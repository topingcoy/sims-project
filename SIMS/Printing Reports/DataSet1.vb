Partial Class DataSet1
  

    Partial Class dtListofCashCollDataTable

        Private Sub dtListofCashCollDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
            '    'Add user code here
            'End If

        End Sub

    End Class

    Partial Class dtCustomerARBalanceDataTable

        Private Sub dtCustomerARBalanceDataTable_dtCustomerARBalanceRowChanging(sender As Object, e As dtCustomerARBalanceRowChangeEvent) Handles Me.dtCustomerARBalanceRowChanging

        End Sub

    End Class

    Partial Class dtListofExpressCollDataTable

        Private Sub dtListofExpressCollDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
            '    'Add user code here
            'End If

        End Sub

    End Class

    Partial Class dtExpressCollDataTable

        Private Sub dtExpressCollDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
            '    'Add user code here
            'End If

        End Sub

        Private Sub dtExpressCollDataTable_dtExpressCollRowChanging(sender As Object, e As dtExpressCollRowChangeEvent) Handles Me.dtExpressCollRowChanging

        End Sub

    End Class

    Partial Class dtListofSalesInvoicesDataTable

        Private Sub dtListofSalesInvoicesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.invoicenoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class whinventoryDataTable



    End Class

    Partial Class dtPriceListDataTable

        Private Sub dtPriceListDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.pckgbagColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class dtSalesInvoiceDataTable

        Private Sub dtSalesInvoiceDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.invoicenoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class dtStockInDataTable


    End Class

    Partial Class supCMDataTable

        Private Sub supCMDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.docnoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class rcvDataTableDataTable

        Private Sub rcvDataTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

    End Class

End Class
