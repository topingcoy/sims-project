Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing

Public Class frmListofExpresColl

    Private Sub frmListofExpresColl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPayment.Rows.Clear()

    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim cmd As MySqlCommand
        Dim i As Integer
        Dim trnos() As String
        Dim dcnos() As String
        Dim xx As Integer = 0

        ReDim trnos(xx)
        ReDim dcnos(xx)

        With dgvPayment
            Dim start As Integer = 0
            .Rows.Clear()
            Dim temptrans As String = Nothing
            Dim dcno As String = Nothing
            Dim dt1 As Date
            Dim dt2 As Date
            dt1 = dtpListInvoiceStart.Value
            dt2 = dtpListInvoiceEnd.Value

            cmd = New MySqlCommand("SELECT h.transno,h.docno FROM expresh h WHERE h.edate " & _
                                   " BETWEEN @dt1 AND @dt2 ORDER BY h.transno,h.edate", cdb)
            cmd.Parameters.AddWithValue("@dt1", dt1.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@dt2", dt2.ToString("yyyy-MM-dd"))
            Using rr As MySqlDataReader = cmd.ExecuteReader
                If rr.HasRows Then
                    While rr.Read()
                        temptrans = rr("transno").ToString
                        dcno = rr("docno").ToString
                        ReDim Preserve trnos(xx)
                        ReDim Preserve dcnos(xx)
                        trnos(xx) = temptrans
                        dcnos(xx) = dcno
                        xx += 1
                    End While
                End If
            End Using
            cmd.Dispose()

            temptrans = trnos(0)
            For i = 0 To xx - 1

                cmd = New MySqlCommand("SELECT h.transno,h.ttype,h.edate,d.reftype, d.refno,d.refamt,d.refdoc,d.bank,d.checkno," & _
                                   "d.checkdate,c.custname,s.slmnname FROM expresh h " & _
                                   "LEFT JOIN expresd d ON h.transno=d.transno " & _
                                   "LEFT JOIN customers c ON d.custcode=c.custcode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                                   "WHERE h.isdeleted<>1 AND h.transno=@trn " & _
                                   " ORDER BY h.transno, h.edate, s.slmnname, c.custname", cdb)
                cmd.Parameters.AddWithValue("@trn", trnos(i))
                rd = cmd.ExecuteReader
                Dim rx As Integer = 0
                Dim temptots As Decimal = 0
                Dim che As Boolean = False

                Dim restart As Integer = 0
                While rd.Read
                    ' i += 1
                    .RowCount += 1
                    rx = .RowCount - 1

                    If temptrans <> trnos(i) Then
                        temptrans = trnos(i)

                        .Item(0, rx).Tag = temptrans
                        .Item(0, rx).Value = dcnos(i)

                        .Item(1, rx).Value = rd("slmnname").ToString
                        .Item(2, rx).Value = rd("edate").ToString
                        .Item(3, rx).Value = rd("custname").ToString
                        .Item(4, rx).Value = rd("reftype").ToString & "-" & rd("refno").ToString
                        .Item(5, rx).Value = Format(rd("refamt").ToString, "STANDARD")
                        .Item(6, rx).Value = rd("bank").ToString
                        .Item(7, rx).Value = rd("checkno").ToString
                        .Item(8, rx).Value = rd("checkdate").ToString

                        che = True
                        start = 1


                    Else

                        If start = 0 Then

                            .Item(0, rx).Tag = temptrans
                            .Item(0, rx).Value = dcnos(i)
                            .Item(1, rx).Value = rd("slmnname").ToString
                            .Item(2, rx).Value = rd("edate").ToString
                            start = 1
                        Else
                            .Item(0, rx).Tag = temptrans
                            .Item(1, rx).Tag = dcnos(i)
                            start = 1
                        End If

                        .Item(3, rx).Value = rd("custname").ToString
                        .Item(4, rx).Value = rd("reftype").ToString & "-" & rd("refno").ToString
                        .Item(5, rx).Value = Format(rd("refamt").ToString, "STANDARD")
                        .Item(6, rx).Value = rd("bank").ToString
                        .Item(7, rx).Value = rd("checkno").ToString
                        .Item(8, rx).Value = rd("checkdate").ToString
                    End If
                    temptots += Decimal.Parse(rd("refamt").ToString)

                End While
                rd.Close()
                .RowCount += 1
                rx = .RowCount - 1
                .Item(0, rx).Tag = trnos(i)

                .Rows(rx).DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
                Dim cell As DataGridViewCell = (.Rows(rx).Cells(4))
                cell.Style.BackColor = Color.Aquamarine
                .Item(4, rx).Value = "Total"
                cell = .Rows(rx).Cells(5)
                .Item(5, rx).Value = Format(temptots, "STANDARD")
                cell.Style.BackColor = Color.Aquamarine

            Next

        End With
    End Sub


    Private Sub btnPrintExpres_Click(sender As Object, e As EventArgs) Handles btnPrintExpres.Click
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
                Dim ds As New DataSet1
                Dim dt As DataTable = ds.Tables("dtListofExpressColl")
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
                    If .Item(5, i).Value <> Nothing Then
                        r1 = dt.NewRow()

                        Dim sd1 As Date = dtpListInvoiceStart.Value
                        Dim sd2 As Date = dtpListInvoiceEnd.Value
                        r1("sdate1") = Format(sd1, "MM/dd/yyyy")
                        r1("sdate2") = Format(sd2, "MM/dd/yyyy")
                        r1("docno") = .Item(0, i).Value
                        r1("slmnname") = .Item(1, i).Value
                        r1("edate") = .Item(2, i).Value
                        r1("custname") = .Item(3, i).Value


                        r1("bank") = .Item(6, i).Value
                        r1("checkno") = .Item(7, i).Value
                        Dim chkdate As Date = .Item(8, i).Value

                        If .Item(4, i).Value = "Total" Then
                            r1("amtpaid") = "<b> <span align='right'>" & .Item(5, i).Value & "</span></b>"
                            r1("refno") = "<b> " & .Item(4, i).Value & "</b>"

                            ' r1("checkdate") = Format(chkdate, "MM/dd/yyyy") '.Item(9, i).Value
                        Else
                            r1("amtpaid") = "<span align='right'>" & .Item(5, i).Value & "</span>"
                            r1("refno") = .Item(4, i).Value
                            r1("checkdate") = Format(chkdate, "MM/dd/yyyy") '.Item(9, i).Value
                        End If
                        r1("total") = .Item(5, i).Value

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
                prep = New rptListofExpressColl
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