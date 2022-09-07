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

Public Class frmSalesInvoiceD

    'structurename
    Dim lDuplicate As Boolean = False
    Dim listrmv() As rmvitem
    Dim listupd() As upditem
    Dim listadded() As addnitem
    Dim listrowsadded() As nwaddedrows

    'structure counter
    Dim rwrmv As Integer = 0
    Dim rwupd As Integer = 0
    Dim rwadded As Integer = 0
    Dim rwsnews As Integer = 0

    Dim prevwhse As String = Nothing

    Dim ttype As String = Nothing
    Dim addrwindex As Integer = 0
    Dim prevwhs As String = Nothing
    Structure nwaddedrows
        Dim c_myrowindex As Integer
    End Structure

    Structure addnitem
        Dim c5additem As String
        Dim c5addqty As Decimal
        Dim c5addpckg As String
        Dim c5addpkno As Decimal
        Dim c5addtransno As String
    End Structure

    Structure rmvitem
        Dim c1item As String
        Dim c1qty As Decimal
        Dim c1unit As String
        Dim c1pckg As Decimal
        Dim c1pkno As Decimal
        Dim c2transno As String
        Dim c3qty As Integer
        Dim c1whs As String
    End Structure

    Structure upditem
        Dim c1uitem As String
        Dim c1upqty As Decimal
        Dim c1pkno As String
        Dim c1whse As String
        Dim c1upckg As Integer
        Dim c1upkno As String
        Dim c1operator As String
    End Structure

    Sub GetTransNo()
        Dim mdr As MySqlDataReader
        Dim ep As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        cqry = "Select transno as tno FROM salesh ORDER BY pkno DESC LIMIT 1"
        ep = New MySqlCommand(cqry, cdb)
        ep.ExecuteNonQuery()
        mdr = ep.ExecuteReader()
        If mdr.HasRows = True Then
            While mdr.Read()
                rcnt += 1
            End While
            rcvtno = Strings.Right(mdr("tno").ToString, 9) + 1
            rcvtno = "S" & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno
            mdr.Close()
        Else
            mdr.Close()
            mdr.Dispose()
        End If


        If rcnt = 0 Then
            rcvtno = "S000000001"
        End If
        mdr.Close()
        mdr.Dispose()
        ep.Dispose()

        txtTransNo.Text = rcvtno
    End Sub


    Sub LoadItemList()
        dgvItem.EndEdit()
        dgvItemList.Rows.Clear()
        '   dgvItemList.Focus()
        Dim i As Integer
        'If cbxSupplier.Text <> Nothing Then
        'cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' AND supcode=@spc ORDER BY supplier ASC", cdb)
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE obsolet <> 'Y' and isdeleted<>1 ORDER BY supplier ASC LIMIT 1000", cdb)
        'cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            ' If statement
            dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
        End While
        rd.Close()

        With dgvItemList

            If txtPriceType.Text = "A" Then
                For i = 16 To 18
                    .Columns(i).Visible = True
                Next
                For i = 19 To 30
                    .Columns(i).Visible = False
                Next
            ElseIf txtPriceType.Text = "B" Then
                For i = 19 To 21
                    .Columns(i).Visible = True
                Next
                For i = 16 To 18
                    .Columns(i).Visible = False
                Next
                For i = 22 To 30
                    .Columns(i).Visible = False
                Next
            ElseIf txtPriceType.Text = "C" Then
                For i = 22 To 24
                    .Columns(i).Visible = True
                Next
                For i = 16 To 21
                    .Columns(i).Visible = False
                Next
                For i = 25 To 30
                    .Columns(i).Visible = False
                Next
            ElseIf txtPriceType.Text = "D" Then
                For i = 25 To 27
                    .Columns(i).Visible = True
                Next
                For i = 16 To 24
                    .Columns(i).Visible = False
                Next
                For i = 28 To 30
                    .Columns(i).Visible = False
                Next
            ElseIf txtPriceType.Text = "E" Then
                For i = 28 To 30
                    .Columns(i).Visible = True
                Next
                For i = 16 To 27
                    .Columns(i).Visible = False
                Next
            End If

            If lastitemsel <> Nothing Then 'FOCUS ON LAST ITEM

                If .Rows.Count > 0 Then
                    For i = 0 To .Rows.Count - 1
                        If .Item(1, i).Value = lastitemsel Then
                            '.ClearSelection()
                            .Item(1, i).Selected = True
                            .CurrentCell = .Item(1, i)
                            .Focus()
                            Exit For
                        End If
                    Next
                End If
            Else
                .Focus()
            End If
        End With
        'End If

    End Sub

    Private Sub DeleteBlankRow()
        For i = 0 To dgvItem.RowCount - 1
            If dgvItem.Rows(i).Cells(1).Value = Nothing Then
                dgvItem.Rows.Remove(dgvItem.Rows(i))
            End If
        Next
    End Sub

    Sub getpackprice(ByVal itm As String, ByVal pck As String, ByVal rx As Integer, ByVal ptype As String)
        Dim cpck As Decimal = 0
        Dim bpck As Decimal = 0
        Dim ppck As Decimal = 0
        Dim gcost As Decimal = 0
        Dim iunit As String = Nothing
        Dim ncost As Decimal = 0
        Dim costpc As Decimal = 0
        Dim apricec As Decimal = 0
        Dim apricep As Decimal = 0


        Dim cmd As MySqlCommand
        'cmd = New MySqlCommand("SELECT PCKGC,PCKGB,PCKGP,GRSCOST,UNIT, NETCOST, COSTPC FROM ivitem WHERE ITEM=@tm", cdb)
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE itemcode=@tm and isdeleted<>1", cdb)
        cmd.Parameters.AddWithValue("@tm", itm)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()

                cpck = rd("PCKGC").ToString
                bpck = rd("PCKGB").ToString
                gcost = rd("GRSCOST").ToString
                
                If ptype = "A" Then
                    If pck = "P" Then
                        apricep = rd("APRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("APRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("APRICEC").ToString
                    End If
                ElseIf ptype = "B" Then
                    If pck = "P" Then
                        apricep = rd("BPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("BPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("BPRICEC").ToString
                    End If
                ElseIf ptype = "C" Then
                    If pck = "P" Then
                        apricep = rd("CPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("CPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("CPRICEC").ToString
                    End If
                ElseIf ptype = "D" Then
                    If pck = "P" Then
                        apricep = rd("DPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("DPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("DPRICEC").ToString
                    End If
                ElseIf ptype = "E" Then
                    If pck = "P" Then
                        apricep = rd("EPRICEP").ToString
                    ElseIf pck = "B" Then
                        apricep = rd("EPRICEB").ToString
                    ElseIf pck = "C" Then
                        apricep = rd("EPRICEC").ToString
                    End If
                End If

                iunit = rd("UNIT").ToString
                ncost = rd("NETCOST").ToString
                costpc = rd("COSTPC").ToString

                Dim pcost As Decimal = 0

                With dgvItem
                    If pck = "C" Then
                        .Item(5, rx).Value = cpck

                        .Item(6, rx).Value = Format(apricep, "STANDARD")
                        '.Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        ' .Item(8, rx).Value = costpc
                        .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                    ElseIf pck = "P" Then
                        'If iunit = "C" Then
                        '    pcost = gcost / cpck
                        'End If
                        .Item(5, rx).Value = 1

                        .Item(6, rx).Value = Format(apricep, "STANDARD")
                        '.Item(7, rx).Value = Format(costpc, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        ' .Item(8, rx).Value = costpc
                        .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(5, rx).Value * .Item(6, rx).Value, "STANDARD")

                    ElseIf pck = "B" Then
                        Dim bgprice As Decimal = 0
                        'bgprice = (apricep / cpck) * bpck
                        bgprice = (apricep) * .Item(3, rx).Value 'compute the bag price

                        .Item(6, rx).Value = Format(apricep, "STANDARD") 'get the bag price
                        '.Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                        '.Item(8, rx).Value = .Item(3, rx).Value
                        '.Item(4, rx).Value = bpck
                        '.Item(5, rx).Value = costpc
                        .Item(4, rx).Value = "B"
                        .Item(5, rx).Value = bpck
                        .Item(7, rx).Value = Format(.Item(3, rx).Value * .Item(6, rx).Value, "STANDARD")
                    End If
                End With
            End If
        End Using


    End Sub

    Function checkitemno(ByVal itmn As String)
        Dim fnd As Boolean = False
        With dgvItem
            Dim xx As Integer = 0

            If .RowCount > 1 Then

                For i = 0 To .RowCount - 2

                    If itmn = .Item(1, i).Value Then
                        xx += 1
                    End If

                Next

                If xx >= 1 Then
                    fnd = True
                End If
            End If
        End With
        Return fnd
    End Function

    Function checkitemno_update(ByVal itmn As String, ByVal rx As Integer)
        Dim fnd As Boolean = False
        With dgvItem
            Dim xx As Integer = 0

            If .RowCount > 1 Then

                For i = 0 To .RowCount - 2
                    If i <> rx Then
                        If itmn = .Item(1, i).Value Then
                            xx += 1
                        End If
                    End If
                Next
                If xx >= 1 Then
                    fnd = True
                End If
            End If
        End With
        Return fnd
    End Function

    Function getitem_byid(ByVal itemno As String, ByVal rdx As Integer)
        Dim fnd As Boolean
        fnd = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode,description,grscost, unit, PCKGC,netcost,costpc FROM ivitem WHERE itemcode=@itm and isdeleted<>1", cdb)
        'cmd = New MySqlCommand("SELECT itemcode,description,grscost, unit, PCKGC,netcost,costpc FROM ivitem WHERE ITEMCODE=@itm AND supcode=@spc", cdb)
        cmd.Parameters.AddWithValue("@itm", itemno)
        'cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
        With dgvItem
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    .Item(2, rdx).Value = rd("description").ToString
                    .Item(4, rdx).Value = rd("unit").ToString
                    .Item(5, rdx).Value = rd("PCKGC").ToString
                    .Item(6, rdx).Value = rd("grscost").ToString
                    .Item(7, rdx).Value = rd("netcost").ToString
                    '.Item(8, rdx).Value = rd("costpc").ToString

                    fnd = True
                Else
                    ' .Item(1, rdx).tag=1
                    MsgBox("ITEM NO Not Found/Belong to this supplier!", 48, "No Record Found/Belong to this supplier!")
                    .Item(2, rdx).Value = Nothing
                    .Item(3, rdx).Value = Nothing
                    .Item(4, rdx).Value = Nothing
                    .Item(5, rdx).Value = Nothing
                    .Item(6, rdx).Value = Nothing
                    .Item(7, rdx).Value = Nothing
                    '.Item(8, rdx).Value = Nothing
                    '.Item(9, rdx).Value = Nothing
                End If
            End Using
        End With
        cmd.Dispose()
        Return fnd
    End Function


    Function CheckItemIsInTheTable()
        Dim fnd As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select * from ivitem where itemcode='" & UCase(dgvItem.CurrentRow.Cells(1).Value) & "'", cdb)
        With cmd
            .Parameters.AddWithValue("@item", UCase(dgvItem.CurrentRow.Cells(1).Value))
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End With
        Return fnd
    End Function

    Private Sub dgvRcvItem_KeyDown(sender As Object, e As KeyEventArgs)

        With dgvItem
            'If e.KeyCode = Keys.Enter And .CurrentCell.ColumnIndex = 3 Then
            '    e.Handled = True
            '    'If .CurrentRow.Cells(1).Value = Nothing Then
            '    '    .Rows.Remove(.CurrentRow)
            '    'End If
            'End If
            'If e.KeyCode = Keys.F2 Then
            '    tsAddItem.PerformClick()
            'End If
        End With

    End Sub

    Sub ComputeInvoiceTotal()
        Dim ntotAmt As Double = Nothing
        Dim Gross As Double = Nothing
        Dim NetAmt As Double = Nothing
        Dim Disc1 As Double = 0
        Dim Disc2 As Double = 0
        Dim Disc3 As Double = 0

        For i = 0 To dgvItem.RowCount - 1
            Gross += dgvItem.Rows(i).Cells(7).Value
            dgvItem.Rows(i).Cells(0).Value = i + 1
        Next

        Me.txtGrossAmount.Text = Format((Gross), sFmat)
        NuPD1_KeyPress(1, New KeyPressEventArgs(vbCr))
        NuPD2_KeyPress(1, New KeyPressEventArgs(vbCr))
        NuPD3_KeyPress(1, New KeyPressEventArgs(vbCr))

        ' NetAmt = tbNetAmount.Text


        Disc1 = Gross * IIf(NuPD1.Value > 0, (NuPD1.Value / 100), 0)
        Disc2 = txtDisc1Net.Text * IIf(NuPD2.Value > 0, (NuPD2.Value / 100), 0)
        Disc3 = txtDisc2Net.Text * IIf(NuPD3.Value > 0, (NuPD3.Value / 100), 0)

        'txtDisc1.Text = Disc1
        'txtDisc2.Text = Disc2
        'txtDisc3.Text = Disc3

        Dim totdisc As Decimal = 0
        totdisc = Disc1 + Disc2 + Disc3

        Me.txtNetAmount.Text = Format((Gross - totdisc), sFmat)
        Me.txtBalance.Text = Format((Gross - totdisc), sFmat)
    End Sub

    Private Sub tsDeleteItem_Click(sender As Object, e As EventArgs)
        'If dgvRcvItem.Rows.Count = 0 Then
        '    MsgBox("Select Item to Delete!", vbCritical)
        'Else
        '    If MsgBox("Delete this Item?", vbYesNo + vbExclamation) = vbYes Then
        '        Try
        '            dgvRcvItem.Rows.Remove(dgvRcvItem.Rows(dgvRcvItem.CurrentRow.Index))
        '            ComputeRcvTotal()
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
        '    End If
        'End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCloseItem.Click
        gbxItemList.Visible = False
        gbxItemList.SendToBack()
        'LoadItemList()
        'tbSearchItem.Focus()
    End Sub

    Dim lastitemsel As String = Nothing
    Sub load_items()
        With dgvItemList
            If .RowCount > 0 Then
                With dgvItemList
                    If .RowCount > 0 Then
                        Dim nn As Integer = 0
                        Dim nm As Integer = 0
                        Dim rindex As Integer = 0
                        Dim rdx As Integer = 0

                        rdx = dgvItemList.CurrentCell.RowIndex
                        'rdx = dgvItemList.RowCount + 1
                        With dgvItem
                            'Dim mycat As String = Nothing
                            'mycat = dgvItemList.Item(6, rdx).Value

                            If .RowCount > 0 Then
                                'rindex = dgvItem.CurrentCell.RowIndex
                                rindex = dgvItem.RowCount - 1
                                Dim nrow As Integer = 0
                                Dim ccrow As Integer = 0
                                Dim krow As Integer = 0

                                'For j = 0 To .RowCount - 1
                                '    If .Item(10, j).Value = mycat Then
                                '        nrow = j
                                '        krow += 1
                                '    End If
                                'Next

                                nrow = .RowCount - 1
                                nrow += 1
                                If nrow <= 0 Then

                                    If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                        If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                            MsgBox("Item already on the list!", 64, "Item added")
                                        End If

                                        .RowCount += 1
                                        nn = .RowCount - 1
                                        selrow = nn
                                        nm = 1
                                        .ClearSelection()
                                        lastitemsel = dgvItemList.Item(1, rdx).Value
                                        .Item(0, nn).Value = nm
                                        .Item(1, nn).Tag = "A"
                                        .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value 'ITEM
                                        'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                        '    MsgBox("not equal1")
                                        'End If
                                        .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                        .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                        .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value

                                        Dim myprice As Decimal = 0

                                        If txtPriceType.Text = "A" Then
                                            myprice = dgvItemList.Item(16, rdx).Value
                                        ElseIf txtPriceType.Text = "B" Then
                                            myprice = dgvItemList.Item(19, rdx).Value
                                        ElseIf txtPriceType.Text = "C" Then
                                            myprice = dgvItemList.Item(22, rdx).Value
                                        ElseIf txtPriceType.Text = "D" Then
                                            myprice = dgvItemList.Item(25, rdx).Value
                                        ElseIf txtPriceType.Text = "E" Then
                                            myprice = dgvItemList.Item(28, rdx).Value
                                        End If

                                        .Item(6, nn).Value = myprice
                                        ' .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                        .Item(7, nn).Value = 0 'dgvItemList.Item(14, rdx).Value
                                        '.Item(8, nn).Value = dgvItemList.Item(27, rdx).Value
                                        '  .Item(10, nn).Value = "Delete"
                                        .CurrentCell = .Item(3, nn)
                                        '.Item(3, nn).Selected = True
                                        .BeginEdit(True)
                                    End If
                                Else

                                    If .Item(1, rindex).Value <> Nothing And .Item(3, rindex).Value <> 0 And _
                                        .Item(8, rindex).Value <> Nothing Then

                                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(1, rindex).Value = dgvItemList.Item(1, rdx).Value 'ITEM
                                            If .Item(9, rindex).Value <> dgvItemList.Item(1, rdx).Value Then
                                                ReDim Preserve listupd(rwupd)
                                                listupd(rwupd).c1uitem = .Item(9, rindex).Value
                                                listupd(rwupd).c1upqty = .Item(3, rindex).Value
                                                listupd(rwupd).c1whse = txtWarehouseCode.Text.Trim
                                                listupd(rwupd).c1upckg = .Item(5, rindex).Value
                                                listupd(rwupd).c1upkno = .Item(8, rindex).Value
                                                rwupd += 1
                                            End If
                                            .Item(1, rindex).Tag = "A"
                                            .Item(2, rindex).Value = dgvItemList.Item(2, rdx).Value 'DESCRIPTION
                                            .Item(4, rindex).Value = dgvItemList.Item(9, rdx).Value 'QTY
                                            .Item(5, rindex).Value = dgvItemList.Item(10, rdx).Value 'UNIT
                                            Dim myprice As Decimal = 0

                                            If txtPriceType.Text = "A" Then
                                                myprice = dgvItemList.Item(16, rdx).Value
                                            ElseIf txtPriceType.Text = "B" Then
                                                myprice = dgvItemList.Item(19, rdx).Value
                                            ElseIf txtPriceType.Text = "C" Then
                                                myprice = dgvItemList.Item(22, rdx).Value
                                            ElseIf txtPriceType.Text = "D" Then
                                                myprice = dgvItemList.Item(25, rdx).Value
                                            ElseIf txtPriceType.Text = "E" Then
                                                myprice = dgvItemList.Item(28, rdx).Value
                                            End If

                                            .Item(6, rindex).Value = myprice 'PCKG
                                            '.Item(7, rindex).Value = dgvItemList.Item(14, rdx).Value  'GROSSCOST
                                            .Item(7, nn).Value = 0 'dgvItemList.Item(14, rdx).Value
                                            '.Item(8, rindex).Value = dgvItemList.Item(15, rdx).Value 'NET-COST
                                            ' .Item(10, nn).Value = "Delete"
                                            .CurrentCell = .Item(3, rindex)
                                            '.item(3, nn).Selected = True
                                            .BeginEdit(True)
                                        Else
                                            nrow += 1
                                            .RowCount += 1
                                            nn = .RowCount - 1

                                            nm = nrow
                                            selrow = nn
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(0, nn).Value = nm
                                            .Item(1, nn).Tag = "A"
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    MsgBox("not equal2")
                                            'End If
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value

                                            Dim myprice As Decimal = 0

                                            If txtPriceType.Text = "A" Then
                                                myprice = dgvItemList.Item(16, rdx).Value
                                            ElseIf txtPriceType.Text = "B" Then
                                                myprice = dgvItemList.Item(19, rdx).Value
                                            ElseIf txtPriceType.Text = "C" Then
                                                myprice = dgvItemList.Item(22, rdx).Value
                                            ElseIf txtPriceType.Text = "D" Then
                                                myprice = dgvItemList.Item(25, rdx).Value
                                            ElseIf txtPriceType.Text = "E" Then
                                                myprice = dgvItemList.Item(28, rdx).Value
                                            End If

                                            .Item(6, rindex).Value = myprice 'PCKG
                                            '.Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                            .Item(7, nn).Value = 0 'dgvItemList.Item(14, rdx).Value
                                            '.Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                            ' .Item(10, nn).Value = "Delete"
                                            .CurrentCell = .Item(3, nn)
                                            '.item(3, nn).Selected = True
                                            .BeginEdit(True)
                                        End If

                                    Else
                                        nn = rindex
                                        If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                            If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                                MsgBox("Item already on the list!", 64, "Item added")
                                            End If
                                            nm = nn + 1
                                            selrow = nn
                                            .ClearSelection()
                                            lastitemsel = dgvItemList.Item(1, rdx).Value
                                            .Item(0, nn).Value = nm
                                            .Item(1, nn).Tag = "A"
                                            .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                            'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                            '    MsgBox("not equal3")
                                            'End If
                                            .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                            .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                            .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value

                                            Dim myprice As Decimal = 0

                                            If txtPriceType.Text = "A" Then
                                                myprice = dgvItemList.Item(16, rdx).Value
                                            ElseIf txtPriceType.Text = "B" Then
                                                myprice = dgvItemList.Item(19, rdx).Value
                                            ElseIf txtPriceType.Text = "C" Then
                                                myprice = dgvItemList.Item(22, rdx).Value
                                            ElseIf txtPriceType.Text = "D" Then
                                                myprice = dgvItemList.Item(25, rdx).Value
                                            ElseIf txtPriceType.Text = "E" Then
                                                myprice = dgvItemList.Item(28, rdx).Value
                                            End If

                                            .Item(6, rindex).Value = myprice 'PCKG
                                            '.Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                            .Item(7, nn).Value = 0 'dgvItemList.Item(14, rdx).Value
                                            '.Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                            '  .Item(10, nn).Value = "Delete"
                                            .CurrentCell = .Item(3, nn)
                                            '.Item(3, nn).Selected = True
                                            .BeginEdit(True)
                                        End If

                                    End If
                                End If

                            Else

                                If dgvItemList.Item(1, rdx).Value <> Nothing Then
                                    If checkitemno(dgvItemList.Item(1, rdx).Value) = True Then
                                        MsgBox("Item already on the list!", 64, "Item added")
                                    End If
                                    If rdx = 0 Then
                                        If dgvItemList.Item(3, rdx).Value = Nothing Then
                                            Exit Sub
                                        End If
                                    Else
                                        If dgvItemList.Item(3, rdx - 1).Value = Nothing Then
                                            Exit Sub
                                        End If
                                    End If

                                    .RowCount += 1
                                    nn = .RowCount - 1
                                    selrow = nn
                                    nm = 1
                                    .ClearSelection()
                                    lastitemsel = dgvItemList.Item(1, rdx).Value
                                    .Item(0, nn).Value = nm
                                    .Item(1, nn).Tag = "A"
                                    .Item(1, nn).Value = dgvItemList.Item(1, rdx).Value
                                    'If .Item(12, nn).Value <> dgvItemList.Item(1, rdx).Value Then
                                    '    MsgBox("not equal4")
                                    'End If
                                    .Item(2, nn).Value = dgvItemList.Item(2, rdx).Value
                                    .Item(4, nn).Value = dgvItemList.Item(9, rdx).Value
                                    .Item(5, nn).Value = dgvItemList.Item(10, rdx).Value

                                    Dim myprice As Decimal = 0

                                    If txtPriceType.Text = "A" Then
                                        myprice = dgvItemList.Item(16, rdx).Value
                                    ElseIf txtPriceType.Text = "B" Then
                                        myprice = dgvItemList.Item(19, rdx).Value
                                    ElseIf txtPriceType.Text = "C" Then
                                        myprice = dgvItemList.Item(22, rdx).Value
                                    ElseIf txtPriceType.Text = "D" Then
                                        myprice = dgvItemList.Item(25, rdx).Value
                                    ElseIf txtPriceType.Text = "E" Then
                                        myprice = dgvItemList.Item(28, rdx).Value
                                    End If

                                    .Item(6, rindex).Value = myprice 'PCKG
                                    ' .Item(7, nn).Value = dgvItemList.Item(14, rdx).Value
                                    .Item(7, nn).Value = 0 'dgvItemList.Item(14, rdx).Value
                                    '.Item(8, nn).Value = dgvItemList.Item(15, rdx).Value
                                    ' .Item(10, nn).Value = "Delete"
                                    .CurrentCell = .Item(3, nn)
                                    '.Item(3, nn).Selected = True
                                    .BeginEdit(True)
                                End If

                            End If

                        End With
                    End If
                End With

                gbxItemList.Visible = False
                gbxItemList.SendToBack()
            End If
        End With
    End Sub

    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        load_items()
    End Sub

    Private Sub dgvItemList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvItemList.KeyDown
        With dgvItemList
            If .RowCount > 0 Then
                If e.KeyCode = Keys.Enter Then
                    load_items()
                End If
            End If
        End With
    End Sub

    Private Sub dgvRcvItem_KeyPress(sender As Object, e As KeyPressEventArgs)
        With dgvItem
            If .Rows.Count > 0 Then
                If Asc(e.KeyChar) = 13 Then
                    If .CurrentCell.ColumnIndex = 5 Then
                        btnAdd.PerformClick()
                    End If

                End If
            End If
        End With
    End Sub

    Public Sub column_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 48 Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then e.Handled = True
    End Sub

    Private Sub tbSearchItem_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSearchItem.KeyDown
        If e.KeyCode = Keys.Down Then
            dgvItemList.Focus()
        End If
    End Sub

    Private Sub tbSearchItem_TextChanged(sender As Object, e As EventArgs) Handles tbSearchItem.TextChanged
        Try
            Dim i As Integer
            dgvItemList.Rows.Clear()
            cmd = New MySqlCommand("SELECT * from ivitem where (itemcode like '%" & tbSearchItem.Text & "%' " & _
                                   " OR description like '%" & tbSearchItem.Text & "%') and isdeleted<>1", cdb)
            'cmd = New MySqlCommand("SELECT * from ivitem where (itemcode like '%" & tbSearchItem.Text & "%' " & _
            '                       " OR description like '%" & tbSearchItem.Text & "%') " & _
            '                       " AND supcode=@spc", cdb)
            'cmd.Parameters.AddWithValue("@spc", cbxSupplier.SelectedItem.value)
            rd = cmd.ExecuteReader
            While rd.Read
                i += 1
                dgvItemList.Rows.Add(i, rd.Item("itemcode").ToString, rd.Item("description").ToString, rd.Item("supcode").ToString, rd.Item("supplier").ToString, rd.Item("catcode").ToString, rd.Item("category").ToString, _
                                  rd.Item("brcode").ToString, rd.Item("brand").ToString, rd.Item("unit").ToString, Format(CDbl(rd.Item("pckgc").ToString), "#,##0"), rd.Item("pckgb").ToString, _
                                  rd.Item("freeitem").ToString, rd.Item("grscost").ToString, rd.Item("netcost").ToString, rd.Item("costpc").ToString, _
                                  Format(CDbl(rd.Item("apricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("apriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("apricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("bpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("bpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("cpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("cpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("dpricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("dpricep").ToString), "#,##0.00"), _
                                  Format(CDbl(rd.Item("epricec").ToString), "#,##0.00"), Format(CDbl(rd.Item("epriceb").ToString), "#,##0.00"), Format(CDbl(rd.Item("epricep").ToString), "#,##0.00"), _
                                  rd.Item("obsolet").ToString, Format(CDbl(rd.Item("discpct").ToString), "#,##.0"), rd.Item("pkno").ToString) ' "Edit", "Delete")
            End While
            rd.Close()
            '  cn.Close()
        Catch ex As Exception
            ' cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function isExistWarehouseAndItem(ByVal currentwhsname As String, ByVal itemcode As String) As Boolean
        Dim existna As Boolean = False
        Dim cmd2 As New MySqlCommand
        cmd2 = New MySqlCommand("SELECT * FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd2.Parameters.AddWithValue("@itm", itemcode)
        cmd2.Parameters.AddWithValue("@wh", currentwhsname)
        Using rd2 As MySqlDataReader = cmd2.ExecuteReader
            If rd2.HasRows Then
                rd2.Read()
                existna = True
            End If
            rd2.Close()
        End Using
        cmd2.Dispose()

        Return existna
    End Function

    Function getCurrentQTYSaExisting(ByVal currentwhsname As String, ByVal itemcode As String) As Integer
        Dim qtyex As Integer = 0

        Dim cmd2 As New MySqlCommand
        cmd2 = New MySqlCommand("SELECT * FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd2.Parameters.AddWithValue("@itm", itemcode)
        cmd2.Parameters.AddWithValue("@wh", currentwhsname)
        Using rd2 As MySqlDataReader = cmd2.ExecuteReader
            If rd2.HasRows Then
                rd2.Read()
                qtyex = rd2("qty_good").ToString
            End If
            rd2.Close()
        End Using
        cmd2.Dispose()

        Return qtyex
    End Function

    Private Sub dgvRcvItem_KeyUp(sender As Object, e As KeyEventArgs)
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0

                mrw = .CurrentCell.RowIndex
                If .CurrentCell.ColumnIndex = 4 Then
                    Dim itemno As String = Nothing
                    Dim mpc As String = Nothing

                    itemno = .Item(1, mrw).Value

                    If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
                        mpc = .Item(4, mrw).Value
                        ComputeInvoiceTotal()
                    Else
                        .Item(4, mrw).Value = "C"
                        mpc = .Item(4, mrw).Value
                        .BeginEdit(True)
                        ComputeInvoiceTotal()
                    End If

                    getpackprice(itemno, mpc, mrw, txtPriceType.Text)

                    If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = "P"
                        mpc = .Item(4, mrw).Value
                        ComputeInvoiceTotal()
                    End If

                    ComputeInvoiceTotal()
                ElseIf .CurrentCell.ColumnIndex = 1 And e.KeyCode = Keys.F3 Then
                    btnSearchItem.PerformClick()
                End If
            End If
        End With
    End Sub

    Private Sub tsAdd_Click_1(sender As Object, e As EventArgs)
        'With dgvRcvItem
        '    Dim r As Integer
        '    .Rows.Add()
        '    r = .Rows.Count - 1
        '    .Rows(r).Cells(0).Value = r + 1
        '    .CurrentCell = .Rows(r).Cells(1)
        '    dgvRcvItem.Focus()
        '    .BeginEdit(True)
        'End With
    End Sub


    'Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    '    Dim r As Integer

    '    If btnSearch.Enabled = False Then
    '        btnSearch.Enabled = True
    '    End If

    '    'If cbxSupplier.Text = "" Then
    '    '    MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
    '    '    cbxSupplier.Focus()
    '    '    Exit Sub
    '    'End If

    '    'If cboWhsCode.Text = "" Then
    '    '    MsgBox("Pls. Enter Warehouse!", MsgBoxStyle.Information)
    '    '    cboWhsCode.Focus()
    '    '    Exit Sub
    '    'End If

    '    If gbxItemList.Visible = True Then
    '        gbxItemList.SendToBack()
    '        gbxItemList.Visible = False
    '    End If

    '    With dgvItem

    '        If .Rows.Count > 0 Then
    '            r = .Rows.Count - 1

    '            If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing Then

    '                If .Rows(r).Cells(3).Value = 0 Then
    '                    .ClearSelection()
    '                    .CurrentCell = .Item(3, r)

    '                    .BeginEdit(True)
    '                Else
    '                    .Rows.Add()
    '                    r = .Rows.Count - 1
    '                    selrow = r
    '                    .Rows(r).Cells(0).Value = r + 1
    '                    .ClearSelection()
    '                    .CurrentCell = .Item(1, r)

    '                    .BeginEdit(True)
    '                End If

    '            Else
    '                .ClearSelection()
    '                .CurrentCell = .Item(1, r)

    '                .BeginEdit(True)
    '            End If
    '        Else
    '            .Rows.Add()
    '            r = .Rows.Count - 1
    '            selrow = r
    '            .Rows(r).Cells(0).Value = r + 1
    '            .CurrentCell = .Rows(r).Cells(1)
    '            .BeginEdit(True)
    '        End If
    '        ' dgvRcvItem.Focus()
    '        ' dgvRcvItem.CurrentCell = dgvRcvItem.CurrentRow.Cells(1)
    '    End With


    'End Sub

    Private Sub tbSupCode_KeyPress(sender As Object, e As KeyPressEventArgs)
        'cmd = New MySqlCommand("SELECT * from supplier where supcode like '%" & cbxSupplier.Text & "%'", cdb)
        'rd = cmd.ExecuteReader
        'If rd.HasRows Then
        '    rd.Read()
        '    With rd
        '        tbSupplier.Text = rd.Item("suppliername").ToString
        '    End With
        'End If
        'rd.Close()
    End Sub

    Private Sub cbx_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        With dgvItem
            If .Item(3, selrow).Value <> 0 Then
                .ClearSelection()
                Dim method As New SetColumnIndex(AddressOf Mymethod)
                Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
                Me.dgvItem.BeginInvoke(method, nextindex)
            End If

        End With

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearchItem.Click

        If txtCustCode.Text = Nothing Then
            MsgBox("Please Select Customer!", MsgBoxStyle.Critical)
            txtCustCode.Focus()
            Exit Sub
        Else
            btnAdd.PerformClick()
        End If

        ' btnAdd_Click(sender, e)
        btnAdd.PerformClick()

        With dgvItem
            btnAdd.PerformClick()
            If .Rows.Count > 0 Then
                Dim r As Integer = 0
                r = .Rows.Count - 1
                If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing _
                    And .Rows(r).Cells(7).Value <> Nothing Then
                    gbxItemList.BringToFront()
                    tbSearchItem.Focus()
                    gbxItemList.Visible = True
                    LoadItemList()
                    gbxItemList.Focus()
                    dgvItemList.Focus()
                Else
                    LoadItemList()
                    gbxItemList.BringToFront()
                    gbxItemList.Visible = True
                    gbxItemList.Focus()
                    dgvItemList.Focus()
                    ' MsgBox("Please provide proper item/s and quantity first", 48, "Invalid entry found")
                End If
                dgvItemList.Focus()
            Else
                gbxItemList.Visible = True
                gbxItemList.BringToFront()
                LoadItemList()
                gbxItemList.Focus()
            End If

            dgvItemList.Focus()
        End With
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'original code
        If MsgBox("(*Note, removing this item will remove the last reflected quantity of this item) Remove this Item? Click Yes to Confirm", vbYesNo + vbInformation) = vbYes Then
            'ReDim Preserve listrmv(rwrmv)
            'With listrmv(rwrmv)
            '    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
            '    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Value
            '    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
            '    .c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
            '    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag
            'End With
            If Me.Tag = 1 Then
                ReDim Preserve listrmv(rwrmv)
                With listrmv(rwrmv)


                    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                    .c1qty = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
                    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
                    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Tag
                    '.c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag
                    .c1whs = dgvItem.Item(10, dgvItem.CurrentRow.Index).Value
                End With
                rwrmv += 1
            End If
            dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))
            ComputeInvoiceTotal()
            CalTotalQty()
        End If

    End Sub

    Private Sub txtCustCode_DoubleClick(sender As Object, e As EventArgs) Handles txtCustCode.DoubleClick
        frmSearchCustomerInvoice.Text = "SALES INVOICE"
        frmSearchCustomerInvoice.ShowDialog()
    End Sub

    Private Sub txtCustCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmSearchCustomerInvoice.Text = "SALES INVOICE"
            frmSearchCustomerInvoice.ShowDialog()
        End If
    End Sub

    Private Sub txtCustCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustCode.KeyPress
        If e.KeyChar = vbCr Then
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT * FROM customers WHERE custcode = '" & txtCustCode.Text & "'", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtCustomername.Text = rd("custname").ToString
                txtAddress.Text = rd("address").ToString
            End If
            rd.Dispose()

            cmd = New MySqlCommand("SELECT c.*,s.* FROM custsales c JOIN salesman s WHERE custcode = '" & txtCustCode.Text & "' AND c.slmncode=s.slmncode", cdb)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtSalesmanCode.Text = rd("slmncode").ToString
                txtSalesmanName.Text = rd("slmnname").ToString
                txtPriceType.Text = rd("pricetype").ToString
                txtWarehouseCode.Text = rd("whscode").ToString
                txtWarehouseName.Text = rd("warehouse").ToString
                rd.Dispose()
                txtSalesmanCode.Focus()
            Else
                MsgBox("Customer Code is invalid!", MsgBoxStyle.Critical)
                txtCustCode.Focus()
            End If
            rd.Dispose()
        End If

        'If e.KeyChar = vbCr Then
        '    txtSalesmanCode.Focus()
        'End If
    End Sub

    Private Sub frmSalesInvoiceD_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F3 Then
            btnSearchItem.PerformClick()
            ''  btnAdd_Click(sender, e)
            'gbxItemList.Focus()
            'If txtCustCode.Text = Nothing Or txtSalesmanCode.Text = Nothing Then
            '    MsgBox("Select customer first!", vbCritical)
            '    Exit Sub
            'Else
            '    With dgvItem
            '        If .Rows.Count > 0 Then
            '            Dim r As Integer = 0

            '            r = .Rows.Count - 1

            '            If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing _
            '                And .Rows(r).Cells(6).Value <> Nothing Then

            '                gbxItemList.BringToFront()
            '                gbxItemList.Visible = True
            '                dgvItemList.Focus()
            '                LoadItemList()
            '                With dgvItemList
            '                    If lastitemsel <> Nothing Then 'FOCUS ON LAST ITEM

            '                        If .Rows.Count > 0 Then
            '                            For i = 0 To .Rows.Count - 1
            '                                If .Item(1, i).Value = lastitemsel Then
            '                                    '.ClearSelection()
            '                                    .Item(1, i).Selected = True
            '                                    .CurrentCell = .Item(1, i)
            '                                    .Focus()
            '                                    Exit For
            '                                End If
            '                            Next
            '                        End If
            '                    Else
            '                        .Focus()
            '                    End If
            '                End With
            '                dgvItemList.Focus()
            '            Else
            '                '  MsgBox("Please provide proper item/s and quantity first", 48, "Invalid entry found")
            '            End If
            '        Else
            '            dgvItemList.Focus()
            '            gbxItemList.Visible = True
            '            gbxItemList.BringToFront()

            '            LoadItemList()
            '            With dgvItemList
            '                If lastitemsel <> Nothing Then 'FOCUS ON LAST ITEM

            '                    If .Rows.Count > 0 Then
            '                        For i = 0 To .Rows.Count - 1
            '                            If .Item(1, i).Value = lastitemsel Then
            '                                '.ClearSelection()
            '                                .Item(1, i).Selected = True
            '                                .CurrentCell = .Item(1, i)
            '                                .Focus()
            '                                Exit For
            '                            End If
            '                        Next
            '                    End If
            '                Else
            '                    .Focus()

            '                End If
            '            End With
            '            dgvItemList.Focus()
            '        End If
            '    End With
            'End If
        ElseIf e.KeyCode = Keys.Escape Then
            If gbxItemList.Visible = True Then
                btnCloseItem.PerformClick()
                'gbxItemList.Visible = False
                'gbxItemList.SendToBack()
                btnAdd_Click(sender, e)
            ElseIf gbxItemList.Visible = False Then
                ' If MsgBox("Are you sure you want to Discard Changes?", vbYesNo + vbQuestion, "Receiving Entry") = vbYes Then
                btnCloseInvD.PerformClick()
                'End If
            ElseIf e.KeyCode = Keys.F7 Then
                btnRemove.PerformClick()
            End If
        End If

        '    If e.KeyCode = Keys.F2 Then
        '        frmSearchCustomer.Text = "SALES INVOICE"
        '        frmSearchCustomer.ShowDialog()
        '    End If




        '    If e.KeyCode = Keys.Escape Then
        '        If gbxItemList.Visible = True Then
        '            gbxItemList.Visible = False
        '            gbxItemList.SendToBack()
        '            btnAdd_Click(sender, e)
        '        Else
        '            If MsgBox("Are you sure you want to Discard Changes?", vbYesNo + vbQuestion, "Receiving Entry") = vbYes Then
        '                btnCloseD.PerformClick()
        '            End If
        '        End If
        '    End If

        '    If e.KeyCode = Keys.F7 Then
        '        btnRemove_Click(sender, e)
        '    End If

        '    If e.KeyCode = Keys.F2 Then
        '        frmSearchCustomer.Text = "SALES INVOICE"
        '        frmSearchCustomer.ShowDialog()
        '    End If

        'End If


        ' tbSearchItem.Focus()
        'End If


        'If e.KeyCode = Keys.Escape Then
        '    If gbxItemList.Visible = True Then
        '        gbxItemList.Visible = False
        '    Else
        '        If MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Sales Invoice") = vbYes Then
        '            Me.Dispose()
        '        End If
        '    End If
        'End If
        'End If



    End Sub

    Private Sub frmSalesInvoiceD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ttype = "S"

        If txtCustCode.Text = Nothing Then
            txtCustCode.Focus()
        End If

        If txtInvoiceNo.Text <> Nothing Then
            txtInvoiceUpdate.Text = txtInvoiceNo.Text
        End If

        If txtPONo.Text <> Nothing Then
            txtPONoUpdate.Text = txtPONo.Text
        End If

        If txtBalance.Text <> Nothing Then
            txtBalance.Text = txtNetAmount.Text
        End If

        If txtUser.Text = Nothing Then
            txtUser.Text = _user
        End If
        prevwhs = txtWarehouseCode.Text
        If Me.Tag = 0 Then
            'LoadSupplier()
            'LoadWarehouse()
            LoadCustomerList()
            LoadSalesman()
            reset_listrmv()
            reset_listupd()
            ' cboPriceType.Text = "A"
            txtGrossAmount.Text = "0.00"
            txtDisc1.Text = "0.00"
            txtDisc2.Text = "0.00"
            txtNetAmount.Text = "0.00"
            cbTerms.Text = "CREDIT"
        End If

        'btnUpdate.Enabled = False
        'btnUpdatePrint.Enabled = False
        'btnSave.Enabled = True
        'btnSavePrint.Enabled = True
        'RcvDate.Enabled = False

        CalTotalQty()
        txtCustCode.Focus()

    End Sub

    Sub LoadCustomerList()
        'dgvCustomerList.Rows.Clear()
        'Dim i As Integer
        'cmd = New MySqlCommand("SELECT * FROM customers WHERE active <> 'N' order by custname asc", cdb)
        ''cmd = New MySqlCommand("SELECT c.*,s.* FROM customers c JOIN custsales s ON c.custcode=s.custcode WHERE c.custcode like '" & frmSalesInvoiceD.txtCustCode.Text & "'", cdb)
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    i += 1
        '    dgvCustomerList.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
        '                          rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
        '                          rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
        '                          Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
        '                          rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        'End While
        'rd.Close()
        'dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
        'dgvCustomerList.Focus()
    End Sub

    'Sub LoadSalesman()
    'Dim i As Integer = 0
    'dgvListSalesman.Rows.Clear()
    'cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE c.custcode like '" & txtCustCode.Text & "'", cdb)
    'rd = cmd.ExecuteReader
    'While rd.Read
    '    i += 1
    '    dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString) ') ', rd.Item("pkno").ToString, "Edit", "Delete")
    'End While
    'rd.Close()
    ' End Sub

    Private Sub txtSalesmanCode_DoubleClick(sender As Object, e As EventArgs) Handles txtSalesmanCode.DoubleClick
        If txtCustCode.Text = Nothing Then
            MsgBox("Select customer first!", vbExclamation)
        Else
            frmSearchSalesmanInvoice.ShowDialog()
        End If
        'gbSalesman.BringToFront()
        'gbSalesman.Visible = True
    End Sub


    Private Sub txtSalesmanCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSalesmanCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            If txtCustCode.Text = Nothing Then
                MsgBox("Select customer first!", vbCritical)
                Exit Sub
            Else
                frmSearchSalesmanInvoice.Show()
                'gbSalesman.BringToFront()
                'gbSalesman.Visible = True
            End If
        End If
    End Sub

    Private Sub txtSalesmanCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesmanCode.KeyPress
        e.Handled = True
        If e.KeyChar = vbCr Then
            txtPONo.Focus()
        End If

        'Dim cmd As MySqlCommand
        ''cmd = New MySqlCommand("SELECT c.*,s.* FROM custsales c JOIN salesman s WHERE slmncode = '" & txtSalesmanCode.Text & "'", cdb)
        'cmd = New MySqlCommand("SELECT * FROM custsales WHERE slmncode = '" & txtSalesmanCode.Text & "'", cdb)
        'rd = cmd.ExecuteReader
        'rd.Read()
        'If rd.HasRows Then
        '    'txtSalesmanCode.Text = rd("slmncode").ToString
        '    txtSalesmanName.Text = rd("slmnname").ToString
        '    txtPriceType.Text = rd("pricetype").ToString
        '    txtWarehouseCode.Text = rd("whscode").ToString
        '    txtWarehouseName.Text = rd("warehouse").ToString
        'Else
        '    MsgBox("Salesman code is invalid!", MsgBoxStyle.Critical)
        '    txtSalesmanCode.Focus()
        'End If
        'rd.Dispose()



    End Sub

    'Private Sub txtSalesmanCode_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSalesmanCode.MouseDoubleClick
    '    gbSalesman.BringToFront()
    '    gbSalesman.Visible = True
    'End Sub

    Private Sub txtSalesmanCode_TextChanged(sender As Object, e As EventArgs) Handles txtSalesmanCode.TextChanged

    End Sub

    Private Sub txtPONo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPONo.KeyPress
        If e.KeyChar = vbCr Then
            txtInvoiceNo.Focus()
        End If
    End Sub

    Private Sub txtPONo_TextChanged(sender As Object, e As EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub txtInvoiceNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoiceNo.KeyPress
        If e.KeyChar = vbCr Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim r As Integer

        If btnSearchItem.Enabled = False Then
            btnSearchItem.Enabled = True
        End If

        'If cbxSupplier.Text = "" Then
        '    MsgBox("Please Enter Supplier!", MsgBoxStyle.Critical)
        '    cbxSupplier.Focus()
        '    Exit Sub
        'End If

        'If cboWhsCode.Text = "" Then
        '    MsgBox("Pls. Enter Warehouse!", MsgBoxStyle.Information)
        '    cboWhsCode.Focus()
        '    Exit Sub
        'End If

        If txtCustCode.Text = Nothing Or txtSalesmanCode.Text = Nothing Then
            MsgBox("Required missing field!", vbExclamation)
            Exit Sub
        Else
            If gbxItemList.Visible = True Then
                gbxItemList.SendToBack()
                gbxItemList.Visible = False
            End If
        End If

        With dgvItem

            If .Rows.Count > 0 Then
                r = .Rows.Count - 1

                If .Rows(r).Cells(1).Value <> Nothing And .Rows(r).Cells(3).Value <> Nothing Then

                    If .Rows(r).Cells(3).Value = 0 Then
                        .ClearSelection()
                        .CurrentCell = .Item(3, r)

                        .BeginEdit(True)
                    Else
                        .Rows.Add()
                        r = .Rows.Count - 1
                        selrow = r
                        .Rows(r).Cells(1).Tag = "A"
                        .Rows(r).Cells(0).Value = r + 1
                        .ClearSelection()
                        .CurrentCell = .Item(1, r)

                        .BeginEdit(True)
                    End If

                Else
                    .ClearSelection()
                    .CurrentCell = .Item(1, r)

                    .BeginEdit(True)
                End If
            Else
                .Rows.Add()
                r = .Rows.Count - 1
                selrow = r
                .Rows(r).Cells(1).Tag = "A"
                .Rows(r).Cells(0).Value = r + 1
                .CurrentCell = .Rows(r).Cells(1)
                .BeginEdit(True)
            End If
            ' dgvRcvItem.Focus()
            ' dgvRcvItem.CurrentCell = dgvRcvItem.CurrentRow.Cells(1)
        End With
    End Sub

    Sub iClear()
        txtTransNo.Clear()
        txtCustCode.Clear()
        txtCustomername.Clear()
        txtAddress.Clear()
        txtSalesmanCode.Clear()
        txtSalesmanName.Clear()
        txtPriceType.Clear()
        txtWarehouseCode.Clear()
        txtWarehouseName.Clear()
        txtInvoiceNo.Clear()
        txtInvoiceUpdate.Clear()
        txtPONo.Clear()
        txtPONoUpdate.Clear()
        txtRemarks.Clear()
        NuPD1.Text = "0.00"
        NuPD2.Text = "0.00"
        txtGrossAmount.Text = "0.00"
        txtDisc1.Text = "0.00"
        txtDisc1Net.Text = "0.00"
        txtDisc2.Text = "0.00"
        txtDisc2Net.Text = "0.00"
        txtNetAmount.Text = "0.00"
        dgvItem.Rows.Clear()
        txtCustCode.Focus()
    End Sub

    Sub iDisabled()
        txtCustCode.Enabled = False
        'txtCustomername.Clear()
        'txtAddress.Clear()
        txtSalesmanCode.Enabled = False
        'txtSalesmanName.Clear()
        'txtPriceType.Clear()
        'txtWarehouseCode.Clear()
        'txtWarehouseName.Clear()
        txtInvoiceNo.Enabled = False
        'txtInvoiceUpdate.Clear()
        txtPONo.Enabled = False
        'txtPONoUpdate.Clear()
        txtRemarks.Enabled = False
        NuPD1.Enabled = False
        NuPD2.Enabled = False
        'txtGrossAmount.Text = "0.00"
        'txtDisc1.Text = "0.00"
        'txtDisc1Net.Text = "0.00"
        'txtDisc2.Text = "0.00"
        'txtDisc2Net.Text = "0.00"
        'txtNetAmount.Text = "0.00"
    End Sub

    Sub iEnabled()

    End Sub

    Function checkInvoiceNo()
        Dim fnd As Boolean = False
        If txtInvoiceNo.Text.Trim <> Nothing Then
            Dim cmd As MySqlCommand
            'cmd = New MySqlCommand("SELECT invoiceno FROM salesh WHERE invoiceno = @ivno", cdb) 'orig
            cmd = New MySqlCommand("SELECT invoiceno FROM salesh WHERE invoiceno = @ivno and ttype <> 'R' and ttype <> 'B'", cdb)
            With cmd
                .Parameters.AddWithValue("@ivno", txtInvoiceNo.Text.Trim)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows = True Then
                        fnd = True
                    End If
                    rd.Close()
                End Using
            End With
        End If

        Return fnd
    End Function

    Function checkPONO()
        Dim fnd As Boolean = False
        If txtPONo.Text.Trim <> Nothing Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("SELECT pono FROM rcvingh WHERE pono = @pn", cdb)
            With cmd
                .Parameters.AddWithValue("@pn", txtPONo.Text.Trim)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows = True Then
                        fnd = True
                    End If
                    rd.Close()
                End Using
            End With
        End If

        Return fnd
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtInvoiceNo.Text = "" Then
            MsgBox("Invoice Number is required", vbCritical)
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        If checkInvoiceNo() = True Then
            MsgBox("Invoice No. already used!.", 48, "Enter Invoice No.")
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        If checkPONO() = True Then
            MsgBox("PO No. already Used!.", 48, "Enter PO No.")
            txtPONo.Focus()
            Exit Sub
        End If

        With dgvItem
            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()

            'If txtCustCode.Text <> Nothing Then
            '    If MsgBox("Save invoice?", vbYesNo + vbQuestion) = vbYes Then
            '        Dim asave As Boolean = True

            If .RowCount > 0 Then
                Dim asave As Boolean = True
                For i = 0 To .Rows.Count - 1
                    'If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                    If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                        asave = False
                    End If
                Next

                If asave = True Then
                    ' GetTransNo()
                    SaveSalesInvoice()
                    MsgBox("Sales invoice has save successfully", vbInformation)
                    iClear()
                    txtCustCode.Focus()
                    With frmSalesInvoiceH
                        '.LoadSalesHeader()
                        .LoadSalesHeaderNew()
                    End With
                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If
            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
            'End If

        End With

        ''update applied if cod
        'If cbTerms.Text = "COD" Then
        '    Dim 
        '    cmd = New MySqlCommand("UPDATE salesh SET applied=totalamt WHERE transno=@tno ", cdb)
        '    cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)

        'End If
    End Sub


    Sub SaveSalesInvoice()

        

        'item qty deduct to ivwh
        With dgvItem
            Dim mkerr As Integer = 0
            Dim mkmsg As String = Nothing
            For i = 0 To .RowCount - 1
                If .Item(3, i).Value <> Nothing Then 'qty <> nothing
                    If .Item(3, i).Value > 0 Then 'qty > 0
                        Dim fnd1 As Boolean = False
                        Dim itmc As String = Nothing
                        Dim pkn As String = Nothing
                        Dim oqty As String = Nothing
                        Dim opck As String = Nothing
                        Dim newwqty As String = Nothing


                        itmc = .Item(1, i).Value
                        pkn = .Item(8, i).Value
                        newwqty = .Item(3, i).Value

                        Dim unt As String = 0
                        Dim nwq As Decimal = 0
                        Dim qtyfromwhs As Decimal = 0
                        qtyfromwhs = getcurqty(itmc, txtWarehouseCode.Text, "G")
                        unt = .Item(4, i).Value
                        nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                        oqty = getoldqtyfrmtable(itmc, pkn, "salesd")

                        Dim old_item_unit As String = Nothing
                        old_item_unit = getolditemunit(itmc, pkn, "salesd")
                        Dim old_item_qty As Decimal = 0
                        old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)

                        oqty = old_item_qty

                        nwq = nwq - oqty
                        'End If
                        If nwq > qtyfromwhs Then
                            mkerr = 1
                            If mkmsg = Nothing Then
                                mkmsg = itmc & " exceeded quantity"
                            Else
                                mkmsg = mkmsg & " " & vbNewLine & itmc & " exceeded quantity"
                            End If
                        End If

                    End If
                End If
            Next

            If mkerr = 0 Then
                'insert to salesh
                Dim TransNo As String = GenerateTransNo_SalesInvoice_Return_Bo("S")
                Dim cmd As MySqlCommand
                Dim i As Integer

                'cmd = New MySqlCommand("INSERT INTO salesh (transno,ttype,idate,custcode,slmncode,whscode,invoiceno,pono,grosstot,disc1percent,disc1amount,disc2percent,disc2amount, " & _
                '                       "remarks,totalamt,applied,balance,user,terms,disc1net,disc2net) VALUES (@transno,@ttype,@idate,@custcode,@slmncode,@whscode,@invoiceno,@pono,@grosstot,@disc1percent,@disc1amount, " & _
                '                       "@disc2percent,@disc2amount,@remarks,@totalamt,@applied,@balance,@user,@terms,@disc1net,@disc2net)", cdb)

                cmd = New MySqlCommand("INSERT INTO salesh (transno,ttype,tdate,custcode,slmncode,whscode,invoiceno,pono,grosstot,disc1percent,disc1amount,disc2percent,disc2amount, " & _
                                       "remarks,totalamt,applied,user,terms,disc1net,disc2net,pdate) VALUES (@transno,@ttype,@tdate,@custcode,@slmncode,@whscode,@invoiceno,@pono,@grosstot,@disc1percent,@disc1amount, " & _
                                       "@disc2percent,@disc2amount,@remarks,@totalamt,@applied,@user,@terms,@disc1net,@disc2net,@pdate)", cdb)
                With cmd
                    cmd.Parameters.AddWithValue("@transno", TransNo)
                    cmd.Parameters.AddWithValue("@ttype", ttype)
                    cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
                    cmd.Parameters.AddWithValue("@custcode", txtCustCode.Text)
                    cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                    cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
                    cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
                    cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
                    cmd.Parameters.AddWithValue("@grosstot", Decimal.Parse(txtGrossAmount.Text))
                    cmd.Parameters.AddWithValue("@disc1percent", NuPD1.Value)
                    cmd.Parameters.AddWithValue("@disc1amount", Decimal.Parse(txtDisc1.Text))
                    cmd.Parameters.AddWithValue("@disc2percent", NuPD2.Value)
                    cmd.Parameters.AddWithValue("@disc2amount", Decimal.Parse(txtDisc2.Text))
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    cmd.Parameters.AddWithValue("@totalamt", Decimal.Parse(txtNetAmount.Text))
                    If cbTerms.Text.Trim = "CASH" Then
                        cmd.Parameters.AddWithValue("@applied", Decimal.Parse(txtNetAmount.Text))
                        ' cmd.Parameters.AddWithValue("@balance", 0)
                        cmd.Parameters.AddWithValue("@pdate", Date.Today)
                    Else
                        cmd.Parameters.AddWithValue("@applied", 0)
                        'cmd.Parameters.AddWithValue("@balance", Decimal.Parse(txtNetAmount.Text))
                        cmd.Parameters.AddWithValue("@pdate", DBNull.Value)
                    End If
                    'cmd.Parameters.AddWithValue("@balance", Decimal.Parse(txtNetAmount.Text))
                    cmd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmd.Parameters.AddWithValue("@terms", cbTerms.Text)
                    cmd.Parameters.AddWithValue("@disc1net", Decimal.Parse(txtDisc1Net.Text))
                    cmd.Parameters.AddWithValue("@disc2net", Decimal.Parse(txtDisc2Net.Text))

                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End With

                'insert to salesd

                For i = 0 To .RowCount - 1
                    If .Item(3, i).Value <> Nothing Then
                        If .Item(3, i).Value > 0 Then
                            cmd = New MySqlCommand("INSERT INTO salesd (transno,ttype,tdate,pricetype,whscode,invoiceno, " & _
                                                   "pono,itemcode,qty,qunit,pckg,uprice,amount) VALUES (@transno,@ttype,@tdate,@pricetype, " & _
                                                   "@whscode,@invoiceno,@pono,@item,@qty,@unit,@pckg,@uprice,@amount)", cdb)
                            cmd.Parameters.AddWithValue("@transno", TransNo)
                            cmd.Parameters.AddWithValue("@ttype", ttype)
                            cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
                            cmd.Parameters.AddWithValue("@pricetype", txtPriceType.Text)
                            cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
                            cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
                            cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
                            cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@qty", .Item(3, i).Value)
                            cmd.Parameters.AddWithValue("@unit", .Item(4, i).Value)
                            cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                            cmd.Parameters.AddWithValue("@uprice", Decimal.Parse(.Item(6, i).Value))
                            cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End If
                Next

                For i = 0 To .RowCount - 1
                    If .Item(3, i).Value <> Nothing Then
                        If .Item(3, i).Value > 0 Then
                            Dim totalqty As Decimal = 0
                            If .Item(4, i).Value = "C" Or .Item(4, i).Value = "B" Then
                                totalqty = .Item(3, i).Value * IIf(.Item(5, i).Value > 0, .Item(5, i).Value, 1)
                            ElseIf .Item(4, i).Value = "P" Then
                                totalqty = .Item(3, i).Value
                            End If

                            Dim fnds As Boolean = False
                            Dim curqty As Decimal = 0
                            cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
                            cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@wh", txtWarehouseCode.Text.Trim)
                            Using rd As MySqlDataReader = cmd.ExecuteReader
                                If rd.HasRows Then
                                    fnds = True
                                    rd.Read()
                                    curqty = rd("qty_good").ToString
                                End If
                                rd.Close()
                            End Using
                            cmd.Dispose()

                            'If fnds = False Then
                            '    cmd = New MySqlCommand("INSERT INTO ivwh (item,whs,qty_good) VALUES (@itm,@wh,@qtyg)", cdb)

                            '    cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            '    cmd.Parameters.AddWithValue("@wh", cboWhsCode.Text.Trim)
                            '    cmd.Parameters.AddWithValue("@qtyg", totalqty)
                            '    cmd.ExecuteNonQuery()
                            '    cmd.Dispose()
                            'Else

                            Dim nqty As Decimal = 0
                            'Dim inputqty As Decimal = 0

                            'inputqty = curqty

                            'If inputqty > curqty Then
                            '    MsgBox("Input Quantity is Greater than Available Qauntity!", vbExclamation)
                            '    Exit Sub
                            '  Else

                            nqty = curqty - totalqty
                            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
                            cmd.Parameters.AddWithValue("@itm", .Item(1, i).Value)
                            cmd.Parameters.AddWithValue("@wh", txtWarehouseCode.Text.Trim)
                            cmd.Parameters.AddWithValue("@qtyg", nqty)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If
                    End If
                    ' End If
                    ' End If
                Next
            Else
                MsgBox(mkmsg, 48, " Exceeded allowed quantity")
            End If

        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtPONo.Text <> txtPONoUpdate.Text Then
            If checkPONO() = True Then
                MsgBox("PO No. already used!.", 48, "Enter PO No.")
                txtPONo.Focus()
                Exit Sub
            End If
        End If

        If txtInvoiceNo.Text <> txtInvoiceUpdate.Text Then
            If checkInvoiceNo() = True Then
                MsgBox("Invoice no. already used!.", 48, "Enter Invoice No.")
                txtInvoiceNo.Focus()
                Exit Sub
            End If
        End If

        With dgvItem

            If .RowCount = 0 Then
                MsgBox("No item(s) found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()

            If txtWarehouseCode.Text <> Nothing Then
                If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
                    Dim asave As Boolean = True

                    For i = 0 To .Rows.Count - 1
                        If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            asave = False
                        End If
                    Next

                    If asave = True Then
                        .EndEdit(True)
                        UpdateSalesInvoice()

                        iClear()
                        Me.Dispose()

                        With frmSalesInvoiceH
                            '.LoadSalesHeader()
                            .LoadSalesHeaderNew()
                        End With
                    Else
                        MsgBox("Please input a valid quantity,item/s first", 48, "Invalid quantity,item/s found")
                    End If

                End If
            Else
                MsgBox("Please select supplier and warehouse first!", 48, "Select First")
            End If

        End With
    End Sub

    Sub UpdateSalesInvoice()

        'NEW PROCESS UPDATE IVH => COCOY
        Dim cmd As MySqlCommand
        Dim i As Integer

        'END UPDATE IVH

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0
        Dim whsecode As String = Nothing

        whsecode = txtWarehouseCode.Text.Trim
        With dgvItem 'sa pagdugang ni

            curqty = 0
            nwqty = 0

            'update remove item
            Dim mkerr As Integer = 0
            Dim mkmsg As String = Nothing
            For i = 0 To .RowCount - 1
                If .Item(3, i).Value <> Nothing Then 'qty <> nothing
                    If .Item(3, i).Value > 0 Then 'qty > 0
                        Dim fnd1 As Boolean = False
                        Dim itmc As String = Nothing
                        Dim pkn As String = Nothing
                        Dim oqty As String = Nothing
                        Dim opck As String = Nothing
                        Dim newwqty As String = Nothing


                        itmc = .Item(1, i).Value
                        pkn = .Item(8, i).Value
                        newwqty = .Item(3, i).Value

                        Dim unt As String = 0
                        Dim nwq As Decimal = 0
                        Dim qtyfromwhs As Decimal = 0
                        qtyfromwhs = getcurqty(itmc, txtWarehouseCode.Text, "G")
                        unt = .Item(4, i).Value
                        nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                        oqty = getoldqtyfrmtable(itmc, pkn, "ivd")

                        Dim old_item_unit As String = Nothing
                        old_item_unit = getolditemunit(itmc, pkn, "ivd")
                        Dim old_item_qty As Decimal = 0
                        old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)

                        oqty = old_item_qty

                        nwq = nwq - oqty
                        'End If
                        If nwq > qtyfromwhs Then
                            mkerr = 1
                            If mkmsg = Nothing Then
                                mkmsg = itmc & " exceeded quantity"
                            Else
                                mkmsg = mkmsg & " " & vbNewLine & itmc & " exceeded quantity"
                            End If
                        End If

                    End If
                End If
            Next

            If mkerr = 0 Then

                cmd = New MySqlCommand("UPDATE salesh SET ttype=@ttype,tdate=@tdate,custcode=@custcode, " & _
                              "slmncode=@slmncode,whscode=@whscode,invoiceno=@invoiceno,pono=@pono,grosstot=@grosstot, " & _
                              "disc1percent=@disc1percent,disc1amount=@disc1amount,disc2percent=@disc2percent,disc2amount=@disc2amount, " & _
                              "remarks=@remarks,totalamt=@totalamt,applied=@applied,user=@user,terms=@terms,disc1net=@disc1net,disc2net=@disc2net,pdate=@pdate WHERE transno=@transno", cdb)
                With cmd
                    cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
                    cmd.Parameters.AddWithValue("@ttype", ttype)
                    cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
                    cmd.Parameters.AddWithValue("@custcode", txtCustCode.Text)
                    cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
                    cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
                    cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
                    cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
                    cmd.Parameters.AddWithValue("@grosstot", Decimal.Parse(txtGrossAmount.Text))
                    cmd.Parameters.AddWithValue("@disc1percent", NuPD1.Value)
                    cmd.Parameters.AddWithValue("@disc1amount", Decimal.Parse(txtDisc1.Text))
                    cmd.Parameters.AddWithValue("@disc2percent", NuPD2.Value)
                    cmd.Parameters.AddWithValue("@disc2amount", Decimal.Parse(txtDisc2.Text))
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    cmd.Parameters.AddWithValue("@totalamt", Decimal.Parse(txtNetAmount.Text))
                    If cbTerms.Text.Trim = "COD" Then
                        cmd.Parameters.AddWithValue("@applied", Decimal.Parse(txtNetAmount.Text))
                        cmd.Parameters.AddWithValue("@pdate", Date.Today)
                    Else
                        cmd.Parameters.AddWithValue("@applied", 0)
                        cmd.Parameters.AddWithValue("@pdate", DBNull.Value)
                    End If
                    'cmd.Parameters.AddWithValue("@balance", Decimal.Parse(txtBalance.Text))
                    cmd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmd.Parameters.AddWithValue("@terms", cbTerms.Text)
                    cmd.Parameters.AddWithValue("@disc1net", Decimal.Parse(txtDisc1Net.Text))
                    cmd.Parameters.AddWithValue("@disc2net", Decimal.Parse(txtDisc2Net.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End With


                For x As Integer = 0 To rwrmv - 1
                    Dim rmvitc As String = Nothing
                    Dim rmvqty As Decimal = 0
                    Dim rmvpkno As String = Nothing
                    Dim rmvunit As String = Nothing
                    Dim rmvpckg As Decimal = 0
                    Dim rmvwhse As String = Nothing

                    rmvitc = listrmv(x).c1item
                    rmvqty = listrmv(x).c1qty
                    rmvpkno = listrmv(x).c1pkno
                    rmvunit = listrmv(x).c1unit
                    rmvpckg = listrmv(x).c1pckg
                    rmvwhse = listrmv(x).c1whs

                    ' delstat = 1
                    ' cmd = New MySqlCommand("UPDATE salesd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc", cdb)
                    cmd = New MySqlCommand("UPDATE salesd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc AND pkno=@pno", cdb) 'toping coy
                    cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
                    cmd.Parameters.AddWithValue("@itemc", rmvitc)
                    cmd.Parameters.AddWithValue("@pno", rmvpkno) 'toping coy
                    cmd.ExecuteNonQuery()

                    curqty = getcurqty(rmvitc, rmvwhse, "G")

                    'Dim totalqty As Integer = 0

                    'totalqty = convertpackaging_fromivitem(rmvitc, Nothing, rmvqty, rmvunit)
                    nwqty = curqty + rmvqty

                    cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@itm", rmvitc)
                    cmd.Parameters.AddWithValue("@wh", rmvwhse)
                    cmd.Parameters.AddWithValue("@qtyg", nwqty)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Next

                'reset_listrmv()
                'reset_listupd()
                Dim whsecode2 As String = Nothing
                whsecode2 = txtWarehouseCode.Text
                For i = 0 To .RowCount - 1
                    If .Item(3, i).Value <> Nothing Then 'qty <> nothing
                        If .Item(3, i).Value > 0 Then 'qty > 0
                            Dim fnd1 As Boolean = False
                            Dim itmc As String = Nothing
                            Dim pkn As String = Nothing
                            Dim oqty As String = Nothing
                            Dim opck As String = Nothing
                            Dim newwqty As String = Nothing
                            Dim my_operator As String = "+"
                            Dim old_item_qty As Decimal = 0

                            itmc = .Item(1, i).Value
                            pkn = .Item(8, i).Value
                            newwqty = .Item(3, i).Value

                            'cmd = New MySqlCommand("SELECT item FROM salesd WHERE pkno=@pno and transno=@tno", cdb)
                            cmd = New MySqlCommand("SELECT itemcode FROM salesd WHERE pkno=@pno and transno=@tno and itemcode=@itm", cdb)
                            cmd.Parameters.AddWithValue("@tno", txtTransNo.Text.Trim)
                            cmd.Parameters.AddWithValue("@pno", pkn)
                            cmd.Parameters.AddWithValue("@itm", itmc)
                            Using rd As MySqlDataReader = cmd.ExecuteReader
                                If rd.HasRows Then
                                    fnd1 = True
                                End If
                            End Using
                            cmd.Dispose()

                            Dim unt As String = 0
                            Dim nwq As Decimal = 0
                            Dim qtyfromwhs As Decimal = 0
                            qtyfromwhs = getcurqty(itmc, whsecode, "G")

                            Dim new_item_unit As String = Nothing
                            Dim old_item_unit As String = Nothing
                            old_item_unit = getolditemunit(itmc, pkn, "salesd")

                            unt = .Item(4, i).Value
                            nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)

                            Dim markunitchange As Integer = 0

                            Dim pvwhs As String = Nothing
                           
                            
                            oqty = getoldqtyfrmtable(itmc, pkn, "salesd")
                            Dim added_status As Integer = 0
                            If .Item(1, i).Tag = "A" Then
                                added_status = 1
                            End If

                            If prevwhs <> whsecode Then 'Change warehouse

                                Dim opr As String = Nothing
                                opr = "+"
                                pvwhs = prevwhs
                                Dim nwqtytoprev As Decimal = 0
                                Dim oldqtyfromprvwhs As Decimal = 0
                                Dim qtyreturntoprvwhs As Decimal = 0

                                'change quantity or unit
                                oldqtyfromprvwhs = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                nwqtytoprev = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)


                                If oldqtyfromprvwhs <> nwqtytoprev Then
                                    If added_status = 0 Then
                                        updateprevwhs(itmc, oldqtyfromprvwhs, nwq, opr, prevwhs, "G")
                                    End If
                                Else
                                    updateprevwhs(itmc, nwqtytoprev, nwq, opr, prevwhs, "G")
                                End If



                                oqty = newwqty
                                old_item_unit = unt
                            ElseIf old_item_unit <> Nothing Then

                                If old_item_unit <> unt Then
                                    ' old_item_qty = getolditem_qty(itmc, pkn)
                                    Dim new_item_qty As Decimal = 0
                                    markunitchange = 1

                                    ' old_item_qty = getoldqtyfrmtable(itmc, pkn, "ivd")
                                    new_item_qty = old_item_qty
                                    old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    return_diff_to_whs(itmc, old_item_qty, whsecode, "+")
                                    'End If
                                    oqty = new_item_qty

                                End If
                            End If


                            If nwq = old_item_qty Then 'if no changes on quantity

                            ElseIf nwq > qtyfromwhs Then
                                mkerr = 1
                                If mkmsg = Nothing Then
                                    mkmsg = itmc & " exceeded quantity"
                                Else
                                    mkmsg = mkmsg & " " & vbNewLine & itmc & " exceeded quantity"
                                End If
                            End If

                            If fnd1 = True Then

                                cmd = New MySqlCommand("UPDATE salesd SET ttype=@ttype,tdate=@tdate, " & _
                                                       "pricetype=@pricetype,whscode=@whscode, " & _
                                                       "invoiceno=@invoiceno,pono=@pono,itemcode=@item,qty=@qty,qunit=@unit,pckg=@pckg, " & _
                                                       "uprice=@uprice,amount=@amount WHERE transno=@transno and pkno=@pkno", cdb)
                                cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
                                cmd.Parameters.AddWithValue("@ttype", ttype)
                                cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
                                cmd.Parameters.AddWithValue("@pricetype", txtPriceType.Text)
                                cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
                                cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
                                cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
                                cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@qty", Decimal.Parse(newwqty)) ' .Item(3, i).Value)
                                cmd.Parameters.AddWithValue("@unit", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                                cmd.Parameters.AddWithValue("@uprice", Decimal.Parse(.Item(6, i).Value))
                                cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                                cmd.Parameters.AddWithValue("@pkno", .Item(8, i).Value)
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()

                                If markunitchange = 1 Then
                                  
                                    'oqty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)


                                    update_currentwhs_1stockout(itmc, oqty, nwq, prevwhs, whsecode, whsecode2, my_operator)
                                Else
                                   
                                    Dim updatedqty As Decimal = 0

                                    updatedqty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    update_currentwhs_1stockout(itmc, updatedqty, nwq, prevwhs, whsecode, whsecode2, my_operator)

                                    ' old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
                                    ' update_currentwhs22(itmc, old_item_qty, nwq, whsecode2, whsecode, pvwhs, my_operator)
                                End If
                            Else
                                cmd = New MySqlCommand("INSERT INTO salesd (transno,ttype,tdate,pricetype,whscode,invoiceno, " & _
                                                 "pono,itemcode,qty,qunit,pckg,uprice,amount) VALUES (@transno,@ttype,@tdate,@pricetype, " & _
                                                 "@whscode,@invoiceno,@pono,@item,@qty,@unit,@pckg,@uprice,@amount)", cdb)
                                cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
                                cmd.Parameters.AddWithValue("@ttype", ttype)
                                cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
                                cmd.Parameters.AddWithValue("@pricetype", txtPriceType.Text)
                                cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
                                cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
                                cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
                                cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
                                cmd.Parameters.AddWithValue("@qty", Decimal.Parse(.Item(3, i).Value)) '.Item(3, i).Value)
                                cmd.Parameters.AddWithValue("@unit", .Item(4, i).Value)
                                cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
                                cmd.Parameters.AddWithValue("@uprice", Decimal.Parse(.Item(6, i).Value))
                                cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
                                cmd.ExecuteNonQuery()
                                cmd.Dispose()
                                nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
                                '  old_item_qty = getcurqty(itmc, whsecode, "G")
                                my_operator = "-"
                                update_currentwhs1(itmc, old_item_qty, nwq, whsecode2, whsecode, nwq, my_operator)
                                'update_currentwhs2(itmc, oqty, newwqty, whsecode2, nwq)
                            End If
                        End If
                    End If
                Next
                MsgBox("Sales invoice has been updated successfully.", vbInformation)
            Else
                MsgBox(mkmsg, 48, " Exceeded allowed quantity")
            End If

            reset_listrmv()
            reset_listupd()
            reset_listadded()
            prevwhs = whsecode
            editeditem = 0
        End With
        'END NEW PROCESS



        'Richel Update
        'NEW PROCESS UPDATE IVH => COCOY
        'Dim cmd As MySqlCommand
        'Dim i As Integer

        ''END UPDATE IVH

        'Dim curqty As Decimal = 0
        'Dim nwqty As Decimal = 0
        'Dim whsecode As String = Nothing

        'whsecode = txtWarehouseCode.Text.Trim
        '' MsgBox(prevwhse)
        ''update edited item

        'With dgvItem 'sa pagdugang ni

        '    curqty = 0
        '    nwqty = 0
        '    Dim mkerr As Integer = 0
        '    Dim mkmsg As String = Nothing

        '    'CHECK IF ITEM exceeded the warehouse quantity
        '    For i = 0 To .RowCount - 1
        '        If .Item(3, i).Value <> Nothing Then 'qty <> nothing
        '            If .Item(3, i).Value > 0 Then 'qty > 0
        '                Dim fnd1 As Boolean = False
        '                Dim itmc As String = Nothing
        '                Dim pkn As String = Nothing
        '                Dim oqty As String = Nothing
        '                Dim opck As String = Nothing
        '                Dim newwqty As String = Nothing


        '                itmc = .Item(1, i).Value
        '                pkn = .Item(8, i).Value
        '                newwqty = .Item(3, i).Value

        '                Dim unt As String = 0
        '                Dim nwq As Decimal = 0
        '                Dim qtyfromwhs As Decimal = 0
        '                qtyfromwhs = getcurqty(itmc, whsecode, "G")
        '                unt = .Item(4, i).Value
        '                nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt) '150
        '                oqty = getoldqtyfrmtable(itmc, pkn, "salesd") 'para ni sa convertpackaging

        '                Dim old_item_unit As String = Nothing 'unit
        '                old_item_unit = getolditemunit(itmc, pkn, "salesd")
        '                Dim old_item_qty As Decimal = 0
        '                old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit) '300




        '                '  oqty = old_item_qty
        '                ' nwq = nwq - oqty
        '                ' End If

        '                If nwq = old_item_qty Then 'if no changes on quantity

        '                ElseIf nwq > qtyfromwhs Then
        '                    mkerr = 1
        '                    If mkmsg = Nothing Then
        '                        mkmsg = itmc & " exceeded quantity"
        '                    Else
        '                        mkmsg = mkmsg & " " & vbNewLine & itmc & " exceeded quantity"
        '                    End If
        '                End If

        '            End If
        '        End If
        '    Next

        '    'update remove item
        '    If mkerr = 0 Then

        '        cmd = New MySqlCommand("UPDATE salesh SET ttype=@ttype,tdate=@tdate,custcode=@custcode, " & _
        '                      "slmncode=@slmncode,whscode=@whscode,invoiceno=@invoiceno,pono=@pono,grosstot=@grosstot, " & _
        '                      "disc1percent=@disc1percent,disc1amount=@disc1amount,disc2percent=@disc2percent,disc2amount=@disc2amount, " & _
        '                      "remarks=@remarks,totalamt=@totalamt,applied=@applied,user=@user,terms=@terms,disc1net=@disc1net,disc2net=@disc2net,pdate=@pdate WHERE transno=@transno", cdb)
        '        With cmd
        '            cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
        '            cmd.Parameters.AddWithValue("@ttype", ttype)
        '            cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
        '            cmd.Parameters.AddWithValue("@custcode", txtCustCode.Text)
        '            cmd.Parameters.AddWithValue("@slmncode", txtSalesmanCode.Text)
        '            cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
        '            cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
        '            cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
        '            cmd.Parameters.AddWithValue("@grosstot", Decimal.Parse(txtGrossAmount.Text))
        '            cmd.Parameters.AddWithValue("@disc1percent", NuPD1.Value)
        '            cmd.Parameters.AddWithValue("@disc1amount", Decimal.Parse(txtDisc1.Text))
        '            cmd.Parameters.AddWithValue("@disc2percent", NuPD2.Value)
        '            cmd.Parameters.AddWithValue("@disc2amount", Decimal.Parse(txtDisc2.Text))
        '            cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text)
        '            cmd.Parameters.AddWithValue("@totalamt", Decimal.Parse(txtNetAmount.Text))
        '            If cbTerms.Text.Trim = "COD" Then
        '                cmd.Parameters.AddWithValue("@applied", Decimal.Parse(txtNetAmount.Text))
        '                cmd.Parameters.AddWithValue("@pdate", Date.Today)
        '            Else
        '                cmd.Parameters.AddWithValue("@applied", 0)
        '                cmd.Parameters.AddWithValue("@pdate", DBNull.Value)
        '            End If
        '            'cmd.Parameters.AddWithValue("@balance", Decimal.Parse(txtBalance.Text))
        '            cmd.Parameters.AddWithValue("@user", txtUser.Text)
        '            cmd.Parameters.AddWithValue("@terms", cbTerms.Text)
        '            cmd.Parameters.AddWithValue("@disc1net", Decimal.Parse(txtDisc1Net.Text))
        '            cmd.Parameters.AddWithValue("@disc2net", Decimal.Parse(txtDisc2Net.Text))
        '            cmd.ExecuteNonQuery()
        '            cmd.Dispose()
        '        End With

        '        'FOR DELETION
        '        For x As Integer = 0 To rwrmv - 1
        '            Dim rmvitc As String = Nothing
        '            Dim rmvqty As Decimal = 0
        '            Dim rmvpkno As String = Nothing
        '            Dim rmvunit As String = Nothing
        '            Dim rmvpckg As Decimal = 0

        '            rmvitc = listrmv(x).c1item
        '            rmvqty = listrmv(x).c1qty
        '            rmvpkno = listrmv(x).c1pkno
        '            rmvunit = listrmv(x).c1unit
        '            rmvpckg = listrmv(x).c1pckg

        '            ' delstat = 1
        '            ' cmd = New MySqlCommand("UPDATE salesd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc", cdb)
        '            cmd = New MySqlCommand("UPDATE salesd SET isdeleted='1' WHERE transno=@tno AND itemcode=@itemc AND pkno=@pno", cdb) 'toping coy
        '            cmd.Parameters.AddWithValue("@tno", txtTransNo.Text)
        '            cmd.Parameters.AddWithValue("@itemc", rmvitc)
        '            cmd.Parameters.AddWithValue("@pno", rmvpkno) 'toping coy
        '            cmd.ExecuteNonQuery()

        '            curqty = getcurqty(rmvitc, whsecode, "G")

        '            Dim totalqty As Decimal = 0

        '            totalqty = convertpackaging_fromivitem(rmvitc, Nothing, rmvqty, rmvunit)
        '            'If nwqty < curqty Then
        '            '    nwqty = curqty - totalqty
        '            'ElseIf nwqty > curqty Then
        '            '    nwqty = curqty + totalqty
        '            'End If
        '            nwqty = curqty + totalqty

        '            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
        '            cmd.Parameters.AddWithValue("@itm", rmvitc)
        '            cmd.Parameters.AddWithValue("@wh", whsecode)
        '            cmd.Parameters.AddWithValue("@qtyg", nwqty)
        '            cmd.ExecuteNonQuery()
        '            cmd.Dispose()

        '        Next

        '        'reset_listrmv()
        '        .Refresh()
        '        For i = 0 To .RowCount - 1
        '            If .Item(3, i).Value <> Nothing Then 'qty <> nothing
        '                If .Item(3, i).Value > 0 Then 'qty > 0
        '                    Dim fnd1 As Boolean = False
        '                    Dim itmc As String = Nothing
        '                    Dim pkn As String = Nothing
        '                    Dim oqty As String = Nothing
        '                    Dim opck As String = Nothing
        '                    Dim newwqty As String = Nothing
        '                    Dim my_operator As String = "+"
        '                    Dim old_item_qty As Decimal = 0


        '                    itmc = .Item(1, i).Value
        '                    pkn = .Item(8, i).Value
        '                    newwqty = .Item(3, i).Value

        '                    'cmd = New MySqlCommand("SELECT item FROM salesd WHERE pkno=@pno and transno=@tno", cdb)
        '                    cmd = New MySqlCommand("SELECT itemcode FROM salesd WHERE pkno=@pno and transno=@tno", cdb)
        '                    cmd.Parameters.AddWithValue("@tno", txtTransNo.Text.Trim)
        '                    cmd.Parameters.AddWithValue("@pno", .Item(8, i).Value)
        '                    Using rd As MySqlDataReader = cmd.ExecuteReader
        '                        If rd.HasRows Then
        '                            fnd1 = True
        '                        End If
        '                    End Using
        '                    cmd.Dispose()

        '                    Dim unt As String = 0
        '                    Dim nwq As Decimal = 0
        '                    Dim qtyfromwhs As Decimal = 0
        '                    qtyfromwhs = getcurqty(itmc, whsecode, "G")

        '                    Dim new_item_unit As String = Nothing
        '                    Dim old_item_unit As String = Nothing
        '                    old_item_unit = getolditemunit(itmc, pkn, "salesd")

        '                    unt = .Item(4, i).Value
        '                    nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)


        '                    '   old_item_unit = getolditemunit(old_item, pkn)

        '                    Dim markunitchange As Integer = 0


        '                    'UPDATE SALESD HERE

        '                    Dim pvwhs As String = Nothing
        '                    Dim prevwhs As String = Nothing
        '                    Dim whsecode2 As String = Nothing
        '                    oqty = getoldqtyfrmtable(itmc, pkn, "salesd")

        '                    If old_item_unit <> unt Then
        '                        ' old_item_qty = getolditem_qty(itmc, pkn)
        '                        Dim new_item_qty As Decimal = 0
        '                        markunitchange = 1

        '                        ' old_item_qty = getoldqtyfrmtable(itmc, pkn, "ivd")
        '                        new_item_qty = old_item_qty
        '                        old_item_qty = convertpackaging_fromivitem(itmc, pkn, oqty, old_item_unit)
        '                        return_diff_to_whs(itmc, old_item_qty, whsecode, "-")
        '                        'End If
        '                        oqty = new_item_qty

        '                    End If

        '                    If fnd1 = True Then
        '                        '=============for ADDING AND SUBTRACTING qty good in warehouse===== 3-30-2022
        '                        Dim oqty_with_minus As Decimal 'RICHEL added
        '                        Dim oldqtyrich As Decimal = Nothing
        '                        oldqtyrich = getoldqtyfrmtable(itmc, pkn, "salesd") 'para ni sa convertpackaging

        '                        If oldqtyrich = newwqty Then
        '                            oqty_with_minus = newwqty
        '                        ElseIf oldqtyrich < newwqty Then
        '                            oqty_with_minus = newwqty - oldqtyrich
        '                        Else
        '                            oqty_with_minus = oldqtyrich - newwqty
        '                        End If
        '                        '===============================================================


        '                        'UPDATE SALESD HERE

        '                        cmd = New MySqlCommand("UPDATE salesd SET ttype=@ttype,tdate=@tdate, " & _
        '                                               "pricetype=@pricetype,whscode=@whscode, " & _
        '                                               "invoiceno=@invoiceno,pono=@pono,itemcode=@item,qty=@qty,qunit=@unit,pckg=@pckg, " & _
        '                                               "uprice=@uprice,amount=@amount WHERE transno=@transno and pkno=@pkno", cdb)
        '                        cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
        '                        cmd.Parameters.AddWithValue("@ttype", ttype)
        '                        cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
        '                        cmd.Parameters.AddWithValue("@pricetype", txtPriceType.Text)
        '                        cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
        '                        cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
        '                        cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
        '                        cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
        '                        cmd.Parameters.AddWithValue("@qty", Decimal.Parse(newwqty)) ' .Item(3, i).Value)
        '                        cmd.Parameters.AddWithValue("@unit", .Item(4, i).Value)
        '                        cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
        '                        cmd.Parameters.AddWithValue("@uprice", Decimal.Parse(.Item(6, i).Value))
        '                        cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
        '                        cmd.Parameters.AddWithValue("@pkno", .Item(8, i).Value)
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()
        '                        If markunitchange = 1 Then
        '                            my_operator = Nothing
        '                            update_currentwhs_1and2(itmc, oqty, nwq, prevwhs, whsecode, whsecode2, my_operator)
        '                        Else
        '                            Dim qty_old_for_warehouse As Decimal
        '                            nwq = convertpackaging_fromivitem(itmc, pkn, oqty_with_minus, unt)
        '                            qty_old_for_warehouse = convertpackaging_fromivitem(itmc, pkn, oldqtyrich, old_item_unit) '300
        '                            'If oldqty > newqty Then
        '                            '    ' Example from 1 to 5

        '                            'Else oldqty < newqty
        '                            '    'Exmple from 5 to 1
        '                            '    'dapat 4 ra ang ma add
        '                            'End If
        '                            update_currentwhs22RICHEL(itmc, oqty, nwq, whsecode2, whsecode, pvwhs, my_operator, qty_old_for_warehouse)
        '                        End If

        '                    Else
        '                        cmd = New MySqlCommand("INSERT INTO salesd (transno,ttype,tdate,pricetype,whscode,invoiceno, " & _
        '                                         "pono,itemcode,qty,qunit,pckg,uprice,amount) VALUES (@transno,@ttype,@tdate,@pricetype, " & _
        '                                         "@whscode,@invoiceno,@pono,@item,@qty,@unit,@pckg,@uprice,@amount)", cdb)
        '                        cmd.Parameters.AddWithValue("@transno", txtTransNo.Text)
        '                        cmd.Parameters.AddWithValue("@ttype", ttype)
        '                        cmd.Parameters.AddWithValue("@tdate", dtpInvoiceDate.Value)
        '                        cmd.Parameters.AddWithValue("@pricetype", txtPriceType.Text)
        '                        cmd.Parameters.AddWithValue("@whscode", txtWarehouseCode.Text)
        '                        cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text)
        '                        cmd.Parameters.AddWithValue("@pono", txtPONo.Text)
        '                        cmd.Parameters.AddWithValue("@item", .Item(1, i).Value)
        '                        cmd.Parameters.AddWithValue("@qty", Decimal.Parse(.Item(3, i).Value)) '.Item(3, i).Value)
        '                        cmd.Parameters.AddWithValue("@unit", .Item(4, i).Value)
        '                        cmd.Parameters.AddWithValue("@pckg", .Item(5, i).Value)
        '                        cmd.Parameters.AddWithValue("@uprice", Decimal.Parse(.Item(6, i).Value))
        '                        cmd.Parameters.AddWithValue("@amount", Decimal.Parse(.Item(7, i).Value))
        '                        cmd.ExecuteNonQuery()
        '                        cmd.Dispose()
        '                        nwq = convertpackaging_fromivitem(itmc, pkn, newwqty, unt)
        '                        old_item_qty = getcurqty(itmc, whsecode, "G")
        '                        update_currentwhs1(itmc, old_item_qty, nwq, whsecode2, whsecode, nwq, my_operator)
        '                        'update_currentwhs2(itmc, oqty, newwqty, whsecode2, nwq)
        '                    End If
        '                End If
        '            End If

        '        Next
        '        MsgBox("Invoice has been updated successfully.", vbInformation)
        '    Else
        '        MsgBox(mkmsg, 48, " Exceeded allowed quantity")
        '    End If
        '    ' If rwrmv < 1 Then 'meaning 0 ===>>>>>>>>RICHEL

        '    '  Else


        'End With


        ''update to ivwh
        'With dgvItem

        '    ' Dim cmd2 As MySqlCommand
        '    Dim presentitem As String = Nothing
        '    Dim previtem As String = Nothing

        '    For i = 0 To .RowCount - 1
        '        If .Item(3, i).Value <> Nothing Then 'qty <> nothing
        '            If .Item(3, i).Value > 0 Then 'qty > 0
        '            End If
        '        End If
        '    Next
        '    reset_listrmv()
        '    reset_listupd()
        '    reset_listadded()
        '    prevwhse = whsecode
        '    editeditem = 0
        'End With
        ''END NEW PROCESS

    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("Invoice Number is required", vbCritical)
            Exit Sub
        End If

        If checkInvoiceNo() = True Then
            MsgBox("Invoice No. already used!.", 48, "Enter Invoice No.")
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        If checkPONO() = True Then
            MsgBox("PO No. already Used!.", 48, "Enter PO No.")
            txtPONo.Focus()
            Exit Sub
        End If

        With dgvItem
            If .RowCount = 0 Then
                MsgBox("No items found!", vbExclamation)
                Return
            End If

            DeleteBlankRow()
            If .RowCount > 0 Then
                Dim asave As Boolean = True
                For i = 0 To .Rows.Count - 1
                    'If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                    If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                        asave = False
                    End If
                Next

                If asave = True Then
                    GetTransNo()
                    SaveSalesInvoice()
                    MsgBox("Sales invoice has save successfully", vbInformation)
                    PrintSalesInvoice()
                    iClear()
                    'With frmReport
                    '    .BringToFront()
                    'End With

                    ' Me.txtCustCode.Focus()
                    With frmSalesInvoiceH
                        .LoadSalesHeaderNew()
                    End With

                    MDIParent1.SendToBack()
                    frmReport.BringToFront()
                Else
                    MsgBox("Please input a valid item/s first", 48, "Invalid item/s found")
                End If
            Else
                MsgBox("Please add item/s first before saving", 48, "No item/s found")
            End If
        End With

    End Sub

    Sub PrintSalesInvoice()
        Dim mmax As Integer = 0
        Dim grpno As Integer = 1
        pbar1.Visible = True
        pbar1.Value = 0

        With dgvItem
            mmax = .RowCount
            pbar1.Maximum = mmax

            dtSalesInvoice.Rows.Clear()
            Dim chkflag As Boolean = False
            'grpno = 10
            grpno = 25
            Dim cntr As Integer = 0
            Dim grid As Integer = 1

            If .RowCount > 0 Then
                'pbar1.Visible = True
                'pbar1.Maximum = .RowCount
                'pbar1.Value = 0
                .EndEdit()
                '=====

                Dim prep As New ReportDocument
                Dim ds As New DataSet1
                Dim dtSalesInvoice As DataTable = ds.Tables("dtSalesInvoice")
                Dim r1 As DataRow
                'Dim grpno As Integer = 1
                dtSalesInvoice.Rows.Clear()
                'Dim chkflag As Boolean = False
                'grpno = 10
                grpno = 25
                'Dim cntr As Integer = 0
                'Dim grid As Integer = 1
                '=====

                For i = 0 To .RowCount - 1
                    'pbar1.Value += 1
                    'pbar1.Refresh()
                    ' r1 = dt.NewRow()
                    pbar1.Value += 1
                    cntr += 1
                    r1 = dtSalesInvoice.NewRow()

                    r1("rtitle") = "SALES INVOICE"
                    r1("dtitle") = "Invoice No."
                    r1("transno") = txtTransNo.Text.ToString
                    r1("date") = dtpInvoiceDate.Value.ToString("MM/dd/yyyy")
                    r1("custcode") = txtCustCode.Text.ToString
                    r1("customername") = txtCustomername.Text.ToString
                    r1("address") = txtAddress.Text.ToString
                    r1("salesmancode") = txtSalesmanCode.Text.ToString
                    r1("salesmanname") = txtSalesmanName.Text.ToString
                    r1("pricetype") = txtPriceType.Text.ToString
                    r1("warehousecode") = txtWarehouseCode.Text.ToString
                    r1("warehousename") = txtWarehouseName.Text.ToString
                    r1("pono") = txtPONo.Text.ToString
                    r1("invoiceno") = txtInvoiceNo.Text.ToString
                    r1("itemcode") = IIf(.Item(1, i).Value = Nothing, DBNull.Value, .Item(1, i).Value)
                    r1("description") = IIf(.Item(2, i).Value = Nothing, DBNull.Value, .Item(2, i).Value)
                    r1("qty") = IIf(.Item(3, i).Value = Nothing, DBNull.Value, .Item(3, i).Value)
                    r1("unit") = IIf(.Item(4, i).Value = Nothing, DBNull.Value, .Item(4, i).Value)
                    r1("pckg") = IIf(.Item(5, i).Value = Nothing, DBNull.Value, .Item(5, i).Value)
                    r1("unitprice") = IIf(.Item(6, i).Value = Nothing, DBNull.Value, .Item(6, i).Value)
                    r1("amount") = IIf(.Item(7, i).Value = Nothing, DBNull.Value, .Item(7, i).Value)
                    r1("grossamount") = txtGrossAmount.Text.ToString
                    r1("disc1") = txtDisc1.Text.ToString
                    r1("disc2") = txtDisc2.Text.ToString
                    r1("nud1") = NuPD1.Value.ToString
                    r1("nud2") = NuPD2.Value.ToString
                    r1("netamount") = txtNetAmount.Text.ToString
                    r1("remarks") = txtRemarks.Text.ToString
                    r1("terms") = cbTerms.Text.ToString
                    r1("totqtycase") = lblCase.Text.ToString
                    r1("totqtybag") = lblBag.Text.ToString
                    r1("totqtypc") = lblPc.Text.ToString
                    r1("grpno") = grid

                    pbar1.Refresh()
                    dtSalesInvoice.Rows.Add(r1)
                    ' dt.Rows.Add(r1)
                    ' pbar1.Refresh()
                    If cntr = grpno Then
                        grid += 1
                        cntr = 0
                    End If
                Next

                'pbar1.Visible = False
                prep = New rptSalesInvoice
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

    Private Sub btnUpdatePrint_Click(sender As Object, e As EventArgs) Handles btnUpdatePrint.Click

        If txtPONo.Text <> txtPONoUpdate.Text Then
            If checkPONO() = True Then
                MsgBox("PO No. already used!.", 48, "Enter PO No.")
                txtPONo.Focus()
                Exit Sub
            End If
        End If

        If txtInvoiceNo.Text <> txtInvoiceUpdate.Text Then
            If checkInvoiceNo() = True Then
                MsgBox("Invoice no. already used!.", 48, "Enter Invoice No.")
                txtInvoiceNo.Focus()
                Exit Sub
            End If
        End If

        With dgvItem

            If .RowCount = 0 Then
                MsgBox("No item(s) found!", vbExclamation)
                Exit Sub
            End If

            DeleteBlankRow()

            If txtWarehouseCode.Text <> Nothing Then
                If MsgBox("Update Changes?", vbYesNo + vbQuestion) = vbYes Then
                    Dim asave As Boolean = True

                    For i = 0 To .Rows.Count - 1
                        If .Item(3, i).Value = Nothing Or .Item(7, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            'If .Item(3, i).Value = Nothing Or .Item(3, i).Value = 0 Then
                            asave = False
                        End If
                    Next

                    If asave = True Then
                        .EndEdit(True)
                        UpdateSalesInvoice()

                        PrintSalesInvoice()
                        ' iClear()
                        ' Me.Close()
                        frmReport.BringToFront()
                        With frmSalesInvoiceH
                            .LoadSalesHeaderNew()
                            '.SendToBack()
                        End With

                        '.LoadSalesHeader()
                    Else
                        MsgBox("Please input a valid quantity,item/s first", 48, "Invalid quantity,item/s found")
                    End If

                End If
            Else
                MsgBox("Please select supplier and warehouse first!", 48, "Select First")
            End If

        End With

    End Sub

    Private Sub dgvItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellContentClick
        Dim colName As String = dgvItem.Columns(e.ColumnIndex).Name
        If colName = "colDelete" Then
            If MsgBox("Delete this Item? Click Yes to Confirm", vbYesNo + vbExclamation) = vbYes Then

                ReDim Preserve listrmv(rwrmv)
                With listrmv(rwrmv)
            

                    .c1item = dgvItem.Item(1, dgvItem.CurrentRow.Index).Value
                    .c1qty = dgvItem.Item(5, dgvItem.CurrentRow.Index).Tag
                    .c1pckg = dgvItem.Item(5, dgvItem.CurrentRow.Index).Value
                    .c1unit = dgvItem.Item(4, dgvItem.CurrentRow.Index).Tag
                    '.c1qty = dgvItem.Item(3, dgvItem.CurrentRow.Index).Value
                    .c1pkno = dgvItem.Item(8, dgvItem.CurrentRow.Index).Tag


                End With

                'cmd = New MySqlCommand("UPDATE rcvingd SET isdeleted='1' where transno=@tno AND item =@itemc", cdb)
                'cmd.Parameters.AddWithValue("@tno", tbTransNo.Text.Trim)
                'cmd.Parameters.AddWithValue("@itemc", dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value)
                'cmd.ExecuteNonQuery()
                rwrmv += 1
                dgvItem.Rows.Remove(dgvItem.Rows(dgvItem.CurrentRow.Index))

                ComputeInvoiceTotal()

                'Dim itemunit As String = dgvRcvItem.Rows(e.RowIndex).Cells(4).Value.ToString
                'Dim itemqty As Decimal = Val(dgvRcvItem.Item(3, dgvRcvItem.CurrentRow.Index).Value)
                'Dim itempkcg As Integer = Val(dgvRcvItem.Item(5, dgvRcvItem.CurrentRow.Index).Value)
                'Dim totalqty As Decimal = Nothing

                'Dim r1 As DataGridViewRow
                'r1 = New DataGridViewRow
                'r1.CreateCells(dgforDelete)



                'If itemunit = "C" Or itemunit = "B" Then
                '    totalqty = itemqty * IIf(itempkcg > 0, itempkcg, 1)
                'ElseIf itemunit = "P" Then
                '    totalqty = itemqty
                'End If

                'r1.Cells(1).Value = dgvRcvItem.Item(1, dgvRcvItem.CurrentRow.Index).Value 'Item_code
                'r1.Cells(3).Value = itemqty
                'r1.Cells(4).Value = itemunit
                'r1.Cells(5).Value = itempkcg


                'dgforDelete.Rows.Add(r1)
                ' MsgBox("item has been Deleted!", vbInformation)
            End If

        End If
    End Sub

    Dim selrow As Integer = 0
    Delegate Sub SetColumnIndex(ByVal i As Integer)
    Sub Mymethod(ByVal columnIndex As Integer)
        If Me.dgvItem.CurrentRow.Index >= 0 Then
            If Me.dgvItem.CurrentRow.Index > 0 Then
                Me.dgvItem.CurrentCell = Me.dgvItem.Item(columnIndex, selrow)    '.Cells(columnIndex)
                Me.dgvItem.BeginEdit(True)
            Else
                Me.dgvItem.CurrentCell = Me.dgvItem.Item(columnIndex, 0)   '.Cells(columnIndex)
                Me.dgvItem.BeginEdit(True)
            End If
        End If
    End Sub

    Dim editeditem As Integer = 0
    Private Sub dgvItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellEndEdit

        '=== NEW PROCESS === => COCOY
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0
                Dim old_quantity As Decimal = 0
                Dim oldqty As Decimal = 0
                mrw = e.RowIndex
                ' act = .Item(7, mrw).Value
                If e.ColumnIndex = 1 Then
                    Dim itemno As String = Nothing

                    itemno = .Item(1, mrw).Value

                    If itemno <> Nothing And itemno <> " " Then
                        .Item(1, mrw).Value = UCase(itemno)
                        itemno = .Item(1, mrw).Value


                        If getitem_byid(itemno, mrw) Then
                            If checkitemno_update(itemno, mrw) = True Then
                                MsgBox("Item already on the list!", 64, "Item added")
                            End If
                            '.CurrentCell = .Item(3, mrw)
                            '.BeginEdit(True)
                            'ComputeRcvTotal()
                            .ClearSelection()
                            'If .Item(1, mrw).Value <> .Item(13, mrw).Value Then
                            If .Item(1, mrw).Value <> .Item(9, mrw).Value Then 'PREV ITEM
                                'addrwindex = mrw
                                'ReDim Preserve listrowsadded(rwsnews)
                                'With listrowsadded(rwsnews)
                                '    .c_myrowindex = addrwindex 'Added new row
                                'End With
                                'rwsnews += 1


                                Dim mpc As String = Nothing
                                itemno = .Item(1, mrw).Value
                                mpc = .Item(4, mrw).Value

                                If txtPriceType.Text <> Nothing Then
                                    getpackprice(itemno, mpc, mrw, txtPriceType.Text)
                                Else
                                    getpackprice(itemno, mpc, mrw, "A")
                                End If

                                Dim nwtotalqty As Decimal = 0
                                ReDim Preserve listrmv(rwrmv)
                                With listrmv(rwrmv)
                                    .c1item = dgvItem.Item(9, mrw).Value 'PREV ITEM
                                    .c1unit = dgvItem.Item(4, mrw).Tag
                                    .c1pckg = dgvItem.Item(5, mrw).Value
                                    nwtotalqty = dgvItem.Item(5, mrw).Tag
                                    .c1qty = nwtotalqty
                                    .c1pkno = dgvItem.Item(8, mrw).Tag 'PREV PKNO
                                    .c1whs = dgvItem.Item(10, mrw).Value
                                End With

                                rwrmv += 1
                                editeditem = 1

                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then
                                    nwtotalqty = 0
                                    ReDim Preserve listupd(rwupd)
                                   
                                End If

                            End If

                            '  .ClearSelection()
                            selrow = mrw
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 3
                            Me.dgvItem.BeginInvoke(method, nextindex)

                            ' Else
                            ' .BeginEdit(True)
                        End If

                    End If

                ElseIf e.ColumnIndex = 3 Then
                    Dim eAmt As Double = 0
                    eAmt = .Item(7, mrw).Value
                    .Item(7, mrw).Value = eAmt

                    'orig code = .Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "STANDARD")
                    '.Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "#,##0")
                    '.Item(8, mrw).Value = .Item(3, mrw).Value
                    '.Item(9, mrw).Value = Format(.Item(8, mrw).Value * .Item(6, mrw).Value, "STANDARD")
                    If .Item(3, mrw).Value = 0 Then
                        .CurrentCell = .Item(3, mrw)
                        MsgBox("Invalid quantity", 48, "Invalid quantity")
                    Else
                        '.Item(9, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                        '.Item(10, mrw).Value = Format(.Item(3, mrw).Value * .Item(7, mrw).Value, "STANDARD")
                        .Item(7, mrw).Value = Format(.Item(3, mrw).Value * .Item(6, mrw).Value, "STANDARD")

                        old_quantity = .Item(3, mrw).Value
                        If .Item(1, mrw).Value <> Nothing Then
                            .ClearSelection()
                            selrow = mrw
                            Dim method As New SetColumnIndex(AddressOf Mymethod)
                            Dim nextindex As Integer = 4
                            Me.dgvItem.BeginInvoke(method, nextindex)


                            Dim nwtotalqty As Decimal = 0
                            nwtotalqty = dgvItem.Item(3, mrw).Value

                            Dim new_current_qty As Decimal = 0

                            If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                                new_current_qty = nwtotalqty * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                            Else
                                new_current_qty = nwtotalqty
                            End If '

                            'oldqty = dgvItem.Item(5, mrw).Tag
                            Dim oldunit As String = Nothing
                            Dim oldpackg As Decimal = 0

                            nwtotalqty = dgvItem.Item(3, mrw).Value

                            oldqty = getoldqtyfrmtable(.Item(1, mrw).Value, .Item(8, mrw).Value, "salesd") ' dgvItem.Item(5, mrw).Tag
                            oldunit = getolditemunit(.Item(1, mrw).Value, .Item(8, mrw).Value, "salesd")
                            oldpackg = getolditempckg(.Item(1, mrw).Value, .Item(8, mrw).Value, "salesd")

                            Dim n_old_qty As Decimal = 0
                            n_old_qty = oldqty * oldpackg

                            Dim itemno As String = Nothing
                            Dim mpc As String = Nothing
                            itemno = .Item(1, mrw).Value
                            mpc = .Item(4, mrw).Value

                            If txtPriceType.Text <> Nothing Then
                                getpackprice(itemno, mpc, mrw, txtPriceType.Text)
                            Else
                                getpackprice(itemno, mpc, mrw, "A")
                            End If '

                            Dim fnlqty As Decimal = 0
                            If n_old_qty = new_current_qty Then
                            ElseIf n_old_qty < new_current_qty Then
                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then


                                    fnlqty = new_current_qty - oldqty

                                    Dim curqty As Decimal = 0

                                    cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
                                    cmd.Parameters.AddWithValue("@itm", .Item(1, mrw).Value)
                                    cmd.Parameters.AddWithValue("@wh", txtWarehouseCode.Text.Trim)
                                    Using rd As MySqlDataReader = cmd.ExecuteReader
                                        If rd.HasRows Then
                                            rd.Read()
                                            curqty = rd("qty_good").ToString
                                        End If
                                        rd.Close()
                                    End Using
                                    cmd.Dispose()

                                    If curqty < fnlqty Then
                                        MsgBox("Item quantity exceeded on quantity in the warehouse", vbCritical)
                                        ' old_quantity = getcurqty_from_detail(.Item(8, mrw).Value, "salesd")
                                        .Item(3, mrw).Value = oldqty
                                        .Item(4, mrw).Value = oldunit
                                        .Item(5, mrw).Value = oldpackg
                                        ' .CurrentCell = .Item(3, mrw)
                                        '.Item(7, mrw).Value = 0
                                        Exit Sub

                                    End If
                                End If

                                'minus ni diri
                            ElseIf n_old_qty > nwtotalqty Then
                                If dgvItem.Item(0, mrw).Tag <> "ADD" Then


                                End If

                            End If

                        End If
                        ComputeInvoiceTotal()
                        CalTotalQty()
                    End If


                ElseIf e.ColumnIndex = 4 Then '====================UNIT==========
                    Dim itemno As String = Nothing
                    Dim mpc As String = Nothing
                    itemno = .Item(1, mrw).Value

                    If .Item(3, mrw).Value = 0 Then
                        '   .ClearSelection()
                        MsgBox("Invalid quantity", 48, "Invalid quantity")
                    Else
                        If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
                            .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
                            mpc = .Item(4, mrw).Value
                            ComputeInvoiceTotal()
                            CalTotalQty()
                            btnAdd_Click(sender, e)
                            '  SendKeys.Send("{enter}")
                        Else
                            .Item(4, mrw).Value = "C"
                            mpc = .Item(4, mrw).Value
                            '.BeginEdit(True)
                            ComputeInvoiceTotal()
                            CalTotalQty()
                            btnAdd_Click(sender, e)
                            '  SendKeys.Send("{enter}")
                        End If


                        getpackprice(itemno, mpc, mrw, txtPriceType.Text)

                        If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                            .Item(4, mrw).Value = "P"
                            mpc = .Item(4, mrw).Value
                            ComputeInvoiceTotal()
                            CalTotalQty()
                            btnAdd_Click(sender, e)

                        End If
                        getpackprice(itemno, mpc, mrw, txtPriceType.Text)
                        selrow = mrw
                        If .Item(1, mrw).Value <> Nothing Then
                            .ClearSelection()
                            'Dim method As New SetColumnIndex(AddressOf Mymethod)
                            'Dim nextindex As Integer = 5 'Math.Min(Me.dgvRcvItem.Columns.Count - 1, Me.dgvRcvItem.CurrentCell.ColumnIndex + 1)
                            'Me.dgvItem.BeginInvoke(method, nextindex)

                        End If
                        ComputeInvoiceTotal()
                        CalTotalQty()
                    End If

                    '--------------------------------------------------------------------------------------------------
                    '--------------------------------------------------------------------------------------------------
                    Dim totalqty As Decimal = 0

                    If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                        totalqty = .Item(3, mrw).Value * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                        ComputeInvoiceTotal()
                        CalTotalQty()
                    ElseIf .Item(4, mrw).Value = "P" Then
                        totalqty = .Item(3, mrw).Value
                        ComputeInvoiceTotal()
                        CalTotalQty()
                    End If


                    Dim nwtotalqty As Decimal = 0
                    nwtotalqty = dgvItem.Item(3, mrw).Value

                    Dim new_current_qty As Decimal = 0

                    If .Item(4, mrw).Value = "C" Or .Item(4, mrw).Value = "B" Then
                        new_current_qty = nwtotalqty * IIf(.Item(5, mrw).Value > 0, .Item(5, mrw).Value, 1)
                    Else
                        new_current_qty = nwtotalqty
                    End If '

                    'oldqty = dgvItem.Item(5, mrw).Tag
                    Dim oldunit As String = Nothing
                    Dim oldpackg As Decimal = 0

                    nwtotalqty = dgvItem.Item(3, mrw).Value

                    oldqty = getoldqtyfrmtable(.Item(1, mrw).Value, .Item(8, mrw).Value, "salesd") ' dgvItem.Item(5, mrw).Tag
                    oldunit = getolditemunit(.Item(1, mrw).Value, .Item(8, mrw).Value, "salesd")
                    oldpackg = getolditempckg(.Item(1, mrw).Value, .Item(8, mrw).Value, "salesd")

                    Dim n_old_qty As Decimal = 0
                    n_old_qty = oldqty * oldpackg


                    Dim fnlqty As Decimal = 0
                    fnlqty = totalqty - n_old_qty
                    '--------------------------------------------------------------------------------------------------
                    '--------------------------------------------------------------------------------------------------
                    Dim curqty As Decimal = 0

                    cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@itm", .Item(1, mrw).Value)
                    cmd.Parameters.AddWithValue("@wh", txtWarehouseCode.Text.Trim)
                    Using rd As MySqlDataReader = cmd.ExecuteReader
                        If rd.HasRows Then
                            rd.Read()
                            curqty = rd("qty_good").ToString
                        End If
                        rd.Close()
                    End Using
                    cmd.Dispose()
                    oldqty = dgvItem.Item(5, mrw).Tag

                    If curqty < fnlqty Then

                        MsgBox("Item quantity exceeded on quantity in the warehouse", vbCritical)
                        ' old_quantity = getcurqty_from_detail(.Item(8, mrw).Value, "salesd")
                        ' .Item(3, mrw).Value = old_quantity
                        ' .CurrentCell = .Item(3, mrw)
                        '.Item(7, mrw).Value = 0
                        .Item(3, mrw).Value = oldqty
                        .Item(4, mrw).Value = oldunit
                        .Item(5, mrw).Value = oldpackg
                        Exit Sub
                    Else
                        ComputeInvoiceTotal()
                        CalTotalQty()
                        '.Item(7, mrw).Value = 0
                        Exit Sub
                    End If


                ElseIf e.ColumnIndex = 5 Then
                    '.ClearSelection()
                    '.CurrentCell = .Item(1, mrw)
                    '.BeginEdit(True)

                End If
            End If
        End With
        '=== END NEW PROCESS ===


    End Sub

    Private Sub dgvItem_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItem.CellEnter

    End Sub



    'Private Sub dgvItem_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvItem.EditingControlShowing
    '    If (Me.dgvItem.CurrentCell.ColumnIndex = 4) Then
    '        Dim control As ComboBox = DirectCast(e.Control, ComboBox)
    '        If (Not control Is Nothing) Then
    '            RemoveHandler control.SelectionChangeCommitted, New EventHandler(AddressOf cbx_SelectionChangeCommitted)
    '            AddHandler control.SelectionChangeCommitted, New EventHandler(AddressOf cbx_SelectionChangeCommitted)
    '        End If
    '    End If

    'With dgvItem
    '    If .Rows.Count > 0 Then
    '        If .CurrentCell.ColumnIndex = 3 Then
    '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
    '            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
    '        ElseIf .CurrentCell.ColumnIndex = 4 Then
    '            'Dim cbo As ComboBox = CType(e.Control, ComboBox)
    '            selrow = .CurrentCell.RowIndex
    '            'AddHandler cbo.PreviewKeyDown, AddressOf cbx_PreviewKeyDown
    '            Dim combo As ComboBox = CType(e.Control, ComboBox)
    '            If (combo IsNot Nothing) Then

    '                RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

    '                ' Add the event handler. 
    '                AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

    '            End If
    '        ElseIf .CurrentCell.ColumnIndex = 1 Then
    '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
    '            AddHandler CType(e.Control, TextBox).KeyDown, AddressOf column_keydown
    '        Else

    '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress

    '        End If
    '    End If
    'End With
    ' End Sub

    Private Sub dgvItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvItem.KeyPress
        With dgvItem
            If .Rows.Count > 0 Then
                If Asc(e.KeyChar) = 13 Then
                    If .CurrentCell.ColumnIndex = 5 Then
                        btnAdd.PerformClick()
                    End If

                End If
            End If
        End With
    End Sub

    Private Sub dgvItem_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvItem.KeyUp
        With dgvItem
            If .RowCount > 0 Then
                Dim mrw As Integer = 0
                Dim act As Integer = 0

                mrw = .CurrentCell.RowIndex
                If .CurrentCell.ColumnIndex = 4 Then
                    Dim itemno As String = Nothing
                    Dim mpc As String = Nothing

                    itemno = .Item(1, mrw).Value

                    If UCase(.Item(4, mrw).Value) = "C" Or UCase(.Item(4, mrw).Value) = "P" Or UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = UCase(.Item(4, mrw).Value)
                        mpc = .Item(4, mrw).Value
                        ComputeInvoiceTotal()
                    Else
                        .Item(4, mrw).Value = "C"
                        mpc = .Item(4, mrw).Value
                        .BeginEdit(True)
                        ComputeInvoiceTotal()
                    End If

                    getpackprice(itemno, mpc, mrw, txtPriceType.Text)

                    If .Item(5, mrw).Value = 1 And UCase(.Item(4, mrw).Value) = "B" Then
                        .Item(4, mrw).Value = "P"
                        mpc = .Item(4, mrw).Value
                        ComputeInvoiceTotal()
                    End If

                    ComputeInvoiceTotal()
                ElseIf .CurrentCell.ColumnIndex = 1 And e.KeyCode = Keys.F3 Then
                    btnSearchItem.PerformClick()
                End If
            End If
        End With
    End Sub

    Private Sub cbx_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)
        Dim box As ComboBox = DirectCast(sender, ComboBox)
        If (Me.dgvItem.CurrentCell.ColumnIndex = 4) Then
            Me.dgvItem.CurrentCell.Value = box.SelectedItem.ToString
        End If
        Me.dgvItem.EndEdit(-1)
    End Sub
    Public Sub tbnumonly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 48 Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then e.Handled = True
    End Sub
    Private Sub dgvItem_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvItem.EditingControlShowing
        If (Me.dgvItem.CurrentCell.ColumnIndex = 4) Then
            Dim control As ComboBox = DirectCast(e.Control, ComboBox)
            If (Not Control Is Nothing) Then
                RemoveHandler Control.SelectionChangeCommitted, New EventHandler(AddressOf cbx_SelectionChangeCommitted)
                AddHandler Control.SelectionChangeCommitted, New EventHandler(AddressOf cbx_SelectionChangeCommitted)
            End If
        ElseIf (Me.dgvItem.CurrentCell.ColumnIndex = 3) Then
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf tbnumonly_KeyPress
        End If
        'With dgvItem
        '    If .Rows.Count > 0 Then
        '        If .CurrentCell.ColumnIndex = 3 Then
        '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '        ElseIf .CurrentCell.ColumnIndex = 4 Then
        '            'Dim cbo As ComboBox = CType(e.Control, ComboBox)
        '            selrow = .CurrentCell.RowIndex
        '            'AddHandler cbo.PreviewKeyDown, AddressOf cbx_PreviewKeyDown
        '            Dim combo As ComboBox = CType(e.Control, ComboBox)
        '            If (combo IsNot Nothing) Then

        '                RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

        '                ' Add the event handler. 
        '                'AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf cbx_SelectedIndexChanged)

        '            End If
        '        ElseIf .CurrentCell.ColumnIndex = 1 Then
        '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '            AddHandler CType(e.Control, TextBox).KeyDown, AddressOf column_keydown
        '        Else
        '            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf column_keypress
        '        End If
        '    End If
        'End With
    End Sub


    Sub CalTotalQty()
        With dgvItem
            Dim TotCase As Decimal = 0
            Dim TotBags As Decimal = 0
            Dim TotPcs As Decimal = 0

            '--------richel----------
            'for display 0 if wala sa datagrid---
            Dim countC As Integer = 0
            Dim countB As Integer = 0
            Dim countP As Integer = 0
            '  Dim countK As Integer = 0 'kilo
            '--------- richel-------

            For Each Qty As DataGridViewRow In dgvItem.Rows
                If Qty.Cells(4).Value = "C" Then
                    TotCase += Qty.Cells(3).Value
                    lblCase.Text = TotCase
                    countC += 1

                ElseIf Qty.Cells(4).Value = "B" Then
                    TotBags += Qty.Cells(3).Value
                    lblBag.Text = TotBags

                    countB += 1
                ElseIf Qty.Cells(4).Value = "P" Then
                    TotPcs += Qty.Cells(3).Value
                    lblPc.Text = TotPcs

                    countP += 1
                End If

                '--------richel----------
                'for display 0 if wala sa datagrid---
                If countC = 0 Then
                    lblCase.Text = "0"
                End If
                If countB = 0 Then
                    lblBag.Text = "0"
                End If
                If countP = 0 Then
                    lblPc.Text = "0"
                End If

                '--------richel----------

            Next
        End With

    End Sub

    Private Sub reset_listrmv()
        'Reset person count and array
        rwrmv = 0
        Erase listrmv
    End Sub

    Private Sub reset_listupd()
        rwupd = 0
        Erase listupd
    End Sub


    Private Sub reset_listadded()
        'Reset person count and array
        rwadded = 0
        rwsnews = 0
        Erase listrowsadded
        Erase listadded
    End Sub

    Private Sub updwhsheader(ByVal wh As String, ByVal itc As String, ByVal totpck As Decimal)

        Dim curqty As Decimal = 0
        Dim nwqty As Decimal = 0

        curqty = 0
        nwqty = 0

        cmd = New MySqlCommand("SELECT itemcode,qty_good FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                curqty = rd("qty_good").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        ' nwqty = curqty - totpck
        nwqty = curqty + totpck 'item qty deleted will add back to ivwh

        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@qtyg WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itc)
        cmd.Parameters.AddWithValue("@wh", wh)
        cmd.Parameters.AddWithValue("@qtyg", nwqty) ' diri cya mo add
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Structure upheaderdt
        Dim ihtcd As String
        Dim ihqty As Decimal
        Dim ihpckg As Decimal
        Dim ihqunit As String
        Dim ihwhs As String
        Dim ihgoods As Decimal
    End Structure

    Dim upthisitem() As upheaderdt
    Dim rwuph As Integer = 0

    Private Sub reset_upthisitem()
        'Reset count and array
        rwuph = 0
        Erase upthisitem
    End Sub

    Sub RetrieveSales(ByVal trno As String)

        With dgvItem
            Dim cmd As MySqlCommand
            Dim rw As Integer = 0
            Dim x As Integer = 0

            .Rows.Clear()

            Dim checkopen As String()

            checkopen = check_if_trans_is_open(trno, "salesh", _user)

            If checkopen(0) = True Then
                MsgBox("This transaction is already open by user " & "-- [ " & checkopen(1) & " ] --" & " please ask the user to close it first before editing/updating this transaction. ", 48, "TRANSACTION IS OPEN")
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
            End If

            cmd = New MySqlCommand("SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                                   "LEFT JOIN salesman s ON h.slmncode=s.slmncode " & _
                                   "LEFT JOIN customers c ON h.custcode=c.custcode " & _
                                   "WHERE h.isdeleted<>1 AND ttype='S' AND h.transno=@tno", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    dtpInvoiceDate.Value = rd("tdate").ToString
                    txtTransNo.Text = rd("transno").ToString
                    txtCustCode.Text = rd("custcode").ToString
                    txtCustomername.Text = rd("custname").ToString
                    txtAddress.Text = rd("address").ToString
                    txtSalesmanCode.Text = rd("slmncode").ToString
                    txtSalesmanName.Text = rd("slmnname").ToString
                    txtWarehouseCode.Text = rd("whscode").ToString
                    txtWarehouseName.Text = rd("warehouse").ToString
                    txtPONo.Text = rd("pono").ToString
                    txtInvoiceNo.Text = rd("invoiceno").ToString
                    txtUser.Text = rd("user").ToString
                    cbTerms.Text = rd("terms").ToString

                    If Not IsDBNull(rd("disc1percent").ToString) Then
                        NuPD1.Value = Format(Math.Round(Decimal.Parse(rd("disc1percent").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        NuPD1.Value = 0
                    End If
                    If Not IsDBNull(rd("disc1amount").ToString) Then
                        txtDisc1.Text = Format(Math.Round(Decimal.Parse(rd("disc1amount").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        txtDisc1.Text = 0
                    End If

                    If Not IsDBNull(rd("disc2percent").ToString) Then
                        NuPD2.Value = Format(Math.Round(Decimal.Parse(rd("disc2percent").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        NuPD2.Value = 0
                    End If

                    If Not IsDBNull(rd("disc2amount").ToString) Then
                        txtDisc2.Text = Format(Math.Round(Decimal.Parse(rd("disc2amount").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    Else
                        txtDisc2.Text = 0
                    End If

                    If Not IsDBNull(rd("disc1net").ToString) Then
                        txtDisc1Net.Text = Format(Math.Round(Decimal.Parse(rd("disc1net").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    End If

                    If Not IsDBNull(rd("disc2net").ToString) Then
                        txtDisc2Net.Text = Format(Math.Round(Decimal.Parse(rd("disc2net").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    End If

                    txtGrossAmount.Text = Format(Math.Round(Decimal.Parse(rd("grosstot").ToString), _
                                                        2, MidpointRounding.AwayFromZero), "STANDARD")
                    txtNetAmount.Text = Format(Math.Round(Decimal.Parse(rd("totalamt").ToString), _
                                                         2, MidpointRounding.AwayFromZero), "STANDARD")
                    'txtBalance.Text = Format(Math.Round(Decimal.Parse(rd("balance").ToString), _
                    '                                     2, MidpointRounding.AwayFromZero), "STANDARD")
                    txtRemarks.Text = rd("remarks").ToString


                End If
                rd.Close()
            End Using
            cmd.Dispose()

            ' For Each ct In itmcat

            'cmd = New MySqlCommand("SELECT r.*,r.pkno as pno, t.description from rcvingd r " & _
            '                       "LEFT JOIN ivitem t ON r.item=t.itemcode " & _
            '                       "WHERE transno=@tn AND r.isdeleted='0' Order by r.pkno Asc", cdb)

            'cmd = New MySqlCommand("select d.*, i.*,w.* from salesd d join ivitem i on d.item=i.itemcode join warehouse w on d.whs=w.whscode where transno=@tn and isdeleted='0' order by d.pkno", cdb)
            ' cmd = New MySqlCommand("select d.*, i.*,w.* from salesd d join ivitem i on d.item=i.itemcode join warehouse w on d.whs=w.whscode where transno=@tn and d.isdeleted='0' order by d.pkno", cdb)
            'cmd = New MySqlCommand("SELECT h.*,d.*,w.*,s.*,c.* FROM salesh h LEFT JOIN salesd d ON h.transno=d.transno " & _
            '                     "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
            '                     "LEFT JOIN salesman s ON h.slsmancode=s.slmcode " & _
            '                     "LEFT JOIN customers c ON h.custcode=c.custcode " & _
            '                     "WHERE h.isdeleted<>1 and d.ttype='S' AND d.transno=@tno ORDER BY d.pkno", cdb)

            cmd = New MySqlCommand("SELECT d.*,i.* FROM salesd d LEFT JOIN ivitem i ON d.itemcode=i.itemcode " & _
                                   "WHERE d.isdeleted<>1 and d.ttype='S' and d.transno=@tno ORDER BY d.pkno", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    x = 0
                    Dim totalqty As Decimal = 0
                    While rd.Read
                        .RowCount += 1
                        rw = .RowCount - 1
                        x += 1
                        .Item(0, rw).Value = x
                        .Item(1, rw).Value = rd("itemcode").ToString
                        .Item(2, rw).Value = rd("description").ToString
                        If Math.Abs(rd("QTY").ToString - Fix(rd("QTY").ToString)) Then
                            .Item(3, rw).Value = Format(CDbl(rd("QTY").ToString), "#,##0.00")
                        Else
                            .Item(3, rw).Value = Format(CDbl(rd("QTY").ToString), "#,##0")
                        End If

                        .Item(4, rw).Value = rd("qunit").ToString
                        .Item(4, rw).Tag = rd("qunit").ToString
                        .Item(5, rw).Value = rd("PCKG").ToString

                        If rd("qunit").ToString = "C" Or rd("qunit").ToString = "B" Then
                            totalqty = rd("QTY").ToString * IIf(rd("PCKG").ToString > 0, rd("PCKG").ToString, 1)
                        ElseIf rd("qunit").ToString = "P" Then
                            totalqty = rd("QTY").ToString
                        End If
                        txtPriceType.Text = rd("pricetype").ToString
                        .Item(5, rw).Tag = totalqty
                        '.Item(6, rw).Value = Format(Math.Round(Decimal.Parse(rd("grossamt").ToString), _
                        '                                       2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(6, rw).Value = Format(Math.Round(Decimal.Parse(rd("uprice").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        '.Item(8, rw).Value = Format(Math.Round(Decimal.Parse(rd("costpc").ToString), _
                        '                                       2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(7, rw).Value = Format(Math.Round(Decimal.Parse(rd("amount").ToString), _
                                                               2, MidpointRounding.AwayFromZero), "STANDARD")
                        .Item(8, rw).Tag = rd("pkno").ToString
                        .Item(8, rw).Value = rd("pkno").ToString
                        .Item(9, rw).Value = rd("itemcode").ToString
                        .Item(10, rw).Value = rd("whscode").ToString

                        ' .Item(1, rw).ReadOnly = True
                        ' .Item(13, rw).Value = rd("whscode").ToString

                    End While
                    rd.Close()
                End If
            End Using

            '    cmd = New MySqlCommand("SELECT * FROM users where username=@uname", cdb)
            '    cmd.Parameters.AddWithValue("@uname", tbUser.Text)
            '    Using rd As MySqlDataReader = cmd.ExecuteReader
            '        If rd.HasRows Then
            '            rd.Read()
            '            tbUser.Text = rd("username").ToString
            '        End If
            '        rd.Close()
            '    End Using

            '    .Focus()
        End With
    End Sub

    Sub Disabler()
        dtpInvoiceDate.Enabled = False
        txtCustCode.Enabled = False
        txtSalesmanCode.Enabled = False
        txtWarehouseCode.Enabled = False
        txtInvoiceNo.Enabled = False
        txtPONo.Enabled = False
        txtRemarks.Enabled = False
        NuPD1.Enabled = False
        NuPD2.Enabled = False
        btnAdd.Enabled = False
        btnSearchItem.Enabled = False
        btnRemove.Enabled = False
        cbTerms.Enabled = False
        dgvItem.Enabled = False
    End Sub

    Sub Enabler()
        dtpInvoiceDate.Enabled = True
        txtCustCode.Enabled = True
        txtSalesmanCode.Enabled = True
        txtWarehouseCode.Enabled = True
        txtInvoiceNo.Enabled = True
        txtPONo.Enabled = True
        txtRemarks.Enabled = True
        NuPD1.Enabled = True
        NuPD2.Enabled = True
        btnAdd.Enabled = True
        btnSearchItem.Enabled = True
        btnRemove.Enabled = True
        cbTerms.Enabled = True
        dgvItem.Enabled = True
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnUpdate.Enabled = True
        btnUpdatePrint.Enabled = True
        btnPrint.Enabled = False
        btnEdit.Enabled = False
        Enabler()
    End Sub

    Private Sub btnCloseInvD_Click(sender As Object, e As EventArgs) Handles btnCloseInvD.Click
        If MsgBox("Are you sure you want to discard changes?", vbYesNo + vbQuestion, "Sales Invoice") = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCloseD_Click(sender As Object, e As EventArgs) Handles btnCloseD.Click
        If MsgBox("Are you sure you want to discard changes?", vbYesNo + vbQuestion, "Sales Invoice") = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub NuPD1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuPD1.KeyPress
        Dim netTotal As Decimal = 0
        Dim disc1 As Decimal = 0
        Dim disc1Net As Decimal = 0

        txtDisc1.Text = NuPD1.Value
        disc1 = myd(txtGrossAmount.Text) * myd(NuPD1.Value / 100)
        txtDisc1.Text = Format(disc1, sFmat)
        disc1Net = myd(txtGrossAmount.Text) - myd(txtDisc1.Text)
        txtDisc1Net.Text = Format(disc1Net, sFmat)
        netTotal = myd(txtGrossAmount.Text) - myd(txtDisc1.Text) - myd(txtDisc2.Text) - myd(txtDisc3.Text)
        txtNetAmount.Text = Format(netTotal, sFmat)
        txtBalance.Text = Format(netTotal, sFmat)
    End Sub

    Private Sub NuPD1_ValueChanged(sender As Object, e As EventArgs) Handles NuPD1.ValueChanged
        NuPD1_KeyPress(1, New KeyPressEventArgs(vbCr))
    End Sub

    Private Sub NuPD2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuPD2.KeyPress
        Dim disc2 As Decimal = 0
        Dim disc2Net As Decimal = 0
        Dim NetAmount As Decimal = 0
        Dim dsc2 As Decimal = 0

        If txtDisc2.Text <> Nothing Then
            dsc2 = Decimal.Parse(txtDisc2.Text)
        End If

        txtDisc2Net.Text = (txtDisc1Net.Text - dsc2)
        disc2 = (myd(txtDisc1Net.Text) * (NuPD2.Value / 100))
        txtDisc2.Text = Format(disc2, sFmat)

        txtDisc3Net.Text = txtDisc2Net.Text
        NetAmount = myd(txtGrossAmount.Text) - myd(txtDisc1.Text) - myd(txtDisc2.Text) - myd(txtDisc3.Text)
        txtNetAmount.Text = Format(NetAmount, sFmat)
        txtBalance.Text = Format(NetAmount, sFmat)

    End Sub

    Private Sub NuPD2_ValueChanged(sender As Object, e As EventArgs) Handles NuPD2.ValueChanged
        NuPD2_KeyPress(1, New KeyPressEventArgs(vbCr))
    End Sub

    Private Sub NuPD3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NuPD3.KeyPress
        Dim disc3 As Decimal = 0
        Dim disc3Net As Decimal = 0
        Dim NetAmount As Decimal = 0

        disc3Net = (txtDisc2Net.Text - txtDisc2.Text)
        txtDisc3Net.Text = Format(disc3Net, sFmat)
        disc3 = (myd(txtDisc2Net.Text) * (NuPD3.Value / 100))
        txtDisc3.Text = Format(disc3, sFmat)

        'NetAmount = Decimal.Parse(tbGrossAmt.Text) - myd(tbDisc1.Text) - myd(tbDisc2.Text) - myd(tbDisc3.Text)
        'NetAmount = Decimal.Parse(Val(txtDisc2Net.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc3.Text))
        'NetAmount = Decimal.Parse(Val(txtDisc2Net.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc2.Text)) - Decimal.Parse(Val(txtDisc3.Text))
        NetAmount = myd(txtDisc3Net.Text) - myd(txtDisc3.Text)
        txtNetAmount.Text = Format(NetAmount, sFmat)
    End Sub


    Private Sub NuPD3_ValueChanged(sender As Object, e As EventArgs) Handles NuPD3.ValueChanged
        NuPD3_KeyPress(1, New KeyPressEventArgs(vbCr))
    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Integer

    Public Sub column_keydown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If txtCustCode.Text = "" Then
            MsgBox("Please select customer!", MsgBoxStyle.Critical)
            txtCustCode.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.F3 Then
            btnSearchItem.PerformClick()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintSalesInvoice()
    End Sub

    Private Sub btnCloseCust_Click(sender As Object, e As EventArgs)
        '  gbCustomer.Visible = False

    End Sub

    Private Sub dgvCustomerList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        '    Dim colname As String = dgvPatient.Columns(e.ColumnIndex).Name
        '    If colname = "colSelect" Then
        '        txtPID.Text = dgvPatient.Rows(e.RowIndex).Cells(1).Value.ToString
        '        txtPatientName.Text = dgvPatient.Rows(e.RowIndex).Cells(2).Value.ToString
        '        txtAddress.Text = dgvPatient.Rows(e.RowIndex).Cells(3).Value.ToString
        '        txtWhsName.Text = dgvPatient.Rows(e.RowIndex).Cells(4).Value.ToString
        '        txtWhs.Text = dgvPatient.Rows(e.RowIndex).Cells(5).Value.ToString
        '        gbPatient.SendToBack()
        '        gbPatient.Visible = False
        '    End If
    End Sub

    Private Sub gbCustomer_Enter(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnSelectSalesman_Click(sender As Object, e As EventArgs)
        '    txtSalesmanCode.Text = dgvListSalesman.CurrentRow.Cells(1).Value
        '    txtSalesmanName.Text = dgvListSalesman.CurrentRow.Cells(2).Value
        '    txtWarehouseCode.Text = dgvListSalesman.CurrentRow.Cells(3).Value
        '    txtWarehouseName.Text = dgvListSalesman.CurrentRow.Cells(4).Value
        '    txtPriceType.Text = dgvListSalesman.CurrentRow.Cells(7).Value
        '    gbSalesman.SendToBack()
        '    gbSalesman.Visible = False
        '    txtInvoiceNo.Focus()
        'End Sub

        ' Private Sub txtSearchCustomer_TextChanged(sender As Object, e As EventArgs)
        'Dim i As Integer
        'dgvCustomerList.Rows.Clear()
        'cmd = New MySqlCommand("SELECT * FROM customers where custcode like '%" & txtSearchCustomer.Text & "%' or custname like '%" & txtSearchCustomer.Text & "%' or address like '%" & txtSearchCustomer.Text & "%' or areaname like '%" & txtSearchCustomer.Text & "%'", cdb)
        'rd = cmd.ExecuteReader
        'While rd.Read
        '    i += 1
        '    dgvCustomerList.Rows.Add(i, rd.Item("custcode").ToString, rd.Item("custname").ToString, rd.Item("address").ToString, rd.Item("shipto").ToString, _
        '                          rd.Item("areacode").ToString, rd.Item("areaname").ToString, rd.Item("outletcode").ToString, rd.Item("outlettype").ToString, _
        '                          rd.Item("provcode").ToString, rd.Item("province").ToString, rd.Item("maincode").ToString, rd.Item("mainp").ToString, _
        '                          rd.Item("tinno").ToString, rd.Item("mobileno").ToString, rd.Item("telno").ToString, rd.Item("payterms").ToString, _
        '                          Format(CDbl(rd.Item("creditlimit").ToString), "#,##0.00"), Format(CDbl(rd.Item("spdiscount").ToString), "#,##0.00"), _
        '                          rd.Item("allowpd").ToString, rd.Item("active").ToString, rd.Item("pkno").ToString, "Edit", "Delete")
        'End While
        'rd.Close()
        'dgvCustomerList.CurrentCell = dgvCustomerList.Rows(1).Cells(1)
        'dgvCustomerList.Focus()
        'End Sub

        ' Private Sub btnCloseSalesman_Click(sender As Object, e As EventArgs)
        '    gbSalesman.SendToBack()
        '    gbSalesman.Visible = False
        'End Sub

        ' Private Sub btnSelect_Click(sender As Object, e As EventArgs)
        'txtCustCode.Text = dgvCustomerList.CurrentRow.Cells(1).Value
        'txtCustomername.Text = dgvCustomerList.CurrentRow.Cells(2).Value
        'txtAddress.Text = dgvCustomerList.CurrentRow.Cells(3).Value
        'gbCustomer.SendToBack()
        'gbCustomer.Visible = False
        'txtSalesmanCode.Focus()
        ' SendKeys.Send("{enter}")
    End Sub

    Sub LoadSalesman()
        Dim i As Integer = 0
        dgvListSalesman.Rows.Clear()
        'cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & txtCustCode.Text & "'", cdb)
        cmd = New MySqlCommand("SELECT s.*,c.* FROM custsales s JOIN customers c ON s.custcode=c.custcode WHERE s.custcode like '" & Me.txtCustCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListSalesman.Rows.Add(i, rd.Item("slmncode").ToString, rd.Item("slmnname").ToString, rd.Item("whscode").ToString, rd.Item("warehouse").ToString, rd.Item("opercode").ToString, rd.Item("typeofoper").ToString, rd.Item("pricetype").ToString) ') ', rd.Item("pkno").ToString, "Edit", "Delete")
        End While
        rd.Close()
    End Sub

    Private Sub txtNetAmount_TextChanged(sender As Object, e As EventArgs) Handles txtNetAmount.TextChanged

    End Sub

    Private Sub tsUpdate_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsUpdate.ItemClicked

    End Sub

    Private Sub txtCustCode_TextChanged(sender As Object, e As EventArgs) Handles txtCustCode.TextChanged

    End Sub

    Private Sub txtPriceType_TabIndexChanged(sender As Object, e As EventArgs) Handles txtPriceType.TabIndexChanged
        If txtPriceType.Text <> Nothing Then
            With dgvItem
                If .RowCount > 0 Then
                    For i = 0 To .RowCount - 1
                        Dim itemno As String = Nothing
                        Dim mpc As String = Nothing
                        If .Item(1, i).Value <> Nothing And .Item(4, i).Value <> Nothing Then
                            itemno = .Item(1, i).Value
                            mpc = .Item(4, i).Value

                            If txtPriceType.Text <> Nothing Then
                                getpackprice(itemno, mpc, i, txtPriceType.Text)
                            Else
                                getpackprice(itemno, mpc, i, "A")
                            End If
                        End If
                    Next
                    ComputeInvoiceTotal()
                    CalTotalQty()
                End If
            End With
        End If
    End Sub

    Private Sub txtPriceType_TextChanged(sender As Object, e As EventArgs) Handles txtPriceType.TextChanged
        If txtPriceType.Text <> Nothing Then
            '    With dgvItem
            '        If .RowCount > 0 Then
            '            For i = 0 To .RowCount - 1
            '                Dim itemno As String = Nothing
            '                Dim mpc As String = Nothing
            '                If .Item(1, i).Value <> Nothing And .Item(4, i).Value <> Nothing Then
            '                    itemno = .Item(1, i).Value
            '                    mpc = .Item(4, i).Value

            '                    If txtPriceType.Text <> Nothing Then
            '                        getpackprice(itemno, mpc, i, txtPriceType.Text)
            '                    Else
            '                        getpackprice(itemno, mpc, i, "A")
            '                    End If
            '                End If
            '            Next
            '            ComputeInvoiceTotal()
            '            CalTotalQty()
            '        End If
            '    End With
        End If
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub tsUpdate_TabIndexChanged(sender As Object, e As EventArgs) Handles tsUpdate.TabIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCustCode.Focus()
    End Sub

    Private Sub dgvItem_ControlAdded(sender As Object, e As ControlEventArgs) Handles dgvItem.ControlAdded

    End Sub

    Private Sub txtInvoiceNo_TextChanged(sender As Object, e As EventArgs) Handles txtInvoiceNo.TextChanged

    End Sub

    Private Sub tsSave_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsSave.ItemClicked

    End Sub

    Private Sub dtpInvoiceDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpInvoiceDate.KeyPress
        If e.KeyChar = vbCr Then
            txtCustCode.Focus()
        End If
    End Sub

    Private Sub dtpInvoiceDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpInvoiceDate.ValueChanged

    End Sub
End Class