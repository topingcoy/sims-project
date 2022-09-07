<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MasterFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageWarehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSalesman = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageProvince = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageOutletType = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageTypeOfOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Inventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivingFromSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscStockIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscStockOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockTransfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoodstockConvertToBO = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockCard = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhysicalInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToActualInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintVarrianceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditMemo = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebitMemo = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentMethod = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reports = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSalesInvoices = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSalesReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfBOReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPerInvoicePerDay = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesRankinOfItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesRankingOfCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesRankingOfSalesman = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailOfOutstandingReceivable = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerARBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListofCreditMemo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListofDebitMemo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfPaymentCollection = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerListing = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemPriceList = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserActivityLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.Utilities = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupAndRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.status1 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterFile, Me.Inventory, Me.Transactions, Me.Reports, Me.Utilities})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.Utilities
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(937, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MasterFile
        '
        Me.MasterFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageWarehouse, Me.ManageSupplier, Me.ManageCategory, Me.ManageBrand, Me.ManageItems, Me.ManageCustomers, Me.ManageSalesman, Me.ManageProvince, Me.ManageArea, Me.ManageOutletType, Me.ManageTypeOfOperationToolStripMenuItem})
        Me.MasterFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.MasterFile.Name = "MasterFile"
        Me.MasterFile.Size = New System.Drawing.Size(76, 20)
        Me.MasterFile.Text = "Master &File"
        '
        'ManageWarehouse
        '
        Me.ManageWarehouse.Name = "ManageWarehouse"
        Me.ManageWarehouse.Size = New System.Drawing.Size(214, 22)
        Me.ManageWarehouse.Text = "Manage &Warehouse"
        '
        'ManageSupplier
        '
        Me.ManageSupplier.Name = "ManageSupplier"
        Me.ManageSupplier.Size = New System.Drawing.Size(214, 22)
        Me.ManageSupplier.Text = "Manage &Supplier"
        '
        'ManageCategory
        '
        Me.ManageCategory.Name = "ManageCategory"
        Me.ManageCategory.Size = New System.Drawing.Size(214, 22)
        Me.ManageCategory.Text = "Manage &Category"
        '
        'ManageBrand
        '
        Me.ManageBrand.Name = "ManageBrand"
        Me.ManageBrand.Size = New System.Drawing.Size(214, 22)
        Me.ManageBrand.Text = "Manage &Brand"
        '
        'ManageItems
        '
        Me.ManageItems.Name = "ManageItems"
        Me.ManageItems.Size = New System.Drawing.Size(214, 22)
        Me.ManageItems.Text = "Manage &Items"
        '
        'ManageCustomers
        '
        Me.ManageCustomers.Name = "ManageCustomers"
        Me.ManageCustomers.Size = New System.Drawing.Size(214, 22)
        Me.ManageCustomers.Text = "Manage C&ustomers"
        '
        'ManageSalesman
        '
        Me.ManageSalesman.Name = "ManageSalesman"
        Me.ManageSalesman.Size = New System.Drawing.Size(214, 22)
        Me.ManageSalesman.Text = "Manage Sales&man"
        '
        'ManageProvince
        '
        Me.ManageProvince.Name = "ManageProvince"
        Me.ManageProvince.Size = New System.Drawing.Size(214, 22)
        Me.ManageProvince.Text = "Manage &Province"
        '
        'ManageArea
        '
        Me.ManageArea.Name = "ManageArea"
        Me.ManageArea.Size = New System.Drawing.Size(214, 22)
        Me.ManageArea.Text = "Manage &Area/Territory"
        '
        'ManageOutletType
        '
        Me.ManageOutletType.Name = "ManageOutletType"
        Me.ManageOutletType.Size = New System.Drawing.Size(214, 22)
        Me.ManageOutletType.Text = "Manage &Outlet Type"
        '
        'ManageTypeOfOperationToolStripMenuItem
        '
        Me.ManageTypeOfOperationToolStripMenuItem.Name = "ManageTypeOfOperationToolStripMenuItem"
        Me.ManageTypeOfOperationToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ManageTypeOfOperationToolStripMenuItem.Text = "Manage &Type of Operation"
        '
        'Inventory
        '
        Me.Inventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceivingFromSupplier, Me.MiscStockIn, Me.MiscStockOut, Me.StockTransfer, Me.GoodstockConvertToBO, Me.GenerateInventory, Me.StockCard, Me.PhysicalInventory, Me.UpdateToActualInventory, Me.PrintVarrianceReportToolStripMenuItem})
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Size = New System.Drawing.Size(69, 20)
        Me.Inventory.Text = "&Inventory"
        '
        'ReceivingFromSupplier
        '
        Me.ReceivingFromSupplier.Name = "ReceivingFromSupplier"
        Me.ReceivingFromSupplier.Size = New System.Drawing.Size(222, 22)
        Me.ReceivingFromSupplier.Text = "&Receiving from Supplier"
        '
        'MiscStockIn
        '
        Me.MiscStockIn.Name = "MiscStockIn"
        Me.MiscStockIn.Size = New System.Drawing.Size(222, 22)
        Me.MiscStockIn.Text = "Misc. Stock &In"
        '
        'MiscStockOut
        '
        Me.MiscStockOut.Name = "MiscStockOut"
        Me.MiscStockOut.Size = New System.Drawing.Size(222, 22)
        Me.MiscStockOut.Text = "Misc. Stock &Out"
        '
        'StockTransfer
        '
        Me.StockTransfer.Name = "StockTransfer"
        Me.StockTransfer.Size = New System.Drawing.Size(222, 22)
        Me.StockTransfer.Text = "Stock &Transfer"
        '
        'GoodstockConvertToBO
        '
        Me.GoodstockConvertToBO.Name = "GoodstockConvertToBO"
        Me.GoodstockConvertToBO.Size = New System.Drawing.Size(222, 22)
        Me.GoodstockConvertToBO.Text = "Goodstock &Converted to BO"
        '
        'GenerateInventory
        '
        Me.GenerateInventory.Name = "GenerateInventory"
        Me.GenerateInventory.Size = New System.Drawing.Size(222, 22)
        Me.GenerateInventory.Text = "&Generate Inventory"
        '
        'StockCard
        '
        Me.StockCard.Name = "StockCard"
        Me.StockCard.Size = New System.Drawing.Size(222, 22)
        Me.StockCard.Text = "&Stock Card"
        '
        'PhysicalInventory
        '
        Me.PhysicalInventory.Name = "PhysicalInventory"
        Me.PhysicalInventory.Size = New System.Drawing.Size(222, 22)
        Me.PhysicalInventory.Text = "&Physical Inventory"
        '
        'UpdateToActualInventory
        '
        Me.UpdateToActualInventory.Name = "UpdateToActualInventory"
        Me.UpdateToActualInventory.Size = New System.Drawing.Size(222, 22)
        Me.UpdateToActualInventory.Text = "Update to Actual Inventory"
        '
        'PrintVarrianceReportToolStripMenuItem
        '
        Me.PrintVarrianceReportToolStripMenuItem.Name = "PrintVarrianceReportToolStripMenuItem"
        Me.PrintVarrianceReportToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.PrintVarrianceReportToolStripMenuItem.Text = "Print &Variance Report"
        '
        'Transactions
        '
        Me.Transactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesInvoice, Me.SalesReturn, Me.BOReturn, Me.CreditMemo, Me.DebitMemo, Me.PaymentMethod})
        Me.Transactions.Name = "Transactions"
        Me.Transactions.Size = New System.Drawing.Size(84, 20)
        Me.Transactions.Text = "&Transactions"
        '
        'SalesInvoice
        '
        Me.SalesInvoice.Name = "SalesInvoice"
        Me.SalesInvoice.Size = New System.Drawing.Size(256, 22)
        Me.SalesInvoice.Text = "&Sales Invoice"
        '
        'SalesReturn
        '
        Me.SalesReturn.Name = "SalesReturn"
        Me.SalesReturn.Size = New System.Drawing.Size(256, 22)
        Me.SalesReturn.Text = "Sales &Return"
        '
        'BOReturn
        '
        Me.BOReturn.Name = "BOReturn"
        Me.BOReturn.Size = New System.Drawing.Size(256, 22)
        Me.BOReturn.Text = "&B.O. Return"
        '
        'CreditMemo
        '
        Me.CreditMemo.Name = "CreditMemo"
        Me.CreditMemo.Size = New System.Drawing.Size(256, 22)
        Me.CreditMemo.Text = "&Credit Memo (for Special Charges)"
        '
        'DebitMemo
        '
        Me.DebitMemo.Name = "DebitMemo"
        Me.DebitMemo.Size = New System.Drawing.Size(256, 22)
        Me.DebitMemo.Text = "&Debit Memo (for Over Payment)"
        '
        'PaymentMethod
        '
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.Size = New System.Drawing.Size(256, 22)
        Me.PaymentMethod.Text = "&Payment Module"
        '
        'Reports
        '
        Me.Reports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfSalesInvoices, Me.ListOfSalesReturn, Me.ListOfBOReturn, Me.ListPerInvoicePerDay, Me.SalesRankinOfItems, Me.SalesRankingOfCustomer, Me.SalesRankingOfSalesman, Me.DetailOfOutstandingReceivable, Me.CustomerARBalance, Me.CustomerLedger, Me.ListofCreditMemo, Me.ListofDebitMemo, Me.ListOfPaymentCollection, Me.CustomerListing, Me.ItemPriceList, Me.UserActivityLogs})
        Me.Reports.Name = "Reports"
        Me.Reports.Size = New System.Drawing.Size(59, 20)
        Me.Reports.Text = "&Reports"
        '
        'ListOfSalesInvoices
        '
        Me.ListOfSalesInvoices.Name = "ListOfSalesInvoices"
        Me.ListOfSalesInvoices.Size = New System.Drawing.Size(246, 22)
        Me.ListOfSalesInvoices.Text = "List of &Sales Invoices"
        '
        'ListOfSalesReturn
        '
        Me.ListOfSalesReturn.Name = "ListOfSalesReturn"
        Me.ListOfSalesReturn.Size = New System.Drawing.Size(246, 22)
        Me.ListOfSalesReturn.Text = "List of Sales &Return"
        '
        'ListOfBOReturn
        '
        Me.ListOfBOReturn.Name = "ListOfBOReturn"
        Me.ListOfBOReturn.Size = New System.Drawing.Size(246, 22)
        Me.ListOfBOReturn.Text = "List of &B.O. Return"
        '
        'ListPerInvoicePerDay
        '
        Me.ListPerInvoicePerDay.Name = "ListPerInvoicePerDay"
        Me.ListPerInvoicePerDay.Size = New System.Drawing.Size(246, 22)
        Me.ListPerInvoicePerDay.Text = "List per &Invoice per Day"
        '
        'SalesRankinOfItems
        '
        Me.SalesRankinOfItems.Name = "SalesRankinOfItems"
        Me.SalesRankinOfItems.Size = New System.Drawing.Size(246, 22)
        Me.SalesRankinOfItems.Text = "Sales Ranking of &Items"
        '
        'SalesRankingOfCustomer
        '
        Me.SalesRankingOfCustomer.Name = "SalesRankingOfCustomer"
        Me.SalesRankingOfCustomer.Size = New System.Drawing.Size(246, 22)
        Me.SalesRankingOfCustomer.Text = "Sales Ranking of &Customer"
        '
        'SalesRankingOfSalesman
        '
        Me.SalesRankingOfSalesman.Name = "SalesRankingOfSalesman"
        Me.SalesRankingOfSalesman.Size = New System.Drawing.Size(246, 22)
        Me.SalesRankingOfSalesman.Text = "Sales Ranking of &Salesman"
        '
        'DetailOfOutstandingReceivable
        '
        Me.DetailOfOutstandingReceivable.Name = "DetailOfOutstandingReceivable"
        Me.DetailOfOutstandingReceivable.Size = New System.Drawing.Size(246, 22)
        Me.DetailOfOutstandingReceivable.Text = "Detail of &Outstanding Receivable"
        '
        'CustomerARBalance
        '
        Me.CustomerARBalance.Name = "CustomerARBalance"
        Me.CustomerARBalance.Size = New System.Drawing.Size(246, 22)
        Me.CustomerARBalance.Text = "Customer &A/R Balance"
        '
        'CustomerLedger
        '
        Me.CustomerLedger.Name = "CustomerLedger"
        Me.CustomerLedger.Size = New System.Drawing.Size(246, 22)
        Me.CustomerLedger.Text = "Customer &Ledger"
        '
        'ListofCreditMemo
        '
        Me.ListofCreditMemo.Name = "ListofCreditMemo"
        Me.ListofCreditMemo.Size = New System.Drawing.Size(246, 22)
        Me.ListofCreditMemo.Text = "List of Credit Memo"
        '
        'ListofDebitMemo
        '
        Me.ListofDebitMemo.Name = "ListofDebitMemo"
        Me.ListofDebitMemo.Size = New System.Drawing.Size(246, 22)
        Me.ListofDebitMemo.Text = "List of Debit Memo"
        '
        'ListOfPaymentCollection
        '
        Me.ListOfPaymentCollection.Name = "ListOfPaymentCollection"
        Me.ListOfPaymentCollection.Size = New System.Drawing.Size(246, 22)
        Me.ListOfPaymentCollection.Text = "List of &Payments/Collections"
        '
        'CustomerListing
        '
        Me.CustomerListing.Name = "CustomerListing"
        Me.CustomerListing.Size = New System.Drawing.Size(246, 22)
        Me.CustomerListing.Text = "Custo&mer Listing"
        '
        'ItemPriceList
        '
        Me.ItemPriceList.Name = "ItemPriceList"
        Me.ItemPriceList.Size = New System.Drawing.Size(246, 22)
        Me.ItemPriceList.Text = "Item &Price List"
        '
        'UserActivityLogs
        '
        Me.UserActivityLogs.Name = "UserActivityLogs"
        Me.UserActivityLogs.Size = New System.Drawing.Size(246, 22)
        Me.UserActivityLogs.Text = "&User Activity Logs"
        '
        'Utilities
        '
        Me.Utilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMaintenance, Me.BackupAndRestore})
        Me.Utilities.Name = "Utilities"
        Me.Utilities.Size = New System.Drawing.Size(58, 20)
        Me.Utilities.Text = "&Utilities"
        '
        'BackupAndRestore
        '
        Me.BackupAndRestore.Name = "BackupAndRestore"
        Me.BackupAndRestore.Size = New System.Drawing.Size(178, 22)
        Me.BackupAndRestore.Text = "&Backup and Restore"
        '
        'UserMaintenance
        '
        Me.UserMaintenance.Name = "UserMaintenance"
        Me.UserMaintenance.Size = New System.Drawing.Size(178, 22)
        Me.UserMaintenance.Text = "&User Maintenance"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(937, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel.Text = "Status :"
        '
        'status1
        '
        Me.status1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.status1.AutoSize = True
        Me.status1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status1.Location = New System.Drawing.Point(48, 436)
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(52, 13)
        Me.status1.TabIndex = 9
        Me.status1.Text = "lblStatus"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 453)
        Me.Controls.Add(Me.status1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.ShowIcon = False
        Me.Text = "   ICON - SALES & INVENTORY MANAGEMENT SYSTEM V1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Utilities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MasterFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Inventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Transactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Reports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents status1 As System.Windows.Forms.Label
    Friend WithEvents ManageWarehouse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageBrand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageSalesman As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceivingFromSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiscStockIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiscStockOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockTransfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockCard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhysicalInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToActualInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditMemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitMemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentMethod As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfSalesInvoices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfSalesReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfBOReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListPerInvoicePerDay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesRankinOfItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesRankingOfCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesRankingOfSalesman As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailOfOutstandingReceivable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerARBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerLedger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfPaymentCollection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerListing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserActivityLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupAndRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMaintenance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoodstockConvertToBO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintVarrianceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageProvince As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageOutletType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemPriceList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListofCreditMemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListofDebitMemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageTypeOfOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
