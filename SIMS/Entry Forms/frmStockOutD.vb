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

Public Class frmStockOutD

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

    Dim prevwhs As String = Nothing

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

    Sub GenerateStockOutNo()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        'cqry = "Select transno as tno FROM ivh ORDER BY pkno DESC LIMIT 1"
        cqry = "Select transno as tno FROM ivh ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While
            rcvtno = Strings.Right(mdr("tno").ToString, 9) + 1
            rcvtno = "O" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If

        If rcnt = 0 Then
            rcvtno = "O000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        txtTransNo.Text = rcvtno
    End Sub

    Sub LoadItemList()
        dgvItem.EndEdit()
        dgvItemList.Rows.Clear()
        '   dgvItemList.Focus()
        Dim i As Integer
        If cboSupplier.Text <> Nothing Then
            cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND supcode=@spc and isdeleted<>1 ORDER BY supplier ASC", cdb)
            cmd.Parameters.AddWithValue("@spc", cboSupplier.SelectedItem.value)
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

                If cboPriceType.Text = "A" Then
                    For i = 16 To 18
                        .Columns(i).Visible = True
                    Next
                    For i = 19 To 24
                        .Columns(i).Visible = False
                    Next
                ElseIf cboPriceType.Text = "B" Then
                    For i = 19 To 21
                        .Columns(i).Visible = True
                    Next
                    For i = 16 To 18
                        .Columns(i).Visible = False
                    Next
                    For i = 22 To 24
                        .Columns(i).Visible = False
                    Next
                ElseIf cboPriceType.Text = "C" Then
                    For i = 22 To 24
                        .Columns(i).Visible = True
                    Next
                    For i = 16 To 21
                        .Columns(i).Visible = False
                    Next
                End If

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
        End If

    End Sub

    Private Sub frmStockOutD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            If btnSearch.Enabled = False Then
                MsgBox("Click click edit button first!", vbExclamation)
            Else
                btnSearch_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            btnRemove_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            If gbxItemList.Visible = True Then
                gbxItemList.Visible = False
                gbxItemList.SendToBack()
            ElseIf gbxItemList.Visible = False Then
                If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion) = vbYes Then
                    Me.Dispose()
                End If
            End If
            'btnClose_Click(sender, e)
        End If
    End Sub

    Private Sub frmStockOutD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttype = "O"

        If txtUser.Text = Nothing Then
            txtUser.Text = _user
        End If
        prevwhs = cboWhsCode.Text
        If Me.Tag = 0 Then

            LoadSupplier()
            LoadWarehouse()
            reset_listrmv()
            reset_listupd()
            cboPriceType.Text = "A"
            txtTotal.Text = "0.00"
        End If

        CalcTotalQty()
    End Sub

    Private Sub DeleteBlankRow()
        For i = 0 To dgvItem.RowCount - 1
            If dgvItem.Rows(i).Cells(1).Value = Nothing Then
                dgvItem.Rows.Remove(dgvItem.Rows(i))
            End If
        Next
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

    Private Sub reset_listadded()
        'Reset person count and array
        rwadded = 0
        rwsnews = 0
        Erase listrowsadded
        Erase listadded
    End Sub

    Sub LoadSupplier()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cboSupplier.Items.Clear()
        cboSupplier.DisplayMember = "text"
        qry = "Select * from supplier ORDER BY suppliername"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cboSupplier.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("supcode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
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
                If ptype = "A" Then
                    If pck = "P" Then
                        apricep = rd("APRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("APRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("APRICEC").ToString
                    End If

                ElseIf ptype = "B" Then
                    If pck = "P" Then
                        apricep = rd("BPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("BPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("BPRICEC").ToString
                    End If
                ElseIf ptype = "C" Then
                    If pck = "P" Then
                        apricep = rd("CPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("CPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("CPRICEC").ToString
                    End If
                ElseIf ptype = "D" Then
                    If pck = "P" Then
                        apricep = rd("DPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("DPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("DPRICEC").ToString
                    End If
                ElseIf ptype = "E" Then
                    If pck = "P" Then
                        apricep = rd("EPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("EPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("EPRICEC").ToString
                    End If
                End If

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
                        'bgprice = (apricep / cpck) * bpck
                        bgprice = (apricep) * .Item(3, rx).Value 'compute the bag price
                        .Item(6, rx).Value = Format(apricep, "STANDARD") 'get the bag price
                        '.Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        '.Item(4, rx).Value = bpck
                        '.Item(5, rx).Value = costpc
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
        Dim fnd As Boolean
        fnd = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode,description,grscost, unit, PCKGC,netcost,costpc FROM ivitem WHERE ITEMCODE=@itm AND supcode=@spc and isdeleted<>1", cdb)
        cmd.Parameters.AddWithValue("@itm", itemno)
        cmd.Parameters.AddWithValue("@spc", cboSupplier.SelectedItem.value)
        With dgvItem
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()

                    .Item(2, rdx).Value = rd("description").ToString
                    .Item(4, rdx).Value = rd("unit").ToString
                    .Item(5, rdx).Value = rd("PCKGC").ToString
                    .Item(6, rdx).Value = rd("grscost").ToString
                    .Item(7, rdx).Value = rd("netcost").ToString
                    '.Item(8, rdx).Value = rd("costpc").ToString

                    fnd = True
                Else
                    ' .Item(1, rdx).tag=1
                    MsgBox("ITEM NO Not Found/Belong to this supplier!", 48, "No Record Found/Belong to this supplier!")
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

    Private Sub dgvItem_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvItem.KeyDown

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

    Sub ComputeStockOutTotal()

        Dim inTotal As Double = Nothing
        Dim iTotal As Double = Nothing
        Dim NetAmt As Double = Nothing


        For i = 0 To dgvItem.RowCount - 1
            iTotal += dgvItem.Rows(i).Cells(7).Value
            dgvItem.Rows(i).Cells(0).Value = i + 1
        Next

        Me.txtTotal.Text = Format((iTotal), sFmat)

    End Sub

    Sub CalcTotalQty()
        With dgvItem
            Dim TotCase As Decimal = 0
            Dim TotBags As Decimal = 0
            Dim TotPcs As Decimal = 0

            '--------richel----------
            'for display 0 if wala sa datagrid---
            Dim countC As Integer = 0
            Dim countB As Integer = 0
            Dim countP As Integer = 0
            '  Dim countK As Integer = 0 'kilo
            '--------- richel-------

            For Each Qty As DataGridViewRow In dgvItem.Rows
                If Qty.Cells(4).Value = "C" Then
                    TotCase += Qty.Cells(3).Value
                    lblCase.Text = TotCase
                    countC += 1

                ElseIf Qty.Cells(4).Value = "B" Then
                    TotBags += Qty.Cells(3).Value
                    lblBag.Text = TotBags

                    countB += 1
                ElseIf Qty.Cells(4).Value = "P" Then
                    TotPcs += Qty.Cells(3).Value
                    lblPc.Text = TotPcs

                    countP += 1
                End If

                '--------richel----------
                'for display 0 if wala sa datagrid---
                If countC = 0 Then
                    lblCase.Text = "0"
                End If
                If countB = 0 Then
                    lblBag.Text = "0"
                End If
                If countP = 0 Then
                    lblPc.Text = "0"
                End If
                '--------richel----------

            Next
        End With

    End Sub

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
        ComputeStockOutTotal()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        gbxItemList.Visible = False
        gbxItemList.SendToBack()
        'LoadItemList()
        'tbSearchItem.Focus()
    End Sub

    Dim lastitemsel As String = Nothing
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
                        'rdx = dgvItemList.RowCount + 1
                        With dgvItem
                            'Dim mycat As String = Nothing
                            'mycat = dgvItemList.Item(6, rdx).Value

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
                                        .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                        .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value

                                        Dim myprice As Decimal = 0

                                        If cboPriceType.Text = "A" Then
                                            myprice = dgvItemList.Item(16, rdx).Value
                                        ElseIf cboPriceType.Text = "B" Then
                                            myprice = dgvItemList.Item(19, rdx).Value
                                        ElseIf cboPriceType.Text = "C" Then
                                            myprice = dgvItemList.Item(22, rdx).Value
                                        ElseIf cboPriceType.Text = "D" Then
                                            myprice = dgvItemList.Item(25, rdx).Value
                                        ElseIf cboPriceType.Text = "E" Then
                                            myprice = dgvItemList.Item(28, rdx).Value
                                        End If
                                        .Item(6, rindex).Value = myprice 'PCKG
                                        .Item(7, nn).Value = 0 ' dgvItemList.Item(14, rdx).Value
                                        '.Item(8, nn).Value = dgvItemList.Item(27, rdx).Value
                                        '  .Item(10, nn).Value = "Delete"
                                        .CurrentCell = .Item(3, nn)
                                        '.Item(3, nn).Selected = True
                                        .BeginEdit(True)
                                    End If
                                Else

                                    If .Item(1, rindex).Value <> Nothing And .Item(3, rindex).Value <> 0 And _
                                        .Item(8, rindex).Value <> Nothing Then

                                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(1, rindex).Value = dgvItemList.Item(1, rdx).Value 'ITEM
                                            If .Item(9, rindex).Value <> dgvItemList.Item(1, rdx).Value Then
                                                ReDim Preserve listupd(rwupd)
                                                listupd(rwupd).c1uitem = .Item(9, rindex).Value
                                                listupd(rwupd).c1upqty = .Item(3, rindex).Value
                                                listupd(rwupd).c1whse = cboWhsCode.SelectedItem.value
                                                listupd(rwupd).c1upckg = .Item(5, rindex).Value
                                                listupd(rwupd).c1upkno = .Item(8, rindex).Value
                                                rwupd += 1
                                            End If
                                            .Item(2, rindex).Value = dgvItemList.Item(2, rdx).Value 'DESCRIPTION
                                            .Item(4, rindex).Value = dgvItemList.Item(9, rdx).Value 'QTY
                                            .Item(5, rindex).Value = dgvItemList.Item(10, rdx).Value 'UNIT
                                            Dim myprice As Decimal = 0

                                            If cboPriceType.Text = "A" Then
                                                myprice = dgvItemList.Item(16, rdx).Value
                                            ElseIf cboPriceType.Text = "B" Then
                                                myprice = dgvItemList.Item(19, rdx).Value
                                            ElseIf cboPriceType.Text = "C" Then
                                                myprice = dgvItemList.Item(22, rdx).Value
                                            ElseIf cboPriceType.Text = "D" Then
                                                myprice = dgvItemList.Item(25, rdx).Value
                                            ElseIf cboPriceType.Text = "E" Then
                                                myprice = dgvItemList.Item(28, rdx).Value
                                            End If
                                            .Item(6, rindex).Value = myprice 'PCKG
                                            .Item(7, nn).Value = 0 ' dgvItemList.Item(14, rdx).Value
                                            '.Item(8, rindex).Value = dgvItemList.Item(15, rdx).Value 'NET-COST
                                            ' .Item(10, nn).Value = "Delete"
                                            .CurrentCell = .Item(3, rindex)
                                            '.item(3, nn).Selected = True
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
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                            Dim myprice As Decimal = 0
                                            If cboPriceType.Text = "A" Then
                                                myprice = dgvItemList.Item(16, rdx).Value
                                            ElseIf cboPriceType.Text = "B" Then
                                                myprice = dgvItemList.Item(19, rdx).Value
                                            ElseIf cboPriceType.Text = "C" Then
                                                myprice = dgvItemList.Item(22, rdx).Value
                                            ElseIf cboPriceType.Text = "D" Then
                                                myprice = dgvItemList.Item(25, rdx).Value
                                            ElseIf cboPriceType.Text = "E" Then
                                                myprice = dgvItemList.Item(28, rdx).Value
                                            End If
                                            .Item(6, rindex).Value = myprice 'PCKG
                                            .Item(7, nn).Value = 0 ' dgvItemList.Item(14, rdx).Value
                                            '.Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                            ' .Item(10, nn).Value = "Delete"
                                            .CurrentCell = .Item(3, nn)
                                            '.item(3, nn).Selected = True
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
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                            Dim myprice As Decimal = 0
                                            If cboPriceType.Text = "A" Then
                                                myprice = dgvItemList.Item(16, rdx).Value
                                            ElseIf cboPriceType.Text = "B" Then
                                                myprice = dgvItemList.Item(19, rdx).Value
                                            ElseIf cboPriceType.Text = "C" Then
                                                myprice = dgvItemList.Item(22, rdx).Value
                                            ElseIf cboPriceType.Text = "D" Then
                                                myprice = dgvItemList.Item(25, rdx).Value
                                            ElseIf cboPriceType.Text = "E" Then
                                                myprice = dgvItemList.Item(28, rdx).Value
                                            End If
                                            .Item(6, rindex).Value = myprice 'PCKG
                                            .Item(7, nn).Value = 0 ' dgvItemList.Item(14, rdx).Value
                                            '.Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                            '  .Item(10, nn).Value = "Delete"
                                            .CurrentCell = .Item(3, nn)
                                            '.Item(3, nn).Selected = True
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
                                    .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                    .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value

                                    Dim myprice As Decimal = 0
                                    If cboPriceType.Text = "A" Then
                                        myprice = dgvItemList.Item(16, rdx).Value
                                    ElseIf cboPriceType.Text = "B" Then
                                        myprice = dgvItemList.Item(19, rdx).Value
                                    ElseIf cboPriceType.Text = "C" Then
                                        myprice = dgvItemList.Item(22, rdx).Value
                                    ElseIf cboPriceType.Text = "D" Then
                                        myprice = dgvItemList.Item(25, rdx).Value
                                    ElseIf cboPriceType.Text = "E" Then
                                        myprice = dgvItemList.Item(28, rdx).Value
                                    End If
                                    .Item(6, rindex).Value = myprice 'PCKG
                                    .Item(7, nn).Value = 0 ' dgvItemList.Item(14, rdx).Value
                                    '.Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                    ' .Item(10, nn).Value = "Delete"
                                    .CurrentCell = .Item(3, nn)
                                    '.Item(3, nn).Selected = True
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
        If cboSupplier.Text = "" Then
            MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
            cboSupplier.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.F3 Then
            'tsSearchItem.PerformClick()

        End If
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
                                   " AND supcode=@spc and isdeleted<>1", cdb)
            cmd.Parameters.AddWithValue("@spc", cboSupplier.SelectedItem.value)
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
            '  cn.Close()
        Catch ex As Exception
            ' cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function isExistWarehouseAndItem(ByVal currentwhsname As String, ByVal itemcode As String) As Boolean
        Dim existna As Boolean = False

        Dim cmd2 As New MySqlCommand
        cmd2 = New MySqlCommand("SELECT * FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
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
        cmd2 = New MySqlCommand("SELECT * FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
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

    Private Sub tsAdd_Click_1(sender As Object, e As EventArgs)
        'With dgvRcvItem
        '    Dim r As Integer
        '    .Rows.Add()
        '    r = .Rows.Count - 1
        '    .Rows(r).Cells(0).Value = r + 1
        '    .CurrentCell = .Rows(r).Cells(1)
        '    dgvRcvItem.Focus()
        '    .BeginEdit(True)
        'End With
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim r As Integer

        If btnSearch.Enabled = False Then
            btnSearch.Enabled = True
        End If

        If cboSupplier.Text = "" Then
            MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
            cboSupplier.Focus()
            Exit Sub
        End If

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

            If .Rows.Count > 0 Then
                r = .Rows.Count - 1

                If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing Then

                    If .Rows(r).Cells(3).Value = 0 Then
                        .ClearSelection()
                        .CurrentCell = .Item(3, r)

                        .BeginEdit(True)
                    Else
                        .Rows.Add()
                        r = .Rows.Count - 1
                        selrow = r
                        .Rows(r).Cells(1).Tag = "A"
                        .Rows(r).Cells(0).Value = r + 1
                        .ClearSelection()
                        .CurrentCell = .Item(1, r)

                        .BeginEdit(True)
                    End If

                Else
                    .ClearSelection()
                    .CurrentCell = .Item(1, r)

                    .BeginEdit(True)
                End If
            Else
                .Rows.Add()
                r = .Rows.Count - 1
                selrow = r
                .Rows(r).Cells(1).Tag = "A"
                .Rows(r).Cells(0).Value = r + 1
                .CurrentCell = .Rows(r).Cells(1)
                .BeginEdit(True)
            End If
            ' dgvRcvItem.Focus()
            ' dgvRcvItem.CurrentCell = dgvRcvItem.CurrentRow.Cells(1)
        End With


    End Sub

    Private Sub tbSupCode_KeyPress(sender As Object, e As KeyPressEventArgs)
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cboSupplier.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtSupplier.Text = rd.Item("suppliername").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub tbSupCode_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvRcvItem_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        With dgvItem
            If .Rows.Count > 0 Then
                If .CurrentCell.ColumnIndex = 3 Then
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
                ElseIf .CurrentCell.ColumnIndex = 4 Then
                    'Dim cbo As ComboBox = CType(e.Control, ComboBox)
                    selrow = .CurrentCell.RowIndex
                    'AddHandler cbo.PreviewKeyDown, AddressOf cbx_PreviewKeyDown
                    Dim combo As ComboBox = CType(e.Control, ComboBox)
                    If (combo IsNot Nothing) Then

                        RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

                        ' Add the event handler. 
                        AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

                    End If
                ElseIf .CurrentCell.ColumnIndex = 1 Then
                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
                    AddHandler CType(e.Control, TextBox).KeyDown, AddressOf column_keydown
                Else

                    RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress

                End If
            End If
        End With
    End Sub

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

    Private Sub cbxSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSupplier.KeyPress
        If e.KeyChar = vbCr Then
            txtRemarks.Focus()
        End If
    End Sub

    Private Sub cbxSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSupplier.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cboSupplier.Text & "%'", cdb)
        Using rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                txtSupplier.Text = rd.Item("suppliername").ToString
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub cboWhs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboWhsCode.KeyPress
        If e.KeyChar = vbCr Then
            cboSupplier.Focus()
        End If
    End Sub

    Private Sub cbxWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboWhsCode.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cboWhsCode.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                tbWhsName.Text = rd.Item("warehouse").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to Quit?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If cboSupplier.Text = "" Then
            MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
            cboSupplier.Focus()
            Exit Sub
        End If

        btnAdd.PerformClick()

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

            dgvItemList.Focus()

        End With
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MsgBox("(*Note, removing this item will remove the last reflected quantity of this item) Remove this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then
            'ReDim Preserve listrmv(rwrmv)
            'With listrmv(rwrmv)
            '    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
            '    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Value
            '    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
            '    .c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
            '    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Value
            'End With
            If Me.Tag = 1 Then
                ReDim Preserve listrmv(rwrmv)
                With listrmv(rwrmv)


                    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                    .c1qty = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
                    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
                    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Tag
                    '.c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag
                    .c1whs = dgvItem.Item(10, dgvItem.CurrentRow.Index).Value
                End With
                rwrmv += 1
            End If
            dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))
            ComputeStockOutTotal()
            ' CalTotalQty()
        End If

        'If MsgBox("Remove this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then
        '    ReDim Preserve listrmv(rwrmv)
        '    With listrmv(rwrmv)
        '        .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
        '        .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Value
        '        .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
        '        .c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
        '        .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Value 'toping
        '    End With

        '    'cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' where transno=@tno AND item =@itemc", cdb)
        '    'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
        '    'cmd.Parameters.AddWithValue("@itemc", dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value)
        '    'cmd.ExecuteNonQuery()
        '    rwrmv += 1
        '    dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))

        '    ComputeStockOutTotal()
        'End If

    End Sub

    Private Sub btnCloseI_Click(sender As Object, e As EventArgs) Handles btnCloseI.Click
        'If dgvItem.RowCount > 0 Or cboWhsCode.Text <> Nothing Or cbxSupplier.Text <> Nothing Then
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
        End If
        'End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboSupplier.Text = "" Or cboWhsCode.Text = "" Then
            MsgBox("Check Missing Field", vbCritical)
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
                    ' GenerateStockOutNo()
                    SaveStockOut()
                    AuditTrail("Trans No.:" & Space(1) & txtTransNo.Text & Space(2) & "Date: " & Space(1) & tDate.Text & Space(2) & "Warehouse:" & Space(1) & cboWhsCode.Text & Space(2) & "Supplier:" & Space(1) & cboSupplier.Text, "Add Misc. Stock Out")
                    MsgBox("Misc. Stock Out has been save successfully", vbInformation)


                    With frmStockOutH
                        .LoadStockOut()
                    End With
                    ClearStockOut()
                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If
            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With


    End Sub

    Sub SaveStockOut()
        'insert to ivh
        
        'out to ivwh
        With dgvItem

            Dim mkerr As Integer = 0
            Dim mkmsg As String = Nothing
            For i = 0 To .RowCount - 1
                If .Item(3, i).Value <> Nothing Then 'qty <> nothing
                    If .Item(3, i).Value > 0 Then 'qty > 0
                        Dim fnd1 As Boolean = False
                        Dim itmc As String = Nothing
                        Dim pkn As String = Nothing
                        Dim oqty As String = Nothing
                        Dim opck As String = Nothing
                        Dim newwqty As String = Nothing


                        itmc = .Item(1, i).Value
                        pkn = .Item(8, i).Value
                        newwqty = .Item(3, i).Value

                        Dim unt As String = 0
                        Dim nwq As Decimal = 0
                        Dim qtyfromwhs As Decimal = 0
                        qtyfromwhs = getcurqty(itmc, cboWhsCode.Text, "G")
                        unt = .Item(4, i).Value
                        nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                        oqty = getoldqtyfrmtable(itmc, pkn, "ivd")

                        Dim old_item_unit As String = Nothing
                        old_item_unit = getolditemunit(itmc, pkn, "ivd")
                        Dim old_item_qty As Decimal = 0
                        old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)

                        oqty = old_item_qty

                        nwq = nwq - oqty
                        'End If
                        If nwq > qtyfromwhs Then
                            mkerr = 1
                            If mkmsg = Nothing Then
                                mkmsg = itmc & " exceeded quantity"
                            Else
                                mkmsg = mkmsg & " " & vbNewLine & itmc & " exceeded quantity"
                            End If
                        End If

                    End If
                End If
            Next


            If mkerr = 0 Then

                Dim TransNo As String = GenerateTransNo_In_Out_Transfer("O")


                Dim cmd As MySqlCommand
                Dim i As Integer
                cmd = New MySqlCommand("INSERT INTO ivh (transno,ttype,tdate,whscode,supcode,total,remarks,pricetype,userid) VALUES (@transno,@ttype,@tdate,@whscode,@supcode,@total,@remarks,@pricetype,@userid)", cdb)

                With cmd
                    cmd.Parameters.AddWithValue("@transno", TransNo)
                    cmd.Parameters.AddWithValue("@ttype", ttype)
                    cmd.Parameters.AddWithValue("@tdate", tDate.Value)
                    cmd.Parameters.AddWithValue("@whscode", cboWhsCode.Text)
                    cmd.Parameters.AddWithValue("@supcode", cboSupplier.Text)
                    cmd.Parameters.AddWithValue("@total", Decimal.Parse(txtTotal.Text))
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    cmd.Parameters.AddWithValue("@pricetype", cboPriceType.Text)
                    cmd.Parameters.AddWithValue("@userid", txtUser.Text)
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                'insert to ivd
                With dgvItem

                    For i = 0 To .RowCount - 1
                        If .Item(3, i).Value <> Nothing Then
                            If .Item(3, i).Value > 0 Then
                                cmd = New MySqlCommand("INSERT INTO ivd (transno,ttype,tdate,whscode,supcode,itemcode,qty,qunit,pckg, " & _
                                                              "price,amount) VALUES (@transno,@ttype,@tdate,@whs,@supcode,@item,@qty,@qunit,@pckg,@price,@amount)", cdb)

                                cmd.Parameters.AddWithValue("@transno", TransNo)
                                cmd.Parameters.AddWithValue("@ttype", ttype)
                                cmd.Parameters.AddWithValue("@tdate", tDate.Value)
                                cmd.Parameters.AddWithValue("@whs", cboWhsCode.Text)
                                cmd.Parameters.AddWithValue("@supcode", cboSupplier.Text)
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
                    Next
                End With

                For i = 0 To .RowCount - 1
                    If .Item(3, i).Value <> Nothing Then
                        If .Item(3, i).Value > 0 Then
                            Dim totalqty As Decimal = 0

                            If .Item(4, i).Value = "C" Or .Item(4, i).Value = "B" Then
                                totalqty = .Item(3, i).Value * IIf(.Item(5, i).Value > 0, .Item(5, i).Value, 1)
                            ElseIf .Item(4, i).Value = "P" Then
                                totalqty = .Item(3, i).Value
                            End If

                            Dim fnds As Boolean = False
                            Dim curqty As Decimal = 0
                            cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
                            cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                            Using rd As MySqlDataReader = cmd.ExecuteReader
                                If rd.HasRows Then
                                    fnds = True
                                    rd.Read()
                                    curqty = rd("qty_good").ToString
                                End If
                                rd.Close()
                            End Using
                            cmd.Dispose()

                            'If fnds = False Then
                            '    cmd = New MySqlCommand("INSERT INTO ivwh (item,whs,qty_good) VALUES (@itm,@wh,@qtyg)", cdb)

                            '    cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            '    cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                            '    cmd.Parameters.AddWithValue("@qtyg", totalqty)
                            '    cmd.ExecuteNonQuery()
                            '    cmd.Dispose()
                            'Else

                            Dim nqty As Decimal = 0
                            'Dim inputqty As Decimal = 0

                            'inputqty = curqty

                            'If inputqty > curqty Then
                            '    MsgBox("Input Quantity is Greater than Available Qauntity!", vbExclamation)
                            '    Exit Sub
                            '  Else

                            nqty = curqty - totalqty
                            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
                            cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                            cmd.Parameters.AddWithValue("@qtyg", nqty)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End If
                    ' End If
                    ' End If
                Next
            Else
                MsgBox(mkmsg, 48, " Exceeded allowed quantity")
            End If
           
        End With
    End Sub

    Sub ClearStockOut()
        'cboSupplier.Text = Nothing
        'cboWhsCode.Text = Nothing
        tbWhsName.Text = ""
        txtSupplier.Text = ""
        txtTransNo.Text = ""
        txtRemarks.Text = ""
        cboPriceType.Text = "A"
        txtTotal.Text = "0.00"
        dgvItem.Rows.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        With dgvItem

            If .RowCount = 0 Then
                MsgBox("No item(s) found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()

            If cboSupplier.Text <> Nothing And cboWhsCode.Text <> Nothing Then
                If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
                    Dim asave As Boolean = True

                    For i = 0 To .Rows.Count - 1
                        If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            asave = False
                        End If
                    Next

                    If asave = True Then
                        .EndEdit(True)
                        UpdateStockOut()

                        ' MsgBox("Misc. Stock Out has been updated successfully.", vbInformation)
                        ClearStockOut()
                        Me.Dispose()

                        With frmStockOutH
                            .LoadStockOut()
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

    Sub UpdateStockOut()


        'NEW PROCESS UPDATE IVH => COCOY
        Dim cmd As MySqlCommand
        Dim i As Integer

        'END UPDATE IVH

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0
        Dim whsecode As String = Nothing

        whsecode = cboWhsCode.SelectedItem.value
        ' MsgBox(prevwhse)
        'update edited item
        With dgvItem 'sa pagdugang ni

            curqty = 0
            nwqty = 0

            'update remove item
            Dim mkerr As Integer = 0
            Dim mkmsg As String = Nothing
            For i = 0 To .RowCount - 1
                If .Item(3, i).Value <> Nothing Then 'qty <> nothing
                    If .Item(3, i).Value > 0 Then 'qty > 0
                        Dim fnd1 As Boolean = False
                        Dim itmc As String = Nothing
                        Dim pkn As String = Nothing
                        Dim oqty As String = Nothing
                        Dim opck As String = Nothing
                        Dim newwqty As String = Nothing


                        itmc = .Item(1, i).Value
                        pkn = .Item(8, i).Value
                        newwqty = .Item(3, i).Value

                        Dim unt As String = 0
                        Dim nwq As Decimal = 0
                        Dim qtyfromwhs As Decimal = 0
                        qtyfromwhs = getcurqty(itmc, whsecode, "G")
                        unt = .Item(4, i).Value
                        nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                        oqty = getoldqtyfrmtable(itmc, pkn, "ivd")

                        Dim old_item_unit As String = Nothing
                        old_item_unit = getolditemunit(itmc, pkn, "ivd")
                        Dim old_item_qty As Decimal = 0
                        old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)

                        oqty = old_item_qty

                        nwq = nwq - oqty
                        'End If
                        If nwq > qtyfromwhs Then
                            mkerr = 1
                            If mkmsg = Nothing Then
                                mkmsg = itmc & " exceeded quantity"
                            Else
                                mkmsg = mkmsg & " " & vbNewLine & itmc & " exceeded quantity"
                            End If
                        End If

                    End If
                End If
            Next


            If mkerr = 0 Then

                cmd = New MySqlCommand("UPDATE ivh SET ttype=@ttype,tdate=@tdate,whscode=@whscode,supcode=@supcode,total=@total,remarks=@remarks,pricetype=@pricetype,userid=@userid WHERE transno=@transno", cdb)
                With cmd
                    cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
                    cmd.Parameters.AddWithValue("@ttype", ttype)
                    cmd.Parameters.AddWithValue("@tdate", tDate.Value)
                    cmd.Parameters.AddWithValue("@whscode", cboWhsCode.Text)
                    cmd.Parameters.AddWithValue("@supcode", cboSupplier.Text)
                    cmd.Parameters.AddWithValue("@total", Decimal.Parse(txtTotal.Text))
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    cmd.Parameters.AddWithValue("@pricetype", cboPriceType.Text)
                    cmd.Parameters.AddWithValue("@userid", txtUser.Text)
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                ' If rwrmv < 1 Then 'meaning 0 ===>>>>>>>>RICHEL GCASH 50K

                '  Else
                For x As Integer = 0 To rwrmv - 1
                    Dim rmvitc As String = Nothing
                    Dim rmvqty As Decimal = 0
                    Dim rmvpkno As String = Nothing
                    Dim rmvunit As String = Nothing
                    Dim rmvpckg As Decimal = 0
                    Dim rmvwhse As String = Nothing

                    rmvitc = listrmv(x).c1item
                    rmvqty = listrmv(x).c1qty
                    rmvpkno = listrmv(x).c1pkno
                    rmvunit = listrmv(x).c1unit
                    rmvpckg = listrmv(x).c1pckg
                    rmvwhse = listrmv(x).c1whs

                  
                    cmd = New MySqlCommand("UPDATE ivd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc AND pkno=@pno", cdb)
                    cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
                    cmd.Parameters.AddWithValue("@itemc", rmvitc)
                    cmd.Parameters.AddWithValue("@pno", rmvpkno)
                    cmd.ExecuteNonQuery()

                    curqty = getcurqty(rmvitc, rmvwhse, "G")

                    'Dim totalqty As Integer = 0

                    'totalqty = convertpackaging_fromivitem(rmvitc, Nothing, rmvqty, rmvunit)
                    nwqty = curqty + rmvqty

                    cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@itm", rmvitc)
                    'cmd.Parameters.AddWithValue("@wh", .Item(10, i).Value)
                    cmd.Parameters.AddWithValue("@wh", rmvwhse)
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
                            Dim itmc As String = Nothing
                            Dim pkn As String = Nothing
                            Dim oqty As String = Nothing
                            Dim opck As String = Nothing
                            Dim newwqty As String = Nothing
                            Dim my_operator As String = "+"
                            Dim old_item_qty As Decimal = 0


                            itmc = .Item(1, i).Value
                            pkn = .Item(8, i).Value
                            newwqty = .Item(3, i).Value

                            'cmd = New MySqlCommand("SELECT item FROM salesd WHERE pkno=@pno and transno=@tno", cdb)
                            cmd = New MySqlCommand("SELECT itemcode FROM ivd WHERE pkno=@pno and transno=@tno and itemcode=@itm and isdeleted='0'", cdb)
                            cmd.Parameters.AddWithValue("@tno", txtTransNo.Text.Trim)
                            cmd.Parameters.AddWithValue("@pno", pkn)
                            cmd.Parameters.AddWithValue("@itm", itmc)
                            Using rd As MySqlDataReader = cmd.ExecuteReader
                                If rd.HasRows Then
                                    fnd1 = True
                                End If
                            End Using
                            cmd.Dispose()

                            Dim unt As String = 0
                            Dim nwq As Decimal = 0
                            Dim qtyfromwhs As Decimal = 0
                            qtyfromwhs = getcurqty(itmc, whsecode, "G")

                            Dim new_item_unit As String = Nothing
                            Dim old_item_unit As String = Nothing
                            old_item_unit = getolditemunit(itmc, pkn, "ivd")

                            unt = .Item(4, i).Value
                            nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)

                            Dim markunitchange As Integer = 0

                            Dim pvwhs As String = Nothing

                            Dim whsecode2 As String = Nothing
                            whsecode2 = cboWhsCode.Text
                            oqty = getoldqtyfrmtable(itmc, pkn, "ivd")

                            Dim added_status As Integer = 0
                            If .Item(1, i).Tag = "A" Then
                                added_status = 1
                            End If

                            If prevwhs <> whsecode Then 'Change warehouse

                                Dim opr As String = Nothing
                                opr = "+"
                                pvwhs = prevwhs
                                Dim nwqtytoprev As Decimal = 0
                                Dim oldqtyfromprvwhs As Decimal = 0
                                Dim qtyreturntoprvwhs As Decimal = 0

                                'change quantity or unit
                                oldqtyfromprvwhs = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                nwqtytoprev = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)


                               
                                If oldqtyfromprvwhs <> nwqtytoprev Then
                                    If added_status = 0 Then
                                        updateprevwhs(itmc, oldqtyfromprvwhs, nwq, opr, prevwhs, "G")
                                    End If
                                Else
                                    updateprevwhs(itmc, nwqtytoprev, nwq, opr, prevwhs, "G")
                                End If



                                oqty = newwqty
                                old_item_unit = unt
                            ElseIf old_item_unit <> Nothing Then

                                If old_item_unit <> unt Then
                                    ' old_item_qty = getolditem_qty(itmc, pkn)
                                    Dim new_item_qty As Decimal = 0
                                    markunitchange = 1

                                    ' old_item_qty = getoldqtyfrmtable(itmc, pkn, "ivd")
                                    new_item_qty = old_item_qty
                                    old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    return_diff_to_whs(itmc, old_item_qty, whsecode, "+")
                                    'End If
                                    oqty = new_item_qty

                                End If
                            End If



                            If fnd1 = True Then
                                'UPDATE IVD HERE
                                cmd = New MySqlCommand("UPDATE ivd SET transno=@transno,ttype=@ttype,tdate=@tdate,whscode=@whs,supcode=@supcode,itemcode=@item,qty=@qty,qunit=@qunit,pckg=@pckg,price=@price,amount=@amount WHERE transno=@transno AND pkno=@pkno", cdb)
                                cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
                                cmd.Parameters.AddWithValue("@ttype", ttype)
                                cmd.Parameters.AddWithValue("@tdate", tDate.Value)
                                cmd.Parameters.AddWithValue("@whs", cboWhsCode.Text.Trim) '.Item(10, i).Value) 'cbxWarehouse.Text.Trim)
                                cmd.Parameters.AddWithValue("@supcode", cboSupplier.Text)
                                cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@qty", Decimal.Parse(.Item(3, i).Value)) '.Item(3, i).Value)
                                cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                                cmd.Parameters.AddWithValue("@price", Decimal.Parse(.Item(6, i).Value))
                                cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                                cmd.Parameters.AddWithValue("@pkno", .Item(8, i).Value)
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()

                                If markunitchange = 1 Then
                                
                                    'oqty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)


                                    update_currentwhs_1stockout(itmc, oqty, nwq, prevwhs, whsecode, whsecode2, my_operator)
                                Else
                                    Dim updatedqty As Decimal = 0

                                    updatedqty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    update_currentwhs_1stockout(itmc, updatedqty, nwq, prevwhs, whsecode, whsecode2, my_operator)

                                  
                                    ' old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    ' update_currentwhs22(itmc, old_item_qty, nwq, whsecode2, whsecode, pvwhs, my_operator)
                                End If
                            Else
                                'SAVE TO IVD HERE
                                cmd = New MySqlCommand("INSERT INTO ivd (transno,ttype,tdate,whscode,supcode,itemcode,qty,qunit,pckg, " & _
                                                      "price,amount) VALUES (@transno,@ttype,@tdate,@whs,@supcode,@item,@qty,@qunit,@pckg,@price,@amount)", cdb)
                                cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
                                cmd.Parameters.AddWithValue("@ttype", ttype)
                                cmd.Parameters.AddWithValue("@tdate", tDate.Value)
                                cmd.Parameters.AddWithValue("@whs", cboWhsCode.Text.Trim) '.Item(10, i).Value) 'cbxWarehouse.Text)
                                cmd.Parameters.AddWithValue("@supcode", cboSupplier.Text)
                                cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@qty", Decimal.Parse(.Item(3, i).Value)) '.Item(3, i).Value)
                                cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                                cmd.Parameters.AddWithValue("@price", Decimal.Parse(.Item(6, i).Value))
                                cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()
                                nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                                'old_item_qty = getcurqty(itmc, whsecode, "G")
                                my_operator = "-"
                                update_currentwhs_stockout(itmc, old_item_qty, nwq, whsecode2, whsecode, nwq, my_operator)
                            End If
                        End If
                    End If
                Next
                prevwhs = whsecode
                MsgBox("Misc. Stock In has been updated successfully.", vbInformation)
            Else
                MsgBox(mkmsg, 48, " Exceeded allowed quantity")
            End If

            reset_listrmv()
            reset_listupd()
            reset_listadded()
            prevwhs = whsecode
            editeditem = 0
        End With
        
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If cboSupplier.Text = "" Or cboWhsCode.Text = "" Then
            MsgBox("Check Missing Field", vbCritical)
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

                    GenerateStockOutNo()
                    SaveStockOut()
                    MsgBox("Misc. Stock In Has Been Save Successfully", vbInformation)
                    StockOutPrint()
                    ClearStockOut()

                    With frmStockOutH
                        .LoadStockOut()
                    End With

                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If
            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With


    End Sub

    Sub StockOutPrint()
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

                    r1("date") = tDate.Value.ToString("MM/dd/yyyy")
                    r1("pricetype") = cboPriceType.Text.ToString
                    'r1("supplier") = cbxSupplier.Text.ToString
                    r1("supplier") = txtSupplier.Text.ToString
                    'r1("warehouse") = cbxWarehouse.Text.ToString
                    r1("warehouse") = tbWhsName.Text.ToString
                    r1("remarks") = txtRemarks.Text.ToString
                    r1("userid") = txtUser.Text.ToString
                    r1("transno") = txtTransNo.Text.ToString
                    r1("total") = txtTotal.Text.ToString

                    'r1("date") = RcvDate.Value.ToString
                    'r1("supplier") = cbxSupplier.SelectedValue.ToString
                    'r1("warehouse") = cbxWarehouse.SelectedValue.ToString
                    'r1("pono") = tbPONo.Text.ToString
                    'r1("user") = tbUser.Text.ToString
                    'r1("transno") = tbTransNo.Text.ToString
                    'r1("invoiceno") = tbInvoiceNo.Text.ToString
                    'r1("qty") = IIf(.Item(3, i).Value = Nothing, DBNull.Value, .Item(3, i).Value)
                    r1("qty") = Format(CDbl(IIf(.Item(3, i).Value = Nothing, DBNull.Value, .Item(3, i).Value)), "#.##0")
                    r1("itemcode") = IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("description") = IIf(.Item(2, i).Value = Nothing, DBNull.Value, .Item(2, i).Value)
                    r1("unit") = IIf(.Item(4, i).Value = Nothing, DBNull.Value, .Item(4, i).Value)
                    r1("pckg") = IIf(.Item(5, i).Value = Nothing, DBNull.Value, .Item(5, i).Value)
                    r1("uprice") = IIf(.Item(6, i).Value = Nothing, DBNull.Value, .Item(6, i).Value)
                    r1("amount") = IIf(.Item(7, i).Value = Nothing, DBNull.Value, .Item(7, i).Value)
                    r1("totqtyc") = Format(CDbl(lblCase.Text.ToString), "#,##0")
                    r1("totqtyb") = Format(CDbl(lblBag.Text.ToString), "#,##0")
                    r1("totqtyp") = Format(CDbl(lblPc.Text.ToString), "#,##0")
                    r1("grpno") = grid

                    pbar1.Refresh()
                    dtStockIn.Rows.Add(r1)
                    ' pbar1.Refresh()

                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next


                'pbar1.Visible = False
                prep = New rptStockOut
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

    Sub RetrieveStockOut(ByVal trno As String)

        With dgvItem
            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0
            Dim mytrans As String = Nothing

            .Rows.Clear()
            Dim checkopen As String()

            checkopen = check_if_trans_is_open(trno, "ivh", _user)

            If checkopen(0) = True Then
                MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before editing/updating this transaction. ", 48, "TRANSACTION IS OPEN")
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
            End If

            cmd = New MySqlCommand("SELECT h.*,s.suppliername,w.warehouse FROM ivh h " & _
                                   " LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                                   " LEFT JOIN warehouse w ON h.whscode=w.whscode WHERE transno=@tn", cdb)
            cmd.Parameters.AddWithValue("@tn", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    tDate.Value = rd("tdate").ToString
                    cboPriceType.Text = rd("pricetype").ToString
                    txtTransNo.Text = rd("transno").ToString
                    cboSupplier.SelectedIndex = setselindex(cboSupplier, rd("supcode").ToString)
                    txtSupplier.Text = rd("suppliername").ToString
                    cboWhsCode.SelectedIndex = setselindex(cboWhsCode, rd("whscode").ToString)
                    txtRemarks.Text = rd("remarks").ToString
                    prevwhs = rd("whscode").ToString
                    tbWhsName.Text = rd("warehouse").ToString
                    txtUser.Text = rd("userid").ToString
                    txtTotal.Text = Format(Math.Round(Decimal.Parse(rd("total").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                End If
                rd.Close()
            End Using
            cmd.Dispose()

            cmd = New MySqlCommand("SELECT r.*,r.pkno as pno, t.description from ivd r " & _
                                   "LEFT JOIN ivitem t ON r.itemcode=t.itemcode WHERE transno=@tn and r.isdeleted='0' Order by r.pkno Asc", cdb) ' '" & tbCustCode.Text & "'", cdb)
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
                        .Item(3, rw).Value = Format(CDbl(rd("QTY").ToString), "#,##0")
                        .Item(4, rw).Value = rd("qunit").ToString
                        .Item(4, rw).Tag = rd("qunit").ToString
                        .Item(5, rw).Value = rd("PCKG").ToString

                        If rd("qunit").ToString = "C" Or rd("qunit").ToString = "B" Then
                            totalqty = rd("QTY").ToString * IIf(rd("PCKG").ToString > 0, rd("PCKG").ToString, 1)
                        ElseIf rd("qunit").ToString = "P" Then
                            totalqty = rd("QTY").ToString
                        End If
                        .Item(5, rw).Tag = totalqty
                        .Item(6, rw).Value = Format(Math.Round(Decimal.Parse(rd("price").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(7, rw).Value = Format(Math.Round(Decimal.Parse(rd("amount").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(8, rw).Value = rd("pno").ToString
                        .Item(8, rw).Tag = rd("pno").ToString
                        .Item(9, rw).Value = rd("itemcode").ToString
                        .Item(10, rw).Value = rd("whscode").ToString

                        'temporarily trap
                        '.Item(1, rw).ReadOnly = True
                        '.Item(4, rw).ReadOnly = True
                        'end

                    End While
                    rd.Close()
                End If
            End Using

            cmd = New MySqlCommand("SELECT * FROM useraccnt where username=@uname", cdb)
            cmd.Parameters.AddWithValue("@uname", txtUser.Text)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    txtUser.Text = rd("username").ToString
                End If
                rd.Close()
            End Using

            .Focus()

        End With

        cboPriceType.Enabled = False
        btnUpdate.Enabled = False
        btnUpdatePrint.Enabled = False
        btnAdd.Enabled = False
        btnSearch.Enabled = False
        btnRemove.Enabled = False
        txtRemarks.Enabled = False
        cboSupplier.Enabled = False
        cboWhsCode.Enabled = False
        dgvItem.ReadOnly = True

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        StockOutPrint()
    End Sub


    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplier.SelectedIndexChanged

    End Sub

    Private Sub btnUpdatePrint_Click(sender As Object, e As EventArgs) Handles btnUpdatePrint.Click
        With dgvItem

            If .RowCount = 0 Then
                MsgBox("No item(s) found!", vbExclamation)
                Return
            End If
            DeleteBlankRow()

            If cboSupplier.Text <> Nothing And cboWhsCode.Text <> Nothing Then
                If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
                    Dim asave As Boolean = True

                    For i = 0 To .Rows.Count - 1
                        If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            asave = False
                        End If
                    Next

                    If asave = True Then
                        .EndEdit(True)
                        UpdateStockOut()
                        MsgBox("Misc. Stock Out Has Been Updated Successfully.", vbInformation)
                        StockOutPrint()
                        'ClearStockIn()

                        With frmStockOutH
                            .LoadStockOut()
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

    Private Sub dgvItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellContentClick
        Dim colName As String = dgvItem.Columns(e.ColumnIndex).Name
        If colName = "colDelete" Then
            If MsgBox("Delete this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then

                ReDim Preserve listrmv(rwrmv)
                With listrmv(rwrmv)
                    

                    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                    .c1qty = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
                    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
                    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Tag
                    '.c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag
                End With

       
                rwrmv += 1
                dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))

                ComputeStockOutTotal()

               
            End If
        End If
    End Sub


    Dim editeditem As Integer = 0
    Private Sub dgvItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellEndEdit

        '=== NEW PROCESS === => COCOY
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0
                Dim oldqty As Decimal = 0
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
                            End If
                            '.ClearSelection()
                            '.CurrentCell = .Item(3, mrw)
                            '.BeginEdit(True)
                            'ComputeRcvTotal()
                            .ClearSelection()

                            'If .Item(1, mrw).Value <> .Item(13, mrw).Value Then
                            If .Item(1, mrw).Value <> .Item(9, mrw).Value Then 'PREV ITEM

                                '======
                                Dim mpc As String = Nothing
                                itemno = .Item(1, mrw).Value
                                mpc = .Item(4, mrw).Value

                                If cboPriceType.Text <> Nothing Then
                                    getpackprice(itemno, mpc, mrw, cboPriceType.Text)
                                Else
                                    getpackprice(itemno, mpc, mrw, "A")
                                End If
                                '=====
                                Dim nwtotalqty As Decimal = 0
                                ReDim Preserve listrmv(rwrmv)
                                With listrmv(rwrmv)
                                    .c1item = dgvItem.Item(9, mrw).Value 'PREV ITEM
                                    .c1unit = dgvItem.Item(4, mrw).Tag
                                    .c1pckg = dgvItem.Item(5, mrw).Value
                                    nwtotalqty = dgvItem.Item(5, mrw).Tag
                                    .c1qty = nwtotalqty
                                    .c1pkno = dgvItem.Item(8, mrw).Tag 'PREV PKNO
                                    .c1whs = dgvItem.Item(10, mrw).Value
                                End With

                                rwrmv += 1
                                editeditem = 1


                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then
                                    nwtotalqty = 0
                                    ReDim Preserve listupd(rwupd)
                              
                                End If

                            End If

                            selrow = mrw
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 3
                            Me.dgvItem.BeginInvoke(method, nextindex)
                            ' Else
                            ' .BeginEdit(True)
                        End If

                    End If

                ElseIf e.ColumnIndex = 3 Then

                    If .Item(3, mrw).Value = 0 Then
                        .CurrentCell = .Item(3, mrw)
                        MsgBox("Invalid quantity", 48, "Invalid quantity")
                    Else
                        '.Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                        '.Item(10, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                        .Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "STANDARD")

                        If .Item(1, mrw).Value <> Nothing Then
                            .ClearSelection()
                            selrow = mrw
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 4
                            Me.dgvItem.BeginInvoke(method, nextindex)


                            Dim nwtotalqty As Decimal = 0
                            Dim oldunit As String = Nothing
                            Dim oldpackg As Decimal = 0

                            nwtotalqty = dgvItem.Item(3, mrw).Value

                            oldqty = getoldqtyfrmtable(.Item(1, mrw).Value, .Item(8, mrw).Value, "ivd") ' dgvItem.Item(5, mrw).Tag
                            oldunit = getolditemunit(.Item(1, mrw).Value, .Item(8, mrw).Value, "ivd")
                            oldpackg = getolditempckg(.Item(1, mrw).Value, .Item(8, mrw).Value, "ivd")

                            nwtotalqty = dgvItem.Item(3, mrw).Value

                            Dim new_current_qty As Decimal = 0

                            If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                                new_current_qty = nwtotalqty * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                            Else
                                new_current_qty = nwtotalqty
                            End If '

                            Dim n_old_qty As Decimal = 0
                            n_old_qty = oldqty * oldpackg


                            Dim itemno As String = Nothing
                            Dim mpc As String = Nothing
                            itemno = .Item(1, mrw).Value
                            mpc = .Item(4, mrw).Value

                            If cboPriceType.Text <> Nothing Then
                                getpackprice(itemno, mpc, mrw, cboPriceType.Text)
                            Else
                                getpackprice(itemno, mpc, mrw, "A")
                            End If


                            Dim fnlqty As Decimal = 0
                            If n_old_qty = new_current_qty Then

                            ElseIf n_old_qty < new_current_qty Then
                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then

                                    fnlqty = new_current_qty - n_old_qty

                                    Dim curqty As Decimal = 0

                                    cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
                                    cmd.Parameters.AddWithValue("@itm", .Item(1, mrw).Value)
                                    cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                                    Using rd As MySqlDataReader = cmd.ExecuteReader
                                        If rd.HasRows Then
                                            rd.Read()
                                            curqty = rd("qty_good").ToString
                                        End If
                                        rd.Close()
                                    End Using
                                    cmd.Dispose()

                                    If curqty < fnlqty Then
                                        MsgBox("Item quantity exceeded on quantity in the warehouse", vbCritical)
                                        ' old_quantity = getcurqty_from_detail(.Item(8, mrw).Value, "salesd")
                                        .Item(3, mrw).Value = oldqty
                                        .Item(4, mrw).Value = oldunit
                                        .Item(5, mrw).Value = oldpackg
                                        ' .CurrentCell = .Item(3, mrw)
                                        '.Item(7, mrw).Value = 0
                                        Exit Sub

                                    End If
                                End If

                                'minus ni diri
                            ElseIf n_old_qty > new_current_qty Then
                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then
                                 
                                End If


                            End If

                        End If
                        ComputeStockOutTotal()
                        CalcTotalQty()
                    End If

                ElseIf e.ColumnIndex = 4 Then 'UNIT===================
                    Dim itemno As String = Nothing
                    Dim mpc As String = Nothing
                    itemno = .Item(1, mrw).Value

                    If .Item(3, mrw).Value = 0 Then
                        '   .ClearSelection()
                        MsgBox("Invalid quantity", 48, "Invalid quantity")
                    Else
                        If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
                            .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
                            mpc = .Item(4, mrw).Value
                            ComputeStockOutTotal()
                            CalcTotalQty()
                            ' btnAdd_Click(sender, e)
                        Else
                            .Item(4, mrw).Value = "C"
                            mpc = .Item(4, mrw).Value
                            '.BeginEdit(True)
                            ComputeStockOutTotal()
                            CalcTotalQty()
                        End If


                        getpackprice(itemno, mpc, mrw, cboPriceType.Text)

                        If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                            .Item(4, mrw).Value = "P"
                            mpc = .Item(4, mrw).Value
                            ComputeStockOutTotal()
                            CalcTotalQty()
                            '  btnAdd_Click(sender, e)
                            '  getpackprice(itemno, mpc, mrw, cboPriceType.Text)
                        End If
                        getpackprice(itemno, mpc, mrw, cboPriceType.Text)
                        selrow = mrw
                        If .Item(1, mrw).Value <> Nothing Then
                            .ClearSelection()
                            ' Dim method As New SetColumnIndex(AddressOf Mymethod)
                            ' Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
                            ' Me.dgvItem.BeginInvoke(method, nextindex)

                        End If
                        ComputeStockOutTotal()
                        CalcTotalQty()
                    End If

                    '--------------------------------------------------------------------------------------------------
                    '--------------------------------------------------------------------------------------------------
                    Dim totalqty As Decimal = 0

                    If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                        totalqty = .Item(3, mrw).Value * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                        ComputeStockOutTotal()
                        CalcTotalQty()
                    ElseIf .Item(4, mrw).Value = "P" Then
                        totalqty = .Item(3, mrw).Value
                        ComputeStockOutTotal()
                        CalcTotalQty()
                    End If

                    Dim nwtotalqty As Decimal = 0
                    Dim oldunit As String = Nothing
                    Dim oldpackg As Decimal = 0

                    nwtotalqty = dgvItem.Item(3, mrw).Value

                    oldqty = getoldqtyfrmtable(.Item(1, mrw).Value, .Item(8, mrw).Value, "ivd") ' dgvItem.Item(5, mrw).Tag
                    oldunit = getolditemunit(.Item(1, mrw).Value, .Item(8, mrw).Value, "ivd")
                    oldpackg = getolditempckg(.Item(1, mrw).Value, .Item(8, mrw).Value, "ivd")

                    nwtotalqty = dgvItem.Item(3, mrw).Value

                    Dim new_current_qty As Decimal = 0

                    If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                        new_current_qty = nwtotalqty * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                    Else
                        new_current_qty = nwtotalqty
                    End If '

                    Dim n_old_qty As Decimal = 0
                    n_old_qty = oldqty * oldpackg
                    ' --------------------------------------------------------------------------------------------------
                    'TRAP IF QTY IS AVAILABLE => RICHEL
                    Dim curqty As Decimal = 0
                    Dim fnlqty As Decimal = 0

                    fnlqty = new_current_qty - n_old_qty

                    cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@itm", .Item(1, mrw).Value)
                    cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                    Using rd As MySqlDataReader = cmd.ExecuteReader
                        If rd.HasRows Then
                            rd.Read()
                            curqty = rd("qty_good").ToString
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()

                    If curqty < fnlqty Then
                        MsgBox("Item quantity exceeded on quantity in the warehouse", vbCritical)

                        .Item(3, mrw).Value = oldqty
                        .Item(4, mrw).Value = oldunit
                        .Item(5, mrw).Value = oldpackg
                        '.Item(7, mrw).Value = 0

                        '.CurrentCell = .Item(3, mrw)
                        ComputeStockOutTotal()
                        'cboWhsCode.Text = Nothing
                        'cboSupplier.Text = Nothing

                        Exit Sub
                    Else
                        'cboWhsCode.Text = Nothing
                        'cboSupplier.Text = Nothing
                    End If
                    'END TRAP
                    '----------------------------------------------------------------

                ElseIf e.ColumnIndex = 5 Then
                    '.ClearSelection()
                    '.CurrentCell = .Item(1, mrw)
                    '.BeginEdit(True)

                End If
            End If
        End With
        '=== END NEW PROCESS ===

    End Sub

    Private Sub cbx_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)
        Dim box As ComboBox = DirectCast(sender, ComboBox)
        If (Me.dgvItem.CurrentCell.ColumnIndex = 4) Then
            Me.dgvItem.CurrentCell.Value = box.SelectedItem.ToString
        End If
        Me.dgvItem.EndEdit(-1)
    End Sub
    Public Sub tbnumonly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 48 Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then e.Handled = True
    End Sub
    Private Sub dgvItem_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvItem.EditingControlShowing
        If (Me.dgvItem.CurrentCell.ColumnIndex = 4) Then
            Dim control As ComboBox = DirectCast(e.Control, ComboBox)
            If (Not control Is Nothing) Then
                RemoveHandler control.SelectionChangeCommitted, New EventHandler(AddressOf cbx_SelectionChangeCommitted)
                AddHandler control.SelectionChangeCommitted, New EventHandler(AddressOf cbx_SelectionChangeCommitted)
            End If
        ElseIf (Me.dgvItem.CurrentCell.ColumnIndex = 3) Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
        End If
        'With dgvItem
        '    If .Rows.Count > 0 Then
        '        If .CurrentCell.ColumnIndex = 3 Then
        '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '        ElseIf .CurrentCell.ColumnIndex = 4 Then
        '            'Dim cbo As ComboBox = CType(e.Control, ComboBox)
        '            selrow = .CurrentCell.RowIndex
        '            'AddHandler cbo.PreviewKeyDown, AddressOf cbx_PreviewKeyDown
        '            Dim combo As ComboBox = CType(e.Control, ComboBox)
        '            If (combo IsNot Nothing) Then

        '                RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

        '                ' Add the event handler. 
        '                ' AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

        '            End If
        '        ElseIf .CurrentCell.ColumnIndex = 1 Then
        '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '            AddHandler CType(e.Control, TextBox).KeyDown, AddressOf column_keydown
        '        Else

        '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress

        '        End If
        '    End If
        'End With
    End Sub

    Private Sub dgvItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvItem.KeyPress
        With dgvItem
            If .Rows.Count > 0 Then
                If Asc(e.KeyChar) = 13 Then
                    If .CurrentCell.ColumnIndex = 5 Then
                        btnAdd.PerformClick()
                    End If

                End If
            End If
        End With
    End Sub

    Private Sub dgvItem_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvItem.KeyUp
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
                        ComputeStockOutTotal()
                    Else
                        .Item(4, mrw).Value = "C"
                        mpc = .Item(4, mrw).Value
                        .BeginEdit(True)
                        ComputeStockOutTotal()
                    End If

                    getpackprice(itemno, mpc, mrw, cboPriceType.Text)

                    If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = "P"
                        mpc = .Item(4, mrw).Value
                        ComputeStockOutTotal()
                    End If

                    ComputeStockOutTotal()
                ElseIf .CurrentCell.ColumnIndex = 1 And e.KeyCode = Keys.F3 Then
                    btnSearch.PerformClick()
                End If
            End If
        End With
    End Sub

    Private Sub btn_CloseU_Click(sender As Object, e As EventArgs) Handles btn_CloseU.Click
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion) = vbYes Then
            Dim trno As String = Nothing

            trno = txtTransNo.Text.Trim()
            close_open_trans_by_user(trno, "ivh", _user)
            Me.Dispose()
        End If
    End Sub

    Private Sub tbRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks.KeyPress
        If e.KeyChar = vbCr Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cboPriceType.Enabled = True
        'cbxSupplier.Enabled = True
        cboWhsCode.Enabled = True
        btnUpdate.Enabled = True
        btnUpdatePrint.Enabled = True
        btnAdd.Enabled = True
        btnSearch.Enabled = True
        btnRemove.Enabled = True
        txtRemarks.Enabled = True
        btnEdit.Enabled = False
        btnPrint.Enabled = False

        dgvItem.ReadOnly = False
        dgvItem.Columns(2).ReadOnly = True
        dgvItem.Columns(0).ReadOnly = True
        dgvItem.Columns(5).ReadOnly = True
        dgvItem.Columns(6).ReadOnly = True
        dgvItem.Columns(7).ReadOnly = True

    End Sub

    Private Sub cboPriceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPriceType.SelectedIndexChanged
        If cboPriceType.Text <> Nothing Then
            With dgvItem
                If .RowCount > 0 Then
                    For i = 0 To .RowCount - 1
                        Dim itemno As String = Nothing
                        Dim mpc As String = Nothing
                        If .Item(1, i).Value <> Nothing And .Item(4, i).Value <> Nothing Then
                            itemno = .Item(1, i).Value
                            mpc = .Item(4, i).Value

                            If cboPriceType.Text <> Nothing Then
                                getpackprice(itemno, mpc, i, cboPriceType.Text)
                            Else
                                getpackprice(itemno, mpc, i, "A")
                            End If
                        End If
                    Next
                    ComputeStockOutTotal()
                    CalcTotalQty()
                End If
            End With
        End If
    End Sub

    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        load_items()
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

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub tDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tDate.KeyPress
        If e.KeyChar = vbCr Then
            cboWhsCode.Focus()
        End If
    End Sub

    Private Sub tDate_ValueChanged(sender As Object, e As EventArgs) Handles tDate.ValueChanged

    End Sub

    Private Sub cboWhs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWhsCode.SelectedIndexChanged

    End Sub

    Private Sub tsUpdate_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsUpdate.ItemClicked

    End Sub
End Class