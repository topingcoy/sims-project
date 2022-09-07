Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions

Public Class frmListofSalesInvoicesDetailed

    Dim listofSalesInvoiceheader() As struct_salesinvoice_header
    Dim rwitemph As Integer = 0 'row item salesinvoice_header
    Structure struct_salesinvoice_header

        Dim transno As String
        Dim invoiceno As String
        Dim tdate As String

        Dim slmncode As String
        Dim custname As String
        Dim whscode As String

        Dim grosstot As Decimal
        Dim disc1amount As Decimal
        Dim disc2amount As Decimal
        Dim totalamt As Decimal


    End Structure
    Private Sub reset_salesinvoice_header()
        rwitemph = 0
        Erase listofSalesInvoiceheader
    End Sub
    Private Sub txtSlmncode_DoubleClick(sender As Object, e As EventArgs) Handles txtSlmncode.DoubleClick
        frmSearchSalesmanInv.Text = "SALESMAN LIST (Detailed Sales Invoice)"

        'frmSearchSalesmanInv.Show()
        'Dim inputText As String = txtSlmncode.Text
        'Dim result As String() = Regex.Split(inputText, ",")

        'If txtSlmncode.Text = "" Then
        '    frmSearchSalesmanInv.uncheckedAll()
        'End If
        'For Each s As String In result
        '    Dim str = s.Replace("'", "")
        '    str = str.Replace(" ", "")
        '    frmSearchSalesmanInv.searchAndChecked(str)
        'Next

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

    Private Sub txtSlmncode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSlmncode.KeyPress

    End Sub

    Private Sub txtSlmncode_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSlmncode.MouseDoubleClick

    End Sub

    Private Sub txtSlmncode_TextChanged(sender As Object, e As EventArgs) Handles txtSlmncode.TextChanged

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click


        reset_salesinvoice_header()

        dgvInvoiceList1.Rows.Clear()
        Dim srchmark As Integer = 0
        Dim qry As String = Nothing

        If txtCustCode.Text <> Nothing And txtSalesmanName.Text <> Nothing Then
            srchmark = 1


            Dim stringQueryCust As String = txtCustCode.Text
            Dim stringQuerySales As String = txtSlmncode.Text
            qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname,h.whscode,h.totalamt " & _
                "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                "AND h.isdeleted<>1 and ttype='S' and c.custcode IN ( " & stringQueryCust & ") " & _
                "OR s.slmncode IN ( " & stringQuerySales & ") " & _
                "ORDER BY h.tdate desc"

        ElseIf txtSlmncode.Text <> Nothing Then

            Dim stringQuery As String = txtSlmncode.Text
            srchmark = 3

            Dim orderbyquery As String = Nothing

            If chkSortCustomer.Checked = True Then
                orderbyquery = ", s.slmncode"
            End If

            qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname,h.whscode,h.totalamt " & _
             "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
             "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
             "ON h.custcode=c.custcode " & _
             "WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
             "AND h.isdeleted<>1 and ttype='S' and s.slmncode IN ( " & stringQuery & ") " & _
             "ORDER BY h.tdate " & orderbyquery & " desc"

        ElseIf txtCustCode.Text <> Nothing Then
            srchmark = 2
            Dim stringQuery As String = txtCustCode.Text

            Dim orderbyquery As String = Nothing

            If chkSortCustomer.Checked = True Then
                orderbyquery = ", c.custname"
            End If
            qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname,h.whscode,h.totalamt " & _
                "FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
                "ON h.custcode=c.custcode WHERE h.tdate BETWEEN @dt1 AND @dt2 " & _
                "AND h.isdeleted<>1 and ttype='S' and c.custcode IN ( " & stringQuery & ") " & _
                "ORDER BY h.tdate " & orderbyquery & " desc"
        Else
            srchmark = 4
            qry = "SELECT h.transno,h.invoiceno,h.tdate,h.grosstot,h.disc1amount,h.disc2amount,s.slmncode,c.custname,h.whscode,h.totalamt " & _
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
                cmd.Parameters.AddWithValue("@custcode", txtCustCode.Text)

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

                Dim n As Integer = 0
                If rdr.HasRows = True Then
                    While rdr.Read

                        '  n += 1


                        ReDim Preserve listofSalesInvoiceheader(rwitemph)
                        listofSalesInvoiceheader(rwitemph).transno = rdr.Item("transno").ToString()
                        listofSalesInvoiceheader(rwitemph).invoiceno = rdr.Item("invoiceno").ToString()
                        listofSalesInvoiceheader(rwitemph).tdate = rdr.Item("tdate").ToString()
                        listofSalesInvoiceheader(rwitemph).custname = rdr.Item("custname").ToString()
                        listofSalesInvoiceheader(rwitemph).slmncode = rdr.Item("slmncode").ToString()
                        listofSalesInvoiceheader(rwitemph).whscode = rdr.Item("whscode").ToString()
                        listofSalesInvoiceheader(rwitemph).grosstot = rdr.Item("grosstot").ToString()
                        listofSalesInvoiceheader(rwitemph).disc1amount = rdr.Item("disc1amount").ToString()
                        listofSalesInvoiceheader(rwitemph).disc2amount = rdr.Item("disc2amount").ToString()
                        listofSalesInvoiceheader(rwitemph).totalamt = rdr.Item("totalamt").ToString()

                        rwitemph += 1
                        '.Item(1, r).Value = rdr("invoiceno").ToString
                        '.Item(2, r).Value = rdr("tdate").ToString
                        '.Item(3, r).Value = rdr("slmncode").ToString
                        '.Item(4, r).Value = rdr("custname").ToString




                        '.Item(5, r).Value = rdr("sditemcode").ToString
                        '.Item(6, r).Value = Format(CDbl(rdr("grosstot").ToString), "##,#00.00")
                        '.Item(7, r).Value = Format(CDbl(rdr("disc1amount").ToString), "##,#00.00")
                        '.Item(8, r).Value = Format(CDbl(rdr("disc2amount").ToString), "##,#00.00")
                        '.Item(9, r).Value = Format(.Item(6, r).Value - .Item(7, r).Value - .Item(8, r).Value, "##,#00.00")
                    End While
                    'MsgBox("Master Kokoy Gwapo!", 64, "20k gcash")
                End If
            End Using
        End Using


        Dim r As DataGridViewRow
        Dim transnoquery As String = Nothing

        Dim cmd5 As MySqlCommand
        Dim rd5 As MySqlDataReader

        Dim costitem As Decimal = 0
        Dim profititem As Decimal = 0
        Dim amountitem As Decimal = 0

        '=========================totals==============
        Dim tcostitem As Decimal = 0
        Dim tprofititem As Decimal = 0
        Dim tamountitem As Decimal = 0
        '=========================totals==============

        '=========================Grand totals==============
        Dim gtcostitem As Decimal = 0
        Dim gtprofititem As Decimal = 0
        Dim gtamountitem As Decimal = 0

        '=========================Grand totals==============
        Dim rx As Integer = 0

        For x As Integer = 0 To rwitemph - 1


            r = New DataGridViewRow
            r.CreateCells(dgvInvoiceList1)


            transnoquery = listofSalesInvoiceheader(x).transno
            r.Cells(1).Value = listofSalesInvoiceheader(x).invoiceno
            r.Cells(2).Value = listofSalesInvoiceheader(x).tdate
            r.Cells(3).Value = listofSalesInvoiceheader(x).slmncode
            r.Cells(4).Value = listofSalesInvoiceheader(x).custname

            cmd5 = New MySqlCommand("SELECT d.transno as dtransno, d.itemcode as ditemcode, d.qty as dqty, d.qunit as dqunit, " & _
                                    "d.amount as damount, i.description as idesc, d.cost as dcost " & _
                               "FROM salesd d LEFT JOIN ivitem i ON d.itemcode = i.itemcode " & _
                               "WHERE d.transno = @transno", cdb)

            cmd5.Parameters.AddWithValue("@transno", transnoquery)
            rd5 = cmd5.ExecuteReader

            amountitem = 0
            costitem = 0
            profititem = 0


            tamountitem = 0
            tcostitem = 0
            tprofititem = 0

            While rd5.Read

                r.Cells(5).Value = rd5.Item("ditemcode").ToString()
                r.Cells(6).Value = rd5.Item("idesc").ToString()
                r.Cells(7).Value = rd5.Item("dqty").ToString()
                r.Cells(8).Value = rd5.Item("dqunit").ToString()

                amountitem = Val(rd5.Item("damount").ToString())
                costitem = Val(rd5.Item("dcost").ToString())
                profititem = amountitem - costitem

                tamountitem = tamountitem + amountitem
                tcostitem = tcostitem + costitem
                tprofititem = tprofititem + profititem

                r.Cells(9).Value = Format(CDbl(amountitem), "##,#00.00")
                r.Cells(10).Value = Format(CDbl(costitem), "##,#00.00")
                r.Cells(11).Value = Format(CDbl(profititem), "##,#00.00")

                dgvInvoiceList1.Rows.Add(r)
                r = New DataGridViewRow
                r.CreateCells(dgvInvoiceList1)
            End While
            rd5.Close()
            cmd5.Dispose()


            dgvInvoiceList1.RowCount += 1
            rx = dgvInvoiceList1.RowCount - 1


            dgvInvoiceList1.Item(6, rx).Value = "Sub-total>>>"
            dgvInvoiceList1.Item(9, rx).Value = Format(tamountitem, "##,#00.00")
            dgvInvoiceList1.Item(10, rx).Value = Format(tcostitem, "##,#00.00")
            dgvInvoiceList1.Item(11, rx).Value = Format(tprofititem, "##,#00.00")


            dgvInvoiceList1.Item(6, rx).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvInvoiceList1.Item(6, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(9, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(10, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            dgvInvoiceList1.Item(11, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
            gtamountitem = gtamountitem + tamountitem
            gtcostitem = gtcostitem + tcostitem
            gtprofititem = gtprofititem + tprofititem
        Next
        'dgvInvoiceList1.Rows.Add(r)
 
        rx = 0
        dgvInvoiceList1.RowCount += 1
        rx = dgvInvoiceList1.RowCount - 1


        r = New DataGridViewRow
        r.CreateCells(dgvInvoiceList1)


        dgvInvoiceList1.Item(6, rx).Value = "TOTAL=====>>"
        dgvInvoiceList1.Item(9, rx).Value = Format(gtamountitem, "##,#00.00")
        dgvInvoiceList1.Item(10, rx).Value = Format(gtcostitem, "##,#00.00")
        dgvInvoiceList1.Item(11, rx).Value = Format(gtprofititem, "##,#00.00")

        Me.txtAmount.Text = Format(gtamountitem, "##,#00.00")
        Me.txtCost.Text = Format(gtcostitem, "##,#00.00")
        Me.txtProfit.Text = Format(gtprofititem, "##,#00.00")
        ' Me.txtGrandTotal.Text = Format((NetAmt), sFmat)

        dgvInvoiceList1.Item(6, rx).Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvInvoiceList1.Item(6, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
        dgvInvoiceList1.Item(9, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
        dgvInvoiceList1.Item(10, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)
        dgvInvoiceList1.Item(11, rx).Style.Font = New Font(Font, Font.Style Or FontStyle.Bold)

    End Sub

    Private Sub chkSalesman_CheckedChanged(sender As Object, e As EventArgs) Handles chkSalesman.CheckedChanged
        If chkSalesman.Checked = True Then
            txtSlmncode.Text = Nothing
            txtSalesmanName.Clear()
            chkSortSalesman.Enabled = False

        End If
    End Sub

    Private Sub chkCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustomer.CheckedChanged
        If chkCustomer.Checked = True Then
            'txtSlmncode.Text = Nothing
            txtCustCode.Text = Nothing
            txtCustomername.Text = Nothing
            chkSortCustomer.Enabled = False
        End If
    End Sub

    Private Sub txtCustCode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        frmSearchCustomer.Text = "CUSTOMER LIST (Detailed Sales Invoice)"


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
                .selectedName = "," & txtCustomername.Text '& ","
            End With
        End If
        For Each s As String In result
            Dim str = s.Replace("'", "")
            str = str.Replace(" ", "")
            frmSearchCustomer.searchAndChecked(str)
        Next
       
    End Sub

    Private Sub frmListofSalesInvoicesDetailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvInvoiceList1.Rows.Clear()
        txtSlmncode.Clear()
        txtCustCode.Clear()

    End Sub

    Private Sub txtCustCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged

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
                Dim dt As DataTable = ds.Tables("dtListofSalesInvoicesDetails")
                Dim r1 As DataRow
                dt.Rows.Clear()
                '  Dim chkflag As Boolean = False
                grpno = 29
                ' grpno = 29
                '   Dim cntr As Integer = 0
                '  Dim grid As Integer = 1

                For i = 0 To .RowCount - 2
                    ' pbar1.Value += 1
                    'pbar1.Refresh()
                    ' r1 = dt.NewRow()
                    pbar1.Value += 1
                    'If .Item(0, i).Value <> Nothing And .Item(1, i).Value <> Nothing Then
                    '    cntr += 1
                    'If .Item(3, i).Value <> Nothing Then
                    r1 = dt.NewRow()

                    r1("rtitle") = "LIST OF DETAILED SALES INVOICES"
                    r1("sdate1") = sDate1.Text
                    r1("sdate2") = sDate2.Text
                    r1("idate") = .Item(2, i).Value
                    r1("invoiceno") = .Item(1, i).Value
                    r1("slmncode") = .Item(3, i).Value
                    r1("customer") = .Item(4, i).Value
                    r1("itemcode") = .Item(5, i).Value
                    r1("item_description") = .Item(6, i).Value
                    If .Item(7, i).Value <> Nothing Then
                        r1("qty") = .Item(7, i).Value
                    End If

                    r1("unit") = .Item(8, i).Value
                    r1("price") = .Item(9, i).Value
                    r1("cost") = .Item(10, i).Value

                    r1("profit") = .Item(11, i).Value

                    r1("tamount") = txtAmount.Text
                    r1("tcost") = txtCost.Text
                    r1("tprofit") = txtProfit.Text
                    r1("grpno") = grid


                    pbar1.Refresh()
                    dt.Rows.Add(r1)
                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                    'End If

                Next
                'pbar1.Visible = False
                prep = New rptListofSalesInvoicesDetailed
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