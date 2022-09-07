Imports MySql.Data.MySqlClient

Public Class frmReceivingH
    Dim sdate1 As String
    Dim sdate2 As String

    Private Sub frmReceivingH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            AddRcv_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub frmReceivingH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tag = 0
        LoadRcvh()
        LoadSupplier()

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
            cbxSupplier.Items.Add(New With {.Text = relr("suppliername").ToString(), .Value = relr("supcode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()

    End Sub

    Sub LoadRcvh()
        DgvRcvH.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM rcvingh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE isdeleted<>1 ORDER BY transno desc", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            DgvRcvH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("pono").ToString, rd.Item("tdate").ToString, _
                             rd.Item("invoiceno").ToString, rd.Item("warehouse").ToString, rd.Item("suppliername").ToString, _
                             Format(CDbl(rd.Item("netamount").ToString), "#,##0.00"), rd.Item("balance").ToString, _
                             rd.Item("paidon").ToString, rd.Item("user").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub AddRcv_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmReceivingD.ShowDialog()
    End Sub


    Private Sub DgvRcvH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRcvH.CellContentClick

        With DgvRcvH

            If .RowCount > 0 And e.RowIndex >= 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, e.RowIndex).Value
                If e.ColumnIndex = 11 Then
                    frmReceivingD.LoadSupplier()
                    frmReceivingD.LoadWarehouse()
                    frmReceivingD.RetrieveRcv(mytrans)
                    frmReceivingD.Tag = 1
                    frmReceivingD.cbxSupplier.Enabled = False
                    frmReceivingD.ShowDialog()

                ElseIf e.ColumnIndex = 12 Then
                    If MsgBox("Are you sure you want to delete this transaction No: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("UPDATE rcvingh SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Transactions No : " & mytrans & " successfully deleted", 64, "Deleted")
                        AuditTrail("Delete Receiving" & mytrans & Space(2) & cbxSupplier.Text, "Receiving Module")
                        LoadRcvh()
                    End If

                End If
            End If
        End With

    End Sub

    Private Sub DgvRcvH_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRcvH.CellDoubleClick
        btnEdit_Click(sender, e)
    End Sub

    Private Sub DgvRcvH_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRcvH.CellEnter

    End Sub

    Private Sub DgvRcvH_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvRcvH.KeyDown
        With DgvRcvH
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentRow.Index).Value

                If e.KeyCode = Keys.F7 Then
                    If MsgBox("Are you sure you want to delete this transaction No: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("UPDATE rcvingh SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Transactions No : " & mytrans & " successfully deleted", 64, "Deleted")
                        LoadRcvh()
                    End If
                End If
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

        nwqty = curqty - totpck

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
        With DgvRcvH
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim myinvoice As String = Nothing
                Dim myPono As String = Nothing


                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                myPono = .Item(2, .CurrentCell.RowIndex).Value
                myinvoice = .Item(4, .CurrentCell.RowIndex).Value

                If MsgBox("Are you sure you want to delete this Invoice No: " & myinvoice & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                    Dim checkopen As String()

                    checkopen = check_if_trans_is_open(mytrans, "rcvingh", _user)

                    If checkopen(0) = True Then
                        MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before deleting this transaction. ", 48, "TRANSACTION IS OPEN")

                    Else
                        Dim cmd As MySqlCommand

                        cmd = New MySqlCommand("SELECT * FROM rcvingd WHERE transno=@tr And isdeleted = '0'", cdb)
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

                        cmd = New MySqlCommand("UPDATE rcvingh SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        AuditTrail("Trans No.:" & Space(1) & mytrans & Space(2) & "PO. No.:" & Space(1) & myPono & Space(2) & "Invoice No.:" & Space(2) & myinvoice, "Delete Receiving")
                        MsgBox("Invoice No : " & myinvoice & " successfully deleted", 64, "Deleted")
                        LoadRcvh()
                    End If
                End If
                End If
        End With
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        With DgvRcvH
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmReceivingD.LoadSupplier()
                frmReceivingD.LoadWarehouse()
                frmReceivingD.RetrieveRcv(mytrans)
                frmReceivingD.Tag = 1
                frmReceivingD.cbxSupplier.Enabled = False
                frmReceivingD.RcvDisabled()
                frmReceivingD.ShowDialog()
            End If
        End With

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim i As Integer

        cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM rcvingh h " & _
                                "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                                "WHERE tdate >= '" & Format(dtpStart.Value, "yyyy-MM-dd") & "' and " & _
                                "tdate <= '" & Format(dtpEnd.Value, "yyyy-MM-dd") & "' ORDER BY tdate desc", cdb)
        rd = cmd.ExecuteReader
        DgvRcvH.Rows.Clear()
        While rd.Read
            i += 1
            DgvRcvH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("pono").ToString, rd.Item("tdate").ToString, _
                             rd.Item("invoiceno").ToString, rd.Item("warehouse").ToString, rd.Item("suppliername").ToString, _
                             Format(CDbl(rd.Item("netamount").ToString), "#,##0.00"), rd.Item("user").ToString) ' "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRcvh()
        txtSearch.Clear()
        cbxSupplier.SelectedIndex = -1
    End Sub

    Private Sub tbSearchRcv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown

    End Sub

    Private Sub tbSearchRcv_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        'tbSearchRcv.Clear()
    End Sub

    Private Sub cbxSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSupplier.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        If txtSearch.Text <> Nothing Then
            DgvRcvH.Rows.Clear()
            cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM rcvingh h " & _
                                   "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                                   "WHERE (invoiceno like '%" & txtSearch.Text & "%' or " & _
                                   "pono Like '%" & txtSearch.Text & "%') and isdeleted='0' ORDER BY tdate desc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                DgvRcvH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("pono").ToString, rd.Item("tdate").ToString, _
                           rd.Item("invoiceno").ToString, rd.Item("warehouse").ToString, rd.Item("suppliername").ToString, _
                           Format(CDbl(rd.Item("netamount").ToString), "#,##0.00"), rd.Item("user").ToString, _
                           rd.Item("paidon").ToString, rd.Item("balance").ToString, "Edit", "Delete")
            End While
            rd.Close()
        Else
            DgvRcvH.Rows.Clear()
            cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM rcvingh h " & _
                                   "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                                   "WHERE isdeleted<>1 ORDER BY tdate desc", cdb)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                DgvRcvH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("pono").ToString, rd.Item("tdate").ToString, _
                          rd.Item("invoiceno").ToString, rd.Item("warehouse").ToString, rd.Item("suppliername").ToString, _
                          Format(CDbl(rd.Item("netamount").ToString), "#,##0.00"), rd.Item("user").ToString, rd.Item("paidon").ToString, _
                          rd.Item("balance").ToString, "Edit", "Delete")

            End While
            rd.Close()

        End If

    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged
        Dim i As Integer
        DgvRcvH.Rows.Clear()
        cmd = New MySqlCommand("SELECT h.*,w.warehouse,s.suppliername FROM rcvingh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                               "WHERE suppliername like '%" & cbxSupplier.Text & "%' and isdeleted<>1 " & _
                               "ORDER BY tdate desc", cdb)

        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            DgvRcvH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("pono").ToString, rd.Item("tdate").ToString, _
                           rd.Item("invoiceno").ToString, rd.Item("warehouse").ToString, rd.Item("suppliername").ToString, _
                           Format(CDbl(rd.Item("netamount").ToString), "#,##0.00"), rd.Item("user").ToString, _
                           rd.Item("paidon").ToString, rd.Item("balance").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub
End Class