Imports MySql.Data.MySqlClient

Public Class frmBOreturnSupplierD
    Dim lastitemsel As String = Nothing
    Dim lDuplicate As Boolean = False
    Dim listrmv() As rmvitem
    Dim rwrmv As Integer = 0
    Structure rmvitem
        Dim c1item As String
        Dim c1qty As Decimal
        Dim c2transno As String
        Dim c3qty As Integer
    End Structure
    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        If gbxItemList.Visible = True Then
            Return
        Else
            Me.Dispose()
        End If


    End Sub

    Private Sub tsSearchItem_Click(sender As Object, e As EventArgs) Handles tsSearchItem.Click
        If cbxSupplier.Text = "" Then
            MsgBox("Please Select Supplier!", MsgBoxStyle.Critical)
            cbxSupplier.Focus()
            Exit Sub
        End If
        With dgvBOReturnItem
            If .Rows.Count > 0 Then
                Dim r As Integer = 0

                r = .Rows.Count - 1

                If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing _
                    And .Rows(r).Cells(7).Value <> Nothing Then
                    gbxItemList.BringToFront()
                    gbxItemList.Visible = True
                    LoadItemList()
                Else
                    LoadItemList()
                    gbxItemList.BringToFront()
                    gbxItemList.Visible = True
                    'MsgBox("Please provide proper item/s and quantity first", 48, "Invalid entry found")
                End If
            Else
                gbxItemList.Visible = True
                LoadItemList()
            End If

        End With

        ' frmSearchItem.ShowDialog()

    End Sub

    Sub LoadItemList()
        dgvBOReturnItem.EndEdit()
        dgvItemList.Rows.Clear()
        '   dgvItemList.Focus()
        Dim i As Integer
        If cbxSupplier.Text <> Nothing Then
            cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND supcode=@spc ORDER BY supplier ASC", cdb)
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

    Private Sub frmBOreturnSupplierD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            tsSearchItem_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            'Me.Dispose()
        End If
    End Sub

    Private Sub frmBOreturnSupplierD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSupplier()
        LoadWarehouse()

    End Sub

    Sub LoadSupplier()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxSupplier.Items.Clear()
        cbxSupplier.DisplayMember = "text"
        qry = "Select * from supplier ORDER BY suppliername"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim rrl = rmd.ExecuteReader()
        While rrl.Read()
            cbxSupplier.Items.Add(New With {.Text = rrl("supcode").ToString(), .Value = rrl("supcode").ToString()})
        End While
        rrl.Dispose()
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        gbxItemList.Visible = False
    End Sub



    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        load_items()
    End Sub

    Private Sub dgvItemList_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellEndEdit

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

    Dim selrow As Integer = 0
    Delegate Sub SetColumnIndex(ByVal i As Integer)
    Private Sub Mymethod(ByVal columnIndex As Integer)
        If Me.dgvBOReturnItem.CurrentRow.Index > 0 Then
            Me.dgvBOReturnItem.CurrentCell = Me.dgvBOReturnItem.Item(columnIndex, selrow)    '.Cells(columnIndex)
            Me.dgvBOReturnItem.BeginEdit(True)
        Else
            Me.dgvBOReturnItem.CurrentCell = Me.dgvBOReturnItem.Item(columnIndex, 0)   '.Cells(columnIndex)
            Me.dgvBOReturnItem.BeginEdit(True)
        End If
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

                        With dgvBOReturnItem
                            'Dim mycat As String = Nothing
                            'mycat = dgvItemList.Item(6, rdx).Value

                            If .RowCount > 0 Then
                                rindex = dgvBOReturnItem.CurrentCell.RowIndex

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
                                        .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                        .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                        .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                        .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                        .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                        .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                        .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                        '  .Item(10, nn).Value = "Delete"
                                        .CurrentCell = .Item(3, nn)
                                        '.Item(3, nn).Selected = True
                                        .BeginEdit(True)
                                    End If
                                Else

                                    If .Item(1, rindex).Value <> Nothing And .Item(3, rindex).Value <> 0 And _
                                        .Item(8, rindex).Value <> Nothing Then
                                        nrow += 1
                                        .RowCount += 1
                                        nn = .RowCount - 1

                                        nm = nrow
                                        selrow = nn

                                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(0, nn).Value = nm
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                            .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                            .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
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
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                            .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                            .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                            .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
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
                                    .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                    .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                    .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value
                                    .Item(6, nn).Value = dgvItemList.Item(13, rdx).Value
                                    .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                    .Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
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
    Function checkitemno(ByVal itmn As String)
        Dim fnd As Boolean = False
        With dgvBOReturnItem
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

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub
End Class