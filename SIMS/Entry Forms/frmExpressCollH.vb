Imports MySql.Data.MySqlClient

Public Class frmExpressCollH

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmExpressCollD.ShowDialog()
    End Sub

    Private Sub frmExpressCollH_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnAdd.PerformClick()
        ElseIf e.KeyCode = Keys.F7 Then
            btnDelete.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            btnEdit.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure you want to exit", vbQuestion + vbYesNo, "Express Collection") = vbYes Then
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub frmExpressCollH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExpressH()
    End Sub

    Sub LoadExpressH()
        Dim cmd As MySqlCommand
        Dim i As Integer

        dgvExpresH.Rows.Clear()

        cmd = New MySqlCommand("SELECT h.*,s.* FROM expresh h  " & _
                                "LEFT JOIN salesman s ON h.slmncode=s.slmncode  " & _
                                " WHERE h.isdeleted<>1 ORDER BY h.transno desc limit 300", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvExpresH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("edate").ToString, _
                                    rd.Item("docno").ToString, rd.Item("slmnname").ToString, _
                                    Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), _
                                     rd.Item("user").ToString)
        End While
        rd.Close()
    End Sub

    Sub LoadExpresD()

    End Sub
    Dim rowtodel As Integer = -1
    Private Sub dgvExpresH_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpresH.CellClick
        With dgvExpresH
            If e.RowIndex > -1 Then
                If .RowCount > 0 Then
                    rowtodel = e.RowIndex
                End If
            End If
            
        End With
    End Sub

    Private Sub dgvExpresH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpresH.CellContentClick
        'With dgvExpresH
        '    If .RowCount > 0 Then
        '        Dim mytrans As String = Nothing
        '        mytrans = .Item(1, .CurrentCell.RowIndex).Value
        '        frmExpressCollD.RetrieveExpresD(mytrans)
        '        frmExpressCollD.Tag = 1
        '        frmExpressCollD.tsSave.Visible = False
        '        frmExpressCollD.tsUpdate.Visible = True
        '        frmExpressCollD.btnUpdate.Enabled = False
        '        frmExpressCollD.btnUpdatePrint.Enabled = False
        '        ' frmExpressCollD.Disabler()
        '        frmExpressCollD.ShowDialog()
        '    End If
        'End With


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With dgvExpresH
            If .RowCount > 0 Then
                Dim mytrans As String = Nothing
                mytrans = .Item(1, .CurrentCell.RowIndex).Value
                frmExpressCollD.RetrieveExpresD(mytrans)
                frmExpressCollD.Tag = 1
                frmExpressCollD.dgvExpressD.Enabled = False
                frmExpressCollD.tsSave.Visible = False
                frmExpressCollD.tsUpdate.Visible = True
                frmExpressCollD.btnUpdate.Enabled = False
                frmExpressCollD.btnUpdatePrint.Enabled = False
                ' frmExpressCollD.Disabler()
                frmExpressCollD.ShowDialog()
            End If
        End With
    End Sub

    Private Sub dgvExpresH_DoubleClick(sender As Object, e As EventArgs) Handles dgvExpresH.DoubleClick
        btnEdit.PerformClick()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With dgvExpresH
            If .RowCount > 0 Then
                If rowtodel >= 0 Then
                    Dim seltrans As String = Nothing
                    seltrans = .Item(1, rowtodel).Value
                    Dim c As Integer = 0
                    If MsgBox("Are you sure you want to delete this express collection?", 4 + 32, "Delete?") = 7 Then
                        c = 1
                    Else
                        deltrans_expressh(seltrans)
                        LoadExpressH()
                    End If

                End If
            End If
        End With
    End Sub
    Sub deltrans_expressh(ByVal strans As String)
        Dim rfno As String = Nothing
        Dim cmd As MySqlCommand

        Dim rfatot As Decimal = 0
        Dim nwamt As Decimal = 0

        'cmd = New MySqlCommand("SELECT SUM(if(refamt<0,abs(refamt),refamt)) rfa from expresd WHERE transno = @tno AND isdeleted<>1", cdb)
        'cmd.Parameters.AddWithValue("@tno", strans)
        'Using rd As MySqlDataReader = cmd.ExecuteReader
        '    If rd.HasRows Then
        '        rd.Read()
        '        rfatot = rd("rfa").ToString
        '    End If
        '    rd.Close()
        'End Using
        'cmd.Dispose()

        Dim rfnos() As String
        Dim rfamntss() As Decimal
        Dim xx As Integer = 0

        ReDim rfnos(xx)
        ReDim rfamntss(xx)

        cmd = New MySqlCommand("SELECT transno,refno,refamt,refdoc from expresd WHERE transno = @tno AND isdeleted<>1", cdb)
        cmd.Parameters.AddWithValue("@tno", strans)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                While rd.Read()
                    ReDim Preserve rfnos(xx)
                    ReDim Preserve rfamntss(xx)
                    rfno = rd("refno").ToString
                    rfnos(xx) = rfno
                    If Not IsDBNull(rd("refamt").ToString) Then
                        Dim rfaas As Decimal = 0
                        rfaas = rd("refamt").ToString
                        If rd("refamt").ToString < 0 Then
                            rfaas = Decimal.Parse(Math.Abs(rfaas))
                            rfamntss(xx) = rfaas
                        Else
                            rfamntss(xx) = rfaas
                        End If


                    Else
                        rfamntss(xx) = 0
                    End If
                    rfnos(xx) = rd("refno").ToString
                    xx += 1
                End While
               
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        For i = 0 To xx - 1
            rfno = rfnos(i)
            rfatot = rfamntss(i)

            Dim apamt As Decimal = 0
            cmd = New MySqlCommand("SELECT applied FROM salesh WHERE transno = @tno", cdb)
            cmd.Parameters.AddWithValue("@tno", rfno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    apamt = rd("applied").ToString
                End If
                rd.Close()
            End Using
            cmd.Dispose()

            If apamt > 0 Then
                nwamt = apamt - rfatot
            Else
                nwamt = 0
            End If

            If nwamt = 0 Then
                cmd = New MySqlCommand("UPDATE salesh SET applied=@apd, pdate=NULL WHERE transno = @tno", cdb)
            Else
                cmd = New MySqlCommand("UPDATE salesh SET applied=@apd WHERE transno = @tno", cdb)
            End If
            cmd.Parameters.AddWithValue("@tno", rfno)
            cmd.Parameters.AddWithValue("@apd", nwamt)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next


        cmd = New MySqlCommand("UPDATE expresh SET isdeleted=@st WHERE transno = @tno", cdb)
        cmd.Parameters.AddWithValue("@tno", strans)
        cmd.Parameters.AddWithValue("@st", 1)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cmd = New MySqlCommand("UPDATE expresd SET isdeleted=1 WHERE transno = @tno ", cdb)
        cmd.Parameters.AddWithValue("@tno", strans)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        MsgBox("Express collection successfully deleted", 64, "DELETED")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim cmd As MySqlCommand
        Dim i As Integer

        dgvExpresH.Rows.Clear()

        cmd = New MySqlCommand("SELECT h.*,s.* FROM expresh h  " & _
                                "LEFT JOIN salesman s ON h.slmncode=s.slmncode  " & _
                                " WHERE (h.docno like '%" & txtSearch.Text & "%') and isdeleted<>1 ORDER BY h.transno desc limit 300", cdb)
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvExpresH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("edate").ToString, _
                                    rd.Item("docno").ToString, rd.Item("slmnname").ToString, _
                                    Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), _
                                     rd.Item("user").ToString)

        End While
        rd.Close()

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim cmd As MySqlCommand
        Dim i As Integer

        dgvExpresH.Rows.Clear()

        cmd = New MySqlCommand("SELECT h.*,s.* FROM expresh h  " & _
                                "LEFT JOIN salesman s ON h.slmncode=s.slmncode  " & _
                                " WHERE edate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
                                  "and edate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "' " & _
                                  "and isdeleted<>1 ORDER BY h.transno desc limit 300", cdb)

        'qry = "SELECT h.*,w.*,s.*,c.* FROM salesh h LEFT JOIN warehouse w ON h.whscode=w.whscode " & _
        '                          "LEFT JOIN salesman s ON h.slmncode=s.slmncode LEFT JOIN customers c " & _
        '                          "ON h.custcode=c.custcode WHERE idate >= '" & Format(sDate1.Value, "yyyy-MM-dd") & "' " & _
        '                          "and idate <= '" & Format(sDate2.Value, "yyyy-MM-dd") & "'and h.isdeleted<>1 and ttype='S' " & _
        '                           "ORDER BY transno desc limit 300"
        rd = cmd.ExecuteReader
        While rd.Read
            i += 1
            dgvExpresH.Rows.Add(i, rd.Item("transno").ToString, rd.Item("edate").ToString, _
                                    rd.Item("docno").ToString, rd.Item("slmnname").ToString, _
                                    Format(CDbl(rd.Item("totalamt").ToString), "#,##0.00"), _
                                     rd.Item("user").ToString)

        End While
        rd.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadExpressH()
    End Sub
End Class