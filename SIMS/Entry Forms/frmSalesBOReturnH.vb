Imports MySql.Data.MySqlClient

Public Class frmSalesBOReturnH

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmSalesBOReturnD.ShowDialog()
    End Sub

    Private Sub frmSalesBOReturnH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            frmSalesBOReturnD.ShowDialog()
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmSalesBOReturnH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        LoadBOReturnHeader()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvInvoiceList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmSalesBOReturnD.RetrieveBOReturn(mytrans)
                frmSalesBOReturnD.Tag = 1
                frmSalesBOReturnD.tsSave.Visible = False
                frmSalesBOReturnD.tsUpdate.Visible = True
                frmSalesBOReturnD.btnUpdate.Enabled = False
                frmSalesBOReturnD.btnUpdatePrint.Enabled = False
                frmSalesBOReturnD.Disabler()
                frmSalesBOReturnD.ShowDialog()
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvInvoiceList
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim myinvoice As String = Nothing

                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                myinvoice = .Item(2, .CurrentCell.RowIndex).Value

                If MsgBox("Are you sure you want to delete this Return No: " & myinvoice & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then

                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("SELECT * FROM salesd WHERE transno=@tr And isdeleted = '0'", cdb)
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
                            .ihqunit = rd("unit").ToString
                            .ihwhs = rd("whscode").ToString

                            iqunit = rd("unit").ToString
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

                    cmd = New MySqlCommand("UPDATE salesh SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd.Parameters.AddWithValue("@tr", mytrans)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd.Parameters.AddWithValue("@tr", mytrans)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    MsgBox("BO Return No: " & myinvoice & " successfully deleted", 64, "Deleted")
                    ' AuditTrail("Trans No.:" & mytrans & Space(2) & "PO. No.:" & tbPONo.Text & Space(2) & "Invoice No.:" & tbInvoiceNo.Text & Space(2) & "Supplier:" & cbxSupplier.Text, "Delete Receiving Module")
                    'AuditTrail("Trans No.:" & mytrans & Space(2) & .Text, "Delete Receiving Module")
                    LoadBOReturnHeader()
                End If
            End If
        End With
    End Sub

    Private Sub dgvInvoiceList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceList.CellContentClick
        With dgvInvoiceList

            If .RowCount > 0 And e.RowIndex >= 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, e.RowIndex).Value
                If e.ColumnIndex = 11 Then
                    frmSalesBOReturnD.RetrieveBOReturn(mytrans)
                    frmSalesBOReturnD.Tag = 1
                    frmSalesBOReturnD.ShowDialog()

                ElseIf e.ColumnIndex = 12 Then
                    If MsgBox("Are you sure you want to delete this transaction No: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        cmd = New MySqlCommand("UPDATE salesd SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Transactions No : " & mytrans & " successfully deleted", 64, "Deleted")
                        'AuditTrail("Delete Receiving" & mytrans & Space(2) & cbxSupplier.Text, "Receiving Module")
                        LoadBOReturnHeader()
                    End If
                End If
            End If
        End With

    End Sub

    Private Sub dgvInvoiceList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceList.CellDoubleClick
        btnEdit_Click(sender, e)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        cbxViewPaid.Checked = False
        LoadBOReturnHeader()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cbxViewPaid.Checked = True Then
            SearchLoadBOReturnHeaderPaid()
        Else
            SearchLoadBOReturnHeader()
        End If

    End Sub

    Sub SearchLoadBOReturnHeaderPaid()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()

            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE (custname like '%" & txtSearch.Text & "%' or " & _
                                   "invoiceno like '%" & txtSearch.Text & "%' ) and  h.isdeleted<>1 and ttype='B' " & _
                                   "AND applied<>'0' and totalamt=applied ORDER BY transno desc limit 100"
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("idate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Sub SearchLoadBOReturnHeader()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()

            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE (custname like '%" & txtSearch.Text & "%' or " & _
                                   "invoiceno like '%" & txtSearch.Text & "%' ) and  h.isdeleted<>1 and ttype='B' " & _
                                   "AND applied>='0' and applied<totalamt ORDER BY transno desc limit 100"
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("idate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If cbxViewPaid.Checked = True Then
            LoadBOReturnHeaderByDateRangePaid()
        Else
            LoadBOReturnHeaderByDateRange()
        End If

        'Dim i As Integer = 0
        'dgvInvoiceList.Rows.Clear()
        'cmd = New MySqlCommand("SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
        '                       "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c ON " & _
        '                       "h.custcode=c.custcode WHERE idate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' and " & _
        '                       "idate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' and ttype='B' and isdeleted <> 1 order by transno desc limit 300", cdb)
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    i += 1
        '    dgvInvoiceList.Rows.Add(i, rd.Item("transno").ToString, rd.Item("invoiceno").ToString, rd.Item("idate").ToString, _
        '                            rd.Item("custname").ToString, rd.Item("slmncode").ToString, rd.Item("whscode").ToString, _
        '                            Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), _
        '                            Format(CDbl(rd.Item("balance").ToString), "#,##0.00"), _
        '                            rd.Item("idate").ToString, rd.Item("user").ToString)
        'End While
        'rd.Close()
    End Sub

    Sub LoadBOReturnHeaderByDateRangePaid()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE idate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
                                   "and idate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' and h.isdeleted<>1 and ttype='B' " & _
                                    "AND totalamt=applied ORDER BY transno desc limit 100"

            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("idate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Sub LoadBOReturnHeaderByDateRange()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE idate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
                                   "and idate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "'and h.isdeleted<>1 and ttype='B' " & _
                                   "ORDER BY transno desc limit 100"
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("idate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
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

    Private Sub updwhsheader(ByVal wh As String, ByVal itc As String, ByVal totpck As Decimal)

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0

        curqty = 0
        nwqty = 0

        cmd = New MySqlCommand("SELECT item,qty_bo FROM ivwh WHERE item=@itm AND whs=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                curqty = rd("qty_bo").ToString
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

        cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@qtyb WHERE item=@itm AND whs=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        cmd.Parameters.AddWithValue("@qtyb", nwqty)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Private Sub cbxViewPaid_CheckedChanged(sender As Object, e As EventArgs) Handles cbxViewPaid.CheckedChanged
        If cbxViewPaid.Checked = True Then
            LoadBOReturnHeaderPaid()
        Else
            LoadBOReturnHeader()
        End If
    End Sub

    Sub LoadBOReturnHeaderPaid()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                   "ON h.custcode=c.custcode WHERE h.isdeleted<>1 and ttype='B' " & _
                                    "AND applied<>'0' and totalamt=applied ORDER BY transno desc limit 100"

            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("idate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Sub LoadBOReturnHeader()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                  "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                  "ON h.custcode=c.custcode WHERE h.isdeleted<>1 and ttype='B' " & _
                                   "AND applied>='0' and applied<totalamt ORDER BY transno desc limit 100"

            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("custname").ToString
                            .Item(5, r).Value = rdr("slmncode").ToString
                            .Item(6, r).Value = rdr("whscode").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("totalamt").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("applied").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(7, r).Value - .Item(8, r).Value
                            .Item(10, r).Value = rdr("pdate").ToString
                            .Item(11, r).Value = rdr("user").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub
End Class