

Partial Class DataSet4
    Partial Class stockcardreportsDataTable

        Private Sub stockcardreportsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.qntyColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub stockcardreportsDataTable_stockcardreportsRowChanging(sender As Object, e As stockcardreportsRowChangeEvent) Handles Me.stockcardreportsRowChanging

        End Sub

    End Class

End Class
