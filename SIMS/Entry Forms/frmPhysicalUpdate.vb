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

Public Class frmPhysicalUpdate
    Dim listactuals() As actualitems
    Dim actualrows As Integer = 0
    Structure actualitems
        Dim a_whs As String
        Dim a_itm As String
        Dim a_tno As String
        Dim a_qc As Decimal
        Dim a_qb As Decimal
        Dim a_qp As Decimal
        Dim a_q_pckc As Decimal
        Dim a_q_pckb As Decimal
        Dim a_q_pcs As String

        Dim a_q_total_pcase As Decimal
        Dim a_q_total_pbag As Decimal

        Dim a_q_total_pcs As Decimal
        Dim a_tdate As Date
    End Structure
    Private Sub frmPhysicalUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = 0
        LoadPhyivH()
        chkalltrans.Checked = False

        set_progressbar_max(0, 0, 0, "B")
        For i = 0 To dgvUpdate.ColumnCount - 1
            If i <> 1 Then
                dgvUpdate.Columns(i).ReadOnly = True
            End If
        Next
    End Sub

    Sub LoadPhyivH()
        dgvUpdate.Rows.Clear()
        Dim i As Integer
        Dim x As Integer = 0
        cmd = New MySqlCommand("SELECT h.*,w.warehouse FROM phyivh h " & _
                               "LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
                               "WHERE isdeleted<>1 AND POSTED='N' ORDER BY transno desc", cdb)

        rd = cmd.ExecuteReader
        While rd.Read


            Dim stat As String = "UPDATE"
            If rd.Item("posted").ToString = "Y" Then
                stat = "UPDATED"

            End If
            i += 1
            dgvUpdate.Rows.Add(i, False, rd.Item("transno").ToString, rd.Item("WHSCODE").ToString, _
                             rd.Item("whsname").ToString, rd.Item("tdate").ToString, _
                             rd.Item("posted").ToString, stat)

            If rd.Item("posted").ToString = "Y" Then
                dgvUpdate.Item(1, x).ReadOnly = True

            End If
            x += 1

        End While
        rd.Close()
    End Sub

    Sub update_to_actual_inventory(ByVal trno As String, ByVal mytab As String, ByVal st As Integer, ByVal batchtype As String)
        actualrows = 0
      
        Using cmd = New MySqlCommand("SELECT t1.transno,t2.* FROM " & mytab & " t1 INNER JOIN phyivd t2 ON t1.transno=t2.transno " & _
                                     " WHERE t2.isdeleted='0' and t1.isdeleted='0' and POSTED='N' AND t1.transno=@tno", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    While rd.Read
                        Dim whse As String = Nothing

                        Dim itmc As String = Nothing

                        Dim pkno As String = Nothing

                        Dim q_cases As Decimal = 0
                        Dim q_bags As Decimal = 0
                        Dim q_pcs As Decimal = 0

                        Dim q_pck_case As Decimal = 0
                        Dim q_pck_bag As Decimal = 0
                        Dim q_tdate As Date

                        itmc = rd("itemcode").ToString
                        pkno = rd("pkno").ToString
                        whse = rd("whscode").ToString

                        q_cases = IIf(rd("qtyc").ToString > 0, Decimal.Parse(rd("qtyc").ToString), 0)
                        q_pck_case = IIf(rd("pckgc").ToString > 0, Decimal.Parse(rd("pckgc").ToString), 0)

                        q_bags = IIf(rd("qtyb").ToString > 0, Decimal.Parse(rd("qtyb").ToString), 0)
                        q_pck_bag = IIf(rd("pckgb").ToString > 0, Decimal.Parse(rd("pckgb").ToString), 0)

                        q_pcs = IIf(rd("qtyp").ToString > 0, Decimal.Parse(rd("qtyp").ToString), 0)

                        q_tdate = IIf(IsDBNull(rd("tdate").ToString), DBNull.Value, rd("tdate").ToString)

                        Dim totalqty As Decimal = 0
                        Dim totalc As Decimal = 0
                        Dim totalb As Decimal = 0

                        totalc = convert_item_to_pcs(q_cases, q_pck_case)
                        totalb = convert_item_to_pcs(q_bags, q_pck_bag)

                        totalqty = totalc + totalb + q_pcs

                        ReDim Preserve listactuals(actualrows)
                        With listactuals(actualrows)
                            .a_itm = itmc
                            .a_whs = whse
                            .a_tno = trno

                            .a_q_pckc = q_pck_case
                            .a_q_pckb = q_pck_bag

                            .a_qc = q_cases
                            .a_qb = q_bags
                            .a_q_pcs = q_pcs

                            .a_q_total_pcase = totalc
                            .a_q_total_pbag = totalb
                            .a_q_total_pcs = totalqty
                            .a_tdate = q_tdate

                        End With
                        actualrows += 1

                    End While
                End If
                rd.Close()
            End Using
            cmd.Dispose()
        End Using

        'If batchtype = "I" Then
        set_progressbar_max(actualrows, 0, 1, batchtype)
        'End If


        Dim cnter2 As Integer = 0
        For x As Integer = 0 To actualrows - 1

            get_item_variance(listactuals(x).a_tno, listactuals(x).a_itm, listactuals(x).a_q_total_pcs, listactuals(x).a_whs, listactuals(x).a_q_pckc, listactuals(x).a_q_pckb, listactuals(x).a_tdate, "G")
            update_warehouse_qty(listactuals(x).a_itm, listactuals(x).a_q_total_pcs, listactuals(x).a_whs, "G")

            'If batchtype = "I" Then
            '    cnter2 += 1
            set_progressbar_max(actualrows, cnter2, 2, batchtype)

            ' End If


        Next

        Using cmd = New MySqlCommand("UPDATE phyivh SET posted='Y' WHERE  transno=@trn", cdb)
            cmd.Parameters.AddWithValue("@trn", trno)
            cmd.ExecuteNonQuery()
        End Using
        chkalltrans.Enabled = True
        dgvUpdate.Enabled = True
        tsrupdate_all.Enabled = True
        'If batchtype = "I" Then
        set_progressbar_max(0, 0, 0, batchtype)

        ' End If


    End Sub

    Private Sub dgvUpdate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUpdate.CellContentClick
        With dgvUpdate
            If .RowCount > 0 Then
                If e.ColumnIndex = 7 Then
                    If .Item(6, e.RowIndex).Value = "N" Then
                        Dim c As Integer = 0
                        If MsgBox("Are you sure you want to post/upload this transaction? This request cannot be reversed or undo, please double check entry", 4 + 32, "Post/Upload physical inventory transaction?") = 7 Then
                            c = 1
                        Else
                            chkalltrans.Enabled = False
                            dgvUpdate.Enabled = False
                            tsrupdate_all.Enabled = False

                            Dim transno As String = Nothing
                            transno = .Item(2, e.RowIndex).Value
                            update_to_actual_inventory(transno, "phyivh", 2, "I")
                            .Item(6, e.RowIndex).Value = "Y"
                            .Item(1, e.RowIndex).Value = False
                            .Item(7, e.RowIndex).Value = "UPDATED"
                            .Item(1, e.RowIndex).ReadOnly = True
                            MsgBox("Actual inventory successfully updated to warehouse!", 64, "Transaction completed successfully")
                            LoadPhyivH()
                            chkalltrans.Enabled = True
                            dgvUpdate.Enabled = True
                            tsrupdate_all.Enabled = True
                        End If
                    Else
                        MsgBox("This transaction is already been posted and uploaded to warehouse", 48, "STATUS POSTED")
                    End If
                ElseIf e.ColumnIndex = 1 Then
                    If .Item(6, e.RowIndex).Value = "Y" Then
                        .Item(1, e.RowIndex).Value = False
                    End If
                End If
            End If
           
        End With

    End Sub

  
    Private Sub tsrupdate_all_Click(sender As Object, e As EventArgs) Handles tsrupdate_all.Click
        With dgvUpdate
            Dim c As Integer = 0
            If MsgBox("Are you sure you want to post/upload this transaction? This request cannot be reversed or undo, please double check entry", 4 + 32, "Post/Upload physical inventory transaction?") = 7 Then
                c = 1
            Else
                chkalltrans.Enabled = False
                dgvUpdate.Enabled = False
                tsrupdate_all.Enabled = False

                Dim mx As Integer = 0
                Dim pbarmax As Integer = 0

                For i = 0 To .RowCount - 1
                    If .Item(1, i).Value = True Then
                        pbarmax += 1
                    End If
                Next
                If pbarmax > 0 Then
                    '   set_progressbar_max(pbarmax, 0, 1, "B")
                End If


                Dim cnter As Integer = 0
                For i = 0 To .RowCount - 1
                    '  MsgBox(.Item(1, i).Value)

                    If .Item(6, i).Value = "N" And .Item(1, i).Value = True Then
                        Dim transno As String = Nothing
                        transno = .Item(2, i).Value
                        'cnter += 1

                        update_to_actual_inventory(transno, "phyivh", 1, "I")
                        '  set_progressbar_max(pbarmax, cnter, 2, "B")
                        .Item(6, i).Value = "Y"
                        .Item(1, i).Value = False
                        .Item(7, i).Value = "UPDATED"
                        .Item(1, i).ReadOnly = True
                        mx = 1

                    End If
                Next
                If mx = 1 Then
                    MsgBox("Actual inventory successfully updated to warehouse!", 64, "Transaction completed successfully")
                    LoadPhyivH()
                End If
                chkalltrans.Checked = False
              
                chkalltrans.Enabled = True
                dgvUpdate.Enabled = True
                tsrupdate_all.Enabled = True
                ' set_progressbar_max(0, 0, 0, "B")
                If mx = 0 Then
                    MsgBox("Please select transaction to update", 48, "No Transaction Selected")
                End If
            End If
           
        End With
    End Sub

    Private Sub dgvUpdate_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvUpdate.CurrentCellDirtyStateChanged
        With dgvUpdate
            If .RowCount > 0 Then
                If .IsCurrentCellDirty Then
                    .CommitEdit(DataGridViewDataErrorContexts.Commit)
                    .CommitEdit(True)
                End If
            End If
        End With
     



    End Sub

    Private Sub chkalltrans_CheckedChanged(sender As Object, e As EventArgs) Handles chkalltrans.CheckedChanged
        With dgvUpdate
            If chkalltrans.Checked = True Then
                For i = 0 To .RowCount - 1
                    If .Item(6, i).Value = "N" Then
                        .Item(1, i).Value = True
                    Else
                        .Item(1, i).Value = False
                    End If
                Next
            Else
                For i = 0 To .RowCount - 1
                    .Item(1, i).Value = False
                Next
            End If

        End With
    End Sub
End Class