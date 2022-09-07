Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing

Public Class frmListSalesReturn

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ListofSalesReturn()
    End Sub

    Sub ListofSalesReturn()
        Dim qry As String = Nothing
        With dgvInvoiceList
            .Rows.Clear()
            If txtCustCode.Text <> Nothing Then
                qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                  "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                  "ON h.custcode=c.custcode WHERE idate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' and idate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' " & _
                                  "and h.isdeleted<>1 and ttype='R' and c.custcode like '" & txtCustCode.Text & "' ORDER BY h.idate desc"
            Else
                qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                  "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                                  "ON h.custcode=c.custcode WHERE idate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' and idate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' " & _
                                  "and h.isdeleted<>1 and ttype='R' ORDER BY h.idate desc"
            End If
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
                            .Item(4, r).Value = rdr("slmncode").ToString
                            .Item(5, r).Value = rdr("custname").ToString
                            .Item(6, r).Value = Format(CDbl(rdr("grosstot").ToString), "##,#00.00")
                            .Item(7, r).Value = Format(CDbl(rdr("disc1amount").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("disc2amount").ToString), "##,#00.00")
                            .Item(9, r).Value = .Item(6, r).Value - .Item(7, r).Value - .Item(8, r).Value
                        End While
                    End If
                End Using
            End Using

            Dim rx As Integer = 0
            dgvInvoiceList.RowCount += 1
            rx = dgvInvoiceList.RowCount - 1

            Dim inTotal As Double = Nothing
            Dim Gross As Double = Nothing
            Dim Disc1 As Double = Nothing
            Dim Disc2 As Double = Nothing
            Dim NetAmt As Double = Nothing
            For i = 0 To dgvInvoiceList.RowCount - 1
                Gross += dgvInvoiceList.Rows(i).Cells(6).Value
                Disc1 += dgvInvoiceList.Rows(i).Cells(7).Value
                Disc2 += dgvInvoiceList.Rows(i).Cells(8).Value
                NetAmt += dgvInvoiceList.Rows(i).Cells(9).Value
                dgvInvoiceList.Rows(i).Cells(0).Value = i + 1
            Next
            Me.txtGross.Text = Format((Gross), sFmat)
            Me.txtDisc1.Text = Format((Disc1), sFmat)
            Me.txtDisc2.Text = Format((Disc2), sFmat)
            Me.txtGrandTotal.Text = Format((NetAmt), sFmat)

            dgvInvoiceList.Item(5, rx).Value = "TOTALS"
            dgvInvoiceList.Item(6, rx).Value = Gross
            dgvInvoiceList.Item(7, rx).Value = Disc1
            dgvInvoiceList.Item(8, rx).Value = Disc2
            dgvInvoiceList.Item(9, rx).Value = NetAmt

            dgvInvoiceList.Item(5, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList.Item(6, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList.Item(7, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList.Item(8, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList.Item(9, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)

        End With
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtCustCode.Clear()
            txtCustomername.Clear()
            dgvInvoiceList.Rows.Clear()
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub txtCustCode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        frmSearchCustomer.Text = "LIST OF SALES RETURN"
        frmSearchCustomer.ShowDialog()
    End Sub

    Private Sub txtCustCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmSearchCustomer.Text = "LIST OF SALES RETURN"
            frmSearchCustomer.ShowDialog()
        End If
    End Sub

    Private Sub txtCustCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged
        If txtCustCode.Text <> Nothing Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub frmListSalesReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvInvoiceList
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
                Dim ds As New DataSet1
                Dim dt As DataTable = ds.Tables("dtListofSalesInvoices")
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

                        r1("rtitle") = "LIST OF SALES RETURN"
                        r1("sdate1") = sDate1.Text
                        r1("sdate2") = sDate2.Text
                        r1("idate") = .Item(3, i).Value
                        r1("invoiceno") = .Item(2, i).Value
                        r1("slmncode") = .Item(4, i).Value
                        r1("customer") = .Item(5, i).Value
                        r1("grossamt") = .Item(6, i).Value
                        r1("disc1") = .Item(7, i).Value
                        r1("disc2") = .Item(8, i).Value
                        r1("totalamt") = .Item(9, i).Value
                        r1("grosstot") = txtGross.Text
                        r1("disc1tot") = txtDisc1.Text
                        r1("disc2tot") = txtDisc2.Text
                        r1("netamttot") = txtGrandTotal.Text
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
                prep = New rptListofSalesInvoices
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