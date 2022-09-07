Imports MySql.Data.MySqlClient

Public Class frmBookingARCollD

    Private Sub frmBookingARCollD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Sub SaveBookingAR()

        'insert to collh


        'insert to colld


        'insert to check


    End Sub

    Sub UpdateBookingAR()

        'update to collh


        'update to colld


        'update to check


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmSearchBookingAR
            .ShowDialog()
        End With
    End Sub

    Private Sub tbCustomerCode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        frmSearchCustomer.Text = "ENTER BOOKING A/R COLLECTION"
        frmSearchCustomer.ShowDialog()
    End Sub

    Private Sub txtCustCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustCode.KeyPress
        If e.KeyChar = vbCr Then
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT * FROM customers WHERE custcode = '" & txtCustCode.Text & "'", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtCustomername.Text = rd("custname").ToString
            End If
            rd.Dispose()

            cmd = New MySqlCommand("SELECT c.*,s.* FROM custsales c JOIN salesman s WHERE custcode = '" & txtCustCode.Text & "' AND c.slmncode=s.slmncode", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtSalesmanCode.Text = rd("slmncode").ToString
                txtSalesmanName.Text = rd("slmnname").ToString
                rd.Dispose()
                txtSalesmanCode.Focus()
            Else
                MsgBox("Customer Code is invalid!", MsgBoxStyle.Critical)
                txtCustCode.Focus()
            End If
            rd.Dispose()
        End If
    End Sub

    Private Sub tbCustomerCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged

    End Sub
End Class