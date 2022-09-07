Imports MySql.Data.MySqlClient

Public Class frmSearchBookingAR

    Private Sub frmSearchBookingAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingAR()
    End Sub

    Sub LoadBookingAR()
        Dim qry As String = Nothing
        With dgvARDetails
            .Rows.Clear()
            qry = "SELECT a.*,b.custname from salesh as a, customers as b " & _
                "where b.custcode='" & frmBookingARCollD.txtCustCode.Text & "'  " & _
                "and a.custcode=b.custcode and (totalamt>applied or applied='0') order by b.custname"
            Using cmd = New MySqlCommand()
                cmd.Connection = cdb
                cmd.CommandText = qry
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    Dim r As Integer = 0
                    Dim n As Integer = 0
                    If rdr.HasRows = True Then
                        While rdr.Read
                            .RowCount += 1
                            n += 1
                            r = .RowCount - 1
                            .Item(1, r).Value = rdr("idate").ToString
                            .Item(2, r).Value = rdr("ttype").ToString
                            .Item(3, r).Value = rdr("invoiceno").ToString
                            .Item(4, r).Value = rdr("pono").ToString
                            If .Item(2, r).Value = "S" Then
                                .Item(5, r).Value = Format(CDbl(rdr("totalamt").ToString), "#,#00.00")
                            Else
                                .Item(5, r).Value = -Format(CDbl(rdr("totalamt").ToString), "#,#00.00")
                            End If
                            .Item(6, r).Value = Format(CDbl(rdr("applied").ToString), "#,#00.00")
                            If .Item(2, r).Value = "S" Then
                                .Item(7, r).Value = .Item(5, r).Value - .Item(6, r).Value
                            Else
                                .Item(7, r).Value = .Item(5, r).Value + .Item(6, r).Value
                            End If
                            .Item(8, r).Value = rdr("pdate").ToString
                            .Item(9, r).Value += .Item(5, r).Value 'commulative
                            .Item(10, r).Value = rdr("transno").ToString
                            .Item(11, r).Value = rdr("idate").ToString
                        End While
                    End If
                End Using
            End Using
        End With

        'For i = 0 To frmBookingARCollD.dgvTransDetails.RowCount - 1
        '    For j = 0 To dgvCollSales.RowCount - 1
        '        If frmExpressCollD.dgvExpressD.Rows(i).Cells(10).Value = dgvCollSales.Rows(j).Cells(10).Value Then
        '            dgvCollSales.Rows(j).Cells(0).Value = True
        '            Exit For
        '        End If
        '    Next
        'Next
        'dgvCollSales.Sort(dgvCollSales.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        'dgvCollSales.CurrentCell = dgvCollSales.Rows(0).Cells(0)

    End Sub


End Class