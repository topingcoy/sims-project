Imports MySql.Data.MySqlClient

Public Class frmReceivingD

    Private Sub frmReceivingD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsRcvd.Cursor = Cursors.Hand
        tsDgvRcvd.Cursor = Cursors.Hand


        With dgvRcvTotal
            dgvRcvTotal.Rows.Add()
            .Rows(0).Cells(0).Value = "GROSS AMOUNT"
            dgvRcvTotal.Rows.Add()
            .Rows(1).Cells(0).Value = "LESS: DISC. 1"
            dgvRcvTotal.Rows.Add()
            .Rows(2).Cells(0).Value = Space(9) & "DISC. 2"
            dgvRcvTotal.Rows.Add()
            .Rows(3).Cells(0).Value = Space(9) & "DISC. 3 "
            dgvRcvTotal.Rows.Add()
            .Rows(4).Cells(0).Value = "NET AMOUNT"
        End With
    End Sub
End Class