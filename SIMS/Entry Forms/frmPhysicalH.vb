Imports MySql.Data.MySqlClient

Public Class frmPhysicalH

    Private Sub AddTransfer_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmPhysicalD.ShowDialog()
    End Sub

    Private Sub frmPhysicalH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit.PerformClick()
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "PHYSICAL INVENTORY") = vbYes Then
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub frmPhysicalH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        LoadPhyivH()

    End Sub

    Sub LoadPhyivH()
        dgvPhyivH.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT h.*,w.warehouse FROM phyivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "WHERE isdeleted<>1 ORDER BY transno desc", cdb)

        rd = cmd.ExecuteReader
        While rd.Read
            i += 1

            dgvPhyivH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("tdate").ToString, _
                             rd.Item("whscode").ToString, rd.Item("whsname").ToString, _
                             rd.Item("remarks").ToString, rd.Item("user").ToString, _
                             rd.Item("posted").ToString)
        End While
        rd.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPhyivH()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvPhyivH
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmPhysicalD.LoadWarehouse()
                frmPhysicalD.RetrievePhyivD(mytrans)
                frmPhysicalD.Tag = 1
                frmPhysicalD.ShowDialog()
            End If
        End With
    End Sub

    Private Sub dgvPhyivH_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhyivH.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

    Private Sub dgvPhyivH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhyivH.CellContentClick

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvPhyivH
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim tposted As String = Nothing

                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                tposted = .Item(7, .CurrentCell.RowIndex).Value
                'mybal = .Item(9, .CurrentCell.RowIndex).Value

                If MsgBox("Are you sure you want to delete this physical transaction: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then

                    If tposted = "Y" Then
                        MsgBox("Cannot delete posted transation!", vbExclamation, "Physical Inventory")
                        Exit Sub
                    Else
                        Dim checkopen As String()

                        checkopen = check_if_trans_is_open(mytrans, "phyivh", _user)

                        If checkopen(0) = True Then
                            MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before deleting this transaction. ", 48, "TRANSACTION IS OPEN")

                        Else
                            

                            cmd = New MySqlCommand("UPDATE phyivh SET isdeleted=1 WHERE transno=@tr", cdb)
                            cmd.Parameters.AddWithValue("@tr", mytrans)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            cmd = New MySqlCommand("UPDATE phyivd SET isdeleted=1 WHERE transno=@tr", cdb)
                            cmd.Parameters.AddWithValue("@tr", mytrans)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            MsgBox("Transaction No: " & mytrans & " successfully deleted", 64, "Deleted")
                            ' AuditTrail("Trans No.:" & mytrans & Space(2) & "PO. No.:" & tbPONo.Text & Space(2) & "Invoice No.:" & tbInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Delete Receiving Module")
                            'AuditTrail("Trans No.:" & mytrans & Space(2) & .Text, "Delete Receiving Module")
                            'LoadSalesHeader()
                            LoadPhyivH()
                        End If
                    End If
                End If
            End If

        End With

    End Sub
End Class