Imports MySql.Data.MySqlClient

Public Class frmStockOutH

    Private Sub frmStockOutH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit_Click(sender, e)
            e.Handled = True
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            If MsgBox("Are You want to Quit?", vbYesNo + vbQuestion, "Misc. Stock Out List") = vbYes Then
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub frmStockOutH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        LoadStockOut()

    End Sub

    Sub LoadStockOut()
        dgvStockOutList.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM ivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE ttype='O' AND isdeleted<>1 ORDER BY transno desc LIMIT 1000", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvStockOutList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                             rd.Item("warehouse").ToString, Format(CDbl(rd.Item("total").ToString), "#,##0.00"), rd.Item("userid").ToString)
        End While
        rd.Close()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmStockOutD
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvStockOutList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockOutList.CellContentClick

    End Sub

    Private Sub dgvStockOutList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockOutList.CellDoubleClick
        With dgvStockOutList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmStockOutD.LoadSupplier()
                frmStockOutD.LoadWarehouse()
                frmStockOutD.RetrieveStockOut(mytrans)
                frmStockOutD.Tag = 1
                frmStockOutD.cboSupplier.Enabled = False
                frmStockOutD.tsSave.Visible = False
                frmStockOutD.tsUpdate.Visible = True
                frmStockOutD.btnSearch.Enabled = False
                frmStockOutD.ShowDialog()
            End If
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvStockOutList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmStockOutD.LoadSupplier()
                frmStockOutD.LoadWarehouse()
                frmStockOutD.RetrieveStockOut(mytrans)
                frmStockOutD.Tag = 1
                frmStockOutD.cboSupplier.Enabled = False
                frmStockOutD.tsSave.Visible = False
                frmStockOutD.tsUpdate.Visible = True
                frmStockOutD.btnSearch.Enabled = False
                frmStockOutD.ShowDialog()
            End If
        End With
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvStockOutList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim mydate As String = Nothing
                Dim mywhs As String = Nothing

                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                mydate = .Item(2, .CurrentCell.RowIndex).Value
                mywhs = .Item(3, .CurrentCell.RowIndex).Value

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

                        cmd = New MySqlCommand("UPDATE ivh SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE ivd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        AuditTrail("Trans No.:" & Space(1) & mytrans & Space(2) & "Date: " & Space(2) & mydate & "Warehouse:" & Space(1) & mywhs, "Delete Misc. Stock Out")
                        MsgBox("Transactions No : " & mytrans & " successfully deleted", 64, "Deleted")
                        ' AuditTrail("Trans No.:" & mytrans & Space(2) & "PO. No.:" & tbPONo.Text & Space(2) & "Invoice No.:" & tbInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Delete Receiving Module")
                        'AuditTrail("Trans No.:" & mytrans & Space(2) & .Text, "Delete Receiving Module")
                        LoadStockOut()

                    End If
                End If
                End If
        End With
    End Sub

    Private Sub tsStockOut_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsStockOut.ItemClicked

    End Sub

    Private Sub tbSearchStockOut_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        If txtSearch.Text <> Nothing Then
            dgvStockOutList.Rows.Clear()
            cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM ivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE (warehouse like '%" & txtSearch.Text & "%') and isdeleted<>1 and ttype='O' ORDER BY tdate desc LIMIT 1000", cdb)

            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvStockOutList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                                 rd.Item("warehouse").ToString, Format(CDbl(rd.Item("total").ToString), "#,##0.00"), rd.Item("userid").ToString)
            End While
            rd.Close()

        Else
            dgvStockOutList.Rows.Clear()
            cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM ivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE ttype='O' and isdeleted<>1 ORDER BY tdate desc LIMIT 1000", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvStockOutList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                                 rd.Item("warehouse").ToString, Format(CDbl(rd.Item("total").ToString), "#,##0.00"), rd.Item("userid").ToString)
            End While
            rd.Close()
        End If
    End Sub

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click

        Dim i As Integer = 0
        cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM ivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE (tdate >= '" & Format(dtpS1.Value, "yyyy-MM-dd") & "' and tdate <= '" & Format(dtpS2.Value, "yyyy-MM-dd") & "') and isdeleted='0' ORDER BY transno desc", cdb)

        rd = cmd.ExecuteReader
        dgvStockOutList.Rows.Clear()
        While rd.Read
            i += 1
            dgvStockOutList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                                rd.Item("warehouse").ToString, Format(CDbl(rd.Item("total").ToString), "#,##0.00"), rd.Item("userid").ToString)
        End While
        rd.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadStockOut()
    End Sub
End Class