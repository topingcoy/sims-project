Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing

Public Class frmExpressCollD

    Dim ttype As String = Nothing
    'structurename
    Dim lDuplicate As Boolean = False
    Dim listrmv() As rmvitem
    Dim listupd() As upditem
    Dim listadded() As addnitem
    Dim listrowsadded() As nwaddedrows

    'structure counter
    Dim rwrmv As Integer = 0
    Dim rwupd As Integer = 0
    Dim rwadded As Integer = 0
    Dim rwsnews As Integer = 0

    Dim prevwhse As String = Nothing
    Dim addrwindex As Integer = 0

    Structure nwaddedrows
        Dim c_myrowindex As Integer
    End Structure

    Structure addnitem
        Dim a1pkn As String
        Dim a1rfa As Decimal
        Dim a1rfno As String
    End Structure

    Structure rmvitem
        Dim r1pkn As String
        Dim r1rfa As Decimal
        Dim r1rfno As String
    End Structure

    Structure upditem
        Dim u1pkn As String
        Dim u1rfa As Decimal
        Dim u1rfno As String
        Dim u1rfdate As Date
    End Structure

    Structure upheaderdt
        Dim uhtcd As String
        Dim uhqty As Decimal
    End Structure

    Private Sub reset_listrmv()
        rwrmv = 0
        Erase listrmv
    End Sub

    Private Sub reset_listupd()
        rwupd = 0
        Erase listupd
    End Sub


    Private Sub reset_listadded()
        'Reset person count and array
        rwadded = 0
        rwsnews = 0
        Erase listrowsadded
        Erase listadded
    End Sub
    Private Sub txtSalesmanCode_DoubleClick(sender As Object, e As EventArgs) Handles txtSalesmanCode.DoubleClick
        With frmCollSalesman
            .ShowDialog()
        End With
    End Sub

    Private Sub txtSalesmanCode_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles txtSalesmanCode.GiveFeedback

    End Sub

    Private Sub txtSalesmanCode_HandleDestroyed(sender As Object, e As EventArgs) Handles txtSalesmanCode.HandleDestroyed

    End Sub

    Private Sub txtSalesmanCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesmanCode.KeyPress
        If e.KeyChar = vbCr Then

        End If
    End Sub

    Sub RetrieveExpresD(ByVal trno As String)

        With dgvExpressD
            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0
            .Rows.Clear()

            'retrieve from expresh
            cmd = New MySqlCommand("SELECT h.*,d.*,s.*,c.* FROM expresh h LEFT JOIN expresd d ON h.transno=d.transno " & _
                               "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c  " & _
                               "ON d.custcode=c.custcode WHERE h.isdeleted<>1 AND h.transno=@tno ", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    sDate.Value = rd("edate").ToString
                    txtTransno.Text = rd("transno").ToString
                    txtSalesmanCode.Text = rd("slmncode").ToString
                    txtSalesmanName.Text = rd("slmnname").ToString
                    txtDocno.Text = rd("docno").ToString
                    txtUser.Text = rd("user").ToString
                    txtAmount.Text = Format(Math.Round(Decimal.Parse(rd("totalamt").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                End If
                rd.Close()
            End Using
            cmd.Dispose()

            'retrive from expresd
            cmd = New MySqlCommand("SELECT d.*,h.*,s.*,c.*,sh.totalamt ttam,sh.applied FROM expresh h " & _
                                "LEFT JOIN expresd d ON h.transno=d.transno " & _
                                "LEFT JOIN salesh sh ON d.refno=sh.transno " & _
                                "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c  " & _
                                "ON d.custcode=c.custcode WHERE h.isdeleted<>1 AND h.transno=@tno AND d.isdeleted<>1", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    x = 0
                    Dim totalqty As Decimal = 0
                    While rd.Read
                        .RowCount += 1
                        rw = .RowCount - 1
                        x += 1
                        .Item(0, rw).Value = x
                        .Item(0, rw).Tag = rd("ttam").ToString ' TOTAL AMOUNT SA SALESH
                        .Item(2, rw).Tag = Format(Math.Round(Decimal.Parse(rd("refamt").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD") ' NAHABILIN NGA BAYRONON 
                        .Item(1, rw).Value = rd("reftype").ToString

                        .Item(3, rw).Value = rd("custname").ToString
                        .Item(3, rw).Tag = rd("applied").ToString
                        .Item(4, rw).Value = rd("refdoc").ToString
                        .Item(6, rw).Tag = Decimal.Parse(rd("refamt").ToString)
                        .Item(6, rw).Value = Format(Math.Round(Decimal.Parse(rd("refamt").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(7, rw).Value = rd("bank").ToString
                        .Item(8, rw).Value = rd("checkno").ToString
                        .Item(9, rw).Value = rd("checkdate").ToString
                        .Item(9, rw).Tag = rd("custcode").ToString
                        .Item(10, rw).Value = rd("refno").ToString
                        .Item(11, rw).Value = rd("refdate").ToString
                        .Item(11, rw).Tag = rd("pkno").ToString
                    End While
                    rd.Close()
                End If
            End Using
        End With

    End Sub

    Private Sub txtSalesmanCode_TextChanged(sender As Object, e As EventArgs) Handles txtSalesmanCode.TextChanged

    End Sub

    Private Sub frmExpressCollD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnClose.PerformClick()

        End If
    End Sub

    Private Sub frmExpressCollD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If txtUser.Text = Nothing Then
            txtUser.Text = _user
        End If

        If txtDocno.Text <> Nothing Then
            txtDocnoUpdate.Text = txtDocno.Text
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSalesmanCode.Text <> Nothing Then
            frmCollSearch.ShowDialog()
        End If
        sComTotal()
    End Sub

    Sub sComTotal()
        Dim nTotal As Double = 0
        For i = 0 To dgvExpressD.RowCount - 1
            dgvExpressD.Rows(i).Cells(0).Value = i + 1
            nTotal += dgvExpressD.Rows(i).Cells(6).Value
        Next
        txtAmount.Text = Format(nTotal, sFmat)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Express Collection") = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Sub GetExpressTransNo()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        cqry = "Select transno as tno FROM expresh ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While
            rcvtno = Strings.Right(mdr("tno").ToString, 9) + 1
            rcvtno = "E" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If

        If rcnt = 0 Then
            rcvtno = "E000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        txtTransno.Text = rcvtno
    End Sub

    Function checkDocNo()
        Dim fnd As Boolean = False
        If txtDocno.Text.Trim <> Nothing Then
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT docno FROM expresh WHERE docno = @docno", cdb)
            With cmd
                .Parameters.AddWithValue("@docno", txtDocno.Text.Trim)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows = True Then
                        fnd = True
                    End If
                    rd.Close()
                End Using
            End With
        End If

        Return fnd
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtDocno.Text = Nothing Then
            MsgBox("Doc No is required.", 48, "Enter Doc No.")
            txtDocno.Focus()
            Exit Sub
        End If

        If checkDocNo() = True Then
            MsgBox("Invoice No. already used!.", 48, "Enter Invoice No.")
            txtDocno.Focus()
            Exit Sub
        End If

        With dgvExpressD
            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Exit Sub
            End If

            If .RowCount > 0 Then
                Dim asave As Boolean = True
                For i = 0 To .Rows.Count - 1
                    If .Item(6, i).Value = Nothing Then
                        asave = False
                    End If
                Next

                If asave = True Then
                    .EndEdit(True)
                    GetExpressTransNo()
                    SaveExpressColl()
                    MsgBox("Express Collection has been save successfully", vbInformation)
                    iClear()
                    txtDocno.Focus()
                    With frmExpressCollH
                        .LoadExpressH()
                    End With
                Else
                    MsgBox("Check inputted amount must not be zero", 48, "Check amount")
                End If
            End If

        End With

    End Sub

    Sub iClear()
        txtTransno.Clear()
        txtDocno.Clear()
        sDate.Value = Date.Today
        txtSalesmanCode.Clear()
        txtSalesmanName.Clear()
        txtAmount.Clear()
        dgvExpressD.Rows.Clear()
        txtDocno.Focus()
    End Sub

    Sub SaveExpressColl()
        Dim cmd As MySqlCommand
        Dim i As Integer
        'insert to expresh


        Dim err As String = Nothing
        'insert to expresd
        With dgvExpressD
            For i = 0 To .RowCount - 1
                If .Item(6, i).Value <> Nothing Then

                    Dim rfamount As Decimal = 0

                    'If .Item(6, i).Value < 0 Then
                    '  rfamount = Decimal.Parse(Math.Abs(.Item(6, i).Value))
                    ' Else
                    rfamount = Decimal.Parse(.Item(6, i).Value)
                    'End If


                    Dim sumpay As Decimal = 0
                    Dim sumsales As Decimal = 0

                    cmd = New MySqlCommand("SELECT SUM(if(refamt<0,abs(refamt),refamt)) as suma FROM expresd WHERE refno=@refno AND isdeleted<>1", cdb)
                    cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("suma").ToString <> Nothing Then
                                sumpay = Decimal.Parse(rd("suma").ToString)
                            Else
                                sumpay = 0
                            End If

                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    cmd = New MySqlCommand("SELECT totalamt as toma FROM salesh WHERE transno=@transno", cdb)
                    cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("toma").ToString <> Nothing Then
                                sumsales = Decimal.Parse(rd("toma").ToString)
                            Else
                                sumsales = 0
                            End If

                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    Dim nwamnt As Decimal = 0
                    Dim forfamt As Decimal = 0

                    If rfamount < 0 Then
                        forfamt = Math.Abs(rfamount)
                    Else
                        forfamt = rfamount
                    End If
                    nwamnt = forfamt + sumpay
                    If nwamnt <= sumsales Then
                        ttype = "E"
                        cmd = New MySqlCommand("INSERT INTO expresd (transno,ttype,edate,slmncode,custcode,reftype, " & _
                                         "refno,refamt,refdate,refdoc,bank,checkno,checkdate) " & _
                                         "VALUES (@transno,@ttype,@edate,@slmncode,@custcode,@reftype,@refno, " & _
                                         "@refamt,@refdate,@refdoc,@bank,@checkno,@checkdate)", cdb)
                        cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
                        cmd.Parameters.AddWithValue("@ttype", ttype)
                        cmd.Parameters.AddWithValue("@edate", sDate.Value)
                        cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                        cmd.Parameters.AddWithValue("@custcode", .Item(2, i).Value)
                        cmd.Parameters.AddWithValue("@reftype", .Item(1, i).Value)
                        cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                        cmd.Parameters.AddWithValue("@refamt", rfamount)
                        Dim refdate As Date = .Item(11, i).Value
                        cmd.Parameters.AddWithValue("@refdate", Format(refdate, "yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@refdoc", .Item(4, i).Value)
                        cmd.Parameters.AddWithValue("@bank", .Item(7, i).Value)
                        cmd.Parameters.AddWithValue("@checkno", .Item(8, i).Value)
                        Dim fromdt As Date
                        fromdt = .Item(9, i).Value
                        Dim fdt = fromdt.ToString("yyyy-MM-dd")
                        cmd.Parameters.AddWithValue("@checkdate", fdt)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Else
                        err = "Amount must be less than or equal the required amount of sales"
                    End If

                    '   If .Item(6, i).Value > 0 Then

                    'End If
                End If
            Next
        End With

        'update to salesh (applied)

        With dgvExpressD
            For i = 0 To .RowCount - 1
                If .Item(6, i).Value <> Nothing Then
                    ' If .Item(6, i).Value > 0 Then


                    Dim rfamount As Decimal = 0
                    Dim apamount As Decimal = 0
                    Dim nwamount As Decimal = 0

                    'apamount = Decimal.Parse(.Item(3, i).Tag)
                    If .Item(6, i).Value < 0 Then
                        rfamount = .Item(6, i).Value
                        rfamount = Math.Abs(rfamount)
                    Else
                        rfamount = Decimal.Parse(.Item(6, i).Value)
                    End If

                    'If apamount > 0 Then
                    '    nwamount = rfamount + apamount
                    'Else
                    '    nwamount = rfamount
                    'End If

                    Dim sumpay As Decimal = 0
                    Dim sumsales As Decimal = 0

                    cmd = New MySqlCommand("SELECT SUM(if(refamt<0,abs(refamt),refamt)) as suma FROM expresd WHERE refno=@refno AND isdeleted<>1", cdb)
                    cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("suma").ToString <> Nothing Then
                                sumpay = Decimal.Parse(rd("suma").ToString)
                            Else
                                sumpay = 0
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()


                    cmd = New MySqlCommand("SELECT totalamt as toma FROM salesh WHERE transno=@transno", cdb)
                    cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("toma").ToString <> Nothing Then
                                sumsales = Decimal.Parse(rd("toma").ToString)
                            Else
                                sumsales = 0
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    If rfamount <= sumpay And rfamount <= sumsales Then
                        If sumpay > 0 Then
                            nwamount = sumpay
                        Else
                            nwamount = rfamount
                        End If

                        If nwamount <= sumsales Then
                            cmd = New MySqlCommand("UPDATE salesh SET applied = @applied, pdate=@pdate  WHERE transno=@transno", cdb)
                            'cmd = New MySqlCommand("UPDATE salesh SET applied = @applied WHERE transno=@transno and pdate=@pdate", cdb)
                            cmd.Parameters.AddWithValue("@applied", nwamount)
                            Dim fromdt As Date
                            fromdt = .Item(9, i).Value
                            Dim fdt = fromdt.ToString("yyyy-MM-dd")
                            cmd.Parameters.AddWithValue("@pdate", fdt)
                            ' cmd.Parameters.AddWithValue("@pdate", .Item(9, i).Value)
                            cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
                            .Item(3, i).Tag = nwamount
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        Else
                            .Item(3, i).Tag = sumsales - sumpay
                            err = "Amount must be less than or equal the required amount of sales"
                        End If
                    Else
                        .Item(3, i).Tag = sumsales - sumpay
                        err = "Amount must be less than or equal the required amount of sales"
                    End If


                    'End If
                End If
            Next
        End With

        'update to salesh (pdate)
        'With dgvExpressD
        '    For i = 0 To .RowCount - 1
        '        If .Item(9, i).Value <> Nothing Then
        '            cmd = New MySqlCommand("UPDATE salesh SET pdate = @pdate WHERE transno=@transno", cdb)
        '            cmd.Parameters.AddWithValue("@pdate", .Item(9, i).Value)
        '            cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
        '            cmd.ExecuteNonQuery()
        '            cmd.Dispose()
        '        End If
        '    Next
        'End With
        If err <> Nothing Then
            MsgBox(err, 48, "Error Saving")
        Else
            ttype = "E"
            cmd = New MySqlCommand("INSERT INTO expresh (transno,ttype,edate,slmncode,docno,totalamt,user) " & _
                                  "VALUES (@tno,@ttype,@edate,@slmncode,@docno,@totalamt,@user)", cdb)
            With cmd
                cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
                cmd.Parameters.AddWithValue("@ttype", ttype)
                cmd.Parameters.AddWithValue("@edate", sDate.Value)
                cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                cmd.Parameters.AddWithValue("@docno", txtDocno.Text)
                cmd.Parameters.AddWithValue("@totalamt", Decimal.Parse(txtAmount.Text))
                cmd.Parameters.AddWithValue("@user", txtUser.Text)
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'MsgBox("Express collection successfully updated!", 64, "Updated")
        End If

    End Sub

    Sub UpdateExpressColl()

        'update to expressh

        Dim cmd As MySqlCommand

      

        Dim err As String = Nothing
        Dim i As Integer
        With dgvExpressD
            .EndEdit(True)
            For i = 0 To .RowCount - 1
                If .Item(6, i).Value <> Nothing Then


                    Dim rfamount As Decimal = 0
                    Dim pkn As String = Nothing

                    pkn = .Item(11, i).Tag
                    rfamount = Decimal.Parse(.Item(6, i).Value)

                    '   If .Item(6, i).Value > 0 Then
                    Dim fnd As Boolean = False

                    cmd = New MySqlCommand("SELECT refamt FROM expresd WHERE pkno=@pkn AND isdeleted<>1", cdb)
                    cmd.Parameters.AddWithValue("@pkn", .Item(11, i).Tag)
                    Using rd As MySqlDataReader = cmd.ExecuteReader
                        If rd.HasRows Then
                            fnd = True
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    'CHECK PREVIOUS AMOUNT
                    Dim prvamt As Decimal = 0
                    cmd = New MySqlCommand("SELECT refamt prevamt FROM expresd WHERE pkno=@pkn  AND isdeleted<>1", cdb)
                    cmd.Parameters.AddWithValue("@pkn", .Item(11, i).Tag)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()

                            prvamt = rd("prevamt").ToString
                            If prvamt < 0 Then
                                prvamt = Math.Abs(prvamt)
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    'SUM OF PAY
                    Dim sumpay As Decimal = 0
                    Dim sumsales As Decimal = 0

                    cmd = New MySqlCommand("SELECT SUM(if(refamt<0,abs(refamt),refamt)) as suma FROM expresd WHERE refno=@refno  AND isdeleted<>1", cdb)
                    cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("suma").ToString <> Nothing Then
                                sumpay = Decimal.Parse(rd("suma").ToString)
                            Else
                                sumpay = 0
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    cmd = New MySqlCommand("SELECT totalamt as toma FROM salesh WHERE transno=@transno", cdb)
                    cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("toma").ToString <> Nothing Then
                                sumsales = Decimal.Parse(rd("toma").ToString)
                            Else
                                sumsales = 0
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    Dim nwamnt As Decimal = 0
                    Dim refnmt As Decimal = 0

                    refnmt = sumpay - prvamt

                    If Me.Tag = 1 Then
                        'If sumpay < rfamount Then
                        '    nwamnt = rfamount - sumpay
                        'ElseIf sumpay > rfamount Then
                        '    nwamnt = sumpay - rfamount
                        'Else
                        '    nwamnt = rfamount + sumpay
                        'End If
                        nwamnt = refnmt + rfamount


                    End If
                    ttype = "E"
                    If nwamnt <= sumsales Then

                        If fnd = True Then
                            cmd = New MySqlCommand("UPDATE expresd SET transno=@transno,ttype=@ttype,edate=@edate,slmncode=@slmncode,custcode=@custcode, " & _
                                               "reftype=@reftype, refno=@refno,refamt=@refamt,refdate=@refdate,refdoc=@refdoc, " & _
                                               "bank=@bank,checkno=@checkno,checkdate=@checkdate WHERE pkno=@pk  AND isdeleted<>1", cdb)
                            cmd.Parameters.AddWithValue("@pk", pkn)
                            cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
                            cmd.Parameters.AddWithValue("@ttype", ttype)
                            cmd.Parameters.AddWithValue("@edate", sDate.Value)
                            cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                            cmd.Parameters.AddWithValue("@custcode", .Item(9, i).Tag)
                            cmd.Parameters.AddWithValue("@reftype", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                            cmd.Parameters.AddWithValue("@refamt", rfamount)
                            Dim refdate As Date = .Item(11, i).Value
                            cmd.Parameters.AddWithValue("@refdate", Format(refdate, "yyyy-MM-dd"))
                            cmd.Parameters.AddWithValue("@refdoc", .Item(4, i).Value)
                            cmd.Parameters.AddWithValue("@bank", .Item(7, i).Value)
                            cmd.Parameters.AddWithValue("@checkno", .Item(8, i).Value)
                            Dim fromdt As Date
                            fromdt = .Item(9, i).Value
                            Dim fdt = fromdt.ToString("yyyy-MM-dd")
                            cmd.Parameters.AddWithValue("@checkdate", fdt)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        Else
                            If sumsales > sumpay Then
                                cmd = New MySqlCommand("INSERT INTO expresd (transno,ttype,edate,slmncode,custcode,reftype, " & _
                                             "refno,refamt,refdate,refdoc,bank,checkno,checkdate) " & _
                                             "VALUES (@transno,@ttype,@edate,@slmncode,@custcode,@reftype,@refno, " & _
                                             "@refamt,@refdate,@refdoc,@bank,@checkno,@checkdate)", cdb)
                                cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
                                cmd.Parameters.AddWithValue("@ttype", ttype)
                                cmd.Parameters.AddWithValue("@edate", sDate.Value)
                                cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                                cmd.Parameters.AddWithValue("@custcode", .Item(2, i).Value)

                                cmd.Parameters.AddWithValue("@reftype", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                                cmd.Parameters.AddWithValue("@refamt", rfamount)
                                Dim refdate As Date = .Item(11, i).Value
                                cmd.Parameters.AddWithValue("@refdate", Format(refdate, "yyyy-MM-dd"))
                                cmd.Parameters.AddWithValue("@refdoc", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@bank", .Item(7, i).Value)
                                cmd.Parameters.AddWithValue("@checkno", .Item(8, i).Value)
                                Dim fromdt As Date
                                fromdt = IIf(.Item(9, i).Value = Nothing, DBNull.Value, .Item(9, i).Value)
                                Dim fdt = fromdt.ToString("yyyy-MM-dd")
                                cmd.Parameters.AddWithValue("@checkdate", fdt)
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()
                            End If

                        End If
                    Else
                        If (sumsales - sumpay) > 0 Then
                            .Item(6, i).Tag = sumsales - sumpay
                        Else
                            .Item(6, i).Tag = prvamt
                        End If

                        err = "Amount must be less than or equal the required amount of sales"

                    End If




                    'End If
                End If
            Next
        End With

        'update to salesh (applied)
        With dgvExpressD
            For i = 0 To .RowCount - 1
                If .Item(6, i).Value <> Nothing Then
                    'If .Item(6, i).Value > 0 Then


                    Dim rfamount As Decimal = 0
                    Dim apamount As Decimal = 0
                    Dim nwamount As Decimal = 0
                    Dim difamount As Decimal = 0
                    Dim odamount As Decimal = 0
                    apamount = Decimal.Parse(.Item(3, i).Tag)
                    ' rfamount = Decimal.Parse(.Item(6, i).Value)
                    If .Item(6, i).Value < 0 Then
                        rfamount = .Item(6, i).Value
                        rfamount = Math.Abs(rfamount)
                    Else
                        rfamount = Decimal.Parse(.Item(6, i).Value)
                    End If

                    odamount = Decimal.Parse(.Item(0, i).Tag)
                    'If odamount > 0 Then
                    '    If rfamount = odamount Then
                    '        nwamount = rfamount
                    '        difamount = odamount - rfamount
                    '        nwamount = apamount - difamount
                    '    ElseIf rfamount > odamount Then
                    '        difamount = rfamount - odamount
                    '        nwamount = difamount + apamount
                    '    ElseIf rfamount < odamount Then
                    '        difamount = odamount - rfamount
                    '        nwamount = apamount - difamount
                    '    End If

                    'Else

                    '    nwamount = rfamount
                    'End If

                    'SUM OF PAY
                    Dim sumpay As Decimal = 0
                    Dim sumsales As Decimal = 0

                    cmd = New MySqlCommand("SELECT SUM(if(refamt<0,abs(refamt),refamt)) as suma FROM expresd WHERE refno=@refno  AND isdeleted<>1", cdb)
                    cmd.Parameters.AddWithValue("@refno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("suma").ToString <> Nothing Then
                                sumpay = Decimal.Parse(rd("suma").ToString)
                            Else
                                sumpay = 0
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()


                    cmd = New MySqlCommand("SELECT totalamt as toma FROM salesh WHERE transno=@transno", cdb)
                    cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
                    Using rd As MySqlDataReader = cmd.ExecuteReader

                        If rd.HasRows Then
                            rd.Read()
                            If rd("toma").ToString <> Nothing Then
                                sumsales = Decimal.Parse(rd("toma").ToString)
                            Else
                                sumsales = 0
                            End If
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()


                    If rfamount <= sumpay And rfamount <= sumsales Then

                        If sumpay > 0 Then
                            nwamount = sumpay
                        Else
                            nwamount = rfamount
                        End If

                        If nwamount <= sumsales Then
                            cmd = New MySqlCommand("UPDATE salesh SET applied = @applied, pdate=@pdate  WHERE transno=@transno", cdb)
                            'cmd = New MySqlCommand("UPDATE salesh SET applied = @applied WHERE transno=@transno and pdate=@pdate", cdb)
                            cmd.Parameters.AddWithValue("@applied", nwamount)
                            Dim refdate As Date = .Item(9, i).Value
                            cmd.Parameters.AddWithValue("@pdate", Format(refdate, "yyyy-MM-dd"))
                            ' cmd.Parameters.AddWithValue("@pdate", fromdt)
                            cmd.Parameters.AddWithValue("@transno", .Item(10, i).Value)
                            .Item(3, i).Tag = nwamount
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        Else
                            .Item(6, i).Tag = sumsales - sumpay
                            err = "Amount must be less than or equal the required amount of sales"
                        End If
                    Else
                        .Item(6, i).Tag = sumsales - sumpay
                        err = "Amount must be less than or equal the required amount of sales"
                    End If


                    'End If
                End If
            Next
        End With
        If err <> Nothing Then
            MsgBox(err, 48, "Error Saving")
        Else
            ttype = "E"

            cmd = New MySqlCommand("UPDATE expresh SET ttype=@ttype,edate=@edate,slmncode=@slmncode,docno=@docno," & _
                                   "totalamt=@totalamt,user=@user " & _
                                   "WHERE transno=@tno", cdb)
            With cmd

                cmd.Parameters.AddWithValue("@ttype", ttype)
                cmd.Parameters.AddWithValue("@edate", sDate.Value)
                cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                cmd.Parameters.AddWithValue("@docno", txtDocno.Text)
                cmd.Parameters.AddWithValue("@totalamt", Decimal.Parse(txtAmount.Text))
                cmd.Parameters.AddWithValue("@user", txtUser.Text)
                cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
            End With
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'UPDATE REMOVELIST
            For x As Integer = 0 To rwrmv - 1
                Dim pkn As String = Nothing
                Dim rfn As String = Nothing
                Dim rfa As Decimal = 0

                pkn = listrmv(x).r1pkn
                rfn = listrmv(x).r1rfno
                rfa = listrmv(x).r1rfa

                If rfa < 0 Then
                    rfa = Math.Abs(rfa)
                End If

                cmd = New MySqlCommand("UPDATE expresd SET isdeleted=1 WHERE pkno=@pk  ", cdb)
                cmd.Parameters.AddWithValue("@pk", pkn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                Dim apmt As Decimal = 0
                cmd = New MySqlCommand("SELECT applied as app FROM salesh WHERE transno=@transno", cdb)
                cmd.Parameters.AddWithValue("@transno", rfn)
                Using rd As MySqlDataReader = cmd.ExecuteReader

                    If rd.HasRows Then
                        rd.Read()
                        If rd("app").ToString <> Nothing Then
                            apmt = Decimal.Parse(rd("app").ToString)
                        Else
                            apmt = 0
                        End If
                    End If
                    rd.Close()
                End Using
                cmd.Dispose()

                Dim nwamt As Decimal = 0
                nwamt = apmt - rfa

                If nwamt > 0 Then
                    cmd = New MySqlCommand("UPDATE salesh SET applied = @applied  WHERE transno=@transno", cdb)
                    cmd.Parameters.AddWithValue("@applied", nwamt)
                    cmd.Parameters.AddWithValue("@transno", rfn)
                Else
                    cmd = New MySqlCommand("UPDATE salesh SET applied = @applied, pdate=NULL  WHERE transno=@transno", cdb)
                    cmd.Parameters.AddWithValue("@applied", nwamt)
                    cmd.Parameters.AddWithValue("@transno", rfn)
                End If
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next

            reset_listrmv()
            frmExpressCollH.LoadExpressH()
            MsgBox("Express collection successfully updated!", 64, "Updated")
            'iClear()
            'Me.Dispose()

        End If
    End Sub

    Private Sub tbnumonly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnumonly.KeyPress
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 48 Or e.KeyChar = "-" Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then e.Handled = True
    End Sub

    Private Sub dgvExpressD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpressD.CellClick
        If Not e.RowIndex = -1 Then
            'Apply on column index in which you want to display DatetimePicker.
            'For this example it is 2.
            If e.ColumnIndex = 9 Then
                'Initialize the dateTimePicker1.
                dtpicker1 = New DateTimePicker()
                'Adding the dateTimePicker1 into DataGridView.
                dgvExpressD.Controls.Add(dtpicker1)
                ' Setting the format i.e. mm/dd/yyyy)
                dtpicker1.Format = DateTimePickerFormat.Short
                ' Create retangular area that represents the display area for a cell.
                Dim oRectangle As Rectangle = dgvExpressD.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                ' Setting area for dateTimePicker1.
                dtpicker1.Size = New Size(oRectangle.Width, oRectangle.Height)
                ' Setting location for dateTimePicker1.
                dtpicker1.Location = New Point(oRectangle.X, oRectangle.Y)
                ' An event attached to dateTimePicker1 which is fired when any date is selected.
                AddHandler dtpicker1.TextChanged, AddressOf DateTimePickerChange
                ' An event attached to dateTimePicker1 which is fired when DateTimeControl is closed.
                AddHandler dtpicker1.CloseUp, AddressOf DateTimePickerClose
            End If
        End If
    End Sub

    Private Sub dgvExpressD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpressD.CellContentClick

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If Me.Tag = 1 Then
            Dim c As Integer = 0
            If MsgBox("Are you sure you want to delete this express collection?", 4 + 32, "Delete?") = 7 Then
                c = 1
            Else
                Dim pkn As String = Nothing
                Dim rfa As Decimal = 0
                Dim rfno As String = Nothing
                With dgvExpressD
                    ReDim Preserve listrmv(rwrmv)
                    listrmv(rwrmv).r1pkn = .Item(11, .CurrentRow.Index).Tag
                    listrmv(rwrmv).r1rfa = .Item(6, .CurrentRow.Index).Value
                    listrmv(rwrmv).r1rfno = .Item(10, .CurrentRow.Index).Value
                    dgvExpressD.Rows.Remove(dgvExpressD.Rows(dgvExpressD.CurrentRow.Index))
                    rwrmv += 1
                End With

            End If
        Else
            dgvExpressD.Rows.Remove(dgvExpressD.Rows(dgvExpressD.CurrentRow.Index))
        End If
        sComTotal()
    End Sub

    Private Sub dgvExpressD_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpressD.CellEndEdit

        'dgvExpressD.Columns(6).DefaultCellStyle.Format = "##.###.00"

        With dgvExpressD
            If .RowCount > 0 Then
                If e.ColumnIndex = 6 Then
                    Dim inputval As Decimal = 0
                    Dim ttyp As String = Nothing
                    If .Item(6, e.RowIndex).Value <> Nothing Then
                        inputval = Decimal.Parse(.Item(6, e.RowIndex).Value)
                    End If

                    Dim cpamt As Decimal = 0

                    If Me.Tag = 1 Then

                        Dim tota As Decimal = 0
                        Dim aped As Decimal = 0
                        Dim prvamnt As Decimal = 0

                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("SELECT refamt FROM expresd WHERE pkno=@refno  AND isdeleted<>1", cdb)
                        cmd.Parameters.AddWithValue("@refno", .Item(11, e.RowIndex).Tag)
                        Using rd As MySqlDataReader = cmd.ExecuteReader

                            If rd.HasRows Then
                                rd.Read()
                                If Not IsDBNull(rd("refamt").ToString) Then
                                    If rd("refamt").ToString <> Nothing Then
                                        prvamnt = Decimal.Parse(rd("refamt").ToString)
                                    Else
                                        prvamnt = 0
                                    End If
                                Else
                                    prvamnt = 0
                                End If
                            Else
                                prvamnt = .Item(0, e.RowIndex).Tag
                            End If
                            rd.Close()
                        End Using
                        cmd.Dispose()

                        cmd = New MySqlCommand("SELECT totalamt,applied,ttype FROM salesh WHERE transno=@refno", cdb)
                        cmd.Parameters.AddWithValue("@refno", .Item(10, e.RowIndex).Value)
                        Using rd As MySqlDataReader = cmd.ExecuteReader

                            If rd.HasRows Then
                                rd.Read()

                                tota = Decimal.Parse(rd("totalamt").ToString)
                                aped = Decimal.Parse(rd("applied").ToString)
                                ttyp = rd("ttype").ToString
                                If ttyp = "R" Then
                                    If prvamnt < 0 Then
                                        prvamnt = Math.Abs(prvamnt)
                                    End If
                                End If
                                cpamt = tota - (aped - prvamnt)
                            End If
                            rd.Close()
                        End Using
                        cmd.Dispose()
                    Else
                        cmd = New MySqlCommand("SELECT totalamt,applied,ttype FROM salesh WHERE transno=@refno", cdb)
                        cmd.Parameters.AddWithValue("@refno", .Item(10, e.RowIndex).Value)
                        Using rd As MySqlDataReader = cmd.ExecuteReader

                            If rd.HasRows Then
                                rd.Read()
                                ttyp = rd("ttype").ToString
                            End If
                            rd.Close()
                        End Using
                        cmd.Dispose()
                        cpamt = .Item(0, e.RowIndex).Tag
                    End If

                    'If inputval <= 0 Then 'dili pwede 0 or negative

                    '    MsgBox("Amount must be greater than zero!", 48, "Greater than zero")

                    '    If Me.Tag = 1 Then
                    '        .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                    '    Else
                    '        .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                    '    End If

                    '    .BeginEdit(True)
                    '    Exit Sub
                    'End If

                    If ttyp = "R" Then

                        If inputval > 0 Then
                            MsgBox("Amount entered must be less than the total amount!", 48, "Must be less than the total amount")
                            If Me.Tag = 1 Then
                                .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                            Else
                                .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                            End If

                            Exit Sub
                        Else
                            ' inputval = Math.Abs(inputval)
                            'cpamt = Math.Abs(cpamt)
                        End If
                        If inputval <= cpamt Then 'dili pwede more than ang amount SA SALESH
                            If ttyp = "R" Then
                                cpamt = cpamt * -1
                                If inputval <= cpamt Then
                                    MsgBox("Amount entered must be less than the total amount!", 48, "Must be less than the total amount")
                                    If Me.Tag = 1 Then
                                        .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                                    Else
                                        .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                                    End If

                                    .BeginEdit(True)
                                    Exit Sub
                                End If

                            Else
                                MsgBox("Amount entered must be less than the total amount!", 48, "Must be less than the total amount")
                                If Me.Tag = 1 Then
                                    .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                                Else
                                    .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                                End If

                                .BeginEdit(True)
                                Exit Sub
                            End If

                        End If

                        If inputval <= cpamt Then 'dili pwede more than ang amount sa Nahabilin nga bayronon

                            MsgBox("Amount entered must be equal or less than the remaining amount!", 48, "Must be equal or less than the remaining amount")

                            If Me.Tag = 1 Then
                                .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                            Else
                                .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                            End If

                            .BeginEdit(True)
                            Exit Sub
                        End If
                    Else
                        If inputval <= 0 Then
                            MsgBox("Amount entered must not be less than or equal to zero ", 48, "Must not be less than or equal to zero")
                            If Me.Tag = 1 Then
                                .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                            Else
                                .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                            End If

                            .BeginEdit(True)
                            Exit Sub
                        End If
                        If inputval > cpamt Then 'dili pwede more than ang amount SA SALESH

                            MsgBox("Amount entered must be less than the total amount!", 48, "Must be less than the total amount")
                            If Me.Tag = 1 Then
                                .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                            Else
                                .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                            End If

                            .BeginEdit(True)
                            Exit Sub
                        End If

                        If inputval > cpamt Then 'dili pwede more than ang amount sa Nahabilin nga bayronon

                            MsgBox("Amount entered must be equal or less than the remaining amount!", 48, "Must be equal or less than the remaining amount")

                            If Me.Tag = 1 Then
                                .Item(6, e.RowIndex).Value = Format(.Item(6, e.RowIndex).Tag, "STANDARD")
                            Else
                                .Item(6, e.RowIndex).Value = Format(.Item(0, e.RowIndex).Tag, "STANDARD")
                            End If

                            .BeginEdit(True)
                            Exit Sub

                        End If
                    End If

                    .Item(6, e.RowIndex).Value = Format(inputval, "STANDARD")


                    '.Item(7, e.RowIndex).Value = Strings.UCase(.Item(7, e.RowIndex).Value)
                    '.Item(8, e.RowIndex).Value = Strings.UCase(.Item(8, e.RowIndex).Value)

                ElseIf e.ColumnIndex = 7 Then
                    .Item(7, e.RowIndex).Value = Strings.UCase(.Item(7, e.RowIndex).Value)
                ElseIf e.ColumnIndex = 8 Then
                    .Item(8, e.RowIndex).Value = Strings.UCase(.Item(8, e.RowIndex).Value)
                End If
            End If

        End With

        sComTotal()

    End Sub

    Private Sub dgvExpressD_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvExpressD.EditingControlShowing
        With dgvExpressD
            If .RowCount > 0 Then
                If .CurrentCell.ColumnIndex = 6 Then
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
                Else
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
                End If
            End If
        End With

    End Sub

    Private Sub dgvExpressD_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvExpressD.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True
        '    Dim iCol = dgvExpressD.CurrentCell.ColumnIndex
        '    Dim iRow = dgvExpressD.CurrentCell.RowIndex
        '    If iCol = dgvExpressD.Columns.Count - 1 Then
        '        If iRow < dgvExpressD.Rows.Count - 1 Then
        '            dgvExpressD.CurrentCell = dgvExpressD(0, iRow + 1)
        '        End If
        '    Else
        '        If iCol >= dgvExpressD.Columns.Count - 2 Then
        '            If iRow < dgvExpressD.RowCount - 1 Then
        '                dgvExpressD.CurrentCell = dgvExpressD(0, iRow + 1)
        '            Else
        '                dgvExpressD.CurrentCell = dgvExpressD(0, iRow)
        '            End If
        '        Else
        '            dgvExpressD.CurrentCell = dgvExpressD(iCol + 1, iRow)
        '        End If
        '    End If
        '    If iCol = 6 Then
        '        sComTotal()
        '    End If
        'ElseIf e.KeyCode = Keys.Delete Then
        '    If dgvPayment.CurrentCell.ColumnIndex = 1 Then
        '        dgvPayment.Rows(dgvPayment.CurrentRow.Index).Cells(1).Value = Nothing
        '    ElseIf dgvPayment.CurrentCell.ColumnIndex = 2 Then
        '        dgvPayment.Rows(dgvPayment.CurrentRow.Index).Cells(2).Value = Nothing
        '    End If
        '    sCompPay()
        'End If
    End Sub

    Private Sub DateTimePickerChange(ByVal sender As Object, ByVal e As EventArgs)
        dgvExpressD.CurrentCell.Value = dtpicker1.Text.ToString()
        ' MessageBox.Show(String.Format("Date changed to {0}", dtpicker1.Text.ToString()))
    End Sub

    Private Sub DateTimePickerClose(ByVal sender As Object, ByVal e As EventArgs)
        dtpicker1.Visible = False
    End Sub

    'Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
    'For Each row As DataGridViewRow In dgvExpressD.Rows
    '    MessageBox.Show(String.Format("Selected Date for {0} is {1}", row.Cells(1).Value, Convert.ToDateTime(row.Cells(2).Value).ToShortDateString()))
    'Next
    'End Sub

    Private Sub tbnumonly_TextChanged(sender As Object, e As EventArgs) Handles tbnumonly.TextChanged

    End Sub

    Private Sub dgvExpressD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvExpressD.KeyPress
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then e.Handled = True
    End Sub

    Private Sub btnCloseU_Click(sender As Object, e As EventArgs) Handles btnCloseU.Click
        If MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Express Collection") = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnUpdate.Enabled = False Then
            btnUpdate.Enabled = True
            btnUpdatePrint.Enabled = True
            dgvExpressD.Enabled = True
            btnEdit.Enabled = False
        ElseIf btnUpdate.Enabled = True Then


        End If
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
       

        If txtDocno.Text <> txtDocnoUpdate.Text Then
            If checkDocNo() = True Then
                MsgBox("Docno No. already used!.", 48, "Enter Invoice No.")
                txtDocno.Focus()
                Exit Sub
            End If
        End If


        With dgvExpressD


            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Exit Sub
            End If

            If .RowCount > 0 Then
                Dim aupdate As Boolean = True
                For i = 0 To .Rows.Count - 1
                    If .Item(6, i).Value = Nothing Then
                        aupdate = False
                    End If
                Next

                If aupdate = True Then
                    .EndEdit(True)
                    UpdateExpressColl()

                    dgvExpressD.Enabled = False
                    btnUpdate.Enabled = False
                    btnUpdatePrint.Enabled = False
                    btnEdit.Enabled = True

                    
                    With frmExpressCollH
                        .LoadExpressH()
                    End With
                    Me.Dispose()

                Else
                    MsgBox("Check inputted amount must not be zero", 48, "Check amount")
                End If
            End If

        End With
    End Sub

    Private Sub btnUpdatePrint_Click(sender As Object, e As EventArgs) Handles btnUpdatePrint.Click
    
        If txtDocno.Text <> txtDocnoUpdate.Text Then
            If checkDocNo() = True Then
                MsgBox("Docno No. already used!.", 48, "Enter Invoice No.")
                txtDocno.Focus()
                Exit Sub
            End If
        End If
        With dgvExpressD


            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Exit Sub
            End If

            If .RowCount > 0 Then
                Dim aupdate As Boolean = True
                For i = 0 To .Rows.Count - 1
                    If .Item(6, i).Value = Nothing Then
                        aupdate = False
                    End If
                Next

                If aupdate = True Then
                    .EndEdit(True)
                    UpdateExpressColl()

                    dgvExpressD.Enabled = False
                    btnUpdate.Enabled = False
                    btnUpdatePrint.Enabled = False
                    btnEdit.Enabled = True


                    With frmExpressCollH
                        .LoadExpressH()
                    End With
                    PrintExpressColl()
                    frmReport.BringToFront()
                    ' Me.Close()

                Else
                    MsgBox("Check inputted amount must not be zero", 48, "Check amount")
                End If
            End If

        End With


    End Sub

    Sub eClear()
        dgvExpressD.Rows.Clear()
        txtDocno.Clear()
        txtTransno.Clear()
        txtSalesmanCode.Clear()
        txtSalesmanName.Clear()
        txtAmount.Clear()
        txtDocno.Focus()
    End Sub

    Private Sub tsSave_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsSave.ItemClicked

    End Sub

    Private Sub tsUpdate_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsUpdate.ItemClicked

    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If txtDocno.Text = Nothing Then
            MsgBox("Doc No is required.", 48, "Enter Doc No.")
            txtDocno.Focus()
            Exit Sub
        End If

        If checkDocNo() = True Then
            MsgBox("Invoice No. already used!.", 48, "Enter Invoice No.")
            txtDocno.Focus()
            Exit Sub
        End If

        With dgvExpressD
            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Exit Sub
            End If

            If .RowCount > 0 Then
                Dim asave As Boolean = True
                For i = 0 To .Rows.Count - 1
                    If .Item(6, i).Value = Nothing Then
                        asave = False
                    End If
                Next

                If asave = True Then
                    .EndEdit(True)
                    GetExpressTransNo()
                    SaveExpressColl()
                    MsgBox("Express Collection has been save successfully", vbInformation)
                    PrintExpressColl()
                    ' iClear()
                    ' txtDocno.Focus()
                    With frmExpressCollH
                        .LoadExpressH()
                    End With
                Else
                    MsgBox("Check inputted amount must not be zero", 48, "Check amount")
                End If
            End If

        End With

    End Sub

    Sub PrintExpressColl()
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvExpressD
            mmax = .RowCount
            pbar1.Maximum = mmax

            dt.Rows.Clear()
            Dim chkflag As Boolean = False
            'grpno = 10
            grpno = 29
            Dim cntr As Integer = 0
            Dim grid As Integer = 1

            If .RowCount > 0 Then
                'pbar1.Visible = True
                'pbar1.Maximum = .RowCount
                'pbar1.Value = 0
                .EndEdit()
                Dim prep As New ReportDocument
                Dim ds As New DataSet1
                Dim dt As DataTable = ds.Tables("dtExpressColl")
                Dim r1 As DataRow
                dt.Rows.Clear()
                '  Dim chkflag As Boolean = False
                grpno = 29
                ' grpno = 29
                '   Dim cntr As Integer = 0
                '  Dim grid As Integer = 1

                For i = 0 To .RowCount - 1
                    'pbar1.Value += 1
                    'pbar1.Refresh()
                    ' r1 = dt.NewRow()
                    pbar1.Value += 1
                    'If .Item(0, i).Value <> Nothing And .Item(1, i).Value <> Nothing Then
                    '    cntr += 1
                    If .Item(3, i).Value <> Nothing Then
                        r1 = dt.NewRow()

                        r1("edate") = sDate.Value
                        r1("docno") = txtDocno.Text
                        ' r1("slmncode") = txtSalesmanCode.Text
                        r1("slmnname") = txtSalesmanName.Text
                        r1("user") = txtUser.Text
                        r1("transno") = txtTransno.Text
                        r1("type") = .Item(1, i).Value
                        r1("custname") = .Item(3, i).Value
                        r1("refno") = .Item(4, i).Value
                        r1("refamt") = Format(.Item(6, i).Value, "STANDARD")
                        r1("bank") = .Item(7, i).Value
                        r1("checkno") = .Item(8, i).Value
                        Dim chkdate As Date = .Item(9, i).Value
                        r1("checkdate") = Format(chkdate, "MM/dd/yyyy") '.Item(9, i).Value
                        r1("totalamt") = Format(txtAmount.Text, "STANDARD")
                        r1("grpno") = grid
                        pbar1.Refresh()
                        dt.Rows.Add(r1)
                        If cntr = grpno Then
                            grid += 1
                            cntr = 0
                        End If
                    End If

                Next
                'pbar1.Visible = False
                prep = New rptExpresColl
                prep.SetDataSource(ds)
                frmReport.CRportRcv.ReportSource = prep
                frmReport.CRportRcv.Refresh()
                frmReport.Dock = DockStyle.Fill
                frmReport.Show()
                pbar1.Visible = False
            Else
                MsgBox("No records found to print!", 48, "Insufficient Rows!")
            End If
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintExpressColl()
    End Sub
End Class