Imports MySql.Data.MySqlClient

Public Class frmCollSearch
    Dim r As Integer

    Private Sub dgvCollSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCollSales.CellContentClick
        If e.ColumnIndex = 0 Then
            With dgvCollSales
                If .Rows(.CurrentRow.Index).Cells(0).Value = True Then
                    .Rows(.CurrentRow.Index).Cells(0).Value = False
                    'delete the item from express itemlist
                    For i = 0 To frmExpressCollD.dgvExpressD.RowCount - 1
                        If .CurrentRow.Cells(10).Value = frmExpressCollD.dgvExpressD.Rows(i).Cells(10).Value Then
                            frmExpressCollD.dgvExpressD.Rows.Remove(frmExpressCollD.dgvExpressD.Rows(i))
                            For j = 0 To frmExpressCollD.dgvExpressD.RowCount - 1
                                frmExpressCollD.dgvExpressD.Rows(j).Cells(0).Value = j + 1
                            Next
                            Exit For
                        End If
                    Next
                Else
                    sAddtoList()
                End If
                sTotal()
            End With
        End If

    End Sub

    Function checkifinlist(ByVal crow As Integer)
        Dim fnd As Boolean = False
        With frmExpressCollD.dgvExpressD
            For i = 0 To .RowCount - 1
                Dim mypkno As String = Nothing
                Dim myval As Decimal = 0

                mypkno = .Rows(i).Cells(1).Tag
                myval = .Rows(i).Cells(6).Value
                '  MsgBox(mypkno)
                If dgvCollSales.Rows(crow).Cells(1).Tag = mypkno And dgvCollSales.Rows(crow).Cells(8).Value = myval Then
                    fnd = True
                End If
            Next

        End With
        Return fnd
    End Function

    Private Sub sAddtoList()
        Dim crow As Integer = 0

        dgvCollSales.Rows(dgvCollSales.CurrentRow.Index).Cells(0).Value = True
        crow = dgvCollSales.CurrentRow.Index

        'add to list
        If checkifinlist(crow) Then
            dgvCollSales.Rows(crow).Cells(0).Value = False
            MsgBox("Already in list!", 48, "Please check")
        Else
            frmExpressCollD.dgvExpressD.Rows.Add()
            r = frmExpressCollD.dgvExpressD.RowCount - 1
            frmExpressCollD.dgvExpressD.Rows(r).Cells(0).Value = r + 1
            frmExpressCollD.dgvExpressD.Rows(r).Cells(0).Tag = dgvCollSales.CurrentRow.Cells(8).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(1).Value = dgvCollSales.CurrentRow.Cells(1).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(1).Tag = dgvCollSales.CurrentRow.Cells(1).Tag
            frmExpressCollD.dgvExpressD.Rows(r).Cells(2).Value = dgvCollSales.CurrentRow.Cells(9).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(3).Value = dgvCollSales.CurrentRow.Cells(5).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(3).Tag = dgvCollSales.CurrentRow.Cells(3).Tag
            frmExpressCollD.dgvExpressD.Rows(r).Cells(4).Value = dgvCollSales.CurrentRow.Cells(3).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(5).Value = dgvCollSales.CurrentRow.Cells(4).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(6).Value = dgvCollSales.CurrentRow.Cells(8).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(7).Value = ""
            frmExpressCollD.dgvExpressD.Rows(r).Cells(8).Value = "CASH"
            frmExpressCollD.dgvExpressD.Rows(r).Cells(9).Value = frmExpressCollD.sDate.Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(10).Value = dgvCollSales.CurrentRow.Cells(10).Value
            frmExpressCollD.dgvExpressD.Rows(r).Cells(11).Value = dgvCollSales.CurrentRow.Cells(2).Value
            frmExpressCollD.dgvExpressD.Refresh()
            sTotal()
        End If

    End Sub

    Private Sub sTotal()
        Dim nTotal As Double = 0
        For i = 0 To frmExpressCollD.dgvExpressD.RowCount - 1
            With frmExpressCollD
                With .dgvExpressD
                    nTotal += .Rows(i).Cells(6).Value
                End With
            End With
        Next
        frmExpressCollD.txtAmount.Text = Format(nTotal, sFmat)
    End Sub

    Private Sub frmCollSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Clear()
        LoadCollSearch(1)
    End Sub

    Sub LoadCollSearch(ByVal x As Integer)
        Dim qry As String = Nothing
        Dim sstring As String = Nothing
        With dgvCollSales
            .Rows.Clear()
            If x = 1 Then
                qry = "SELECT a.*,b.custname from salesh as a, customers as b " & _
             "where a.slmncode='" & frmExpressCollD.txtSalesmanCode.Text & "'  " & _
             "and a.isdeleted<>1 and a.custcode=b.custcode and (totalamt>applied or applied='0') order by b.custname"
            ElseIf x = 2 Then

                sstring = "%" & txtSearch.Text & "%"
                qry = "SELECT a.*,b.custname from salesh as a, customers as b " & _
                 " WHERE b.custname LIKE @cn AND a.slmncode='" & frmExpressCollD.txtSalesmanCode.Text & "'  " & _
                 "and a.isdeleted<>1 and a.custcode=b.custcode and (totalamt>applied or applied='0') order by b.custname"

            End If
         
            Using cmd = New MySqlCommand()

                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                If x = 2 Then
                    cmd.Parameters.AddWithValue("@cn", sstring)
                End If
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            '  .Item(0, r).Tag = rd("totalamt").ToString
                            .Item(1, r).Value = rdr("ttype").ToString
                            .Item(1, r).Tag = rdr("pkno").ToString
                            .Item(2, r).Value = rdr("tdate").ToString
                            .Item(3, r).Value = rdr("invoiceno").ToString
                            .Item(3, r).Tag = rdr("applied").ToString
                            .Item(4, r).Value = rdr("pono").ToString
                            .Item(5, r).Value = rdr("custname").ToString
                            If .Item(1, r).Value = "S" Then
                                .Item(6, r).Value = Format(CDbl(rdr("totalamt").ToString), "#,#00.00")
                            Else
                                .Item(6, r).Value = -Format(CDbl(rdr("totalamt").ToString), "#,#00.00")
                            End If
                            .Item(7, r).Value = Format(CDbl(rdr("applied").ToString), "#,#00.00")
                            If .Item(1, r).Value = "S" Then
                                .Item(8, r).Value = .Item(6, r).Value - .Item(7, r).Value
                            Else
                                .Item(8, r).Value = .Item(6, r).Value + .Item(7, r).Value
                            End If
                            .Item(9, r).Value = rdr("custcode").ToString
                            .Item(10, r).Value = rdr("transno").ToString
                        End While
                    End If
                End Using
            End Using
            For i = 0 To frmExpressCollD.dgvExpressD.RowCount - 1
                For j = 0 To dgvCollSales.RowCount - 1
                    If frmExpressCollD.dgvExpressD.Rows(i).Cells(10).Value = dgvCollSales.Rows(j).Cells(1).Value Then
                        dgvCollSales.Rows(j).Cells(0).Value = True
                        Exit For
                    End If
                Next
            Next
            dgvCollSales.Sort(dgvCollSales.Columns(2), System.ComponentModel.ListSortDirection.Descending)
            If dgvCollSales.RowCount > 0 Then
                dgvCollSales.CurrentCell = dgvCollSales.Rows(0).Cells(0)
            End If

        End With

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' frmExpressCollD.txtDocno.Text = dgvCollSales.CurrentRow.Cells(0).Value
        With dgvCollSales
            Dim x As Integer = 0
            Dim b As Boolean = False
            For i = 0 To .RowCount - 1
                If .Item(0, i).Value = True Then
                    b = True
                End If
            Next
            If b = False Then
                MsgBox("Please select transaction first!", 48, "No selected transactions")
            Else
                SendKeys.Send("{enter}")
                Me.Close()
            End If
        End With
       
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> Nothing Then
            LoadCollSearch(2)
        Else
            LoadCollSearch(1)
        End If
    End Sub
End Class