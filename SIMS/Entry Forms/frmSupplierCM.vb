Imports MySql.Data.MySqlClient

Public Class frmSupplierCM

    Private Sub NewCM_Click(sender As Object, e As EventArgs)

    End Sub
    Dim lastitemsel As String = Nothing

    Sub SaveSupCM()
        'save supplier cm
        cmdmtype = "C"
        Dim cmd As MySqlCommand

        cmd = New MySqlCommand("INSERT INTO supcmdm (transno,date,ttype,docno,supcode,user,amount,balance,remarks1,remarks2,remarks3,remarks4) VALUES (@tno,@cd,@tt,@docno,@sup,@user,@amt,@bal,@rem1,@rem2,@rem3,@rem4)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", tbTransnoCM.Text)
            cmd.Parameters.AddWithValue("@cd", dtpCMDate.Value)
            cmd.Parameters.AddWithValue("@tt", cmdmtype)
            cmd.Parameters.AddWithValue("@docno", tbCMNo.Text)
            cmd.Parameters.AddWithValue("@sup", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@user", tbUser.Text)
            cmd.Parameters.AddWithValue("@amt", Decimal.Parse(tbCMAmount.Text))
            cmd.Parameters.AddWithValue("@bal", Decimal.Parse(tbCMAmount.Text))
            cmd.Parameters.AddWithValue("@rem1", tbRem1.Text)
            cmd.Parameters.AddWithValue("@rem2", tbRem2.Text)
            cmd.Parameters.AddWithValue("@rem3", tbRem3.Text)
            cmd.Parameters.AddWithValue("@rem4", tbRem4.Text)

        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub GetTransSupplierCM()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        cqry = "Select transno as tno FROM supcmdm ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While
            rcvtno = Strings.Right(mdr("tno").ToString, 9) + 1
            rcvtno = "C" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If

        If rcnt = 0 Then
            rcvtno = "C000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        tbTransnoCM.Text = rcvtno
    End Sub

    Private Sub frmSupplierCM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub

    Private Sub frmSupplierCM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            LoadSupplierCM()
            CM_LoadSupplier()
            ClearCM()
            '  disableCM()
            btnSavePrint.Enabled = False
            btnSave.Enabled = False
            btnNew.Enabled = True
            dgvSupplierCM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmSupplierCM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tbUser.Text = Nothing Then
            tbUser.Text = str_user
        End If

        btnSavePrint.Enabled = False
        btnSave.Enabled = False

        LoadSupplierCM()
        CM_LoadSupplier()
        dgvSupplierCM.Focus()

        ' disableCM()

        If Me.Tag = 0 Then
            'LoadSupplierCM()
            'LoadSupplier()
        End If

    End Sub

    Private Sub SaveCM_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'orig
        If tbCMNo.Text = Nothing And tbCMAmount.Text = Nothing And cbxSupplier.Text = Nothing Then
            MsgBox("Pls Complete Missing Field!", vbCritical)
            Exit Sub
        End If

        If btnSave.Text = "U&pdate" Then
            UpdateSupCM()
            MsgBox("Supplier credit memo has been successfully updated.", vbInformation)
            btnSave.Text = "S&ave"
        Else
            If CheckSupCMNo() = True Then
                MsgBox("Supplier credit memo already exist!", 48, "Enter Supplier Credit Memo")
                Exit Sub
            End If

            GetTransSupplierCM()
            SaveSupCM()
            MsgBox("Supplier Credit Memo has been Successfully saved.", vbInformation)
        End If

        ClearCM()
        LoadSupplierCM()
    End Sub

    Sub ClearCM()
        dtpCMDate.Value = Date.Now
        tbTransnoCM.Clear()
        tbCMNo.Clear()
        tbCMAmount.Clear()
        cbxSupplier.Text = Nothing
        tbSupplierName.Clear()
        tbRem1.Clear()
        tbRem2.Clear()
        tbRem3.Clear()
        tbRem4.Clear()
        tbSearchCM.Clear()
        tbSearchCM.Focus()
    End Sub

    Sub LoadSupplierCM()

        Dim qry As String = Nothing
        With dgvSupplierCM
            .Rows.Clear()

            qry = "SELECT h.*,s.suppliername FROM supcmdm h LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                  "WHERE ttype='C' and isdeleted<>1 ORDER BY date desc"
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
                            .Item(2, r).Value = rdr("date").ToString
                            .Item(3, r).Value = rdr("ttype").ToString
                            .Item(4, r).Value = rdr("docno").ToString
                            .Item(5, r).Value = rdr("supcode").ToString
                            .Item(6, r).Value = rdr("suppliername").ToString
                            .Item(7, r).Value = Format(CDbl(rdr("amount").ToString), "#,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("balance").ToString), "#,#00.00")
                            .Item(9, r).Value = rdr("user").ToString
                            .Item(12, r).Value = rdr("remarks1").ToString
                            .Item(13, r).Value = rdr("remarks2").ToString
                            .Item(14, r).Value = rdr("remarks3").ToString
                            .Item(15, r).Value = rdr("remarks4").ToString
                        End While
                    End If
                End Using
            End Using
        End With
    End Sub

    Sub CM_LoadSupplier()
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

    Private Sub cbxSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSupplier.KeyPress
        If e.KeyChar = vbCr Then
            tbRem1.Focus()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tbCMAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCMAmount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select

        Dim cmamt As Decimal = 0
        If e.KeyChar = vbCr Then
            cmamt = myd(tbCMAmount.Text)
            tbCMAmount.Text = Format(cmamt, sFmat)
            cbxSupplier.Focus()
        End If

    End Sub

    Private Sub tbCMNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCMNo.KeyPress
        If e.KeyChar = vbCr Then
            tbCMAmount.Focus()
        End If
    End Sub

    Function CheckSupCMNo()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT docno FROM supcmdm WHERE docno = @docno", cdb)
        With cmd
            .Parameters.AddWithValue("@docno", tbCMNo.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "'", cdb)
        Using rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                tbSupplierName.Text = rd.Item("suppliername").ToString
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub dgvSupplierCM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierCM.CellClick

        With dgvSupplierCM
            If .RowCount > 0 And e.RowIndex >= 0 Then
                tbTransnoCM.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(1).Value.ToString
                dtpCMDate.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(2).Value.ToString
                tbCMNo.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(4).Value.ToString
                cbxSupplier.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(5).Value.ToString
                tbSupplierName.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(6).Value.ToString
                tbCMAmount.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(7).Value.ToString
                tbUser.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(9).Value.ToString
                tbRem1.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(12).Value.ToString
                tbRem2.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(13).Value.ToString
                tbRem3.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(14).Value.ToString
                tbRem4.Text = dgvSupplierCM.Rows(e.RowIndex).Cells(15).Value.ToString

                lastitemsel = dgvSupplierCM.Rows(e.RowIndex).Cells(4).Value.ToString

                btnSave.Enabled = True
                btnSavePrint.Enabled = True

                btnSave.Text = "U&pdate"
                btnSavePrint.Text = "Update+P&rint"

                btnSave.ToolTipText = "U&pdate"
                btnSavePrint.ToolTipText = "Update+P&rint"
            End If
        End With

    End Sub

    Private Sub dgvSupplierCM_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSupplierCM.KeyDown
        With dgvSupplierCM
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(4, .CurrentRow.Index).Value
                If e.KeyCode = Keys.F7 Then
                    If MsgBox("Delete Supplier C.M. " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                        Dim cmd As MySqlCommand
                        cmd = New MySqlCommand("UPDATE supcmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                        cmd.Parameters.AddWithValue("@tr", mytrans)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MsgBox("Supplier Credit Memo has been Successfully Deleted!", vbInformation)
                        LoadSupplierCM()
                    End If
                End If
            End If

            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
                SendKeys.Send("{enter}")
            End If
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
                SendKeys.Send("{enter}")
            End If
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                dgvSupplierCM_CellClick(1, New DataGridViewCellEventArgs(0, dgvSupplierCM.CurrentRow.Index))
            End If
        End With
    End Sub

    Private Sub NewSupCM_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        dtpCMDate.Value = Date.Now
        tbTransnoCM.Clear()
        tbCMNo.Clear()
        tbCMAmount.Clear()
        cbxSupplier.Text = Nothing
        tbSupplierName.Clear()
        tbRem1.Clear()
        tbRem2.Clear()
        tbRem3.Clear()
        tbRem4.Clear()
        tbCMNo.Focus()

        btnSave.Text = "S&ave"
        btnSavePrint.Text = "Sa&ve+Print"


        btnSave.Enabled = True
        btnSavePrint.Enabled = True
    End Sub

    Private Sub tbSupplierName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSupplierName.KeyPress
        e.Handled = True
    End Sub

    Sub disableCM()
        dtpCMDate.Enabled = False
        tbTransnoCM.Enabled = False
        tbCMNo.Enabled = False
        tbCMAmount.Enabled = False
        cbxSupplier.Enabled = False
        tbSupplierName.Enabled = False
        tbRem1.Enabled = False
        tbRem2.Enabled = False
        tbRem3.Enabled = False
        tbRem4.Enabled = False
        tbCMNo.Enabled = False
        tbUser.Enabled = False
    End Sub

    Sub enableCM()
        dtpCMDate.Value = Date.Now
        tbTransnoCM.Enabled = True
        tbCMNo.Enabled = True
        tbCMAmount.Enabled = True
        cbxSupplier.Enabled = True
        tbSupplierName.Enabled = True
        tbRem1.Enabled = True
        tbRem2.Enabled = True
        tbRem3.Enabled = True
        tbRem4.Enabled = True
        tbCMNo.Enabled = True
        tbUser.Enabled = True
    End Sub

    Private Sub tsRereshCM_Click(sender As Object, e As EventArgs) Handles tsRereshCM.Click
        LoadSupplierCM()
        CM_LoadSupplier()
        ClearCM()
        btnSave.Text = "Save"
        btnSavePrint.Text = "Save+Print"
        dgvSupplierCM.Focus()
    End Sub

    Private Sub tsUpdateCM_Click(sender As Object, e As EventArgs)
        If MsgBox("Update this Supplier Credit Memo?", vbYesNo + vbQuestion) = vbYes Then
            UpdateSupCM()
            MsgBox("Supplier Credit Memo has been Successfully Updated.", vbInformation)
        End If

    End Sub

    Sub UpdateSupCM()
        'update supcmdm
        Dim cmd As MySqlCommand
        cmdmtype = "C"
        cmd = New MySqlCommand("UPDATE supcmdm  SET date=@cd,ttype=@tt,docno=@docno,supcode=@sup,user=@user, " & _
                                   "amount=@amt,balance=@bal,remarks1=@rem1,remarks2=@rem2,remarks3=@rem3,remarks4=@rem4 WHERE transno=@tno", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", tbTransnoCM.Text)
            cmd.Parameters.AddWithValue("@cd", dtpCMDate.Value)
            cmd.Parameters.AddWithValue("@tt", cmdmtype)
            cmd.Parameters.AddWithValue("@docno", tbCMNo.Text)
            cmd.Parameters.AddWithValue("@sup", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@user", tbUser.Text)
            cmd.Parameters.AddWithValue("@amt", Decimal.Parse(tbCMAmount.Text))
            cmd.Parameters.AddWithValue("@bal", Decimal.Parse(tbCMAmount.Text))
            cmd.Parameters.AddWithValue("@rem1", tbRem1.Text)
            cmd.Parameters.AddWithValue("@rem2", tbRem2.Text)
            cmd.Parameters.AddWithValue("@rem3", tbRem3.Text)
            cmd.Parameters.AddWithValue("@rem4", tbRem4.Text)
            cmd.ExecuteNonQuery()
        End With
        cmd.Dispose()
    End Sub

    Private Sub DeleteSupCM_Click(sender As Object, e As EventArgs) Handles DeleteSupCM.Click
        With dgvSupplierCM
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(4, .CurrentRow.Index).Value
                If MsgBox("Delete Supplier C.M.: " & mytrans & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("UPDATE supcmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd.Parameters.AddWithValue("@tr", mytrans)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Supplier Credit Memo has been Successfully Deleted!", vbInformation)
                    LoadSupplierCM()
                End If
            End If
        End With
    End Sub

    Private Sub tbSearchCM_TextChanged(sender As Object, e As EventArgs) Handles tbSearchCM.TextChanged

        If tbSearchCM.Text <> Nothing Then
            Dim qry As String = Nothing
            With dgvSupplierCM
                .Rows.Clear()

                qry = "SELECT h.*,s.suppliername FROM supcmdm h LEFT JOIN supplier s ON h.supcode=s.supcode WHERE ttype='C' and isdeleted<>1 and docno like '%" & tbSearchCM.Text & "%'ORDER BY suppliername asc"
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
                                .Item(2, r).Value = rdr("date").ToString
                                .Item(3, r).Value = rdr("ttype").ToString
                                .Item(4, r).Value = rdr("docno").ToString
                                .Item(5, r).Value = rdr("supcode").ToString
                                .Item(6, r).Value = rdr("suppliername").ToString
                                .Item(7, r).Value = Format(CDbl(rdr("amount").ToString), "#,#00.00")
                                .Item(8, r).Value = Format(CDbl(rdr("balance").ToString), "#,#00.00")
                                .Item(9, r).Value = rdr("user").ToString
                                .Item(12, r).Value = rdr("remarks1").ToString
                                .Item(13, r).Value = rdr("remarks2").ToString
                                .Item(14, r).Value = rdr("remarks3").ToString
                                .Item(15, r).Value = rdr("remarks4").ToString
                            End While
                        End If
                    End Using
                End Using
            End With
        End If

    End Sub

    Sub PrintSupCM()
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        mmax = 1
        pbar1.Maximum = mmax

        dtc.Rows.Clear()
        Dim chkflag As Boolean = False
        'grpno = 10
        grpno = 25
        Dim cntr As Integer = 0
        Dim grid As Integer = 1

        pbar1.Value += 1
        cntr += 1
        r1 = dtc.NewRow()

        r1("dates") = dtpCMDate.Value.ToString("MM/dd/yyyy")
        r1("transno") = tbTransnoCM.Text.ToString
        r1("docno") = tbCMNo.Text.ToString
        'r1("supcode") = cbxSupplier.Text.ToString
        r1("supplier") = tbSupplierName.Text.ToString
        r1("amount") = tbCMAmount.Text.ToString
        r1("user") = tbUser.Text.ToString
        r1("remarks1") = tbRem1.Text.ToString
        r1("remarks2") = tbRem2.Text.ToString
        r1("remarks3") = tbRem3.Text.ToString
        r1("remarks4") = tbRem4.Text.ToString

        'r1("grpno") = grid

        pbar1.Refresh()
        dtc.Rows.Add(r1)
        ' pbar1.Refresh()
        If cntr = grpno Then
            grid += 1
            cntr = 0
        End If
        'Next
        'pbar1.Visible = False
        prep = New supcmReport
        prep.SetDataSource(ds)
        frmReport.CRportRcv.ReportSource = prep
        frmReport.CRportRcv.Refresh()
        frmReport.Dock = DockStyle.Fill
        frmReport.Show()
        pbar1.Visible = False

        'Else()
        'MsgBox("No records found to print!", 48, "Insufficient Rows!")
        'End If
        ' End With

    End Sub

    Private Sub tsSavePrintCM_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If tbCMNo.Text = Nothing And tbCMAmount.Text = Nothing And cbxSupplier.Text = Nothing Then
            MsgBox("Pls Complete Missing Field!", vbCritical)
            Exit Sub
        End If


        If btnSavePrint.Text = "Update+P&rint" Then
            UpdateSupCM()
            MsgBox("Supplier Credit Memo has been Successfully updated.", vbInformation)
            btnSavePrint.Text = "Sa&ve+Print"
        Else
            If CheckSupCMNo() = True Then
                MsgBox("Supplier Credit Memo Already Exist!", 48, "Enter Supplier Credit Memo")
                Exit Sub
            End If

            GetTransSupplierCM()

            SaveSupCM()
            MsgBox("Supplier Credit Memo has been Successfully saved.", vbInformation)
        End If

        LoadSupplierCM()
        If lastitemsel <> Nothing Then
            With dgvSupplierCM
                For i = 0 To .RowCount - 1
                    If .Item(4, i).Value <> Nothing And .Item(4, i).Value = lastitemsel Then
                        .CurrentCell = .Item(4, i)
                    End If
                Next
            End With

        End If
        'ClearCM()

        PrintSupCM()

    End Sub

    Private Sub tsUpdatePrintCM_Click(sender As Object, e As EventArgs)
        If MsgBox("Update this Supplier Credit Memo?", vbYesNo + vbQuestion) = vbYes Then
            UpdateSupCM()
            MsgBox("Supplier Credit Memo has been Successfully Updated.", vbInformation)
            PrintSupCM()
        End If
    End Sub

    Private Sub tbRem1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRem1.KeyPress
        If e.KeyChar = vbCr Then
            tbRem2.Focus()
        End If
    End Sub

    Private Sub tbRem2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRem2.KeyPress
        If e.KeyChar = vbCr Then
            tbRem3.Focus()
        End If
    End Sub

    Private Sub tbRem3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRem3.KeyPress
        If e.KeyChar = vbCr Then
            tbRem4.Focus()
        End If
    End Sub

    Private Sub tsPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If tbCMNo.Text.Trim <> Nothing Then
            PrintSupCM()
        Else
            MsgBox("Select Record to Print", vbExclamation)
        End If
    End Sub

    Private Sub dgvSupplierCM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierCM.CellContentClick

    End Sub

    Private Sub tbCMNo_MarginChanged(sender As Object, e As EventArgs) Handles tbCMNo.MarginChanged

    End Sub

    Private Sub tbCMNo_TextChanged(sender As Object, e As EventArgs) Handles tbCMNo.TextChanged

    End Sub

    Private Sub tbCMAmount_TextChanged(sender As Object, e As EventArgs) Handles tbCMAmount.TextChanged

    End Sub

    Private Sub tsSupplierCM_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsSupplierCM.ItemClicked

    End Sub
End Class