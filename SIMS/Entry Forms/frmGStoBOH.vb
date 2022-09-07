Imports MySql.Data.MySqlClient

Public Class frmGStoBOH

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmGStoBOD.ShowDialog()

    End Sub

    Private Sub frmGStoBOH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit.PerformClick()
            e.Handled = True
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmGStoBOH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        LoadGStoBOH()
    End Sub

    Sub LoadGStoBOH()
        dgvGStoBOList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM ivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE ttype='B' AND isdeleted<>1 ORDER BY tdate desc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvGStoBOList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                             rd.Item("warehouse").ToString, Format(CDbl(rd.Item("total").ToString), "#,##0.00"), rd.Item("userid").ToString)
        End While
        rd.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvGStoBOList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmGStoBOD.LoadSupplier()
                frmGStoBOD.LoadWarehouse()
                frmGStoBOD.RetrieveConverted(mytrans)
                frmGStoBOD.Tag = 1
                frmGStoBOD.cboSupplier.Enabled = False
                frmGStoBOD.tsSave.Visible = False
                frmGStoBOD.tsUpdate.Visible = True
                frmGStoBOD.btnSearch.Enabled = False
                frmGStoBOD.ShowDialog()
            End If
        End With
    End Sub
    Structure upheaderdt
        Dim ihtcd As String
        Dim ihqty As Decimal
        Dim ihpckg As Decimal
        Dim ihqunit As String
        Dim ihwhs As String
        Dim ihwhs2 As String
        Dim ihgoods As Decimal
    End Structure
    Dim upthisitem() As upheaderdt
    Dim rwuph As Integer = 0

    Private Sub reset_upthisitem()
        'Reset count and array
        rwuph = 0
        Erase upthisitem
    End Sub
    Private Sub updwhsheader(ByVal wh As String, ByVal wh2 As String, ByVal itc As String, ByVal totpck As Decimal)

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0

        curqty = 0
        nwqty = 0

        'cmd = New MySqlCommand("SELECT item,qty_good FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@itm", itc)
        'cmd.Parameters.AddWithValue("@wh", wh)

        'Using rd As MySqlDataReader = cmd.ExecuteReader
        '    If rd.HasRows Then
        '        rd.Read()
        '        curqty = rd("qty_good").ToString
        '    End If
        '    rd.Close()
        'End Using
        'cmd.Dispose()
        curqty = getcurqty(itc, wh, "G")

        'If curqty > 0 Then
        '    nwqty = curqty - totpck
        'Else
        '    nwqty = 0
        'End If

        nwqty = curqty + totpck

        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE item=@itm AND whs=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        cmd.Parameters.AddWithValue("@qtyg", nwqty)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        nwqty = 0
        curqty = getcurqty(itc, wh, "B")
        nwqty = curqty - totpck
        cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@qtyg WHERE item=@itm AND whs=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        cmd.Parameters.AddWithValue("@qtyg", nwqty)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvGStoBOList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                If MsgBox("Are you sure you want to delete this transaction No: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then

                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("SELECT * FROM ivd WHERE transno=@tr And isdeleted = '0'", cdb)
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
                            .ihtcd = rd("item").ToString
                            .ihqty = rd("qty").ToString
                            .ihpckg = rd("pckg").ToString
                            .ihqunit = rd("qunit").ToString
                            .ihwhs = rd("whs").ToString
                            .ihwhs2 = rd("towhs").ToString
                            '.ihwhs2 = rd("towhs").ToString

                            iqunit = rd("qunit").ToString
                            iqty = rd("qty").ToString
                            ipckg = rd("pckg").ToString

                            'If iqunit = "C" Then
                            '    ipckg = rd("pckgc").ToString
                            '    .ihgoods = iqty * IIf(ipckg > 0, ipckg, 1)
                            'ElseIf iqunit = "B" Then
                            '    ipckg = rd("pckg").ToString
                            '    .ihgoods = iqty * IIf(ipckg > 0, ipckg, 1)
                            'ElseIf iqunit = "P" Then
                            '    rmvpckg = rd("pckgp").ToString
                            '    nwqt = nwqty * IIf(rmvpckg > 0, rmvpckg, 1)
                            '    nwqt = nwqt
                            'End If
                            If iqunit = "C" Or iqunit = "B" Then
                                .ihgoods = iqty * ipckg
                            ElseIf iqunit = "P" Then
                                .ihgoods = iqty
                            End If
                            '.ihgoods = convertpackaging_fromivitem(rd("item").ToString, Nothing, iqty, iqunit)


                        End With
                        rwuph += 1
                    End While
                    rd.Close()

                    Dim wh As String = Nothing
                    Dim wh2 As String = Nothing
                    Dim itc As String = Nothing
                    Dim ing As Decimal = 0

                    For x As Integer = 0 To rwuph - 1
                        ing = 0
                        wh = upthisitem(x).ihwhs
                        wh2 = upthisitem(x).ihwhs2
                        itc = upthisitem(x).ihtcd
                        ing = upthisitem(x).ihgoods

                        updwhsheader(wh, wh2, itc, ing)
                    Next

                    reset_upthisitem()

                    cmd = New MySqlCommand("UPDATE ivh SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd.Parameters.AddWithValue("@tr", mytrans)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New MySqlCommand("UPDATE ivd SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd.Parameters.AddWithValue("@tr", mytrans)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    MsgBox("GSBO Transactions No : " & mytrans & " successfully deleted", 64, "Deleted")
                    ' AuditTrail("Trans No.:" & mytrans & Space(2) & "PO. No.:" & tbPONo.Text & Space(2) & "Invoice No.:" & tbInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Delete Receiving Module")
                    'AuditTrail("Trans No.:" & mytrans & Space(2) & .Text, "Delete Receiving Module")
                    LoadGStoBOH()

                End If
            End If
        End With
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

    End Sub

    Private Sub dgvGStoBOList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGStoBOList.CellContentClick

    End Sub

    Private Sub dgvGStoBOList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGStoBOList.CellDoubleClick
        If dgvGStoBOList.RowCount > 0 Then
            btnEdit.PerformClick()
        End If

    End Sub
End Class