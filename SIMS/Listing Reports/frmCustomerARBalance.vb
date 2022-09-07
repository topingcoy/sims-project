Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing


Public Class frmCustomerARBalance

    Private Sub tbSelectCustomer_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        dgvARBalance.Rows.Clear()
        frmSearchCustomer.Text = "CUSTOMER A/R BALANCE"
        frmSearchCustomer.ShowDialog()
    End Sub

    Private Sub txtCustCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            dgvARBalance.Rows.Clear()
            frmSearchCustomer.Text = "CUSTOMER A/R BALANCE"
            frmSearchCustomer.ShowDialog()
        End If
    End Sub

    Private Sub txtCustCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustCode.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim Comulative As Decimal = 0
        Dim i As Integer

        dgvARBalance.Rows.Clear()

        Dim ccode As String = Nothing

        If txtCustCode.Text.Trim <> Nothing Then
            ccode = txtCustCode.Text
        End If

        With dgvARBalance

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            If ccode <> Nothing Then
                cmd = New MySqlCommand("SELECT * FROM salesh WHERE custcode=@custcode and totalamt>applied and terms<>'CASH' and isdeleted<>1 order by tdate asc", cdb)
                cmd.Parameters.AddWithValue("@custcode", ccode)

                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("tdate").ToString
                            .Item(2, rw).Value = rd("ttype").ToString
                            .Item(3, rw).Value = rd("invoiceno").ToString
                            .Item(4, rw).Value = rd("pono").ToString
                            If .Item(2, rw).Value = "S" Then
                                .Item(5, rw).Value = Format(CDbl(rd("totalamt").ToString), "#,#00.00")
                            Else
                                .Item(5, rw).Value = -Format(CDbl(rd("totalamt").ToString), "#,#00.00")
                            End If
                            .Item(6, rw).Value = Format(CDbl(rd("applied").ToString), "#,#00.00")

                            If .Item(2, rw).Value = "S" Then
                                .Item(7, rw).Value = .Item(5, rw).Value - .Item(6, rw).Value
                            Else
                                .Item(7, rw).Value = .Item(5, rw).Value + .Item(6, rw).Value
                            End If

                            If i = 0 Then
                                ' .Item(8, rw).Value = .Item(7, rw).Value
                                .Rows(i).Cells(8).Value = dgvARBalance.Rows(i).Cells(7).Value
                            Else
                                '   .Item(8, rw).Value = .rowindex.(i - 1).Item(7, rw).Value +  .Item(7, rw).Value
                                .Rows(i).Cells(8).Value = .Rows(i - 1).Cells(7).Value + .Rows(i).Cells(6).Value
                            End If
                            .Rows(i).Cells(8).Value = dgvARBalance.Rows(i).Cells(8).Value
                            '8 = commulative

                            ' .Item(8, rw).Value = .

                        End While
                    End If

                End Using

            End If
            compute_commulative()


        End With
    End Sub
    Private Sub compute_commulative()
        With dgvARBalance
            If .RowCount > 0 Then
                Dim comu As Decimal = 0
                Dim bals As Decimal = 0

                For i = 0 To .RowCount - 1
                    bals = Decimal.Parse(.Item(7, i).Value)
                   
                    comu += bals
                    .Item(8, i).Value = comu
                Next

            End If
        End With
    End Sub
    Private Sub frmCustomerARBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustCode.Clear()
        txtCustomername.Clear()
        dgvARBalance.Rows.Clear()
    End Sub

    Private Sub txtCustCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvARBalance
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
                Dim dt As DataTable = ds.Tables("dtCustomerARBalance")
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
                        r1("custname") = txtCustomername.Text
                        r1("edate") = .Item(1, i).Value
                        r1("type") = .Item(2, i).Value
                        r1("docno") = .Item(3, i).Value
                        r1("pono") = .Item(4, i).Value
                        r1("amount") = .Item(5, i).Value
                        r1("payment") = .Item(6, i).Value
                        r1("balance") = .Item(7, i).Value
                        r1("comm") = .Item(8, i).Value
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
                prep = New rptCustomerARBalance
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