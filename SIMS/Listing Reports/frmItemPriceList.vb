
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


Public Class frmItemPriceList

    Sub LoadSupplier()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxSupplier.Items.Clear()
        cbxSupplier.DisplayMember = "text"
        qry = "Select * from supplier ORDER BY suppliername"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxSupplier.Items.Add(New With {.Text = relr("supcode").ToString(), .Value = relr("supcode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Sub LoadCategory()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand

        cbxCategory.Items.Clear()
        cbxCategory.DisplayMember = "text"
        qry = "Select * from category ORDER BY categoryname"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxCategory.Items.Add(New With {.Text = relr("catcode").ToString(), .Value = relr("categoryname").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub cbxSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxSupplier.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "'", cdb)
        Using rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                tbSupplier.Text = rd.Item("suppliername").ToString
            End If
            rd.Close()
        End Using
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        If cbxSupplier.Text = Nothing Then
            MsgBox("Select Supplier!", vbExclamation)
            Exit Sub
        End If

        Dim Sup As String = Nothing
        Dim Cat As String = Nothing
        Dim sql As String = Nothing

        Dim totalqty As Decimal = 0
        Dim totalcase As Decimal = 0
        Dim Bag As Decimal = 0
        Dim BagQty As Decimal = 0

        If cbxSupplier.Text.Trim <> Nothing Then
            Sup = cbxSupplier.Text
        End If

        If cbxCategory.Text.Trim <> Nothing Then
            Cat = cbxCategory.Text
        End If

        With dgvPriceList

            dgvPriceList.Rows.Clear()

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            If Sup <> Nothing And Cat = Nothing Then
                cmd = New MySqlCommand("select a.*,c.suppliername as Supplier_Name, d.categoryname as Category_Name " & _
                      " FROM ivitem AS a INNER JOIN supplier AS c ON c.supcode = a.supcode " & _
                      " INNER JOIN category AS d ON d.catcode = a.catcode " & _
                      " Where c.supcode=@sc order by description asc", cdb)
                cmd.Parameters.AddWithValue("@sc", Sup)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("ITEMCODE").ToString
                            .Item(2, rw).Value = rd("description").ToString
                            .Item(8, rw).Value = rd("SUPCODE").ToString
                            .Item(8, rw).Tag = rd("Supplier_Name").ToString
                            .Item(9, rw).Value = rd("CATCODE").ToString
                            .Item(9, rw).Tag = rd("Category_Name").ToString

                            If cbxPriceType.Text = "A" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                Bag = rd("PCKGB").ToString
                                If Bag = 1 Then
                                    BagQty = 0
                                    .Item(4, rw).Value = BagQty
                                Else
                                    .Item(4, rw).Value = rd("PCKGB").ToString
                                End If
                                .Item(5, rw).Value = Format(rd("APRICEC").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("APRICEB").ToString
                                .Item(7, rw).Value = rd("APRICEP").ToString
                            ElseIf cbxPriceType.Text = "B" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                Bag = rd("PCKGB").ToString
                                If Bag = 1 Then
                                    BagQty = 0
                                    .Item(4, rw).Value = BagQty
                                Else
                                    .Item(4, rw).Value = rd("PCKGB").ToString
                                End If
                                .Item(5, rw).Value = Format(rd("BPRICEC").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("BPRICEB").ToString
                                .Item(7, rw).Value = rd("BPRICEP").ToString
                            ElseIf cbxPriceType.Text = "C" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                Bag = rd("PCKGB").ToString
                                If Bag = 1 Then
                                    BagQty = 0
                                    .Item(4, rw).Value = BagQty
                                Else
                                    .Item(4, rw).Value = rd("PCKGB").ToString
                                End If
                                .Item(5, rw).Value = Format(rd("CPRICEC").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("CPRICEB").ToString
                                .Item(7, rw).Value = rd("CPRICEP").ToString
                            ElseIf cbxPriceType.Text = "1" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                .Item(4, rw).Value = rd("PCKGB").ToString
                                .Item(5, rw).Value = Format(rd("grscost").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("CPRICEB").ToString
                                .Item(7, rw).Value = rd("costpc").ToString
                            End If
                        End While
                        rd.Close()
                    End If
                End Using
            End If

            If Sup <> Nothing And Cat <> Nothing Then
                cmd = New MySqlCommand("select a.*,c.suppliername as Supplier_Name, d.categoryname as Category_Name " & _
                      " FROM ivitem AS a INNER JOIN supplier AS c ON c.supcode = a.supcode " & _
                      " INNER JOIN category AS d ON d.catcode = a.catcode " & _
                      " Where c.supcode=@sc and d.catcode=@cc order by description asc", cdb)
                cmd.Parameters.AddWithValue("@sc", Sup)
                cmd.Parameters.AddWithValue("@cc", Cat)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows Then
                        x = 0
                        While rd.Read
                            .RowCount += 1
                            rw = .RowCount - 1
                            x += 1
                            .Item(0, rw).Value = x
                            .Item(1, rw).Value = rd("ITEMCODE").ToString
                            .Item(2, rw).Value = rd("description").ToString
                            .Item(8, rw).Value = rd("SUPCODE").ToString
                            .Item(9, rw).Value = rd("CATCODE").ToString

                            If cbxPriceType.Text = "A" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                Bag = rd("PCKGB").ToString
                                If Bag = 1 Then
                                    BagQty = 0
                                    .Item(4, rw).Value = BagQty
                                Else
                                    .Item(4, rw).Value = rd("PCKGB").ToString
                                End If
                                .Item(5, rw).Value = Format(rd("APRICEC").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("APRICEB").ToString
                                .Item(7, rw).Value = rd("APRICEP").ToString
                            ElseIf cbxPriceType.Text = "B" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                Bag = rd("PCKGB").ToString
                                If Bag = 1 Then
                                    BagQty = 0
                                    .Item(4, rw).Value = BagQty
                                Else
                                    .Item(4, rw).Value = rd("PCKGB").ToString
                                End If
                                .Item(5, rw).Value = Format(rd("BPRICEC").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("BPRICEB").ToString
                                .Item(7, rw).Value = rd("BPRICEP").ToString
                            ElseIf cbxPriceType.Text = "C" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                Bag = rd("PCKGB").ToString
                                If Bag = 1 Then
                                    BagQty = 0
                                    .Item(4, rw).Value = BagQty
                                Else
                                    .Item(4, rw).Value = rd("PCKGB").ToString
                                End If
                                .Item(5, rw).Value = Format(rd("CPRICEC").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("CPRICEB").ToString
                                .Item(7, rw).Value = rd("CPRICEP").ToString
                            ElseIf cbxPriceType.Text = "1" Then
                                .Item(3, rw).Value = rd("PCKGC").ToString
                                .Item(4, rw).Value = rd("PCKGB").ToString
                                .Item(5, rw).Value = Format(rd("grscost").ToString, "STANDARD")
                                .Item(6, rw).Value = rd("CPRICEB").ToString
                                .Item(7, rw).Value = rd("costpc").ToString
                            End If
                        End While
                        rd.Close()
                    End If
                End Using
            End If
        End With
    End Sub


    Private Sub frmItemPriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshPriceList()
    End Sub

    Sub RefreshPriceList()
        LoadSupplier()
        LoadCategory()
        cbxPriceType.Text = "A"
        checkboxAll.Checked = True
        cbxSupplier.SelectedIndex = -1
        cbxCategory.SelectedIndex = -1
        tbSupplier.Clear()
        tbCategory.Clear()
        dgvPriceList.Rows.Clear()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshPriceList()
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged

    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged

    End Sub

    Private Sub cbxCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxCategory.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from category where catcode like '%" & cbxCategory.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                tbCategory.Text = rd.Item("categoryname").ToString
            End With
            checkboxAll.Checked = False
        End If
        rd.Close()
    End Sub

    Private Sub checkboxAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxAll.CheckedChanged
        If checkboxAll.Checked = True Then
            cbxCategory.Text = Nothing
            tbCategory.Text = Nothing
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        With dgvPriceList
            If .RowCount > 0 Then
                pbar1.Visible = True
                pbar1.Maximum = .RowCount
                pbar1.Value = 0


                .EndEdit()
                Dim prep As New ReportDocument
                Dim ds As New DataSet1
                Dim dt As DataTable = ds.Tables("dtpricelist")
                Dim r1 As DataRow
                Dim grpno As Integer = 1
                dt.Rows.Clear()
                Dim chkflag As Boolean = False
                'grpno = 10
                grpno = 10
                Dim cntr As Integer = 0
                Dim grid As Integer = 1

                For i = 0 To .RowCount - 1
                    pbar1.Value += 1
                    pbar1.Refresh()
                    r1 = dt.NewRow()
                    cntr += 1
                    r1 = dt.NewRow()
                    'r1("supplier") = IIf(.Item(8, i).Value = Nothing, DBNull.Value, .Item(8, i).Value) 'IIf(.Item(0, i).Value = Nothing, 0, .Item(0, i).Value)
                    r1("supplier") = tbSupplier.Text
                    r1("category") = IIf(.Item(9, i).Value = Nothing, DBNull.Value, .Item(9, i).Value)
                    r1("pricetype") = IIf(cbxPriceType.Text = Nothing, DBNull.Value, cbxPriceType)
                    r1("itemcode") = IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("description") = IIf(.Item(2, i).Value = Nothing, DBNull.Value, .Item(2, i).Value)
                    r1("pckgcase") = IIf(.Item(3, i).Value = Nothing, 0, .Item(3, i).Value)
                    r1("pckgbag") = IIf(.Item(4, i).Value = Nothing, 0, .Item(4, i).Value)
                    r1("pricecase") = IIf(.Item(5, i).Value = Nothing, 0, .Item(5, i).Value)
                    r1("pricebag") = IIf(.Item(6, i).Value = Nothing, 0, .Item(6, i).Value)
                    r1("pricepc") = IIf(.Item(7, i).Value = Nothing, 0, .Item(7, i).Value)
                    r1("supcode") = IIf(.Item(8, i).Value = Nothing, DBNull.Value, .Item(8, i).Value)
                    r1("catcode") = IIf(.Item(9, i).Value = Nothing, DBNull.Value, .Item(9, i).Value)
                    r1("grpno") = grid

                    dt.Rows.Add(r1)
                    pbar1.Refresh()

                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next
                pbar1.Visible = False
                prep = New rptPriceList
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
End Class