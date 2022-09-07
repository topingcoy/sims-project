Imports MySql.Data.MySqlClient

Module checkerFunctions

    Public Function checkItemIsExisting(ByVal itemcode As String) As Boolean
        Dim retVar As Boolean = False

        If checkItemIsExistingIVD(itemcode) _
            Or checkItemIsExistingRCVINGD(itemcode) _
            Or checkItemIsExistingSALESD(itemcode) _
            Or checkItemisExistingPHYIVD(itemcode) _
            Or checkItemisExistingPHYIVA(itemcode) Then
            retVar = True
        Else
            retVar = False
        End If
        Return retVar
    End Function

    Public Function checkItemisExistingPHYIVD(ByVal itemcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM phyivd AS pd " & _
                 "Where pd.isdeleted = '0' and pd.itemcode = @itemcode", cdb)
        cmd.Parameters.AddWithValue("@itemcode", itemcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar

    End Function

    Public Function checkItemisExistingPHYIVA(ByVal itemcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM phyivd AS pa " & _
                 "Where pa.isdeleted = '0' and pa.itemcode = @itemcode", cdb)
        cmd.Parameters.AddWithValue("@itemcode", itemcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar

    End Function

    Public Function checkItemIsExistingIVD(ByVal itemcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM ivd AS id " & _
                 "Where id.isdeleted = '0' and id.itemcode = @itemcode", cdb)
        cmd.Parameters.AddWithValue("@itemcode", itemcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkItemIsExistingRCVINGD(ByVal itemcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM rcvingd AS rd " & _
                 "Where rd.isdeleted = '0' and rd.itemcode = @itemcode", cdb)
        cmd.Parameters.AddWithValue("@itemcode", itemcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkItemIsExistingSALESD(ByVal itemcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM salesd AS sd " & _
                 "Where sd.isdeleted = '0' and sd.itemcode = @itemcode", cdb)
        cmd.Parameters.AddWithValue("@itemcode", itemcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkCustomerIfExistingSALESHandEXPRESD(ByVal custcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM expresd " & _
                "INNER JOIN salesh ON expresd.custcode = salesh.custcode " & _
                 "Where expresd.isdeleted = '0' and salesh.isdeleted = '0' and expresd.custcode=@custcode", cdb)
        cmd.Parameters.AddWithValue("@custcode", custcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkCustomerIfExistingCMDM(ByVal custcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM cmdm " & _
                 "Where isdeleted = '0' and custcode=@custcode", cdb)
        cmd.Parameters.AddWithValue("@custcode", custcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkCustomerIfExistingCUSTSALES(ByVal custcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM custsales " & _
                 "Where custcode=@custcode", cdb)
        cmd.Parameters.AddWithValue("@custcode", custcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkCustomerIfExistingPAYH(ByVal custcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM payh " & _
                 "Where custcode=@custcode", cdb)
        cmd.Parameters.AddWithValue("@custcode", custcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkCustomerIfExistingCOLLH(ByVal custcode As String) As Boolean
        Dim retVar As Boolean = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * " & _
                "FROM collh " & _
                 "Where custcode=@custcode", cdb)
        cmd.Parameters.AddWithValue("@custcode", custcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retVar = True
            End If
        End Using
        cmd.Dispose()

        Return retVar
    End Function

    Public Function checkCustomerIfExistingALL(ByVal custcode As String) As Boolean
        Dim retVar As Boolean = False

        If checkCustomerIfExistingSALESHandEXPRESD(custcode) _
            Or checkCustomerIfExistingCMDM(custcode) _
            Or checkCustomerIfExistingCOLLH(custcode) _
            Or checkCustomerIfExistingPAYH(custcode) Then
            retVar = True
        End If

        Return retVar
    End Function

    Public Function isExistItemCode(ByVal itemcode As String) As Boolean
        Dim retvar As Boolean = False

        cmd = New MySqlCommand("SELECT itemcode FROM ivitem WHERE itemcode=@itm", cdb)
        cmd.Parameters.AddWithValue("@itm", itemcode)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                retvar = True

            End If
        End Using

        Return retvar
    End Function
End Module
