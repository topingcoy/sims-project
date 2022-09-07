Imports MySql.Data.MySqlClient

Public Class frmCustomerD

    Private Sub cbxAllow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxAllow.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxTerritory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTerritory.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxOutletType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxOutletType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxProvince_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProvince.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxMainPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxMainPrincipal.KeyPress
        e.Handled = True
    End Sub

    Private Sub NewCustomer_Click(sender As Object, e As EventArgs)

        'tbCustNo.Text = GetCustNo()
        'UpdateCust.Enabled = False
        'tbCustCode.Focus()


    End Sub

    Private Sub frmCustomerD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub frmCustomerD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCustomerD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadArea()
        LoadOutletType()
        LoadProvince()
        LoadMainPrincipal()
        '  LoadSalesman()
        ' NewCustomer.PerformClick()
        SaveCust.Enabled = False
        tbCustName.Focus()
    End Sub

    Sub LoadSalesman()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

    End Sub

    Private Sub sRemovetoListCustomerD()
        For Each row As DataGridViewRow In dgvSalesman.SelectedRows
            dgvSalesman.Rows.Remove(row)
        Next
    End Sub

    Sub LoadArea()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxTerritory.Items.Clear()
        cbxTerritory.DisplayMember = "text"
        qry = "Select * from area ORDER BY areaname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxTerritory.Items.Add(New With {.Text = relr("areacode").ToString(), .Value = relr("areaname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadOutletType()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxOutletType.Items.Clear()
        cbxOutletType.DisplayMember = "text"
        qry = "Select * from outlet ORDER BY outletname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxOutletType.Items.Add(New With {.Text = relr("outletcode").ToString(), .Value = relr("outletname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadProvince()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxProvince.Items.Clear()
        cbxProvince.DisplayMember = "text"
        qry = "Select * from province ORDER BY provincename"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxProvince.Items.Add(New With {.Text = relr("provcode").ToString(), .Value = relr("provincename").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadMainPrincipal()

    End Sub

    Private Sub btnAddSalesman_Click(sender As Object, e As EventArgs) Handles btnAddSalesman.Click
        If tbCustCode.Text = Nothing Or tbCustName.Text = Nothing Then
            MsgBox("Fillup Customer Information First!", vbCritical)
        Else
            frmSearchSalesmanInv.ShowDialog()
        End If
    End Sub

    Private Sub SaveCust_Click(sender As Object, e As EventArgs) Handles SaveCust.Click
        'trap duplicate
        If CheckCustName() = True Then
            MsgBox("Customer Name Already Exist!", vbCritical, "Enter Customer Name")
            Exit Sub
        End If

        If tbCustCode.Text = Nothing Or tbCustName.Text = Nothing Then
            MsgBox("Check Missing Field!", vbCritical)
            Exit Sub
        End If

        Dim pricetype As String = Nothing
        For i As Integer = 0 To dgvSalesman.RowCount - 1
            With dgvSalesman

                pricetype = dgvSalesman.Rows(i).Cells(7).Value
                If pricetype = Nothing Then
                    MsgBox("Check Missing Field!", vbCritical)
                    Exit Sub
                End If

            End With
        Next

        If MsgBox("Save this Customer?", vbYesNo + vbQuestion) = vbYes Then
            'save to customers
            SaveCustomer()
            'SaveCustSales()
        End If
        'MsgBox("New Customer Has Been Save Sucessfully!", vbInformation)
        'frmCustomerH.LoadCustomer()
        'Me.Dispose()
    End Sub

    Sub TrapEmptyFields()
        'If IS_EMPTY(tbCustCode) = True Then Exit Sub
        'If IS_EMPTY(tbCustName) = True Then Exit Sub
        'If IS_EMPTY(tbCustAddress) = True Then Exit Sub
        'If IS_EMPTY(tbShipTo) = True Then Exit Sub
        'If IS_EMPTY(cbxTerritory) = True Then Exit Sub
        'If IS_EMPTY(cbxOutletType) = True Then Exit Sub
        'If IS_EMPTY(cbxProvince) = True Then Exit Sub
    End Sub

    Function CheckCustName()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT custname FROM customers WHERE custname = @cname", cdb)
        With cmd
            .Parameters.AddWithValue("@cname", tbCustName.Text.Trim)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Sub SaveCustomer()
        'save to customer
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("INSERT INTO customers (custcode,custname,address,shipto,areacode,areaname,outletcode,outlettype,provcode,province,maincode,mainp, " & _
                               "tinno,mobileno,telno,payterms,creditlimit,spdiscount,allowpd,active) " & _
                               " VALUES (@custcode,@custname,@address,@shipto,@acode,@aname,@ocode,@outlet,@pvcode,@prov,@mcode,@mainp,@tinno, " & _
                               "@mobile,@telno,@terms,@climit,@spd,@allow,@active)", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@custcode", tbCustCode.Text)
            cmd.Parameters.AddWithValue("@custname", tbCustName.Text)
            cmd.Parameters.AddWithValue("@address", tbCustAddress.Text)
            cmd.Parameters.AddWithValue("@shipto", tbShipTo.Text)
            cmd.Parameters.AddWithValue("@acode", cbxTerritory.Text)
            cmd.Parameters.AddWithValue("@aname", lblArea.Text)
            cmd.Parameters.AddWithValue("@ocode", cbxOutletType.Text)
            cmd.Parameters.AddWithValue("@outlet", lblOutlet.Text)
            cmd.Parameters.AddWithValue("@pvcode", cbxProvince.Text)
            cmd.Parameters.AddWithValue("@prov", lblProvince.Text)
            cmd.Parameters.AddWithValue("@mcode", cbxMainPrincipal.Text)
            cmd.Parameters.AddWithValue("@mainp", lblMain.Text)
            cmd.Parameters.AddWithValue("@tinno", tbTin.Text)
            cmd.Parameters.AddWithValue("@mobile", tbMobile.Text)
            cmd.Parameters.AddWithValue("@telno", tbTelno.Text)
            cmd.Parameters.AddWithValue("@terms", nuPayTerms.Text)
            cmd.Parameters.AddWithValue("@climit", CDbl(nuCredit.Text))
            cmd.Parameters.AddWithValue("@spd", CDbl(nuSpecial.Text))
            cmd.Parameters.AddWithValue("@allow", cbxAllow.Text)
            cmd.Parameters.AddWithValue("@active", cbxActive.Text)
            'cmd.Parameters.AddWithValue("@custno", tbCustNo.Text)
            cmd.ExecuteNonQuery()
        End With
        Dim pricetype As String = Nothing
        'save to custsales
        For i As Integer = 0 To dgvSalesman.RowCount - 1
            cmd = New MySqlCommand("INSERT INTO custsales (custcode,slmcode,salesman,whscode,warehouse,opercode,typeofoper,pricetype) VALUES " & _
                                   "(@ccode,@smcode,@sname,@whcode,@whname,@opercode,@typeoper,@pt)", cdb)
            With cmd
                With dgvSalesman
                    cmd.Parameters.AddWithValue("@ccode", tbCustCode.Text)
                    cmd.Parameters.AddWithValue("@smcode", dgvSalesman.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@sname", dgvSalesman.Rows(i).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@whcode", dgvSalesman.Rows(i).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@whname", dgvSalesman.Rows(i).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@opercode", dgvSalesman.Rows(i).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@typeoper", dgvSalesman.Rows(i).Cells(6).Value)
                    pricetype = dgvSalesman.Rows(i).Cells(7).Value

                    cmd.Parameters.AddWithValue("@pt", pricetype)
                    cmd.ExecuteNonQuery()
                End With
            End With
        Next
        MsgBox("New Customer Has Been Save Sucessfully!", vbInformation)
        frmCustomerH.LoadCustomer()
        'Me.Dispose()
        ClearCustomer()
        NewCust.Enabled = True
        NewCust.PerformClick()
    End Sub

    Sub SaveCustSales()
        'Dim cmd As MySqlCommand
        'For i As Integer = 0 To dgvSalesman.RowCount - 1
        '    cmd = New MySqlCommand("INSERT INTO custsales (custcode,salesman,warehouse,typeofoper,pricetype) VALUES (@ccode,@sman,@whs,@typeoper,@ptype)", cdb)
        '    With cmd
        '        cmd.Parameters.AddWithValue("@ccode", tbCustCode.Text)
        '        cmd.Parameters.AddWithValue("@sman", dgvSalesman.Rows(i).Cells(1).Value)
        '        cmd.Parameters.AddWithValue("@whs", dgvSalesman.Rows(i).Cells(2).Value)
        '        cmd.Parameters.AddWithValue("@typeoper", dgvSalesman.Rows(i).Cells(3).Value)
        '        cmd.Parameters.AddWithValue("@ptype", dgvSalesman.Rows(i).Cells(4).Value)
        '        cmd.Parameters.AddWithValue("@def", dgvSalesman.Rows(i).Cells(5).Value)
        '        cmd.ExecuteNonQuery()
        '    End With
        'Next
    End Sub

    Private Sub btnDeleteSalesman_Click(sender As Object, e As EventArgs) Handles btnDeleteSalesman.Click

        If dgvSalesman.Rows.Count = 0 Then
            MsgBox("Select Salesman to Remove!", vbCritical)
        Else
            If MsgBox("Remove this Salesman?", vbYesNo + vbExclamation) = vbYes Then
                Try
                    For Each row As DataGridViewRow In dgvSalesman.SelectedRows
                        dgvSalesman.Rows.Remove(row)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub cbxTerritory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTerritory.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from area where areacode like '%" & cbxTerritory.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                lblArea.Text = rd.Item("areaname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub cbxOutletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOutletType.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from outlet where outletcode like '%" & cbxOutletType.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                lblOutlet.Text = rd.Item("outletname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub cbxProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProvince.SelectedIndexChanged
        cmd = New MySqlCommand("SELECT * from province where provcode like '%" & cbxProvince.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                lblProvince.Text = rd.Item("provincename").ToString
            End With
        End If
        rd.Close()
    End Sub

  
    Private Sub dgvSalesman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesman.CellContentClick

    End Sub

    Sub LoadCustSales()
        dgvSalesman.Rows.Clear()
        Dim i As Integer
        cmd = New MySqlCommand("select * from custsales where custcode = '" & tbCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvSalesman.Rows.Add(i, rd.Item("slmcode").ToString, rd.Item("salesman").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString, rd.Item("pkno").ToString)
        End While
        rd.Close()
    End Sub

    Private Sub dgvSalesman_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesman.CellEndEdit
        
    End Sub

    Private Sub UpdateCust_Click(sender As Object, e As EventArgs) Handles UpdateCust.Click
        If MsgBox("Update this Customer?", vbYesNo + vbQuestion) = vbYes Then
            Dim bolDuplicateWasFound As Boolean = False

            'For x As Integer = 0 To dgvSalesman.Rows.Count - 1
            '    For y As Integer = 0 To dgvSalesman.Rows.Count - 1
            '        If y <> x AndAlso dgvSalesman.Rows(x).Cells(0).Value.ToString = dgvSalesman.Rows(y).Cells(0).Value.ToString Then
            '            bolDuplicateWasFound = True
            '            MsgBox("Duplicate Salesman!", vbCritical)
            '            Exit Sub
            '        End If
            '    Next
            'Next

            If Not bolDuplicateWasFound Then
                tbCustName.Focus()
                UpdateCustomer()
            End If

        End If

       
    End Sub

    Sub UpdateCustomer()
        'update to customer

        cmd = New MySqlCommand("UPDATE customers SET  custcode=@custcode, custname=@custname, address=@address, shipto=@shipto, " & _
                               "areacode=@acode, areaname=@aname, outletcode=@ocode, outlettype=@outlet, " & _
                               "province=@prov, maincode=@mcode, mainp=@mainp, tinno=@tinno, mobileno=@mobile, telno=@telno, " & _
                               "payterms=@terms, creditlimit=@climit, spdiscount=@spd, allowpd=@allow, active=@active where custcode=@custcode", cdb)
        With cmd
            cmd.Parameters.AddWithValue("@custcode", tbCustCode.Text)
            cmd.Parameters.AddWithValue("@custname", tbCustName.Text)
            cmd.Parameters.AddWithValue("@address", tbCustAddress.Text)
            cmd.Parameters.AddWithValue("@shipto", tbShipTo.Text)
            cmd.Parameters.AddWithValue("@acode", cbxTerritory.Text)
            cmd.Parameters.AddWithValue("@aname", lblArea.Text)
            cmd.Parameters.AddWithValue("@ocode", cbxOutletType.Text)
            cmd.Parameters.AddWithValue("@outlet", lblOutlet.Text)
            cmd.Parameters.AddWithValue("@pvcode", cbxProvince.Text)
            cmd.Parameters.AddWithValue("@prov", lblProvince.Text)
            cmd.Parameters.AddWithValue("@mcode", cbxMainPrincipal.Text)
            cmd.Parameters.AddWithValue("@mainp", lblMain.Text)
            cmd.Parameters.AddWithValue("@tinno", tbTin.Text)
            cmd.Parameters.AddWithValue("@mobile", tbMobile.Text)
            cmd.Parameters.AddWithValue("@telno", tbTelno.Text)
            cmd.Parameters.AddWithValue("@terms", nuPayTerms.Text)
            cmd.Parameters.AddWithValue("@climit", nuCredit.Text)
            cmd.Parameters.AddWithValue("@spd", nuSpecial.Text)
            cmd.Parameters.AddWithValue("@allow", cbxAllow.Text)
            cmd.Parameters.AddWithValue("@active", cbxActive.Text)

            cmd.ExecuteNonQuery()
        End With

        'update to custsales
        'For i As Integer = 0 To dgvSalesman.RowCount - 1
        '    cmd = New MySqlCommand("UPDATE custsales SET custcode=@ccode, slmcode=@smcode, salesman=@sname, whscode=@whcode, warehouse=@whname, opercode=@opercode, typeofoper=@typeoper, pricetype=@pt WHERE custcode=@ccode and pkno=@pkno", cdb)
        '    With cmd
        '        With dgvSalesman
        '            cmd.Parameters.AddWithValue("@ccode", tbCustCode.Text)
        '            cmd.Parameters.AddWithValue("@smcode", dgvSalesman.Rows(i).Cells(1).Value)
        '            cmd.Parameters.AddWithValue("@sname", dgvSalesman.Rows(i).Cells(2).Value)
        '            cmd.Parameters.AddWithValue("@whcode", dgvSalesman.Rows(i).Cells(3).Value)
        '            cmd.Parameters.AddWithValue("@whname", dgvSalesman.Rows(i).Cells(4).Value)
        '            cmd.Parameters.AddWithValue("@opercode", dgvSalesman.Rows(i).Cells(5).Value)
        '            cmd.Parameters.AddWithValue("@typeoper", dgvSalesman.Rows(i).Cells(6).Value)
        '            cmd.Parameters.AddWithValue("@pt", dgvSalesman.Rows(i).Cells(7).Value)
        '            cmd.Parameters.AddWithValue("@pkno", dgvSalesman.Rows(i).Cells(8).Value)
        '            cmd.ExecuteNonQuery()
        '        End With
        '    End With
        'Next

        Dim pricetype As String = Nothing
        Dim cmd2 As MySqlCommand
        cmd2 = New MySqlCommand("Delete From custsales where custcode = @c_no", cdb)
        cmd2.Parameters.AddWithValue("@c_no", tbCustCode.Text)
        cmd2.ExecuteNonQuery()

        For i As Integer = 0 To dgvSalesman.RowCount - 1
            cmd = New MySqlCommand("INSERT INTO custsales (custcode,slmcode,salesman,whscode,warehouse,opercode,typeofoper,pricetype) VALUES " & _
                                   "(@ccode,@smcode,@sname,@whcode,@whname,@opercode,@typeoper,@pt)", cdb)
            With cmd
                With dgvSalesman
                    cmd.Parameters.AddWithValue("@ccode", tbCustCode.Text)
                    cmd.Parameters.AddWithValue("@smcode", dgvSalesman.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@sname", dgvSalesman.Rows(i).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@whcode", dgvSalesman.Rows(i).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@whname", dgvSalesman.Rows(i).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@opercode", dgvSalesman.Rows(i).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@typeoper", dgvSalesman.Rows(i).Cells(6).Value)
                    pricetype = dgvSalesman.Rows(i).Cells(7).Value
                    cmd.Parameters.AddWithValue("@pt", pricetype)
                    cmd.ExecuteNonQuery()
                End With
            End With
        Next
        MsgBox("Customer Has Been Updated Sucessfully!", vbInformation)
        frmCustomerH.LoadCustomer()
        Me.Dispose()
    End Sub

    Private Sub NewCust_Click(sender As Object, e As EventArgs) Handles NewCust.Click

        '  tbCustCode.Text = GetCustCode()
        GetCustCode()
        SaveCust.Enabled = True
        NewCust.Enabled = False
        tbCustName.Focus()


    End Sub

    Sub GetCustCode()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim empn As String = Nothing
        Dim cnts As String = Nothing
        Dim cqry As String = Nothing

        yn = Year(gettime2(3))
        cqry = "Select custcode as pno FROM customers ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While

            empn = mdr("pno") + 1

            If Strings.Left(empn, 4) <> yn Then
                cnts = "0001"
                empn = yn & cnts
            End If
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If


        If rcnt = 0 Then
            cnts = "0001"
            empn = yn & cnts
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        tbCustCode.Text = empn

    End Sub

    Private Sub ClearCust_Click(sender As Object, e As EventArgs) Handles ClearCust.Click
        ClearCustomer()
    End Sub

    Sub ClearCustomer()
        'tbCustCode.Clear()
        tbCustName.Clear()
        tbCustAddress.Clear()
        tbShipTo.Clear()
        cbxTerritory.SelectedIndex = -1
        lblArea.Text = ""
        cbxOutletType.SelectedIndex = -1
        lblOutlet.Text = ""
        cbxProvince.SelectedIndex = -1
        lblProvince.Text = ""
        cbxMainPrincipal.SelectedIndex = -1
        lblMain.Text = ""
        tbTin.Clear()
        tbMobile.Clear()
        tbTelno.Clear()
        nuPayTerms.Value = "0"
        nuCredit.Value = "0"
        nuSpecial.Value = "0"
        cbxAllow.SelectedIndex = 1
        cbxActive.SelectedIndex = 0
        dgvSalesman.Rows.Clear()

        'SaveCust.Enabled = False
        'NewCust.Enabled = True
        tbCustName.Focus()


    End Sub

    'Function GetCustCode()
    '    Dim sdate As String = Now.ToString("yyMMdd")
    '    Dim cmd As MySqlCommand
    '    cmd = New MySqlCommand("select custcode from customers where custcode like '" & sdate & "%'", cdb)
    '    Using rd As MySqlDataReader = cmd.ExecuteReader
    '        If rd.HasRows Then
    '            rd.Read()
    '            GetCustCode = Format(CLng(rd.Item("custcode").ToString) + 1)
    '        Else
    '            GetCustCode = sdate & "0001"
    '        End If
    '        rd.Close()
    '    End Using
    '    Return GetCustCode
    'End Function

End Class