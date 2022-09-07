Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data
Imports System.Text
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Linq
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing


Public Class frmPhysicalD

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

    Dim ttype As String = Nothing
    Dim addrwindex As Integer = 0

    Structure nwaddedrows
        Dim c_myrowindex As Integer
    End Structure

    Structure addnitem
        Dim c5additem As String
        Dim c5addqty As Decimal
        Dim c5addpckg As String
        Dim c5addpkno As Decimal
        Dim c5addtransno As String
    End Structure

    Structure rmvitem
        Dim c1item As String
        Dim c1qty As Decimal
        Dim c1unit As String
        Dim c1pckg As Decimal
        Dim c1pkno As Decimal
        Dim c2transno As String
        Dim c3qty As Integer
        Dim c1whs As String
    End Structure

    Structure upditem
        Dim c1uitem As String
        Dim c1upqty As Decimal
        Dim c1pkno As String
        Dim c1whse As String
        Dim c1upckg As Integer
        Dim c1upkno As String
        Dim c1operator As String
    End Structure

    Private Sub frmPhysicalD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            btnSearch.PerformClick()
        ElseIf e.KeyCode = Keys.F7 Then
            btnRemove.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            btnLoadAll.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            If gbxItemList.Visible = True Then
                gbxItemList.SendToBack()
                gbxItemList.Visible = False
            Else
                btnClose.PerformClick()
            End If
        End If
    End Sub

    Private Sub frmPhysicalD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If txtUser.Text = Nothing Then
            txtUser.Text = _user
        End If
        With dgvItem
            For i = 0 To .Columns.Count - 1
                .Columns(i).ReadOnly = True
            Next
            .Columns(1).ReadOnly = False
        End With
        If Me.Tag = 0 Then
            LoadWarehouse()
            reset_listrmv()
            reset_listupd()

        End If

    End Sub

    Private Sub reset_listadded()
        'Reset person count and array
        rwadded = 0
        rwsnews = 0
        Erase listrowsadded
        Erase listadded
    End Sub

    Sub LoadItemList()
        dgvItem.EndEdit()
        dgvItemList.Rows.Clear()
        '   dgvItemList.Focus()
        Dim i As Integer
        'If cbxSupplier.Text <> Nothing Then
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND isdeleted<>1 ORDER BY description ASC", cdb)
        'cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            ' If statement
            dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
        End While
        rd.Close()

        With dgvItemList

            If lastitemsel <> Nothing Then 'FOCUS ON LAST ITEM
                If .Rows.Count > 0 Then
                    For i = 0 To .Rows.Count - 1
                        If .Item(1, i).Value = lastitemsel Then
                            '.ClearSelection()
                            .Item(1, i).Selected = True
                            .CurrentCell = .Item(1, i)
                            .Focus()
                            Exit For
                        End If
                    Next
                End If
            Else
                .Focus()
            End If
        End With

    End Sub

    Sub LoadWarehouse()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand
        cboWhsCode.Items.Clear()
        cboWhsCode.DisplayMember = "text"
        qry = "Select * from warehouse ORDER BY warehouse"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboWhsCode.Items.Add(New With {.Text = relr("whscode").ToString(), .Value = relr("whscode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub


    Private Sub tsnew_Click(sender As Object, e As EventArgs)
        'tbTransNo.Text = GetTransNo()
        ' GetTransRcvNo()
    End Sub

    Sub GeneratePhysicalTransNo()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        cqry = "Select transno as tno FROM phyivh ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While
            rcvtno = Strings.Right(mdr("tno").ToString, 9) + 1
            rcvtno = "P" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If

        If rcnt = 0 Then
            rcvtno = "P000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        txtTransno.Text = rcvtno

    End Sub


    Dim selrow As Integer = 0
    Delegate Sub SetColumnIndex(ByVal i As Integer)
    Private Sub Mymethod(ByVal columnIndex As Integer)
        If Me.dgvItem.CurrentRow.Index >= 0 Then
            If Me.dgvItem.CurrentRow.Index > 0 Then
                Me.dgvItem.CurrentCell = Me.dgvItem.Item(columnIndex, selrow)    '.Cells(columnIndex)
                Me.dgvItem.BeginEdit(True)
            Else
                Me.dgvItem.CurrentCell = Me.dgvItem.Item(columnIndex, 0)   '.Cells(columnIndex)
                Me.dgvItem.BeginEdit(True)
            End If
        End If

    End Sub

    Sub getpackprice(ByVal itm As String, ByVal pck As String, ByVal rx As Integer, ByVal ptype As String)
        Dim cpck As Decimal = 0
        Dim bpck As Decimal = 0
        Dim ppck As Decimal = 0
        Dim gcost As Decimal = 0
        Dim iunit As String = Nothing
        Dim ncost As Decimal = 0
        Dim costpc As Decimal = 0
        Dim apricec As Decimal = 0
        Dim apricep As Decimal = 0


        Dim cmd As MySqlCommand
        'cmd = New MySqlCommand("SELECT PCKGC,PCKGB,PCKGP,GRSCOST,UNIT, NETCOST, COSTPC FROM ivitem WHERE ITEMCODE=@tm", cdb)
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE ITEMCODE=@tm and isdeleted<>1", cdb)
        cmd.Parameters.AddWithValue("@tm", itm)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()

                cpck = rd("PCKGC").ToString
                bpck = rd("PCKGB").ToString
                gcost = rd("GRSCOST").ToString

                'If ptype = "A" Then
                '    If pck = "P" Then
                '        apricep = rd("APRICEP").ToString
                '    ElseIf pck = "B" Then
                '        apricep = rd("APRICEB").ToString
                '    ElseIf pck = "C" Then
                '        apricep = rd("APRICEC").ToString
                '    End If

                'ElseIf ptype = "B" Then
                '    If pck = "P" Then
                '        apricep = rd("BPRICEP").ToString
                '    ElseIf pck = "B" Then
                '        apricep = rd("BPRICEB").ToString
                '    ElseIf pck = "C" Then
                '        apricep = rd("BPRICEC").ToString
                '    End If
                'ElseIf ptype = "C" Then
                '    If pck = "P" Then
                '        apricep = rd("CPRICEP").ToString
                '    ElseIf pck = "B" Then
                '        apricep = rd("CPRICEB").ToString
                '    ElseIf pck = "C" Then
                '        apricep = rd("CPRICEC").ToString
                '    End If
                'ElseIf ptype = "D" Then
                '    If pck = "P" Then
                '        apricep = rd("DPRICEP").ToString
                '    ElseIf pck = "B" Then
                '        apricep = rd("DPRICEB").ToString
                '    ElseIf pck = "C" Then
                '        apricep = rd("DPRICEC").ToString
                '    End If
                'ElseIf ptype = "E" Then
                '    If pck = "P" Then
                '        apricep = rd("EPRICEP").ToString
                '    ElseIf pck = "B" Then
                '        apricep = rd("EPRICEB").ToString
                '    ElseIf pck = "C" Then
                '        apricep = rd("EPRICEC").ToString
                '    End If
                'End If


                iunit = rd("UNIT").ToString
                ncost = rd("NETCOST").ToString
                costpc = rd("COSTPC").ToString


                Dim pcost As Decimal = 0

                With dgvItem
                    If pck = "C" Then
                        .Item(5, rx).Value = cpck

                        .Item(6, rx).Value = Format(apricep, "STANDARD")
                        '.Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        ' .Item(8, rx).Value = costpc
                        .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                    ElseIf pck = "P" Then
                        'If iunit = "C" Then
                        '    pcost = gcost / cpck
                        'End If
                        .Item(5, rx).Value = 1

                        .Item(6, rx).Value = Format(apricep, "STANDARD")
                        '.Item(7, rx).Value = Format(costpc, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        ' .Item(8, rx).Value = costpc
                        .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(5, rx).Value * .Item(6, rx).Value, "STANDARD")

                    ElseIf pck = "B" Then
                        Dim bgprice As Decimal = 0
                        bgprice = (apricep / cpck) * bpck

                        .Item(5, rx).Value = bpck
                        .Item(6, rx).Value = Format(bgprice, "STANDARD")

                        '.Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        .Item(4, rx).Value = "B"
                        .Item(5, rx).Value = bpck
                        .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")

                    End If

                End With

            End If
        End Using

    End Sub

    Function checkitemno(ByVal itmn As String)
        Dim fnd As Boolean = False
        With dgvItem
            Dim xx As Integer = 0

            If .RowCount > 1 Then

                For i = 0 To .RowCount - 2

                    If itmn = .Item(1, i).Value Then
                        xx += 1
                    End If

                Next

                If xx >= 1 Then
                    fnd = True
                End If
            End If
        End With
        Return fnd
    End Function

    Function checkitemno_update(ByVal itmn As String, ByVal rx As Integer)
        Dim fnd As Boolean = False
        With dgvItem
            Dim xx As Integer = 0

            If .RowCount > 1 Then

                For i = 0 To .RowCount - 2
                    If i <> rx Then
                        If itmn = .Item(1, i).Value Then
                            xx += 1
                        End If
                    End If

                Next

                If xx >= 1 Then
                    fnd = True
                End If
            End If
        End With
        Return fnd
    End Function

    Function getitem_byid(ByVal itemno As String, ByVal rdx As Integer)
        Dim unlock_colums(0) As Integer


        Dim current_unit As String = Nothing
        Dim selected_col As Integer = 0


        

        Dim fnd As Boolean
        fnd = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode,description,grscost, unit, PCKGC,PCKGB, netcost,costpc FROM ivitem WHERE ITEMCODE=@itm AND isdeleted<>1", cdb)
        cmd.Parameters.AddWithValue("@itm", itemno)
        'cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
        With dgvItem
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()

                    current_unit = rd("unit").ToString

                    If current_unit = "C" Then
                        selected_col = 3
                        'lock_colums(0) = 5
                        'lock_colums(1) = 7
                        Array.Resize(unlock_colums, 3)
                        unlock_colums(0) = 3
                        unlock_colums(1) = 5
                        unlock_colums(2) = 7
                    ElseIf current_unit = "B" Then
                        selected_col = 5
                        Array.Resize(unlock_colums, 2)
                        unlock_colums(0) = 5
                        unlock_colums(1) = 7
                    ElseIf current_unit = "P" Then
                        selected_col = 7
                        Array.Resize(unlock_colums, 1)
                        unlock_colums(0) = 7
                    End If

                    .Item(2, rdx).Value = rd("description").ToString
                    ' .Item(4, rdx).Value = rd("unit").ToString
                    .Item(4, rdx).Value = rd("PCKGC").ToString
                    .Item(6, rdx).Value = rd("PCKGB").ToString

                    .Item(3, rdx).Value = 0
                    .Item(5, rdx).Value = 0
                    .Item(7, rdx).Value = 0
                    '.Item(7, rdx).Value = rd("netcost").ToString
                    '.Item(8, rdx).Value = rd("costpc").ToString
                    If unlock_colums.Length > 0 Then
                        For i = 0 To unlock_colums.Length - 1
                            ' .Columns(lock_colums(i)).ReadOnly = True
                            .Rows(rdx).Cells(unlock_colums(i)).ReadOnly = False
                        Next
                    End If
                    fnd = True
                Else
                    ' .Item(1, rdx).tag=1
                    MsgBox("ITEM NO Not Found/Belong to this supplier!", 48, "No Record Found/Belong to this supplier!")
                    .Item(1, rdx).Value = Nothing
                    .Item(2, rdx).Value = Nothing
                    .Item(3, rdx).Value = Nothing
                    .Item(4, rdx).Value = Nothing
                    .Item(5, rdx).Value = Nothing
                    .Item(6, rdx).Value = Nothing
                    .Item(7, rdx).Value = Nothing

                    '.Item(8, rdx).Value = Nothing
                    '.Item(9, rdx).Value = Nothing
                End If
            End Using
        End With
        cmd.Dispose()
        Return fnd
    End Function


    Function CheckItemIsInTheTable()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select * from ivitem where itemcode='" & UCase(dgvItem.CurrentRow.Cells(1).Value) & "'", cdb)
        With cmd
            .Parameters.AddWithValue("@itemcode", UCase(dgvItem.CurrentRow.Cells(1).Value))
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub dgvItem_KeyDown(sender As Object, e As KeyEventArgs)

        With dgvItem

            'If e.KeyCode = Keys.Enter And .CurrentCell.ColumnIndex = 3 Then
            '    e.Handled = True
            '    'If .CurrentRow.Cells(1).Value = Nothing Then
            '    '    .Rows.Remove(.CurrentRow)
            '    'End If
            'End If
            'If e.KeyCode = Keys.F2 Then
            '    tsAddItem.PerformClick()
            'End If
        End With

    End Sub

    'Sub ComputeStockInTotal()

    '    Dim inTotal As Double = Nothing
    '    Dim iTotal As Double = Nothing
    '    Dim NetAmt As Double = Nothing

    '    For i = 0 To dgvItem.RowCount - 1
    '        iTotal += dgvItem.Rows(i).Cells(7).Value
    '        dgvItem.Rows(i).Cells(0).Value = i + 1
    '    Next

    '    Me.tbTotal.Text = Format((iTotal), sFmat)

    'End Sub



    Private Sub ComputeTotal()
        'Dim nRDisc As Double = 0
        'Dim nSDisc As Double = 0
        'Dim nTotAmt As Double = 0
        'nTotAmt = 0
        'For i = 0 To dgvRcvItem.RowCount - 1
        '    nTotAmt += dgvRcvItem.Rows(i).Cells(10).Value
        '    dgvRcvItem.Rows(i).Cells(0).Value = i + 1
        'Next
        'dgvRcvItem.Rows(0).Cells(1).Value = nTotAmt
        'nRDisc = nTotAmt * (NuPD1.Value / 100)
        'dgvRcvItem.Rows(1).Cells(1).Value = nRDisc
        'nSDisc = (nTotAmt - nRDisc) * (NuPD2.Value / 100)
        'dgvRcvItem.Rows(2).Cells(1).Value = nSDisc
        'dgvRcvItem.Rows(3).Cells(1).Value = nTotAmt - nRDisc - nRDisc


    End Sub

    Private Sub tsDeleteItem_Click(sender As Object, e As EventArgs)
        'If dgvRcvItem.Rows.Count = 0 Then
        '    MsgBox("Select Item to Delete!", vbCritical)
        'Else
        '    If MsgBox("Delete this Item?", vbYesNo + vbExclamation) = vbYes Then
        '        Try
        '            dgvRcvItem.Rows.Remove(dgvRcvItem.Rows(dgvRcvItem.CurrentRow.Index))
        '            ComputeRcvTotal()
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
        '    End If
        'End If
    End Sub

    Private Sub btnLoadItem_Click(sender As Object, e As EventArgs)
        frmSearchItem.ShowDialog()
    End Sub

    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs)
        '  ComputeStockInTotal()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "PHYSICAL INVENTORY ENTRY") = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Dim lastitemsel As String = Nothing
    Sub clear_row_if_item_found(ByVal rwx As Integer)
        With dgvItem
            .Item(1, rwx).Value = Nothing
            .Item(2, rwx).Value = Nothing
            .Item(8, rwx).Value = Nothing
        End With
    End Sub
    Sub load_items()

        With dgvItemList
            If .RowCount > 0 Then
                With dgvItemList

                    If .RowCount > 0 Then
                        Dim nn As Integer = 0
                        Dim nm As Integer = 0
                        Dim rindex As Integer = 0
                        Dim rdx As Integer = 0

                        rdx = dgvItemList.CurrentCell.RowIndex
                        Dim unlock_colums(0) As Integer


                        Dim current_unit As String = Nothing
                        Dim selected_col As Integer = 0
                        current_unit = dgvItemList(9, rdx).Value

                        If current_unit = "C" Then
                            selected_col = 3
                            'lock_colums(0) = 5
                            'lock_colums(1) = 7
                            Array.Resize(unlock_colums, 3)
                            unlock_colums(0) = 3
                            unlock_colums(1) = 5
                            unlock_colums(2) = 7
                        ElseIf current_unit = "B" Then
                            selected_col = 5
                            Array.Resize(unlock_colums, 2)
                            unlock_colums(0) = 5
                            unlock_colums(1) = 7
                        ElseIf current_unit = "P" Then
                            selected_col = 7
                            Array.Resize(unlock_colums, 1)
                            unlock_colums(0) = 7
                        End If


                        With dgvItem
                            .Columns(1).ReadOnly = False
                            If .RowCount > 0 Then
                                'rindex = dgvItem.CurrentCell.RowIndex
                                rindex = dgvItem.RowCount - 1
                                Dim nrow As Integer = 0
                                Dim ccrow As Integer = 0
                                Dim krow As Integer = 0


                                'For j = 0 To .RowCount - 1
                                '    If .Item(10, j).Value = mycat Then
                                '        nrow = j
                                '        krow += 1
                                '    End If
                                'Next

                                nrow = .RowCount - 1
                                nrow += 1
                                If nrow <= 0 Then

                                    If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                        If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                            MsgBox("Item already on the list!", 64, "Item added")
                                            clear_row_if_item_found(rdx)
                                            Exit Sub
                                        End If

                                        .RowCount += 1
                                        nn = .RowCount - 1
                                        selrow = nn
                                        nm = 1
                                        .ClearSelection()
                                        lastitemsel = dgvItemList.Item(1, rdx).Value
                                        .Item(0, nn).Value = nm
                                        .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value 'ITEM
                                        'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                        '    MsgBox("not equal1")
                                        'End If
                                        .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                        '.Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                        .Item(4, nn).Value = dgvItemList.Item(10, rdx).Value
                                        .Item(6, nn).Value = dgvItemList.Item(11, rdx).Value

                                        .Item(3, nn).Value = 0
                                        .Item(5, nn).Value = 0
                                        .Item(7, nn).Value = 0



                                        '.CurrentCell = .Item(3, nn)
                                        '.Item(5, nn).Selected = True

                                        .CurrentCell = .Item(selected_col, nn)
                                        .Item(selected_col, nn).Selected = True
                                        If unlock_colums.Length > 0 Then
                                            For i = 0 To unlock_colums.Length - 1
                                                ' .Columns(lock_colums(i)).ReadOnly = True
                                                .Rows(nn).Cells(unlock_colums(i)).ReadOnly = False
                                            Next
                                        End If

                                        .BeginEdit(True)
                                    End If
                                Else
                                    If .Item(1, rindex).Value <> Nothing And .Item(3, rindex).Value <> 0 Then 'And .Item(8, rindex).Value <> Nothing Then
                                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(1, rindex).Value = dgvItemList.Item(1, rdx).Value 'ITEM
                                            'If .Item(9, rindex).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    ReDim Preserve listupd(rwupd)
                                            '    listupd(rwupd).c1uitem = .Item(9, rindex).Value
                                            '    listupd(rwupd).c1upqty = .Item(3, rindex).Value
                                            '    listupd(rwupd).c1whse = cboWhsCode.SelectedItem.value
                                            '    listupd(rwupd).c1upckg = .Item(5, rindex).Value
                                            '    listupd(rwupd).c1upkno = .Item(8, rindex).Value
                                            '    rwupd += 1
                                            'End If
                                            .Item(2, rindex).Value = dgvItemList.Item(2, rdx).Value 'DESCRIPTION
                                            ' .Item(4, rindex).Value = dgvItemList.Item(9, rdx).Value 'QTY
                                            .Item(4, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(11, rdx).Value
                                            .Item(3, nn).Value = 0
                                            .Item(5, nn).Value = 0
                                            .Item(7, nn).Value = 0
                                            '.CurrentCell = .Item(3, rindex)
                                            '.Item(5, nn).Selected = True
                                            .CurrentCell = .Item(selected_col, nn)
                                            .Item(selected_col, nn).Selected = True
                                            If unlock_colums.Length > 0 Then
                                                For i = 0 To unlock_colums.Length - 1
                                                    ' .Columns(lock_colums(i)).ReadOnly = True
                                                    .Rows(nn).Cells(unlock_colums(i)).ReadOnly = False
                                                Next
                                            End If
                                            .BeginEdit(True)
                                        Else
                                            nrow += 1
                                            .RowCount += 1
                                            nn = .RowCount - 1

                                            nm = nrow
                                            selrow = nn
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(0, nn).Value = nm
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    MsgBox("not equal2")
                                            'End If
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            '.Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(11, rdx).Value
                                            .Item(3, nn).Value = 0
                                            .Item(5, nn).Value = 0
                                            .Item(7, nn).Value = 0

                                            '.CurrentCell = .Item(3, nn)
                                            '.Item(5, nn).Selected = True
                                            .CurrentCell = .Item(selected_col, nn)
                                            .Item(selected_col, nn).Selected = True
                                            If unlock_colums.Length > 0 Then
                                                For i = 0 To unlock_colums.Length - 1
                                                    ' .Columns(lock_colums(i)).ReadOnly = True
                                                    .Rows(nn).Cells(unlock_colums(i)).ReadOnly = False
                                                Next
                                            End If
                                            .BeginEdit(True)
                                        End If
                                    Else
                                        nn = rindex
                                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            nm = nn + 1
                                            selrow = nn
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(0, nn).Value = nm
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    MsgBox("not equal3")
                                            'End If
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            ' .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(11, rdx).Value
                                            .Item(3, nn).Value = 0
                                            .Item(5, nn).Value = 0
                                            .Item(7, nn).Value = 0

                                            '.CurrentCell = .Item(3, nn)
                                            '.Item(5, nn).Selected = True
                                            .CurrentCell = .Item(selected_col, nn)
                                            .Item(selected_col, nn).Selected = True
                                            If unlock_colums.Length > 0 Then
                                                For i = 0 To unlock_colums.Length - 1
                                                    ' .Columns(lock_colums(i)).ReadOnly = True
                                                    .Rows(nn).Cells(unlock_colums(i)).ReadOnly = False
                                                Next
                                            End If

                                            .BeginEdit(True)
                                        End If

                                    End If
                                End If

                            Else

                                If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                    If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                        MsgBox("Item already on the list!", 64, "Item added")
                                    End If
                                    If rdx = 0 Then
                                        If dgvItemList.Item(3, rdx).Value = Nothing Then
                                            Exit Sub
                                        End If
                                    Else
                                        If dgvItemList.Item(3, rdx - 1).Value = Nothing Then
                                            Exit Sub
                                        End If
                                    End If

                                    .RowCount += 1
                                    nn = .RowCount - 1
                                    selrow = nn
                                    nm = 1
                                    .ClearSelection()
                                    lastitemsel = dgvItemList.Item(1, rdx).Value
                                    .Item(0, nn).Value = nm
                                    .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                    'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                    '    MsgBox("not equal4")
                                    'End If
                                    .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                    ' .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                    .Item(4, nn).Value = dgvItemList.Item(10, rdx).Value
                                    .Item(6, nn).Value = dgvItemList.Item(11, rdx).Value
                                    .Item(3, nn).Value = 0
                                    .Item(5, nn).Value = 0
                                    .Item(7, nn).Value = 0

                                    '.CurrentCell = .Item(3, nn)
                                    '.Item(3, nn).Selected = True
                                    .CurrentCell = .Item(selected_col, nn)
                                    .Item(selected_col, nn).Selected = True
                                    If unlock_colums.Length > 0 Then
                                        For i = 0 To unlock_colums.Length - 1
                                            ' .Columns(lock_colums(i)).ReadOnly = True
                                            .Rows(nn).Cells(i).ReadOnly = False
                                        Next
                                    End If
                                    .BeginEdit(True)
                                End If

                            End If

                        End With
                    End If
                End With

                gbxItemList.Visible = False
                gbxItemList.SendToBack()
            End If
        End With
    End Sub

    Public Sub column_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Integer
    Public Sub column_keydown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If cboWhsCode.Text = "" Then
            MsgBox("Please select warehouse!", MsgBoxStyle.Critical)
            cboWhsCode.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.F3 Then
            'tsSearchItem.PerformClick()
        End If
    End Sub


    Private Sub tssave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        'If cbxSupplier.Text = "" Or cbxWarehouse.Text = "" Or tbInvoiceNo.Text = "" Then
        '    MsgBox("Check Missing Field", vbCritical)
        '    Exit Sub
        'End If

        'If checkrcvPOno() = True Then
        '    MsgBox("PO No. Already Used!", 48, "Enter PO. No.")
        '    tbPONo.Focus()
        '    Exit Sub
        'End If

        'If checkrcvInvoiceNo() = True Then
        '    MsgBox("Invoice No. Already Used!.", 48, "Enter Invoice No.")
        '    tbInvoiceNo.Focus()
        '    Exit Sub
        'End If

        'With dgvItem
        '    If .RowCount > 0 Then
        '        Dim asave As Boolean = True

        '        For i = 0 To .Rows.Count - 1
        '            If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
        '                asave = False
        '            End If
        '        Next

        '        If asave = True Then

        '            GetTransRcvNo()
        '            rcvSave()
        '            MsgBox("Recieving Has Been Save Successfully", vbInformation)

        '            AuditTrail("Trans No.:" & tbTransNo.Text & Space(2) & "PO. No.:" & tbPONo.Text & Space(2) & "Invoice No.:" & tbInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Receiving Entry")
        '            ClearRcv()
        '            'Me.Dispose()
        '            With frmReceivingH
        '                .LoadRcvh()
        '            End With
        '        Else
        '            MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
        '        End If

        '    Else
        '        MsgBox("Please add item/s first before saving", 48, "No item/s found")
        '    End If
        'End With


        ' AuditTrail("Add Product " & txtID.Text & Space(2) & txtDescription.Text & Space(2) & txtPrice.Text & Space(2) & txtQty.Text, "Product Module")



    End Sub

    Private Sub tbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Down Then
            dgvItemList.Focus()
        End If
    End Sub

    Private Sub tbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim i As Integer
            dgvItemList.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from ivitem where (itemcode like '%" & txtSearch.Text & "%' " & _
                                   " OR description like '%" & txtSearch.Text & "%') " & _
                                   " AND isdeleted<>1", cdb)
            'cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub reset_listrmv()
        'Reset person count and array
        rwrmv = 0
        Erase listrmv
    End Sub
    Private Sub reset_listupd()
        rwupd = 0
        Erase listupd
    End Sub


    Function isExistWarehouseAndItem(ByVal currentwhsname As String, ByVal itemcode As String) As Boolean
        Dim existna As Boolean = False

        Dim cmd2 As New MySqlCommand
        cmd2 = New MySqlCommand("SELECT * FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
        cmd2.Parameters.AddWithValue("@itm", itemcode)
        cmd2.Parameters.AddWithValue("@wh", currentwhsname)
        Using rd2 As MySqlDataReader = cmd2.ExecuteReader
            If rd2.HasRows Then
                rd2.Read()
                existna = True
            End If
            rd2.Close()
        End Using
        cmd2.Dispose()

        Return existna
    End Function

    Function getCurrentQTYSaExisting(ByVal currentwhsname As String, ByVal itemcode As String) As Integer
        Dim qtyex As Integer = 0

        Dim cmd2 As New MySqlCommand
        cmd2 = New MySqlCommand("SELECT * FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
        cmd2.Parameters.AddWithValue("@itm", itemcode)
        cmd2.Parameters.AddWithValue("@wh", currentwhsname)
        Using rd2 As MySqlDataReader = cmd2.ExecuteReader
            If rd2.HasRows Then
                rd2.Read()
                qtyex = rd2("qty_good").ToString
            End If
            rd2.Close()
        End Using
        cmd2.Dispose()

        Return qtyex
    End Function

    Private Sub dgvItem_KeyUp(sender As Object, e As KeyEventArgs)
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0

                mrw = .CurrentCell.RowIndex
                If .CurrentCell.ColumnIndex = 4 Then
                    Dim itemno As String = Nothing
                    Dim mpc As String = Nothing

                    itemno = .Item(1, mrw).Value

                    If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
                        mpc = .Item(4, mrw).Value
                        '   ComputeStockInTotal()
                    Else
                        .Item(4, mrw).Value = "C"
                        mpc = .Item(4, mrw).Value
                        .BeginEdit(True)
                        '   ComputeStockInTotal()
                    End If

                    '  getpackprice(itemno, mpc, mrw, cboPriceType.Text)

                    If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = "P"
                        mpc = .Item(4, mrw).Value
                        '   ComputeStockInTotal()
                    End If

                    ' ComputeStockInTotal()
                ElseIf .CurrentCell.ColumnIndex = 1 And e.KeyCode = Keys.F3 Then
                    btnSearch.PerformClick()
                End If
            End If
        End With

    End Sub
  
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim r As Integer

        'If btnSearch.Enabled = False Then
        '    btnSearch.Enabled = True
        'End If

        'If cbxSupplier.Text = "" Then
        '    MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
        '    cbxSupplier.Focus()
        '    Exit Sub
        'End If

        If cboWhsCode.Text = "" Then
            MsgBox("Pls. Enter Warehouse!", MsgBoxStyle.Information)
            cboWhsCode.Focus()
            Exit Sub
        End If

        If gbxItemList.Visible = True Then
            gbxItemList.SendToBack()
            gbxItemList.Visible = False
        End If

        With dgvItem
            Dim allow_add As Boolean = False
            Dim check_columns As Integer() = {3, 5, 7}
            .Columns(1).ReadOnly = False

            If .Rows.Count > 0 Then
                r = .Rows.Count - 1

                If .Rows(r).Cells(1).Value <> Nothing  Then

                    'If .Rows(r).Cells(3).Value = 0 Then
                    '    .ClearSelection()
                    '    .CurrentCell = .Item(3, r)

                    '    .BeginEdit(True)
                    'Else
                    .Rows.Add()
                    r = .Rows.Count - 1
                    selrow = r
                    .Rows(r).Cells(0).Value = r + 1
                    .ClearSelection()
                    ' If .CurrentCell.ColumnIndex <> 7 Then
                    'If .Rows(r).Cells(4).Value <> 0 Then
                    ' MsgBox("choose any item in cell3 before you can proceed here")
                    If (.Rows.Count > 0) Then
                        .Rows(r).Selected = True
                        .CurrentCell = .Item(1, r)
                        'Dim method As New SetColumnIndex(AddressOf Mymethod)
                        '.BeginInvoke(method, 7)
                        Exit Sub
                    End If
                    ' End If
                    '.CurrentCell = .Item(1, r)
                    'End If


                    .BeginEdit(True)
                    'End If

                Else

                    .ClearSelection()
                    ' If .Rows(r).Cells(4).Value <> 0 Then
                    '("choose any item in cell3 before you can proceed here")
                    If (.Rows.Count > 0) Then
                        .Rows(r).Selected = True
                        .CurrentCell = .Item(1, r)
                        'Dim method As New SetColumnIndex(AddressOf Mymethod)
                        '.BeginInvoke(method, 7)
                        Exit Sub
                    End If
                   
                    'End If
                    'If .CurrentCell.ColumnIndex <> 7 Then
                    ' .CurrentCell = .Item(1, r)
                    ' End If
                    '.CurrentCell = .Item(1, r)

                    .BeginEdit(True)
                End If
            Else
                .Rows.Add()
                r = .Rows.Count - 1
                selrow = r
                .Rows(r).Cells(0).Value = r + 1
                .CurrentCell = .Rows(r).Cells(1)
                .BeginEdit(True)
            End If
            ' dgvRcvItem.Focus()
            ' dgvRcvItem.CurrentCell = dgvRcvItem.CurrentRow.Cells(1)
        End With


    End Sub

    'Private Sub dgvItem_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
    '    With dgvItem
    '        If .Rows.Count > 0 Then
    '            If .CurrentCell.ColumnIndex = 3 Then
    '                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
    '                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
    '            ElseIf .CurrentCell.ColumnIndex = 4 Then
    '                'Dim cbo As ComboBox = CType(e.Control, ComboBox)
    '                selrow = .CurrentCell.RowIndex
    '                'AddHandler cbo.PreviewKeyDown, AddressOf cbx_PreviewKeyDown
    '                Dim combo As ComboBox = CType(e.Control, ComboBox)
    '                If (combo IsNot Nothing) Then

    '                    RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

    '                    ' Add the event handler. 
    '                    AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

    '                End If
    '            ElseIf .CurrentCell.ColumnIndex = 1 Then
    '                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
    '                AddHandler CType(e.Control, TextBox).KeyDown, AddressOf column_keydown
    '            Else

    '                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress

    '            End If
    '        End If
    '    End With
    'End Sub

    Private Sub cbx_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        With dgvItem
            If .Item(3, selrow).Value <> 0 Then
                .ClearSelection()
                Dim method As New SetColumnIndex(AddressOf Mymethod)
                Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
                Me.dgvItem.BeginInvoke(method, nextindex)
            End If

        End With

    End Sub

    'Private Sub cbxSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSupplier.KeyPress
    '    If e.KeyChar = vbCr Then
    '        cboWhsCode.Focus()
    '    End If
    'End Sub

    'Private Sub cbxSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxSupplier.SelectionChangeCommitted
    '    cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "'", cdb)
    '    Using rd = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            rd.Read()
    '            tbSupplier.Text = rd.Item("suppliername").ToString
    '        End If
    '        rd.Close()
    '    End Using
    'End Sub


    Private Sub cboWhsCode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboWhsCode.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cboWhsCode.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtWarehouse.Text = rd.Item("warehouse").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If cboWhsCode.Text = "" Then
            MsgBox("Please select warehouse!", MsgBoxStyle.Critical)
            cboWhsCode.Focus()
            Exit Sub
        End If

        btnAdd_Click(sender, e)
        With dgvItem

            If .Rows.Count > 0 Then
                Dim r As Integer = 0

                r = .Rows.Count - 1

                If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing _
                    And .Rows(r).Cells(7).Value <> Nothing Then

                    gbxItemList.BringToFront()
                    txtSearch.Focus()
                    gbxItemList.Visible = True
                    LoadItemList()
                    gbxItemList.Focus()
                    dgvItemList.Focus()
                Else
                    LoadItemList()
                    gbxItemList.BringToFront()
                    gbxItemList.Visible = True
                    gbxItemList.Focus()
                    dgvItemList.Focus()

                    ' MsgBox("Please provide proper item/s and quantity first", 48, "Invalid entry found")

                End If
                dgvItemList.Focus()
            Else
                gbxItemList.Visible = True
                gbxItemList.BringToFront()
                LoadItemList()
                gbxItemList.Focus()
                dgvItemList.Focus()
            End If

        End With
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MsgBox("Remove this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then

            Dim mytrans As String = Nothing
            mytrans = txtTransno.Text.Trim()

            If mytrans <> Nothing Then
               

                Dim fnd As Boolean = False
                cmd = New MySqlCommand("SELECT transno FROM phyivh  where transno=@tno AND POSTED='N'", cdb)
                cmd.Parameters.AddWithValue("@tno", mytrans)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        fnd = True
                    End If
                End Using
                cmd.Dispose()
                If fnd = False Then
                    MsgBox("This transaction is already posted", 48, "Items on this transaction cannot be removed or modified")
                Else
                    ReDim Preserve listrmv(rwrmv)
                    With listrmv(rwrmv)
                        .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                        .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Value
                        .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
                        .c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                        .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Value ' .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag 'toping coy

                    End With
                    rwrmv += 1
                    dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))
                End If
               
                '  ComputeStockInTotal()
                'CalcTotalQty()

            End If
           

        End If

    End Sub

    Private Sub DeleteBlankRow()
        For i = 0 To dgvItem.RowCount - 1
            If dgvItem.Rows(i).Cells(1).Value = Nothing Then
                dgvItem.Rows.Remove(dgvItem.Rows(i))
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cboWhsCode.Text = "" Then
            MsgBox("Warehouse is required!", vbCritical)
            cboWhsCode.Focus()
            Exit Sub
        End If

        With dgvItem

            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()
            If .RowCount > 0 Then
                Dim allow_save As Boolean = True

                For i = 0 To .Rows.Count - 1
                    'If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                    If .Item(2, i).Value = Nothing Then
                        allow_save = False
                    End If
                Next

                If allow_save = True Then
                    GeneratePhysicalTransNo()
                    SavePhysicalInventory()
                    MsgBox("Physical Inventory has been save successfully", vbInformation)
                    Clears()
                    With frmPhysicalH
                        .LoadPhyivH()
                    End With
                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If
            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With

    End Sub

    Sub SavePhysicalInventory()
        'insert to phyivh
        Dim cmd As MySqlCommand
        Dim posted As String = "N"

        Dim i As Integer
        cmd = New MySqlCommand("INSERT INTO phyivh (transno,tdate,whscode,whsname,remarks,posted,user) " & _
                               "VALUES (@transno,@tdate,@whscode,@whsname,@remarks,@posted,@user )", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
            cmd.Parameters.AddWithValue("@tdate", sDate.Value)
            cmd.Parameters.AddWithValue("@whscode", cboWhsCode.Text)
            cmd.Parameters.AddWithValue("@whsname", txtWarehouse.Text)
            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
            cmd.Parameters.AddWithValue("@posted", posted)
            cmd.Parameters.AddWithValue("@user", txtUser.Text)
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'insert to phyivd
        With dgvItem

            For i = 0 To .RowCount - 1
                'If .Item(3, i).Value <> Nothing Then
                If .Item(2, i).Value <> Nothing Then
                    cmd = New MySqlCommand("INSERT INTO phyivd (transno,whscode,tdate,itemcode,qtyc,qtyb,qtyp,pckgc,pckgb)" & _
                                            "VALUES (@transno,@whs,@tdate,@item,@qtyc,@qtyb,@qtyp,@pckgc,@pckgb)", cdb)
                    cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
                    cmd.Parameters.AddWithValue("@whs", cboWhsCode.Text)
                    cmd.Parameters.AddWithValue("@tdate", sDate.Value)
                    cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                    cmd.Parameters.AddWithValue("@qtyc", .Item(3, i).Value)
                    cmd.Parameters.AddWithValue("@qtyb", .Item(5, i).Value)
                    cmd.Parameters.AddWithValue("@qtyp", .Item(7, i).Value)
                    cmd.Parameters.AddWithValue("@pckgc", .Item(4, i).Value)
                    cmd.Parameters.AddWithValue("@pckgb", .Item(6, i).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
                'End If
            Next
        End With

    End Sub

    Sub Clears()
        cboWhsCode.Text = Nothing
        txtWarehouse.Text = ""
        txtTransno.Text = ""
        txtRemarks.Text = ""
        '  cboPriceType.Text = "A"
        dgvItem.Rows.Clear()
    End Sub

    Sub StockInDisble()
        'cbxSupplier.Enabled = False
        'cboWhsCode.Enabled = False
        'tbWhsName.Text = ""
        'tbSupplier.Text = ""
        'tbTransNo.Text = ""
        'txtRemarks.Text = ""
        'cboPriceType.Enabled = False
        ' tbTotal.Text = "0.00"
        ' dgvItem.Rows.Clear()
    End Sub

    Sub StockInEnable()
        'cbxSupplier.Enabled = False
        'cboWhsCode.Enabled = True
        'tbWhsName.Text = ""
        'tbSupplier.Text = ""
        'tbTransNo.Text = ""
        'txtRemarks.Text = ""
        'cboPriceType.Enabled = False
    End Sub


    'Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    '    With dgvItem
    '        If .RowCount = 0 Then
    '            MsgBox("No items found!", vbExclamation)
    '            Return
    '        End If

    '        DeleteBlankRow()

    '        If cboWhsCode.Text <> Nothing Then
    '            If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
    '                Dim asave As Boolean = True

    '                For i = 0 To .Rows.Count - 1
    '                    If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
    '                        'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
    '                        asave = False
    '                    End If
    '                Next

    '                If asave = True Then
    '                    .EndEdit(True)
    '                    UpdatePhysicalInventory()

    '                    MsgBox("Misc. Stock In Has Been Updated Successfully.", vbInformation)
    '                    Clears()
    '                    Me.Dispose()

    '                    With frmStockInH
    '                        .LoadStockIn()
    '                    End With
    '                Else
    '                    MsgBox("Please input a valid quantity,item/s first", 48, "Invalid quantity,item/s found")
    '                End If

    '            End If
    '        Else
    '            MsgBox("Please select supplier and warehouse first!", 48, "Select First")
    '        End If

    '    End With
    'End Sub

    Sub UpdatePhysicalInventory()

        'NEW PROCESS UPDATE IVH => COCOY
        Dim cmd As MySqlCommand
        Dim i As Integer
        cmd = New MySqlCommand("UPDATE ivh SET ttype=@ttype,date=@date,whscode=@whscode,supcode=@supcode,total=@total,remarks=@remarks,pricetype=@pricetype,userid=@userid WHERE transno=@transno", cdb)
        With cmd
            'cmd.Parameters.AddWithValue("@transno", tbTransNo.Text)
            'cmd.Parameters.AddWithValue("@ttype", ttype)
            'cmd.Parameters.AddWithValue("@date", dtpStockIn.Value)
            'cmd.Parameters.AddWithValue("@whscode", cboWhsCode.Text)
            'cmd.Parameters.AddWithValue("@supcode", cbxSupplier.Text)
            'cmd.Parameters.AddWithValue("@total", Decimal.Parse(tbTotal.Text))
            'cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
            'cmd.Parameters.AddWithValue("@pricetype", cboPriceType.Text)
            'cmd.Parameters.AddWithValue("@userid", tbUser.Text)
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        'END UPDATE IVH

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0
        Dim whsecode As String = Nothing

        whsecode = cboWhsCode.SelectedItem.value
        ' MsgBox(prevwhse)
        'update edited item
        With dgvItem 'sa pagdugang ni
            For x As Integer = 0 To rwupd - 1
                Dim upitc As String = Nothing
                Dim upqty As Decimal = 0
                Dim uppck As Decimal = 0
                Dim upwhs As String = Nothing
                Dim uppkno As String = Nothing

                curqty = 0
                nwqty = 0

                upitc = listupd(x).c1uitem
                upqty = listupd(x).c1upqty
                upwhs = listupd(x).c1whse
                uppck = listupd(x).c1upckg
                uppkno = listupd(x).c1upkno

                Dim totpck As Decimal = 0
                totpck = upqty * uppck

                cmd = New MySqlCommand("SELECT item,qty_good FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
                cmd.Parameters.AddWithValue("@itm", upitc)
                cmd.Parameters.AddWithValue("@wh", upwhs)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        rd.Read()
                        curqty = rd("qty_good").ToString
                    End If
                    rd.Close()
                End Using
                cmd.Dispose()

                nwqty = curqty - totpck
                'If rwrmv < 1 Then 'meaning 0

                'Else
                cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
                cmd.Parameters.AddWithValue("@itm", upitc)
                cmd.Parameters.AddWithValue("@wh", upwhs)
                cmd.Parameters.AddWithValue("@qtyg", nwqty)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'End If
            Next
            curqty = 0
            nwqty = 0

            'update remove item

            ' If rwrmv < 1 Then 'meaning 0 ===>>>>>>>>RICHEL

            '  Else
            For x As Integer = 0 To rwrmv - 1
                Dim rmvitc As String = Nothing
                Dim rmvqty As Decimal = 0
                Dim rmvpkno As String = Nothing
                Dim rmvunit As String = Nothing
                Dim rmvpckg As Decimal = 0

                rmvitc = listrmv(x).c1item
                rmvqty = listrmv(x).c1qty
                rmvpkno = listrmv(x).c1pkno
                rmvunit = listrmv(x).c1unit
                rmvpckg = listrmv(x).c1pckg

                ' delstat = 1
                'cmd = New MySqlCommand("UPDATE ivd SET isdeleted='1' WHERE transno=@tno AND item=@itemc", cdb)
                cmd = New MySqlCommand("UPDATE ivd SET isdeleted='1' WHERE transno=@tno AND item=@itemc AND pkno=@pno", cdb)
                cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
                cmd.Parameters.AddWithValue("@itemc", rmvitc)
                cmd.Parameters.AddWithValue("@pno", rmvpkno)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("SELECT item,qty_good FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
                cmd.Parameters.AddWithValue("@itm", rmvitc)
                cmd.Parameters.AddWithValue("@wh", .Item(10, i).Value)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        rd.Read()
                        curqty = rd("qty_good").ToString
                    End If
                    rd.Close()
                End Using
                cmd.Dispose()

                Dim totalqty As Integer = 0

                If rmvunit = "C" Or rmvunit = "B" Then
                    totalqty = rmvqty * IIf(rmvpckg > 0, rmvpckg, 1)
                ElseIf rmvunit = "P" Then
                    totalqty = rmvqty
                End If

                nwqty = curqty - totalqty

                cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
                cmd.Parameters.AddWithValue("@itm", rmvitc)
                cmd.Parameters.AddWithValue("@wh", .Item(10, i).Value)
                cmd.Parameters.AddWithValue("@qtyg", nwqty)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            Next

            'reset_listrmv()
            'reset_listupd()
            For i = 0 To .RowCount - 1
                If .Item(3, i).Value <> Nothing Then 'qty <> nothing
                    If .Item(3, i).Value > 0 Then 'qty > 0
                        Dim fnd1 As Boolean = False

                        'cmd = New MySqlCommand("SELECT item FROM salesd WHERE pkno=@pno and transno=@tno", cdb)
                        cmd = New MySqlCommand("SELECT item FROM ivd WHERE pkno=@pno and transno=@tno", cdb)
                        cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
                        cmd.Parameters.AddWithValue("@pno", .Item(8, i).Value)
                        Using rd As MySqlDataReader = cmd.ExecuteReader
                            If rd.HasRows Then
                                fnd1 = True
                            End If
                        End Using
                        cmd.Dispose()

                        If fnd1 = True Then
                            'UPDATE IVD HERE
                            cmd = New MySqlCommand("UPDATE ivd SET transno=@transno,ttype=@ttype,date=@date,whs=@whs,supcode=@supcode,item=@item,qty=@qty,qunit=@qunit,pckg=@pckg,price=@price,amount=@amount WHERE transno=@transno AND pkno=@pkno", cdb)
                            cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
                            'cmd.Parameters.AddWithValue("@ttype", ttype)
                            cmd.Parameters.AddWithValue("@date", sDate.Value)
                            cmd.Parameters.AddWithValue("@whs", cboWhsCode.Text.Trim) '.Item(10, i).Value) 'cbxWarehouse.Text.Trim)
                            'cmd.Parameters.AddWithValue("@supcode", cbxSupplier.Text)
                            cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@qty", .Item(3, i).Value)
                            cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                            cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                            cmd.Parameters.AddWithValue("@price", Decimal.Parse(.Item(6, i).Value))
                            cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                            cmd.Parameters.AddWithValue("@pkno", .Item(8, i).Value)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        Else
                            'SAVE TO IVD HERE
                            cmd = New MySqlCommand("INSERT INTO ivd (transno,ttype,date,whs,supcode,item,qty,qunit,pckg, " & _
                                                  "price,amount) VALUES (@transno,@ttype,@date,@whs,@supcode,@item,@qty,@qunit,@pckg,@price,@amount)", cdb)
                            cmd.Parameters.AddWithValue("@transno", txtTransno.Text)
                            'cmd.Parameters.AddWithValue("@ttype", ttype)
                            cmd.Parameters.AddWithValue("@date", sDate.Value)
                            cmd.Parameters.AddWithValue("@whs", cboWhsCode.Text.Trim) '.Item(10, i).Value) 'cbxWarehouse.Text)
                            'cmd.Parameters.AddWithValue("@supcode", cbxSupplier.Text)
                            cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@qty", .Item(3, i).Value)
                            cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                            cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                            cmd.Parameters.AddWithValue("@price", Decimal.Parse(.Item(6, i).Value))
                            cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End If
                End If
            Next
        End With

        'update to ivwh
        'With dgvItem

        '    ' Dim cmd2 As MySqlCommand
        '    Dim presentitem As String = Nothing
        '    Dim previtem As String = Nothing

        '    For i = 0 To .RowCount - 1
        '        If .Item(3, i).Value <> Nothing Then 'qty <> nothing
        '            If .Item(3, i).Value > 0 Then 'qty > 0
        '                Dim totalqty As Decimal = 0

        '                'If itemunit = "C" Or itemunit = "B" Then
        '                '    totalqty = itemqty * IIf(itempkcg > 0, itempkcg, 1)
        '                'ElseIf itemunit = "P" Then
        '                '    totalqty = itemqty
        '                'End If

        '                If .Item(4, i).Value = "C" Or .Item(4, i).Value = "B" Then
        '                    totalqty = .Item(3, i).Value * IIf(.Item(5, i).Value > 0, .Item(5, i).Value, 1)
        '                ElseIf .Item(4, i).Value = "P" Then
        '                    totalqty = .Item(3, i).Value
        '                End If

        '                Dim fnds As Boolean = False
        '                curqty = 0

        '                presentitem = .Item(1, i).Value 'ITEMCODE => new item
        '                previtem = .Item(9, i).Value 'Previous ITEMCODE

        '                cmd = New MySqlCommand("SELECT item,qty_good FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
        '                cmd.Parameters.AddWithValue("@itm", previtem)
        '                cmd.Parameters.AddWithValue("@wh", .Item(10, i).Value) 'prev warehouse
        '                Using rd As MySqlDataReader = cmd.ExecuteReader
        '                    If rd.HasRows Then
        '                        fnds = True
        '                        rd.Read()
        '                        curqty = rd("qty_good").ToString 'get the Current Quantity
        '                        rd.Close()
        '                    End If

        '                End Using
        '                cmd.Dispose()

        '                Dim itmqty As Decimal = 0
        '                Dim difqty As Decimal = 0

        '                itmqty = .Item(5, i).Tag 'totalqty -> tagged From Retreive 
        '                If previtem = presentitem Then 'if no changes sa item
        '                    difqty = itmqty - totalqty
        '                    If itmqty > totalqty Then
        '                        difqty = curqty - difqty
        '                    ElseIf itmqty = totalqty Then
        '                        difqty = curqty   '  difqty = itmqty
        '                    ElseIf totalqty > itmqty Then
        '                        difqty = totalqty - itmqty
        '                        difqty = curqty + difqty
        '                    End If
        '                Else
        '                    difqty = totalqty
        '                End If

        '                If fnds = False Then

        '                    If isExistWarehouseAndItem(cboWhsCode.Text.Trim, .Item(1, i).Value) Then
        '                        Dim qtyexisting As Integer = getCurrentQTYSaExisting(cboWhsCode.Text.Trim, .Item(1, i).Value)
        '                        'Dim qtyexistingAdd As Integer = qtyexisting + totalqty
        '                        Dim qtyexistingAdd As Integer = qtyexisting - totalqty
        '                        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
        '                        cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
        '                        cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim) 'current warehouse
        '                        cmd.Parameters.AddWithValue("@qtyg", qtyexistingAdd)
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()
        '                    Else
        '                        cmd = New MySqlCommand("INSERT INTO ivwh (item,whs,qty_good) VALUES (@itm,@wh,@qtyg)", cdb)
        '                        cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
        '                        cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
        '                        cmd.Parameters.AddWithValue("@qtyg", totalqty)
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()
        '                    End If

        '                Else

        '                    If isExistWarehouseAndItem(cboWhsCode.Text.Trim, .Item(1, i).Value) Then
        '                        Dim qtyexisting As Integer = getCurrentQTYSaExisting(cboWhsCode.Text.Trim, .Item(1, i).Value)
        '                        Dim qtyexistingAdd As Integer = qtyexisting + difqty

        '                        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
        '                        cmd.Parameters.AddWithValue("@itm", .Item(9, i).Value)
        '                        cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim) 'current warehouse
        '                        cmd.Parameters.AddWithValue("@qtyg", qtyexistingAdd)
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()

        '                        If curqty <= totalqty Then

        '                            If cboWhsCode.Text.Trim = .Item(10, i).Value Then 'current warehouse = prev warehouse 'if walay changes gyud sa ITEM' 1-29-2020 

        '                            Else
        '                                difqty = 0
        '                            End If

        '                        Else

        '                        End If

        '                        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
        '                        cmd.Parameters.AddWithValue("@itm", .Item(9, i).Value)
        '                        cmd.Parameters.AddWithValue("@wh", .Item(10, i).Value) 'prev warehouse
        '                        cmd.Parameters.AddWithValue("@qtyg", difqty)
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()

        '                    Else
        '                        'cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg, item=@itmchange, whs=@whchange WHERE item=@itm AND whs=@wh", cdb)
        '                        'cmd.Parameters.AddWithValue("@itmchange", .Item(1, i).Value)
        '                        'cmd.Parameters.AddWithValue("@whchange", cbxWarehouse.Text.Trim) 'current warehouse
        '                        'cmd.Parameters.AddWithValue("@itm", .Item(12, i).Value)
        '                        'cmd.Parameters.AddWithValue("@wh", .Item(13, i).Value) 'prev warehouse
        '                        'cmd.Parameters.AddWithValue("@qtyg", difqty)
        '                        'cmd.ExecuteNonQuery()
        '                        'cmd.Dispose()

        '                        If isExistWarehouseAndItem(.Item(10, i).Value, .Item(1, i).Value) Then

        '                            If curqty <= totalqty Then
        '                                difqty = 0
        '                            Else

        '                            End If

        '                            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
        '                            cmd.Parameters.AddWithValue("@itm", .Item(9, i).Value)
        '                            cmd.Parameters.AddWithValue("@wh", .Item(10, i).Value) 'prev warehouse
        '                            cmd.Parameters.AddWithValue("@qtyg", difqty)
        '                            cmd.ExecuteNonQuery()
        '                            cmd.Dispose()
        '                        End If
        '                        cmd = New MySqlCommand("INSERT INTO ivwh (item,whs,qty_good) VALUES (@itm,@wh,@qtyg)", cdb)
        '                        cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
        '                        cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
        '                        cmd.Parameters.AddWithValue("@qtyg", totalqty)
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()
        '                    End If

        '                End If

        '            End If
        '        End If
        '    Next
        '    reset_listrmv()
        '    reset_listupd()
        '    reset_listadded()
        '    prevwhse = whsecode
        '    editeditem = 0
        'End With
        'END NEW PROCESS



    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click

        If cboWhsCode.Text = "" Then
            MsgBox("Warehouse is required", vbCritical)
            Exit Sub
        End If

        With dgvItem

            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()

            If .RowCount > 0 Then
                Dim asave As Boolean = True

                For i = 0 To .Rows.Count - 1
                    'If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                    If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                        asave = False
                    End If
                Next

                If asave = True Then

                    'GenerateStockInNo()
                    'SaveStockIn()
                    MsgBox("Misc. Stock In Has Been Save Successfully", vbInformation)
                    'StockInPrint()
                    'ClearStockIn()

                    With frmStockInH
                        .LoadStockIn()
                    End With

                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If
            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With


    End Sub

    Sub PhysicalInvPrint()
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvItem
            mmax = .RowCount
            pbar1.Maximum = mmax

            dtStockIn.Rows.Clear()
            Dim chkflag As Boolean = False
            'grpno = 10
            grpno = 30
            Dim cntr As Integer = 0
            Dim grid As Integer = 1



            If .RowCount > 0 Then
                'pbar1.Visible = True
                'pbar1.Maximum = .RowCount
                'pbar1.Value = 0


                .EndEdit()

                For i = 0 To .RowCount - 1
                    'pbar1.Value += 1
                    'pbar1.Refresh()
                    ' r1 = dt.NewRow()
                    pbar1.Value += 1
                    cntr += 1
                    r1 = dtStockIn.NewRow()

                    'r1("date") = dtpStockIn.Value.ToString("MM/dd/yyyy")
                    'r1("pricetype") = cboPriceType.Text.ToString
                    ''r1("supplier") = cbxSupplier.Text.ToString
                    'r1("supplier") = tbSupplier.Text.ToString
                    ''r1("warehouse") = cbxWarehouse.Text.ToString
                    'r1("warehouse") = tbWhsName.Text.ToString
                    'r1("remarks") = txtRemarks.Text.ToString
                    'r1("userid") = tbUser.Text.ToString
                    'r1("transno") = tbTransNo.Text.ToString
                    'r1("total") = tbTotal.Text.ToString
                    'r1("qty") = Format(CDbl(IIf(.Item(3, i).Value = Nothing, DBNull.Value, .Item(3, i).Value)), "#.##0")
                    'r1("itemcode") = IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    'r1("description") = IIf(.Item(2, i).Value = Nothing, DBNull.Value, .Item(2, i).Value)
                    'r1("unit") = IIf(.Item(4, i).Value = Nothing, DBNull.Value, .Item(4, i).Value)
                    'r1("pckg") = IIf(.Item(5, i).Value = Nothing, DBNull.Value, .Item(5, i).Value)
                    'r1("uprice") = IIf(.Item(6, i).Value = Nothing, DBNull.Value, .Item(6, i).Value)
                    'r1("amount") = IIf(.Item(7, i).Value = Nothing, DBNull.Value, .Item(7, i).Value)
                    'r1("totqtyc") = lblCase.Text.ToString
                    'r1("totqtyb") = lblBag.Text.ToString
                    'r1("totqtyp") = lblPc.Text.ToString
                    'r1("grpno") = grid

                    pbar1.Refresh()
                    dtStockIn.Rows.Add(r1)
                    ' pbar1.Refresh()

                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next

                'pbar1.Visible = False
                prep = New rptStockIn
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

    Sub RetrieveStockIn(ByVal trno As String)

        'With dgvItem
        '    Dim cmd As MySqlCommand
        '    Dim rw As Integer = 0
        '    Dim x As Integer = 0
        '    Dim mytrans As String = Nothing

        '    .Rows.Clear()

        '    cmd = New MySqlCommand("SELECT h.*,s.suppliername,w.warehouse FROM ivh h " & _
        '                           " LEFT JOIN supplier s ON h.supcode=s.supcode " & _
        '                           " LEFT JOIN warehouse w ON h.whscode=w.whscode WHERE transno=@tn", cdb)
        '    cmd.Parameters.AddWithValue("@tn", trno)
        '    Using rd As MySqlDataReader = cmd.ExecuteReader
        '        If rd.HasRows Then
        '            rd.Read()
        '            dtpStockIn.Value = rd("date").ToString
        '            cboPriceType.Text = rd("pricetype").ToString
        '            tbTransNo.Text = rd("transno").ToString
        '            cbxSupplier.SelectedIndex = setselindex(cbxSupplier, rd("supcode").ToString)
        '            tbSupplier.Text = rd("suppliername").ToString
        '            cboWhsCode.SelectedIndex = setselindex(cboWhsCode, rd("whscode").ToString)
        '            txtRemarks.Text = rd("remarks").ToString
        '            prevwhse = rd("whscode").ToString
        '            tbWhsName.Text = rd("warehouse").ToString
        '            tbUser.Text = rd("userid").ToString
        '            tbTotal.Text = Format(Math.Round(Decimal.Parse(rd("total").ToString), _
        '                                                2, MidpointRounding.AwayFromZero), "STANDARD")
        '        End If
        '        rd.Close()
        '    End Using
        '    cmd.Dispose()

        '    cmd = New MySqlCommand("SELECT r.*,r.pkno as pno, t.description from ivd r " & _
        '                           "LEFT JOIN ivitem t ON r.item=t.itemcode WHERE transno=@tn and r.isdeleted='0' Order by r.pkno Asc", cdb) ' '" & tbCustCode.Text & "'", cdb)
        '    cmd.Parameters.AddWithValue("@tn", trno)
        '    Using rd As MySqlDataReader = cmd.ExecuteReader
        '        If rd.HasRows Then
        '            x = 0
        '            Dim totalqty As Decimal = 0
        '            While rd.Read
        '                .RowCount += 1
        '                rw = .RowCount - 1
        '                x += 1
        '                .Item(0, rw).Value = x
        '                .Item(1, rw).Value = rd("ITEM").ToString
        '                .Item(2, rw).Value = rd("description").ToString
        '                .Item(3, rw).Value = Format(CDbl(rd("QTY").ToString), "#,##0")
        '                .Item(4, rw).Value = rd("qunit").ToString
        '                .Item(5, rw).Value = rd("PCKG").ToString

        '                If rd("qunit").ToString = "C" Or rd("qunit").ToString = "B" Then
        '                    totalqty = rd("QTY").ToString * IIf(rd("PCKG").ToString > 0, rd("PCKG").ToString, 1)
        '                ElseIf rd("qunit").ToString = "P" Then
        '                    totalqty = rd("QTY").ToString
        '                End If
        '                .Item(5, rw).Tag = totalqty
        '                .Item(6, rw).Value = Format(Math.Round(Decimal.Parse(rd("price").ToString), _
        '                                                       2, MidpointRounding.AwayFromZero), "STANDARD")
        '                .Item(7, rw).Value = Format(Math.Round(Decimal.Parse(rd("amount").ToString), _
        '                                                       2, MidpointRounding.AwayFromZero), "STANDARD")
        '                .Item(8, rw).Value = rd("pno").ToString
        '                .Item(9, rw).Value = rd("ITEM").ToString
        '                .Item(10, rw).Value = rd("whs").ToString

        '                'temporarily trap
        '                '.Item(1, rw).ReadOnly = True
        '                '.Item(2, rw).ReadOnly = True
        '                '.Item(3, rw).ReadOnly = True
        '                '.Item(4, rw).ReadOnly = True
        '                '.Item(5, rw).ReadOnly = True
        '                '.Item(6, rw).ReadOnly = True
        '                '.Item(7, rw).ReadOnly = True
        '                'end trap

        '            End While
        '            rd.Close()

        '        End If
        '    End Using

        '    cmd = New MySqlCommand("SELECT * FROM useraccnt where username=@uname", cdb)
        '    cmd.Parameters.AddWithValue("@uname", tbUser.Text)
        '    Using rd As MySqlDataReader = cmd.ExecuteReader
        '        If rd.HasRows Then
        '            rd.Read()
        '            tbUser.Text = rd("username").ToString
        '        End If
        '        rd.Close()
        '    End Using

        '    .Focus()
        'End With

        'cboPriceType.Enabled = False
        'btnUpdate.Enabled = False
        'btnUpdatePrint.Enabled = False
        'btnAdd.Enabled = False
        'btnSearch.Enabled = False
        'btnRemove.Enabled = False
        'txtRemarks.Enabled = False
        'cbxSupplier.Enabled = False
        'cboWhsCode.Enabled = False
        'dgvItem.ReadOnly = True
        ''dgvItem.Enabled = False

    End Sub

    'Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    '    '  StockInPrint()
    'End Sub


    'Private Sub btnUpdatePrint_Click(sender As Object, e As EventArgs) Handles btnUpdatePrint.Click
    '    With dgvItem

    '        If .RowCount = 0 Then
    '            MsgBox("No item(s) found!", vbExclamation)
    '            Return
    '        End If

    '        DeleteBlankRow()

    '        If cboWhsCode.Text <> Nothing Then
    '            If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
    '                Dim asave As Boolean = True

    '                For i = 0 To .Rows.Count - 1
    '                    If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
    '                        'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
    '                        asave = False
    '                    End If
    '                Next

    '                If asave = True Then
    '                    .EndEdit(True)
    '                    '  UpdateStockIn()
    '                    MsgBox("Misc. Stock In Has Been Updated Successfully.", vbInformation)
    '                    '   StockInPrint()
    '                    'ClearStockIn()

    '                    With frmStockInH
    '                        .LoadStockIn()
    '                    End With
    '                Else
    '                    MsgBox("Please input a valid quantity,item/s first", 48, "Invalid quantity,item/s found")
    '                End If

    '            End If
    '        Else
    '            MsgBox("Please select supplier and warehouse first!", 48, "Select First")
    '        End If

    '    End With
    'End Sub

    Private Sub txtRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks.KeyPress
        If e.KeyChar = vbCr Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Sub CalcTotalQty()
        'With dgvItem
        '    Dim TotCase As Decimal = 0
        '    Dim TotBags As Decimal = 0
        '    Dim TotPcs As Decimal = 0

        '    For Each Qty As DataGridViewRow In dgvItem.Rows
        '        If Qty.Cells(4).Value = "C" Then
        '            TotCase += Qty.Cells(3).Value
        '            lblCase.Text = TotCase
        '        ElseIf Qty.Cells(4).Value = "B" Then
        '            TotBags += Qty.Cells(3).Value
        '            lblBag.Text = TotBags
        '        ElseIf Qty.Cells(4).Value = "P" Then
        '            TotPcs += Qty.Cells(3).Value
        '            lblPc.Text = TotPcs
        '        End If
        '    Next
        'End With

    End Sub

    'Private Sub cboPriceType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPriceType.KeyPress
    '    e.Handled = True
    'End Sub

    'Private Sub btnCalculateTotalQty_Click(sender As Object, e As EventArgs) Handles btnCalculateTotalQty.Click
    '    With dgvItem
    '        Dim TotCase As Decimal = 0
    '        Dim TotBags As Decimal = 0
    '        Dim TotPcs As Decimal = 0

    '        For Each Col As DataGridViewRow In dgvItem.Rows
    '            If Col.Cells(4).Value = "C" Then
    '                TotCase += Col.Cells(3).Value
    '                lblCase.Text = TotCase
    '            ElseIf Col.Cells(4).Value = "B" Then
    '                TotBags += Col.Cells(3).Value
    '                lblBag.Text = TotBags
    '            ElseIf Col.Cells(4).Value = "P" Then
    '                TotPcs += Col.Cells(3).Value
    '                lblPc.Text = TotPcs
    '            End If
    '        Next
    '    End With
    'End Sub

    ' Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    'dgvItem.Enabled = True
    'cboPriceType.Enabled = True
    ''cbxSupplier.Enabled = True
    'cboWhsCode.Enabled = True
    'btnUpdate.Enabled = True
    'btnUpdatePrint.Enabled = True
    'btnAdd.Enabled = True
    'btnSearch.Enabled = True
    'btnRemove.Enabled = True
    'txtRemarks.Enabled = True
    'btnEdit.Enabled = False
    'btnPrint.Enabled = False

    'dgvItem.ReadOnly = False
    'dgvItem.Columns(2).ReadOnly = True
    'dgvItem.Columns(0).ReadOnly = True
    'dgvItem.Columns(5).ReadOnly = True
    'dgvItem.Columns(6).ReadOnly = True
    'dgvItem.Columns(7).ReadOnly = True

    '  End Sub

    Private Sub btnCloseI_Click(sender As Object, e As EventArgs) Handles btnCloseI.Click
        gbxItemList.SendToBack()
        gbxItemList.Visible = False
    End Sub

    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        load_items()
    End Sub

    Dim editeditem As Integer = 0

    Private Sub dgvItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellEndEdit

        '=== NEW PROCESS === => COCOY
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0

                mrw = e.RowIndex
                ' act = .Item(7, mrw).Value
                If e.ColumnIndex = 1 Then
                    Dim itemno As String = Nothing

                    itemno = .Item(1, mrw).Value

                    If itemno <> Nothing And itemno <> " " Then
                        .Item(1, mrw).Value = UCase(itemno)
                        itemno = .Item(1, mrw).Value

                        If getitem_byid(itemno, mrw) Then
                            If checkitemno_update(itemno, mrw) = True Then
                                MsgBox("Item already on the list!", 64, "Item added")
                                clear_row_if_item_found(mrw)
                                Exit Sub
                            End If

                        End If
                    End If
                    .ClearSelection()
                    If .Item(1, mrw).Value <> Nothing Then
                        selrow = mrw
                        If .Item(1, mrw).Value <> .Item(9, mrw).Value Then
                            Dim oldqty As Decimal = 0

                            '======
                            Dim mpc As String = Nothing
                            itemno = .Item(1, mrw).Value
                            mpc = .Item(4, mrw).Value

                            Dim nwtotalqty As Decimal = 0
                            ReDim Preserve listrmv(rwrmv)
                            With listrmv(rwrmv)
                                .c1item = dgvItem.Item(9, mrw).Value 'PREV ITEM
                                '.c1unit = dgvItem.Item(4, mrw).Tag
                                '.c1pckg = dgvItem.Item(5, mrw).Value

                                '.c1qty = nwtotalqty
                                .c1pkno = dgvItem.Item(8, mrw).Tag 'PREV PKNO
                                .c1whs = dgvItem.Item(10, mrw).Value
                                rwrmv += 1
                            End With
                        End If
                        'PREV ITEM
                       

                        Dim method As New SetColumnIndex(AddressOf Mymethod)
                        Dim nextindex As Integer = 3
                        Me.dgvItem.BeginInvoke(method, nextindex)
                    End If
                ElseIf e.ColumnIndex = 3 Then
                    .ClearSelection()
                    If .Item(3, mrw).Value <> Nothing Then
                        selrow = mrw
                        ' MsgBox(.Item(6, mrw).Value)
                        If .Item(6, mrw).Value <= 1 Then
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 7
                            Me.dgvItem.BeginInvoke(method, nextindex)
                        Else
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 5
                            Me.dgvItem.BeginInvoke(method, nextindex)
                        End If
                    End If
                ElseIf e.ColumnIndex = 5 Then
                    .ClearSelection()
                    If .Item(6, mrw).Value <> Nothing And .Item(6, mrw).Value >= 1 Then
                        selrow = mrw
                        Dim method As New SetColumnIndex(AddressOf Mymethod)
                        Dim nextindex As Integer = 7
                        Me.dgvItem.BeginInvoke(method, nextindex)
                    End If
                ElseIf e.ColumnIndex = 7 Then
                    .ClearSelection()
                    btnAdd.PerformClick()
                End If
            End If



        End With

        '=== END NEW PROCESS ===

    End Sub

    Private Sub dgvItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellContentClick
        Dim colName As String = dgvItem.Columns(e.ColumnIndex).Name
        If colName = "colDelete" Then
            If MsgBox("Delete this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then

                ReDim Preserve listrmv(rwrmv)
                With listrmv(rwrmv)
                    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                    .c1qty = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
                    .c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag
                End With

                'cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' where transno=@tno AND item =@itemc", cdb)
                'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
                'cmd.Parameters.AddWithValue("@itemc", dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value)
                'cmd.ExecuteNonQuery()
                rwrmv += 1
                dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))

                ' ComputeStockInTotal()
                ' CalcTotalQty()
                'btnCalculateTotalQty.PerformClick()

                'Dim itemunit As String = dgvRcvItem.Rows(e.RowIndex).Cells(4).Value.ToString
                'Dim itemqty As Decimal = Val(dgvRcvItem.Item(3, dgvRcvItem.CurrentRow.Index).Value)
                'Dim itempkcg As Integer = Val(dgvRcvItem.Item(5, dgvRcvItem.CurrentRow.Index).Value)
                'Dim totalqty As Decimal = Nothing

                'Dim r1 As DataGridViewRow
                'r1 = New DataGridViewRow
                'r1.CreateCells(dgforDelete)



                'If itemunit = "C" Or itemunit = "B" Then
                '    totalqty = itemqty * IIf(itempkcg > 0, itempkcg, 1)
                'ElseIf itemunit = "P" Then
                '    totalqty = itemqty
                'End If

                'r1.Cells(1).Value = dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value 'Item_code
                'r1.Cells(3).Value = itemqty
                'r1.Cells(4).Value = itemunit
                'r1.Cells(5).Value = itempkcg


                'dgforDelete.Rows.Add(r1)
                ' MsgBox("item has been Deleted!", vbInformation)
            End If
        End If
    End Sub

    Private Sub dgvItemList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvItemList.KeyDown
        With dgvItemList
            If .RowCount > 0 Then
                If e.KeyCode = Keys.Enter Then
                    load_items()
                End If
            End If
        End With
    End Sub

    Private Sub dgvItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvItem.KeyPress
        With dgvItem
            If .Rows.Count > 0 Then
                If Asc(e.KeyChar) = 13 Then
                    If .CurrentCell.ColumnIndex = 7 Then
                        btnAdd.PerformClick()
                    End If

                End If
            End If
        End With
    End Sub

    Sub RetrievePhyivD(ByVal trno As String)

        tsSave.Visible = False
        tsUpdate.Visible = True

        With dgvItem
            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            .Rows.Clear()
            Dim checkopen As String()

            checkopen = check_if_trans_is_open(trno, "phyivh", _user)

            If checkopen(0) = True Then
                MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before editing/updating this transaction. ", 48, "TRANSACTION IS OPEN")
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
            End If

            'retrieve phyivh
            cmd = New MySqlCommand("SELECT h.*, w.warehouse FROM phyivh h LEFT JOIN warehouse w " & _
                                   "ON h.whscode=w.whscode WHERE isdeleted <> 1 And transno=@tn", cdb)
            cmd.Parameters.AddWithValue("@tn", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    txtTransno.Text = rd("transno").ToString
                    sDate.Value = rd("tdate").ToString
                    cboWhsCode.SelectedIndex = setselindex(cboWhsCode, rd("whscode").ToString)
                    txtWarehouse.Text = rd("whsname").ToString
                    txtRemarks.Text = rd("remarks").ToString
                    txtUser.Text = rd("user").ToString
                    prevwhse = rd("whscode").ToString
                End If
                rd.Close()
            End Using
            cmd.Dispose()

            'retrieve from phyivd
            cmd = New MySqlCommand("SELECT d.*,d.pkno as pno, i.description from phyivd d " & _
                                    "LEFT JOIN ivitem i ON d.itemcode=i.itemcode " & _
                                    "WHERE transno=@tn AND d.isdeleted='0' Order by d.pkno Asc", cdb)
            cmd.Parameters.AddWithValue("@tn", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    x = 0
                    Dim totalqty As Decimal = 0

                    While rd.Read
                        .RowCount += 1
                        rw = .RowCount - 1
                        x += 1
                        .Item(0, rw).Value = x
                        .Item(1, rw).Value = rd("itemcode").ToString
                        .Item(2, rw).Value = rd("description").ToString
                        .Item(3, rw).Value = Format(CDbl(rd("qtyc").ToString), "#0")
                        .Item(4, rw).Value = rd("pckgc").ToString
                        .Item(5, rw).Value = Format(CDbl(rd("qtyb").ToString), "#0")
                        .Item(6, rw).Value = rd("pckgb").ToString
                        .Item(7, rw).Value = Format(CDbl(rd("qtyp").ToString), "#0")
                        .Item(8, rw).Value = rd("pkno").ToString
                        .Item(9, rw).Value = rd("itemcode").ToString
                        .Item(10, rw).Value = rd("whscode").ToString

                    End While
                    rd.Close()
                End If
            End Using

            'cmd = New MySqlCommand("SELECT * FROM useraccnt where username=@uname", cdb)
            'cmd.Parameters.AddWithValue("@uname", txtUser.Text)
            'Using rd As MySqlDataReader = cmd.ExecuteReader
            '    If rd.HasRows Then
            '        rd.Read()
            '        txtUser.Text = rd("username").ToString
            '    End If
            '    rd.Close()
            'End Using

            .Focus()
        End With
    End Sub

    Private Sub btnCloseD_Click(sender As Object, e As EventArgs) Handles btnCloseD.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "PHYSICAL INVENTORY ENTRY") = vbYes Then
            Dim trno As String = Nothing

            trno = txtTransno.Text.Trim()
            close_open_trans_by_user(trno, "phyivh", _user)
            Me.Dispose()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        With dgvItem
            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()

            If cboWhsCode.Text <> Nothing Then
                If MsgBox("Update changes?", vbYesNo + vbQuestion) = vbYes Then
                    Dim asave As Boolean = True

                    For i = 0 To .Rows.Count - 1
                        If .Item(3, i).Value = 0 And .Item(5, i).Value = 0 And .Item(7, i).Value = 0 Then
                            'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            asave = False
                        End If
                    Next

                    If asave = True Then
                        .EndEdit(True)
                        updatephysicald()

                        clearphysicald()
                        Me.Dispose()

                        With frmStockInH
                            .LoadStockIn()
                        End With
                    Else
                        MsgBox("Please input a valid quantity,item/s first", 48, "Invalid quantity,item/s found")
                    End If

                End If
            Else
                MsgBox("Please select supplier and warehouse first!", 48, "Select First")
            End If

        End With
    End Sub
    Sub updatephysicald()

        With dgvItem

            For x = 0 To rwrmv - 1

                Dim rmvitc As String = Nothing
                Dim rmvqty As Decimal = 0
                Dim rmvpkno As String = Nothing
                Dim rmvunit As String = Nothing
                Dim rmvpckg As Decimal = 0
                Dim rmvwhse As String = Nothing
                If rmvitc <> Nothing Then
                    rmvitc = listrmv(x).c1item
                    ' rmvqty = listrmv(x).c1qty
                    rmvpkno = listrmv(x).c1pkno
                    'rmvunit = listrmv(x).c1unit
                    'rmvpckg = listrmv(x).c1pckg
                    rmvwhse = listrmv(x).c1whs
                    Using cmd = New MySqlCommand("UPDATE phyivd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc AND pkno=@pno", cdb)
                        cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
                        cmd.Parameters.AddWithValue("@itemc", rmvitc)
                        cmd.Parameters.AddWithValue("@pno", rmvpkno)
                        cmd.ExecuteNonQuery()
                    End Using

                End If
            Next

            For i = 0 To .RowCount - 1

                Dim tno As String = Nothing
                Dim itmc As String = Nothing
                Dim whse As String = Nothing
                Dim pkno As String = Nothing

                Dim q_cases As Decimal = 0
                Dim q_bags As Decimal = 0
                Dim q_pcs As Decimal = 0

                Dim q_pck_case As Decimal = 0
                Dim q_pck_bag As Decimal = 0

                itmc = .Item(1, i).Value
                pkno = .Item(8, i).Value
                whse = cboWhsCode.Text

                q_cases = IIf(.Item(3, i).Value <> Nothing, Decimal.Parse(.Item(3, i).Value), 0)
                q_pck_case = IIf(.Item(4, i).Value <> Nothing, Decimal.Parse(.Item(4, i).Value), 0)

                q_bags = IIf(.Item(5, i).Value <> Nothing, Decimal.Parse(.Item(5, i).Value), 0)
                q_pck_bag = IIf(.Item(6, i).Value <> Nothing, Decimal.Parse(.Item(6, i).Value), 0)

                q_pcs = IIf(.Item(7, i).Value <> Nothing, Decimal.Parse(.Item(7, i).Value), 0)


                Dim fnd1 As Boolean = False

                Dim mytransno As String = Nothing

                mytransno = txtTransno.Text.Trim()

                fnd1 = check_if_item_is_found_intab(itmc, "phyivd", whse, mytransno)

                If fnd1 = True Then
                    Using cmd = New MySqlCommand("UPDATE phyivd SET qtyc=@qc, qtyb=@qb, qtyp=@qp, pckgc=@pckc, pckgb=@pckb, tdate=@td WHERE transno=@tno AND itemcode=@itemc AND pkno=@pno", cdb)


                        cmd.Parameters.AddWithValue("@tno", mytransno)
                        cmd.Parameters.AddWithValue("@itemc", itmc)
                        cmd.Parameters.AddWithValue("@pno", pkno)
                        cmd.Parameters.AddWithValue("@td", sDate.Value)
                        cmd.Parameters.AddWithValue("@qc", q_cases)
                        cmd.Parameters.AddWithValue("@pckc", q_pck_case)
                        cmd.Parameters.AddWithValue("@qb", q_bags)
                        cmd.Parameters.AddWithValue("@pckb", q_pck_bag)
                        cmd.Parameters.AddWithValue("@qp", q_pcs)


                        cmd.ExecuteNonQuery()
                    End Using
                Else
                    Using cmd = New MySqlCommand("INSERT INTO phyivd(transno,itemcode,whscode,tdate,qtyc, qtyb, qtyp, pckgc, pckgb) VALUES(@tno,@itemc,@whsc,@td,@qc,@qb,@qp,@pckc,@pckb)", cdb)


                        cmd.Parameters.AddWithValue("@tno", mytransno)
                        cmd.Parameters.AddWithValue("@itemc", itmc)
                        cmd.Parameters.AddWithValue("@whsc", cboWhsCode.Text)
                        cmd.Parameters.AddWithValue("@td", sDate.Value)
                        cmd.Parameters.AddWithValue("@qc", q_cases)
                        cmd.Parameters.AddWithValue("@pckc", q_pck_case)
                        cmd.Parameters.AddWithValue("@qb", q_bags)
                        cmd.Parameters.AddWithValue("@pckb", q_pck_bag)
                        cmd.Parameters.AddWithValue("@qp", q_pcs)


                        cmd.ExecuteNonQuery()
                    End Using
                End If
                
            Next
            MsgBox("Physical entry of inventory has been updated successfully.", vbInformation)
        End With

    End Sub
    Sub clearphysicald()

        cboWhsCode.Text = Nothing


        txtTransno.Text = ""
        txtRemarks.Text = ""

        dgvItem.Rows.Clear()
    End Sub
    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub tbnumonly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnumonly.KeyPress
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 48 Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then e.Handled = True
    End Sub

    Private Sub tbnumonly_TextChanged(sender As Object, e As EventArgs) Handles tbnumonly.TextChanged

    End Sub

    Private Sub dgvItem_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvItem.EditingControlShowing
        With dgvItem
            If .Rows.Count > 0 Then
                If .CurrentCell.ColumnIndex = 3 Or .CurrentCell.ColumnIndex = 5 Or .CurrentCell.ColumnIndex = 7 Then
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
                ElseIf .CurrentCell.ColumnIndex = 1 Then
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
                End If


            End If
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim mytrans As String = Nothing
        mytrans = txtTransno.Text.Trim()
        Dim fnd As Boolean = False
        cmd = New MySqlCommand("SELECT transno FROM phyivh  where transno=@tno AND POSTED='N'", cdb)
        cmd.Parameters.AddWithValue("@tno", mytrans)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                fnd = True
            End If
        End Using
        cmd.Dispose()

        If fnd = False Then
            btnUpdate.Enabled = False
            btnUpdatePrint.Enabled = False
            MsgBox("This transaction is already posted", 48, "Items on this transaction cannot be removed or modified")
        Else

            btnUpdate.Enabled = True
            btnUpdatePrint.Enabled = True
        End If
    End Sub
End Class