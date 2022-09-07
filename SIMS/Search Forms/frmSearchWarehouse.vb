Imports MySql.Data.MySqlClient

Public Class frmSearchWarehouse

    Private Sub frmSearchWarehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadwarehouse()

    End Sub
    Sub Loadwarehouse()
        dgvListWhs.Rows.Clear()
        Dim i As Integer
        Dim cmd As MySqlCommand
        Dim rd As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM warehouse", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvListWhs.Rows.Add(i, rd.Item("whscode").ToString, rd.Item("warehouse").ToString)
        End While
        rd.Close()
    End Sub
End Class