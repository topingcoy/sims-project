Imports MySql.Data.MySqlClient

Module getterModule
    Public Function GenerateTransNo_In_Out_Transfer(ByVal prefix As String) As String
        Dim mdr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        Dim tno As Long = 0
        Dim tnoFromDb As String = Nothing
        Dim prefixtoOmit As Long

        cmd = New MySqlCommand("Select transno as tno FROM ivh WHERE ttype=@ttype Order by transno Desc limit 1", cdb)
        cmd.Parameters.AddWithValue("@ttype", prefix)

        mdr = cmd.ExecuteReader
        If mdr.HasRows = True Then
 
            mdr.Read()

            tnoFromDb = mdr("tno").ToString
            prefixtoOmit = tnoFromDb.Remove(0, 1)
            tno = prefixtoOmit + 1
            rcvtno = Strings.Right(tno, 9) ' + 1
            rcvtno = prefix & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno

        Else
            tno = 1
            If rcnt = 0 Then
                rcvtno = prefix & "000000001"
            End If
        End If
        mdr.Close()
        mdr.Dispose()

        '  txtTransNo.Text = rcvtno
        Return rcvtno
    End Function

    Public Function GenerateTransNo_SalesInvoice_Return_Bo(ByVal prefix As String) As String
        Dim mdr As MySqlDataReader
        Dim cmd As MySqlCommand
        Dim rcnt As Integer = 0
        Dim yn As Integer = 0
        Dim rcvtno As String = Nothing
        Dim cqry As String = Nothing

        Dim tno As Long = 0

        Dim tnoFromDb As String = Nothing
        Dim prefixtoOmit As Long

        cmd = New MySqlCommand("Select transno as tno FROM salesh WHERE ttype=@ttype Order by transno Desc limit 1", cdb)
        ' cmd = New MySqlCommand("Select COUNT(transno) as tno FROM salesh WHERE ttype=@ttype", cdb)
        cmd.Parameters.AddWithValue("@ttype", prefix)

        mdr = cmd.ExecuteReader
        If mdr.HasRows = True Then

            mdr.Read()

            ' tno = Val(mdr("tno").ToString) + 1
            tnoFromDb = mdr("tno").ToString
            prefixtoOmit = tnoFromDb.Remove(0, 1)
            tno = prefixtoOmit + 1
            rcvtno = Strings.Right(tno, 9) ' + 1
            rcvtno = prefix & Strings.StrDup(9 - Strings.Len(rcvtno), "0") & rcvtno

        Else
            tno = 1
            If rcnt = 0 Then
                rcvtno = prefix & "000000001"
            End If
        End If
        mdr.Close()
        mdr.Dispose()

        '  txtTransNo.Text = rcvtno
        Return rcvtno
    End Function
End Module
