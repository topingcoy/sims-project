Imports MySql.Data.MySqlClient

Public Class frmItemH

    Private Sub frmItemH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            If txtItemcode.Text <> Nothing Then
                'If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Item Maintenance") = vbYes Then
                btnClose.PerformClick()
                'Me.Dispose()
                'ElseIf txtItemcode.Text = Nothing Then
                '    Me.Dispose()
            Else
                'Return
                btnClose.PerformClick()
            End If
        End If
        'End If
    End Sub

    Private Sub frmItemH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplier()
        LoadSupplierFilter()
        LoadCategory()
        ' LoadBrand()
        'LoadItems()
        FilterbySupplier()
        chkObsolet.Checked = False
        btnUpdate.Enabled = False
        btnChangeItemCode.Enabled = False
        txtChangeItemCode.Enabled = False
        dgvItemList.Focus()
        ' LoadSuppllierToGbox()
    End Sub

    Sub LoadSupplierFilter()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxFilterSupplier.Items.Clear()
        cbxFilterSupplier.DisplayMember = "text"
        qry = "Select * from supplier ORDER BY suppliername"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            'cbSupplierFilter.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("suppliername").ToString()})
            cbxFilterSupplier.Items.Add(New With {.Text = relr("suppliername").ToString(), .Value = relr("supcode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub ComputeBag()
        ' Dim nPBag As Decimal

        If (Me.txtItemcode.Text <> Nothing) Then
            If ((Decimal.Compare(Me.nupPcsCase.Value, Me.nuPcBag.Value) = 0 AndAlso ((Decimal.Compare(Me.nuPcBag.Value, Decimal.One) <> 0) And (Decimal.Compare(Me.nupPcsCase.Value, Decimal.One) <> 0)))) Then
                MsgBox("Value per case should not be the same as value per bag!", MsgBoxStyle.Critical)
                Me.nuPcBag.Value = Decimal.One
                Me.nuPcBag.Focus()
            ElseIf ((Decimal.Compare(Me.nuPcBag.Value, Decimal.Zero) > 0) AndAlso (Decimal.Compare(Decimal.Remainder(Me.nupPcsCase.Value, Me.nuPcBag.Value), Decimal.Zero) > 0)) Then
                MsgBox("Pieces per bag is invalid!", MsgBoxStyle.Critical, Nothing)
                '   Me.nuPcBag.Value = New Decimal(If((Me.nPBag = 0), 1, Me.nPBag))
                Me.nuPcBag.Focus()
            End If
        End If

        'If ((Decimal.Compare(Me.nudPCase.Value, Me.nudPBag.Value) = 0) AndAlso ((Decimal.Compare(Me.nudPBag.Value, Decimal.One) <> 0) And (Decimal.Compare(Me.nudPCase.Value, Decimal.One) <> 0))) Then
        '    Interaction.MsgBox("Value per case should not be the same as value per bag!", MsgBoxStyle.Critical, Nothing)
        '    Me.nudPBag.Value = Decimal.One
        '    Me.nudPBag.Focus()
        'ElseIf ((Decimal.Compare(Me.nudPBag.Value, Decimal.Zero) > 0) AndAlso (Decimal.Compare(Decimal.Remainder(Me.nudPCase.Value, Me.nudPBag.Value), Decimal.Zero) > 0)) Then
        '    Interaction.MsgBox("Pieces per bag is invalid!", MsgBoxStyle.Critical, Nothing)
        '    Me.nudPBag.Value = New Decimal(If((Me.nPBag = 0), 1, Me.nPBag))
        '    Me.nudPBag.Focus()
        'End If

    End Sub

    Sub LoadSuppllierToGbox()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxSupplier.Items.Clear()
        cbxSupplier.DisplayMember = "text"
        qry = "Select * from supplier ORDER BY suppliername"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxSupplier.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("suppliername").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadCategoryToGbx()

    End Sub

    Sub LoadBrandToGbx()

    End Sub

    Sub LoadItems()
        dgvItemList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND isdeleted='0' ORDER BY description asc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, Format(CDbl(rd.Item("grscost").ToString), "#,##0.00"), Format(CDbl(rd.Item("netcost").ToString), "#,##0.00"), Format(CDbl(rd.Item("costpc").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, rd.Item("discpct").ToString, rd.Item("wtkg").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub dgvItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        With dgvItemList
            txtItemcode.Text = dgvItemList.Rows(e.RowIndex).Cells(1).Value.ToString
            txtDescription.Text = dgvItemList.Rows(e.RowIndex).Cells(2).Value.ToString
            cbxSupplier.Text = dgvItemList.Rows(e.RowIndex).Cells(3).Value.ToString
            txtSupname.Text = dgvItemList.Rows(e.RowIndex).Cells(4).Value.ToString
            cbxCategory.Text = dgvItemList.Rows(e.RowIndex).Cells(5).Value.ToString
            txtCatname.Text = dgvItemList.Rows(e.RowIndex).Cells(6).Value.ToString
            cbxBrand.Text = dgvItemList.Rows(e.RowIndex).Cells(7).Value.ToString
            txtBrandname.Text = dgvItemList.Rows(e.RowIndex).Cells(8).Value.ToString
            cbxUnit.Text = dgvItemList.Rows(e.RowIndex).Cells(9).Value.ToString
            nupPcsCase.Value = dgvItemList.Rows(e.RowIndex).Cells(10).Value.ToString
            nuPcBag.Value = dgvItemList.Rows(e.RowIndex).Cells(11).Value.ToString
            cbxFree.Text = dgvItemList.Rows(e.RowIndex).Cells(12).Value.ToString
            txtGross.Text = dgvItemList.Rows(e.RowIndex).Cells(13).Value.ToString
            txtNetdisc.Text = dgvItemList.Rows(e.RowIndex).Cells(14).Value.ToString
            txtCostpc.Text = dgvItemList.Rows(e.RowIndex).Cells(15).Value.ToString
            txtPriceCaseA.Text = dgvItemList.Rows(e.RowIndex).Cells(16).Value.ToString
            txtPriceBagA.Text = dgvItemList.Rows(e.RowIndex).Cells(17).Value.ToString
            txtPricePcA.Text = dgvItemList.Rows(e.RowIndex).Cells(18).Value.ToString
            txtPriceCaseB.Text = dgvItemList.Rows(e.RowIndex).Cells(19).Value.ToString
            txtPriceBagB.Text = dgvItemList.Rows(e.RowIndex).Cells(20).Value.ToString
            txtPricePcB.Text = dgvItemList.Rows(e.RowIndex).Cells(21).Value.ToString
            txtPriceCaseC.Text = dgvItemList.Rows(e.RowIndex).Cells(22).Value.ToString
            txtPriceBagC.Text = dgvItemList.Rows(e.RowIndex).Cells(23).Value.ToString
            txtPricePcC.Text = dgvItemList.Rows(e.RowIndex).Cells(24).Value.ToString

            txtPriceCaseD.Text = dgvItemList.Rows(e.RowIndex).Cells(25).Value.ToString
            txtPriceBagD.Text = dgvItemList.Rows(e.RowIndex).Cells(26).Value.ToString
            txtPricePcD.Text = dgvItemList.Rows(e.RowIndex).Cells(27).Value.ToString

            txtPriceCaseE.Text = dgvItemList.Rows(e.RowIndex).Cells(28).Value.ToString
            txtPriceBagE.Text = dgvItemList.Rows(e.RowIndex).Cells(29).Value.ToString
            txtPricePcE.Text = dgvItemList.Rows(e.RowIndex).Cells(30).Value.ToString

            cbxObsolet.Text = dgvItemList.Rows(e.RowIndex).Cells(31).Value.ToString
            nuItemDisc.Value = dgvItemList.Rows(e.RowIndex).Cells(32).Value.ToString
            nuWgkg.Value = dgvItemList.Rows(e.RowIndex).Cells(33).Value.ToString
            lblpk.Text = dgvItemList.Rows(e.RowIndex).Cells(34).Value.ToString

            btnSave.Enabled = False
            btnUpdate.Enabled = True
            btnClear.Enabled = False
            btnChangeItemCode.Enabled = True
            txtItemcode.Enabled = False
            txtChangeItemCode.Enabled = False
            'txtItemcode.Focus()
            .Focus()
        End With
    End Sub



    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick
        'Dim colName As String = dgvItemList.Columns(e.ColumnIndex).Name
        'If colName = "Edit" Then
        '    With frmItemD
        '        .tbItemCode.Text = dgvItemList.Rows(e.RowIndex).Cells(1).Value.ToString
        '        .tbItemDescription.Text = dgvItemList.Rows(e.RowIndex).Cells(2).Value.ToString
        '        .cbxSupplier.Text = dgvItemList.Rows(e.RowIndex).Cells(3).Value.ToString
        '        .lblSupplier.Text = dgvItemList.Rows(e.RowIndex).Cells(4).Value.ToString
        '        .cbxCategory.Text = dgvItemList.Rows(e.RowIndex).Cells(5).Value.ToString
        '        .lblCategory.Text = dgvItemList.Rows(e.RowIndex).Cells(6).Value.ToString
        '        .cbxBrand.Text = dgvItemList.Rows(e.RowIndex).Cells(7).Value.ToString
        '        .lblBrand.Text = dgvItemList.Rows(e.RowIndex).Cells(8).Value.ToString
        '        .cbxUnit.Text = dgvItemList.Rows(e.RowIndex).Cells(9).Value.ToString
        '        .nupPcsCase.Value = dgvItemList.Rows(e.RowIndex).Cells(10).Value.ToString
        '        .nuPcBag.Value = dgvItemList.Rows(e.RowIndex).Cells(11).Value.ToString
        '        .cbxFree.Text = dgvItemList.Rows(e.RowIndex).Cells(12).Value.ToString
        '        .tbGross.Text = dgvItemList.Rows(e.RowIndex).Cells(13).Value.ToString
        '        .tbNetDisc.Text = dgvItemList.Rows(e.RowIndex).Cells(14).Value.ToString
        '        .tbCostPc.Text = dgvItemList.Rows(e.RowIndex).Cells(15).Value.ToString
        '        .tbPriceCaseA.Text = dgvItemList.Rows(e.RowIndex).Cells(16).Value.ToString
        '        .tbPriceBagA.Text = dgvItemList.Rows(e.RowIndex).Cells(17).Value.ToString
        '        .tbPricePcA.Text = dgvItemList.Rows(e.RowIndex).Cells(18).Value.ToString
        '        .tbPriceCaseB.Text = dgvItemList.Rows(e.RowIndex).Cells(19).Value.ToString
        '        .tbPriceBagB.Text = dgvItemList.Rows(e.RowIndex).Cells(20).Value.ToString
        '        .tbPricePcB.Text = dgvItemList.Rows(e.RowIndex).Cells(21).Value.ToString
        '        .tbPriceCaseC.Text = dgvItemList.Rows(e.RowIndex).Cells(22).Value.ToString
        '        .tbPriceBagC.Text = dgvItemList.Rows(e.RowIndex).Cells(23).Value.ToString
        '        .tbPricePcC.Text = dgvItemList.Rows(e.RowIndex).Cells(24).Value.ToString
        '        .cbxObsolet.Text = dgvItemList.Rows(e.RowIndex).Cells(25).Value.ToString
        '        .lblpk.Text = dgvItemList.Rows(e.RowIndex).Cells(27).Value.ToString
        '        .nuItemDisc.Value = dgvItemList.Rows(e.RowIndex).Cells(26).Value.ToString

        '        '.enableitem()
        '        .SaveItem.Enabled = False
        '        .UpdateItem.Enabled = True
        '        .ClearItem.Enabled = False
        '        .tbItemCode.Enabled = False
        '        '.tbItemCode.Focus()
        '        .ShowDialog()
        '    End With

        'ElseIf colName = "Delete" Then
        '    If MsgBox("Delete this Item? Click Yes to Confirm", vbYesNo + vbQuestion) = vbYes Then
        '        cmd = New MySqlCommand("DELETE FROM ivitem where itemcode like '" & dgvItemList.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cdb)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Item has been Successfully Deleted!", vbInformation)
        '        LoadItems()
        '    End If
        'End If

    End Sub

    Private Sub gbxGroupBy_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbSeachItem_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        dgvItemList.Rows.Clear()
        cmd = New MySqlCommand("SELECT * FROM ivitem where (description like '%" & txtSearch.Text & "%' or itemcode like '%" & txtSearch.Text & "%') AND obsolet <> 'Y' AND isdeleted='0' order by supplier asc", cdb)

        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                 rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                 rd.Item("freeitem").ToString, Format(CDbl(rd.Item("grscost").ToString), "#,##0.00"), Format(CDbl(rd.Item("netcost").ToString), "#,##0.00"), Format(CDbl(rd.Item("costpc").ToString), "#,##0.00"), _
                                 Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                 Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                 Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                 Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                 Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                 rd.Item("obsolet").ToString, rd.Item("discpct").ToString, rd.Item("wtkg").ToString, rd.Item("pkno").ToString, "Edit", "Delete")

            'dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
            '                      rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
            '                      rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
            '                      Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
            '                      Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
            '                      Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
            '                      rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("wtkg").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Sub DisableItems()
        txtItemcode.Enabled = False
        txtDescription.Enabled = False
        cbxSupplier.Enabled = False
        cbxCategory.Enabled = False
        cbxBrand.Enabled = False
        cbxUnit.Enabled = False
        nupPcsCase.Enabled = False
        nuPcBag.Enabled = False
        cbxFree.Enabled = False
        txtGross.Enabled = False
        txtNetdisc.Enabled = False
        txtCostpc.Enabled = False
        txtPriceCaseA.Enabled = False
        txtPriceBagA.Enabled = False
        txtPricePcA.Enabled = False
        txtPriceCaseB.Enabled = False
        txtPriceBagB.Enabled = False
        txtPricePcB.Enabled = False
        txtPriceCaseC.Enabled = False
        txtPriceBagC.Enabled = False
        txtPricePcC.Enabled = False

        txtPriceCaseD.Enabled = False
        txtPriceBagD.Enabled = False
        txtPricePcD.Enabled = False

        txtPriceCaseE.Enabled = False
        txtPriceBagE.Enabled = False
        txtPricePcE.Enabled = False

        cbxObsolet.Enabled = False
        nuItemDisc.Enabled = False
    End Sub

    Sub enableitem()
        txtItemcode.Enabled = True
        txtDescription.Enabled = True
        cbxSupplier.Enabled = True
        cbxCategory.Enabled = True
        cbxBrand.Enabled = True
        cbxUnit.Enabled = True
        nupPcsCase.Enabled = True
        nuPcBag.Enabled = True
        cbxFree.Enabled = True
        txtGross.Enabled = True
        txtNetdisc.Enabled = True
        txtCostpc.Enabled = True
        txtPriceCaseA.Enabled = True
        txtPriceBagA.Enabled = True
        txtPricePcA.Enabled = True
        txtPriceCaseB.Enabled = True
        txtPriceBagB.Enabled = True
        txtPricePcB.Enabled = True
        txtPriceCaseC.Enabled = True
        txtPriceBagC.Enabled = True
        txtPricePcC.Enabled = True

        txtPriceCaseD.Enabled = True
        txtPriceBagD.Enabled = True
        txtPricePcD.Enabled = True

        txtPriceCaseE.Enabled = True
        txtPriceBagE.Enabled = True
        txtPricePcE.Enabled = True

        cbxObsolet.Enabled = True
        nuItemDisc.Enabled = True
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
            cbxSupplier.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("suppliername").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadCategory()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxCategory.Items.Clear()
        cbxCategory.DisplayMember = "text"
        qry = "Select * from category ORDER BY categoryname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxCategory.Items.Add(New With {.Text = relr("catcode").ToString(), .Value = relr("categoryname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadBrand()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxBrand.Items.Clear()
        cbxBrand.DisplayMember = "text"
        qry = "Select * from brand ORDER BY brandname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxBrand.Items.Add(New With {.Text = relr("brcode").ToString(), .Value = relr("brandname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub nupcase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nupPcsCase.KeyPress
        If e.KeyChar = vbCr Then
            btnCalcCostPc.PerformClick()
            btnCalcPriceA.PerformClick()
            btnCalcPriceB.PerformClick()
            btnCalcPriceC.PerformClick()
            btnCalcPriceD.PerformClick()
            btnCalcPriceE.PerformClick()
            nuPcBag.Focus()
        End If
    End Sub

    Private Sub nupbag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nuPcBag.KeyPress
        If e.KeyChar = vbCr Then
            btnCalcCostPc.PerformClick()
            btnCalcPriceA.PerformClick()
            btnCalcPriceB.PerformClick()
            btnCalcPriceC.PerformClick()
            btnCalcPriceD.PerformClick()
            btnCalcPriceE.PerformClick()
            txtGross.Focus()
        End If
    End Sub

    Private Sub tbGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGross.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim GrossCost As Decimal = 0
        If e.KeyChar = vbCr Then
            GrossCost = myd(txtGross.Text)
            txtGross.Text = Format(GrossCost, sFmat)
            myd(Format(txtGross.Text, sFmat) = Format(GrossCost, sFmat))
            txtNetdisc.Focus()
        End If
    End Sub

    Private Sub tbItemCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemcode.KeyPress
        If e.KeyChar = vbCr Then
            txtDescription.Focus()
        End If
    End Sub

    Private Sub SaveItem_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtItemcode.Text = Nothing Or txtDescription.Text = Nothing Or cbxSupplier.Text = Nothing Or cbxCategory.Text = Nothing Or cbxUnit.Text = Nothing Then 'Or cbxBrand.Text = Nothing
            MsgBox("Pls Check Missing Filed!", vbExclamation)
            Exit Sub
        End If

        If nupPcsCase.Value = "0" Or nuPcBag.Value = "0" Then
            MsgBox("Pcs Per Case Shoulbe not be Zero!", vbExclamation)
            Exit Sub
        End If

        If isExistItemCode(txtItemcode.Text.Trim) Then
            MsgBox("Item Code Already Used!", vbCritical)
            Exit Sub
        End If

        cmd = New MySqlCommand("SELECT description FROM ivitem WHERE description=@desc", cdb)
        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Item Description Already Used!", vbCritical)
                Exit Sub
            End If
        End Using

        If MsgBox("Save  this Item?", vbYesNo + vbQuestion) = vbYes Then
            SaveItems()
        End If
        AuditTrail("Code.:" & Space(1) & txtItemcode.Text & Space(2) & "Description:" & Space(1) & txtDescription.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text & Space(2) & "Category:" & Space(1) & cbxCategory.Text, "Add New Item")
        MsgBox("New item has been save sucessfully!", vbInformation)
        If cbxFilterSupplier.Text <> Nothing Then
            FilterbySupplier()
            ItemClears()
            btnRefresh.PerformClick()
        Else
            btnRefresh.PerformClick()
            'LoadItems()
            'ItemClears()
        End If
        'LoadItems()
        'ItemClears()
    End Sub

    Sub CheckItem()
        cmd = New MySqlCommand("SELECT itemcode FROM ivitem WHERE itemcode=@itm", cdb)
        cmd.Parameters.AddWithValue("@itm", txtItemcode.Text.Trim)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Item Code Already Used!", vbCritical)
                Exit Sub
            End If
        End Using
    End Sub

    Sub CheckDescription()
        cmd = New MySqlCommand("SELECT description FROM ivitem WHERE description=@desc", cdb)
        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Item Description Already Used!", vbCritical)
                Exit Sub
            End If
        End Using
    End Sub

    Sub SaveItems()
        'save to ivitem
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO ivitem (itemcode,description,supcode,supplier,catcode,category,brcode,brand,unit, " & _
                               "pckgc,pckgb,pckgp,freeitem,grscost,netcost,costpc,apricec,apriceb,apricep, " & _
                               "bpricec,bpriceb,bpricep,cpricec,cpriceb,cpricep,dpricec,dpriceb,dpricep,epricec,epriceb,epricep,obsolet,discpct,wtkg) " & _
                               " VALUES (@itemcode,@description,@supcode,@supplier,@catcode,@category,@brcode,@brand,@unit,@pckgc, " & _
                               "@pckgb,@pckgp,@freeitem,@grscost,@netcost,@costpc,@apricec,@apriceb,@apricep,@bpricec,@bpriceb, " & _
                               "@bpricep,@cpricec,@cpriceb,@cpricep,@dpricec,@dpriceb,@dpricep,@epricec,@epriceb,@epricep,@obsolet,@discpct,@wtkg)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@itemcode", txtItemcode.Text)
            cmd.Parameters.AddWithValue("@description", txtDescription.Text)
            cmd.Parameters.AddWithValue("@supcode", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@supplier", txtSupname.Text)
            cmd.Parameters.AddWithValue("@catcode", cbxCategory.Text)
            cmd.Parameters.AddWithValue("@category", txtCatname.Text)
            cmd.Parameters.AddWithValue("@brcode", cbxBrand.Text)
            cmd.Parameters.AddWithValue("@brand", txtBrandname.Text)
            cmd.Parameters.AddWithValue("@unit", cbxUnit.Text)
            cmd.Parameters.AddWithValue("@pckgc", nupPcsCase.Value)
            cmd.Parameters.AddWithValue("@pckgb", nuPcBag.Value)

            'If cbxUnit.Text = "P" Then
            cmd.Parameters.AddWithValue("@pckgp", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@pckgp", nuPcBag.Value)
            'End If
            'If cbxFree.Checked = True Then
            '    cmd.Parameters.AddWithValue("@fi", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@fi", 0)
            'End If
            cmd.Parameters.AddWithValue("@freeitem", cbxFree.Text)
            cmd.Parameters.AddWithValue("@grscost", CDbl(txtGross.Text))
            cmd.Parameters.AddWithValue("@netcost", CDbl(txtNetdisc.Text))
            cmd.Parameters.AddWithValue("@costpc", CDbl(txtCostpc.Text))
            cmd.Parameters.AddWithValue("@apricec", CDbl(txtPriceCaseA.Text))
            cmd.Parameters.AddWithValue("@apriceb", CDbl(txtPriceBagA.Text))
            cmd.Parameters.AddWithValue("@apricep", CDbl(txtPricePcA.Text))
            cmd.Parameters.AddWithValue("@bpricec", CDbl(txtPriceCaseB.Text))
            cmd.Parameters.AddWithValue("@bpriceb", CDbl(txtPriceBagB.Text))
            cmd.Parameters.AddWithValue("@bpricep", CDbl(txtPricePcB.Text))
            cmd.Parameters.AddWithValue("@cpricec", CDbl(txtPriceCaseC.Text))
            cmd.Parameters.AddWithValue("@cpriceb", CDbl(txtPriceBagC.Text))
            cmd.Parameters.AddWithValue("@cpricep", CDbl(txtPricePcC.Text))

            cmd.Parameters.AddWithValue("@dpricec", CDbl(txtPriceCaseD.Text))
            cmd.Parameters.AddWithValue("@dpriceb", CDbl(txtPriceBagD.Text))
            cmd.Parameters.AddWithValue("@dpricep", CDbl(txtPricePcD.Text))

            cmd.Parameters.AddWithValue("@epricec", CDbl(txtPriceCaseE.Text))
            cmd.Parameters.AddWithValue("@epriceb", CDbl(txtPriceBagE.Text))
            cmd.Parameters.AddWithValue("@epricep", CDbl(txtPricePcE.Text))

            'If cbxphaseout.Checked = True Then
            '    cmd.Parameters.AddWithValue("@obso", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@obso", 0)
            'End If
            cmd.Parameters.AddWithValue("@obsolet", cbxObsolet.Text)
            cmd.Parameters.AddWithValue("@discpct", nuItemDisc.Value)
            cmd.Parameters.AddWithValue("@wtkg", CDbl(nuWgkg.Value))
            cmd.ExecuteNonQuery()
        End With

    End Sub

    Sub ItemClears()
        txtSearch.Clear()
        txtItemcode.Clear()
        txtDescription.Clear()
        cbxSupplier.Text = Nothing
        txtSupname.Text = Nothing
        cbxCategory.Text = Nothing
        txtCatname.Text = Nothing
        cbxBrand.Text = Nothing
        txtBrandname.Text = Nothing
        cbxUnit.Text = "C"
        cbxFree.Text = "N"
        nupPcsCase.Text = "1"
        nuPcBag.Text = "1"
        txtGross.Text = "0"
        txtNetdisc.Text = "0"
        txtCostpc.Text = "0"
        txtPriceCaseA.Text = "0"
        txtPriceBagA.Text = "0"
        txtPricePcA.Text = "0"
        txtPriceCaseB.Text = "0"
        txtPriceBagB.Text = "0"
        txtPricePcB.Text = "0"
        txtPriceCaseC.Text = "0"
        txtPriceBagC.Text = "0"
        txtPricePcC.Text = "0"

        txtPriceCaseD.Text = "0"
        txtPriceBagD.Text = "0"
        txtPricePcD.Text = "0"

        txtPriceCaseE.Text = "0"
        txtPriceBagE.Text = "0"
        txtPricePcE.Text = "0"

        cbxObsolet.Text = "N"
        nuItemDisc.Text = "0"
        nuWgkg.Value = "0.00"
        txtChangeItemCode.Clear()
        txtChangeItemCode.Enabled = False
        lblpk.Text = Nothing
        ' txtItemcode.Focus()
    End Sub

    Function CheckItemCode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode FROM ivitem WHERE itemcode = @ic", cdb)
        With cmd
            .Parameters.AddWithValue("@ic", txtItemcode.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Function CheckItemDescription()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT description FROM ivitem WHERE description = @desc", cdb)
        With cmd
            .Parameters.AddWithValue("@desc", txtDescription.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub tbNetDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetdisc.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim NetDisc As Decimal = 0
        If e.KeyChar = vbCr Then
            NetDisc = myd(txtNetdisc.Text)
            txtNetdisc.Text = Format(NetDisc, sFmat)
            myd(Format(txtNetdisc.Text, sFmat) = Format(NetDisc, sFmat))
            btnCalcCostPc.PerformClick()
            txtPriceCaseA.Focus()
        End If
    End Sub

    Private Sub btnCalcCostPc_Click(sender As Object, e As EventArgs) Handles btnCalcCostPc.Click
        Dim num1 As Decimal = 0
        Dim totcost As Decimal = 0
        num1 = myd(txtNetdisc.Text) / nupPcsCase.Value
        txtCostpc.Text = Format((num1), sFmat)
    End Sub

    Private Sub tbCostPc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostpc.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPriceBagA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceBagA.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPricePcA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPricePcA.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPriceBagB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceBagB.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPricePcB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPricePcB.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPriceBagC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceBagC.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPricePcC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPricePcC.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnCalcPriceA_Click(sender As Object, e As EventArgs) Handles btnCalcPriceA.Click
        Dim bagA As Decimal = 0
        Dim pcsA As Decimal = 0

        pcsA = Format(CDbl(txtPriceCaseA.Text / nupPcsCase.Value), sFmat)
        If nuPcBag.Value = 1 Then
            bagA = 0
        Else
            bagA = Format((pcsA * nuPcBag.Value), sFmat)
        End If

        txtPricePcA.Text = pcsA
        txtPriceBagA.Text = bagA

    End Sub

    Private Sub tbPriceCaseA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceCaseA.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseA As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseA = myd(txtPriceCaseA.Text)
            txtPriceCaseA.Text = Format(PriceCaseA, sFmat)
            myd(Format(txtPriceCaseA.Text, sFmat) = Format(PriceCaseA, sFmat))
            btnCalcPriceA.PerformClick()
            txtPriceCaseB.Focus()
        End If
    End Sub

    Private Sub btnCalcPriceB_Click(sender As Object, e As EventArgs) Handles btnCalcPriceB.Click
        Dim bagB As Decimal = 0
        Dim pcsB As Decimal = 0

        pcsB = Format((txtPriceCaseB.Text / nupPcsCase.Value), sFmat)
        bagB = Format((pcsB * nuPcBag.Value), sFmat)

        If nuPcBag.Value = 1 Then
            bagB = 0
        Else
            bagB = Format((pcsB * nuPcBag.Value), sFmat)
        End If

        txtPricePcB.Text = pcsB
        txtPriceBagB.Text = bagB
    End Sub

    Private Sub btnCalcPriceC_Click(sender As Object, e As EventArgs) Handles btnCalcPriceC.Click
        Dim bagC As Decimal = 0
        Dim pcsC As Decimal = 0

        pcsC = Format((txtPriceCaseC.Text / nupPcsCase.Value), sFmat)
        bagC = Format((pcsC * nuPcBag.Value), sFmat)

        If nuPcBag.Value = 1 Then
            bagC = 0
        Else
            bagC = Format((pcsC * nuPcBag.Value), sFmat)
        End If

        txtPricePcC.Text = pcsC
        txtPriceBagC.Text = bagC
    End Sub

    Private Sub tbPriceCaseB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceCaseB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseB As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseB = myd(txtPriceCaseB.Text)
            txtPriceCaseB.Text = Format(PriceCaseB, sFmat)
            myd(Format(txtPriceCaseB.Text, sFmat) = Format(PriceCaseB, sFmat))
            btnCalcPriceB.PerformClick()
            txtPriceCaseC.Focus()
        End If
    End Sub

    Private Sub tbPriceCaseC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceCaseC.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseC As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseC = myd(txtPriceCaseC.Text)
            txtPriceCaseC.Text = Format(PriceCaseC, sFmat)
            myd(Format(txtPriceCaseC.Text, sFmat) = Format(PriceCaseC, sFmat))
            btnCalcPriceC.PerformClick()
            txtPriceCaseD.Focus()
        End If
    End Sub

    Private Sub ClearItem_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ItemClears()
    End Sub

    Private Sub cboSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSupplier.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxBrand.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxUnit.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxFree_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxFree.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxObsolet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxObsolet.KeyPress
        e.Handled = True
    End Sub

    Sub UpdateItemCode()

    End Sub

    Private Sub UpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtItemcode.Text.Trim = Nothing And txtDescription.Text.Trim = Nothing Then
            MsgBox("Select item you want to update!", "Item Maintenance", vbExclamation)
            Exit Sub
        End If
      

        If MsgBox("Update this Item?", vbYesNo + vbQuestion, "Item Maintenance") = vbYes Then

            If txtChangeItemCode.Text.Trim = Nothing And txtChangeItemCode.Enabled = True Then
                MsgBox("Enter new item code to change!", vbCritical)
                Exit Sub
            Else
                If isExistItemCode(txtChangeItemCode.Text.Trim) Then
                    MsgBox("Item Code Already Used!", vbCritical)
                    Exit Sub
                End If
                If txtChangeItemCode.Text.Trim = Nothing Then
                    UpdateItems(True) 'if walay new itemcode
                Else
                    UpdateItems(False)
                    updateItemCodeOthers("rcvingd")
                    updateItemCodeOthers("salesd")
                    updateItemCodeOthers("ivd")
                    updateItemCodeOthers("ivwh")
                    updateItemCodeOthers("phyiva")
                    updateItemCodeOthers("phyivd")
                End If
                If txtChangeItemCode.Text <> Nothing Then
                    AuditTrail("Code.:" & Space(1) & txtItemcode.Text & Space(2) & "New code.:" & Space(1) & txtChangeItemCode.Text & Space(2) & "Description:" & Space(1) & txtDescription.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text & Space(2) & "Category:" & Space(1) & cbxCategory.Text, "Change Item Code")
                Else
                    AuditTrail("Code.:" & Space(1) & txtItemcode.Text & Space(2) & "Description:" & Space(1) & txtDescription.Text & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text & Space(2) & "Category:" & Space(1) & cbxCategory.Text, "Update Item")
                End If
                MsgBox("Item has been updated successfully!", vbInformation)
                'LoadItems()
                FilterbySupplier()
                ItemClears()
                btnAdd.PerformClick()
            End If
            'disableControls()
            'Else
            '    MsgBox("Enter new item code.", vbExclamation)
            '    Return
        End If
        txtSearch.Focus()
    End Sub
    Sub disableControls()
        cbxUnit.Enabled = False
        cbxFree.Enabled = False
        nupPcsCase.Enabled = False
        nuPcBag.Enabled = False
        nuWgkg.Enabled = False

        grpSupplier.Enabled = False
        grpSRP.Enabled = False

    End Sub

    Sub updateItemCodeOthers(ByVal tablename As String)

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("UPDATE " & tablename & " set itemcode=@itemcodechange Where itemcode=@itemcode", cdb)
        cmd.Parameters.AddWithValue("@itemcodechange", txtChangeItemCode.Text)
        cmd.Parameters.AddWithValue("@itemcode", txtItemcode.Text)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub UpdateItems(ByVal txtChangeItemCodeIsEmpty As Boolean)
        'update ivitem 
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("UPDATE ivitem set itemcode=@itemcodechange, description=@desc, supcode=@scode, supplier=@sup, " & _
                               "catcode=@ccode, category=@cat, brcode=@bcode, brand=@br, unit=@unit, pckgc=@pcase, " & _
                               "pckgb=@pbag, pckgp=@pcsp, freeitem=@fi, grscost=@gcost, netcost=@nc, costpc=@cp, apricec=@apc, apriceb=@apb, " & _
                               "apricep=@app, bpricec=@bpc, bpriceb=@bpb, bpricep=@bpp, cpricec=@cpc, cpriceb=@cpb, cpricep=@cpp, " & _
                               "dpricec=@dpc, dpriceb=@dpb, dpricep=@dpp, epricec=@epc, epriceb=@epb, epricep=@epp, " & _
                               "obsolet=@obso, discpct=@discpct, wtkg=@wtkg Where itemcode=@ic", cdb)

        If txtChangeItemCodeIsEmpty Then
            cmd.Parameters.AddWithValue("@itemcodechange", txtItemcode.Text)
        Else

            cmd.Parameters.AddWithValue("@itemcodechange", txtChangeItemCode.Text)
        End If

        cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
        cmd.Parameters.AddWithValue("@scode", cbxSupplier.Text)
        cmd.Parameters.AddWithValue("@sup", txtSupname.Text)
        cmd.Parameters.AddWithValue("@ccode", cbxCategory.Text)
        cmd.Parameters.AddWithValue("@cat", txtCatname.Text)
        cmd.Parameters.AddWithValue("@bcode", cbxBrand.Text)
        cmd.Parameters.AddWithValue("@br", txtBrandname.Text)
        cmd.Parameters.AddWithValue("@unit", cbxUnit.Text)
        cmd.Parameters.AddWithValue("@pcase", CDbl(nupPcsCase.Text))
        cmd.Parameters.AddWithValue("@pbag", CDbl(nuPcBag.Text))

        'If cbxUnit.Text = "P" Then
        '    cmd.Parameters.AddWithValue("@pckgp", 1)
        'Else
        cmd.Parameters.AddWithValue("@pcsp", nuPcBag.Value)
        ' End If
        'If cbxFree.Checked = True Then
        '    cmd.Parameters.AddWithValue("@fi", 1)
        'Else
        '    cmd.Parameters.AddWithValue("@fi", 0)
        'End If
        cmd.Parameters.AddWithValue("@fi", cbxFree.Text)
        cmd.Parameters.AddWithValue("@gcost", CDbl(txtGross.Text))
        cmd.Parameters.AddWithValue("@nc", CDbl(txtNetdisc.Text))
        cmd.Parameters.AddWithValue("@cp", CDbl(txtCostpc.Text))
        cmd.Parameters.AddWithValue("@apc", CDbl(txtPriceCaseA.Text))
        cmd.Parameters.AddWithValue("@apb", CDbl(txtPriceBagA.Text))
        cmd.Parameters.AddWithValue("@app", CDbl(txtPricePcA.Text))
        cmd.Parameters.AddWithValue("@bpc", CDbl(txtPriceCaseB.Text))
        cmd.Parameters.AddWithValue("@bpb", CDbl(txtPriceBagB.Text))
        cmd.Parameters.AddWithValue("@bpp", CDbl(txtPricePcB.Text))
        cmd.Parameters.AddWithValue("@cpc", CDbl(txtPriceCaseC.Text))
        cmd.Parameters.AddWithValue("@cpb", CDbl(txtPriceBagC.Text))
        cmd.Parameters.AddWithValue("@cpp", CDbl(txtPricePcC.Text))

        cmd.Parameters.AddWithValue("@dpc", CDbl(txtPriceCaseD.Text))
        cmd.Parameters.AddWithValue("@dpb", CDbl(txtPriceBagD.Text))
        cmd.Parameters.AddWithValue("@dpp", CDbl(txtPricePcD.Text))

        cmd.Parameters.AddWithValue("@epc", CDbl(txtPriceCaseE.Text))
        cmd.Parameters.AddWithValue("@epb", CDbl(txtPriceBagE.Text))
        cmd.Parameters.AddWithValue("@epp", CDbl(txtPricePcE.Text))

        'If cbxphaseout.Checked = True Then
        '    cmd.Parameters.AddWithValue("@obso", 1)
        'Else
        '    cmd.Parameters.AddWithValue("@obso", 0)
        'End If
        cmd.Parameters.AddWithValue("@obso", cbxObsolet.Text)
        cmd.Parameters.AddWithValue("@discpct", nuItemDisc.Value)
        cmd.Parameters.AddWithValue("@wtkg", CDbl(nuWgkg.Value))
        ' cmd.Parameters.AddWithValue("@pkno", lblpk.Text)
        cmd.Parameters.AddWithValue("@ic", txtItemcode.Text)

        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtSupname.Text = rd.Item("suppliername").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from category where catcode like '%" & cbxCategory.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtCatname.Text = rd.Item("categoryname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub cbxBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBrand.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from brand where brcode like '%" & cbxBrand.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtBrandname.Text = rd.Item("brandname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub tbItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemcode.TextChanged
        ' CheckItem()
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar = vbCr Then
            cbxSupplier.Focus()
        End If
    End Sub

    Private Sub tbItemDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        'CheckDescription()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnClear.Enabled = True
        txtItemcode.Enabled = True
        ItemClears()
        txtItemcode.Focus()

    End Sub

    Private Sub tbPriceCaseA_TextChanged(sender As Object, e As EventArgs) Handles txtPriceCaseA.TextChanged

    End Sub

    Private Sub tbGross_TextChanged(sender As Object, e As EventArgs) Handles txtGross.TextChanged

    End Sub

    Private Sub dgvItemList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvItemList.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvItemList_CellClick(1, New DataGridViewCellEventArgs(0, dgvItemList.CurrentRow.Index))
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        chkRefresh.Checked = False
        FilterbySupplier()
        ItemClears()
        'LoadItems()
        ' cbxFilterSupplier.Text = " --- Filter by Supplier --- "
        'LoadItems()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        'wala gyud transaction
        With dgvItemList

            If .RowCount > 0 Then
                Dim pkno As String = Nothing
                Dim iCode As String = Nothing
                Dim iDesc As String = Nothing
                pkno = .Item(34, .CurrentRow.Index).Value
                iCode = .Item(1, .CurrentRow.Index).Value
                iDesc = .Item(1, .CurrentRow.Index).Value


                If checkItemIsExisting(iCode) Then
                    ' MsgBox("naa") 'nag exist sya
                    MsgBox("Item has already transaction. Cannot be deleted.", vbInformation)
                    Exit Sub
                Else
                    If MsgBox("Delete Item :" & iCode & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        'cmd = New MySqlCommand("UPDATE ivitem SET isdeleted=1 WHERE itemcode=@tr", cdb)
                        'cmd = New MySqlCommand("DELETE FROM ivitem where pkno like '" & pkno & "'", cdb)
                        cmd = New MySqlCommand("DELETE FROM ivitem where itemcode=@ic", cdb)
                        cmd.Parameters.AddWithValue("@ic", iCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        'check the item from ivwh
                        cmd = New MySqlCommand("SELECT * FROM ivwh WHERE itemcode=@it", cdb)
                        cmd.Parameters.AddWithValue("@it", iCode)
                        rd = cmd.ExecuteReader
                        rd.Read()
                        If rd.HasRows Then
                            iCode = rd("itemcode").ToString
                        End If
                        cmd.Dispose()
                        rd.Dispose()

                        'delete from ivwh if qty_good=0 and qty_bo=0
                        cmd = New MySqlCommand("DELETE FROM ivwh where itemcode=@ic", cdb)
                        cmd.Parameters.AddWithValue("@ic", iCode)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        AuditTrail("Code:" & Space(1) & iCode & Space(2) & "Description:" & Space(1) & iDesc & Space(2) & "Supplier:" & Space(1) & cbxSupplier.Text & Space(2) & "Category:" & Space(1) & cbxCategory.Text, "Delete Item")
                        MsgBox("Item has been successfully deleted!", vbInformation)
                        LoadSupplier()
                        LoadCategory()
                        LoadBrand()
                        LoadItems()
                        ItemClears()
                        btnUpdate.Enabled = False
                        'MsgBox("Wala")
                    End If
                End If 'checkItemIsExisting


            End If ' If .RowCount > 0
        End With

    End Sub



    'Private Function iCheckTransaction(ByVal iTable As String)
    '    'Dim fn As Boolean = False
    '    'Dim cmd As MySqlCommand
    '    'cmd = New MySqlCommand("SELECT item FROM ", iTable, " WHERE item=@item", cdb)
    '    'cmd.Parameters.AddWithValue("@item", txtItemcode.Text)
    '    'Using rd As MySqlDataReader = cmd.ExecuteReader
    '    '    If rd.HasRows Then
    '    '        fn = True
    '    '    End If
    '    'End Using
    '    'cmd.Dispose()
    '    'Return fn
    'End Function

    'Public Function getolditem(ByVal pkn As String)
    '    Dim olditm As String = Nothing

    '    Dim cmd As MySqlCommand
    '    cmd = New MySqlCommand("SELECT item,qty,pckg,qunit FROM ivd WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
    '    'cmd.Parameters.AddWithValue("@im", itm)
    '    cmd.Parameters.AddWithValue("@pk", pkn)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            rd.Read()
    '            olditm = rd("item").ToString
    '        End If
    '        rd.Close()
    '    End Using
    '    cmd.Dispose()

    '    Return olditm
    'End Function

    Private Sub nuPcBag_ValueChanged(sender As Object, e As EventArgs) Handles nuPcBag.ValueChanged
        If txtItemcode.Text <> Nothing Then
            ComputeBag()
            btnCalcPriceB.PerformClick()
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Item Maintenance") = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub cbSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxFilterSupplier.KeyPress
        e.Handled = True
    End Sub

    Sub FilterbySupplier()
        If cbxFilterSupplier.Text <> Nothing Then
            Dim i As Integer
            dgvItemList.Rows.Clear()
            'cmd = New MySqlCommand("SELECT * FROM ivitem where (description like '%" & tbSeachItem.Text & "%' or itemcode like '%" & tbSeachItem.Text & "%') AND obsolet <> 'Y' AND isdeleted='0' order by supplier asc", cdb)
            cmd = New MySqlCommand("SELECT * FROM ivitem where (supplier like '%" & cbxFilterSupplier.Text & "%') AND obsolet <> 'Y' AND isdeleted='0' order by description asc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, _
                                     rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                      rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, _
                                      Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                      rd.Item("freeitem").ToString, Format(CDbl(rd.Item("grscost").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("netcost").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("costpc").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), _
                                      rd.Item("wtkg").ToString, rd.Item("pkno").ToString) ', "Edit", "Delete")
            End While
            rd.Close()
        Else
            dgvItemList.Rows.Clear()
            Dim i As Integer
            cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND isdeleted='0' ORDER BY description asc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                      rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                      rd.Item("freeitem").ToString, Format(CDbl(rd.Item("grscost").ToString), "#,##0.00"), Format(CDbl(rd.Item("netcost").ToString), "#,##0.00"), Format(CDbl(rd.Item("costpc").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                      Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                      rd.Item("obsolet").ToString, rd.Item("discpct").ToString, rd.Item("wtkg").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
            End While
            rd.Close()
        End If
        
    End Sub
    Private Sub cbFilterbySupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilterSupplier.SelectedIndexChanged
        FilterbySupplier()
    End Sub

    Private Sub txtPriceCaseD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceCaseD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseD As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseD = myd(txtPriceCaseD.Text)
            txtPriceCaseD.Text = Format(PriceCaseD, sFmat)
            myd(Format(txtPriceCaseD.Text, sFmat) = Format(PriceCaseD, sFmat))
            btnCalcPriceD.PerformClick()
            txtPriceCaseE.Focus()
        End If

    End Sub

    Private Sub btnCalcPriceD_Click(sender As Object, e As EventArgs) Handles btnCalcPriceD.Click
        Dim bagD As Decimal = 0
        Dim pcsD As Decimal = 0

        pcsD = Format((txtPriceCaseD.Text / nupPcsCase.Value), sFmat)
        bagD = Format((pcsD * nuPcBag.Value), sFmat)

        If nuPcBag.Value = 1 Then
            bagD = 0
        Else
            bagD = Format((pcsD * nuPcBag.Value), sFmat)
        End If

        txtPricePcD.Text = pcsD
        txtPriceBagD.Text = bagD
    End Sub

    Private Sub btnCalcPriceE_Click(sender As Object, e As EventArgs) Handles btnCalcPriceE.Click
        Dim bagE As Decimal = 0
        Dim pcsE As Decimal = 0

        pcsE = Format((txtPriceCaseE.Text / nupPcsCase.Value), sFmat)
        bagE = Format((pcsE * nuPcBag.Value), sFmat)

        If nuPcBag.Value = 1 Then
            bagE = 0
        Else
            bagE = Format((pcsE * nuPcBag.Value), sFmat)
        End If

        txtPricePcE.Text = pcsE
        txtPriceBagE.Text = bagE
    End Sub

    Private Sub txtPriceCaseE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceCaseE.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseE As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseE = myd(txtPriceCaseE.Text)
            txtPriceCaseE.Text = Format(PriceCaseE, sFmat)
            myd(Format(txtPriceCaseE.Text, sFmat) = Format(PriceCaseE, sFmat))
            btnCalcPriceE.PerformClick()
        End If
    End Sub

    Private Sub txtPriceBagD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceBagD.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPricePcD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPricePcD.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPriceBagE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceBagE.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPricePcE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPricePcE.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPriceCaseD_TextChanged(sender As Object, e As EventArgs) Handles txtPriceCaseD.TextChanged

    End Sub

    Private Sub txtPriceBagD_TextChanged(sender As Object, e As EventArgs) Handles txtPriceBagD.TextChanged

    End Sub

    Private Sub txtSupname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupname.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtSupname_TextChanged(sender As Object, e As EventArgs) Handles txtSupname.TextChanged

    End Sub

    Private Sub txtCatname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCatname.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCatname_TextChanged(sender As Object, e As EventArgs) Handles txtCatname.TextChanged

    End Sub

    Private Sub txtBrandname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrandname.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtBrandname_TextChanged(sender As Object, e As EventArgs) Handles txtBrandname.TextChanged

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChangeItemCode.Click
        If txtItemcode.Text = Nothing Then
            MsgBox("Select item to change.", vbExclamation)
            Exit Sub
        End If
        txtChangeItemCode.Enabled = True
        txtChangeItemCode.Focus()
    End Sub

    Private Sub cbxSupplier_TextChanged(sender As Object, e As EventArgs) Handles cbxSupplier.TextChanged
        cbxCategory.Focus()
    End Sub

    Private Sub cbxCategory_TextChanged(sender As Object, e As EventArgs) Handles cbxCategory.TextChanged
        cbxUnit.Focus()
    End Sub

    Private Sub cbxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUnit.SelectedIndexChanged

    End Sub

    Private Sub cbxUnit_TextChanged(sender As Object, e As EventArgs) Handles cbxUnit.TextChanged
        nupPcsCase.Focus()
    End Sub

    Private Sub nupPcsCase_ValueChanged(sender As Object, e As EventArgs) Handles nupPcsCase.ValueChanged

    End Sub

    Private Sub txtPriceCaseB_TextChanged(sender As Object, e As EventArgs) Handles txtPriceCaseB.TextChanged

    End Sub

    Private Sub txtPriceCaseC_TextChanged(sender As Object, e As EventArgs) Handles txtPriceCaseC.TextChanged

    End Sub

    
    Private Sub chkRefresh_CheckedChanged(sender As Object, e As EventArgs) Handles chkRefresh.CheckedChanged
        If chkRefresh.Checked = True Then
            cbxFilterSupplier.Text = Nothing
            LoadItems()
        Else
            FilterbySupplier()
        End If
    End Sub
End Class