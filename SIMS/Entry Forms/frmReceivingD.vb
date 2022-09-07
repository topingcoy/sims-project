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

Public Class frmReceivingD


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


    Function GetTransNo()
        Dim sdate As String = Now.ToString("yyyyMMdd")
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select transno from rcvingh where transno like '" & sdate & "%' order by pkno desc", cdb)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                GetTransNo = Format(CLng(rd.Item("transno").ToString) + 1)
            Else
                GetTransNo = sdate & "101"
            End If
            rd.Close()
        End Using
        Return GetTransNo
    End Function


    Private Sub frmReceivingD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' If cbxSupplier.Text <> Nothing Or cbxWarehouse.Text <> Nothing Or tbPONo.Text <> Nothing Or tbInvoiceNo.Text <> Nothing Then
        'If MsgBox("Are you sure you want to discard entry?", vbYesNo + vbQuestion) = vbYes Then
        '    'gbxItemList.Visible = False
        '    'gbxItemList.SendToBack()
        '    Me.Dispose()
        'Else
        '    Exit Sub
        'End If
        ' ElseIf cbxSupplier.Text = Nothing Or cbxWarehouse.Text = Nothing Or tbPONo.Text = Nothing Or tbInvoiceNo.Text = Nothing Then
        ' gbxItemList.Visible = False
        ' gbxItemList.SendToBack()
        ' Me.Dispose()
        ' End If
    End Sub

    Private Sub frmReceivingD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F3 Then
            If btnSearchItem.Enabled = False Then
                MsgBox("Click edit button first!", vbExclamation)
            Else
                btnSearchItem_Click(sender, e)
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
        End If
        'If e.KeyCode = Keys.F2 Then
        '    frmSearchItem.ShowDialog()
        ''End If

        'If e.KeyCode = Keys.F3 Then

        '    If tsItems.Enabled = False Then
        '        MsgBox("Click edit button first.", vbCritical)
        '        Exit Sub
        '    Else
        '        btnSearchItem_Click(sender, e)
        '    End If
        'End If

        '    gbxItemList.Focus()

        '    If cbxSupplier.Text = Nothing Or cbxWarehouse.Text = Nothing Then
        '        MsgBox("Enter Required Fields First!", vbCritical)
        '        Exit Sub
        '    End If

        '    With dgvItem

        '        If .Rows.Count > 0 Then
        '            Dim r As Integer = 0

        '            r = .Rows.Count - 1


        '            If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing _
        '                And .Rows(r).Cells(7).Value <> Nothing Then

        '                dgvItemList.Focus()
        '                gbxItemList.Visible = True
        '                gbxItemList.BringToFront()

        '                LoadItemList()
        '                With dgvItemList
        '                    If lastitemsel <> Nothing Then 'FOCUS ON LAST ITEM

        '                        If .Rows.Count > 0 Then
        '                            For i = 0 To .Rows.Count - 1
        '                                If .Item(1, i).Value = lastitemsel Then
        '                                    '.ClearSelection()
        '                                    .Item(1, i).Selected = True
        '                                    .CurrentCell = .Item(1, i)
        '                                    .Focus()
        '                                    Exit For
        '                                End If
        '                            Next
        '                        End If
        '                    Else
        '                        .Focus()

        '                    End If
        '                End With
        '                dgvItemList.Focus()
        '            Else
        '                '  MsgBox("Please provide proper item/s and quantity first", 48, "Invalid entry found")
        '            End If
        '        Else
        '            dgvItemList.Focus()
        '            gbxItemList.Visible = True
        '            gbxItemList.BringToFront()

        '            LoadItemList()
        '            With dgvItemList
        '                If lastitemsel <> Nothing Then 'FOCUS ON LAST ITEM

        '                    If .Rows.Count > 0 Then
        '                        For i = 0 To .Rows.Count - 1
        '                            If .Item(1, i).Value = lastitemsel Then
        '                                '.ClearSelection()
        '                                .Item(1, i).Selected = True
        '                                .CurrentCell = .Item(1, i)
        '                                .Focus()
        '                                Exit For
        '                            End If
        '                        Next
        '                    End If
        '                Else
        '                    .Focus()

        '                End If
        '            End With
        '            dgvItemList.Focus()
        '        End If
        '    End With

        '    ' tbSearchItem.Focus()
        ''  End If

        'If e.KeyCode = Keys.Escape Then
        '    If gbxItemList.Visible = True Then
        '        'gbxItemList.Visible = False
        '        'gbxItemList.SendToBack()
        '        'btnAdd_Click(sender, e)
        '        'ElseIf MsgBox("Are you sure you want to Discard Changes?", vbYesNo + vbQuestion, "Receiving Entry") = vbYes Then
        '        '    Me.Dispose()
        '        'Else
        '        '    Me.Close()
        '        'End If
        '        btnCloseG_Click(sender, e)
        '    ElseIf tsItems.Enabled = False Then
        '        btnCloseR_Click(sender, e)
        '    ElseIf e.KeyCode = Keys.F7 Then
        '        If tsItems.Enabled = False Then
        '            MsgBox("Click edit button first.", vbCritical)
        '            Exit Sub
        '        Else
        '            btnRemove_Click(sender, e)
        '        End If
        '    End If
        'End If

    End Sub


    Private Sub DeleteBlankRow()
        For i = 0 To dgvItem.RowCount - 1
            If dgvItem.Rows(i).Cells(1).Value = Nothing Then
                dgvItem.Rows.Remove(dgvItem.Rows(i))
            End If
        Next
    End Sub

    Private Sub frmReceivingD_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

    End Sub

    Private Sub frmReceivingD_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If txtUser.Text = Nothing Then
            txtUser.Text = _user
        End If

        If txtInvoiceNo.Text <> Nothing Then
            txtInvoiceNoupdate.Text = txtInvoiceNo.Text
        End If

        If txtPONo.Text <> Nothing Then
            txtPOupdate.Text = txtPONo.Text
        End If

        btnUpdate.Enabled = False
        btnUpdatePrint.Enabled = False
        btnSave.Enabled = True
        btnSavePrint.Enabled = True
        'RcvDate.Enabled = False
        CalTotalQty()
        ' prevwhs = cbxWarehouse.Text
        If Me.Tag = 0 Then
            LoadSupplier()
            LoadWarehouse()
            reset_listrmv()
            reset_listupd()
            txtGrossAmount.Text = "0.00"
            txtDisc1.Text = "0.00"
            txtDisc2.Text = "0.00"
            txtDisc3.Text = "0.00"
            txtNetAmount.Text = "0.00"
        End If

    End Sub

    Sub rDisble()
        RcvDate.Enabled = False
        cbxSupplier.Enabled = False
        cbxWarehouse.Enabled = False
        txtPONo.Enabled = False
        txtInvoiceNo.Enabled = False
        tsItems.Enabled = False
        tsSave.Enabled = False
        'tsUpdate.Enabled = False
        dgvItem.Enabled = True
        NuPD1.Enabled = False
        NuPD2.Enabled = False
        NuPD3.Enabled = False

    End Sub

    Sub CalTotalQty()
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

    Sub RcvDisabled()
        RcvDate.Enabled = False
        cbxSupplier.Enabled = False
        cbxWarehouse.Enabled = False
        txtPONo.Enabled = False
        txtInvoiceNo.Enabled = False
        dgvItem.Enabled = False
        tsItems.Enabled = False
        NuPD1.Enabled = False
        NuPD2.Enabled = False
        NuPD3.Enabled = False
    End Sub

    Sub RcvEnabled()
        RcvDate.Enabled = True
        'cbxSupplier.Enabled = True 
        btnUpdatePrint.Enabled = True
        btnUpdate.Enabled = True
        btnEdit.Enabled = False
        btnCloseD.Text = "Cancel"
        cbxWarehouse.Enabled = True
        txtPONo.Enabled = True
        txtInvoiceNo.Enabled = True
        dgvItem.Enabled = True
        tsItems.Enabled = True
        NuPD1.Enabled = True
        NuPD2.Enabled = True
        NuPD3.Enabled = True
    End Sub

    Sub LoadItemList()
        dgvItem.EndEdit()
        dgvItemList.Rows.Clear()
        '   dgvItemList.Focus()
        Dim i As Integer
        If cbxSupplier.Text <> Nothing Then
            cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND supcode=@spc and isdeleted<>1 ORDER BY description ASC", cdb)
            cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                      rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                      rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                      Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
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
        End If

    End Sub

    Sub LoadSupplier()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxSupplier.Items.Clear()
        cbxSupplier.DisplayMember = "text"
        qry = "Select * from supplier ORDER BY suppliername"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxSupplier.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("supcode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadWarehouse()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand
        cbxWarehouse.Items.Clear()
        cbxWarehouse.DisplayMember = "text"
        qry = "Select * from warehouse ORDER BY warehouse"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxWarehouse.Items.Add(New With {.Text = relr("whscode").ToString(), .Value = relr("whscode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub


    Private Sub tsnew_Click(sender As Object, e As EventArgs)
        'tbTransNo.Text = GetTransNo()
        ' GetTransRcvNo()
    End Sub

    Sub GetTransRcvNo()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        cqry = "Select transno as tno FROM rcvingh ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While
            rcvtno = Strings.Right(mdr("tno").ToString, 9) + 1
            rcvtno = "R" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If


        If rcnt = 0 Then
            rcvtno = "R000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        txtTransNo.Text = rcvtno

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

    Dim editeditem As Integer = 0

    Private Sub dgvItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellClick
        If Not e.RowIndex = -1 Then
            'Apply on column index in which you want to display DatetimePicker.
            'For this example it is 2.
            If e.ColumnIndex = 14 Then
                'Initialize the dateTimePicker1.
                dtpicker1 = New DateTimePicker()
                'Adding the dateTimePicker1 into DataGridView.
                dgvItem.Controls.Add(dtpicker1)
                ' Setting the format i.e. mm/dd/yyyy)
                dtpicker1.Format = DateTimePickerFormat.Short
                ' Create retangular area that represents the display area for a cell.
                Dim oRectangle As Rectangle = dgvItem.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
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

    Private Sub dgvRcvItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellEndEdit
        '==== START NEW PROCESS === COCOY
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0

                mrw = e.RowIndex

                ' act = .Item(7, mrw).Value
                If e.ColumnIndex = 1 Then
                    Dim itemno As String = Nothing

                    itemno = .Item(1, mrw).Value
                    .Item(0, mrw).ReadOnly = True
                    .Item(2, mrw).ReadOnly = True
                    .Item(5, mrw).ReadOnly = True
                    .Item(6, mrw).ReadOnly = True
                    .Item(7, mrw).ReadOnly = True
                    .Item(8, mrw).ReadOnly = True
                    .Item(9, mrw).ReadOnly = True

                    If itemno <> Nothing And itemno <> " " Then
                        .Item(1, mrw).Value = UCase(itemno)
                        itemno = .Item(1, mrw).Value
                        .Item(14, mrw).Value = frmExpressCollD.sDate.Value

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
                            If .Item(1, mrw).Value <> .Item(12, mrw).Value Then 'PREV ITEM
                                'addrwindex = mrw
                                'ReDim Preserve listrowsadded(rwsnews)
                                'With listrowsadded(rwsnews)
                                '    .c_myrowindex = addrwindex 'Added new row
                                'End With
                                'rwsnews += 1

                                Dim nwtotalqty As Decimal = 0
                                ReDim Preserve listrmv(rwrmv)
                                With listrmv(rwrmv)
                                    .c1item = dgvItem.Item(12, mrw).Value 'PREV ITEM
                                    .c1unit = dgvItem.Item(4, mrw).Tag
                                    .c1pckg = dgvItem.Item(5, mrw).Value
                                    nwtotalqty = dgvItem.Item(5, mrw).Tag
                                    .c1qty = nwtotalqty
                                    .c1pkno = dgvItem.Item(11, mrw).Tag 'PREV PKNO
                                    .c1whs = dgvItem.Item(13, mrw).Value
                                End With

                                rwrmv += 1
                                editeditem = 1

                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then
                                    nwtotalqty = 0
                                    ReDim Preserve listupd(rwupd)
                                    listupd(rwupd).c1uitem = .Item(1, mrw).Value
                                    nwtotalqty = dgvItem.Item(3, mrw).Value
                                    listupd(rwupd).c1upqty = nwtotalqty
                                    '  listupd(rwupd).c1whse = cbxWarehouse.SelectedItem.value
                                    listupd(rwupd).c1upckg = .Item(5, mrw).Value
                                    listupd(rwupd).c1upkno = .Item(11, mrw).Value ' PREV PKNO
                                    rwupd += 1
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
                    'orig code = .Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "STANDARD")
                    '.Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "#,##0")
                    '.Item(8, mrw).Value = .Item(3, mrw).Value
                    '.Item(9, mrw).Value = Format(.Item(8, mrw).Value * .Item(6, mrw).Value, "STANDARD")
                    If .Item(3, mrw).Value = 0 Then
                        .CurrentCell = .Item(3, mrw)
                        MsgBox("Invalid quantity", 48, "Invalid quantity")
                    Else
                        '.Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                        '.Item(10, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                        .Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")

                        If .Item(1, mrw).Value <> Nothing Then
                            .ClearSelection()
                            selrow = mrw
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 4
                            Me.dgvItem.BeginInvoke(method, nextindex)

                            Dim oldqty As Decimal = 0
                            Dim nwtotalqty As Decimal = 0

                            nwtotalqty = dgvItem.Item(3, mrw).Value
                            oldqty = dgvItem.Item(5, mrw).Tag

                            Dim fnlqty As Decimal = 0
                            If oldqty = nwtotalqty Then
                            ElseIf oldqty < nwtotalqty Then

                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then
                                    'orig 'fnlqty = nwtotalqty - oldqty
                                    fnlqty = nwtotalqty - oldqty
                                    ReDim Preserve listupd(rwupd)
                                    listupd(rwupd).c1uitem = .Item(1, mrw).Value
                                    listupd(rwupd).c1upqty = fnlqty
                                    'orig 'listupd(rwupd).c1operator = "-"
                                    listupd(rwupd).c1operator = "+"
                                    '  listupd(rwupd).c1whse = cbxWarehouse.SelectedItem.value
                                    listupd(rwupd).c1upckg = .Item(5, mrw).Value
                                    listupd(rwupd).c1upkno = .Item(11, mrw).Value 'PREV PKNO
                                    rwupd += 1
                                End If

                                'minus ni diri
                            ElseIf oldqty > nwtotalqty Then
                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then
                                    fnlqty = oldqty - nwtotalqty
                                    ReDim Preserve listupd(rwupd)
                                    listupd(rwupd).c1uitem = .Item(1, mrw).Value
                                    listupd(rwupd).c1upqty = fnlqty
                                    'orig 'listupd(rwupd).c1operator = "+"
                                    listupd(rwupd).c1operator = "-"
                                    '  listupd(rwupd).c1whse = cbxWarehouse.SelectedItem.value
                                    listupd(rwupd).c1upckg = .Item(5, mrw).Value
                                    listupd(rwupd).c1upkno = .Item(11, mrw).Value 'PREV PKNO
                                    rwupd += 1
                                    'add ni diri
                                End If

                            End If

                        End If
                        ComputeRcvTotal()
                        CalTotalQty()

                    End If


                    'If tbTransNo.Text.Trim <> Nothing Then
                    '    Dim tfound As Boolean = False

                    '    cmd = New MySqlCommand("SELECT transno FROM rcvingh WHERE  transno=@tno", cdb)
                    '    cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
                    '    Using rd As MySqlDataReader = cmd.ExecuteReader
                    '        If rd.HasRows Then
                    '            tfound = True
                    '        End If
                    '    End Using
                    '    cmd.Dispose()

                    '    If tfound Then
                    '        'cmd = New MySqlCommand("UPDATE rcvingd SET amount=@amt WHERE transno=@tno", cdb)
                    '        'cmd.Parameters.AddWithValue("@amt", Decimal.Parse(lbltotalamt.Text))
                    '        'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
                    '        'cmd.ExecuteNonQuery()
                    '        'cmd.Dispose()
                    '    End If

                    'End If
                    '   getotal()


                    ' .Item(3, mrw).Selected = True
                ElseIf e.ColumnIndex = 4 Then
                    Dim itemno As String = Nothing
                    Dim mpc As String = Nothing
                    itemno = .Item(1, mrw).Value
                    '  ComputeRcvTotal()
                    ' CalTotalQty()
                    If .Item(3, mrw).Value = 0 Then
                        '   .ClearSelection()
                        MsgBox("Invalid quantity", 48, "Invalid quantity")
                    Else
                        If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
                            .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
                            mpc = .Item(4, mrw).Value
                            '   getpackprice(itemno, mpc, mrw) 'remove ni richel
                            ComputeRcvTotal()
                            CalTotalQty()
                            ' btnAdd_Click(sender, e)
                            '  SendKeys.Send("{enter}")
                        Else
                            .Item(4, mrw).Value = "C"
                            mpc = .Item(4, mrw).Value
                            '.BeginEdit(True)
                            ' getpackprice(itemno, mpc, mrw) 'remove ni richel
                            ComputeRcvTotal()
                            CalTotalQty()
                            '  SendKeys.Send("{enter}")
                        End If

                        getpackprice(itemno, mpc, mrw) ''gibalik ni richel

                        If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                            .Item(4, mrw).Value = "P"
                            mpc = .Item(4, mrw).Value
                            ComputeRcvTotal()
                            CalTotalQty()
                            '  btnAdd_Click(sender, e)
                            '  getpackprice(itemno, mpc, mrw) 'remove ni richel
                        End If

                        getpackprice(itemno, mpc, mrw)
                        selrow = mrw
                        If .Item(1, mrw).Value <> Nothing Then
                            .ClearSelection()
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
                            Me.dgvItem.BeginInvoke(method, nextindex)
                            ComputeRcvTotal()
                            CalTotalQty()
                        End If
                        'ComputeRcvTotal()
                        'CalTotalQty()
                    End If

                    '--------------------------------------------------------------------------------------------------
                    '--------------------------------------------------------------------------------------------------
                    Dim totalqty As Decimal = 0

                    If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                        totalqty = .Item(3, mrw).Value * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                        ComputeRcvTotal()
                        CalTotalQty()
                    ElseIf .Item(4, mrw).Value = "P" Then
                        totalqty = .Item(3, mrw).Value
                        ComputeRcvTotal()
                        CalTotalQty()
                    End If
                    '--------------------------------------------------------------------------------------------------
                    '--------------------------------------------------------------------------------------------------

                    'trap qty onhand vs new qty inputed
                    'Dim curqty As Decimal = 0

                    'cmd = New MySqlCommand("SELECT item,qty_good FROM ivwh WHERE item=@itm ", cdb)
                    'cmd.Parameters.AddWithValue("@itm", .Item(1, mrw).Value)
                    ''cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                    'Using rd As MySqlDataReader = cmd.ExecuteReader
                    '    If rd.HasRows Then
                    '        rd.Read()
                    '        curqty = rd("qty_good").ToString
                    '    End If
                    '    rd.Close()
                    'End Using
                    'cmd.Dispose()

                    'If curqty < totalqty Then
                    '    MsgBox("Qty on hand is less than the Qty Entered", vbCritical)
                    '    .Item(3, mrw).Value = 0
                    '    '.CurrentCell = .Item(3, mrw)
                    '    Exit Sub
                    'End If
                    'end trap


                    'ElseIf e.ColumnIndex = 8 Then

                    '    If .Item(3, mrw).Value <> Nothing Then
                    '        'orig code = .Item(10, mrw).Value = .Item(3, mrw).Value - .Item(8, mrw).Value
                    '        '  .Item(10, mrw).Value = Format(.Item(3, mrw).Value - .Item(8, mrw).Value, "#,##0")
                    '        ' .Item(9, mrw).Value = Format(.Item(8, mrw).Value * .Item(6, mrw).Value, "STANDARD")
                    '        '  .Item(11, mrw).Value = Format(.Item(10, mrw).Value * .Item(6, mrw).Value, "STANDARD")
                    '        .Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                    '    Else
                    '        ' MsgBox("Please input order quantity first!", 48, "Order Quantity is required")
                    '        .Item(8, mrw).Value 
                    '    End If
                    '   getotal()
                    'If e.ColumnIndex = 3 Then
                    '    .Item(3, mrw).Value = .Item(7, mrw).ToString
                    'End If

                    'If .Item(3, mrw).Value <> Nothing Then
                    '    .Item(3, mrw).Value = act
                    'End If
                ElseIf e.ColumnIndex = 5 Then
                    '.ClearSelection()
                    '.CurrentCell = .Item(1, mrw)
                    '.BeginEdit(True)

                End If
            End If
        End With
        '=== END NEW PROCESS ===



        '==== OLD PROCESS ===
        'With dgvItem
        '    If .RowCount > 0 Then
        '        Dim mrw As Integer = 0
        '        Dim act As Integer = 0

        '        mrw = e.RowIndex
        '        act = .Item(7, mrw).Value
        '        If e.ColumnIndex = 1 Then
        '            Dim itemno As String = Nothing

        '            itemno = .Item(1, mrw).Value


        '            If itemno <> Nothing And itemno <> " " Then
        '                .Item(1, mrw).Value = UCase(itemno)
        '                itemno = .Item(1, mrw).Value


        '                If getitem_byid(itemno, mrw) Then
        '                    If checkitemno_update(itemno, mrw) = True Then
        '                        MsgBox("Item already on the list!", 64, "Item added")
        '                    End If
        '                    .ClearSelection()
        '                    .CurrentCell = .Item(3, mrw)
        '                    .BeginEdit(True)
        '                    ComputeRcvTotal()
        '                    .ClearSelection()
        '                    selrow = mrw
        '                    Dim method As New SetColumnIndex(AddressOf Mymethod)
        '                    Dim nextindex As Integer = 3
        '                    Me.dgvItem.BeginInvoke(method, nextindex)

        '                Else
        '                    .BeginEdit(True)
        '                End If

        '            End If




        '        ElseIf e.ColumnIndex = 3 Then

        '            orig code = .Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "STANDARD")
        '            .Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "#,##0")
        '            .Item(8, mrw).Value = .Item(3, mrw).Value
        '            .Item(9, mrw).Value = Format(.Item(8, mrw).Value * .Item(6, mrw).Value, "STANDARD")
        '            If .Item(3, mrw).Value = 0 Then
        '                .CurrentCell = .Item(3, mrw)
        '                MsgBox("Invalid quantity", 48, "Invalid quantity")
        '            Else
        '                .Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")

        '                If .Item(1, mrw).Value <> Nothing Then
        '                    .ClearSelection()
        '                    selrow = mrw
        '                    Dim method As New SetColumnIndex(AddressOf Mymethod)
        '                    Dim nextindex As Integer = 4
        '                    Me.dgvItem.BeginInvoke(method, nextindex)

        '                End If
        '                ComputeRcvTotal()
        '                CalTotalQty()
        '            End If


        '            If tbTransNo.Text.Trim <> Nothing Then
        '                Dim tfound As Boolean = False

        '                cmd = New MySqlCommand("SELECT transno FROM rcvingh WHERE  transno=@tno", cdb)
        '                cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
        '                Using rd As MySqlDataReader = cmd.ExecuteReader
        '                    If rd.HasRows Then
        '                        tfound = True
        '                    End If
        '                End Using
        '                cmd.Dispose()

        '                If tfound Then
        '                    'cmd = New MySqlCommand("UPDATE rcvingd SET amount=@amt WHERE transno=@tno", cdb)
        '                    'cmd.Parameters.AddWithValue("@amt", Decimal.Parse(lbltotalamt.Text))
        '                    'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
        '                    'cmd.ExecuteNonQuery()
        '                    'cmd.Dispose()
        '                End If

        '            End If
        '            getotal()


        '            .Item(3, mrw).Selected = True
        '        ElseIf e.ColumnIndex = 4 Then
        '            Dim itemno As String = Nothing
        '            Dim mpc As String = Nothing
        '            itemno = .Item(1, mrw).Value

        '            If .Item(3, mrw).Value = 0 Then
        '                .ClearSelection()
        '                MsgBox("Invalid quantity", 48, "Invalid quantity")
        '            Else
        '                If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
        '                    .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
        '                    mpc = .Item(4, mrw).Value
        '                    ComputeRcvTotal()
        '                    CalTotalQty()
        '                Else
        '                    .Item(4, mrw).Value = "C"
        '                    mpc = .Item(4, mrw).Value
        '                    .BeginEdit(True)
        '                    ComputeRcvTotal()
        '                    CalTotalQty()
        '                End If

        '                getpackprice(itemno, mpc, mrw)

        '                If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
        '                    .Item(4, mrw).Value = "P"
        '                    mpc = .Item(4, mrw).Value
        '                    ComputeRcvTotal()
        '                    CalTotalQty()
        '                End If

        '                selrow = mrw
        '                If .Item(1, mrw).Value <> Nothing Then
        '                    .ClearSelection()
        '                    Dim method As New SetColumnIndex(AddressOf Mymethod)
        '                    Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
        '                    Me.dgvItem.BeginInvoke(method, nextindex)

        '                End If
        '                ComputeRcvTotal()
        '                CalTotalQty()
        '            End If

        '        ElseIf e.ColumnIndex = 8 Then

        '            If .Item(3, mrw).Value <> Nothing Then
        '                'orig code = .Item(10, mrw).Value = .Item(3, mrw).Value - .Item(8, mrw).Value
        '                '  .Item(10, mrw).Value = Format(.Item(3, mrw).Value - .Item(8, mrw).Value, "#,##0")
        '                ' .Item(9, mrw).Value = Format(.Item(8, mrw).Value * .Item(6, mrw).Value, "STANDARD")
        '                '  .Item(11, mrw).Value = Format(.Item(10, mrw).Value * .Item(6, mrw).Value, "STANDARD")
        '                .Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
        '            Else
        '                ' MsgBox("Please input order quantity first!", 48, "Order Quantity is required")
        '                .Item(8, mrw).Value
        '            End If
        '            getotal()
        '            If e.ColumnIndex = 3 Then
        '                .Item(3, mrw).Value = .Item(7, mrw).ToString
        '            End If

        '            If .Item(3, mrw).Value <> Nothing Then
        '                .Item(3, mrw).Value = act
        '            End If
        '        ElseIf e.ColumnIndex = 5 Then
        '            .ClearSelection()
        '            .CurrentCell = .Item(1, mrw)
        '            .BeginEdit(True)

        '        End If
        '    End If
        'End With
    End Sub

    Sub getpackprice(ByVal itm As String, ByVal pck As String, ByVal rx As Integer)
        Dim cpck As Decimal = 0
        Dim bpck As Decimal = 0
        Dim ppck As Decimal = 0
        Dim gcost As Decimal = 0
        Dim iunit As String = Nothing
        Dim ncost As Decimal = 0
        Dim costpc As Decimal = 0


        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT PCKGC,PCKGB,PCKGP,GRSCOST,UNIT, NETCOST, COSTPC FROM ivitem WHERE ITEMCODE=@tm and isdeleted<>1", cdb)
        cmd.Parameters.AddWithValue("@tm", itm)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()

                cpck = rd("PCKGC").ToString
                bpck = rd("PCKGB").ToString
                gcost = rd("GRSCOST").ToString
                iunit = rd("UNIT").ToString
                ncost = rd("NETCOST").ToString
                costpc = rd("COSTPC").ToString

                Dim pcost As Decimal = 0

                With dgvItem
                    If pck = "C" Then
                        .Item(5, rx).Value = cpck

                        .Item(6, rx).Value = Format(gcost, "STANDARD")
                        ' .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        .Item(8, rx).Value = costpc
                        .Item(9, rx).Value = Format(.Item(3, rx).Value * .Item(5, rx).Value * .Item(8, rx).Value, "STANDARD")
                        .Item(14, rx).Value = frmExpressCollD.sDate.Value
                    ElseIf pck = "P" Then
                        'If iunit = "C" Then
                        '    pcost = gcost / cpck
                        'End If
                        .Item(5, rx).Value = 1

                        .Item(6, rx).Value = Format(costpc, "STANDARD")
                        .Item(7, rx).Value = Format(costpc, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        .Item(8, rx).Value = costpc
                        .Item(9, rx).Value = Format(.Item(3, rx).Value * .Item(5, rx).Value * .Item(8, rx).Value, "STANDARD")
                        .Item(14, rx).Value = frmExpressCollD.sDate.Value

                    ElseIf pck = "B" Then
                        Dim bgprice As Decimal = 0
                        ' bgprice = (gcost / cpck) * bpck
                        ' bgprice = (costpc) * .Item(3, rx).Value
                        bgprice = (ncost) * .Item(3, rx).Value

                        .Item(6, rx).Value = Format(costpc, "STANDARD") * bpck 'get the bag price

                        .Item(5, rx).Value = bpck
                        .Item(7, rx).Value = Format(costpc, "STANDARD") * bpck
                        .Item(8, rx).Value = Format(costpc, "STANDARD") * bpck
                        '.Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        '.Item(7, rx).Value = costpc
                        .Item(8, rx).Value = costpc
                        ' bgprice = (costpc * bpck) * .Item(3, rx).Value
                        .Item(9, rx).Value = Format(.Item(3, rx).Value * .Item(5, rx).Value * .Item(8, rx).Value, "STANDARD")
                        .Item(14, rx).Value = frmExpressCollD.sDate.Value
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
        cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
        With dgvItem
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    .Item(2, rdx).Value = rd("description").ToString
                    .Item(4, rdx).Value = rd("unit").ToString
                    .Item(5, rdx).Value = rd("PCKGC").ToString
                    .Item(6, rdx).Value = rd("grscost").ToString
                    .Item(7, rdx).Value = rd("netcost").ToString
                    .Item(8, rdx).Value = rd("costpc").ToString
                    .Item(14, rdx).Value = frmExpressCollD.sDate.Value
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
                    .Item(8, rdx).Value = Nothing
                    .Item(9, rdx).Value = Nothing
                    .Item(14, rdx).Value = Nothing
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

        'If dgvItem.RowCount >= 1 Then
        '    If dgvItem.CurrentCell.ColumnIndex = 1 Then
        '        'If e.KeyCode = Keys.F2 Then
        '        '    frmSearch.Text = "Sales"
        '        '    sWhse = tbBT.Text
        '        '    frmSearch.ShowDialog()
        '        'check if quantity is available

        '        'SendKeys.Send("{ENTER}")
        '        'dgvItems_CellEndEdit(1, vbCr)

        '        dgvItem.CurrentCell = dgvItem.CurrentRow.Cells(3)
        '    End If
        'End If
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True
        '    Dim iCol = dgvItem.CurrentCell.ColumnIndex
        '    Dim iRow = dgvItem.CurrentCell.RowIndex
        '    If iCol = dgvItem.Columns.Count - 1 Then
        '        If iRow < dgvItem.Rows.Count - 1 Then
        '            dgvItem.CurrentCell = dgvItem(0, iRow + 1)
        '        End If
        '    Else
        '        If iCol >= dgvItem.Columns.Count - 2 Then
        '            If iRow < dgvItem.RowCount - 1 Then
        '                dgvItem.CurrentCell = dgvItem(0, iRow + 1)
        '            Else
        '                dgvItem.CurrentCell = dgvItem(0, iRow)
        '            End If
        '        Else
        '            '  dgvItem.CurrentCell = dgvItem(iCol + 1, iRow)
        '        End If
        '    End If

        '    'If iCol = 6 Then
        '    '    sComputeTotal()
        '    '    lblQtyOH.Text = ""
        '    '    tsItemMenu.Focus()
        '    '    tsItemMenu.Items(0).Select()
        '    'End If

        'ElseIf e.KeyCode = Keys.Escape Then
        '    If dgvItem.CurrentRow.Cells(1).Value = Nothing Then
        '        dgvItem.Rows.Remove(dgvItem.CurrentRow)
        '    End If
        'End If
        ''   End If



        'With dgvItem

        '    'If e.KeyCode = Keys.Enter And .CurrentCell.ColumnIndex = 3 Then
        '    '    e.Handled = True
        '    '    'If .CurrentRow.Cells(1).Value = Nothing Then
        '    '    '    .Rows.Remove(.CurrentRow)
        '    '    'End If
        '    'End If
        '    'If e.KeyCode = Keys.F2 Then
        '    '    tsAddItem.PerformClick()
        '    'End If
        'End With

    End Sub

    Sub ComputeRcvTotal()
        Dim ntotAmt As Double = Nothing
        Dim Gross As Double = Nothing
        Dim NetAmt As Double = Nothing
        Dim Disc1 As Double = 0
        Dim Disc2 As Double = 0
        ' Dim Disc3 As Double = 0


        For i = 0 To dgvItem.RowCount - 1
            Gross += dgvItem.Rows(i).Cells(9).Value
            dgvItem.Rows(i).Cells(0).Value = i + 1
        Next

        Me.txtGrossAmount.Text = Format((Gross), sFmat)
        NuPD1_KeyPress(1, New KeyPressEventArgs(vbCr))
        NuPD2_KeyPress(1, New KeyPressEventArgs(vbCr))
        '  NuPD3_KeyPress(1, New KeyPressEventArgs(vbCr))

        ' NetAmt = tbNetAmount.Text


        Disc1 = Gross * IIf(NuPD1.Value > 0, (NuPD1.Value / 100), 0)
        Disc2 = txtDisc1Net.Text * IIf(NuPD2.Value > 0, (NuPD2.Value / 100), 0)
        ' Disc3 = txtDisc2Net.Text * IIf(NuPD3.Value > 0, (NuPD3.Value / 100), 0)

        'tbDisc1.Text = Disc1
        'tbDisc2.Text = Disc2
        'tbDisc3.Text = Disc3

        Dim totdisc As Decimal = 0
        totdisc = Disc1 + Disc2 '+ Disc3

        Me.txtNetAmount.Text = Format((Gross - totdisc), sFmat)

        'nSDisc = (ntotAmt - nRDisc) * (nudSpDisc.Value / 100)
        'dgvTotal.Rows(2).Cells(1).Value = nSDisc
        'dgvTotal.Rows(3).Cells(1).Value = ntotAmt - nRDisc - nRDisc

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
        '  ComputeRcvTotal()
    End Sub

    Private Sub btnCloseG_Click(sender As Object, e As EventArgs) Handles btnCloseG.Click
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
                                        .Item(1, nn).Tag = "A"
                                        .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value 'ITEM
                                        'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                        '    MsgBox("not equal1")
                                        'End If
                                        .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                        .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                        .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                        .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                        .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                        .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                        .Item(14, nn).Value = frmExpressCollD.sDate.Value
                                        '.Item(14, nn).Value = Date.Today
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
                                                listupd(rwupd).c1whse = cbxWarehouse.SelectedItem.value
                                                listupd(rwupd).c1upckg = .Item(5, rindex).Value
                                                listupd(rwupd).c1upkno = .Item(8, rindex).Value
                                                rwupd += 1
                                            End If
                                            .Item(1, rindex).Tag = "A"
                                            .Item(2, rindex).Value = dgvItemList.Item(2, rdx).Value 'DESCRIPTION
                                            .Item(4, rindex).Value = dgvItemList.Item(9, rdx).Value 'QTY
                                            .Item(5, rindex).Value = dgvItemList.Item(10, rdx).Value 'UNIT
                                            .Item(6, rindex).Value = dgvItemList.Item(13, rdx).Value 'PCKG
                                            .Item(7, rindex).Value = dgvItemList.Item(14, rdx).Value  'GROSSCOST
                                            .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value 'NET COST
                                            .Item(14, nn).Value = frmExpressCollD.sDate.Value
                                            ' .Item(13, nn).Value = RcvDate.Value
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
                                            .Item(1, nn).Tag = "A"
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    MsgBox("not equal2")
                                            'End If
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                            .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                            .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value 'NET COST
                                            .Item(14, nn).Value = frmExpressCollD.sDate.Value
                                            ' .Item(14, nn).Value = Date.Today
                                            '.Item(13, nn).Value = RcvDate.Value
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
                                            .Item(1, nn).Tag = "A"
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    MsgBox("not equal3")
                                            'End If
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                            .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                            .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value 'NET COST
                                            .Item(14, nn).Value = frmExpressCollD.sDate.Value
                                            '.Item(14, nn).Value = Date.Today
                                            ' .Item(13, nn).Value = RcvDate.Value
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
                                    .Item(1, nn).Tag = "A"
                                    .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                    'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                    '    MsgBox("not equal4")
                                    'End If
                                    .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                    .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                    .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                    .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                    .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                    .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value 'NET COST
                                    .Item(14, nn).Value = frmExpressCollD.sDate.Value
                                    '.Item(14, nn).Value = Date.Today
                                    ' .Item(13, nn).Value = RcvDate.Value
                                    'frmReceivingD.dgvItem.Rows(9).Cells(9).Value = frmReceivingD.RcvDate.Value
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


        'old 
        'With dgvItemList
        '    If .RowCount > 0 Then
        '        With dgvItemList
        '            If .RowCount > 0 Then
        '                Dim nn As Integer = 0
        '                Dim nm As Integer = 0
        '                Dim rindex As Integer = 0
        '                Dim rdx As Integer = 0

        '                rdx = dgvItemList.CurrentCell.RowIndex

        '                With dgvItem
        '                    'Dim mycat As String = Nothing
        '                    'mycat = dgvItemList.Item(6, rdx).Value

        '                    If .RowCount > 0 Then
        '                        'rindex = dgvItem.CurrentCell.RowIndex
        '                        rindex = dgvItem.RowCount - 1
        '                        Dim nrow As Integer = 0
        '                        Dim ccrow As Integer = 0
        '                        Dim krow As Integer = 0

        '                        'For j = 0 To .RowCount - 1
        '                        '    If .Item(10, j).Value = mycat Then
        '                        '        nrow = j
        '                        '        krow += 1
        '                        '    End If
        '                        'Next
        '                        nrow = .RowCount - 1
        '                        nrow += 1
        '                        If nrow <= 0 Then

        '                            If dgvItemList.Item(1, rdx).Value <> Nothing Then
        '                                If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
        '                                    MsgBox("Item already on the list!", 64, "Item added")
        '                                End If


        '                                .RowCount += 1
        '                                nn = .RowCount - 1
        '                                selrow = nn
        '                                nm = 1
        '                                .ClearSelection()
        '                                lastitemsel = dgvItemList.Item(1, rdx).Value
        '                                .Item(0, nn).Value = nm
        '                                .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value 'ITEM
        '                                'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
        '                                '    MsgBox("not equal1")
        '                                'End If
        '                                .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
        '                                .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
        '                                .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
        '                                .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
        '                                .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
        '                                .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
        '                                '  .Item(10, nn).Value = "Delete"
        '                                .CurrentCell = .Item(3, nn)
        '                                '.Item(3, nn).Selected = True
        '                                .BeginEdit(True)
        '                            End If
        '                        Else

        '                            If .Item(1, rindex).Value <> Nothing And .Item(3, rindex).Value <> 0 And _
        '                                .Item(8, rindex).Value <> Nothing Then

        '                                If dgvItemList.Item(1, rdx).Value <> Nothing Then
        '                                    If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
        '                                        MsgBox("Item already on the list!", 64, "Item added")
        '                                    End If
        '                                    .ClearSelection()
        '                                    lastitemsel = dgvItemList.Item(1, rdx).Value
        '                                    .Item(1, rindex).Value = dgvItemList.Item(1, rdx).Value 'ITEM
        '                                    If .Item(12, rindex).Value <> dgvItemList.Item(1, rdx).Value Then
        '                                        ReDim Preserve listupd(rwupd)
        '                                        listupd(rwupd).c1uitem = .Item(12, rindex).Value
        '                                        listupd(rwupd).c1upqty = .Item(3, rindex).Value
        '                                        listupd(rwupd).c1whse = cbxWarehouse.SelectedItem.value
        '                                        listupd(rwupd).c1upckg = .Item(5, rindex).Value
        '                                        listupd(rwupd).c1upkno = .Item(11, rindex).Value
        '                                        rwupd += 1
        '                                    End If
        '                                    .Item(2, rindex).Value = dgvItemList.Item(2, rdx).Value 'DESCRIPTION
        '                                    .Item(4, rindex).Value = dgvItemList.Item(9, rdx).Value 'QTY
        '                                    .Item(5, rindex).Value = dgvItemList.Item(10, rdx).Value 'UNIT
        '                                    .Item(6, rindex).Value = dgvItemList.Item(13, rdx).Value 'PCKG
        '                                    .Item(7, rindex).Value = dgvItemList.Item(14, rdx).Value  'GROSSCOST
        '                                    .Item(8, rindex).Value = dgvItemList.Item(15, rdx).Value 'NET-COST
        '                                    ' .Item(10, nn).Value = "Delete"
        '                                    .CurrentCell = .Item(3, rindex)
        '                                    '.item(3, nn).Selected = True
        '                                    .BeginEdit(True)
        '                                Else
        '                                    nrow += 1
        '                                    .RowCount += 1
        '                                    nn = .RowCount - 1

        '                                    nm = nrow
        '                                    selrow = nn
        '                                    If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
        '                                        MsgBox("Item already on the list!", 64, "Item added")
        '                                    End If
        '                                    .ClearSelection()
        '                                    lastitemsel = dgvItemList.Item(1, rdx).Value
        '                                    .Item(0, nn).Value = nm
        '                                    .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
        '                                    'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
        '                                    '    MsgBox("not equal2")
        '                                    'End If
        '                                    .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
        '                                    .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
        '                                    .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
        '                                    .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
        '                                    .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
        '                                    .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
        '                                    ' .Item(10, nn).Value = "Delete"
        '                                    .CurrentCell = .Item(3, nn)
        '                                    '.item(3, nn).Selected = True
        '                                    .BeginEdit(True)
        '                                End If

        '                            Else
        '                                nn = rindex
        '                                If dgvItemList.Item(1, rdx).Value <> Nothing Then
        '                                    If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
        '                                        MsgBox("Item already on the list!", 64, "Item added")
        '                                    End If
        '                                    nm = nn + 1
        '                                    selrow = nn
        '                                    .ClearSelection()
        '                                    lastitemsel = dgvItemList.Item(1, rdx).Value
        '                                    .Item(0, nn).Value = nm
        '                                    .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
        '                                    'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
        '                                    '    MsgBox("not equal3")
        '                                    'End If
        '                                    .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
        '                                    .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
        '                                    .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
        '                                    .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
        '                                    .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
        '                                    .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
        '                                    '  .Item(10, nn).Value = "Delete"
        '                                    .CurrentCell = .Item(3, nn)
        '                                    '.Item(3, nn).Selected = True
        '                                    .BeginEdit(True)
        '                                End If

        '                            End If
        '                        End If

        '                    Else

        '                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
        '                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
        '                                MsgBox("Item already on the list!", 64, "Item added")
        '                            End If
        '                            If rdx = 0 Then
        '                                If dgvItemList.Item(3, rdx).Value = Nothing Then
        '                                    Exit Sub
        '                                End If
        '                            Else
        '                                If dgvItemList.Item(3, rdx - 1).Value = Nothing Then
        '                                    Exit Sub
        '                                End If
        '                            End If

        '                            .RowCount += 1
        '                            nn = .RowCount - 1
        '                            selrow = nn
        '                            nm = 1
        '                            .ClearSelection()
        '                            lastitemsel = dgvItemList.Item(1, rdx).Value
        '                            .Item(0, nn).Value = nm
        '                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
        '                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
        '                            '    MsgBox("not equal4")
        '                            'End If
        '                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
        '                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
        '                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
        '                            .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
        '                            .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
        '                            .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
        '                            ' .Item(10, nn).Value = "Delete"
        '                            .CurrentCell = .Item(3, nn)
        '                            '.Item(3, nn).Selected = True
        '                            .BeginEdit(True)
        '                        End If

        '                    End If

        '                End With
        '            End If
        '        End With

        '        gbxItemList.Visible = False
        '        gbxItemList.SendToBack()
        '    End If
        'End With
    End Sub

    Private Sub dgvItemList_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles dgvItemList.CellContextMenuStripNeeded

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

    Private Sub tbInvoiceNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoiceNo.KeyPress
        If e.KeyChar = vbCr Then
            btnAdd_Click(sender, e)
        End If
    End Sub


    Private Sub tbInvoiceNo_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceNo.TextChanged
        'If checkrcvInvoiceNo() = True Then
        '    MsgBox("Invoice No. Already Used!.", vbCritical)
        '    Exit Sub
        'End If
    End Sub

    Private Sub NuPD1_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles NuPD1.ContextMenuStripChanged

    End Sub

    Private Sub NuPD1_KeyDown(sender As Object, e As KeyEventArgs) Handles NuPD1.KeyDown

    End Sub

    Private Sub NuPD1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuPD1.KeyPress

        Dim netTotal As Decimal = 0
        Dim disc1 As Decimal = 0
        Dim disc1Net As Decimal = 0

        txtDisc1.Text = NuPD1.Value
        disc1 = myd(txtGrossAmount.Text) * myd(NuPD1.Value / 100)
        txtDisc1.Text = Format(disc1, sFmat)
        disc1Net = myd(txtGrossAmount.Text) - myd(txtDisc1.Text)
        txtDisc1Net.Text = Format(disc1Net, sFmat)
        netTotal = myd(txtGrossAmount.Text) - myd(txtDisc1.Text) - myd(txtDisc2.Text) - myd(txtDisc3.Text)
        txtNetAmount.Text = Format(netTotal, sFmat)

    End Sub

    Private Sub NuPD1_Resize(sender As Object, e As EventArgs) Handles NuPD1.Resize

    End Sub

    Private Sub NuPD1_ValueChanged(sender As Object, e As EventArgs) Handles NuPD1.ValueChanged
        NuPD1_KeyPress(1, New KeyPressEventArgs(vbCr))
    End Sub

    Private Sub NuPD2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuPD2.KeyPress

        Dim disc2 As Decimal = 0
        Dim disc2Net As Decimal = 0
        Dim NetAmount As Decimal = 0
        Dim dsc2 As Decimal = 0

        If txtDisc2.Text <> "" Or txtDisc2.Text <> Nothing Then
            dsc2 = Decimal.Parse(txtDisc2.Text)
        End If

        txtDisc2Net.Text = (txtDisc1Net.Text - dsc2)
        disc2 = (myd(txtDisc1Net.Text) * (NuPD2.Value / 100))
        txtDisc2.Text = Format(disc2, sFmat)

        txtDisc3Net.Text = txtDisc2Net.Text
        'NetAmount = Decimal.Parse(tbGrossAmt.Text) - myd(tbDisc1.Text) - myd(tbDisc2.Text) - myd(tbDisc3.Text)
        'NetAmount = Format(CDbl(txtGrossAmount.Text) - myd(Val(txtDisc1.Text)) - myd(Val(txtDisc2.Text)) - myd(Val(txtDisc3.Text)), "#,##0.00")
        NetAmount = myd(txtGrossAmount.Text) - myd(txtDisc1.Text) - myd(txtDisc2.Text) - myd(txtDisc3.Text)
        'NetAmount = Format(CDbl(txtGrossAmount.Text) - myd(Val(txtDisc1.Text)) - myd(Val(txtDisc2.Text)), "#,##0.00")
        txtNetAmount.Text = Format(NetAmount, sFmat)

    End Sub

    Private Sub NuPD2_ValueChanged(sender As Object, e As EventArgs) Handles NuPD2.ValueChanged
        NuPD2_KeyPress(1, New KeyPressEventArgs(vbCr))
    End Sub

    Private Sub dgvItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvItem.KeyPress
        With dgvItem
            If .Rows.Count > 0 Then
                If Asc(e.KeyChar) = 13 Then
                    If .CurrentCell.ColumnIndex = 4 Then
                        .BeginEdit(True)
                        ' SendKeys.Send("{enter}")
                        .Focus()
                    End If
                    btnAdd.PerformClick()
                End If
            End If
        End With

        'If e.KeyChar = vbCr Then
        '    If dgvItem.CurrentCell.ColumnIndex = 1 Then
        '        dgvItem.CurrentCell = dgvItem.CurrentRow.Cells(3)

        '    ElseIf dgvItem.CurrentCell.ColumnIndex = 3 Then

        '    ElseIf dgvItem.CurrentCell.ColumnIndex = 4 Then
        '        ComputeRcvTotal()
        '        CalTotalQty()
        '    End If
        'End If

        'With dgvItem
        '    If .Rows.Count > 0 Then
        '        If Asc(e.KeyChar) = 13 Then
        '            If .CurrentCell.ColumnIndex = 5 Then
        '                btnAdd.PerformClick()
        '            End If

        '        End If
        '    End If
        'End With
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
        If cbxSupplier.Text = "" Then
            MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
            cbxSupplier.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.F3 Then
            btnSearchItem.PerformClick()

        End If
    End Sub

    Private Sub NuPD3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuPD3.KeyPress

        Dim disc3 As Decimal = 0
        Dim disc3Net As Decimal = 0
        Dim NetAmount As Decimal = 0

        disc3Net = (txtDisc2Net.Text - txtDisc2.Text)
        txtDisc3Net.Text = Format(disc3Net, sFmat)
        disc3 = (myd(txtDisc2Net.Text) * (NuPD3.Value / 100))
        txtDisc3.Text = Format(disc3, sFmat)

        'NetAmount = Decimal.Parse(tbGrossAmt.Text) - myd(tbDisc1.Text) - myd(tbDisc2.Text) - myd(tbDisc3.Text)
        'NetAmount = Decimal.Parse(Val(txtDisc2Net.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc3.Text))
        'NetAmount = Decimal.Parse(Val(txtDisc2Net.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc3.Text))
        NetAmount = myd(txtDisc3Net.Text) - myd(txtDisc3.Text)
        txtNetAmount.Text = Format(NetAmount, sFmat)

        'Dim netTotal As Decimal = 0
        'Dim disc2 As Decimal = 0
        'Dim disc3Net As Decimal = 0

        'txtDisc1.Text = NuPD1.Value
        'disc2 = myd(txtDisc2Net.Text) * myd(NuPD3.Value / 100)
        'txtDisc2.Text = Format(disc2, sFmat)
        'disc3Net = myd(txtGrossAmount.Text) - myd(txtDisc1.Text)
        'txtDisc1Net.Text = Format(disc1Net, sFmat)
        'netTotal = myd(txtGrossAmount.Text) - myd(txtDisc1.Text) - myd(txtDisc2.Text) - myd(txtDisc3.Text)
        'txtNetAmount.Text = Format(netTotal, sFmat)
    End Sub

    Private Sub NuPD3_ValueChanged(sender As Object, e As EventArgs) Handles NuPD3.ValueChanged
        NuPD3_KeyPress(1, New KeyPressEventArgs(vbCr))
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cbxSupplier.Text = "" Or cbxWarehouse.Text = "" Or txtInvoiceNo.Text = "" Then
            MsgBox("Check Missing Field", vbCritical)
            Exit Sub
        End If

        If checkrcvPOno() = True Then
            MsgBox("PO No. Already Used!", 48, "Enter PO. No.")
            txtPONo.Focus()
            Exit Sub
        End If

        If checkrcvInvoiceNo() = True Then
            MsgBox("Invoice No. Already Used!.", 48, "Enter Invoice No.")
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        With dgvItem
            DeleteBlankRow()
            If .RowCount > 0 Then
                Dim asave As Boolean = True

                For i = 0 To .Rows.Count - 1
                    If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                        asave = False
                    End If
                Next

                If asave = True Then

                    GetTransRcvNo()
                    rcvSave()
                    AuditTrail("Trans No.:" & Space(1) & txtTransNo.Text & Space(2) & "PO. No.:" & Space(1) & txtPONo.Text & Space(2) & "Invoice No.:" & Space(2) & txtInvoiceNo.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text, "Add Receiving")
                    MsgBox("Recieving has been save successfully", vbInformation)
                    ClearRcv()
                    'Me.Dispose()
                    With frmReceivingH
                        .LoadRcvh()
                    End With
                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If

            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With

        ' AuditTrail("Add Product " & txtID.Text & Space(2) & txtDescription.Text & Space(2) & txtPrice.Text & Space(2) & txtQty.Text, "Product Module")



    End Sub

    Sub LoadRcv()

    End Sub

    Sub ClearRcv()
        ' Dim listrmv() As rmvitem
        cbxSupplier.Text = Nothing
        txtSupplier.Text = ""
        cbxWarehouse.Text = Nothing
        txtWarehouse.Text = ""
        txtPONo.Text = ""
        ' tbUser.Text = ""
        txtTransNo.Text = ""
        txtInvoiceNo.Text = ""
        dgvItem.Rows.Clear()
        txtGrossAmount.Text = ""
        txtDisc1.Text = ""
        txtDisc2.Text = ""
        ' txtDisc3.Text = ""
        txtNetAmount.Text = ""
        NuPD1.Text = "0.00"
        NuPD2.Text = "0.00"
        '  NuPD3.Text = "0.00"

    End Sub


    Sub rcvSave()
        'save to rcvingh
        Dim cmd As MySqlCommand
        Dim i As Integer

        cmd = New MySqlCommand("INSERT INTO rcvingh (transno,tdate,invoiceno,whscode,pono,user,supcode," & _
                               "grossamt,disc1percent,disc1amount,disc2percent,disc2amount,disc3percent,disc3amount, " & _
                               "netamount) VALUES (@tno,@tdate,@invno,@whcode,@po,@user,@scode,@grsamt,@d1pct,@d1amt, " & _
                               "@d2pct,@d2amt,@d3pct,@d3amt,@namt)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
            cmd.Parameters.AddWithValue("@tdate", RcvDate.Value)
            cmd.Parameters.AddWithValue("@invno", txtInvoiceNo.Text)
            cmd.Parameters.AddWithValue("@whcode", cbxWarehouse.Text)
            ' cmd.Parameters.AddWithValue("@whname", tbWarehouse.Text)
            cmd.Parameters.AddWithValue("@po", txtPONo.Text)
            cmd.Parameters.AddWithValue("@user", txtUser.Text)
            cmd.Parameters.AddWithValue("@scode", cbxSupplier.Text)
            ' cmd.Parameters.AddWithValue("@sname", tbSupplier.Text)
            cmd.Parameters.AddWithValue("@grsamt", Decimal.Parse(txtGrossAmount.Text))
            cmd.Parameters.AddWithValue("@d1pct", NuPD1.Value)
            cmd.Parameters.AddWithValue("@d1amt", Decimal.Parse(txtDisc1.Text))
            cmd.Parameters.AddWithValue("@d2pct", NuPD2.Value)
            cmd.Parameters.AddWithValue("@d2amt", Decimal.Parse(txtDisc2.Text))
            cmd.Parameters.AddWithValue("@d3pct", NuPD3.Value)
            cmd.Parameters.AddWithValue("@d3amt", Decimal.Parse(txtDisc3.Text))
            cmd.Parameters.AddWithValue("@namt", Decimal.Parse(txtNetAmount.Text))
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'save to rcvingd
        With dgvItem

            For i = 0 To .RowCount - 1
                If .Item(3, i).Value <> Nothing Then
                    If .Item(3, i).Value > 0 Then
                        cmd = New MySqlCommand("INSERT INTO rcvingd (transno,tdate,whscode,itemcode,qty,qunit,pckg, " & _
                                                      "grossamt,netcost,costpc,amount,expdate) VALUES (@tno,@tdate,@whcode,@item," & _
                                                      "@qty,@qunit,@pckg,@grsamt,@ncost,@costpc,@amt,@expdate)", cdb)
                        cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
                        cmd.Parameters.AddWithValue("@tdate", RcvDate.Value)
                        ' cmd.Parameters.AddWithValue("@invno", tbInvoiceNo.Text)
                        cmd.Parameters.AddWithValue("@whcode", cbxWarehouse.Text)
                        ' cmd.Parameters.AddWithValue("@whname", tbWarehouse.Text)
                        cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                        ' cmd.Parameters.AddWithValue("@desc", .Item(2, i).Value)
                        cmd.Parameters.AddWithValue("@qty", .Item(3, i).Value)
                        cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                        cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                        cmd.Parameters.AddWithValue("@grsamt", Decimal.Parse(.Item(6, i).Value))
                        cmd.Parameters.AddWithValue("@ncost", Decimal.Parse(.Item(7, i).Value))
                        cmd.Parameters.AddWithValue("@costpc", Decimal.Parse(.Item(8, i).Value))
                        cmd.Parameters.AddWithValue("@amt", Decimal.Parse(.Item(9, i).Value))
                        Dim expdate As Date = .Item(14, i).Value
                        cmd.Parameters.AddWithValue("@expdate", Format(expdate, "yyyy-MM-dd"))

                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                End If
            Next
        End With

        'save to ivwh
        With dgvItem
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
                        cmd.Parameters.AddWithValue("@wh", cbxWarehouse.Text.Trim)
                        Using rd As MySqlDataReader = cmd.ExecuteReader
                            If rd.HasRows Then
                                fnds = True
                                rd.Read()
                                curqty = rd("qty_good").ToString
                            End If
                            rd.Close()
                        End Using
                        cmd.Dispose()

                        If fnds = False Then
                            cmd = New MySqlCommand("INSERT INTO ivwh (itemcode,whscode,qty_good) VALUES (@itm,@wh,@qtyg)", cdb)

                            cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@wh", cbxWarehouse.Text.Trim)
                            cmd.Parameters.AddWithValue("@qtyg", totalqty)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        Else
                            Dim nqty As Decimal = 0
                            nqty = totalqty + curqty
                            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
                            cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@wh", cbxWarehouse.Text.Trim)
                            cmd.Parameters.AddWithValue("@qtyg", nqty)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If


                    End If
                End If
            Next
        End With
    End Sub

    Private Sub tbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearchItem.KeyDown
        If e.KeyCode = Keys.Down Then
            dgvItemList.Focus()
        End If
    End Sub

    Private Sub tbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles tbSearchItem.TextChanged
        Try
            Dim i As Integer
            dgvItemList.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from ivitem where (itemcode like '%" & tbSearchItem.Text & "%' " & _
                                   " OR description like '%" & tbSearchItem.Text & "%') " & _
                                   " AND supcode=@spc and isdeleted<>1", cdb)
            cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
            End While
            rd.Close()
            '  cn.Close()
        Catch ex As Exception
            ' cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub RetrieveRcv(ByVal trno As String)

        tsSave.Visible = False
        tsUpdate.Visible = True

        With dgvItem
            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            .Rows.Clear()

            Dim checkopen As String()

            checkopen = check_if_trans_is_open(trno, "rcvingh", _user)

            If checkopen(0) = True Then
                MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before editing/updating this transaction. ", 48, "TRANSACTION IS OPEN")
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
            End If

            cmd = New MySqlCommand("SELECT h.*,s.suppliername,w.warehouse FROM rcvingh h " & _
                                   " LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                                   " LEFT JOIN warehouse w ON h.whscode=w.whscode WHERE transno=@tn", cdb)
            cmd.Parameters.AddWithValue("@tn", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    RcvDate.Value = rd("tdate").ToString
                    'MsgBox(setselindex(cbxSupplier, rd("supcode").ToString))
                    cbxSupplier.SelectedIndex = setselindex(cbxSupplier, rd("supcode").ToString)
                    txtSupplier.Text = rd("suppliername").ToString
                    cbxWarehouse.SelectedIndex = setselindex(cbxWarehouse, rd("whscode").ToString)
                    prevwhs = rd("whscode").ToString
                    txtWarehouse.Text = rd("warehouse").ToString
                    txtPONo.Text = rd("pono").ToString
                    txtUser.Text = rd("user").ToString
                    txtTransNo.Text = rd("transno").ToString
                    txtInvoiceNo.Text = rd("invoiceno").ToString
                    txtGrossAmount.Text = Format(Math.Round(Decimal.Parse(rd("grossamt").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                    If Not IsDBNull(rd("disc1percent").ToString) Then
                        NuPD1.Value = Format(Math.Round(Decimal.Parse(rd("disc1percent").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        NuPD1.Value = 0
                    End If
                    If Not IsDBNull(rd("disc1amount").ToString) Then
                        txtDisc1.Text = Format(Math.Round(Decimal.Parse(rd("disc1amount").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        txtDisc1.Text = 0
                    End If
                    If Not IsDBNull(rd("disc2percent").ToString) Then
                        NuPD2.Value = Format(Math.Round(Decimal.Parse(rd("disc2percent").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        NuPD2.Value = 0
                    End If
                    If Not IsDBNull(rd("disc2amount").ToString) Then
                        txtDisc2.Text = Format(Math.Round(Decimal.Parse(rd("disc2amount").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        txtDisc2.Text = 0
                    End If
                    If Not IsDBNull(rd("disc3percent").ToString) Then
                        NuPD3.Value = Format(Math.Round(Decimal.Parse(rd("disc3percent").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        NuPD3.Value = 0
                    End If
                    If Not IsDBNull(rd("disc3amount").ToString) Then
                        txtDisc3.Text = Format(Math.Round(Decimal.Parse(rd("disc3amount").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        txtDisc3.Text = 0
                    End If

                    txtNetAmount.Text = Format(Math.Round(Decimal.Parse(rd("netamount").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                End If
                rd.Close()
            End Using
            cmd.Dispose()

            ' For Each ct In itmcat

            cmd = New MySqlCommand("SELECT r.*,r.pkno as pno, t.description from rcvingd r " & _
                                   "LEFT JOIN ivitem t ON r.itemcode=t.itemcode " & _
                                   "WHERE transno=@tn AND r.isdeleted='0' Order by r.pkno Asc", cdb)
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

                        .Item(6, rw).Value = Format(Math.Round(Decimal.Parse(rd("grossamt").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")

                        .Item(7, rw).Value = Format(Math.Round(Decimal.Parse(rd("netcost").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(8, rw).Value = Format(Math.Round(Decimal.Parse(rd("costpc").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(9, rw).Value = Format(Math.Round(Decimal.Parse(rd("amount").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(11, rw).Value = rd("pno").ToString
                        .Item(11, rw).Tag = rd("pno").ToString
                        .Item(12, rw).Value = rd("itemcode").ToString
                        .Item(13, rw).Value = rd("whscode").ToString
                        .Item(14, rw).Value = rd("expdate").ToString

                        .Item(0, rw).ReadOnly = True
                        .Item(2, rw).ReadOnly = True
                        .Item(5, rw).ReadOnly = True
                        .Item(6, rw).ReadOnly = True
                        .Item(7, rw).ReadOnly = True
                        .Item(8, rw).ReadOnly = True
                        .Item(9, rw).ReadOnly = True

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
        prevwhs = cbxWarehouse.Text.Trim
        ' dgvItem.ReadOnly = True
    End Sub

    Private Sub tbPONo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPONo.KeyPress
        If e.KeyChar = vbCr Then
            txtInvoiceNo.Focus()
        End If
    End Sub

    Private Sub tbPONo_TextChanged(sender As Object, e As EventArgs) Handles txtPONo.TextChanged

        'If checkrcvPOno() = True Then
        '    MsgBox("PO No. Already Used!", 48, "Enter PO. No.")
        '    Exit Sub
        'End If

        'cmd = New MySqlCommand("SELECT pono FROM rcvingh WHERE pono=@pn", cdb)
        'cmd.Parameters.AddWithValue("@pn", tbPONo.Text.Trim)
        'Using rd As MySqlDataReader = cmd.ExecuteReader
        '    If rd.HasRows Then
        '        MsgBox("PO No. Already used!", vbCritical)
        '        Exit Sub
        '    End If
        'End Using

    End Sub

    Function checkrcvPOno()
        Dim fnd As Boolean = False
        If txtPONo.Text.Trim <> Nothing Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT pono FROM rcvingh WHERE pono = @pn", cdb)
            With cmd
                .Parameters.AddWithValue("@pn", txtPONo.Text.Trim)
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

    Function checkrcvInvoiceNo()
        Dim fnd As Boolean = False
        If txtInvoiceNo.Text.Trim <> Nothing Then
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT invoiceno FROM rcvingh WHERE invoiceno = @ivno", cdb)
            With cmd
                .Parameters.AddWithValue("@ivno", txtInvoiceNo.Text.Trim)
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


    Private Sub reset_listrmv()
        'Reset person count and array
        rwrmv = 0
        Erase listrmv
    End Sub
    Private Sub reset_listupd()
        rwupd = 0
        Erase listupd
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
                    .c1pkno = dgvItem.Item(11, dgvItem.CurrentRow.Index).Tag
                End With
                'cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' where transno=@tno AND item =@itemc", cdb)
                'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
                'cmd.Parameters.AddWithValue("@itemc", dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value)
                'cmd.ExecuteNonQuery()
                rwrmv += 1
                dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))

                ComputeRcvTotal()

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

    Private Sub reset_listadded()
        'Reset person count and array
        rwadded = 0
        rwsnews = 0
        Erase listrowsadded
        Erase listadded
    End Sub

    Sub UpdateRcv()

        'OLD PROCESS
        'update to rcvingh
        '  Dim delstat As Integer = 0
        Dim cmd As MySqlCommand
        Dim i As Integer


        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0
        Dim whsecode As String = Nothing

        whsecode = cbxWarehouse.Text.Trim
        ' MsgBox(prevwhse)
        'update edited item
        With dgvItem

            curqty = 0
            nwqty = 0
            Dim mkerr As Integer = 0
            Dim mkmsg As String = Nothing

            If mkerr = 0 Then

                cmd = New MySqlCommand("UPDATE rcvingh SET tdate=@tdate,invoiceno=@invno,whscode=@whcode,pono=@po, " & _
                              "user=@user,supcode=@scode,grossamt=@grsamt,disc1percent=@d1pct,disc1amount=@d1amt,disc2percent=@d2pct, " & _
                              "disc2amount=@d2amt,disc3percent=@d3pct,disc3amount=@d3amt,netamount=@namt WHERE transno=@tno", cdb)
                With cmd
                    cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
                    cmd.Parameters.AddWithValue("@tdate", RcvDate.Value)
                    cmd.Parameters.AddWithValue("@invno", txtInvoiceNo.Text)
                    cmd.Parameters.AddWithValue("@whcode", cbxWarehouse.Text)
                    ' cmd.Parameters.AddWithValue("@whname", tbWarehouse.Text)
                    cmd.Parameters.AddWithValue("@po", txtPONo.Text)
                    cmd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmd.Parameters.AddWithValue("@scode", cbxSupplier.Text)
                    'cmd.Parameters.AddWithValue("@sname", tbSupplier.Text)
                    cmd.Parameters.AddWithValue("@grsamt", Decimal.Parse(txtGrossAmount.Text))
                    cmd.Parameters.AddWithValue("@d1pct", NuPD1.Value)
                    cmd.Parameters.AddWithValue("@d1amt", Decimal.Parse(txtDisc1.Text))
                    cmd.Parameters.AddWithValue("@d2pct", NuPD2.Value)
                    cmd.Parameters.AddWithValue("@d2amt", Decimal.Parse(txtDisc2.Text))
                    cmd.Parameters.AddWithValue("@d3pct", NuPD3.Value)
                    cmd.Parameters.AddWithValue("@d3amt", Decimal.Parse(txtDisc3.Text))
                    cmd.Parameters.AddWithValue("@namt", Decimal.Parse(txtNetAmount.Text))
                End With
                cmd.ExecuteNonQuery()
                cmd.Dispose()

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

                    ' delstat = 1

                    'cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' WHERE transno=@tno AND item=@itemc", cdb) 'orig
                    cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc AND pkno=@pno", cdb) 'toping coy
                    cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
                    cmd.Parameters.AddWithValue("@itemc", rmvitc)
                    cmd.Parameters.AddWithValue("@pno", rmvpkno)
                    cmd.ExecuteNonQuery()

                    curqty = getcurqty(rmvitc, rmvwhse, "G")

                    'Dim totalqty As Integer = 0

                    'totalqty = convertpackaging_fromivitem(rmvitc, Nothing, rmvqty, rmvunit)
                    nwqty = curqty - rmvqty


                    cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@itm", rmvitc)
                    'cmd.Parameters.AddWithValue("@wh", .Item(13, i).Value)
                    cmd.Parameters.AddWithValue("@wh", rmvwhse)
                    cmd.Parameters.AddWithValue("@qtyg", nwqty)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Next

                Dim whsecode2 As String = Nothing
                whsecode2 = cbxWarehouse.Text.Trim
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
                            pkn = .Item(11, i).Value
                            newwqty = .Item(3, i).Value

                            'cmd = New MySqlCommand("SELECT item FROM salesd WHERE pkno=@pno and transno=@tno", cdb)
                            cmd = New MySqlCommand("SELECT itemcode FROM rcvingd WHERE pkno=@pno and transno=@tno and itemcode=@itm and isdeleted='0'", cdb)
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
                            old_item_unit = getolditemunit(itmc, pkn, "rcvingd")

                            unt = .Item(4, i).Value
                            nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)

                            '   old_item_unit = getolditemunit(old_item, pkn)

                            Dim markunitchange As Integer = 0


                            'UPDATE SALESD HERE

                            Dim pvwhs As String = Nothing
                            'Dim prevwhs As String = Nothing
                            
                            oqty = getoldqtyfrmtable(itmc, pkn, "rcvingd")
                            Dim added_status As Integer = 0
                            If .Item(1, i).Tag = "A" Then
                                added_status = 1
                            End If

                            If prevwhs <> whsecode2 Then 'Change warehouse

                                Dim opr As String = Nothing
                                opr = "-"
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
                                    return_diff_to_whs(itmc, old_item_qty, whsecode2, "-")
                                    'End If
                                    oqty = new_item_qty

                                End If
                            End If

                            If fnd1 = True Then
                                cmd = New MySqlCommand("UPDATE rcvingd SET tdate=@tdate,whscode=@whcode," & _
                                                   "qty=@qty,qunit=@qunit,pckg=@pckg,grossamt=@grsamt,netcost=@ncost, " & _
                                                   "costpc=@costpc,amount=@amt, itemcode=@itemc, expdate=@expdate WHERE pkno=@pno", cdb)
                                cmd.Parameters.AddWithValue("@tdate", RcvDate.Value)
                                cmd.Parameters.AddWithValue("@invno", txtInvoiceNo.Text)
                                cmd.Parameters.AddWithValue("@whcode", cbxWarehouse.Text)
                                cmd.Parameters.AddWithValue("@qty", Decimal.Parse(.Item(3, i).Value))
                                cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                                cmd.Parameters.AddWithValue("@grsamt", Decimal.Parse(.Item(6, i).Value))
                                cmd.Parameters.AddWithValue("@ncost", Decimal.Parse(.Item(7, i).Value))
                                cmd.Parameters.AddWithValue("@costpc", Decimal.Parse(.Item(8, i).Value))
                                cmd.Parameters.AddWithValue("@amt", Decimal.Parse(.Item(9, i).Value))
                                cmd.Parameters.AddWithValue("@itemc", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@pno", .Item(11, i).Value)

                                If .Item(14, i).Value <> Nothing Then
                                    Dim fromdt As Date
                                    fromdt = .Item(14, i).Value
                                    cmd.Parameters.AddWithValue("@expdate", fromdt.ToString("yyyy-MM-dd"))
                                Else
                                    cmd.Parameters.AddWithValue("@expdate", DBNull.Value)
                                End If

                                ' .Item(14, i).Value



                                'cmd.Parameters.AddWithValue("@expdate", Format(.Item(14, i).Value, "yyyy-MM-dd"))

                                'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text)

                                cmd.ExecuteNonQuery()
                                cmd.Dispose()

                                'If markunitchange = 1 Then
                                '    ' my_operator = Nothing
                                '    update_currentwhs_1stockin(itmc, oqty, nwq, prevwhs, whsecode, whsecode2, my_operator)
                                'Else
                                '    old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                'update_currentwhs22(itmc, old_item_qty, nwq, whsecode2, whsecode, pvwhs, my_operator)
                                'End If

                                If markunitchange = 1 Then

                                    'oqty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)

                                    update_currentwhs_1stockin(itmc, oqty, nwq, prevwhs, whsecode, whsecode2, my_operator)
                                Else

                                    Dim updatedqty As Decimal = 0

                                    updatedqty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    update_currentwhs_1stockin(itmc, updatedqty, nwq, prevwhs, whsecode, whsecode2, my_operator)
                                    'update_currentwhs22(itmc, old_item_qty, nwq, whsecode2, whsecode, pvwhs, my_operator)
                                End If

                            Else
                                cmd = New MySqlCommand("INSERT INTO rcvingd (transno,tdate,whscode,itemcode,qty,qunit,pckg, " & _
                                                                  "grossamt,netcost,costpc,amount,expdate) VALUES (@tno,@tdate,@whcode,@item, " & _
                                                                  "@qty,@qunit,@pckg,@grsamt,@ncost,@costpc,@amt,@expdate)", cdb)
                                cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
                                cmd.Parameters.AddWithValue("@tdate", RcvDate.Value)
                                cmd.Parameters.AddWithValue("@whcode", cbxWarehouse.Text)
                                cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@qty", .Item(3, i).Value)
                                cmd.Parameters.AddWithValue("@qunit", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                                cmd.Parameters.AddWithValue("@grsamt", Decimal.Parse(.Item(6, i).Value))
                                cmd.Parameters.AddWithValue("@ncost", Decimal.Parse(.Item(7, i).Value))
                                cmd.Parameters.AddWithValue("@costpc", Decimal.Parse(.Item(8, i).Value))
                                cmd.Parameters.AddWithValue("@amt", Decimal.Parse(.Item(9, i).Value))
                                'Dim expdate As Date = .Item(14, i).Value
                                'cmd.Parameters.AddWithValue("@expdate", Format(expdate, "yyyy-MM-dd"))
                                Dim fromdt As Date
                                fromdt = .Item(14, i).Value
                                Dim fdt = fromdt.ToString("yyyy-MM-dd")
                                cmd.Parameters.AddWithValue("@expdate", fdt)
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()
                                '  MsgBox(added_status)

                                nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                                '  If added_status = 0 Then
                                'old_item_qty = getcurqty(itmc, whsecode, "G")
                                'Else
                                old_item_qty = 0
                                'End If

                                update_currentwhs_stockin(itmc, old_item_qty, nwq, whsecode2, whsecode, nwq, my_operator)

                            End If

                    End If
                    End If
                Next
                prevwhs = whsecode2
                MsgBox("Recieving updated successfully.", vbInformation)
            Else
                MsgBox(mkmsg, 48, " Exceeded allowed quantity")
            End If

        End With


        reset_listrmv()
        reset_listupd()
        reset_listadded()
        prevwhs = whsecode
        editeditem = 0
        'END OLD PROCESS
        '==========================

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPONo.Text <> txtPOupdate.Text Then
            If checkrcvPOno() = True Then
                MsgBox("PO No. already used!.", 48, "Enter PO No.")
                txtPONo.Focus()
                Exit Sub
            End If
        End If

        If txtInvoiceNo.Text <> txtInvoiceNoupdate.Text Then
            If checkrcvInvoiceNo() = True Then
                MsgBox("Invoice No. already used!.", 48, "Enter Invoice No.")
                txtInvoiceNo.Focus()
                Exit Sub
            End If
        End If

        With dgvItem
            DeleteBlankRow()
            If cbxSupplier.Text <> Nothing And cbxWarehouse.Text <> Nothing Then
                If MsgBox("Update Changes? ", vbYesNo + vbQuestion) = vbYes Then
                    Dim asave As Boolean = True

                    'For i = 0 To .Rows.Count - 1
                    '    If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                    '        asave = False
                    '    End If
                    'Next

                    If asave = True Then
                        .EndEdit(True)
                        UpdateRcv()
                        'AuditTrail("Trans No.:" & txtTransNo.Text & Space(2) & "PO. No.:" & txtPONo.Text & Space(2) & "Invoice No.:" & txtInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Update Receiving")
                        AuditTrail("Trans No.:" & Space(1) & txtTransNo.Text & Space(2) & "PO. No.:" & Space(1) & txtPONo.Text & Space(2) & "Invoice No.:" & Space(2) & txtInvoiceNo.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text, "Update Receiving")

                        ClearRcv()
                        Me.Dispose()
                        With frmReceivingH
                            .LoadRcvh()
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

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If cbxSupplier.Text = "" Or cbxWarehouse.Text = "" Or txtInvoiceNo.Text = "" Then
            MsgBox("Check Missing Field", vbCritical)
            Exit Sub
        End If

        If checkrcvPOno() = True Then
            MsgBox("PO No. Already Used!", 48, "Enter PO. No.")
            txtPONo.Focus()
            Exit Sub
        End If

        If checkrcvInvoiceNo() = True Then
            MsgBox("Invoice No. Already Used!.", 48, "Enter Invoice No.")
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        With dgvItem
            DeleteBlankRow()
            If .RowCount > 0 Then
                Dim asave As Boolean = True

                For i = 0 To .Rows.Count - 1
                    If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                        asave = False
                    End If
                Next

                If asave = True Then
                    GetTransRcvNo()
                    rcvSave()
                    AuditTrail("Trans No.:" & txtTransNo.Text & Space(2) & "PO. No.:" & txtPONo.Text & Space(2) & "Invoice No.:" & txtInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Save&Print Receiving")
                    MsgBox("Recieving Has Been Save Successfully", vbInformation)
                    RcvPrint()
                    ClearRcv()
                    '  Me.Dispose()
                    With frmReceivingH
                        .LoadRcvh()
                    End With
                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If

            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With

    End Sub

    Sub RcvPrint()
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvItem
            mmax = .RowCount
            pbar1.Maximum = mmax



            dt.Rows.Clear()
            Dim chkflag As Boolean = False
            'grpno = 10
            grpno = 25
            Dim cntr As Integer = 0
            Dim grid As Integer = 1

            If .RowCount > 0 Then
                'pbar1.Visible = True
                'pbar1.Maximum = .RowCount
                'pbar1.Value = 0


                .EndEdit()
                '=====

                Dim prep As New ReportDocument
                Dim ds As New DataSet1
                Dim dt As DataTable = ds.Tables("rcvDataTable")
                Dim r1 As DataRow
                'Dim grpno As Integer = 1
                dt.Rows.Clear()
                'Dim chkflag As Boolean = False
                'grpno = 10
                grpno = 25
                'Dim cntr As Integer = 0
                'Dim grid As Integer = 1

                '=====

                For i = 0 To .RowCount - 1
                    'pbar1.Value += 1
                    'pbar1.Refresh()
                    ' r1 = dt.NewRow()
                    pbar1.Value += 1
                    cntr += 1
                    r1 = dt.NewRow()

                    r1("dates") = RcvDate.Value.ToString("MM/dd/yyyy")
                    'r1("supplier") = cbxSupplier.Text.ToString
                    r1("supplier") = txtSupplier.Text.ToString
                    'r1("warehouse") = cbxWarehouse.Text.ToString
                    r1("warehouse") = txtWarehouse.Text.ToString
                    r1("pono") = txtPONo.Text.ToString
                    r1("user") = txtUser.Text.ToString
                    r1("transno") = txtTransNo.Text.ToString
                    r1("invoiceno") = txtInvoiceNo.Text.ToString

                    r1("grossamt") = txtGrossAmount.Text.ToString
                    r1("disc1") = txtDisc1.Text.ToString
                    r1("disc2") = txtDisc2.Text.ToString
                    r1("disc3") = txtDisc3.Text.ToString

                    r1("nudisc1") = NuPD1.Value
                    r1("nudisc2") = NuPD2.Value
                    r1("nudisc3") = NuPD3.Value
                    r1("netamount") = txtNetAmount.Text.ToString

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
                    r1("groscost") = IIf(.Item(6, i).Value = Nothing, DBNull.Value, .Item(6, i).Value)
                    r1("netcost") = IIf(.Item(7, i).Value = Nothing, DBNull.Value, .Item(7, i).Value)
                    r1("costpc") = IIf(.Item(8, i).Value = Nothing, DBNull.Value, .Item(8, i).Value)
                    r1("amount") = IIf(.Item(9, i).Value = Nothing, DBNull.Value, .Item(9, i).Value)
                    r1("grpno") = grid
                    r1("qtyc") = Format(CDbl(lblCase.Text), "#,##0")
                    r1("qtyb") = Format(CDbl(lblBag.Text), "#,##0")
                    r1("qtyp") = Format(CDbl(lblPc.Text), "#,##0")

                    pbar1.Refresh()
                    dt.Rows.Add(r1)
                    ' pbar1.Refresh()

                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next


                'pbar1.Visible = False
                prep = New rcvReport
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
                        ComputeRcvTotal()
                    Else
                        .Item(4, mrw).Value = "C"
                        mpc = .Item(4, mrw).Value
                        .BeginEdit(True)
                        ComputeRcvTotal()
                    End If

                    getpackprice(itemno, mpc, mrw)

                    If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = "P"
                        mpc = .Item(4, mrw).Value
                        ComputeRcvTotal()
                    End If




                    ComputeRcvTotal()
                ElseIf .CurrentCell.ColumnIndex = 1 And e.KeyCode = Keys.F3 Then
                    btnSearchItem.PerformClick()
                End If
            End If
        End With
    End Sub

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

        If txtInvoiceNo.Text = "" Then
            MsgBox("Please Enter Invoice No!", MsgBoxStyle.Critical)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        If cbxSupplier.Text = "" Then
            MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
            cbxSupplier.Focus()
            Exit Sub
        End If

        If cbxWarehouse.Text = "" Then
            MsgBox("Pls. Enter Warehouse!", MsgBoxStyle.Information)
            cbxWarehouse.Focus()
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
                        .Rows(r).Cells(0).Value = r + 1
                        .Rows(r).Cells(1).Tag = "A"
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
                .Rows(r).Cells(0).Value = r + 1
                .Rows(r).Cells(1).Tag = "A"
                .CurrentCell = .Rows(r).Cells(1)
                .BeginEdit(True)
            End If
            ' dgvRcvItem.Focus()
            ' dgvRcvItem.CurrentCell = dgvRcvItem.CurrentRow.Cells(1)
        End With


    End Sub

    Private Sub tbSupCode_KeyPress(sender As Object, e As KeyPressEventArgs)
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtSupplier.Text = rd.Item("suppliername").ToString
            End With
        End If
        rd.Close()
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
        ' End With
    End Sub

    'Private Sub cbx_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    With dgvItem
    '        If .Item(3, selrow).Value <> 0 Then
    '            .ClearSelection()
    '            Dim method As New SetColumnIndex(AddressOf Mymethod)
    '            Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
    '            Me.dgvItem.BeginInvoke(method, nextindex)
    '        End If

    '    End With

    'End Sub



    Private Sub btnUpdatePrint_Click(sender As Object, e As EventArgs) Handles btnUpdatePrint.Click
        With dgvItem
            DeleteBlankRow()

            If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
                Dim asave As Boolean = True

                For i = 0 To .Rows.Count - 1
                    If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                        asave = False
                    End If
                Next

                If asave = True Then
                    UpdateRcv()
                    'AuditTrail("Trans No.:" & txtTransNo.Text & Space(2) & "PO. No.:" & txtPONo.Text & Space(2) & "Invoice No.:" & txtInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Receiving Update")
                    AuditTrail("Trans No.:" & Space(1) & txtTransNo.Text & Space(2) & "PO. No.:" & Space(1) & txtPONo.Text & Space(2) & "Invoice No.:" & Space(2) & txtInvoiceNo.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text, "Update&Print Receiving")
                    MsgBox("Recieving Updated Successfully.", vbInformation)
                    RcvPrint()
                    ' ClearRcv()
                    frmReport.BringToFront()
                    With frmReceivingH
                        .LoadRcvh()
                    End With
                Else
                    MsgBox("Please input a valid quantity,item/s first", 48, "Invalid quantity,item/s found")
                End If

            End If
        End With

    End Sub

    Private Sub cbxSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSupplier.KeyPress
        If e.KeyChar = vbCr Then
            cbxWarehouse.Focus()
        End If
    End Sub

    Private Sub cbxSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxSupplier.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "'", cdb)
        Using rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                txtSupplier.Text = rd.Item("suppliername").ToString
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub cbxWarehouse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxWarehouse.KeyPress
        If e.KeyChar = vbCr Then
            txtPONo.Focus()
        End If
    End Sub

    Private Sub cbxWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxWarehouse.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cbxWarehouse.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtWarehouse.Text = rd.Item("warehouse").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to Quit?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
        End If
    End Sub


    Private Sub btnCloseR_Click(sender As Object, e As EventArgs) Handles btnCloseR.Click

        If MsgBox("Are you sure you want to Quit?", vbYesNo + vbQuestion, "Receiving Entry") = vbYes Then
            Me.Dispose()
        End If


    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'tsRcvdUpdate.Items(0).Enabled = True
        'tsRcvdUpdate.Items(1).Enabled = True
        'tsRcvdUpdate.Items(2).Enabled = True
        'tsRcvdUpdate.Items(3).Enabled = False
        btnPrint.Enabled = False
        RcvEnabled()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'MsgBox("Recieving Updated Successfully.", vbInformation)
        AuditTrail("Trans No.:" & Space(1) & txtTransNo.Text & Space(2) & "PO. No.:" & Space(1) & txtPONo.Text & Space(2) & "Invoice No.:" & Space(2) & txtInvoiceNo.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text, "Print Receiving")
        RcvPrint()
        ' ClearRcv()
        'Me.Dispose()
    End Sub

    Private Sub btnSearchItem_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click

        btnAdd.PerformClick()

        If cbxSupplier.Text = "" Then
            MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
            cbxSupplier.Focus()
            Exit Sub
        End If

        With dgvItem
            .Focus()
            If .Rows.Count > 0 Then
                Dim r As Integer = 0

                r = .Rows.Count - 1

                If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing _
                    And .Rows(r).Cells(7).Value <> Nothing Then
                    gbxItemList.BringToFront()
                    gbxItemList.Visible = True
                    tbSearchItem.Focus()
                    LoadItemList()
                Else
                    LoadItemList()
                    gbxItemList.BringToFront()
                    gbxItemList.Visible = True
                    'MsgBox("Please provide proper item/s and quantity first", 48, "Invalid entry found")
                End If
            Else
                gbxItemList.Visible = True
                gbxItemList.BringToFront()
                .Focus()
                LoadItemList()
            End If

            dgvItemList.Focus()
        End With
    End Sub

    Private Sub tsRcvdUpdate_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsUpdate.ItemClicked

    End Sub

    Private Sub RcvDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RcvDate.KeyPress
        If e.KeyChar = vbCr Then
            cbxSupplier.Focus()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If MsgBox("Remove this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then
            'ReDim Preserve listrmv(rwrmv)
            'With listrmv(rwrmv)
            '    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
            '    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Value
            '    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
            '    .c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
            '    .c1pkno = dgvItem.Item(11, dgvItem.CurrentRow.Index).Value 'toping coy
            'End With
           
            'cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' where transno=@tno AND item =@itemc", cdb)
            'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
            'cmd.Parameters.AddWithValue("@itemc", dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value)
            'cmd.ExecuteNonQuery()
            If Me.Tag = 1 Then
                ReDim Preserve listrmv(rwrmv)
                With listrmv(rwrmv)


                    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                    .c1qty = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
                    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
                    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Tag
                    '.c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                    .c1pkno = dgvItem.Item(11, dgvItem.CurrentRow.Index).Tag
                    .c1whs = dgvItem.Item(13, dgvItem.CurrentRow.Index).Value
                End With
                rwrmv += 1
            End If

            dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))
            ComputeRcvTotal()
            CalTotalQty()
        End If

    End Sub

    Private Sub btnCloseD_Click(sender As Object, e As EventArgs) Handles btnCloseD.Click
        If gbxItemList.Visible = True Then
            MsgBox("Close Search Item first before closing.", vbExclamation, "SIMS")
            Exit Sub
        Else
            'If rwrmv > 0 Or rwupd > 0 Then
            If dgvItem.RowCount > 0 Then
                If MsgBox("Are you sure you want to Discard Changes?", vbYesNo + vbQuestion, "Receiving Entry") = vbYes Then
                    Dim trno As String = Nothing

                    trno = txtTransNo.Text.Trim()
                    close_open_trans_by_user(trno, "rcvingh", _user)
                    Me.Dispose()

                End If
            Else
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub DateTimePickerChange(ByVal sender As Object, ByVal e As EventArgs)
        dgvItem.CurrentCell.Value = dtpicker1.Text.ToString()
        ' MessageBox.Show(String.Format("Date changed to {0}", dtpicker1.Text.ToString()))
    End Sub

    Private Sub DateTimePickerClose(ByVal sender As Object, ByVal e As EventArgs)
        dtpicker1.Visible = False
    End Sub
End Class
