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

Public Class frmGenerateInventory

    Private Sub frmGenerateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshInventory()
    End Sub

    Sub RefreshInventory()
        LoadWarehouse()
        LoadSupplier()
        LoadCategory()
        cbxWarehouse.SelectedIndex = -1
        cbxPriceType.Text = "A"
        checkboxAll.Checked = True
        chkGood.Checked = True
        cbxSupplier.SelectedIndex = -1
        cbxCategory.SelectedIndex = -1
        tbWarehouse.Clear()
        tbSupplier.Clear()
        tbCategory.Clear()
        tbTotal.Clear()
        dgvInventoryItem.Rows.Clear()
    End Sub

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

    Private Sub cbxWarehouse_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxWarehouse.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cbxWarehouse.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                tbWarehouse.Text = rd.Item("warehouse").ToString
            End With
        End If
        rd.Close()
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

    Function getbags(ByRef g As Decimal, ByRef b As Decimal)
        Dim array(1) As Decimal
        Dim ubags As Decimal
        Dim nwgoods As Decimal

        ubags = g / b
        ubags = Math.Floor(ubags)

        nwgoods = ubags * b
        nwgoods = g - nwgoods

        array(0) = ubags
        array(1) = nwgoods

        Return array
    End Function
    Private Sub GoGenerate_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        If cbxWarehouse.Text = Nothing And cbxSupplier.Text = Nothing Then
            MsgBox("Pls Select Warehouse and Supplier!", vbInformation)
            Exit Sub
        End If

        Dim cbwhs As String = Nothing
        Dim cbsup As String = Nothing
        Dim cbcat As String = Nothing

        If cbxWarehouse.Text.Trim <> Nothing Then
            cbwhs = cbxWarehouse.Text
        End If

        If cbxSupplier.Text.Trim <> Nothing Then
            cbsup = cbxSupplier.Text
        End If

        If cbxCategory.Text.Trim <> Nothing Then
            cbcat = cbxCategory.Text
        End If

        With dgvInventoryItem

            dgvInventoryItem.Rows.Clear()

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            Dim totalqty As Decimal = 0
            Dim totalcase As Decimal = 0
            Dim BagAmount As Decimal = 0
            Dim PcAmount As Decimal = 0
            Dim Gtotal As Decimal = 0
            Dim ApriceC As Decimal = 0
            Dim ApriceB As Decimal = 0
            Dim ApriceP As Decimal = 0
            Dim categoryname As String = Nothing
            Dim catamount As Decimal = 0

            If cbwhs <> Nothing And cbsup <> Nothing Then
                cmd = New MySqlCommand("select a.*,b.QTY_GOOD,c.suppliername as Supplier_Name, d.categoryname as Category_Name " & _
                                  " FROM ivitem AS a INNER JOIN ivwh AS b ON b.itemcode = a.itemcode " & _
                                  " INNER JOIN supplier AS c ON c.supcode = a.supcode " & _
                                  " INNER JOIN category AS d ON d.catcode = a.catcode " & _
                                  " Where b.whscode=@whs and c.supcode=@sc ORDER BY catcode asc", cdb)
                cmd.Parameters.AddWithValue("@whs", cbwhs)
                cmd.Parameters.AddWithValue("@sc", cbsup)
           

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
                            .Item(15, rw).Value = rd("pckgb").ToString
                            '.Item(10, rw).Value = rd("qty_good").ToString
                            If Math.Abs(rd("qty_good").ToString - Fix(rd("qty_good").ToString)) Then
                                .Item(10, rw).Value = Format(CDbl(rd("qty_good").ToString), "#,##0.00")
                            Else
                                .Item(10, rw).Value = Format(CDbl(rd("qty_good").ToString), "#,##0")
                            End If


                            Dim tcases As Decimal = 0
                            Dim tbag As Decimal = 0
                            Dim totpc As Decimal = 0
                            Dim pcs As Decimal = 0
                            Dim pqty As Decimal = 0


                            tbag = rd("pckgb").ToString
                            pcs = rd("pckgp").ToString
                            totpc = rd("qty_good").ToString
                            tcases = rd("pckgc").ToString

                            If totpc >= tcases And tcases > 1 Then
                                Dim ncase As Decimal = 0

                                ncase = totpc / tcases
                                Dim nc As Decimal = 0
                                Dim tc As Decimal = 0
                                Dim nwg As Decimal = 0

                                ncase = Math.Floor(ncase) ' to get the whole number
                                tc = tcases * ncase
                                nwg = totpc - tc

                                If Math.Abs(ncase - Fix(ncase)) Then
                                    .Item(3, rw).Value = Format(CDbl(ncase), "#,##0.00")
                                Else
                                    .Item(3, rw).Value = Format(CDbl(ncase), "#,##0")
                                End If


                                If nwg > 0 And nwg > tbag And tbag > 1 Then
                                    Dim rs(1) As Decimal
                                    rs = getbags(nwg, tbag)
                                    '.Item(4, rw).Value = rs(0)
                                    '.Item(5, rw).Value = rs(1)
                                    If Math.Abs(rs(0) - Fix(rs(0))) Then
                                        .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0.00")
                                    Else
                                        .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0")
                                    End If

                                    If Math.Abs(rs(1) - Fix(rs(1))) Then
                                        Dim actual_pcs As Decimal = 0
                                        actual_pcs = rs(1) / rd("pckgc").ToString

                                        .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(rs(1)), "#,##0")
                                    End If

                                ElseIf nwg > 0 And nwg < tbag And tbag > 1 Then
                                    .Item(4, rw).Value = 0 '0
                                    '.Item(5, rw).Value = nwg

                                    If Math.Abs(nwg - Fix(nwg)) Then
                                        Dim actual_pcs As Decimal = 0
                                        actual_pcs = nwg / rd("pckgc").ToString

                                        .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(nwg), "#,##0")
                                    End If
                                ElseIf nwg > 0 And tbag = 0 And pcs = 1 Then
                                    .Item(4, rw).Value = 0
                                    If Math.Abs(nwg - Fix(nwg)) Then
                                        .Item(5, rw).Value = Format(CDbl(nwg), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(nwg), "#,##0")
                                    End If
                                Else
                                    .Item(4, rw).Value = 0
                                    If Math.Abs(nwg - Fix(nwg)) Then
                                        Dim actual_pcs As Decimal = 0
                                        actual_pcs = nwg / rd("pckgc").ToString

                                        .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(nwg), "#,##0")
                                    End If
                                End If
                            ElseIf totpc < tcases And tbag > 1 Then
                                Dim rs(1) As Decimal
                                rs = getbags(totpc, tbag)
                                .Item(3, rw).Value = 0

                                If Math.Abs(rs(0) - Fix(rs(0))) Then
                                    .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0.00")
                                Else
                                    .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0")
                                End If

                                If Math.Abs(rs(1) - Fix(rs(1))) Then
                                    Dim actual_pcs As Decimal = 0
                                    actual_pcs = rs(1) / rd("pckgc").ToString

                                    .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                Else
                                    .Item(5, rw).Value = Format(CDbl(rs(1)), "#,##0")
                                End If

                            ElseIf totpc < tcases And tbag = 0 And pcs = 1 Then
                                .Item(3, rw).Value = 0

                                If Math.Abs(totpc - Fix(totpc)) Then
                                    .Item(4, rw).Value = Format(CDbl(totpc), "#,##0.00")
                                Else
                                    .Item(4, rw).Value = Format(CDbl(totpc), "#,##0")
                                End If

                                .Item(5, rw).Value = 0 'totpc
                            Else 'RICH pcs

                                .Item(3, rw).Value = 0
                                .Item(4, rw).Value = 0
                                If Math.Abs(totpc - Fix(totpc)) Then
                                    Dim actual_pcs As Decimal = 0
                                    actual_pcs = totpc / rd("pckgc").ToString

                                    .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                Else
                                    .Item(5, rw).Value = Format(CDbl(totpc), "#,##0")
                                End If
                            End If

                            If tbag > 1 Then
                                .Item(6, rw).Value = rd("pckgc").ToString & " x " & tbag
                            Else
                                .Item(6, rw).Value = rd("pckgc").ToString & " x " & pcs
                            End If

                            .Item(7, rw).Value = rd("Category_Name").ToString
                            .Item(7, rw).Tag = rd("catcode").ToString

                            If cbxPriceType.Text = "A" Then
                                .Item(8, rw).Value = Format(rd("APRICEC").ToString, "STANDARD")
                                ApriceC = rd("apricec").ToString
                                ApriceB = rd("apriceb").ToString
                                ApriceP = rd("apricep").ToString
                                .Item(14, rw).Value = Format(.Item(12, rw).Value * .Item(5, rw).Value, "STANDARD")
                                '14 = 5 * 12
                                '.Item(14, rw).Value = .Item(12, rw).Value * .Item(5, rw).Value
                                .Item(10, rw).Value = totalqty
                                .Item(11, rw).Value = ApriceB
                                .Item(12, rw).Value = ApriceP
                                .Item(13, rw).Value = ApriceB * .Item(4, rw).Value
                                .Item(14, rw).Value = ApriceP * .Item(5, rw).Value

                                .Item(9, rw).Value = Format(.Item(8, rw).Value * .Item(3, rw).Value + .Item(13, rw).Value + .Item(14, rw).Value, "STANDARD")
                                '.Item(9, rw).Value = totalqty * ApriceP

                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()

                            ElseIf cbxPriceType.Text = "B" Then
                                .Item(8, rw).Value = Format(rd("BPRICEC").ToString, "STANDARD")
                                .Item(9, rw).Value = Format(.Item(3, rw).Value * .Item(8, rw).Value, "STANDARD")
                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()

                            ElseIf cbxPriceType.Text = "C" Then
                                .Item(8, rw).Value = Format(rd("CPRICEC").ToString, "STANDARD")
                                .Item(9, rw).Value = Format(.Item(3, rw).Value * .Item(8, rw).Value, "STANDARD")
                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()
                            End If
                            'If categoryname <> rd("Category_Name").ToString Then
                            '    categoryname = rd("Category_Name").ToString
                            '    .RowCount += 1
                            '    rw = .RowCount - 1
                            '    .Item(8, rw).Value = "SUBTOTAL"
                            '    .Item(9, rw).Value = Format(catamount, "N2")
                            '    catamount = 0
                            'Else
                            '    catamount += Decimal.Parse(.Item(9, rw).Value)

                            'End If
                        End While
                        rd.Close()
                    End If
                End Using
            End If

            If cbwhs <> Nothing And cbsup <> Nothing And cbcat <> Nothing Then
                cmd = New MySqlCommand("select a.*,b.QTY_GOOD,c.suppliername as Supplier_Name, d.categoryname as Category_Name " & _
                                  " FROM ivitem AS a INNER JOIN ivwh AS b ON b.itemcode = a.itemcode" & _
                                  " INNER JOIN supplier AS c ON c.supcode = a.supcode " & _
                                  " INNER JOIN category AS d ON d.catcode = a.catcode " & _
                                  " Where b.whscode=@whs and c.supcode=@sc and d.catcode=@cc ORDER BY catcode asc", cdb)
                cmd.Parameters.AddWithValue("@whs", cbwhs)
                cmd.Parameters.AddWithValue("@sc", cbsup)
                cmd.Parameters.AddWithValue("@cc", cbcat)

                dgvInventoryItem.Rows.Clear()

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
                            .Item(15, rw).Value = rd("pckgb").ToString
                            .Item(10, rw).Value = rd("qty_good").ToString

                            Dim tbag As Decimal = 0
                            Dim totpc As Decimal = 0
                            Dim pcs As Decimal = 0
                            Dim pqty As Decimal = 0

                            Dim tcases As Decimal = 0

                            tbag = rd("pckgb").ToString
                            pcs = rd("pckgp").ToString
                            totpc = rd("qty_good").ToString
                            tcases = rd("pckgc").ToString

                            'tbag = rd("pckgb").ToString
                            'pcs = rd("pckgp").ToString
                            'totpc = rd("qty_good").ToString

                            If totpc >= tcases And tcases > 1 Then
                                Dim ncase As Decimal = 0

                                ncase = totpc / tcases
                                Dim nc As Decimal = 0
                                Dim tc As Decimal = 0
                                Dim nwg As Decimal = 0

                                ncase = Math.Floor(ncase)
                                tc = tcases * ncase
                                nwg = totpc - tc
                                .Item(3, rw).Value = ncase

                                If nwg > 0 And nwg > tbag And tbag > 1 Then
                                    Dim rs(1) As Decimal
                                    rs = getbags(nwg, tbag)
                                    If Math.Abs(rs(0) - Fix(rs(0))) Then
                                        .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0.00")
                                    Else
                                        .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0")
                                    End If

                                    If Math.Abs(rs(1) - Fix(rs(1))) Then
                                        Dim actual_pcs As Decimal = 0
                                        actual_pcs = rs(1) / rd("pckgc").ToString

                                        .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(rs(1)), "#,##0")
                                    End If
                                ElseIf nwg > 0 And nwg < tbag And tbag > 1 Then

                                    .Item(4, rw).Value = 0
                                   

                                    If Math.Abs(nwg - Fix(nwg)) Then
                                        Dim actual_pcs As Decimal = 0
                                        actual_pcs = nwg / rd("pckgc").ToString

                                        .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(nwg), "#,##0")
                                    End If
                                ElseIf nwg > 0 And tbag = 0 And pcs = 1 Then
                                    .Item(4, rw).Value = 0
                                    If Math.Abs(nwg - Fix(nwg)) Then
                                        Dim actual_pcs As Decimal = 0
                                        actual_pcs = nwg / rd("pckgc").ToString

                                        .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                    Else
                                        .Item(5, rw).Value = Format(CDbl(nwg), "#,##0")
                                    End If
                                End If
                            ElseIf totpc < tcases And tbag > 1 Then
                                Dim rs(1) As Decimal
                                rs = getbags(totpc, tbag)
                                .Item(3, rw).Value = 0
                                If Math.Abs(rs(0) - Fix(rs(0))) Then
                                    .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0.00")
                                Else
                                    .Item(4, rw).Value = Format(CDbl(rs(0)), "#,##0")
                                End If

                                If Math.Abs(rs(1) - Fix(rs(1))) Then
                                    Dim actual_pcs As Decimal = 0
                                    actual_pcs = rs(1) / rd("pckgc").ToString

                                    .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                Else
                                    .Item(5, rw).Value = Format(CDbl(rs(1)), "#,##0")
                                End If

                            ElseIf totpc < tcases And tbag = 0 And pcs = 1 Then
                                .Item(3, rw).Value = 0
                                .Item(4, rw).Value = 0

                                If Math.Abs(totpc - Fix(totpc)) Then
                                    Dim actual_pcs As Decimal = 0
                                    actual_pcs = totpc / rd("pckgc").ToString

                                    .Item(5, rw).Value = Format(CDbl(actual_pcs), "#,##0.00")
                                Else
                                    .Item(5, rw).Value = Format(CDbl(totpc), "#,##0")
                                End If
                            End If

                            'tbag = rd("pckgb").ToString
                            'pcs = rd("pckgp").ToString
                            'totpc = rd("qty_good").ToString

                            'If rd("pckgc").ToString > 1 Then
                            '    .Item(3, rw).Value = rd("qty_good").ToString \ rd("pckgc").ToString
                            '    .Item(5, rw).Value = rd("qty_good").ToString - .Item(3, rw).Value * rd("pckgc").ToString
                            'ElseIf rd("pckgb").ToString > 1 Then
                            '    .Item(4, rw).Value = rd("qty_good").ToString / rd("pckgb").ToString
                            '    .Item(5, rw).Value = rd("qty_good").ToString - .Item(3, rw).Value * rd("pckgc").ToString

                            'End If

                            '  function CvtBagPc
                            'parameter pqty
                            'private m.pcs, bag, pc
                            ' m.pcs = IIF( IV_ITM.PCKG_C > 1, SIGN(m.pqty)*(ABS(m.pqty) % IV_ITM.PCKG_C), m.pqty )
                            '        If IV_ITM.PCKG_W > 1 Then
                            '            m.bag = INT(m.pcs / IV_ITM.PCKG_W)
                            '   m.pc = SIGN(m.pcs)*(ABS(m.pcs) % IV_ITM.PCKG_W)
                            '        Else
                            '            m.bag = 0
                            '            m.pc = m.pcs
                            '        End If
                            'IF m.ptr_or_scr = 'W'
                            '  RETURN TRANS(m.bag,'@Z #######')+' '+TRANS(m.pc,'@Z #######')
                            '        Else
                            '  RETURN TRANS(m.bag,'@Z ####,###')+'   '+TRANS(m.pc,'@Z ####,###')

                            If tbag > 1 Then
                                .Item(6, rw).Value = rd("pckgc").ToString & " x " & tbag
                            Else
                                .Item(6, rw).Value = rd("pckgc").ToString & " x " & pcs
                            End If

                            .Item(7, rw).Value = rd("Category_Name").ToString
                            .Item(7, rw).Tag = rd("catcode").ToString

                            If cbxPriceType.Text = "A" Then
                                .Item(8, rw).Value = Format(rd("APRICEC").ToString, "STANDARD")
                                ApriceC = rd("apricec").ToString
                                ApriceB = rd("apriceb").ToString
                                ApriceP = rd("apricep").ToString
                                .Item(14, rw).Value = Format(.Item(12, rw).Value * .Item(5, rw).Value, "STANDARD")
                                '14 = 5 * 12
                                '.Item(14, rw).Value = .Item(12, rw).Value * .Item(5, rw).Value
                                .Item(10, rw).Value = totalqty
                                .Item(11, rw).Value = ApriceB
                                .Item(12, rw).Value = ApriceP
                                .Item(13, rw).Value = ApriceB * .Item(4, rw).Value
                                .Item(14, rw).Value = ApriceP * .Item(5, rw).Value

                                .Item(9, rw).Value = Format(.Item(8, rw).Value * .Item(3, rw).Value + .Item(13, rw).Value + .Item(14, rw).Value, "STANDARD")
                                '.Item(9, rw).Value = totalqty * ApriceP

                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()

                            ElseIf cbxPriceType.Text = "B" Then
                                .Item(8, rw).Value = Format(rd("BPRICEC").ToString, "STANDARD")
                                .Item(9, rw).Value = Format(.Item(3, rw).Value * .Item(8, rw).Value, "STANDARD")
                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()

                            ElseIf cbxPriceType.Text = "C" Then
                                .Item(8, rw).Value = Format(rd("CPRICEC").ToString, "STANDARD")
                                .Item(9, rw).Value = Format(.Item(3, rw).Value * .Item(8, rw).Value, "STANDARD")
                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()
                            End If

                        End While
                        rd.Close()
                    End If
                End Using
            End If

        End With

        ' createsubtotal()
    End Sub
    Sub createsubtotal()
        With dgvInventoryItem
            If .RowCount > 0 Then
                Dim catcod As String = Nothing
                Dim current_catcod As String = Nothing
                Dim catamount As Decimal = 0
                catcod = .Item(7, 0).Tag
                Dim mrwcnt As Integer = 0
                mrwcnt = .RowCount - 1

                For i = 0 To .RowCount - 1
                    current_catcod = .Item(7, i).Tag
                    'MsgBox(current_catcod)
                    If current_catcod <> Nothing Then

                        If current_catcod <> catcod Then
                            'If i = mrwcnt Then
                            '    .RowCount += 1
                            '    Dim rw As Integer = 0
                            '    rw = .RowCount - 1
                            '    i = rw
                            'Else
                            .Rows.Insert(i, 1)
                            'End If

                            .Item(8, i).Value = "SUBTOTAL - " & catcod
                            .Item(9, i).Value = Format(catamount, "N2")
                            catcod = current_catcod

                            catamount = 0
                        Else
                            catamount += .Item(9, i).Value
                        End If
                    End If
                    .Refresh()
                Next
            End If
        End With
    End Sub
    Sub cvtobag()

    End Sub

    Sub whs_supplier()
        Dim cbwhs As String = Nothing
        Dim cbsup As String = Nothing
        Dim cbcat As String = Nothing

        If cbxWarehouse.Text.Trim <> Nothing Then
            cbwhs = cbxWarehouse.Text
        End If

        If cbxSupplier.Text.Trim <> Nothing Then
            cbsup = cbxSupplier.Text
        End If

        If cbxCategory.Text.Trim <> Nothing Then
            cbcat = cbxCategory.Text
        End If

        With dgvInventoryItem

            dgvInventoryItem.Rows.Clear()

            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            Dim totalqty As Decimal = 0
            Dim totalcase As Decimal = 0
            Dim BagAmount As Decimal = 0
            Dim PcAmount As Decimal = 0
            Dim Gtotal As Decimal = 0
            Dim ApriceC As Decimal = 0
            Dim ApriceB As Decimal = 0
            Dim ApriceP As Decimal = 0

            If cbwhs <> Nothing And cbsup <> Nothing Then
                cmd = New MySqlCommand("select a.*,b.QTY_GOOD,c.suppliername as Supplier_Name, d.categoryname as Category_Name " & _
                                  " FROM ivitem AS a INNER JOIN ivwh AS b ON b.item = a.itemcode " & _
                                  " INNER JOIN supplier AS c ON c.supcode = a.supcode " & _
                                  " INNER JOIN category AS d ON d.catcode = a.catcode " & _
                                  " Where b.whs=@whs and c.supcode=@sc ORDER BY catcode asc", cdb)
                cmd.Parameters.AddWithValue("@whs", cbwhs)
                cmd.Parameters.AddWithValue("@sc", cbsup)

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
                            .Item(15, rw).Value = rd("pckgb").ToString
                            .Item(10, rw).Value = rd("qty_good").ToString

                            Dim tbag As Decimal = 0
                            Dim totpc As Decimal = 0
                            Dim pcs As Decimal = 0
                            Dim pqty As Decimal = 0


                            tbag = rd("pckgb").ToString
                            pcs = rd("pckgp").ToString
                            totpc = rd("qty_good").ToString

                            If rd("pckgc").ToString > 1 Then
                                .Item(3, rw).Value = rd("qty_good").ToString \ rd("pckgc").ToString
                                .Item(5, rw).Value = rd("qty_good").ToString - .Item(3, rw).Value * rd("pckgc").ToString
                            ElseIf rd("pckgb").ToString > 1 Then
                                .Item(4, rw).Value = rd("qty_good").ToString / rd("pckgb").ToString
                                .Item(5, rw).Value = rd("qty_good").ToString - .Item(3, rw).Value * rd("pckgc").ToString

    
                            End If


                            .Item(6, rw).Value = rd("pckgc").ToString & " x " & rd("pckgb").ToString
                            .Item(7, rw).Value = rd("Category_Name").ToString

                            If cbxPriceType.Text = "A" Then
                                .Item(8, rw).Value = Format(rd("APRICEC").ToString, "STANDARD")
                                ApriceC = rd("apricec").ToString
                                ApriceB = rd("apriceb").ToString
                                ApriceP = rd("apricep").ToString
                                .Item(14, rw).Value = Format(.Item(12, rw).Value * .Item(5, rw).Value, "STANDARD")
                                '14 = 5 * 12
                                '.Item(14, rw).Value = .Item(12, rw).Value * .Item(5, rw).Value
                                .Item(10, rw).Value = totalqty
                                .Item(11, rw).Value = ApriceB
                                .Item(12, rw).Value = ApriceP
                                .Item(13, rw).Value = ApriceB * .Item(4, rw).Value
                                .Item(14, rw).Value = ApriceP * .Item(5, rw).Value

                                .Item(9, rw).Value = Format(.Item(8, rw).Value * .Item(3, rw).Value + .Item(13, rw).Value + .Item(14, rw).Value, "STANDARD")
                                '.Item(9, rw).Value = totalqty * ApriceP

                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()

                            ElseIf cbxPriceType.Text = "B" Then

                                .Item(8, rw).Value = Format(rd("BPRICEC").ToString, "STANDARD")
                                .Item(9, rw).Value = Format(.Item(3, rw).Value * .Item(8, rw).Value, "STANDARD")
                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()

                            ElseIf cbxPriceType.Text = "C" Then

                                .Item(8, rw).Value = Format(rd("CPRICEC").ToString, "STANDARD")
                                .Item(9, rw).Value = Format(.Item(3, rw).Value * .Item(8, rw).Value, "STANDARD")
                                ComputeInventoryTotal()
                                dgvInventoryItem.Focus()
                            End If


                        End While
                        rd.Close()
                    End If
                End Using
            End If

        End With
    End Sub

    Sub whs_supplier_category()

    End Sub

    Public Function setselindex(ByVal cb As ComboBox, ByVal vv As String)
        Dim s As Integer = 0
        Dim flg As Boolean = False
        For Each item In cb.Items
            If item.value = vv Then
                flg = True
                Exit For
            Else
                flg = False
            End If
            s += 1
        Next

        If flg = False Then
            s = -1
        End If

        Return s
    End Function

    Sub ComputeInventoryTotal()
        Dim inTotal As Double = Nothing
        Dim Gross As Double = Nothing
        Dim NetAmt As Double = Nothing
        For i = 0 To dgvInventoryItem.RowCount - 1
            Gross += dgvInventoryItem.Rows(i).Cells(9).Value
            dgvInventoryItem.Rows(i).Cells(0).Value = i + 1
        Next
        Me.tbTotal.Text = Format((Gross), sFmat)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshInventory()
    End Sub

    Private Sub chkBO_CheckedChanged(sender As Object, e As EventArgs) Handles chkBO.CheckedChanged
        If chkBO.Checked = True Then
            chkGood.Checked = False
        End If
    End Sub

    Private Sub chkGood_CheckedChanged(sender As Object, e As EventArgs) Handles chkGood.CheckedChanged
        If chkGood.Checked = True Then
            chkBO.Checked = False
        End If
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged

    End Sub

    Private Sub dgvInventoryItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventoryItem.CellContentClick

    End Sub

    Private Sub checkboxAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxAll.CheckedChanged
        If checkboxAll.Checked = True Then
            cbxCategory.Text = Nothing
            tbCategory.Text = Nothing
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        With dgvInventoryItem
            If .RowCount > 0 Then
                pbar1.Visible = True
                pbar1.Maximum = .RowCount
                pbar1.Value = 0


                .EndEdit()
                Dim prep As New ReportDocument
                Dim ds As New DataSet1
                Dim dt As DataTable = ds.Tables("whinventory")
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
                    'IIf(.Item(6, i).Value = Nothing, 0, .Item(6, i).Value)
                    r1("supplier") = tbSupplier.Text
                    r1("category") = IIf(.Item(7, i).Value = Nothing, DBNull.Value, .Item(7, i).Value)
                    r1("pricetype") = cbxPriceType.Text
                    r1("itemcode") = IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("description") = IIf(.Item(2, i).Value = Nothing, DBNull.Value, .Item(2, i).Value)
                    r1("pckgcase") = IIf(.Item(3, i).Value = Nothing, 0, .Item(3, i).Value)
                    r1("pckgbag") = IIf(.Item(4, i).Value = Nothing, 0, .Item(4, i).Value)
                    r1("pckgpiece") = IIf(.Item(5, i).Value = Nothing, 0, .Item(5, i).Value)
                    r1("pckgs") = IIf(.Item(6, i).Value = Nothing, DBNull.Value, .Item(6, i).Value)
                    r1("uprice") = IIf(.Item(8, i).Value = Nothing, 0, .Item(8, i).Value)
                    r1("amnt") = IIf(.Item(9, i).Value = Nothing, 0, .Item(9, i).Value)
                    r1("grpno") = grid
                    Dim ivdate As Date = dtpInventory.Value
                    r1("ivdate") = Format(ivdate, "MM/dd/yyyy") '.Item(9, i).Value
                    r1("whs") = tbWarehouse.Text
                    If chkGood.Checked = True Then
                        r1("stocktype") = "Good Stock"
                    ElseIf chkBO.Checked = True Then
                        r1("stocktype") = "Bad Stock"
                    End If


                    dt.Rows.Add(r1)
                    pbar1.Refresh()

                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next
                pbar1.Visible = False
                prep = New rptWhinventory
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

    Private Sub cbxWarehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWarehouse.SelectedIndexChanged

    End Sub
End Class