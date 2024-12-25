Partial Class DataSet1
    Partial Public Class EtiquetteExportDataTable
        Private Sub EtiquetteExportDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NumPaquetColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
