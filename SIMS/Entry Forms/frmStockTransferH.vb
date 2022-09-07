Imports MySql.Data.MySqlClient

Public Class frmStockTransferH

    Private Sub frmStockTransferH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmTransferH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        LoadStockTransferH()

    End Sub

    Sub LoadStockTransferH()
        With dgvTransferList
            dgvTransferList.Rows.Clear()
            Dim i As Integer
            'Dim rw As Integer
            'Dim x As Integer
            'Dim w1 As String
            'Dim w2 As String

            cmd = New MySqlCommand("SELECT h.*,s.* FROM ivh h LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                                   "WHERE ttype='T' and isdeleted<>1  ORDER BY tdate desc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvTransferList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                                 rd.Item("whscode").ToString, rd.Item("whsfromname").ToString, _
                                 rd.Item("towhs").ToString, rd.Item("whstoname").ToString, _
                                 Format(CDbl(rd.Item("total").ToString), "#,##0.00"), rd.Item("userid").ToString)
            End While
            rd.Close()
            cmd.Dispose()

        End With
    End Sub


    Private Sub AddTransfer_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        With frmStockTransferD
            .ShowDialog()
        End With

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvTransferList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmStockTransferD.LoadSupplier()
                frmStockTransferD.LoadWarehouse()
                frmStockTransferD.RetrieveStockTransfer(mytrans)
                frmStockTransferD.Tag = 1
                frmStockTransferD.cboSupplier.Enabled = False
                frmStockTransferD.tsSave.Visible = False
                frmStockTransferD.tsUpdate.Visible = True
                frmStockTransferD.btnSearch.Enabled = False
                frmStockTransferD.ShowDialog()
            End If
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadStockTransferH()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvTransferList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim mydate As String = Nothing
                Dim transferfrom As String = Nothing
                Dim transferto As String = Nothing

                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                mydate = .Item(2, .CurrentCell.RowIndex).Value
                transferfrom = .Item(3, .CurrentCell.RowIndex).Value
                transferto = .Item(5, .CurrentCell.RowIndex).Value

                If MsgBox("Are you sure you want to delete this transaction No: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                    Dim checkopen As String()

                    checkopen = check_if_trans_is_open(mytrans, "ivh", _user)

                    If checkopen(0) = True Then
                        MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before deleting this transaction. ", 48, "TRANSACTION IS OPEN")

                    Else
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
                                .ihtcd = rd("itemcode").ToString
                                .ihqty = rd("qty").ToString
                                .ihpckg = rd("pckg").ToString
                                .ihqunit = rd("qunit").ToString
                                .ihwhs = rd("whscode").ToString
                                .ihwhs2 = rd("towhs").ToString
                                '.ihwhs2 = rd("towhs").ToString

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
                        Dim wh2 As String = Nothing
                        Dim itc As String = Nothing
                        Dim ing As Decimal = 0

                        For x As Integer = 0 To rwuph - 1
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
                        AuditTrail("Transno.:" & Space(1) & mytrans & Space(2) & "Date: " & Space(1) & mydate & Space(2) & "From:" & Space(1) & transferfrom & Space(2) & "To:" & Space(2) & transferto, "Delete Stock Transfer")
                        MsgBox("Transactions No : " & mytrans & " successfully deleted", 64, "Deleted")
                        LoadStockTransferH()
                    End If
                End If
                End If
        End With
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

        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        cmd.Parameters.AddWithValue("@qtyg", nwqty)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        nwqty = 0
        curqty = getcurqty(itc, wh2, "G")
        nwqty = curqty - totpck
        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh2)
        cmd.Parameters.AddWithValue("@qtyg", nwqty)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
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

    Private Sub dgvTransferList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransferList.CellContentClick

    End Sub

    Private Sub dgvTransferList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransferList.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged

    End Sub
End Class