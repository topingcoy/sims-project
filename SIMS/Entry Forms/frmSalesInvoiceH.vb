Imports MySql.Data.MySqlClient

Public Class frmSalesInvoiceH
    Private Sub btnAddH_Click(sender As Object, e As EventArgs) Handles btnAddH.Click
        frmSalesInvoiceD.ShowDialog()
    End Sub
    Private Sub frmSalesInvoiceH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            frmSalesInvoiceD.ShowDialog()
            'btnAddH.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmSalesInvoiceH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        'LoadSalesHeader()
        LoadSalesHeaderNew()




    End Sub

    Sub LoadSalesHeader()
        'load to sales header
        Dim i As Integer = 0
        dgvInvoiceList.Rows.Clear()
        cmd = New MySqlCommand("SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                               "ON h.custcode=c.custcode WHERE h.isdeleted<>1 and ttype='S' " & _
                                "ORDER BY transno desc limit 100", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvInvoiceList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("invoiceno").ToString, _
                                    rd.Item("tdate").ToString, rd.Item("custname").ToString, _
                                    rd.Item("slmncode").ToString, rd.Item("whscode").ToString, _
                                    Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), _
                                    Format(CDbl(rd.Item("applied").ToString), "#,##0.00"), _
                                    Format(CDbl(rd.Item("balance").ToString), "#,##0.00"), _
                                    rd.Item("pdate").ToString, rd.Item("user").ToString)

        End While
        rd.Close()
    End Sub

    Sub LoadSalesHeaderPaid()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE h.isdeleted<>1 and ttype='S' " & _
                                    "AND applied<>'0' and totalamt=applied ORDER BY transno desc LIMIT 1000"

            'qry = "SELECT a.*,b.custname from salesh as a, customers as b " & _
            '    "where a.slmncode='" & frmExpressCollD.txtSalesmanCode.Text & "'  " & _
            '    "and a.custcode=b.custcode and (totalamt>applied or applied='0') order by b.custname"

            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Sub LoadSalesHeaderNew()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE h.isdeleted<>1 and ttype='S' " & _
                                    "AND applied>=0 and applied<=totalamt ORDER BY transno desc LIMIT 1000"

            'qry = "SELECT a.*,b.custname from salesh as a, customers as b " & _
            '    "where a.slmncode='" & frmExpressCollD.txtSalesmanCode.Text & "'  " & _
            '    "and a.custcode=b.custcode and (totalamt>applied or applied='0') order by b.custname"

            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With


    End Sub

    'Private Sub btnAddH_Click(sender As Object, e As EventArgs) Handles btnAddH.Click
    '    With frmSalesInvoiceD
    '        .iClear()
    '        .ShowDialog()
    '    End With
    '    'frmSalesInvoiceD.ShowDialog()
    'End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvInvoiceList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmSalesInvoiceD.RetrieveSales(mytrans)
                frmSalesInvoiceD.Tag = 1
                frmSalesInvoiceD.tsSave.Visible = False
                frmSalesInvoiceD.tsUpdate.Visible = True
                frmSalesInvoiceD.btnUpdate.Enabled = False
                frmSalesInvoiceD.btnUpdatePrint.Enabled = False
                frmSalesInvoiceD.Disabler()
                frmSalesInvoiceD.ShowDialog()
            End If
        End With
    End Sub


    Private Sub dgvInvoiceList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceList.CellDoubleClick
        btnEdit_Click(sender, e)
    End Sub

    Private Sub dgvInvoiceList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceList.CellContentClick

        With dgvInvoiceList

            If .RowCount > 0 And e.RowIndex >= 0 Then
                Dim mytrans As String = Nothing
                Dim myinvoice As String = Nothing

                mytrans = .Item(1, e.RowIndex).Value
                myinvoice = .Item(2, e.RowIndex).Value

                If e.ColumnIndex = 11 Then
                    frmSalesInvoiceD.RetrieveSales(mytrans)
                    frmSalesInvoiceD.Tag = 1
                    frmSalesInvoiceD.ShowDialog()

                ElseIf e.ColumnIndex = 12 Then
                    If MsgBox("Are you sure you want to delete this Invoice No: " & myinvoice & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Invoice No : " & mytrans & " successfully deleted", 64, "Deleted")
                        'AuditTrail("Delete Receiving" & mytrans & Space(2) & cbxSupplier.Text, "Receiving Module")
                        LoadSalesHeader()
                    End If
                End If
            End If
        End With

    End Sub

    Private Sub dgvInvoiceList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvInvoiceList.KeyDown
        With dgvInvoiceList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim myinvoice As String = Nothing

                mytrans = .Item(1, .CurrentRow.Index).Value
                myinvoice = .Item(2, .CurrentRow.Index).Value

                'If e.KeyCode = Keys.Enter Then
                '    frmReceivingD.RetrieveRcv(mytrans)
                '    frmReceivingD.Tag = 1
                '    frmReceivingD.ShowDialog()
                'End If

                If e.KeyCode = Keys.F7 Then
                    If MsgBox("Are you sure you want to delete this Invoice No: " & myinvoice & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("UPDATE salesh SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", myinvoice)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", myinvoice)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Invoice No : " & myinvoice & " successfully deleted", 64, "Deleted")
                        LoadSalesHeader()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        With dgvInvoiceList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim myinvoice As String = Nothing
                Dim mybal As String = Nothing

                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                myinvoice = .Item(2, .CurrentCell.RowIndex).Value
                mybal = .Item(9, .CurrentCell.RowIndex).Value

                If MsgBox("Are you sure you want to delete this Invoice No: " & myinvoice & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then

                    If mybal = 0 Then
                        MsgBox("Cannot delete paid transation!", vbExclamation, "Sales Invoice")
                        Exit Sub
                    Else
                        Dim checkopen As String()

                        checkopen = check_if_trans_is_open(mytrans, "salesh", _user)

                        If checkopen(0) = True Then
                            MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before deleting this transaction. ", 48, "TRANSACTION IS OPEN")

                        Else
                            Dim cmd As MySqlCommand
                            cmd = New MySqlCommand("SELECT * FROM salesd WHERE transno=@tr And isdeleted = '0'", cdb)
                            cmd.Parameters.AddWithValue("@tr", mytrans)
                            rd = cmd.ExecuteReader

                            Dim iqty As Decimal = 0
                            Dim ipckg As Decimal = 0
                            Dim iqunit As String = Nothing

                            Dim ingoods As Decimal = 0

                            While rd.Read
                                ReDim Preserve upthisitem(rwuph)
                                With upthisitem(rwuph)
                                    ' MsgBox(rd("item").ToString)
                                    .ihtcd = rd("itemcode").ToString
                                    .ihqty = rd("qty").ToString
                                    .ihpckg = rd("pckg").ToString
                                    .ihqunit = rd("qunit").ToString
                                    .ihwhs = rd("whscode").ToString

                                    iqunit = rd("qunit").ToString
                                    iqty = rd("qty").ToString
                                    ipckg = rd("pckg").ToString

                                    If iqunit = "C" Or iqunit = "B" Then
                                        .ihgoods = iqty * ipckg
                                    ElseIf iqunit = "P" Then
                                        .ihgoods = iqty
                                    End If

                                End With
                                rwuph += 1
                            End While
                            rd.Close()

                            Dim wh As String = Nothing
                            Dim itc As String = Nothing
                            Dim ing As Decimal = 0

                            For x As Integer = 0 To rwuph - 1
                                wh = upthisitem(x).ihwhs
                                itc = upthisitem(x).ihtcd
                                ing = upthisitem(x).ihgoods
                                updwhsheader(wh, itc, ing)
                            Next

                            reset_upthisitem()

                            cmd = New MySqlCommand("UPDATE salesh SET isdeleted=1 WHERE transno=@tr", cdb)
                            cmd.Parameters.AddWithValue("@tr", mytrans)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                            cmd.Parameters.AddWithValue("@tr", mytrans)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            MsgBox("Invoice No: " & myinvoice & " successfully deleted", 64, "Deleted")
                            ' AuditTrail("Trans No.:" & mytrans & Space(2) & "PO. No.:" & tbPONo.Text & Space(2) & "Invoice No.:" & tbInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Delete Receiving Module")
                            'AuditTrail("Trans No.:" & mytrans & Space(2) & .Text, "Delete Receiving Module")
                            'LoadSalesHeader()
                            LoadSalesHeaderNew()
                        End If
                    End If
                End If
                End If

        End With


    End Sub

    Structure upheaderdt
        Dim ihtcd As String
        Dim ihqty As Decimal
        Dim ihpckg As Decimal
        Dim ihqunit As String
        Dim ihwhs As String
        Dim ihgoods As Decimal
    End Structure

    Dim upthisitem() As upheaderdt
    Dim rwuph As Integer = 0

    Private Sub reset_upthisitem()
        'Reset count and array
        rwuph = 0
        Erase upthisitem
    End Sub

    Private Sub updwhsheader(ByVal wh As String, ByVal itc As String, ByVal totpck As Decimal)

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0

        curqty = 0
        nwqty = 0

        cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                curqty = rd("qty_good").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        'If curqty > 0 Then
        '    nwqty = curqty - totpck
        'Else
        '    nwqty = 0
        'End If

        'nwqty = curqty - totpck
        nwqty = curqty + totpck

        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        cmd.Parameters.AddWithValue("@qtyg", nwqty)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'LoadSalesHeader()
        cbxViewPaid.Checked = False
        txtSearch.Clear()
        LoadSalesHeaderNew()

    End Sub

    Sub SearchLoadSalesHeader()
        'load to sales header
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()

            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE (custname like '%" & txtSearch.Text & "%' or " & _
                                   "invoiceno like '%" & txtSearch.Text & "%' ) and  h.isdeleted<>1 and ttype='S' " & _
                                   "AND applied>='0' and applied<totalamt ORDER BY transno desc LIMIT 1000 "
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With

    End Sub

    Sub SearchLoadSalesHeaderPaid()
        'load to sales header
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()

            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE (custname like '%" & txtSearch.Text & "%' or " & _
                                   "invoiceno like '%" & txtSearch.Text & "%' ) and  h.isdeleted<>1 and ttype='S' " & _
                                   "AND applied<>'0' and totalamt=applied ORDER BY transno desc LIMIT 1000"
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If cbxViewPaid.Checked = True Then
            SearchLoadSalesHeaderPaid()
        Else
            SearchLoadSalesHeader()
        End If

        'old process
        'Dim i As Integer = 0
        'dgvInvoiceList.Rows.Clear()
        'cmd = New MySqlCommand("SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
        '                       "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
        '                       "ON h.custcode=c.custcode WHERE (custname like '%" & txtSearch.Text & "%' or " & _
        '                       "invoiceno like '%" & txtSearch.Text & "%' ) and  h.isdeleted<>1 and ttype='S' " & _
        '                       "ORDER BY transno desc", cdb)
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    i += 1
        '    ' dgvInvoiceList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("invoiceno").ToString, rd.Item("idate").ToString, rd.Item("custname").ToString, rd.Item("slmncode").ToString, rd.Item("whscode").ToString, Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), Format(CDbl(rd.Item("balance").ToString), "#,##0.00"), rd.Item("idate").ToString, rd.Item("user").ToString)
        '    dgvInvoiceList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("invoiceno").ToString, _
        '                           rd.Item("idate").ToString, rd.Item("custname").ToString, _
        '                           rd.Item("slmncode").ToString, rd.Item("whscode").ToString, _
        '                           Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), _
        '                           Format(CDbl(rd.Item("applied").ToString), "#,##0.00"), _
        '                           Format(CDbl(rd.Item("balance").ToString), "#,##0.00"), _
        '                           rd.Item("idate").ToString, rd.Item("user").ToString)
        'End While
        'rd.Close()

    End Sub

    Sub LoadSalesHeaderByDateRange()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE tdate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
                                   "and tdate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "'and h.isdeleted<>1 and ttype='S' " & _
                                    "ORDER BY transno desc LIMIT 1000"
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Sub LoadSalesHeaderByDateRangePaid()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE tdate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
                                   "and tdate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' and h.isdeleted<>1 and ttype='S' " & _
                                    "AND totalamt=applied ORDER BY transno desc LIMIT 1000"

            'qry = "SELECT a.*,b.custname from salesh as a, customers as b " & _
            '    "where a.slmncode='" & frmExpressCollD.txtSalesmanCode.Text & "'  " & _
            '    "and a.custcode=b.custcode and (totalamt>applied or applied='0') order by b.custname"

            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If cbxViewPaid.Checked = True Then
            LoadSalesHeaderByDateRangePaid()
        Else
            LoadSalesHeaderByDateRange()
        End If
    End Sub




    Private Sub tsInvoiceList_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsInvoiceList.ItemClicked

    End Sub

    Private Sub cbxViewPaid_CheckedChanged(sender As Object, e As EventArgs) Handles cbxViewPaid.CheckedChanged
        If cbxViewPaid.Checked = True Then
            LoadSalesHeaderPaid()
        Else
            LoadSalesHeaderNew()
        End If
    End Sub
End Class