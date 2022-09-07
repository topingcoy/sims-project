Imports System
Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data
Imports System.Text
Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Linq
Imports System.Configuration
Imports System.Xml
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization
Imports System.Drawing.Printing

Imports System.Threading

Public Class frmStockCard
    Dim ds2 As New DataSet4
    Dim dt As DataTable = ds2.Tables("stockcardreports")
    Private Delegate Function returncheck() As Object
    Dim tt1 As System.Threading.Thread
    Dim myprogcount As Integer = 0
    Dim liststocks() As stockcards
    Dim rwstockcard As Integer
    Private Delegate Sub dlgt(ByVal Results)
    Structure stockcards
        Dim tno As Decimal
        Dim sorder As Decimal
        Dim itemcode As String
        Dim particular As String
        Dim tdate As Date
        Dim docno As String
        Dim ttype As String
        Dim incss As Decimal
        Dim inbgs As Decimal
        Dim inpcs As Decimal
        Dim oucss As Decimal
        Dim oubgs As Decimal
        Dim oupcs As Decimal
        Dim lcost As Decimal
        Dim price As Decimal
        Dim qunit As String
        Dim pckg As Decimal
    End Structure

    Private Sub reset_liststocks()
        'Reset person count and array
        rwstockcard = 0
        Erase liststocks
    End Sub

    Private Sub get_detailstockcard(ByVal itmcode)
        For x As Integer = 0 To rwstockcard - 1

            Dim tn As Decimal
            Dim sod As Decimal
            Dim itc As String
            Dim ptc As String
            Dim tdt As Date
            Dim dcn As String
            Dim ttp As String
            Dim inc As Decimal
            Dim inb As Decimal
            Dim inp As Decimal
            Dim ouc As Decimal
            Dim oub As Decimal
            Dim oup As Decimal
            Dim cost As Decimal
            Dim pr As Decimal
            Dim qnt As String
            Dim pcg As Decimal

            tn = liststocks(x).tno
            sod = liststocks(x).sorder
            itc = liststocks(x).itemcode
            ptc = liststocks(x).particular
            tdt = liststocks(x).tdate
            dcn = liststocks(x).docno
            ttp = liststocks(x).ttype
            inc = liststocks(x).incss
            inb = liststocks(x).inbgs
            inp = liststocks(x).inpcs
            ouc = liststocks(x).oucss
            oub = liststocks(x).oubgs
            oup = liststocks(x).oupcs
            cost = liststocks(x).lcost
            pr = liststocks(x).particular
            qnt = liststocks(x).tdate
            pcg = liststocks(x).pckg
        Next
    End Sub

    Private Sub txtItemCode_DoubleClick(sender As Object, e As EventArgs) Handles txtItemCode.DoubleClick
        show_form_item_search("StockCard", "Stock Card")

    End Sub

    Private Sub txtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.F3 Then
            show_form_item_search("StockCard", "Stock Card")
        End If
    End Sub

    Private Sub txtItemCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemCode.KeyPress
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("SELECT * FROM ivitem WHERE itemcode= '" & txtItemCode.Text & "'", cdb)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtDescription.Text = rd("description").ToString
        End If
        rd.Dispose()

        If e.KeyChar = vbCr Then
            cbxWhsCode.Focus()
        End If
    End Sub

    Private Sub txtItemCode_TextChanged(sender As Object, e As EventArgs) Handles txtItemCode.TextChanged

    End Sub


    Private Sub frmStockCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Control.CheckForIllegalCrossThreadCalls = False
        LoadWarehouse()
        chkGood.Checked = True
        dtpStart.Value = "01/01/2022"
        dt.Rows.Clear()
        tt1 = Nothing
        'dt.Columns.Clear()
        'dt.Rows.Clear()
        'dt.Clear()
        'dt.Columns.Add("nos", Type.GetType("System.String"))
        'dt.Columns.Add("AccountNo", Type.GetType("System.String"))
        'dt.Columns.Add("clname", Type.GetType("System.String"))
        'dt.Columns.Add("fcnt", Type.GetType("System.String"))
        'dt.Columns.Add("cgend", Type.GetType("System.String"))
        'dt.Columns.Add("ctno", Type.GetType("System.String"))
        'dt.Columns.Add("addr", Type.GetType("System.String"))
        'dt.Columns.Add("vdocs", Type.GetType("System.String"))
        'dt.Columns.Add("clid", Type.GetType("System.String"))
    End Sub

    Sub LoadWarehouse()
        Dim qry As String = Nothing
        Dim rmd As New MySqlCommand
        cbxWhsCode.Items.Clear()
        cbxWhsCode.DisplayMember = "text"
        qry = "Select * from warehouse ORDER BY warehouse"
        rmd = New MySqlCommand(qry, cdb)
        rmd.ExecuteNonQuery()
        Dim relr = rmd.ExecuteReader()
        While relr.Read()
            cbxWhsCode.Items.Add(New With {.Text = relr("whscode").ToString(), .Value = relr("whscode").ToString()})
        End While
        relr.Close()
        rmd.Dispose()
    End Sub

    Private Sub cbxWhsCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxWhsCode.KeyPress
        If e.KeyChar = vbCr Then
            dtpStart.Focus()
        End If
    End Sub


    Private Sub cbxWhsCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWhsCode.SelectedIndexChanged

    End Sub

    Private Sub cbxWhsCode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxWhsCode.SelectionChangeCommitted
        cmd = New MySqlCommand("SELECT * from warehouse where whscode like '%" & cbxWhsCode.Text & "%'", cdb)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            With rd
                txtWarehouseName.Text = rd.Item("warehouse").ToString
            End With
        End If
        rd.Close()
    End Sub

    Private Sub dtpStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpStart.KeyPress

    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
    End Sub

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        If txtItemCode.Text <> Nothing And cbxWhsCode.Text <> Nothing Then
            If check_if_item_in_whs(txtItemCode.Text.Trim(), cbxWhsCode.Text) Then
                tt1 = Nothing
                set_progressbar_max(0, 0, 0, "B")
                dt.Rows.Clear()
                ' sGoodStock(1)
                Dim stocktype As Integer = 0
                If chkGood.Checked = True Then
                    stocktype = 1
                ElseIf chkBO.Checked = True Then
                    stocktype = 2
                End If
                center_animated_progress(stocktype)
            Else
                MsgBox("Please select item and warehouse first before proceeding request", 48, "No selected item and warehouse")
            End If

           
        Else
            MsgBox("Please select item and warehouse first before proceeding request", 48, "No selected item and warehouse")
        End If

    End Sub
    Public Sub start_thread(ByVal st As Integer)
        If tt1 Is Nothing Then
            If st = 1 Then
                tt1 = New System.Threading.Thread(AddressOf mythread) 'New Thread(Sub() sGoodStock())
            ElseIf st = 2 Then
                tt1 = New System.Threading.Thread(AddressOf mythread2) 'New Thread(Sub() sGoodStock())
            End If


            tt1.IsBackground = True
            tt1.Start()
            'Thread.Join()
        End If
    End Sub
    Private Sub mythread()
        Me.Invoke(New dlgt(AddressOf sGoodStock), True)
    End Sub
    Private Sub mythread2()
        Me.Invoke(New dlgt(AddressOf sBoStock), True)
    End Sub
    Sub sGoodStock(ByVal x As Integer)

        'MsgBox(x)
        'dt.Columns.Clear()

        'MDIParent1.pbMain.Show()

        MDIParent1.pbMain.Visible = True
        MDIParent1.pbMain.Step = 1

        Dim nIN As Decimal = 0
        Dim nOUT As Decimal = 0
        Dim nBegBal As Decimal = 0
        Dim prep As New ReportDocument
        Dim drw As DataRow


        Dim q_itmc As String = Nothing
        Dim q_whsq As String = Nothing
        Dim q_tdate As Date

        q_itmc = txtItemCode.Text.Trim()
        q_whsq = cbxWhsCode.Text
        q_tdate = Format(dtpStart.Value, "yyyy-MM-dd")

        Using cmd = New MySqlCommand("SELECT m.itemcode,m.description,m.unit,m.pckgc,m.pckgb,m.pckgp,w.qty_good,w.qty_bo FROM ivitem m " & _
                               "LEFT JOIN ivwh w ON m.itemcode=w.itemcode WHERE m.itemcode=@itm AND w.whscode=@mywhs ", cdb)
            cmd.Parameters.AddWithValue("@itm", q_itmc)
            cmd.Parameters.AddWithValue("@mywhs", q_whsq)
            Using rd As MySqlDataReader = cmd.ExecuteReader

                If rd.HasRows Then
                    rd.Read()
                    If Not IsDBNull(rd("qty_good").ToString()) Then
                        nBegBal = Decimal.Parse(rd("qty_good").ToString)
                    End If

                End If
                rd.Close()
            End Using
        End Using

        Dim mytabh As String = Nothing
        Dim mytabd As String = Nothing
        Dim docno As String = Nothing
        Dim myfield As String = Nothing
        Dim sql As String = Nothing

        mytabh = "rcvingh"
        mytabd = "rcvingd"
        myfield = "docno"

        Dim maxcnt As Integer = 0 'receiving count
        Dim totalmaxcnt As Integer = 0

        sql = "SELECT COUNT(a.itemcode) as recordcount FROM " & mytabh & " b INNER JOIN  " & mytabd & " a " & _
                        "ON a.transno=b.transno WHERE a.itemcode=@itm and a.whscode=@mywhs " & _
                        "and b.tdate>=@mydate AND a.isdeleted='0' and b.isdeleted='0' order by b.transno,b.tdate"
        maxcnt = get_max_record_count(sql, q_itmc, q_whsq, q_tdate)

        totalmaxcnt = totalmaxcnt + maxcnt
        totalmaxcnt += 3
       

        Dim fnd As Boolean = False 'check receiving table
     
        If check_if_docno_exists(mytabh, mytabd) Then
            sql = "SELECT a.itemcode,b.tdate,b.docno,b.transno, a.qty,a.pckg,a.qunit,a.netcost,a.costpc FROM " & mytabh & " b INNER JOIN  " & mytabd & " a " & _
                 "ON a.transno=b.transno WHERE a.itemcode=@itm and a.whscode=@mywhs " & _
                 "and b.tdate>=@mydate AND  a.isdeleted='0' and b.isdeleted='0' order by b.transno,b.tdate"
        Else
            sql = "SELECT a.itemcode,b.tdate,b.transno, a.qty,a.pckg,a.qunit,a.netcost,a.costpc FROM " & mytabh & " b INNER JOIN  " & mytabd & " a " & _
                "ON a.transno=b.transno WHERE a.itemcode=@itm and a.whscode=@mywhs " & _
                "and b.tdate>=@mydate AND  a.isdeleted='0' and b.isdeleted='0' order by b.transno,b.tdate"
        End If

        MDIParent1.pbMain.Maximum = totalmaxcnt
        Dim ic As Integer = 0
        Using cmd = New MySqlCommand(sql, cdb)
            cmd.Parameters.AddWithValue("@itm", q_itmc)
            cmd.Parameters.AddWithValue("@mywhs", q_whsq)
            cmd.Parameters.AddWithValue("@mydate", q_tdate)
            Using rd As MySqlDataReader = cmd.ExecuteReader

                If rd.HasRows Then
                    While rd.Read
                        drw = dt.NewRow()
                        drw("trno") = rd("transno").ToString
                        drw("sortorder") = 1   'sort order
                        drw("itmc") = q_itmc
                        If fnd = True Then
                            drw("docno") = rd("docno").ToString
                        Else
                            drw("docno") = rd("transno").ToString
                        End If
                        drw("ttype") = "Rcv"
                        drw("icost") = rd("netcost").ToString
                        drw("qunit") = rd("qunit").ToString
                        drw("pckg") = rd("pckg").ToString
                        drw("qnty") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                        If rd("qunit").ToString = "C" Then
                            drw("inc") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                        ElseIf rd("qunit").ToString = "B" Then
                            drw("inb") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                        Else
                            drw("inp") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                        End If
                        nIN += If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString) * rd("pckg").ToString
                        ic += 1
                        MDIParent1.pbMain.Value = ic
                        dt.Rows.Add(drw)
                    End While

                End If
                rd.Close()
            End Using
        End Using


        fnd = False
        mytabh = "ivh"
        mytabd = "ivd"
        sql = "SELECT COUNT(a.itemcode) as recordcount FROM " & mytabh & " b INNER JOIN  " & mytabd & " a " & _
                       "ON a.transno=b.transno WHERE a.itemcode=@itm and a.whscode=@mywhs " & _
                       "and b.tdate>=@mydate AND a.isdeleted='0' and b.isdeleted='0'   order by b.transno,b.tdate"
        maxcnt = get_max_record_count(sql, q_itmc, q_whsq, q_tdate)

        totalmaxcnt = totalmaxcnt + maxcnt
        MDIParent1.pbMain.Maximum = totalmaxcnt
        fnd = check_if_docno_exists(mytabh, mytabd)
        If fnd = True Then
            sql = "SELECT a.itemcode,b.tdate,b.docno,b.transno, a.qty,a.pckg,a.qunit,a.cost,a.price,a.ttype,a.towhs FROM " & mytabh & " b INNER JOIN  " & mytabd & " a " & _
                 "ON a.transno=b.transno WHERE a.itemcode=@itm and a.whscode=@mywhs " & _
                 "and b.tdate>=@mydate AND a.isdeleted='0' and b.isdeleted='0' order by b.transno,b.tdate"
        Else
            sql = "SELECT  a.itemcode,b.tdate,b.transno, a.qty,a.pckg,a.qunit,a.cost,a.price,a.ttype,a.towhs  FROM " & mytabh & " b INNER JOIN  " & mytabd & " a " & _
                "ON a.transno=b.transno WHERE a.itemcode=@itm and a.whscode=@mywhs " & _
                "and b.tdate>=@mydate AND  a.isdeleted='0' and b.isdeleted='0' order by b.transno,b.tdate"
        End If

        Using cmd = New MySqlCommand(sql, cdb)
            cmd.Parameters.AddWithValue("@itm", q_itmc)
            cmd.Parameters.AddWithValue("@mywhs", q_whsq)
            cmd.Parameters.AddWithValue("@mydate", q_tdate)
            Using rd As MySqlDataReader = cmd.ExecuteReader

                If rd.HasRows Then
                    While rd.Read
                        drw = dt.NewRow()
                        drw("trno") = rd("transno").ToString

                        drw("itmc") = q_itmc
                        If fnd = True Then
                            drw("docno") = rd("docno").ToString
                        Else
                            drw("docno") = rd("transno").ToString
                        End If
                        'MsgBox(rd("cost").ToString))
                        drw("icost") = If(IsDBNull(rd("cost").ToString), 0, Decimal.Parse(rd("cost").ToString))
                        drw("qunit") = rd("qunit").ToString
                        drw("pckg") = rd("pckg").ToString
                        drw("tdate") = rd("tdate").ToString
                        If rd("ttype").ToString = "I" Then
                            drw("sortorder") = 2   'sort order
                            drw("ttype") = "In"
                            If rd("qunit").ToString = "C" Then
                                drw("inc") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            ElseIf rd("qunit").ToString = "B" Then
                                drw("inb") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            Else
                                drw("inp") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            End If
                            nIN += If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString) * rd("pckg").ToString
                        ElseIf rd("ttype").ToString = "O" Then
                            drw("sortorder") = 3   'sort order
                            drw("ttype") = "Out"
                            If rd("qunit").ToString = "C" Then
                                drw("ouc") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            ElseIf rd("qunit").ToString = "B" Then
                                drw("oucb") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            Else
                                drw("oup") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            End If
                            nOUT += If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString) * rd("pckg").ToString
                        ElseIf rd("ttype").ToString = "B" Or rd("ttype").ToString = "C" Then
                            drw("sortorder") = 3   'sort order
                            drw("ttype") = "Con"
                            If rd("qunit").ToString = "C" Then
                                drw("ouc") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            ElseIf rd("qunit").ToString = "B" Then
                                drw("oucb") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            Else
                                drw("oup") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            End If
                            drw("partc") = "Converted to B.O."
                            nOUT += If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString) * rd("pckg").ToString
                        ElseIf rd("ttype").ToString = "T" Then
                            drw("sortorder") = 7   'sort order
                            drw("ttype") = "Trf"
                            Dim towhs As String = Nothing
                            Dim crwhs As String = Nothing
                            towhs = rd("towhs").ToString
                            crwhs = cbxWhsCode.Text
                            drw("partc") = "To " & towhs
                            If rd("qunit").ToString = "C" Then
                                drw("ouc") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            ElseIf rd("qunit").ToString = "B" Then
                                drw("oucb") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            Else
                                drw("oup") = If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString)
                            End If
                            nOUT += If(IsDBNull(rd("qty").ToString), 0, rd("qty").ToString) * rd("pckg").ToString
                        End If

                        ic += 1
                        MDIParent1.pbMain.Value = ic
                        dt.Rows.Add(drw)
                    End While

                End If
                rd.Close()
            End Using
        End Using
        ' System.Threading.Thread.Sleep(1000)


        ' MDIParent1.pbMain.Maximum = 2000002 + totalmaxcnt
        ' For i = 1 To 2000000
        drw = dt.NewRow()
        drw("trno") = "KOKS"
        drw("sortorder") = 3
        ic += 1
        dt.Rows.Add(drw)
        MDIParent1.pbMain.Value = ic

        'Next


        ' System.Threading.Thread.Sleep(1000)

        drw = dt.NewRow()
        drw("trno") = "RICHEL"
        drw("sortorder") = 1
        ic += 1
        dt.Rows.Add(drw)

        MDIParent1.pbMain.Value = ic
        ' System.Threading.Thread.Sleep(1000)
        drw = dt.NewRow()
        drw("trno") = "TOPING"
        drw("sortorder") = 2
        ic += 1
        dt.Rows.Add(drw)
        MDIParent1.pbMain.Value = ic

        Dim dtv1 As System.Data.DataView
        dtv1 = dt.DefaultView
        dtv1.Sort = dt.Columns(0).ColumnName + " Desc, " + dt.Columns(2).ColumnName 'dt.Columns(4).ColumnName + " Desc, " + dt.Columns(2).ColumnName + " Asc" 'SORT DATE,SORT ORDER
        'dtv1.Sort = dt.Columns(0).ColumnName + " Desc"
        'For Each row As DataRow In dt.Rows
        '    MsgBox(row("trno").ToString)

        'Next

        MDIParent1.pbMain.Maximum = dtv1.Count
        For Each vrw As DataRowView In dt.DefaultView
            MsgBox(vrw("trno").ToString)
        Next
        ' MDIParent1.pbMain.Hide()

        ' MDIParent1.pbMain.Visible = False

        center_animated_progress_hide()
        MDIParent1.pbMain.Visible = False
        tt1 = Nothing

        ' center_animated_progress_hide()
        'string name = row["name"].ToString();
        'string description = row["description"].ToString();
        'string icoFileName = row["iconFile"].ToString();
        'string installScript = row["installScript"].ToString();
        ' prep = New Listing
        ' prep.SetDataSource(ds2)

        'frmReport.CRportRcv.ReportSource = prep
        'frmReport.CRportRcv.Refresh()
        'frmReport.Dock = DockStyle.Fill
        'frmReport.Show()

    End Sub
    Sub sBoStock()

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub


End Class