Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine


Module Module1
    Public enc As System.Text.UTF8Encoding
    Public encryptor As ICryptoTransform
    Public decryptor As ICryptoTransform
    Public cString As String = Nothing
    Public cString2 As String = "Server=192.168.1.1; User Id=root; Password=123456789;Database=dbname; pooling=false;"
    Public cdb As MySqlConnection
    Public cdb2 As MySqlConnection
    Public adb As OleDbConnection
    Public sFmat As String = "###,###,###,##0.00"
    Public mypath As String = Nothing
    Public ptpath As String = Nothing
    Public seltabindex As Integer = 0
    Public seldbname As String = Nothing
    Public ntpg As TabPage
    Public rmbtabtflag As Boolean = False
    Public BoldedRows As New List(Of DataGridViewRow)
    Dim gdr As MySqlDataReader
    Public usertyp As String = Nothing
    Public crpay As Boolean = False
    Public crpaybrs As String = Nothing
    Public crattid As String = Nothing
    Public crnewpperid As String = Nothing
    Public ndtrn1 As Date
    Public ndtrn2 As Date
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public mysvrip As String = Nothing
    'Public _user, _pass, _name, _usertype As String
    Private tripleDes As New TripleDESCryptoServiceProvider
    Public str_user As String
    Public str_pass As String
    Public str_role As String
    Public str_name As String
    Public _user, _pass, _name, _usertype As String

    Public KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
    Public IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
    Public symmetricKey As RijndaelManaged = New RijndaelManaged()

    Public dtps1 As Date = Now.ToString
    Public dtps2 As Date = Now.ToString
    Public dtps3 As Date = Now.ToString

    Public prep As New ReportDocument
    Public ds As New DataSet1
    Public ds2 As New DataSet2
    Public dt As DataTable = ds.Tables("rcvDataTable")
    Public dtc As DataTable = ds.Tables("supCM")
    Public dtStockIn As DataTable = ds.Tables("dtStockIn")
    Public dtStockTransfer As DataTable = ds2.Tables("dtStockTransfer")
    Public dtSalesInvoice As DataTable = ds.Tables("dtSalesInvoice")
    Public dtExpress As DataTable = ds.Tables("dtExpressColl")
    Public r1 As DataRow
    Public r2 As DataRow
    Public cmdmtype As String = Nothing

    Public Function convertpackaging_fromivitem(ByVal itm As String, ByVal pkcg As String, ByVal nwqty As Decimal, ByVal un As String)
        Dim nwqt As Decimal = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT pckgc,pckgb,pckgp,unit FROM ivitem WHERE itemcode=@it", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@it", itm)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                Dim qunit As String = Nothing
                Dim rmvunit As Decimal = 0
                Dim rmvpckg As Decimal = 0

                If un <> Nothing Then
                    qunit = un
                Else
                    qunit = rd("unit").ToString
                End If

                If qunit = "C" Then
                    rmvpckg = rd("pckgc").ToString
                    nwqt = nwqty * IIf(rmvpckg > 0, rmvpckg, 1)
                ElseIf qunit = "B" Then
                    rmvpckg = rd("pckgb").ToString
                    nwqt = nwqty * IIf(rmvpckg > 0, rmvpckg, 1)
                ElseIf qunit = "P" Then
                    rmvpckg = rd("pckgp").ToString
                    nwqt = nwqty * IIf(rmvpckg > 0, rmvpckg, 1)
                    nwqt = nwqt
                End If

            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return nwqt
    End Function

    Public Function return_diff_to_whs(ByVal itm As String, ByVal qty As Decimal, ByVal whs1 As String, ByVal op As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0

        cqty = getcurqty(itm, whs1, "G")

        If op = "+" Then
            nqty = cqty + qty
        ElseIf op = "-" Then
            nqty = cqty - qty
        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        Return True
    End Function

    Public Function return_diff_to_whs_bo(ByVal itm As String, ByVal qty As Decimal, ByVal whs1 As String, ByVal op As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0

        cqty = getcurqty(itm, whs1, "B")

        If op = "+" Then
            nqty = cqty + qty
        ElseIf op = "-" Then
            nqty = cqty - qty
        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        Return True
    End Function
    Public Function update_currentwhs_for_transfer(ByVal itm As String, ByVal qty As Decimal, ByVal nw As Decimal, _
                                            ByVal pvwh As String, ByVal whs1 As String, ByVal whs2 As String, _
                                            ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        'WAREHOUSE 1
        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, pvwh)
        If pvwh <> Nothing and pvwh <> whs2  Then
            cqty = getcurqty(itm, pvwh, "G")
            If myoperator = "+" Then
                nqty = cqty + qty
            Else
                nqty = cqty - qty
            End If


            If fd = False Then

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                      "@it, @wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pvwh)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                                  "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pvwh)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If

        fd = False
        'WAREHOUSE 2 UPDATE
        If whs2 <> Nothing Then
            cqty = getcurqty(itm, whs2, "G")
            If qty > 0 Then
                nqty = (cqty - qty) + nw
            Else
                nqty = cqty + nw
            End If

            fd = checkitemiffound_in_whs(itm, whs2)
            If fd = False Then

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                      "@it, @wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", whs2)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                                  "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", whs2)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        End If

        'WAREHOUSE1 UPDATE

        cqty = getcurqty(itm, whs1, "G")
        If myoperator = "+" Then
            nqty = cqty + nw 'orig
        Else
            If cqty = nw Then
                nqty = cqty
            Else
                If nw = cqty Then
                    nqty = nw
                ElseIf nw > cqty Then
                    Dim nq As Decimal = 0
                    nq = nw - cqty
                    nqty = cqty + nq
                ElseIf cqty > nw Then
                    Dim nq As Decimal = 0
                    nq = cqty - nw
                    nqty = nq 'cqty - nq
                End If

            End If
        End If

        'nqty = cqty + qty
        'Else
        'nqty = cqty - qty
        'End If
        'If nw > cqty Then
        '    Dim nq As Decimal = 0
        '    nq = nw - cqty
        '    nqty = cqty + nq
        'ElseIf cqty > nw Then
        '    Dim nq1 As Decimal = 0
        '    nq1 = cqty - nw
        '    nqty = nq1 'cqty - nq
        'End If

        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Return True
    End Function
    Public Function update_currentwhs_1stockin(ByVal itm As String, ByVal qty As Decimal, ByVal nw As Decimal, _
                                            ByVal pvwh As String, ByVal whs1 As String, ByVal whs2 As String, _
                                            ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        'WAREHOUSE 1
        Dim fd As Boolean = False


        fd = False
        'WAREHOUSE 2 UPDATE
        'DAPAT NAA DRI

        'WAREHOUSE1 UPDATE

        cqty = getcurqty(itm, whs1, "G")

        If qty = nw Then
            If pvwh <> whs1 Then
                nqty = cqty + nw
            Else
                nqty = cqty
            End If

        Else
            'DECREASE INCREASE QUANTITY
            If qty > nw Then
                mq = qty - nw
                nqty = cqty - mq
            ElseIf nw > qty Then
                mq = nw - qty
                nqty = cqty + mq
            End If

        End If



        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Return True
    End Function
    Public Function update_currentwhs_1stockout(ByVal itm As String, ByVal qty As Decimal, ByVal nw As Decimal, _
                                            ByVal pvwh As String, ByVal whs1 As String, ByVal whs2 As String, _
                                            ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        'WAREHOUSE 1
        Dim fd As Boolean = False


        fd = False
        'WAREHOUSE 2 UPDATE


        'WAREHOUSE1 UPDATE

        cqty = getcurqty(itm, whs1, "G")

        If qty = nw Then
            If pvwh <> whs1 Then
                nqty = cqty - nw
            Else
                nqty = cqty
            End If

        Else
            'DECREASE INCREASE QUANTITY
            If qty > nw Then
                mq = qty - nw
                nqty = cqty + mq
            ElseIf nw > qty Then
                mq = nw - qty
                nqty = cqty - mq
            End If

        End If

        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Return True
    End Function
    Public Function update_currentwhs_1and2_bo(ByVal itm As String, ByVal qty As Decimal, ByVal nw As Decimal, _
                                            ByVal pvwh As String, ByVal whs1 As String, ByVal whs2 As String, _
                                            ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        'WAREHOUSE 1
        Dim fd As Boolean = False
        If pvwh <> Nothing Then
            cqty = getcurqty(itm, pvwh, "B")
            If myoperator = "+" Then
                nqty = cqty + qty
            Else
                nqty = cqty - qty
            End If



            fd = checkitemiffound_in_whs(itm, pvwh)
            If fd = False Then

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
                                      "@it, @wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pvwh)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                                  "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pvwh)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If

        fd = False

        'WAREHOUSE 2 UPDATE
        If whs2 <> Nothing Then
            cqty = getcurqty(itm, whs2, "B")
            nqty = cqty + nw
            fd = checkitemiffound_in_whs(itm, whs2)
            If fd = False Then

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
                                      "@it, @wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", whs2)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                                  "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", whs2)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

        End If
        'WAREHOUSE1 UPDATE
        fd = False
        cqty = getcurqty(itm, whs1, "B")
        If myoperator = "+" Then
            nqty = cqty + nw
        Else
            If cqty = nw Then
                nqty = cqty
            Else
                If nw > cqty Then
                    Dim nq As Decimal = 0

                    nq = nw - cqty
                    nqty = cqty + nq
                ElseIf cqty > nw Then
                    Dim nq As Decimal = 0

                    nq = cqty - nw
                    nqty = cqty - nq
                End If

            End If
        End If

        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Return True
    End Function

    Public Function update_currentwhs1(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, _
                                       ByVal whs2 As String, ByVal whs1 As String, ByVal nq As String, _
                                       ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        cqty = getcurqty(itm, whs1, "G")

      
        If qty = nwqty Then
            ' nqty = nwqty
            nqty = cqty
        ElseIf qty > nwqty Then
            If myoperator = "+" Then
                mq = qty + nwqty
            ElseIf myoperator = "-" Then
                mq = qty - nwqty
            Else
                mq = cqty - nwqty
            End If

            nqty = mq
        ElseIf qty < nwqty Then
            If myoperator = "+" Then
                mq = nwqty + qty
            ElseIf myoperator = "-" Then
                mq = nwqty - qty
            Else
                mq = cqty - nwqty

            End If

            nqty = mq
        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            nqty = nq
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        Return True
    End Function

    Public Function update_currentwhs_stockin(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, _
                                       ByVal whs2 As String, ByVal whs1 As String, ByVal nq As String, _
                                       ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        cqty = getcurqty(itm, whs1, "G")

     
        If qty = nwqty Then
            ' nqty = nwqty
            nqty = cqty
        ElseIf qty > nwqty Then
            If myoperator = "+" Then
                mq = qty + nwqty
            ElseIf myoperator = "-" Then
                mq = qty - nwqty
            End If

            nqty = mq
        ElseIf qty < nwqty Then
            If myoperator = "+" Then
                mq = nwqty + qty
            ElseIf myoperator = "-" Then
                mq = nwqty - qty
            End If

            nqty = cqty + mq
        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            nqty = nq
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        Return True
    End Function

    Public Function update_currentwhs_stockin_bo(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, _
                                       ByVal whs2 As String, ByVal whs1 As String, ByVal nq As String, _
                                       ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        cqty = getcurqty(itm, whs1, "B")

        If qty = nwqty Then
            ' nqty = nwqty
            nqty = cqty
        ElseIf qty > nwqty Then
            mq = qty + nwqty
            nqty = mq
        ElseIf qty < nwqty Then
            mq = nwqty - qty
            nqty = cqty + mq
        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            nqty = nq
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        Return True
    End Function

    'Added function for the stockout update
    Public Function update_currentwhs_stockout(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, _
                                      ByVal whs2 As String, ByVal whs1 As String, ByVal nq As String, _
                                      ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        cqty = getcurqty(itm, whs1, "G")

        'If qty = nwqty Then
        '    ' nqty = nwqty
        '    nqty = cqty
        'ElseIf qty > nwqty Then
        '    mq = qty - nwqty
        '    nqty = mq
        'ElseIf qty < nwqty Then
        '    mq = nwqty + qty
        '    nqty = cqty - mq
        'End If
        If qty = nwqty Then
            ' nqty = nwqty
            nqty = cqty
        ElseIf qty > nwqty Then
            If myoperator = "+" Then
                mq = qty + nwqty
            ElseIf myoperator = "-" Then
                mq = qty - nwqty
            End If

            nqty = mq
        ElseIf qty < nwqty Then
            If myoperator = "+" Then
                mq = nwqty + qty
                nqty = cqty + mq
            ElseIf myoperator = "-" Then
                mq = nwqty - qty
                nqty = cqty - mq
            End If

        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs1)
        If fd = False Then

            nqty = nq
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If

        Return True
    End Function

    Public Function update_currentwhs2(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, ByVal whs2 As String, ByVal nq As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        cqty = getcurqty(itm, whs2, "G")
        If qty = nwqty Then
            ' nqty = nwqty
            nqty = cqty
        ElseIf qty > nwqty Then
            mq = qty - nwqty
            nqty = cqty - mq
        ElseIf qty < nwqty Then
            mq = nwqty - qty
            nqty = cqty + mq
        End If

        Dim fd As Boolean = False
        fd = checkitemiffound_in_whs(itm, whs2)
        If fd = False Then
            nqty = nq
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                  "@it, @wh)", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs2)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                                  "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs2)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        Return True
    End Function

    Public Function checkitemiffound(ByVal pkn As String)
        Dim fn As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode FROM ivd WHERE pkno=@pno", cdb)
        cmd.Parameters.AddWithValue("@pno", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                fn = True
            End If
        End Using
        cmd.Dispose()
        Return fn
    End Function

    Public Function checkitemiffound_in_whs(ByVal itmc As String, ByVal wh As String)
        Dim fn As Boolean = False
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode FROM ivwh WHERE itemcode=@itm and whscode=@whs", cdb)
        cmd.Parameters.AddWithValue("@itm", itmc)
        cmd.Parameters.AddWithValue("@whs", wh)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                fn = True
            End If
        End Using
        cmd.Dispose()
        Return fn
    End Function

    Public Function check_if_item_is_found_intab(ByVal itm As String, ByVal mtb As String, ByVal wh As String, ByVal tn As String)
        Dim fn As Boolean = False

        Using cmd = New MySqlCommand("SELECT itemcode FROM " & mtb & " WHERE itemcode=@itmc AND whscode=@whs AND tno=@tn AND isdeleted='0'", cdb)
            cmd.Parameters.AddWithValue("@itmc", itm)
            cmd.Parameters.AddWithValue("@whs", wh)
            cmd.Parameters.AddWithValue("@tn", wh)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    fn = True
                End If
            End Using
            cmd.Dispose()
        End Using
        Return fn
    End Function

    Public Function update_currentwhs11(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, ByVal whs1 As String, ByVal pv As String, ByVal tt As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim nw_goodsqty As Decimal = 0
        Dim current_goodqty As Decimal = 0

        Dim op As String = Nothing
        Dim mq As Decimal = 0
        If tt = "G" Then
            cqty = getcurqty(itm, whs1, "G")
        ElseIf tt = "B" Then
            current_goodqty = getcurqty(itm, whs1, "G")
            cqty = getcurqty(itm, whs1, "B")
        End If


        If qty = nwqty Then
            'nqty = nwqty
            nqty = cqty
            nw_goodsqty = current_goodqty
        ElseIf qty > nwqty Then
            mq = qty - nwqty
            nqty = cqty - mq
            nw_goodsqty = current_goodqty + mq
        ElseIf qty < nwqty Then
            mq = nwqty - qty
            nqty = cqty + mq
            nw_goodsqty = current_goodqty - mq
        End If

        If tt = "G" Then
            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                            "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        ElseIf tt = "B" Then

            cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                           "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nw_goodsqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                                "WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@nwqty", nqty)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", whs1)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        Return True
    End Function

    Public Function update_currentwhs22(ByVal itm As String, ByVal qty As Decimal, _
                                        ByVal nwqty As Decimal, ByVal whs2 As String, _
                                        ByVal whs1 As String, ByVal pv As String, ByVal myoperator As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim nwhsqty As Decimal = 0

        Dim op As String = Nothing
        Dim mq As Decimal = 0
        'If previous warehouse was change, change old quantity
        'If pv <> Nothing Then
        nwhsqty = qty
        'Else
        ' nwhsqty = qty
        'End If

        cqty = getcurqty(itm, whs2, "G")
        If nwhsqty = nwqty Then
            ' nqty = nwqty
            If pv <> Nothing Then

                nqty = cqty + nwqty
            Else
                If cqty = 0 Then
                    nqty = nwqty
                Else
                    nqty = cqty
                End If
            End If
        ElseIf nwhsqty > nwqty Then
                mq = nwhsqty - nwqty
                nqty = cqty - mq
        ElseIf nwhsqty < nwqty Then
                mq = nwqty - nwhsqty
                nqty = cqty + mq
        End If

            'new warehouse
            Dim fd As Boolean = False
            If whs2 <> Nothing Then
                fd = checkitemiffound_in_whs(itm, whs2)

                If fd = False Then
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                          "@it, @wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                    cmd.Parameters.AddWithValue("@it", itm)
                    cmd.Parameters.AddWithValue("@wh", whs2)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                                          "WHERE itemcode=@it AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@nwqty", nqty)
                    cmd.Parameters.AddWithValue("@it", itm)
                    cmd.Parameters.AddWithValue("@wh", whs2)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            End If


            fd = False
        'return or add to warehouse1
        If whs1 <> Nothing Then
            cqty = 0
            nqty = 0
            cqty = getcurqty(itm, whs1, "G")

            If qty = nwqty Then
                'nqty = nwqty
                If cqty = 0 Then
                    nqty = nwqty
                Else
                    nqty = cqty
                End If
            ElseIf qty > nwqty Then
                mq = qty - nwqty

                nqty = cqty + mq
            ElseIf qty < nwqty Then
                mq = nwqty - qty
                If myoperator = "+" Then
                    nqty = cqty + mq
                Else
                    nqty = cqty - mq
                End If

            End If

            fd = False
            fd = checkitemiffound_in_whs(itm, whs1)
            If pv = Nothing Then
                If fd = False Then
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
                                          "@it, @wh)", cdb)
                    cmd.Parameters.AddWithValue("@nwqty", nqty)
                    cmd.Parameters.AddWithValue("@it", itm)
                    cmd.Parameters.AddWithValue("@wh", whs1)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                                     "WHERE itemcode=@it AND whscode=@wh", cdb)
                    cmd.Parameters.AddWithValue("@nwqty", nqty)
                    cmd.Parameters.AddWithValue("@it", itm)
                    cmd.Parameters.AddWithValue("@wh", whs1)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            End If
        End If
           


            Return True
    End Function

    Public Function update_currentwhs22RICHEL(ByVal itm As String, ByVal qty As Decimal, _
                                       ByVal nwqty As Decimal, ByVal whs2 As String, _
                                       ByVal whs1 As String, ByVal pv As String, ByVal myoperator As String, ByVal old_item_qty As Decimal)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim nwhsqty As Decimal = 0

        Dim op As String = Nothing
        Dim mq As Decimal = 0
        'If previous warehouse was change, change old quantity
        'If pv <> Nothing Then
        '    nwhsqty = nwqty
        'Else
        '    nwhsqty = nwqty 'new quantity gyud (dili qty only)
        'End If

        cqty = getcurqty(itm, whs1, "G") 'current qty sa warehouse
        'If nwhsqty = nwqty Then
        '    ' nqty = nwqty
        '    If pv <> Nothing Then

        '        nqty = cqty + nwqty
        '    Else
        '        If cqty = 0 Then
        '            nqty = nwqty
        '        Else
        '            nqty = cqty
        '        End If
        '    End If
        'ElseIf nwhsqty > nwqty Then
        '    mq = nwhsqty - nwqty
        '    nqty = cqty - mq
        'ElseIf nwhsqty < nwqty Then
        '    mq = nwqty - nwhsqty
        '    nqty = cqty + mq
        'End If

      '  old_item_qty = convertpackaging_fromivitem(itm, pkn, oqty, old_item_unit) '300

        If old_item_qty = nwqty Then
            'wala pani ha
            'dapat walay nahitabo
            nqty = cqty
        ElseIf nwqty > old_item_qty Then
            'add
            nqty = cqty - nwqty
            ' nwq = old_item_qty - nwqty
        ElseIf nwqty < old_item_qty Then
            'minus
            nqty = cqty + nwqty
            '  nwq = nwq - old_item_qty
        End If

        'If nwqty < curqty Then
        '    nwqty = curqty - totalqty
        'ElseIf nwqty > curqty Then
        '    nwqty = curqty + totalqty
        'End If

        'new warehouse
        Dim fd As Boolean = False
        'If whs2 <> Nothing Then
        '    fd = checkitemiffound_in_whs(itm, whs2)

        '    If fd = False Then
        '        Dim cmd As MySqlCommand
        '        cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
        '                              "@it, @wh)", cdb)
        '        cmd.Parameters.AddWithValue("@nwqty", nwqty)
        '        cmd.Parameters.AddWithValue("@it", itm)
        '        cmd.Parameters.AddWithValue("@wh", whs2)
        '        cmd.ExecuteNonQuery()
        '        cmd.Dispose()
        '    Else
        '        Dim cmd As MySqlCommand
        '        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
        '                              "WHERE itemcode=@it AND whscode=@wh", cdb)
        '        cmd.Parameters.AddWithValue("@nwqty", nqty)
        '        cmd.Parameters.AddWithValue("@it", itm)
        '        cmd.Parameters.AddWithValue("@wh", whs2)
        '        cmd.ExecuteNonQuery()
        '        cmd.Dispose()
        '    End If
        'End If


        'fd = False
        ''return or add to warehouse1
        'cqty = 0
        'nqty = 0
        'cqty = getcurqty(itm, whs1, "G")

        'If qty = nwqty Then
        '    'nqty = nwqty
        '    nqty = cqty
        'ElseIf qty > nwqty Then
        '    mq = qty - nwqty
        '    nqty = cqty - mq
        'ElseIf qty < nwqty Then
        '    mq = nwqty - qty
        '    If myoperator = "+" Then
        '        nqty = cqty + mq
        '    Else
        '        nqty = cqty - mq
        '    End If

        'End If

        'fd = False
        'fd = checkitemiffound_in_whs(itm, whs1)
        'If fd = False Then
        '    Dim cmd As MySqlCommand
        '    cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty, " & _
        '                          "@it, @wh)", cdb)
        '    cmd.Parameters.AddWithValue("@nwqty", nqty)
        '    cmd.Parameters.AddWithValue("@it", itm)
        '    cmd.Parameters.AddWithValue("@wh", whs1)
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'Else
        '    cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
        '                     "WHERE itemcode=@it AND whscode=@wh", cdb)
        '    cmd.Parameters.AddWithValue("@nwqty", nqty)
        '    cmd.Parameters.AddWithValue("@it", itm)
        '    cmd.Parameters.AddWithValue("@wh", whs1)
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'End If
        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                             "WHERE itemcode=@it AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@nwqty", nqty)
        cmd.Parameters.AddWithValue("@it", itm)
        cmd.Parameters.AddWithValue("@wh", whs1)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Return True
    End Function

    Public Function update_currentwhs22_bo(ByVal itm As String, ByVal qty As Decimal, _
                                        ByVal nwqty As Decimal, ByVal whs2 As String, _
                                        ByVal whs1 As String, ByVal pv As String, ByVal myoperator As String)



        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim nwhsqty As Decimal = 0

        Dim op As String = Nothing
        Dim mq As Decimal = 0
        'If previous warehouse was change, change old quantity
        'If pv <> Nothing Then
        nwhsqty = qty
        'Else
        ' nwhsqty = qty
        'End If

        cqty = getcurqty(itm, whs2, "B")
        If nwhsqty = nwqty Then
            ' nqty = nwqty
            If pv <> Nothing Then

                nqty = cqty + nwqty
            Else
                If cqty = 0 Then
                    nqty = nwqty
                Else
                    nqty = cqty
                End If
            End If
        ElseIf nwhsqty > nwqty Then
            mq = nwhsqty - nwqty
            nqty = cqty - mq
        ElseIf nwhsqty < nwqty Then
            mq = nwqty - nwhsqty
            nqty = cqty + mq
        End If

        'new warehouse
        Dim fd As Boolean = False
        If whs2 <> Nothing Then
            fd = checkitemiffound_in_whs(itm, whs2)

            If fd = False Then
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
                                      "@it, @wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", whs2)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                                      "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", whs2)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If


        fd = False
        'return or add to warehouse1
        'If pv = Nothing Then
        '    cqty = 0
        '    nqty = 0
        '    cqty = getcurqty(itm, whs1, "B")

        '    If qty = nwqty Then
        '        'nqty = nwqty
        '        If cqty = 0 Then
        '            nqty = nwqty
        '        Else
        '            nqty = cqty
        '        End If
        '    ElseIf qty > nwqty Then
        '        mq = qty - nwqty

        '        nqty = cqty + mq
        '    ElseIf qty < nwqty Then
        '        mq = nwqty - qty
        '        If myoperator = "+" Then
        '            nqty = cqty + mq
        '        Else
        '            nqty = cqty - mq
        '        End If

        '    End If

        '    fd = False
        '    fd = checkitemiffound_in_whs(itm, whs1)
        '    If pv = Nothing Then
        '        If fd = False Then
        '            Dim cmd As MySqlCommand
        '            cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty, " & _
        '                                  "@it, @wh)", cdb)
        '            cmd.Parameters.AddWithValue("@nwqty", nqty)
        '            cmd.Parameters.AddWithValue("@it", itm)
        '            cmd.Parameters.AddWithValue("@wh", whs1)
        '            cmd.ExecuteNonQuery()
        '            cmd.Dispose()
        '        Else
        '            cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
        '                             "WHERE itemcode=@it AND whscode=@wh", cdb)
        '            cmd.Parameters.AddWithValue("@nwqty", nqty)
        '            cmd.Parameters.AddWithValue("@it", itm)
        '            cmd.Parameters.AddWithValue("@wh", whs1)
        '            cmd.ExecuteNonQuery()
        '            cmd.Dispose()
        '        End If
        '    End If
        'End If



        Return True
    End Function

    Public Function getolditemdetails(ByVal itm As String, ByVal pkn As String) As String()
        Dim qunit As String = Nothing
        Dim olditm As String = Nothing

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode,qty,pckg,qunit FROM ivd WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                olditm = rd("itemcode").ToString
                qunit = rd("qunit").ToString

            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Dim oldqty As Decimal = 0
        oldqty = getoldqtyfrmtable(itm, pkn, "ivd")

        Return New String() {olditm, qunit, oldqty}
    End Function

    Public Function getolditem(ByVal pkn As String)
        Dim olditm As String = Nothing

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT itemcode,qty,pckg,qunit FROM ivd WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                olditm = rd("itemcode").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return olditm
    End Function

    Public Function getolditemunit(ByVal itm As String, ByVal pkn As String, ByVal mytab As String)
        Dim qunit As String = Nothing

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT qty,pckg,qunit FROM " & mytab & " WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                qunit = rd("qunit").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return qunit
    End Function

    Public Function getolditem_qty(ByVal itm As String, ByVal pkn As String)
        Dim qty As String = Nothing

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT qty,pckg,qunit FROM ivd WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()

                qty = rd("qty").ToString

            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return qty
    End Function

    Public Function getoldqtyfrmtable(ByVal itm As String, ByVal pkn As String, ByVal mytable As String)
        Dim oldq As Decimal = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT qty,pckg,qunit FROM " & mytable & " WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                Dim qunit As String = Nothing
                oldq = rd("qty").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return oldq
    End Function
    Public Function getolditempckg(ByVal itm As String, ByVal pkn As String, ByVal mytable As String)
        Dim oldpkg As Decimal = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT qty,pckg,qunit FROM " & mytable & " WHERE pkno=@pk", cdb) 'item=@it AND whs=@wh", cdb)
        'cmd.Parameters.AddWithValue("@im", itm)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                Dim qunit As String = Nothing
                oldpkg = rd("pckg").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return oldpkg
    End Function
    Public Function update_tab_open(ByVal trno As String, ByVal mytab As String, ByVal systemuser As String)
        Using cmd = New MySqlCommand("UPDATE " & mytab & " SET isopen='1', isopenby=@user WHERE transno = @tno", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            cmd.Parameters.AddWithValue("@user", systemuser)
            cmd.ExecuteNonQuery()
        End Using
        Return True
    End Function
    Public Function check_if_trans_is_open(ByVal trno As String, ByVal mytab As String, ByVal systemuser As String) As String()
        Dim isopen As Integer = 0
        Dim fnd As Boolean = False
        Dim open_by As String = Nothing

        Using cmd = New MySqlCommand("SELECT isopen,isopenby FROM " & mytab & " WHERE transno=@tno AND isopen='1'", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    open_by = rd("isopenby").ToString
                    fnd = True
                End If
            End Using
            cmd.Dispose()
        End Using

        If fnd = False Then
            update_tab_open(trno, mytab, systemuser)
        Else
            If open_by = _user Then
                fnd = False
                update_tab_open(trno, mytab, systemuser)
            End If
        End If
        Return New String() {fnd, open_by}
    End Function

    Public Function close_open_trans_by_user(ByVal trno As String, ByVal mytab As String, ByVal systemuser As String)
        Dim fnd As Boolean = False

        Using cmd = New MySqlCommand("SELECT isopen,isopenby FROM " & mytab & " WHERE transno=@tno AND isopen='1' and isopenby=@usr", cdb)
            cmd.Parameters.AddWithValue("@tno", trno)
            cmd.Parameters.AddWithValue("@usr", systemuser)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    fnd = True
                End If
            End Using
            cmd.Dispose()
        End Using

        If fnd = True Then
            Using cmd = New MySqlCommand("UPDATE " & mytab & " SET isopen='0'  WHERE transno = @tno AND isopenby=@user", cdb)
                cmd.Parameters.AddWithValue("@tno", trno)
                cmd.Parameters.AddWithValue("@user", systemuser)
                cmd.ExecuteNonQuery()
            End Using
        End If
        Return fnd
    End Function

    Public Function convert_item_to_pcs(ByVal qty As Decimal, ByVal pckging As Decimal)
        Dim totalq As Decimal = 0
        totalq = qty * pckging

        Return totalq
    End Function
    Public Function get_item_variance(ByVal trno As String, ByVal itm As String, ByVal qty As Decimal, ByVal whse As String, _
                                      ByVal pckc As Decimal, ByVal pckb As Decimal, ByVal p_tdate As Date, _
                                     ByVal ttype As String)
        Dim current_qty As Decimal = 0

        Dim myfield As String = Nothing
        If ttype = "G" Then
            myfield = "qty_good"
        ElseIf ttype = "B" Then
            myfield = "qty_bo"
        End If

        Using cmd = New MySqlCommand("SELECT * FROM ivwh WHERE itemcode=@itmc AND whscode=@whs", cdb)
            cmd.Parameters.AddWithValue("@itmc", itm)
            cmd.Parameters.AddWithValue("@whs", whse)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    rd.Read()
                    current_qty = rd(myfield).ToString
                End If
            End Using
        End Using

        ' Dim tdate As Date
        ' tdate = gettime2(3)

        Dim var_qty As Decimal = 0
        var_qty = current_qty - qty


        Using cmd = New MySqlCommand("INSERT INTO phyiva(transno,whscode,tdate,itemcode,qty,pckgc,pckgb,variance) VALUES(@trn,@whs,@tdet,@itmc,@qt,@pckc,@pckb,@vrn)", cdb)
            cmd.Parameters.AddWithValue("@trn", trno)
            cmd.Parameters.AddWithValue("@whs", whse)
            cmd.Parameters.AddWithValue("@tdet", p_tdate)
            cmd.Parameters.AddWithValue("@itmc", itm)
            cmd.Parameters.AddWithValue("@qt", qty)
            cmd.Parameters.AddWithValue("@pckc", pckc)
            cmd.Parameters.AddWithValue("@pckb", pckb)
            cmd.Parameters.AddWithValue("@vrn", var_qty)

            cmd.ExecuteNonQuery()
        End Using

        Return True
    End Function
    Public Function set_progressbar_max(ByVal mx As Integer, ByVal newval As Integer, ByVal st As Integer, ByVal btype As String)
        With MDIParent1.pbMain
            If st = 1 Then
                .Maximum = mx
                .Visible = True
                .Value = 0

            ElseIf st = 2 Then

                'If btype = "I" Then
                '    .Value += 1
                'ElseIf btype = "B" Then
                .Value += 1

                ' End If

            Else
                .Maximum = 0
                .Value = 0
                .Visible = False
            End If

            .Refresh()
        End With


        Return True

    End Function
    Public Function get_max_record_count(ByVal sqlq As String, ByVal item As String, ByVal whs As String, ByVal tdate As Date)
        Dim rcnt As Integer = 0
        Using rc = New MySqlCommand(sqlq, cdb)
            rc.Parameters.AddWithValue("@itm", item)
            rc.Parameters.AddWithValue("@mywhs", whs)
            rc.Parameters.AddWithValue("@mydate", tdate)
            Using rd As MySqlDataReader = rc.ExecuteReader
                If rd.HasRows Then
                    rd.Read()
                    rcnt = rd("recordcount").ToString
                End If
            End Using
        End Using

        Return rcnt
    End Function
    Function myi(str As String) As Integer
        myi = Replace(str, ",", "")
        If myi = Nothing Then
            myi = 0
        End If
        Return myi
    End Function
    Public Function update_warehouse_qty(ByVal itm As String, ByVal qty As Decimal, ByVal whs As String, ByVal ttype As String)
        Dim fnd As Boolean = False
        Dim myfield As String = Nothing
        If ttype = "G" Then
            myfield = "qty_good"
        ElseIf ttype = "B" Then
            myfield = "qty_bo"
        End If

        Dim tabname As String = "ivwh" & Format(Now, "MMddyyy_htt")
        Dim tabexists As Boolean = False
        Using cmd = New MySqlCommand("SHOW TABLES LIKE '" & tabname & "'", cdb)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    tabexists = True
                End If
            End Using
        End Using

        If tabexists = False Then
            Using cmd = New MySqlCommand("CREATE TABLE " & tabname & " LIKE ivwh", cdb)
                cmd.ExecuteNonQuery()
            End Using
            Using cmd = New MySqlCommand("INSERT INTO " & tabname & " SELECT * FROM ivwh", cdb)
                cmd.ExecuteNonQuery()
            End Using
        End If

        If check_if_item_in_whs(itm, whs) = True Then


            Using cmd = New MySqlCommand("UPDATE ivwh SET " & myfield & " =@nwqty WHERE itemcode=@itmc AND whscode=@whs", cdb)
                cmd.Parameters.AddWithValue("@nwqty", qty)
                cmd.Parameters.AddWithValue("@itmc", itm)
                cmd.Parameters.AddWithValue("@whs", whs)
                Using rd As MySqlDataReader = cmd.ExecuteReader
                    If rd.HasRows = True Then
                        fnd = True
                    End If
                End Using
            End Using

            If tabexists = True Then

                Using cmd = New MySqlCommand("UPDATE " & tabname & " SET " & myfield & " =@nwqty WHERE itemcode=@itmc AND whscode=@whs", cdb)
                    cmd.Parameters.AddWithValue("@nwqty", qty)
                    cmd.Parameters.AddWithValue("@itmc", itm)
                    cmd.Parameters.AddWithValue("@whs", whs)
                    Using rd As MySqlDataReader = cmd.ExecuteReader
                        If rd.HasRows = True Then
                            fnd = True
                        End If
                    End Using
                End Using
            End If
        Else
            Using cmd = New MySqlCommand("INSERT INTO ivwh(itemcode," & myfield & ",whscode) VALUES(@itmc,@nwqty,@whs)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", qty)
                cmd.Parameters.AddWithValue("@itmc", itm)
                cmd.Parameters.AddWithValue("@whs", whs)
                cmd.ExecuteNonQuery()
            End Using
        End If
        Return True
    End Function
    Public Function check_if_item_in_whs(ByVal itm As String, ByVal whs As String)
        Dim fnd As Boolean = False
        Using cmd = New MySqlCommand("SELECT itemcode FROM ivwh WHERE itemcode=@itmc AND whscode=@whs", cdb)
            cmd.Parameters.AddWithValue("@itmc", itm)
            cmd.Parameters.AddWithValue("@whs", whs)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows = True Then
                    fnd = True
                End If
            End Using
        End Using
        Return fnd
    End Function
    Public Function update_currentwhs(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, ByVal whs2 As String, ByVal whs1 As String, ByVal pv As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim op As String = Nothing
        Dim mq As Decimal = 0

        cqty = getcurqty(itm, whs2, "G")
        If qty = nwqty Then
            ' nqty = nwqty
            If pv <> Nothing Then

                nqty = cqty + nwqty
            Else
                If cqty = 0 Then
                    nqty = nwqty
                Else
                    nqty = cqty
                End If
            End If
        ElseIf qty > nwqty Then
            mq = qty - nwqty
            nqty = cqty - mq
        ElseIf qty < nwqty Then
            mq = nwqty - qty
            nqty = cqty + mq
        End If

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@nwqty", nqty)
        cmd.Parameters.AddWithValue("@it", itm)
        cmd.Parameters.AddWithValue("@wh", whs2)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        cqty = 0
        nqty = 0
        cqty = getcurqty(itm, whs1, "G")

        If qty = nwqty Then
            'nqty = nwqty
            nqty = cqty
        ElseIf qty > nwqty Then
            mq = qty - nwqty
            nqty = cqty + mq
        ElseIf qty < nwqty Then
            mq = nwqty - qty
            nqty = cqty - mq
        End If

        cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                              "WHERE itemcode=@it AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@nwqty", nqty)
        cmd.Parameters.AddWithValue("@it", itm)
        cmd.Parameters.AddWithValue("@wh", whs1)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        Return True
    End Function

    Public Function getcurqty_from_detail(ByVal pkn As String, ByVal mytab As String)
        Dim old_qty As Decimal = 0
        cmd = New MySqlCommand("SELECT qty FROM " & mytab & " WHERE pkno=@pk", cdb)
        cmd.Parameters.AddWithValue("@pk", pkn)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                old_qty = rd("qty").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return old_qty
    End Function

    Public Function getcurqty(ByVal itm As String, ByVal whs As String, ByVal ttype As String)
        Dim curqty As Decimal = 0
        cmd = New MySqlCommand("SELECT itemcode,qty_good,qty_bo FROM ivwh WHERE itemcode=@itm AND whscode=@wh", cdb)
        cmd.Parameters.AddWithValue("@itm", itm)
        cmd.Parameters.AddWithValue("@wh", whs)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                If ttype = "G" Then
                    curqty = rd("qty_good").ToString
                ElseIf ttype = "B" Then
                    curqty = rd("qty_bo").ToString
                End If

            End If
            rd.Close()
        End Using
        cmd.Dispose()
        Return curqty
    End Function

    Function updateprevwhs(ByVal itm As String, ByVal qty As Decimal, ByVal nwqty As Decimal, ByVal op As String, ByVal pwhs As String, ByVal tt As String)

        Dim cqty As Decimal = 0
        Dim nqty As Decimal = 0
        Dim new_goodsqty As Decimal = 0
        Dim current_goodsqty As Decimal = 0
        If tt = "G" Then
            cqty = getcurqty(itm, pwhs, "G")
        ElseIf tt = "B" Then
            current_goodsqty = getcurqty(itm, pwhs, "G")
            cqty = getcurqty(itm, pwhs, "B")
        End If

        If op = "-" Then
            nqty = cqty - qty
            new_goodsqty = current_goodsqty + qty
        ElseIf op = "+" Then
            nqty = cqty + qty
            new_goodsqty = current_goodsqty - qty
        End If

        Dim cmd As MySqlCommand
        Dim whsfnd As Boolean = False
        If tt = "G" Then


            cmd = New MySqlCommand("SELECT itemcode FROM ivwh WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", pwhs)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    whsfnd = True
                End If
            End Using
            cmd.Dispose()

            If whsfnd = True Then
                cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
                            "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pwhs)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_good,itemcode,whscode) VALUES(@nwqty,@it,@wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pwhs)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


        ElseIf tt = "B" Then
            'cmd = New MySqlCommand("UPDATE ivwh SET qty_good=@nwqty " & _
            '                "WHERE itemcode=@it AND whscode=@wh", cdb)
            'cmd.Parameters.AddWithValue("@nwqty", new_goodsqty)
            'cmd.Parameters.AddWithValue("@it", itm)
            'cmd.Parameters.AddWithValue("@wh", pwhs)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()

            'cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
            '                "WHERE itemcode=@it AND whscode=@wh", cdb)
            'cmd.Parameters.AddWithValue("@nwqty", nqty)
            'cmd.Parameters.AddWithValue("@it", itm)
            'cmd.Parameters.AddWithValue("@wh", pwhs)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()


            cmd = New MySqlCommand("SELECT itemcode FROM ivwh WHERE itemcode=@it AND whscode=@wh", cdb)
            cmd.Parameters.AddWithValue("@it", itm)
            cmd.Parameters.AddWithValue("@wh", pwhs)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    whsfnd = True
                End If
            End Using
            cmd.Dispose()

            If whsfnd = True Then
                cmd = New MySqlCommand("UPDATE ivwh SET qty_bo=@nwqty " & _
                            "WHERE itemcode=@it AND whscode=@wh", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pwhs)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                cmd = New MySqlCommand("INSERT INTO ivwh(qty_bo,itemcode,whscode) VALUES(@nwqty,@it,@wh)", cdb)
                cmd.Parameters.AddWithValue("@nwqty", nqty)
                cmd.Parameters.AddWithValue("@it", itm)
                cmd.Parameters.AddWithValue("@wh", pwhs)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If

        Return True
    End Function

    Function getoldqtyfrmwh(ByVal itm As String, ByVal pckg As String, ByVal whs As String)
        Dim oldq As Decimal = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT qty_good FROM ivwh WHERE itemcode=@it AND whscode=@wh", cdb)
        ' cmd.Parameters.AddWithValue("@tr", itm) 'old
        cmd.Parameters.AddWithValue("@it", itm)
        cmd.Parameters.AddWithValue("@wh", whs)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                oldq = rd("qty_good").ToString
            End If
            rd.Close()
        End Using
        cmd.Dispose()

        Return oldq
    End Function

    Public Function EncryptData(ByVal plaintext As String) As String
        On Error GoTo err
        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)

        Dim myenc As String = Nothing

        Dim sPlainText As String = plaintext
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            myenc = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If

        Return myenc

err:
        If Err.Number Then
            'MsgBox(Err.Description)
            Dim x As String = Nothing
            Return x
        End If

    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String
        On Error GoTo err

        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)

        Dim mydepc As String = Nothing

        Dim cypherTextBytes As Byte() = Convert.FromBase64String(encryptedtext)
        Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes(cypherTextBytes.Length) As Byte
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        mydepc = enc.GetString(plainTextBytes, 0, decryptedByteCount)

        Return mydepc

err:
        If Err.Number Then
            ' Return False
            'MsgBox(Err.Description)
            Dim x As String = Nothing
            Return x
        End If
    End Function


    Public Sub condb()
        Try
            Dim sFileName As String
            Dim x As Integer = 0

            seldbname = "sims"
            sFileName = Application.StartupPath & "\" & "ips.txt"


            Dim myun As String = Nothing
            Dim mypd As String = Nothing

            For Each line As String In File.ReadLines(sFileName)
                x += 1
                If x = 1 Then
                    mysvrip = line
                ElseIf x = 2 Then
                    myun = line
                ElseIf x = 3 Then
                    mypd = line
                End If
            Next
            cString = "Server=" & mysvrip & "; User Id=" & myun & "; Password= " & mypd & "; Database=" & seldbname & ";pooling=false;Convert Zero Datetime=True;Allow Zero Datetime=True"
            cdb = New MySqlConnection(cString)
            cdb.Open()

            'MDIParent1.status1.Text = "Connected to Server!"
            'MDIParent1.status1.ForeColor = Color.Green
            'MDIParent1.Time_Server.Enabled = True
        Catch ex As Exception
            'MDIParent1.status1.Text = "Error Connecting to Server " & ex.Message.ToString
            'MDIParent1.status1.ForeColor = Color.Red
        End Try
    End Sub
    Public Function show_form_item_search(ByVal tag As String, ByVal ftext As String)
        frmSearchItem.Tag = "StockCard"
        frmSearchItem.Text = "Stock Card"
        frmSearchItem.ShowDialog()
        Return True
    End Function
    Public Sub condb2()
        'Try
        '    cdb2 = New MySqlConnection(cString2)
        '    KCCMain.sts2.Text = "Connected to Server!"
        '    KCCMain.sts2.ForeColor = Color.Blue
        '    KCCMain.Time_Server.Enabled = True
        'Catch ex As Exception
        '    KCCMain.sts2.Text = "Error Connecting to Server " & ex.Message.ToString
        '    KCCMain.sts2.ForeColor = Color.Red
        'End Try
    End Sub

    Public Function cmdb(ByVal mp As String) As Boolean
        Try
            Dim mpath As String = Nothing
            mpath = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" + Strings.LCase(mp) + ";Jet OLEDB:Database Password=mxx6re"
            adb = New OleDbConnection(mpath)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try
        Return True
    End Function

    Function centerme(cobject)
        Dim xx As Integer = CInt((cobject.ClientSize.Width / 2) - (cobject.Width / 2))
        Dim yy As Integer = CInt((cobject.ClientSize.Height / 2) - (cobject.Height / 2))
        cobject.Location = New Point(xx, yy)
        Return cobject
    End Function


    Public Sub center_animated_progress(ByVal stype As Integer)
        With MDIParent1

            frmprogress.Tag = stype
            frmprogress.ShowDialog()

        End With
    End Sub
    Public Sub center_animated_progress_hide()
        'With MDIParent1
        'Using f2 As New frmprogress
        '    f2.Dispose()
        '    f2.Close()
        'End Using
        frmprogress.Close()
        frmprogress.Hide()
        frmprogress.Dispose()
        'End With
    End Sub
    Public Sub closeallchild()
        For Each frm As Form In MDIParent1.MdiChildren()
            frm.Close()
        Next
    End Sub
    'Public Function returndata(ByVal d As String)
    '    'frmotransac.tbsemp.Text = d
    '    'Return True
    'End Function

    Public Function Byte2Image(ByVal ByteArr() As Byte) As Image
        'will turn a byte array to an image
        Dim ImageStream As MemoryStream

        Try
            If ByteArr.GetUpperBound(0) > 0 Then
                ImageStream = New MemoryStream(ByteArr)
                Return Image.FromStream(ImageStream)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function getdate()
        Dim dtms As String = Nothing
        Dim qy As String = Nothing
        Dim cg As New MySqlCommand
        Dim gndnw As MySqlDataReader
        qy = "SELECT DATE_FORMAT(CURDATE(),'%Y-%m-%d') mdate"
        cg = New MySqlCommand(qy, cdb)
        gndnw = cg.ExecuteReader()
        If gndnw.HasRows = True Then
            gndnw.Read()
            dtms = gndnw("mdate")
        End If
        gndnw.Dispose()
        cg.Dispose()

        Return dtms

    End Function

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

    Function rpchar(ByVal mstr, ByVal crev)
        Return mstr.Replace(crev, "")
    End Function

    Public Function gettime2(ByVal x As Integer)
        Dim dtm2 As String = Nothing
        Dim qy As String = Nothing
        Dim cg2 As New MySqlCommand

        qy = "SELECT DATE_FORMAT(CURDATE(),'%Y-%m-%d') mdate,DATE_FORMAT(CURDATE(),'%b %e, %Y') formaldate,TIME_FORMAT(CURTIME(),'%h:%i:%s %p') mtime"
        cg2 = New MySqlCommand(qy, cdb)
        Using nwgdr2 As MySqlDataReader = cg2.ExecuteReader()
            If nwgdr2.HasRows = True Then
                nwgdr2.Read()
                If x = 1 Then
                    dtm2 = nwgdr2("mtime")
                ElseIf x = 2 Then
                    dtm2 = nwgdr2("formaldate")
                ElseIf x = 3 Then
                    dtm2 = nwgdr2("mdate")
                End If
            End If
            nwgdr2.Close()
            nwgdr2.Dispose()
        End Using

        cg2.Dispose()

        Return dtm2
    End Function

    Public Function gettime(ByVal x As Integer)
        Dim dtm As String = Nothing
        Dim qy As String = Nothing
        Dim cg As New MySqlCommand
        Dim gdr As MySqlDataReader
        qy = "SELECT DATE_FORMAT(CURDATE(),'%Y-%m-%d') mdate,DATE_FORMAT(CURDATE(),'%b %e, %Y') formaldate,TIME_FORMAT(CURTIME(),'%h:%i:%s %p') mtime"
        cg = New MySqlCommand(qy, cdb)
        gdr = cg.ExecuteReader()
        If gdr.HasRows = True Then
            gdr.Read()
            If x = 1 Then
                dtm = gdr("mtime")
            ElseIf x = 2 Then
                dtm = gdr("formaldate")
            ElseIf x = 3 Then
                dtm = gdr("mdate")
            End If
        End If
        gdr.Dispose()
        cg.Dispose()

        Return dtm
    End Function

    Public Function GetCurrentAge(ByVal dob As Date) As String
        Dim CurrentDate, Years, ThisYear, Months, ThisMonth, Days
        CurrentDate = CDate(dob)
        Years = DateDiff("yyyy", CurrentDate, Now.Date)
        ThisYear = DateAdd("yyyy", Years, CurrentDate)
        Months = DateDiff("m", ThisYear, Now.Date)
        ThisMonth = DateAdd("m", Months, ThisYear)
        Days = DateDiff("d", ThisMonth, Now.Date)

        Do While (Days < 0) Or (Months < 0)
            If Days < 0 Then
                Months = Months - 1
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
            If Months < 0 Then
                Years = Years - 1
                ThisYear = DateAdd("yyyy", Years, CurrentDate)
                Months = DateDiff("m", ThisYear, Now.Date)
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
        Loop

        Dim gys As String = Nothing
        gys = Years & "Y/" & Months & "M/" & Days & "D/"
        Return gys
    End Function

    Public Function GetYears(ByVal dob As Date) As String
        Dim CurrentDate, Years, ThisYear, Months, ThisMonth, Days
        CurrentDate = CDate(dob)
        Years = DateDiff("yyyy", CurrentDate, Now.Date)
        ThisYear = DateAdd("yyyy", Years, CurrentDate)
        Months = DateDiff("m", ThisYear, Now.Date)
        ThisMonth = DateAdd("m", Months, ThisYear)
        Days = DateDiff("d", ThisMonth, Now.Date)

        Do While (Days < 0) Or (Months < 0)
            If Days < 0 Then
                Months = Months - 1
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
            If Months < 0 Then
                Years = Years - 1
                ThisYear = DateAdd("yyyy", Years, CurrentDate)
                Months = DateDiff("m", ThisYear, Now.Date)
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
        Loop

        Dim gys As String = Nothing
        gys = Years
        Return gys
    End Function

    Public Function GetMonths(ByVal dob As Date) As String
        Dim CurrentDate, Years, ThisYear, Months, ThisMonth, Days
        CurrentDate = CDate(dob)
        Years = DateDiff("yyyy", CurrentDate, Now.Date)
        ThisYear = DateAdd("yyyy", Years, CurrentDate)
        Months = DateDiff("m", ThisYear, Now.Date)
        ThisMonth = DateAdd("m", Months, ThisYear)
        Days = DateDiff("d", ThisMonth, Now.Date)

        Do While (Days < 0) Or (Months < 0)
            If Days < 0 Then
                Months = Months - 1
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
            If Months < 0 Then
                Years = Years - 1
                ThisYear = DateAdd("yyyy", Years, CurrentDate)
                Months = DateDiff("m", ThisYear, Now.Date)
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
        Loop
        Dim gys As String = Nothing
        gys = Months
        Return gys
    End Function

    Public Function GetYearofService(ByVal dob As Date) As String
        Dim CurrentDate, Years, ThisYear, Months, ThisMonth, Days
        CurrentDate = CDate(dob)
        Years = DateDiff("yyyy", CurrentDate, Now.Date)
        ThisYear = DateAdd("yyyy", Years, CurrentDate)
        Months = DateDiff("m", ThisYear, Now.Date)
        ThisMonth = DateAdd("m", Months, ThisYear)
        Days = DateDiff("d", ThisMonth, Now.Date)

        Do While (Days < 0) Or (Months < 0)
            If Days < 0 Then
                Months = Months - 1
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
            If Months < 0 Then
                Years = Years - 1
                ThisYear = DateAdd("yyyy", Years, CurrentDate)
                Months = DateDiff("m", ThisYear, Now.Date)
                ThisMonth = DateAdd("m", Months, ThisYear)
                Days = DateDiff("d", ThisMonth, Now.Date)
            End If
        Loop
        Dim gys As String = Nothing
        gys = Years & "Y/" & Months & "M/" & Days & "D/"
        Return gys
    End Function

    Function savelogs(ByVal mystrng As String)
        Dim mstrn() As String = Nothing
        mstrn = mystrng.Split("-")
        'db.Execute("INSERT INTO userlogs(userid,emp_no,Remarks,tdate) VALUES('" & mstrn(0) & "', '" & mstrn(1) & "','" & mstrn(2) & "','" & getdatetime(1) & "')")
        Return True
    End Function

    ' Function focusontab(ByVal tpname As String)
    'For Each tp As TabPage In MDIParent1.mytab.TabPages
    '    If tp.Name = tpname Then
    '        KCCMain.mytab.SelectTab(tp)
    '        seltabindex = KCCMain.mytab.SelectedIndex
    '        Exit For
    '    End If
    'Next
    'Return True
    ' End Function
    ' Function addnewtab(ByVal tb As TabPage, ByVal fm As Form, ByVal fn As String)
    'ntpg = New TabPage(fn)
    'ntpg.Name = fn
    'fm.Visible = True
    'fm.FormBorderStyle = FormBorderStyle.None
    'fm.Dock = DockStyle.Fill
    'KCCMain.mytab.TabPages.Add(ntpg)
    'KCCMain.mytab.SelectTab(ntpg)
    'KCCMain.mytab.SizeMode = TabSizeMode.FillToRight
    'Dim x As Integer = 0
    'x = KCCMain.mytab.SelectedIndex
    'seltabindex = x
    'KCCMain.mytab.TabPages(x).Controls.Add(fm)
    'Return True
    'End Function

    Function exeupdater()
        Do While True
            Dim client As New Net.WebClient
            Dim newVersion As String = client.DownloadString("http://www.myWebsite.com/updates/latestVersion.txt")
            If newVersion <> IO.File.ReadAllText("Your programs file location") Then
                For Each p As Process In Process.GetProcesses
                    If p.ProcessName = "KCCPayroll" Then 'If you don't know what your program's process name is, simply run your program, run windows task manager, select 'processes' tab, scroll down untill you find your programs name.
                        p.Kill()
                    End If
                Next
                IO.File.Delete("old program file location")
                client.DownloadFile("http://www.myWebsite.com/updates/KCCPayroll.exe", "where ever you want to download your new program to (file location)")
                client.Dispose()
            End If
            Threading.Thread.Sleep(300000) 'freeze thread for 5 mins...
        Loop
        Return True
    End Function

    'Function removecurrenttab()
    'Dim tcnts As Integer = 0

    'rmbtabtflag = False
    'tcnts = KCCMain.mytab.TabCount - 1
    'If tcnts > 0 Then
    '    If seltabindex > -1 Then
    '        If seltabindex > 0 Then
    '            rmbtabtflag = True
    '            KCCMain.mytab.TabPages(seltabindex).Dispose()
    '            'TabControl1.TabPages.Remove(TabControl1.TabPages(seltabindex))
    '        Else
    '            rmbtabtflag = True
    '            KCCMain.mytab.TabPages(0).Dispose()
    '            'TabControl1.TabPages.Remove(TabControl1.TabPages(0))
    '        End If
    '    End If
    'Else
    '    If tcnts < 0 Then
    '        MsgBox("NO TABPAGE TO REMOVE!", 48, "ZERO(0) TAB PAGE")
    '    Else
    '        If tcnts = 0 Then
    '            rmbtabtflag = True
    '            KCCMain.mytab.TabPages(0).Dispose()
    '            'TabControl1.TabPages.Remove(TabControl1.TabPages(0))
    '        Else
    '            rmbtabtflag = True
    '            KCCMain.mytab.TabPages(tcnts - 1).Dispose()
    '            'TabControl1.TabPages.Remove(TabControl1.TabPages(tcnts - 1))
    '        End If
    '    End If
    'End If
    'Return True
    ' End Function

    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Public Function SafeImageFromFile(path As String) As Image
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function

    Function myd(str As String)
        myd = Replace(str, ",", "")
        Return myd
    End Function

    Function savetrail(mytrail As String)
        Dim myt As String = Nothing
        myt = mytrail
        Dim qst As String = Nothing
        qst = "INSERT INTO biotrail(tdetail,tdate) VALUES('" & myt & "','" & gettime2(1) & "')"
        Dim tr As MySqlCommand
        tr = New MySqlCommand(qst, cdb)
        tr.ExecuteNonQuery()
        tr.Dispose()
        Return True
    End Function

    Sub AuditTrail(ByVal plog As String, ByVal pmod As String)
        Dim sdate As String = Now.ToString("yyyy-MM-dd")

        cmd = New MySqlCommand("insert into AuditTrail (user, transactions, module, sdate, stime)values (@user, @transactions, @module, @sdate, @stime)", cdb)

        With cmd
            .Parameters.AddWithValue("@user", _user)
            .Parameters.AddWithValue("@transactions", plog)
            .Parameters.AddWithValue("@module", pmod)
            .Parameters.AddWithValue("@sdate", sdate)
            .Parameters.AddWithValue("@stime", Now.ToLongTimeString)
            .ExecuteNonQuery()
        End With
    End Sub

    Function GetTransNo() As String
        Dim sdate As String = Now.ToString("yyMMdd")
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select transno from poheader where transno like '" & sdate & "%' order by pkno desc", cdb)
        Using rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                GetTransNo = Format(CLng(rd.Item("transno").ToString) + 1)
            Else
                GetTransNo = sdate & "101"
            End If
            rd.Close()
        End Using
        Return GetTransNo
    End Function

    Public Function IS_EMPTY(ByVal pText As Object) As Boolean
        If pText.text = String.Empty Then
            pText.backcolor = Color.LemonChiffon
            pText.focus()
            MsgBox("Required missing field", vbCritical)
            IS_EMPTY = True
        Else
            pText.backcolor = Color.White
            IS_EMPTY = False
        End If
    End Function


    Sub PopUser()

    End Sub
    Public Function check_if_docno_exists(ByVal t_h As String, ByVal t_d As String)
        Dim fndcol As Boolean = False
        Using cmd = New MySqlCommand("SHOW COLUMNS FROM " & t_h & " LIKE '" & t_h & "';", cdb)
            Using rd As MySqlDataReader = cmd.ExecuteReader
                If rd.HasRows Then
                    fndcol = True
                End If
            End Using
        End Using
        Return fndcol
    End Function
    

End Module
