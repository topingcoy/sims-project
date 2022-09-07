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

Public Class frmItemHistory

    Private Sub txtItemCode_DoubleClick(sender As Object, e As EventArgs) Handles txtItemCode.DoubleClick
        frmSearchItem.ShowDialog()
    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.F3 Then
            frmSearchItem.ShowDialog()
        End If
    End Sub

    Private Sub txtItemCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemCode.KeyPress
        'e.Handled = True
        If e.KeyChar = vbCr Then
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT * FROM ivitem WHERE itemcode = '" & txtItemCode.Text & "'", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtItemCode.Text = rd("itemcode").ToString
                txtDescription.Text = rd("description").ToString
                rd.Dispose()
            Else
                MsgBox("Invalid item code", vbExclamation)
                If txtDescription.Text <> Nothing Then
                    txtDescription.Clear()
                End If
                rd.Dispose()
                Exit Sub
            End If
            'rd.Dispose()
        End If
        ' cbxWarehouse.Focus()
    End Sub

    Private Sub frmItemHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItemHistory.Rows.Clear()
        txtItemCode.Clear()
        txtDescription.Clear()
        cbxWarehouse.Text = ""
        txtWarehouse.Clear()
        LoadWarehouse()
        txtItemCode.Focus()
    End Sub


    Sub LoadWarehouse()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand
        cbxWarehouse.Items.Clear()
        cbxWarehouse.DisplayMember = "text"
        qry = "Select * from warehouse ORDER BY warehouse"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxWarehouse.Items.Add(New With {.Text = relr("whscode").ToString(), .Value = relr("whscode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub cbxWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxWarehouse.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cbxWarehouse.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtWarehouse.Text = rd.Item("warehouse").ToString
            End With
        End If
        rd.Close()
    End Sub

    Sub SalesandReturn()
        If cbxWarehouse.Text = Nothing And txtItemCode.Text = Nothing Then
            MsgBox("Pls Select Warehouse and Itemcode!", vbInformation)
            Exit Sub
        End If

        Dim cbwhs As String = Nothing
        Dim itemc As String = Nothing
        Dim sdate As String = sDate1.Value.ToString("yyyy-MM-dd")

        If cbxWarehouse.Text.Trim <> Nothing Then
            cbwhs = cbxWarehouse.Text
        End If

        If txtItemCode.Text.Trim <> Nothing Then
            itemc = txtItemCode.Text
        End If

        With dgvItemHistory

            dgvItemHistory.Rows.Clear()

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            If cbwhs <> Nothing And itemc <> Nothing Then
                cmd = New MySqlCommand("select * from salesd d INNER JOIN salesh as h on d.transno=h.transno " & _
                                       "INNER JOIN customers as c on c.custcode=h.custcode " & _
                                       "INNER JOIN warehouse w on w.whscode=d.whscode " & _
                                       "WHERE itemcode=@ic AND d.whscode=@whs AND d.tdate>=@dd AND d.isdeleted<>1 ORDER BY d.tdate asc", cdb)
                cmd.Parameters.AddWithValue("@whs", cbwhs)
                cmd.Parameters.AddWithValue("@ic", itemc)
                cmd.Parameters.AddWithValue("@dd", sdate)

                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("transno").ToString
                            .Item(2, rw).Value = rd("invoiceno").ToString
                            .Item(3, rw).Value = rd("ttype").ToString
                            .Item(4, rw).Value = rd("tdate").ToString
                            .Item(5, rw).Value = rd("whscode").ToString
                            .Item(6, rw).Value = rd("warehouse").ToString
                            .Item(7, rw).Value = Format(CDbl(rd("qty").ToString), "#,##0")
                            .Item(8, rw).Value = rd("qunit").ToString
                            .Item(9, rw).Value = Format(CDbl(rd("uprice").ToString), "#,##0.00")
                            .Item(10, rw).Value = rd("custname").ToString

                        End While
                        rd.Close()
                    End If
                End Using
            End If
        End With
    End Sub

    Sub Inout()
        If cbxWarehouse.Text = Nothing And txtItemCode.Text = Nothing Then
            MsgBox("Pls Select Warehouse and Itemcode!", vbInformation)
            Exit Sub
        End If

        Dim cbwhs As String = Nothing
        Dim itemc As String = Nothing
        Dim sdate As String = sDate1.Value.ToString("yyyy-MM-dd")

        If cbxWarehouse.Text.Trim <> Nothing Then
            cbwhs = cbxWarehouse.Text
        End If

        If txtItemCode.Text.Trim <> Nothing Then
            itemc = txtItemCode.Text
        End If

        With dgvItemHistory

            dgvItemHistory.Rows.Clear()

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            If cbwhs <> Nothing And itemc <> Nothing Then
                cmd = New MySqlCommand("select * from ivd d INNER JOIN ivh as h on d.transno=h.transno " & _
                                        "INNER JOIN warehouse w on w.whscode=d.whscode " & _
                                       "WHERE itemcode=@ic AND (d.whscode=@whs OR d.towhs=@towhs) AND d.tdate>=@dd AND d.isdeleted<>1 ORDER BY d.tdate asc", cdb)
                '"WHERE item=@ic AND d.whs=@whs AND d.date>=@dd AND d.isdeleted<>1 ORDER BY d.date asc", cdb)
                cmd.Parameters.AddWithValue("@whs", cbwhs)
                cmd.Parameters.AddWithValue("@towhs", cbwhs) 'add
                cmd.Parameters.AddWithValue("@ic", itemc)
                cmd.Parameters.AddWithValue("@dd", sdate)

                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("transno").ToString
                            .Item(2, rw).Value = rd("transno").ToString
                            .Item(3, rw).Value = rd("ttype").ToString
                            .Item(4, rw).Value = rd("tdate").ToString
                            .Item(5, rw).Value = rd("whscode").ToString
                            .Item(6, rw).Value = rd("warehouse").ToString
                            .Item(7, rw).Value = Format(CDbl(rd("qty").ToString), "#,##0")
                            .Item(8, rw).Value = rd("qunit").ToString
                            .Item(9, rw).Value = Format(CDbl(rd("price").ToString), "#,##0.00")
                            If rd("ttype").ToString = "I" Then
                                .Item(10, rw).Value = "Stock In"
                                .Item(11, rw).Value = rd("towhs").ToString 'added 1-26-2022
                                .Item(12, rw).Value = rd("whscode").ToString 'added 1-26-2022
                            Else
                                .Item(10, rw).Value = "Stock Out"
                                .Item(11, rw).Value = rd("whscode").ToString 'added 1-26-2022
                                .Item(12, rw).Value = rd("towhs").ToString 'added 1-26-2022
                            End If
                            If rd("ttype").ToString = "T" Then
                                Dim tt As String
                                tt = rd("towhs").ToString
                                '.Item(10, rw).Value = "Stock Transfer to: " & tt & ""
                                .Item(10, rw).Value = "Stock Transfer "
                                .Item(11, rw).Value = rd("whscode").ToString
                                .Item(12, rw).Value = rd("towhs").ToString
                            End If
                            '.Item(11, rw).Value = rd("whs").ToString
                            '.Item(12, rw).Value = rd("towhs").ToString
                        End While
                        rd.Close()
                    End If
                End Using
            End If
        End With
    End Sub

    Sub Receiving()
        If cbxWarehouse.Text = Nothing And txtItemCode.Text = Nothing Then
            MsgBox("Pls Select Warehouse and Itemcode!", vbInformation)
            Exit Sub
        End If

        Dim cbwhs As String = Nothing
        Dim itemc As String = Nothing
        Dim sdate As String = sDate1.Value.ToString("yyyy-MM-dd")

        If cbxWarehouse.Text.Trim <> Nothing Then
            cbwhs = cbxWarehouse.Text
        End If

        If txtItemCode.Text.Trim <> Nothing Then
            itemc = txtItemCode.Text
        End If

        With dgvItemHistory

            dgvItemHistory.Rows.Clear()

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            If cbwhs <> Nothing And itemc <> Nothing Then
                cmd = New MySqlCommand("select * from rcvingd d INNER JOIN rcvingh as h on d.transno=h.transno " & _
                                       "INNER JOIN warehouse w on w.whscode=d.whscode " & _
                                       "WHERE itemcode=@ic AND w.whscode=@whs AND d.tdate>=@dd AND d.isdeleted<>1 ORDER BY d.tdate asc", cdb)
                cmd.Parameters.AddWithValue("@whs", cbwhs)
                cmd.Parameters.AddWithValue("@ic", itemc)
                cmd.Parameters.AddWithValue("@dd", sdate)

                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("transno").ToString
                            .Item(2, rw).Value = rd("invoiceno").ToString
                            .Item(3, rw).Value = "Receiving"
                            .Item(4, rw).Value = rd("tdate").ToString
                            .Item(5, rw).Value = rd("whscode").ToString
                            .Item(6, rw).Value = rd("warehouse").ToString
                            .Item(7, rw).Value = Format(CDbl(rd("qty").ToString), "#,##0")
                            .Item(8, rw).Value = rd("qunit").ToString
                            .Item(9, rw).Value = Format(CDbl(rd("netcost").ToString), "#,##0.00")
                            .Item(10, rw).Value = "Stock Receiving"
                            '.Item(11, rw).Value = rd("whs").ToString
                            .Item(12, rw).Value = rd("whscode").ToString

                        End While
                        rd.Close()
                    End If
                End Using
            End If
        End With
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        If txtItemCode.Text = Nothing Or cbxWarehouse.Text = Nothing Then
            MsgBox("Pls select item or warehouse!", vbExclamation)
            Exit Sub
        End If

        If rbSales.Checked = True Then
            Dim i As Integer
            With dgvItemHistory
                dgvItemHistory.Rows.Clear()
                For i = 11 To 12
                    .Columns(i).Visible = False
                Next
                SalesandReturn()
            End With
        ElseIf rbInOut.Checked = True Then
            With dgvItemHistory
                dgvItemHistory.Rows.Clear()
                For i = 11 To 12
                    .Columns(i).Visible = True
                Next
                Inout()
            End With
        ElseIf rbReceiving.Checked = True Then
            With dgvItemHistory
                dgvItemHistory.Rows.Clear()
                For i = 11 To 11
                    .Columns(i).Visible = False
                Next
                For i = 12 To 12
                    .Columns(i).Visible = True
                Next
                Receiving()
            End With
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        With dgvItemHistory
            If .RowCount > 0 Then
                pbar1.Visible = True
                pbar1.Maximum = .RowCount
                pbar1.Value = 0


                .EndEdit()
                Dim prep As New ReportDocument
                Dim ds As New DataSet2
                Dim dt As DataTable = ds.Tables("dtItemHistory")
                Dim r1 As DataRow
                Dim grpno As Integer = 1
                dt.Rows.Clear()
                Dim chkflag As Boolean = False
                grpno = 10
                'grpno = 29
                Dim cntr As Integer = 0
                Dim grid As Integer = 1

                For i = 0 To .RowCount - 1
                    pbar1.Value += 1
                    pbar1.Refresh()
                    r1 = dt.NewRow()
                    cntr += 1
                    r1 = dt.NewRow()

                    Dim Sdate As Date = sDate1.Value
                    r1("sdate") = Format(Sdate, "MM/dd/yyyy") '.Item(9, i).Value
                    r1("itemc") = txtItemCode.Text 'IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("itemdesc") = txtDescription.Text 'IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("whsc") = cbxWarehouse.Text 'IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("whsname") = txtWarehouse.Text 'IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    If rbSales.Checked = True Then
                        r1("radiotrans") = "Sales/Return/BO"
                    ElseIf rbInOut.Checked = True Then
                        r1("radiotrans") = "Misc. Stock In/Out/Transfer"
                    ElseIf rbReceiving.Checked = True Then
                        r1("radiotrans") = "Receiving"
                    End If
                    r1("transno") = .Item(1, i).Value
                    r1("docno") = .Item(2, i).Value
                    r1("type") = .Item(3, i).Value
                    Dim tdate As Date = .Item(4, i).Value
                    r1("tdate") = Format(tdate, "MM/dd/yyyy") '.Item(9, i).Value
                    r1("qty") = .Item(7, i).Value
                    r1("unit") = .Item(8, i).Value
                    r1("uprice") = .Item(9, i).Value
                    r1("particulars") = .Item(10, i).Value
                    r1("grpno") = grid


                    'r1("supplier") = tbSupplier.Text
                    'r1("category") = IIf(.Item(7, i).Value = Nothing, DBNull.Value, .Item(7, i).Value)
                    'r1("pricetype") = cbxPriceType.Text
                    'r1("itemcode") = IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    'r1("description") = IIf(.Item(2, i).Value = Nothing, DBNull.Value, .Item(2, i).Value)
                    'r1("pckgcase") = IIf(.Item(3, i).Value = Nothing, 0, .Item(3, i).Value)
                    'r1("pckgbag") = IIf(.Item(4, i).Value = Nothing, 0, .Item(4, i).Value)
                    'r1("pckgpiece") = IIf(.Item(5, i).Value = Nothing, 0, .Item(5, i).Value)
                    'r1("pckgs") = IIf(.Item(6, i).Value = Nothing, DBNull.Value, .Item(6, i).Value)
                    'r1("uprice") = IIf(.Item(8, i).Value = Nothing, 0, .Item(8, i).Value)
                    'r1("amnt") = IIf(.Item(9, i).Value = Nothing, 0, .Item(9, i).Value)
                    'r1("grpno") = grid
                    'Dim ivdate As Date = dtpInventory.Value
                    'r1("ivdate") = Format(ivdate, "MM/dd/yyyy") '.Item(9, i).Value
                    'r1("whs") = tbWarehouse.Text
                    'If chkGood.Checked = True Then
                    '    r1("stocktype") = "Good Stock"
                    'ElseIf chkBO.Checked = True Then
                    '    r1("stocktype") = "Bad Stock"
                    'End If


                    dt.Rows.Add(r1)
                    pbar1.Refresh()

                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next
                pbar1.Visible = False
                prep = New rptItemHistory
                prep.SetDataSource(ds)
                frmReport.CRportRcv.ReportSource = prep
                frmReport.CRportRcv.Refresh()
                frmReport.Dock = DockStyle.Fill
                frmReport.Show()

            Else
                MsgBox("No records found to print!", 48, "Insufficient Rows!")
            End If
        End With

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        sDate1.Text = Now.ToString
        txtItemCode.Clear()
        txtDescription.Clear()
        cbxWarehouse.Text = Nothing
        txtWarehouse.Clear()
        rbSales.Checked = False
        rbInOut.Checked = False
        rbReceiving.Checked = False
        dgvItemHistory.Rows.Clear()
        txtItemCode.Focus()
    End Sub

    Private Sub sDate1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sDate1.KeyPress
        If e.KeyChar = vbCr Then
            txtItemCode.Focus()
        End If
    End Sub

    Private Sub sDate1_ValueChanged(sender As Object, e As EventArgs) Handles sDate1.ValueChanged

    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged

    End Sub
End Class