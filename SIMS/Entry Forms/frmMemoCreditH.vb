Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data
Imports System.Text
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Linq
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing

Public Class frmMemoCredit

    Dim ttype As String
    Dim lastitemsel As String = Nothing

    Private Sub frmMemoCreditH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F5 Then
            btnAdd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            btnRefresh_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then
            btnClose_Click(sender, e)
        End If

    End Sub

    Private Sub frmMemoCreditH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If txtCMNo.Text <> Nothing Then
            txtCMNoUpdate.Text = txtCMNo.Text
        End If

        If txtBalance.Text <> Nothing Then
            txtBalance.Text = txtAmount.Text
        End If

        ttype = "C"

        If txtUser.Text = Nothing Then
            txtUser.Text = _user
        End If

        loadCreditMemo()
        '  cmDisable()
        ' btnUpdatePrint.Enabled = False
        ' btnUpdate.Enabled = False
        ' LoadCustomerList()
    End Sub

    Sub LoadSalesman()
        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & txtCustCode.Text.Trim & "'", cdb)
        'SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.customercode where s.custcode='20200001'
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString) ') ', rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    'Sub LoadCustomerList()
    '    dgvCustomerList.Rows.Clear()
    '    Dim i As Integer
    '    cmd = New MySqlCommand("SELECT * FROM customers WHERE active <> 'N' order by custname asc", cdb)
    '    'cmd = New MySqlCommand("SELECT c.*,s.* FROM customers c JOIN custsales s ON c.custcode=s.custcode WHERE c.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
    '    rd = cmd.ExecuteReader
    '    While rd.Read
    '        i += 1
    '        dgvCustomerList.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
    '                              rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
    '                              rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
    '                              Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
    '                              rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
    '    End While
    '    rd.Close()
    '    dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
    '    dgvCustomerList.Focus()
    'End Sub

    Sub cmClear()
        txtTransno.Clear()
        dtpCM.Value = Date.Today
        txtCMNo.Clear()
        txtAmount.Text = "0.00"
        txtCustCode.Clear()
        txtCustomerName.Clear()
        txtSalesmanCode.Clear()
        txtSalesmanName.Clear()
        txtRemarks1.Clear()
        txtRemarks2.Clear()
        txtRemarks3.Clear()
        txtRemarks4.Clear()
        txtSearch.Clear()
        txtCMNo.Focus()
    End Sub

    Sub cmDisable()
        dtpCM.Enabled = False
        txtCMNo.Enabled = False
        txtCustCode.Enabled = False
        txtCustomerName.Enabled = False
        txtSalesmanCode.Enabled = False
        txtSalesmanName.Enabled = False
        txtRemarks1.Enabled = False
        txtRemarks2.Enabled = False
        txtRemarks3.Enabled = False
        txtRemarks4.Enabled = False

    End Sub

    Sub cmEnable()
        dtpCM.Enabled = True
        txtCMNo.Enabled = True
        txtCustCode.Enabled = True
        txtCustomerName.Enabled = True
        txtSalesmanCode.Enabled = True
        txtSalesmanName.Enabled = True
        txtRemarks1.Enabled = True
        txtRemarks2.Enabled = True
        txtRemarks3.Enabled = True
        txtRemarks4.Enabled = True
    End Sub

    Sub loadCreditMemo()
        'load cmdm
        dgvCM.Rows.Clear()
        Dim i As Integer
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT h.*,c.custname,s.slmnname FROM cmdm h LEFT JOIN customers c " & _
                               "ON h.custcode=c.custcode LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                               "WHERE ttype='C' AND isdeleted<>1 ORDER BY transno desc LIMIT 300", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCM.Rows.Add(i, rd.Item("transno").ToString, rd.Item("date").ToString, rd.Item("docno").ToString, _
                           rd.Item("custcode").ToString, rd.Item("custname").ToString, _
                           rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, _
                           Format(CDbl(rd.Item("amount").ToString), "##,##0.00"), _
                           Format(CDbl(rd.Item("applied").ToString), "##,##0.00"), _
                           Format(CDbl(rd.Item("balance").ToString), "##,##0.00"), _
                           rd.Item("remarks1").ToString, rd.Item("remarks2").ToString, _
                           rd.Item("remarks3").ToString, rd.Item("remarks4").ToString, rd.Item("pkno").ToString)
        End While
        rd.Close()
        cmClear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cmClear()
        tsUpdate.SendToBack()
        tsUpdate.Visible = False

        tsSave.BringToFront()
        tsSave.Visible = True
        cmEnable()
        txtCMNo.Focus()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select

        Dim cmamt As Decimal = 0
        If e.KeyChar = vbCr Then
            cmamt = myd(txtAmount.Text)
            txtAmount.Text = Format(cmamt, sFmat)
            txtBalance.Text = Format(cmamt, sFmat)
            txtCustCode.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCMNo.Text = Nothing And txtAmount.Text = Nothing Then
            MsgBox("Pls complete missing field!", vbCritical)
            Exit Sub
        End If

        If CheckDuplicateDocNo() = True Then
            MsgBox("Credit memo number already exist!", 48, "Enter Credit Memo")
            Exit Sub
        End If

        If MsgBox("Save this Transaction?", vbYesNo + vbQuestion) = vbYes Then
            GetCMTransNo()
            SaveCM()
            MsgBox("Credit Memo has been successfully saved.", vbInformation)
            cmClear()
        End If
        loadCreditMemo()

    End Sub

    Sub GetCMTransNo()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        cqry = "Select transno as tno FROM cmdm ORDER BY pkno DESC LIMIT 1"
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

        txtTransno.Text = rcvtno
    End Sub

    Sub SaveCM()
        'save to cmdm
        Dim cmd As MySqlCommand

        cmd = New MySqlCommand("INSERT INTO cmdm (transno,ttype,date,docno,custcode,slmncode,amount,balance,remarks1,remarks2,remarks3,remarks4,user) " & _
                               "VALUES (@tno,@ttype,@date,@docno,@ccode,@scode,@amount,@bal,@rem1,@rem2,@rem3,@rem4,@user)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
            cmd.Parameters.AddWithValue("@ttype", ttype) 'dtpCMDate.Value)
            cmd.Parameters.AddWithValue("@date", dtpCM.Value)
            cmd.Parameters.AddWithValue("@docno", txtCMNo.Text)
            cmd.Parameters.AddWithValue("@ccode", txtCustCode.Text)
            cmd.Parameters.AddWithValue("@scode", txtSalesmanCode.Text)
            cmd.Parameters.AddWithValue("@amount", Decimal.Parse(txtAmount.Text))
            cmd.Parameters.AddWithValue("@bal", Decimal.Parse(txtBalance.Text))
            cmd.Parameters.AddWithValue("@rem1", txtRemarks1.Text)
            cmd.Parameters.AddWithValue("@rem2", txtRemarks2.Text)
            cmd.Parameters.AddWithValue("@rem3", txtRemarks3.Text)
            cmd.Parameters.AddWithValue("@rem4", txtRemarks4.Text)
            cmd.Parameters.AddWithValue("@user", txtUser.Text)
        End With
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Function CheckDuplicateDocNo()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT docno FROM cmdm WHERE docno = @docno", cdb)
        With cmd
            .Parameters.AddWithValue("@docno", txtCMNo.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub dgvCM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCM.CellClick

        cmEnable()

        tsSave.Visible = False
        tsSave.SendToBack()

        tsUpdate.BringToFront()
        tsUpdate.Visible = True

        If dgvCM.Rows(e.RowIndex).Cells(10).Value.ToString = 0 Then
            btnUpdate.Enabled = False
            btnUpdatePrint.Enabled = False
        Else
            btnUpdate.Enabled = True
            btnUpdatePrint.Enabled = True
        End If

        With dgvCM
            'If dgvCM.Rows(e.RowIndex).Cells(10).Value.ToString = 0 Then
            '    btnUpdate.Enabled = False
            '    btnUpdatePrint.Enabled = False
            'Else

            txtTransno.Text = dgvCM.Rows(e.RowIndex).Cells(1).Value.ToString
            dtpCM.Text = dgvCM.Rows(e.RowIndex).Cells(2).Value.ToString
            txtCMNo.Text = dgvCM.Rows(e.RowIndex).Cells(3).Value.ToString
            txtCMNoUpdate.Text = dgvCM.Rows(e.RowIndex).Cells(3).Value.ToString
            txtCustCode.Text = dgvCM.Rows(e.RowIndex).Cells(4).Value.ToString
            txtCustomerName.Text = dgvCM.Rows(e.RowIndex).Cells(5).Value.ToString
            txtSalesmanCode.Text = dgvCM.Rows(e.RowIndex).Cells(6).Value.ToString
            txtSalesmanName.Text = dgvCM.Rows(e.RowIndex).Cells(7).Value.ToString
            txtAmount.Text = dgvCM.Rows(e.RowIndex).Cells(8).Value.ToString

            txtBalance.Text = dgvCM.Rows(e.RowIndex).Cells(10).Value.ToString
            txtRemarks1.Text = dgvCM.Rows(e.RowIndex).Cells(11).Value.ToString
            txtRemarks2.Text = dgvCM.Rows(e.RowIndex).Cells(12).Value.ToString
            txtRemarks3.Text = dgvCM.Rows(e.RowIndex).Cells(13).Value.ToString
            txtRemarks4.Text = dgvCM.Rows(e.RowIndex).Cells(14).Value.ToString
            pkno.Text = dgvCM.Rows(e.RowIndex).Cells(15).Value.ToString
            'End If
        End With
    End Sub


    Private Sub dgvCM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCM.CellContentClick
        'If tsSave.Visible = True Then
        '    tsSave.SendToBack()
        '    tsSave.Visible = False
        'ElseIf tsUpdate.Visible = False Then
        '    tsUpdate.BringToFront()
        '    tsUpdate.Visible = True
        'End If
        'If dgvCM.Rows(e.RowIndex).Cells(10).Value.ToString = 0 Then
        '    btnUpdate.Enabled = False
        '    btnUpdatePrint.Enabled = False
        'End If

        'With dgvCM
        '    'If dgvCM.Rows(e.RowIndex).Cells(10).Value.ToString = 0 Then
        '    '    btnUpdate.Enabled = False
        '    '    btnUpdatePrint.Enabled = False
        '    'Else
        '    txtTransno.Text = dgvCM.Rows(e.RowIndex).Cells(1).Value.ToString
        '    dtpCM.Text = dgvCM.Rows(e.RowIndex).Cells(2).Value.ToString
        '    txtCMNo.Text = dgvCM.Rows(e.RowIndex).Cells(3).Value.ToString
        '    txtCMNoUpdate.Text = dgvCM.Rows(e.RowIndex).Cells(3).Value.ToString
        '    txtCustCode.Text = dgvCM.Rows(e.RowIndex).Cells(4).Value.ToString
        '    txtCustomerName.Text = dgvCM.Rows(e.RowIndex).Cells(5).Value.ToString
        '    txtSalesmanCode.Text = dgvCM.Rows(e.RowIndex).Cells(6).Value.ToString
        '    txtSalesmanName.Text = dgvCM.Rows(e.RowIndex).Cells(7).Value.ToString
        '    txtAmount.Text = dgvCM.Rows(e.RowIndex).Cells(8).Value.ToString

        '    txtBalance.Text = dgvCM.Rows(e.RowIndex).Cells(10).Value.ToString
        '    txtRemarks1.Text = dgvCM.Rows(e.RowIndex).Cells(11).Value.ToString
        '    txtRemarks2.Text = dgvCM.Rows(e.RowIndex).Cells(12).Value.ToString
        '    txtRemarks3.Text = dgvCM.Rows(e.RowIndex).Cells(13).Value.ToString
        '    txtRemarks4.Text = dgvCM.Rows(e.RowIndex).Cells(14).Value.ToString
        '    pkno.Text = dgvCM.Rows(e.RowIndex).Cells(15).Value.ToString
        '    'End If
        'End With
    End Sub

    Private Sub dgvCM_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCM.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
            SendKeys.Send("{enter}")
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dgvCM_CellClick(1, New DataGridViewCellEventArgs(0, dgvCM.CurrentRow.Index))
        End If
    End Sub

    Private Sub txtCustomerCode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        frmSearchCustomer.Text = "CREDIT MEMO"
        frmSearchCustomer.ShowDialog()
    End Sub

    Private Sub txtCustCode_DragLeave(sender As Object, e As EventArgs) Handles txtCustCode.DragLeave

    End Sub

    Private Sub txtCustCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmSearchCustomer.Text = "CREDIT MEMO"
            frmSearchCustomer.ShowDialog()
        End If
    End Sub

    Private Sub txtCustCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustCode.KeyPress
        If e.KeyChar = vbCr Then
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT * FROM customers WHERE custcode = '" & txtCustCode.Text & "'", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtCustomerName.Text = rd("custname").ToString
                ' txtAddress.Text = rd("address").ToString
            End If
            rd.Dispose()

            cmd = New MySqlCommand("SELECT c.*,s.* FROM custsales c JOIN salesman s WHERE custcode = '" & txtCustCode.Text & "' AND c.slmncode=s.slmncode", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtSalesmanCode.Text = rd("slmncode").ToString
                txtSalesmanName.Text = rd("slmnname").ToString
                'txtPriceType.Text = rd("pricetype").ToString
                'txtWarehouseCode.Text = rd("whscode").ToString
                'txtWarehouseName.Text = rd("warehouse").ToString
                rd.Dispose()
                txtSalesmanCode.Focus()
            Else
                MsgBox("Customer Code is invalid!", MsgBoxStyle.Critical)
                txtCustCode.Focus()
            End If
            rd.Dispose()
        End If
        

        'If e.KeyChar = vbCr Then
        '    If txtCustCode.Text = Nothing Then
        '        MsgBox("Select customer!", vbExclamation)
        '        Exit Sub
        '    Else
        '        txtSalesmanCode.Focus()
        '    End If
        'End If
    End Sub

    Private Sub txtCustCode_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCustCode.MouseClick

    End Sub

    Private Sub txtCustomerCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged

    End Sub

    Private Sub txtSalesmanCode_CursorChanged(sender As Object, e As EventArgs) Handles txtSalesmanCode.CursorChanged

    End Sub

    Private Sub txtSalesmanCode_DoubleClick(sender As Object, e As EventArgs) Handles txtSalesmanCode.DoubleClick

        If txtCustCode.Text <> Nothing Then
            dgvListSalesman.BringToFront()
            dgvListSalesman.Visible = True
            LoadSalesman()
        Else
            MsgBox("Select customer first!", vbExclamation)
            Exit Sub
        End If
    End Sub

    Private Sub txtSalesmanCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSalesmanCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            If txtCustCode.Text <> Nothing Then
                dgvListSalesman.BringToFront()
                dgvListSalesman.Visible = True
                LoadSalesman()
            Else
                MsgBox("Select customer first!", vbExclamation)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtSalesmanCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesmanCode.KeyPress
        e.Handled = True
        If e.KeyChar = vbCr Then
            txtRemarks1.Focus()
        End If
    End Sub

    Private Sub txtCMNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCMNo.KeyPress
        If e.KeyChar = vbCr Then
            txtAmount.Focus()
        End If
    End Sub

    Private Sub txtRemarks1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks1.KeyPress
        If e.KeyChar = vbCr Then
            txtRemarks2.Focus()
        End If
    End Sub

    Private Sub txtRemarks3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks3.KeyPress
        If e.KeyChar = vbCr Then
            txtRemarks4.Focus()
        End If
    End Sub

    Private Sub txtRemarks2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks2.KeyPress
        If e.KeyChar = vbCr Then
            txtRemarks3.Focus()
        End If
    End Sub

    Private Sub dgvListSalesman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellClick
        txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        txtRemarks1.Focus()
    End Sub

    Private Sub dgvListSalesman_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellDoubleClick
        dgvListSalesman.SendToBack()
        dgvListSalesman.Visible = False
        txtRemarks1.Focus()
    End Sub

    Private Sub dgvListSalesman_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvListSalesman.KeyDown
        'If e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Then
        '    SendKeys.Send("{enter}")
        'End If
        'If e.KeyCode = Keys.Up Or e.KeyCode = Keys.PageUp Then
        '    SendKeys.Send("{enter}")
        'End If
        'If e.KeyCode = Keys.Enter Then
        '    e.SuppressKeyPress = True
        '    dgvListSalesman_CellClick(1, New DataGridViewCellEventArgs(0, dgvListSalesman.CurrentRow.Index))
        'End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        txtBalance.Text = txtAmount.Text
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvCM
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                Dim docno As String = Nothing
                mytrans = .Item(1, .CurrentRow.Index).Value
                docno = .Item(3, .CurrentRow.Index).Value
                If MsgBox("Delete C.M.: " & docno & "?", vbQuestion + vbYesNo, "Continue?") = vbYes Then
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("UPDATE cmdm SET isdeleted=1 WHERE transno=@tr", cdb)
                    cmd.Parameters.AddWithValue("@tr", mytrans)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Credit Memo has been successfully deleted!", vbInformation)
                    loadCreditMemo()
                End If
            End If
        End With
    End Sub


    Private Sub dgvListSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListSalesman.CellContentClick

    End Sub

    Private Sub txtSalesmanCode_TextChanged(sender As Object, e As EventArgs) Handles txtSalesmanCode.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If MsgBox("Update this transaction?", vbYesNo + vbQuestion) = vbYes Then
            If txtAmount.Text <> Nothing Or txtAmount.Text <> Nothing Or txtCMNo.Text <> Nothing Then
                UpdateCM()
            End If
            MsgBox("Transaction has been updated successfully.", vbInformation)
        End If
        cmClear()
        pkno.Text = Nothing
        txtBalance.Clear()
        txtCMNoUpdate.Clear()
        loadCreditMemo()
    End Sub

    Sub UpdateCM()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("UPDATE cmdm SET transno=@tno,ttype=@ttype,date=@date,docno=@docno, " & _
                               "custcode=@ccode,slmncode=@scode,amount=@amount,balance=@bal, " & _
                               "remarks1=@rem1,remarks2=@rem2,remarks3=@rem3,remarks4=@rem4,user=@user " & _
                               "WHERE transno=@tno AND pkno=@pno", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@tno", txtTransno.Text)
            cmd.Parameters.AddWithValue("@ttype", ttype) 'dtpCMDate.Value)
            cmd.Parameters.AddWithValue("@date", dtpCM.Value)
            cmd.Parameters.AddWithValue("@docno", txtCMNo.Text)
            cmd.Parameters.AddWithValue("@ccode", txtCustCode.Text)
            cmd.Parameters.AddWithValue("@scode", txtSalesmanCode.Text)
            cmd.Parameters.AddWithValue("@amount", Decimal.Parse(txtAmount.Text))
            cmd.Parameters.AddWithValue("@bal", Decimal.Parse(txtBalance.Text))
            cmd.Parameters.AddWithValue("@rem1", txtRemarks1.Text)
            cmd.Parameters.AddWithValue("@rem2", txtRemarks2.Text)
            cmd.Parameters.AddWithValue("@rem3", txtRemarks3.Text)
            cmd.Parameters.AddWithValue("@rem4", txtRemarks4.Text)
            cmd.Parameters.AddWithValue("@user", txtUser.Text)
            cmd.Parameters.AddWithValue("@pno", pkno.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End With
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'load cmdm
        dgvCM.Rows.Clear()
        Dim i As Integer
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT h.*,c.custname,s.slmnname FROM cmdm h LEFT JOIN customers c " & _
                               "ON h.custcode=c.custcode LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                               "WHERE c.custname like '%" & txtSearch.Text & "%' or docno like '%" & txtSearch.Text & "%' AND ttype='C'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCM.Rows.Add(i, rd.Item("transno").ToString, rd.Item("date").ToString, rd.Item("docno").ToString, _
                           rd.Item("custcode").ToString, rd.Item("custname").ToString, _
                           rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, _
                           Format(CDbl(rd.Item("amount").ToString), "##,##0.00"), _
                           Format(CDbl(rd.Item("applied").ToString), "##,##0.00"), _
                           Format(CDbl(rd.Item("balance").ToString), "##,##0.00"), _
                           rd.Item("remarks1").ToString, rd.Item("remarks2").ToString, _
                           rd.Item("remarks3").ToString, rd.Item("remarks4").ToString, rd.Item("pkno").ToString)
        End While
        rd.Close()

    End Sub

  
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadCreditMemo()
        cmClear()
        tsUpdate.BringToFront()
        tsUpdate.Visible = True
        'btnUpdatePrint.Enabled = True
        'btnUpdate.Enabled = True
        'btnEdit.Enabled = True
        cmDisable()
        tsSave.SendToBack()
        tsSave.Visible = False
        'tsSave.Visible = False
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'load cmdm
        dgvCM.Rows.Clear()
        Dim i As Integer
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT h.*,c.custname,s.slmnname FROM cmdm h LEFT JOIN customers c " & _
                               "ON h.custcode=c.custcode LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                               "WHERE date >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
                              "and date <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' and ttype='C' and " & _
                              "isdeleted <> 1 order by transno desc limit 300", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvCM.Rows.Add(i, rd.Item("transno").ToString, rd.Item("date").ToString, rd.Item("docno").ToString, _
                           rd.Item("custcode").ToString, rd.Item("custname").ToString, _
                           rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, _
                           Format(CDbl(rd.Item("amount").ToString), "##,##0.00"), _
                           Format(CDbl(rd.Item("applied").ToString), "##,##0.00"), _
                           Format(CDbl(rd.Item("balance").ToString), "##,##0.00"), _
                           rd.Item("remarks1").ToString, rd.Item("remarks2").ToString, _
                           rd.Item("remarks3").ToString, rd.Item("remarks4").ToString, rd.Item("pkno").ToString)
        End While
        rd.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close?", vbYesNo + vbQuestion, "Continue") = vbYes Then
            Me.Dispose()
        End If
    End Sub
End Class