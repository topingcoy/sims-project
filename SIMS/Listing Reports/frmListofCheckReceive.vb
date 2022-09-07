Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing

Public Class frmlistofCheckReceive

    Private Sub txtCustcode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustcode.DoubleClick
        dgvPayment.Rows.Clear()
        frmSearchCustomer.Text = "CHECK RECEIVE FROM COLLECTION"
        frmSearchCustomer.ShowDialog()
    End Sub

    Private Sub txtCustcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustcode.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtSlmncode_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub frmlistofCheckReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPayment.Rows.Clear()
        cbxSlmncode.Text = Nothing
        txtSalesman.Clear()
        txtCustcode.Clear()
        txtTotal.Clear()
        txtCustomername.Clear()
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        LoadSalesman()
    End Sub

    Private Sub cbxSlmncode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSlmncode.KeyPress
        e.Handled = True
    End Sub

    Sub LoadSalesman()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand
        cbxSlmncode.Items.Clear()
        cbxSlmncode.DisplayMember = "text"
        qry = "Select * from salesman ORDER BY slmnname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxSlmncode.Items.Add(New With {.Text = relr("slmncode").ToString(), .Value = relr("slmncode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txtCustcode.Clear()
            txtCustomername.Clear()
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim slm As String = Nothing
        Dim cust As String = Nothing

        If cbxSlmncode.Text <> Nothing Then
            slm = cbxSlmncode.Text
        End If

        If txtCustcode.Text <> Nothing Then
            cust = txtCustcode.Text
        End If

        If cbxSlmncode.Text = Nothing And txtCustcode.Text <> Nothing Then
            MsgBox("Please select salesman!", vbExclamation)
            Exit Sub
        End If

        With dgvPayment
            .Rows.Clear()
            Dim sD1 As Date
            Dim sD2 As Date

            sD1 = sDate1.Value
            sD2 = sDate2.Value

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            If slm = Nothing And cust = Nothing Then
                cmd = New MySqlCommand("SELECT h.transno,h.docno,h.ttype,h.edate,d.reftype, d.refno,d.refamt,d.refdoc, " & _
                                       "d.bank,d.checkno,d.checkdate,c.custname,s.slmnname " & _
                                       "FROM expresh h LEFT JOIN expresd d ON h.transno=d.transno " & _
                                       "LEFT JOIN customers c ON d.custcode=c.custcode " & _
                                       "LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                                       "WHERE h.edate BETWEEN @dt1 AND @dt2 and h.isdeleted<>1 and checkno<>'CASH' and " & _
                                       "d.reftype='S' ORDER BY custname asc", cdb)
                ' cmd.Parameters.AddWithValue("@slmncode", slm)
                cmd.Parameters.AddWithValue("@dt1", sD1.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@dt2", sD2.ToString("yyyy-MM-dd"))
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("custname").ToString
                            .Item(2, rw).Value = rd("bank").ToString
                            .Item(3, rw).Value = rd("checkno").ToString
                            .Item(4, rw).Value = rd("checkdate").ToString
                            .Item(5, rw).Value = Format(CDbl(rd("refamt").ToString), "##,##0.00")
                            .Item(6, rw).Value = rd("edate").ToString
                        End While
                    End If
                    gettotal()
                End Using
            End If

            If slm <> Nothing And cust = Nothing Then
                cmd = New MySqlCommand("SELECT h.transno,h.docno,h.ttype,h.edate,d.reftype, d.refno,d.refamt,d.refdoc, " & _
                                       "d.bank,d.checkno,d.checkdate,c.custname,s.slmnname " & _
                                       "FROM expresh h LEFT JOIN expresd d ON h.transno=d.transno " & _
                                       "LEFT JOIN customers c ON d.custcode=c.custcode " & _
                                       "LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                                       "WHERE h.edate BETWEEN @dt1 AND @dt2 and h.isdeleted<>1 and checkno<>'CASH' and " & _
                                       "s.slmncode=@slmncode and d.reftype='S' ORDER BY custname asc", cdb)
                cmd.Parameters.AddWithValue("@slmncode", slm)
                cmd.Parameters.AddWithValue("@dt1", sD1.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@dt2", sD2.ToString("yyyy-MM-dd"))
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("custname").ToString
                            .Item(2, rw).Value = rd("bank").ToString
                            .Item(3, rw).Value = rd("checkno").ToString
                            .Item(4, rw).Value = rd("checkdate").ToString
                            .Item(5, rw).Value = Format(CDbl(rd("refamt").ToString), "##,##0.00")
                            .Item(6, rw).Value = rd("edate").ToString
                        End While
                    End If
                    gettotal()
                End Using
            End If

            If slm <> Nothing And cust <> Nothing Then
                cmd = New MySqlCommand("SELECT h.transno,h.docno,h.ttype,h.edate,d.reftype, d.refno,d.refamt,d.refdoc, " & _
                                       "d.bank,d.checkno,d.checkdate,c.custname,s.slmnname " & _
                                       "FROM expresh h LEFT JOIN expresd d ON h.transno=d.transno " & _
                                       "LEFT JOIN customers c ON d.custcode=c.custcode " & _
                                       "LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                                       "WHERE h.edate BETWEEN @dt1 AND @dt2 and h.isdeleted<>1 and checkno<>'CASH' " & _
                                       "and d.slmncode=@slmncode and d.custcode=@cust and d.reftype='S' ORDER BY custname asc", cdb)
                cmd.Parameters.AddWithValue("@slmncode", slm)
                cmd.Parameters.AddWithValue("@cust", cust)
                cmd.Parameters.AddWithValue("@dt1", sD1.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@dt2", sD2.ToString("yyyy-MM-dd"))
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("custname").ToString
                            .Item(2, rw).Value = rd("bank").ToString
                            .Item(3, rw).Value = rd("checkno").ToString
                            .Item(4, rw).Value = rd("checkdate").ToString
                            .Item(5, rw).Value = Format(CDbl(rd("refamt").ToString), "##,##0.00")
                            .Item(6, rw).Value = rd("edate").ToString
                        End While
                    End If
                    gettotal()
                End Using
            End If
        End With

    End Sub

    Private Sub cbxSlmncode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSlmncode.SelectedIndexChanged
        dgvPayment.Rows.Clear()
        cmd = New MySqlCommand("SELECT * from salesman where slmncode like '%" & cbxSlmncode.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtSalesman.Text = rd.Item("slmnname").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub txtCustcode_TextChanged(sender As Object, e As EventArgs) Handles txtCustcode.TextChanged
        dgvPayment.Rows.Clear()
    End Sub

    Sub gettotal()
        With dgvPayment
            Dim mytots As Decimal = 0
            For i = 0 To .RowCount - 1
                mytots += .Item(5, i).Value
            Next
            txtTotal.Text = Format(mytots, "STANDARD")
        End With
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            cbxSlmncode.Text = Nothing
            txtSalesman.Clear()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvPayment
            mmax = .RowCount
            pbar1.Maximum = mmax

            dt.Rows.Clear()
            Dim chkflag As Boolean = False
            'grpno = 10
            grpno = 29
            Dim cntr As Integer = 0
            Dim grid As Integer = 1

            If .RowCount > 0 Then
                'pbar1.Visible = True
                'pbar1.Maximum = .RowCount
                'pbar1.Value = 0
                .EndEdit()
                Dim prep As New ReportDocument
                Dim ds As New DataSet2
                Dim dt As DataTable = ds.Tables("dtCheckColl")
                Dim r1 As DataRow
                dt.Rows.Clear()
                '  Dim chkflag As Boolean = False
                grpno = 29
                ' grpno = 29
                '   Dim cntr As Integer = 0
                '  Dim grid As Integer = 1

                For i = 0 To .RowCount - 1
                    'pbar1.Value += 1
                    'pbar1.Refresh()
                    ' r1 = dt.NewRow()
                    pbar1.Value += 1
                    'If .Item(0, i).Value <> Nothing And .Item(1, i).Value <> Nothing Then
                    '    cntr += 1
                    If .Item(3, i).Value <> Nothing Then
                        r1 = dt.NewRow()

                        Dim sd1 As Date = sDate1.Value
                        Dim sd2 As Date = sDate2.Value
                        r1("rtitle") = "CHECK RECEIVE FROM COLLECTION"
                        r1("sdate1") = Format(sd1, "MM/dd/yyyy")
                        r1("sdate2") = Format(sd2, "MM/dd/yyyy")
                        r1("slmnname") = txtSalesman.Text
                        r1("custname") = .Item(1, i).Value
                        r1("bank") = .Item(2, i).Value
                        r1("checkno") = .Item(3, i).Value
                        r1("checkdate") = .Item(4, i).Value
                        r1("amount") = .Item(5, i).Value
                        r1("datepaid") = .Item(6, i).Value
                        r1("totalamt") = txtTotal.Text
                        r1("grpno") = grid
                        pbar1.Refresh()
                        dt.Rows.Add(r1)
                        If cntr = grpno Then
                            grid += 1
                            cntr = 0
                        End If
                    End If

                Next
                'pbar1.Visible = False
                prep = New rptListofCheckColl
                prep.SetDataSource(ds)
                frmReport.CRportRcv.ReportSource = prep
                frmReport.CRportRcv.Refresh()
                frmReport.Dock = DockStyle.Fill
                frmReport.Show()
                pbar1.Visible = False
            Else
                MsgBox("No records found to print!", 48, "Insufficient Rows!")
            End If
        End With
    End Sub
End Class