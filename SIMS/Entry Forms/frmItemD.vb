Imports MySql.Data.MySqlClient

Public Class frmItemD

    Private Sub frmItemD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmItemD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmItemD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSupplier()
        LoadCategory()
        LoadBrand()


        ' NewItem.Enabled = True
        'SaveItem.Enabled = False
        'UpdateItem.Enabled = False
        'ClearItem.Enabled = False
        ' DisableItems()
    End Sub

    Sub DisableItems()
        tbItemCode.Enabled = False
        tbItemDescription.Enabled = False
        cbxSupplier.Enabled = False
        cbxCategory.Enabled = False
        cbxBrand.Enabled = False
        cbxUnit.Enabled = False
        nupPcsCase.Enabled = False
        nuPcBag.Enabled = False
        cbxFree.Enabled = False
        tbGross.Enabled = False
        tbNetDisc.Enabled = False
        tbCostPc.Enabled = False
        tbPriceCaseA.Enabled = False
        tbPriceBagA.Enabled = False
        tbPricePcA.Enabled = False
        tbPriceCaseB.Enabled = False
        tbPriceBagB.Enabled = False
        tbPricePcB.Enabled = False
        tbPriceCaseC.Enabled = False
        tbPriceBagC.Enabled = False
        tbPricePcC.Enabled = False
        cbxObsolet.Enabled = False
        nuItemDisc.Enabled = False
    End Sub

    Sub enableitem()
        tbItemCode.Enabled = True
        tbItemDescription.Enabled = True
        cbxSupplier.Enabled = True
        cbxCategory.Enabled = True
        cbxBrand.Enabled = True
        cbxUnit.Enabled = True
        nupPcsCase.Enabled = True
        nuPcBag.Enabled = True
        cbxFree.Enabled = True
        tbGross.Enabled = True
        tbNetDisc.Enabled = True
        tbCostPc.Enabled = True
        tbPriceCaseA.Enabled = True
        tbPriceBagA.Enabled = True
        tbPricePcA.Enabled = True
        tbPriceCaseB.Enabled = True
        tbPriceBagB.Enabled = True
        tbPricePcB.Enabled = True
        tbPriceCaseC.Enabled = True
        tbPriceBagC.Enabled = True
        tbPricePcC.Enabled = True
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
            nuPcBag.Focus()
        End If
    End Sub

    Private Sub nupbag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nuPcBag.KeyPress
        If e.KeyChar = vbCr Then
            btnCalcCostPc.PerformClick()
            btnCalcPriceA.PerformClick()
            btnCalcPriceB.PerformClick()
            btnCalcPriceC.PerformClick()
            tbGross.Focus()
        End If
    End Sub

    Private Sub tbGross_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbGross.KeyPress
        'Select Case Asc(e.KeyChar)
        '    Case 48 To 57
        '    Case 46
        '    Case 8
        '    Case Else
        '        e.Handled = True
        'End Select
        Dim GrossCost As Decimal = 0
        If e.KeyChar = vbCr Then
            GrossCost = myd(tbGross.Text)
            tbGross.Text = Format(GrossCost, sFmat)
            myd(Format(tbGross.Text, sFmat) = Format(GrossCost, sFmat))
            tbNetDisc.Focus()
        End If
    End Sub

    Private Sub tbItemCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbItemCode.KeyPress
        If e.KeyChar = vbCr Then
            tbItemDescription.Focus()
        End If
    End Sub


    Private Sub SaveItem_Click(sender As Object, e As EventArgs) Handles SaveItem.Click

        If tbItemCode.Text = Nothing Or tbItemDescription.Text = Nothing Or cbxSupplier.Text = Nothing Or cbxCategory.Text = Nothing Or cbxBrand.Text = Nothing Or cbxUnit.Text = Nothing Then
            MsgBox("Pls Check Missing Filed!", vbExclamation)
            Exit Sub
        End If

        If nupPcsCase.Value = "0" Or nuPcBag.Value = "0" Then
            MsgBox("Pcs Per Case Shoulbe not be Zero!", vbExclamation)
            Exit Sub
        End If

        cmd = New MySqlCommand("SELECT itemcode FROM ivitem WHERE itemcode=@itm", cdb)
        cmd.Parameters.AddWithValue("@itm", tbItemCode.Text.Trim)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Item Code Already Used!", vbCritical)
                Exit Sub
            End If
        End Using

        cmd = New MySqlCommand("SELECT description FROM ivitem WHERE description=@desc", cdb)
        cmd.Parameters.AddWithValue("@desc", tbItemDescription.Text.Trim)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Item Description Already Used!", vbCritical)
                Exit Sub
            End If
        End Using

        If MsgBox("Save  this Item?", vbYesNo + vbQuestion) = vbYes Then
            SaveItems()
        End If

    End Sub

    Sub CheckItem()
        cmd = New MySqlCommand("SELECT itemcode FROM ivitem WHERE itemcode=@itm", cdb)
        cmd.Parameters.AddWithValue("@itm", tbItemCode.Text.Trim)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Item Code Already Used!", vbCritical)
                Exit Sub
            End If
        End Using
    End Sub

    Sub CheckDescription()
        cmd = New MySqlCommand("SELECT description FROM ivitem WHERE description=@desc", cdb)
        cmd.Parameters.AddWithValue("@desc", tbItemDescription.Text.Trim)
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
                               "pckgc,pckgb,freeitem,grscost,netcost,costpc,apricec,apriceb,apricep, " & _
                               "bpricec,bpriceb,bpricep,cpricec,cpriceb,cpricep,obsolet,discpct) " & _
                               " VALUES (@ic,@desc,@supcode,@sup,@catcode,@cat,brcode,@brname,@unit,@pcase,@pbag,@fi,@gcost,@nc,@cp,@apc,@apb,@app,@bpc,@bpb,@bpp,@cpc,@cpb,@cpp,@obso,@discp)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@ic", tbItemCode.Text)
            cmd.Parameters.AddWithValue("@desc", tbItemDescription.Text)
            cmd.Parameters.AddWithValue("@supcode", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@sup", lblSupplier.Text)
            cmd.Parameters.AddWithValue("@catcode", cbxCategory.Text)
            cmd.Parameters.AddWithValue("@cat", lblCategory.Text)
            cmd.Parameters.AddWithValue("@brcode", cbxBrand.Text)
            cmd.Parameters.AddWithValue("@brname", lblBrand.Text)
            cmd.Parameters.AddWithValue("@unit", cbxUnit.Text)
            cmd.Parameters.AddWithValue("@pcase", CDbl(nupPcsCase.Text))
            cmd.Parameters.AddWithValue("@pbag", CDbl(nuPcBag.Text))
            'If cbxFree.Checked = True Then
            '    cmd.Parameters.AddWithValue("@fi", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@fi", 0)
            'End If
            cmd.Parameters.AddWithValue("@fi", cbxFree.Text)
            cmd.Parameters.AddWithValue("@gcost", CDbl(tbGross.Text))
            cmd.Parameters.AddWithValue("@nc", CDbl(tbNetDisc.Text))
            cmd.Parameters.AddWithValue("@cp", CDbl(tbCostPc.Text))
            cmd.Parameters.AddWithValue("@apc", CDbl(tbPriceCaseA.Text))
            cmd.Parameters.AddWithValue("@apb", CDbl(tbPriceBagA.Text))
            cmd.Parameters.AddWithValue("@app", CDbl(tbPricePcA.Text))
            cmd.Parameters.AddWithValue("@bpc", CDbl(tbPriceCaseB.Text))
            cmd.Parameters.AddWithValue("@bpb", CDbl(tbPriceBagB.Text))
            cmd.Parameters.AddWithValue("@bpp", CDbl(tbPricePcB.Text))
            cmd.Parameters.AddWithValue("@cpc", CDbl(tbPriceCaseC.Text))
            cmd.Parameters.AddWithValue("@cpb", CDbl(tbPriceBagC.Text))
            cmd.Parameters.AddWithValue("@cpp", CDbl(tbPricePcC.Text))
            'If cbxphaseout.Checked = True Then
            '    cmd.Parameters.AddWithValue("@obso", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@obso", 0)
            'End If
            cmd.Parameters.AddWithValue("@obso", cbxObsolet.Text)
            cmd.Parameters.AddWithValue("@discp", CDbl(nuItemDisc.Text))
            cmd.ExecuteNonQuery()
        End With
        MsgBox("New Item Has Been Save Sucessfully!", vbInformation)
        frmItemH.LoadItems()
        Me.Dispose()
    End Sub

    Sub ItemClears()
        tbItemCode.Clear()
        tbItemDescription.Clear()
        cbxSupplier.Text = Nothing
        cbxCategory.Text = Nothing
        cbxBrand.Text = Nothing
        cbxUnit.Text = Nothing
        nupPcsCase.Text = "1"
        nuPcBag.Text = "1"
        cbxFree.Text = Nothing
        tbGross.Text = "0"
        tbNetDisc.Text = "0"
        tbCostPc.Text = "0"
        tbPriceCaseA.Text = "0"
        tbPriceBagA.Text = "0"
        tbPricePcA.Text = "0"
        tbPriceCaseB.Text = "0"
        tbPriceBagB.Text = "0"
        tbPricePcB.Text = "0"
        tbPriceCaseC.Text = "0"
        tbPriceBagC.Text = "0"
        tbPricePcC.Text = "0"
        cbxObsolet.Text = Nothing
        nuItemDisc.Text = "0"
        tbItemCode.Focus()
    End Sub

    Function CheckItemCode()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode FROM ivitem WHERE itemcode = @ic", cdb)
        With cmd
            .Parameters.AddWithValue("@ic", tbItemCode.Text.Trim)
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
            .Parameters.AddWithValue("@desc", tbItemDescription.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub tbNetDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNetDisc.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim NetDisc As Decimal = 0
        If e.KeyChar = vbCr Then
            NetDisc = myd(tbNetDisc.Text)
            tbNetDisc.Text = Format(NetDisc, sFmat)
            myd(Format(tbNetDisc.Text, sFmat) = Format(NetDisc, sFmat))
            btnCalcCostPc.PerformClick()
            tbPriceCaseA.Focus()
        End If
    End Sub

    Private Sub btnCalcCostPc_Click(sender As Object, e As EventArgs) Handles btnCalcCostPc.Click
        Dim num1 As Decimal = 0
        Dim totcost As Decimal = 0
        num1 = myd(tbNetDisc.Text) / nupPcsCase.Value
        tbCostPc.Text = Format((num1), sFmat)
    End Sub

    Private Sub tbCostPc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCostPc.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPriceBagA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPriceBagA.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPricePcA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPricePcA.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPriceBagB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPriceBagB.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPricePcB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPricePcB.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPriceBagC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPriceBagC.KeyPress
        e.Handled = True
    End Sub

    Private Sub tbPricePcC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPricePcC.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnCalcPriceA_Click(sender As Object, e As EventArgs) Handles btnCalcPriceA.Click
        Dim bagA As Decimal = 0
        Dim pcsA As Decimal = 0

        pcsA = Format(CDbl(tbPriceCaseA.Text / nupPcsCase.Value), sFmat)
        If nuPcBag.Value = 1 Then
            bagA = 0
        Else
            bagA = Format((pcsA * nuPcBag.Value), sFmat)
        End If

        tbPricePcA.Text = pcsA
        tbPriceBagA.Text = bagA

    End Sub

    Private Sub tbPriceCaseA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPriceCaseA.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseA As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseA = myd(tbPriceCaseA.Text)
            tbPriceCaseA.Text = Format(PriceCaseA, sFmat)
            myd(Format(tbPriceCaseA.Text, sFmat) = Format(PriceCaseA, sFmat))
            btnCalcPriceA.PerformClick()
        End If
    End Sub

    Private Sub btnCalcPriceB_Click(sender As Object, e As EventArgs) Handles btnCalcPriceB.Click
        Dim bagB As Decimal = 0
        Dim pcsB As Decimal = 0

        pcsB = Format((tbPriceCaseB.Text / nupPcsCase.Value), sFmat)
        bagB = Format((pcsB * nuPcBag.Value), sFmat)

        If nuPcBag.Value = 1 Then
            bagB = 0
        Else
            bagB = Format((pcsB * nuPcBag.Value), sFmat)
        End If

        tbPricePcB.Text = pcsB
        tbPriceBagB.Text = bagB
    End Sub

    Private Sub btnCalcPriceC_Click(sender As Object, e As EventArgs) Handles btnCalcPriceC.Click
        Dim bagC As Decimal = 0
        Dim pcsC As Decimal = 0

        pcsC = Format((tbPriceCaseC.Text / nupPcsCase.Value), sFmat)
        bagC = Format((pcsC * nuPcBag.Value), sFmat)

        If nuPcBag.Value = 1 Then
            bagC = 0
        Else
            bagC = Format((pcsC * nuPcBag.Value), sFmat)
        End If

        tbPricePcC.Text = pcsC
        tbPriceBagC.Text = bagC
    End Sub

    Private Sub tbPriceCaseB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPriceCaseB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseB As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseB = myd(tbPriceCaseB.Text)
            tbPriceCaseB.Text = Format(PriceCaseB, sFmat)
            myd(Format(tbPriceCaseB.Text, sFmat) = Format(PriceCaseB, sFmat))
            btnCalcPriceB.PerformClick()
        End If

    End Sub

    Private Sub tbPriceCaseC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPriceCaseC.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
        Dim PriceCaseC As Decimal = 0
        If e.KeyChar = vbCr Then
            PriceCaseC = myd(tbPriceCaseC.Text)
            tbPriceCaseC.Text = Format(PriceCaseC, sFmat)
            myd(Format(tbPriceCaseC.Text, sFmat) = Format(PriceCaseC, sFmat))
            btnCalcPriceC.PerformClick()
        End If
    End Sub

    Private Sub ClearItem_Click(sender As Object, e As EventArgs) Handles ClearItem.Click
        ItemClears()
    End Sub

    Private Sub cboSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSupplier.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxBrand.KeyPress
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

    Private Sub UpdateItem_Click(sender As Object, e As EventArgs) Handles UpdateItem.Click

        If MsgBox("Update this Item?", vbYesNo + vbQuestion) = vbYes Then
            UpdateItems()
        End If

    End Sub

    Sub UpdateItems()
        'update ivitem 
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("UPDATE ivitem set itemcode=@ic, description=@desc, supcode=@scode, supplier=@sup, " & _
                               "catcode=@ccode, category=@cat, brcode=@bcode, brand=@br, unit=@unit, pckgc=@pcase, " & _
                               "pckgb=@pbag, freeitem=@fi, grscost=@gcost, netcost=@nc, costpc=@cp, apricec=@apc, apriceb=@apb, " & _
                               "apricep=@app, bpricec=@bpc, bpriceb=@bpb, bpricep=@bpp, cpricec=@cpc, cpriceb=@cpb, cpricep=@cpp, " & _
                               "obsolet=@obso, discpct=@discp where pkno=@pkno", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@ic", tbItemCode.Text)
            cmd.Parameters.AddWithValue("@desc", tbItemDescription.Text)
            cmd.Parameters.AddWithValue("@scode", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@sup", lblSupplier.Text)
            cmd.Parameters.AddWithValue("@ccode", cbxCategory.Text)
            cmd.Parameters.AddWithValue("@cat", lblCategory.Text)
            cmd.Parameters.AddWithValue("@bcode", cbxBrand.Text)
            cmd.Parameters.AddWithValue("@br", lblBrand.Text)
            cmd.Parameters.AddWithValue("@unit", cbxUnit.Text)
            cmd.Parameters.AddWithValue("@pcase", CDbl(nupPcsCase.Text))
            cmd.Parameters.AddWithValue("@pbag", CDbl(nuPcBag.Text))
            'If cbxFree.Checked = True Then
            '    cmd.Parameters.AddWithValue("@fi", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@fi", 0)
            'End If
            cmd.Parameters.AddWithValue("@fi", cbxFree.Text)
            cmd.Parameters.AddWithValue("@gcost", CDbl(tbGross.Text))
            cmd.Parameters.AddWithValue("@nc", CDbl(tbNetDisc.Text))
            cmd.Parameters.AddWithValue("@cp", CDbl(tbCostPc.Text))
            cmd.Parameters.AddWithValue("@apc", CDbl(tbPriceCaseA.Text))
            cmd.Parameters.AddWithValue("@apb", CDbl(tbPriceBagA.Text))
            cmd.Parameters.AddWithValue("@app", CDbl(tbPricePcA.Text))
            cmd.Parameters.AddWithValue("@bpc", CDbl(tbPriceCaseB.Text))
            cmd.Parameters.AddWithValue("@bpb", CDbl(tbPriceBagB.Text))
            cmd.Parameters.AddWithValue("@bpp", CDbl(tbPricePcB.Text))
            cmd.Parameters.AddWithValue("@cpc", CDbl(tbPriceCaseC.Text))
            cmd.Parameters.AddWithValue("@cpb", CDbl(tbPriceBagC.Text))
            cmd.Parameters.AddWithValue("@cpp", CDbl(tbPricePcC.Text))
            'If cbxphaseout.Checked = True Then
            '    cmd.Parameters.AddWithValue("@obso", 1)
            'Else
            '    cmd.Parameters.AddWithValue("@obso", 0)
            'End If
            cmd.Parameters.AddWithValue("@obso", cbxObsolet.Text)
            cmd.Parameters.AddWithValue("@discp", CDbl(nuItemDisc.Text))
            cmd.Parameters.AddWithValue("@pkno", lblpk.Text)
            cmd.ExecuteNonQuery()
        End With
        MsgBox("Item Has Been Updated Successfully!", vbInformation)
        frmItemH.LoadItems()
        Me.Dispose()
    End Sub

    Private Sub cboSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                lblSupplier.Text = rd.Item("suppliername").ToString
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
                lblCategory.Text = rd.Item("categoryname").ToString
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
                lblBrand.Text = rd.Item("brandname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub tbItemCode_TextChanged(sender As Object, e As EventArgs) Handles tbItemCode.TextChanged
        ' CheckItem()
    End Sub

    Private Sub tbItemDescription_TextChanged(sender As Object, e As EventArgs) Handles tbItemDescription.TextChanged
        'CheckDescription()
    End Sub
End Class