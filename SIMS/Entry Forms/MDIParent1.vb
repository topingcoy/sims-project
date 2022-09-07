Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '  Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '   Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ReceivingFromSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivingFromSupplier.Click
        frmReceivingH.Show()

    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked
        MenuStrip.Cursor = Cursors.Hand()
    End Sub

    Private Sub MDIParent1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
      
    End Sub

    Private Sub MDIParent1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure you want to Logout?", vbYesNo + vbQuestion, "SIMS - SALES & INVENTORY MANAGEMENT SYSTEM") = vbYes Then
            AuditTrail("Logout", "Logout")
            Me.Hide()
            frmLogin.tbuser.Clear()
            frmLogin.tbpwd.Clear()
            frmLogin.Show()
            frmLogin.tbuser.Focus()
        Else
            e.Cancel = True
        End If
    End Sub

    
    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'cmd = New MySqlCommand("select * from users where username = @username ", cdb)
        'With cmd
        '    .Parameters.AddWithValue("@username", lbluser.Text)
        '    .Parameters.AddWithValue("@password", txtPass.Text)
        'End With
        'rd = cmd.ExecuteReader
        'If rd.HasRows Then
        '    str_user = rd("username").ToString
        '    lbluser.Text = str_user
        '    lblip.Text = "localhost"
        'End If
        'rd.Dispose()
        'rd.Close()
        'lbluser.Text = str_user
        'lblip.Text = "localhost"


    End Sub

    Private Sub ManageWarehouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterWarehouse.Click
        frmWarehouse.ShowDialog()
    End Sub

    Private Sub ManageSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterSupplier.Click
        frmSupplier.ShowDialog()
    End Sub

   
    Private Sub ManageCategory_Click(sender As Object, e As EventArgs) Handles EnterCategory.Click
        frmCategory.ShowDialog()

    End Sub

    Private Sub ManageBrand_Click(sender As Object, e As EventArgs) Handles EnterBrand.Click
        frmBrand.ShowDialog()

    End Sub

    Private Sub ManageItems_Click(sender As Object, e As EventArgs) Handles EnterItem.Click
        frmItemH.Show()

    End Sub

    Private Sub ManageSalesman_Click(sender As Object, e As EventArgs) Handles EnterSalesman.Click
        frmSalesmanH.ShowDialog()
    End Sub

    Private Sub MiscStockIn_Click(sender As Object, e As EventArgs) Handles MiscStockIn.Click
        frmStockInH.ShowDialog()

    End Sub

    Private Sub MiscStockOut_Click(sender As Object, e As EventArgs) Handles MiscStockOut.Click
        frmStockOutH.ShowDialog()

    End Sub

    Private Sub StockTransfer_Click(sender As Object, e As EventArgs) Handles StockTransfer.Click
        frmStockTransferH.ShowDialog()

    End Sub

    Private Sub GoodstockConvertToBO_Click(sender As Object, e As EventArgs) Handles GoodstockConvertToBO.Click
        frmGStoBOH.ShowDialog()

    End Sub

    Private Sub PhysicalInventory_Click(sender As Object, e As EventArgs) Handles PhysicalInventory.Click
        frmPhysicalH.ShowDialog()

    End Sub

    Private Sub UpdateToActualInventory_Click(sender As Object, e As EventArgs) Handles UpdateToActualInventory.Click
        frmPhysicalUpdate.ShowDialog()

    End Sub

    Private Sub PrintVarrianceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintVarrianceReportToolStripMenuItem.Click
        frmPhysicalVariance.ShowDialog()

    End Sub

    Private Sub SalesInvoice_Click(sender As Object, e As EventArgs) Handles SalesInvoice.Click
        frmSalesInvoiceH.ShowDialog()

    End Sub

    Private Sub ManageCustomers_Click(sender As Object, e As EventArgs) Handles EnterCustomers.Click
        frmCustomerH.Show()

    End Sub

   
    Private Sub ManageProvince_Click(sender As Object, e As EventArgs) Handles EnterProvince.Click
        frmProvince.ShowDialog()

    End Sub

    Private Sub ManageArea_Click(sender As Object, e As EventArgs) Handles EnterArea.Click
        frmAreaTerritory.ShowDialog()

    End Sub

    
    Private Sub ManageOutletType_Click(sender As Object, e As EventArgs) Handles EnterOutletType.Click
        frmOutletType.ShowDialog()

    End Sub

    Private Sub SalesReturn_Click(sender As Object, e As EventArgs) Handles SalesReturn.Click
        frmSalesReturnH.ShowDialog()

    End Sub

    Private Sub BOReturn_Click(sender As Object, e As EventArgs) Handles BOReturn.Click
        frmSalesBOReturnH.ShowDialog()
    End Sub

    Private Sub CreditMemo_Click(sender As Object, e As EventArgs) Handles CreditMemo.Click
        frmMemoCredit.ShowDialog()

    End Sub

    Private Sub DebitMemo_Click(sender As Object, e As EventArgs) Handles DebitMemo.Click
        frmMemoDebitH.ShowDialog()

    End Sub


    Private Sub ListOfSalesInvoices_Click(sender As Object, e As EventArgs) Handles ListOfSalesInvoices.Click
        frmListSalesInvoices.ShowDialog()

    End Sub

    Private Sub ListOfSalesReturn_Click(sender As Object, e As EventArgs) Handles ListOfSalesReturn.Click
        frmListSalesReturn.ShowDialog()

    End Sub

    Private Sub ListOfBOReturn_Click(sender As Object, e As EventArgs) Handles ListOfBOReturn.Click
        frmListSalesBOReturn.ShowDialog()

    End Sub

    Private Sub ListPerInvoicePerDay_Click(sender As Object, e As EventArgs) Handles ListPerInvoicePerDay.Click
        frmListInvoicePerDay.ShowDialog()

    End Sub

    Private Sub SalesRankinOfItems_Click(sender As Object, e As EventArgs)
        frmRankingItems.ShowDialog()

    End Sub

    Private Sub SalesRankingOfCustomer_Click(sender As Object, e As EventArgs)
        frmRankingCustomer.ShowDialog()

    End Sub

    Private Sub SalesRankingOfSalesman_Click(sender As Object, e As EventArgs)
        frmRankingSalesman.ShowDialog()

    End Sub

    Private Sub DetailOfOutstandingReceivable_Click(sender As Object, e As EventArgs)
        frmDetailofOutsReceivables.ShowDialog()

    End Sub

    Private Sub CustomerARBalance_Click(sender As Object, e As EventArgs)
        frmCustomerARBalance.ShowDialog()

    End Sub

    Private Sub CustomerLedger_Click(sender As Object, e As EventArgs)
        frmCustomerARLedger.ShowDialog()

    End Sub

    Private Sub ManageTypeOfOperationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterTypeOfOperation.Click
        frmTypeOperation.ShowDialog()

    End Sub

    Private Sub ListofCreditMemo_Click(sender As Object, e As EventArgs) Handles ListofCreditMemo.Click
        frmListofCreditMemos.ShowDialog()

    End Sub

    Private Sub ListofDebitMemo_Click(sender As Object, e As EventArgs) Handles ListofDebitMemo.Click
        frmListofDebitMemos.ShowDialog()

    End Sub

    Private Sub ListOfPaymentCollection_Click(sender As Object, e As EventArgs) Handles ListOfPaymentCollection.Click
        frmListofExpresColl.ShowDialog()

    End Sub

    Private Sub CustomerListing_Click(sender As Object, e As EventArgs) Handles CustomerListing.Click
        frmCustomerListing.ShowDialog()

    End Sub

    Private Sub ItemPriceList_Click(sender As Object, e As EventArgs)
        frmItemPriceList.ShowDialog()

    End Sub

    Private Sub UserActivityLogs_Click(sender As Object, e As EventArgs) Handles UserActivityLogs.Click
        frmUserLogs.ShowDialog()

    End Sub

    Private Sub UserMaintenance_Click(sender As Object, e As EventArgs) Handles UserMaintenance.Click
        frmUserMaintenance.ShowDialog()

    End Sub

    Private Sub ChangePassword_Click(sender As Object, e As EventArgs) Handles ChangePassword.Click
        frmChangePassword.ShowDialog()

    End Sub

    Private Sub SummaryofMiscIn_Click(sender As Object, e As EventArgs) Handles SummaryofMiscIn.Click
        frmSummaryMiscStockIn.ShowDialog()

    End Sub

    Private Sub SummaryofReceiving_Click(sender As Object, e As EventArgs) Handles SummaryofReceiving.Click
        frmSummaryReceivingPerItem.ShowDialog()

    End Sub

    Private Sub SummaryofTransfer_Click(sender As Object, e As EventArgs) Handles SummaryofTransfer.Click
        frmSummaryStockTransfer.ShowDialog()

    End Sub

    Private Sub SummaryofConvertedtoBO_Click(sender As Object, e As EventArgs) Handles SummaryofConvertedtoBO.Click
        frmSummaryGoodstockBO.ShowDialog()

    End Sub

    Private Sub SummaryCreditMemo_Click(sender As Object, e As EventArgs) Handles SummaryCreditMemo.Click
        frmSummaryCreditMemo.ShowDialog()

    End Sub

    Private Sub DeletedInvoice_Click(sender As Object, e As EventArgs) Handles DeletedInvoice.Click
        frmListDeletedInvoice.ShowDialog()

    End Sub

    Private Sub DeletedReturn_Click(sender As Object, e As EventArgs) Handles DeletedReturn.Click
        frmListDeletedReturn.ShowDialog()

    End Sub

    Private Sub DeletedBO_Click(sender As Object, e As EventArgs) Handles DeletedBO.Click
        frmListDeletedBOReturn.ShowDialog()

    End Sub

   
    Private Sub ListofReceivingSupplier_Click(sender As Object, e As EventArgs) Handles ListofReceivingSupplier.Click
        frmListReceivingSupplier.ShowDialog()

    End Sub

    Private Sub SummaryDebitMemo_Click(sender As Object, e As EventArgs) Handles SummaryDebitMemo.Click
        frmSummaryDebitMemo.ShowDialog()

    End Sub

    Private Sub DeleteStockTransfer_Click(sender As Object, e As EventArgs) Handles DeleteStockTransfer.Click
        frmListDeletedStockTransfer.ShowDialog()

    End Sub

    Private Sub DeletedStockIn_Click(sender As Object, e As EventArgs) Handles DeletedStockIn.Click
        frmListDeletedStockIn.ShowDialog()

    End Sub

    Private Sub DeletedStockOut_Click(sender As Object, e As EventArgs) Handles DeletedStockOut.Click
        frmListDeletedStockOut.ShowDialog()

    End Sub

    Private Sub DeletedReceiving_Click(sender As Object, e As EventArgs) Handles DeletedReceiving.Click
        frmListDeletedReceiving.ShowDialog()

    End Sub

    Private Sub BackupAndRestore_Click(sender As Object, e As EventArgs) Handles BackupAndRestore.Click
        'frmBackup.ShowDialog()
        frmBackupRestore.ShowDialog()


    End Sub

    Private Sub UserAccessRole_Click(sender As Object, e As EventArgs) Handles UserAccessRole.Click
        frmUserAccessRole.ShowDialog()

    End Sub

    Private Sub SupplierCM_Click(sender As Object, e As EventArgs) Handles SupplierCM.Click
        frmSupplierCM.ShowDialog()

    End Sub

    Private Sub SupplierDM_Click(sender As Object, e As EventArgs) Handles SupplierDM.Click
        frmSupplierDM.ShowDialog()
    End Sub

    Private Sub BOReturnSupplier_Click(sender As Object, e As EventArgs) Handles BOReturnSupplier.Click
        frmBOreturnSupplierH.ShowDialog()

    End Sub

    Private Sub EnterGSreturnSupplier_Click(sender As Object, e As EventArgs) Handles EnterGSreturnSupplier.Click
        frmGSreturnSupplierH.ShowDialog()

    End Sub

    Private Sub PaymentToSupplier_Click(sender As Object, e As EventArgs) Handles PaymentToSupplier.Click
        frmPaymentSupplierH.ShowDialog()

    End Sub

    Private Sub TruckBranchInventory_Click(sender As Object, e As EventArgs) Handles TruckBranchInventory.Click
        frmGenerateInventory.ShowDialog()
    End Sub

    Private Sub ItemListPriceList_Click(sender As Object, e As EventArgs) Handles ItemListPriceList.Click
        frmItemPriceList.ShowDialog()
    End Sub

    Private Sub StockCard_Click(sender As Object, e As EventArgs) Handles StockCard.Click
        frmStockCard.ShowDialog()
    End Sub

    Private Sub ExpressColl_Click(sender As Object, e As EventArgs) Handles ExpressColl.Click
        frmExpressCollH.ShowDialog()
    End Sub

   
    Private Sub ViewCustomerARBalance_Click(sender As Object, e As EventArgs) Handles ViewCustomerARBalance.Click
        frmCustomerARBalance.ShowDialog()
    End Sub

    Private Sub BookingAR_Click(sender As Object, e As EventArgs) Handles BookingAR.Click
        frmBookingARCollH.ShowDialog()
    End Sub

   
    Private Sub ItemHistory_Click(sender As Object, e As EventArgs) Handles ItemHistory.Click
        frmItemHistory.ShowDialog()
    End Sub

    Private Sub btnItemMaintenance_Click(sender As Object, e As EventArgs) Handles btnItemMaintenance.Click
        frmItemH.Show()
    End Sub

    Private Sub btnReceiving_Click(sender As Object, e As EventArgs) Handles btnReceiving.Click
        frmReceivingH.ShowDialog()
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        frmStockInH.ShowDialog()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        frmStockOutH.ShowDialog()
    End Sub

    Private Sub btnSalesInvoice_Click(sender As Object, e As EventArgs) Handles btnSalesInvoice.Click
        'With frmSalesInvoiceH
        '    frmSalesInvoiceH.Text = "SAMPLE LIST"
        '    .ShowDialog()
        'End With
        frmSalesInvoiceH.ShowDialog()
    End Sub

    Private Sub btnItemPriceList_Click(sender As Object, e As EventArgs) Handles btnItemPriceList.Click
        frmItemPriceList.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        frmGenerateInventory.ShowDialog()
    End Sub

    Private Sub btnItemHistory_Click(sender As Object, e As EventArgs) Handles btnItemHistory.Click
        frmItemHistory.ShowDialog()
    End Sub

    Private Sub btnExpressColl_Click(sender As Object, e As EventArgs) Handles btnExpressColl.Click
        frmExpressCollH.ShowDialog()
    End Sub

    Private Sub CustomerARLedger_Click(sender As Object, e As EventArgs) Handles CustomerARLedger.Click
        frmCustomerARBalance.ShowDialog()
    End Sub

    Private Sub btnCustomerAR_Click(sender As Object, e As EventArgs) Handles btnCustomerAR.Click
        frmCustomerARBalance.ShowDialog()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        frmBackupRestore.ShowDialog()
    End Sub

    Private Sub btnListInvoice_Click(sender As Object, e As EventArgs) Handles btnListInvoice.Click
        frmListSalesInvoices.ShowDialog()
    End Sub

    Private Sub btnListReturn_Click(sender As Object, e As EventArgs) Handles btnListReturn.Click
        frmListSalesReturn.ShowDialog()
    End Sub

    Private Sub btnListExpressColl_Click(sender As Object, e As EventArgs) Handles btnListExpressColl.Click
        frmListofExpresColl.ShowDialog()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        frmCustomerH.ShowDialog()
    End Sub

    Private Sub btnCashColl_Click(sender As Object, e As EventArgs) Handles btnCashColl.Click
        frmListofCashReceive.ShowDialog()
    End Sub

    Private Sub btnCheckColl_Click(sender As Object, e As EventArgs) Handles btnCheckColl.Click
        frmlistofCheckReceive.ShowDialog()
    End Sub

    Private Sub btnStockTransfer_Click(sender As Object, e As EventArgs) Handles btnStockTransfer.Click
        frmStockTransferH.ShowDialog()
    End Sub

    Private Sub btnPhysical_Click(sender As Object, e As EventArgs) Handles btnPhysical.Click
        frmPhysicalH.ShowDialog()
    End Sub

    Private Sub btnUpdateActual_Click(sender As Object, e As EventArgs) Handles btnUpdateActual.Click
        frmPhysicalUpdate.ShowDialog()
    End Sub

    Private Sub btnStockCard_Click(sender As Object, e As EventArgs) Handles btnStockCard.Click
        frmStockCard.ShowDialog()
        'closeallchild()
        'With frmStockCard
        '    .MdiParent = Me
        '    '.Dock = DockStyle.Fill
        '    .Show()
        'End With
    End Sub

    Private Sub UserActivityLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserActivityLogsToolStripMenuItem.Click
        frmUserLogs.ShowDialog()
    End Sub

   
    Private Sub btnSalesReturn_Click(sender As Object, e As EventArgs) Handles btnSalesReturn.Click
        frmSalesReturnH.ShowDialog()
    End Sub

    Private Sub btnBOReturn_Click(sender As Object, e As EventArgs) Handles btnBOReturn.Click
        frmSalesBOReturnH.ShowDialog()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        frmListofSalesInvoicesDetailed.ShowDialog()
    End Sub
End Class
