Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions


Public Class frmListSalesInvoices

    Private Sub frmListSalesInvoices_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmListSalesInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvInvoiceList1.Rows.Clear()
        'chkSalesman.Checked = True
        'chkCustomer.Checked = True
    End Sub

    Sub LoadListofSalesInvoices()
        Dim qry As String = Nothing


        With dgvInvoiceList1
            .Rows.Clear()
            Dim srchmark As Integer = 0

            'qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname " & _
            '        "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
            '    "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
            '    "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
            '    "AND h.isdeleted<>1 and ttype='S' and s.slmncode IN (@slmcod) " & _
            '    "ORDER BY h.tdate desc"


            'Using cmd = New MySqlCommand()
            '    cmd.Parameters.AddWithValue("@dt1", sDate1.Value.ToString("yyyy-MM-dd"))
            '    cmd.Parameters.AddWithValue("@dt2", sDate2.Value.ToString("yyyy-MM-dd"))
            '    cmd.Parameters.AddWithValue("@slmcod", txtSlmncode.Text)


            If txtCustCode.Text <> Nothing And txtSalesmanName.Text <> Nothing Then
                srchmark = 1
                'qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname " & _
                '  "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                '  "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                '  "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                '  "AND h.isdeleted<>1 and ttype='S' and c.custcode =@ccode AND s.slmncode=@slmcod  " & _
                '  "ORDER BY h.tdate desc"

                Dim stringQueryCust As String = txtCustCode.Text
                Dim stringQuerySales As String = txtSlmncode.Text
                qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname " & _
                    "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                    "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                    "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                    "AND h.isdeleted<>1 and ttype='S' and c.custcode IN ( " & stringQueryCust & ") " & _
                    "OR s.slmncode IN ( " & stringQuerySales & ") " & _
                    "ORDER BY h.tdate desc"



            ElseIf txtCustCode.Text <> Nothing Then
                srchmark = 2
                Dim stringQuery As String = txtCustCode.Text

                Dim orderbyquery As String = Nothing

                If chkSortCustomer.Checked = True Then
                    orderbyquery = ", c.custname"
                End If
                qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname " & _
                    "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                    "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                    "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                    "AND h.isdeleted<>1 and ttype='S' and c.custcode IN ( " & stringQuery & ") " & _
                    "ORDER BY h.tdate " & orderbyquery & " desc"
            ElseIf txtSlmncode.Text <> Nothing Then

                Dim stringQuery As String = txtSlmncode.Text
                srchmark = 3

                Dim orderbyquery As String = Nothing

                If chkSortCustomer.Checked = True Then
                    orderbyquery = ", s.slmncode"
                End If

                qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname " & _
                 "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                 "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                 "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                 "AND h.isdeleted<>1 and ttype='S' and s.slmncode IN ( " & stringQuery & ") " & _
                 "ORDER BY h.tdate " & orderbyquery & " desc"

                '"AND h.isdeleted<>1 and ttype='S' and s.slmncode IN ('O','A') " & _
            Else
                srchmark = 4
                qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname " & _
                    "FROM salesh h " & _
                    "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                    "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                    "AND h.isdeleted<>1 and ttype='S' ORDER BY h.tdate desc"
            End If
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                If srchmark = 1 Then
                    cmd.Parameters.AddWithValue("@dt1", sDate1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dt2", sDate2.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ccode", txtCustCode.Text.Trim)
                    cmd.Parameters.AddWithValue("@slmcod", txtSlmncode.Text.Trim)
                ElseIf srchmark = 2 Then
                    cmd.Parameters.AddWithValue("@dt1", sDate1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dt2", sDate2.Value.ToString("yyyy-MM-dd"))
                    ' cmd.Parameters.AddWithValue("@ccode", txtCustCode.Text.Trim)
                ElseIf srchmark = 3 Then
                    cmd.Parameters.AddWithValue("@dt1", sDate1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dt2", sDate2.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@slmcod", txtSlmncode.Text)
                ElseIf srchmark = 4 Then
                    cmd.Parameters.AddWithValue("@dt1", sDate1.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dt2", sDate2.Value.ToString("yyyy-MM-dd"))
                End If

                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            r = .RowCount - 1
                            n += 1
                            .Item(0, r).Value = n
                            .Item(1, r).Value = rdr("transno").ToString
                            .Item(2, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Value = rdr("tdate").ToString
                            .Item(4, r).Value = rdr("slmncode").ToString
                            .Item(5, r).Value = rdr("custname").ToString
                            .Item(6, r).Value = Format(CDbl(rdr("grosstot").ToString), "##,#00.00")
                            .Item(7, r).Value = Format(CDbl(rdr("disc1amount").ToString), "##,#00.00")
                            .Item(8, r).Value = Format(CDbl(rdr("disc2amount").ToString), "##,#00.00")
                            .Item(9, r).Value = Format(.Item(6, r).Value - .Item(7, r).Value - .Item(8, r).Value, "##,#00.00")
                        End While
                        MsgBox("Master Kokoy Gwapo!", 64, "20k gcash")
                    End If
                End Using
            End Using

            Dim rx As Integer = 0
            dgvInvoiceList1.RowCount += 1
            rx = dgvInvoiceList1.RowCount - 1

            Dim inTotal As Double = Nothing
            Dim Gross As Double = Nothing
            Dim Disc1 As Double = Nothing
            Dim Disc2 As Double = Nothing
            Dim NetAmt As Double = Nothing
            For i = 0 To dgvInvoiceList1.RowCount - 1
                Gross += dgvInvoiceList1.Rows(i).Cells(6).Value
                Disc1 += dgvInvoiceList1.Rows(i).Cells(7).Value
                Disc2 += dgvInvoiceList1.Rows(i).Cells(8).Value
                NetAmt += dgvInvoiceList1.Rows(i).Cells(9).Value

            Next
            Me.txtGross.Text = Format((Gross), sFmat)
            Me.txtDisc1.Text = Format((Disc1), sFmat)
            Me.txtDisc2.Text = Format((Disc2), sFmat)
            Me.txtGrandTotal.Text = Format((NetAmt), sFmat)

            dgvInvoiceList1.Item(5, rx).Value = "TOTALS"
            dgvInvoiceList1.Item(6, rx).Value = Format(Gross, "##,#00.00")
            dgvInvoiceList1.Item(7, rx).Value = Format(Disc1, "##,#00.00")
            dgvInvoiceList1.Item(8, rx).Value = Format(Disc2, "##,#00.00")
            dgvInvoiceList1.Item(9, rx).Value = Format(NetAmt, "##,#00.00")

            dgvInvoiceList1.Item(5, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(6, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(7, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(8, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(9, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)

        End With

    End Sub

    Private Sub txtSlmncode_DoubleClick(sender As Object, e As EventArgs) Handles txtSlmncode.DoubleClick
        ' frmSearchSalesmanInv.Text = "SALESMAN'S LIST"
        'If txtSlmncode.Text <> Nothing And txtSalesmanName.Text <> Nothing Then
        '    txtSlmncode.Text = Nothing
        '    txtSalesmanName.Text = Nothing
        'End If
        'frmSearchSalesmanInv.Text = "LIST OF SALES INVOICES"
        'frmSearchSalesmanInv.ShowDialog()

        frmSearchSalesmanInv.Show()
        Dim inputText As String = txtSlmncode.Text
        Dim result As String() = Regex.Split(inputText, ",")

        If txtSlmncode.Text = "" Then
            frmSearchSalesmanInv.uncheckedAll()
        Else
            With frmSearchSalesmanInv
                .txtSlmncode.Text = "," & txtSlmncode.Text
                .selectedValue = "," & txtSlmncode.Text '& ","
                .txtSalesmanName.Text = "," & txtSalesmanName.Text
                .selectedName = "," & txtSalesmanName.Text '& ","
            End With
        End If
        For Each s As String In result
            Dim str = s.Replace("'", "")
            str = str.Replace(" ", "")
            frmSearchSalesmanInv.searchAndChecked(str)
        Next
    End Sub

    Private Sub tbCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSlmncode.KeyDown
        'If e.KeyCode = Keys.F2 Then
        '    frmSearchSalesmanInv.ShowDialog()
        'End If
        If e.KeyCode = Keys.F2 Then
            '  frmSearchSalesmanInv.Text = "SALESMAN'S LIST"
            frmSearchSalesmanInv.ShowDialog()
        End If
    End Sub

    Private Sub tbWhs_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            frmSearchWarehouse.ShowDialog()
        End If
    End Sub

    Private Sub txtCustCode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        'txtCustCode.Text = Nothing
        'txtCustomername.Text = Nothing
        ' frmSearchCustomer.Text = "LIST OF SALES INVOICES"

        'Dim inputText As String = txtCustCode.Text
        'Dim result As String() = Regex.Split(inputText, ",")


        'For Each s As String In result
        '    Dim str = s.Replace("'", "")
        '    str = str.Replace(" ", "")
        '    frmSearchCustomer.searchAndChecked(str)
        'Next




        frmSearchCustomer.Show()
        Dim inputText As String = txtCustCode.Text
        Dim result As String() = Regex.Split(inputText, ",")

        If txtCustCode.Text = "" Then
            frmSearchCustomer.uncheckedAll()
        Else
            With frmSearchCustomer
                .txtCustCode.Text = "," & txtCustCode.Text
                .selectedValue = "," & txtCustCode.Text '& ","
                .txtCustomername.Text = "," & txtCustomername.Text
                .selectedName = "," & txtCustomername.Text ' & ","
            End With
        End If
        For Each s As String In result
            Dim str = s.Replace("'", "")
            str = str.Replace(" ", "")
            frmSearchCustomer.searchAndChecked(str)
        Next

    End Sub

    Private Sub txtCustCode_Enter(sender As Object, e As EventArgs) Handles txtCustCode.Enter

    End Sub

    Private Sub txtCustCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            txtCustCode.Text = Nothing
            txtCustomername.Text = Nothing
            chkCustomer.Checked = False
            frmSearchCustomer.Text = "LIST OF SALES INVOICES"
            frmSearchCustomer.ShowDialog()
        End If
    End Sub

    Private Sub txtCustCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged
        'If txtCustCode.Text <> Nothing Then
        '    chkSalesman.Checked = False
        'End If

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        LoadListofSalesInvoices()
        ' SumAmount()
    End Sub

    Sub SumAmount()
        'With dgvInvoiceList
        '    Dim GrossAmt As Decimal = 0
        '    Dim TotDisc1 As Decimal = 0
        '    Dim TotDisc2 As Decimal = 0
        '    Dim NetAmt As Decimal = 0
        '    Dim TotalDisc As Decimal = 0

        '    For Each Amt As DataGridViewRow In dgvInvoiceList.Rows
        '        If Amt.Cells(6).Value > 0 Then
        '            GrossAmt += Amt.Cells(6).Value
        '            lblGrossAmt.Text = Format(CDbl(GrossAmt), "##,##0.00")
        '        End If

        '        If Amt.Cells(7).Value > 0 Then
        '            TotDisc1 += Amt.Cells(7).Value
        '            lblTotDisc1.Text = Format(CDbl(TotDisc1), "##,##0.00")
        '        End If

        '        If Amt.Cells(8).Value > 0 Then
        '            TotDisc2 += Amt.Cells(8).Value
        '            lblTotDisc2.Text = Format(CDbl(TotDisc2), "##,##0.00")
        '        End If

        '        If Amt.Cells(9).Value > 0 Then
        '            NetAmt += Amt.Cells(9).Value
        '            lblNetAmount.Text = Format(CDbl(NetAmt), "##,##0.00")
        '        End If

        '        TotalDisc = TotDisc1 + TotDisc2
        '        lblTotalDisc.Text = Format(CDbl(TotalDisc), "##.##0.00")
        '    Next
        'End With
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkSalesman.CheckedChanged

        'If chkSalesman.Checked = True Then
        '    txtCustCode.Clear()
        '    txtCustomername.Clear()
        '    dgvInvoiceList1.Rows.Clear()
        'Else
        '    chkSalesman.Checked = False
        'End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvInvoiceList1
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

                        r1("rtitle") = "LIST OF SALES INVOICES"
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

    Private Sub txtSlmncode_TextChanged(sender As Object, e As EventArgs) Handles txtSlmncode.TextChanged
        'If txtSlmncode.Text <> Nothing Then
        '    chkCustomer.Checked = False
        '    txtSalesmanName.Text = Nothing
        'End If

    End Sub

    Private Sub chkSlman_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustomer.CheckedChanged
        If chkCustomer.Checked = True Then
            'txtSlmncode.Text = Nothing
            txtCustCode.Text = Nothing
            txtCustomername.Text = Nothing
        End If
    End Sub

End Class