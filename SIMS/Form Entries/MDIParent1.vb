Imports System.Windows.Forms

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
        frmReceivingH.ShowDialog()

    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked
        MenuStrip.Cursor = Cursors.Hand()
    End Sub

    Private Sub MDIParent1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        frmLogin.ShowDialog()
    End Sub

    
    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip.Cursor = Cursors.Hand
    End Sub

    Private Sub ManageWarehouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageWarehouse.Click
        frmWarehouse.ShowDialog()
    End Sub

    Private Sub ManageSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSupplier.Click
        frmSupplier.ShowDialog()
    End Sub

   
    Private Sub ManageCategory_Click(sender As Object, e As EventArgs) Handles ManageCategory.Click
        frmCategory.ShowDialog()

    End Sub

    Private Sub ManageBrand_Click(sender As Object, e As EventArgs) Handles ManageBrand.Click
        frmBrand.ShowDialog()

    End Sub

    Private Sub ManageItems_Click(sender As Object, e As EventArgs) Handles ManageItems.Click
        frmItemH.ShowDialog()

    End Sub

    Private Sub ManageSalesman_Click(sender As Object, e As EventArgs) Handles ManageSalesman.Click
        frmSalesmanH.ShowDialog()
    End Sub

    Private Sub MiscStockIn_Click(sender As Object, e As EventArgs) Handles MiscStockIn.Click
        frmStockInH.ShowDialog()

    End Sub

    Private Sub MiscStockOut_Click(sender As Object, e As EventArgs) Handles MiscStockOut.Click
        frmStockOutH.ShowDialog()

    End Sub

    Private Sub StockTransfer_Click(sender As Object, e As EventArgs) Handles StockTransfer.Click
        frmTransferH.ShowDialog()

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

    Private Sub ManageCustomers_Click(sender As Object, e As EventArgs) Handles ManageCustomers.Click
        frmCustomerH.ShowDialog()

    End Sub

   
    Private Sub ManageProvince_Click(sender As Object, e As EventArgs) Handles ManageProvince.Click
        frmProvince.ShowDialog()

    End Sub

    Private Sub ManageArea_Click(sender As Object, e As EventArgs) Handles ManageArea.Click
        frmAreaTerritory.ShowDialog()

    End Sub

    
    Private Sub ManageOutletType_Click(sender As Object, e As EventArgs) Handles ManageOutletType.Click
        frmOutletType.ShowDialog()

    End Sub

    Private Sub GenerateInventory_Click(sender As Object, e As EventArgs) Handles GenerateInventory.Click
        frmGenerateInventory.ShowDialog()

    End Sub

    Private Sub StockCard_Click(sender As Object, e As EventArgs) Handles StockCard.Click
        frmStockCard.ShowDialog()

    End Sub

    Private Sub SalesReturn_Click(sender As Object, e As EventArgs) Handles SalesReturn.Click
        frmSalesReturnH.ShowDialog()

    End Sub

    Private Sub BOReturn_Click(sender As Object, e As EventArgs) Handles BOReturn.Click
        frmBOReturnH.ShowDialog()

    End Sub

    Private Sub CreditMemo_Click(sender As Object, e As EventArgs) Handles CreditMemo.Click
        frmMemoCreditH.ShowDialog()

    End Sub

    Private Sub DebitMemo_Click(sender As Object, e As EventArgs) Handles DebitMemo.Click
        frmMemoDebitH.ShowDialog()

    End Sub

    Private Sub PaymentMethod_Click(sender As Object, e As EventArgs) Handles PaymentMethod.Click
        frmPaymentModuleH.ShowDialog()

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

    Private Sub SalesRankinOfItems_Click(sender As Object, e As EventArgs) Handles SalesRankinOfItems.Click
        frmRankingItems.ShowDialog()

    End Sub

    Private Sub SalesRankingOfCustomer_Click(sender As Object, e As EventArgs) Handles SalesRankingOfCustomer.Click
        frmRankingCustomer.ShowDialog()

    End Sub

    Private Sub SalesRankingOfSalesman_Click(sender As Object, e As EventArgs) Handles SalesRankingOfSalesman.Click
        frmRankingSalesman.ShowDialog()

    End Sub

    Private Sub DetailOfOutstandingReceivable_Click(sender As Object, e As EventArgs) Handles DetailOfOutstandingReceivable.Click
        frmDetailofOutsRcv.ShowDialog()

    End Sub

    Private Sub CustomerARBalance_Click(sender As Object, e As EventArgs) Handles CustomerARBalance.Click
        frmCustomerARBalance.ShowDialog()

    End Sub

    Private Sub CustomerLedger_Click(sender As Object, e As EventArgs) Handles CustomerLedger.Click
        frmCustomerARLedger.ShowDialog()

    End Sub

    Private Sub ManageTypeOfOperationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageTypeOfOperationToolStripMenuItem.Click
        frmTypeOperation.ShowDialog()

    End Sub

    Private Sub ListofCreditMemo_Click(sender As Object, e As EventArgs) Handles ListofCreditMemo.Click
        frmListofCreditMemos.ShowDialog()

    End Sub

    Private Sub ListofDebitMemo_Click(sender As Object, e As EventArgs) Handles ListofDebitMemo.Click
        frmListofDebitMemos.ShowDialog()

    End Sub

    Private Sub ListOfPaymentCollection_Click(sender As Object, e As EventArgs) Handles ListOfPaymentCollection.Click
        frmListofPayment.ShowDialog()

    End Sub

    Private Sub CustomerListing_Click(sender As Object, e As EventArgs) Handles CustomerListing.Click
        frmCustomerListing.ShowDialog()

    End Sub

    Private Sub ItemPriceList_Click(sender As Object, e As EventArgs) Handles ItemPriceList.Click
        frmItemPriceList.ShowDialog()

    End Sub

    Private Sub UserActivityLogs_Click(sender As Object, e As EventArgs) Handles UserActivityLogs.Click
        frmUserLogs.ShowDialog()

    End Sub
End Class
