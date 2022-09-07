Imports MySql.Data.MySqlClient

Public Class frmSupplierDM

    Dim lastitemsel As String = Nothing

    Private Sub frmSupplierDM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            LoadSupplierDM()
            DM_LoadSupplier()
            ClearDM()
            '  disableCM()
            tsSavePrintDM.Enabled = False
            tsSaveDM.Enabled = False
            tsNewSupDM.Enabled = True
            dgvSupplierDM.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmSupplierDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tbUser.Text = Nothing Then
            tbUser.Text = str_user
        End If

        tsSavePrintDM.Enabled = False
        tsSaveDM.Enabled = False

        LoadSupplierDM()
        DM_LoadSupplier()
        dgvSupplierDM.Focus()

        ' disableCM()

        If Me.Tag = 0 Then
            'LoadSupplierCM()
            'LoadSupplier()
        End If

    End Sub

    Sub LoadSupplierDM()

        Dim qry As String = Nothing
        With dgvSupplierDM
            .Rows.Clear()

            qry = "SELECT h.*,s.suppliername FROM supcmdm h LEFT JOIN supplier s ON h.supcode=s.supcode " & _
                  "WHERE ttype='D' and isdeleted<>1 ORDER BY date desc"
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

    Sub SaveSupDM()
        'save supplier cm
        cmdmtype = "D"
        Dim cmd As MySqlCommand

        cmd = New MySqlCommand("INSERT INTO supcmdm (transno,date,ttype,docno,supcode,user,amount,balance,remarks1,remarks2,remarks3,remarks4) VALUES (@tno,@cd,@tt,@docno,@sup,@user,@amt,@bal,@rem1,@rem2,@rem3,@rem4)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", tbTransnoDM.Text)
            cmd.Parameters.AddWithValue("@cd", dtpDMDate.Value)
            cmd.Parameters.AddWithValue("@tt", cmdmtype)
            cmd.Parameters.AddWithValue("@docno", tbDMNo.Text)
            cmd.Parameters.AddWithValue("@sup", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@user", tbUser.Text)
            cmd.Parameters.AddWithValue("@amt", Decimal.Parse(tbDMAmount.Text))
            cmd.Parameters.AddWithValue("@bal", Decimal.Parse(tbDMAmount.Text))
            cmd.Parameters.AddWithValue("@rem1", tbRem1.Text)
            cmd.Parameters.AddWithValue("@rem2", tbRem2.Text)
            cmd.Parameters.AddWithValue("@rem3", tbRem3.Text)
            cmd.Parameters.AddWithValue("@rem4", tbRem4.Text)

        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Sub DM_LoadSupplier()
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

    Sub GetTransSupplierDM()
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
            rcvtno = "D" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If

        If rcnt = 0 Then
            rcvtno = "D000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        tbTransnoDM.Text = rcvtno
    End Sub

    Sub ClearDM()
        dtpDMDate.Value = Date.Now
        tbTransnoDM.Clear()
        tbDMNo.Clear()
        tbDMAmount.Clear()
        cbxSupplier.Text = Nothing
        tbSupplierName.Clear()
        tbRem1.Clear()
        tbRem2.Clear()
        tbRem3.Clear()
        tbRem4.Clear()
        tbSearchDM.Clear()
        tbSearchDM.Focus()

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
            cbxSupplier.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("supcode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs)
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "'", cdb)
        Using rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                tbSupplierName.Text = rd.Item("suppliername").ToString
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub tbDMAmount_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select

        Dim dmamt As Decimal = 0
        If e.KeyChar = vbCr Then
            dmamt = myd(tbDMAmount.Text)
            tbDMAmount.Text = Format(dmamt, sFmat)
            cbxSupplier.Focus()
        End If
    End Sub

    Private Sub tbDMNo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbCr Then
            tbDMAmount.Focus()
        End If
    End Sub

    Private Sub tsNewSupDM_Click(sender As Object, e As EventArgs) Handles tsNewSupDM.Click
        dtpDMDate.Value = Date.Now
        tbTransnoDM.Clear()
        tbDMNo.Clear()
        tbDMAmount.Clear()
        cbxSupplier.Text = Nothing
        tbSupplierName.Clear()
        tbRem1.Clear()
        tbRem2.Clear()
        tbRem3.Clear()
        tbRem4.Clear()
        tbDMNo.Focus()

        tsSaveDM.Text = "S&ave"
        tsSavePrintDM.Text = "Sa&ve+Print"

        tsSaveDM.Enabled = True
        tsSavePrintDM.Enabled = True
    End Sub

    Private Sub tsSavePrintDM_Click(sender As Object, e As EventArgs) Handles tsSavePrintDM.Click
        If tbDMNo.Text = Nothing And tbDMAmount.Text = Nothing And cbxSupplier.Text = Nothing Then
            MsgBox("Pls Complete Missing Field!", vbCritical)
            Exit Sub
        End If

        If tsSavePrintDM.Text = "Update+P&rint" Then
            UpdateSupDM()
            MsgBox("Supplier Credit Memo has been Successfully updated.", vbInformation)
            tsSavePrintDM.Text = "Sa&ve+Print"
        Else
            If CheckSupDMNo() = True Then
                MsgBox("Supplier Credit Memo Already Exist!", 48, "Enter Supplier Credit Memo")
                Exit Sub
            End If

            GetTransSupplierDM()

            SaveSupDM()
            MsgBox("Supplier Credit Memo has been Successfully saved.", vbInformation)
        End If

        LoadSupplierDM()
        If lastitemsel <> Nothing Then
            With dgvSupplierDM
                For i = 0 To .RowCount - 1
                    If .Item(4, i).Value <> Nothing And .Item(4, i).Value = lastitemsel Then
                        .CurrentCell = .Item(4, i)
                    End If
                Next
            End With

        End If
        'ClearCM()

        PrintSupDM()
    End Sub

    Sub UpdateSupDM()
        'update supcmdm
        Dim cmd As MySqlCommand
        cmdmtype = "D"
        cmd = New MySqlCommand("UPDATE supcmdm  SET date=@cd,ttype=@tt,docno=@docno,supcode=@sup,user=@user, " & _
                                   "amount=@amt,balance=@bal,remarks1=@rem1,remarks2=@rem2,remarks3=@rem3,remarks4=@rem4 WHERE transno=@tno", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", tbTransnoDM.Text)
            cmd.Parameters.AddWithValue("@cd", dtpDMDate.Value)
            cmd.Parameters.AddWithValue("@tt", cmdmtype)
            cmd.Parameters.AddWithValue("@docno", tbDMNo.Text)
            cmd.Parameters.AddWithValue("@sup", cbxSupplier.Text)
            cmd.Parameters.AddWithValue("@user", tbUser.Text)
            cmd.Parameters.AddWithValue("@amt", Decimal.Parse(tbDMAmount.Text))
            cmd.Parameters.AddWithValue("@bal", Decimal.Parse(tbDMAmount.Text))
            cmd.Parameters.AddWithValue("@rem1", tbRem1.Text)
            cmd.Parameters.AddWithValue("@rem2", tbRem2.Text)
            cmd.Parameters.AddWithValue("@rem3", tbRem3.Text)
            cmd.Parameters.AddWithValue("@rem4", tbRem4.Text)
            cmd.ExecuteNonQuery()
        End With
        cmd.Dispose()
    End Sub

    Sub PrintSupDM()

    End Sub

    Function CheckSupDMNo()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT docno FROM supcmdm WHERE docno = @docno", cdb)
        With cmd
            .Parameters.AddWithValue("@docno", tbDMNo.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub tsSaveDM_Click(sender As Object, e As EventArgs) Handles tsSaveDM.Click
        'orig
        If tbDMNo.Text = Nothing And tbDMAmount.Text = Nothing And cbxSupplier.Text = Nothing Then
            MsgBox("Pls Complete Missing Field!", vbCritical)
            Exit Sub
        End If

        If tsSaveDM.Text = "U&pdate" Then
            UpdateSupDM()
            MsgBox("Supplier Credit Memo has been Successfully updated.", vbInformation)
            tsSaveDM.Text = "S&ave"
        Else

            If CheckSupDMNo() = True Then
                MsgBox("Supplier Credit Memo Already Exist!", 48, "Enter Supplier Credit Memo")
                Exit Sub
            End If

            GetTransSupplierDM()

            SaveSupDM()
            MsgBox("Supplier Credit Memo has been Successfully saved.", vbInformation)
        End If

        ClearDM()
        LoadSupplierDM()
    End Sub

    Private Sub tsRereshDM_Click(sender As Object, e As EventArgs) Handles tsRereshDM.Click
        LoadSupplierDM()
        DM_LoadSupplier()
        ClearDM()
        tsSaveDM.Text = "Save"
        tsSavePrintDM.Text = "Save+Print"
        dgvSupplierDM.Focus()
    End Sub

    Private Sub dgvSupplierDM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierDM.CellClick
        With dgvSupplierDM
            If .RowCount > 0 And e.RowIndex >= 0 Then
                tbTransnoDM.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(1).Value.ToString
                dtpDMDate.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(2).Value.ToString
                tbDMNo.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(4).Value.ToString
                cbxSupplier.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(5).Value.ToString
                tbSupplierName.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(6).Value.ToString
                tbDMAmount.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(7).Value.ToString
                tbUser.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(9).Value.ToString
                tbRem1.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(12).Value.ToString
                tbRem2.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(13).Value.ToString
                tbRem3.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(14).Value.ToString
                tbRem4.Text = dgvSupplierDM.Rows(e.RowIndex).Cells(15).Value.ToString

                lastitemsel = dgvSupplierDM.Rows(e.RowIndex).Cells(4).Value.ToString

                tsSaveDM.Enabled = True
                tsSavePrintDM.Enabled = True

                tsSaveDM.Text = "U&pdate"
                tsSavePrintDM.Text = "Update+P&rint"

                tsSaveDM.ToolTipText = "U&pdate"
                tsSavePrintDM.ToolTipText = "Update+P&rint"
            End If
        End With
    End Sub

    Private Sub dgvSupplierDM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierDM.CellContentClick

    End Sub

    Private Sub tbDMNo_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tbDMNo.KeyPress
        If e.KeyChar = vbCr Then
            tbDMAmount.Focus()
        End If
    End Sub

    Private Sub tbDMNo_TextChanged(sender As Object, e As EventArgs) Handles tbDMNo.TextChanged

    End Sub

    Private Sub tbDMAmount_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tbDMAmount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select

        Dim cmamt As Decimal = 0
        If e.KeyChar = vbCr Then
            cmamt = myd(tbDMAmount.Text)
            tbDMAmount.Text = Format(cmamt, sFmat)
            cbxSupplier.Focus()
        End If
    End Sub

    Private Sub tbDMAmount_TextChanged(sender As Object, e As EventArgs) Handles tbDMAmount.TextChanged

    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "'", cdb)
        Using rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                tbSupplierName.Text = rd.Item("suppliername").ToString
            End If
            rd.Close()
        End Using
    End Sub
End Class