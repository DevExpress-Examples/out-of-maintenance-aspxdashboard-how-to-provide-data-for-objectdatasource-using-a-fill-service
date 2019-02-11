Imports DevExpress.DashboardCommon
Imports System.Collections.Generic
Imports System.Data

Namespace DXWebApplication5
    Public Class CustomObjectDataSourceCustomFillService
        Implements IObjectDataSourceCustomFillService

        Public Function GetData(ByVal dataSource As DashboardObjectDataSource, ByVal fillParameters As ObjectDataSourceFillParameters) As Object
            If fillParameters.DataFields Is Nothing OrElse fillParameters.DataFields.Length = 0 Then
                Return Nothing
            End If

            Dim data As List(Of SalesPersonData) = DataGenerator.CreateSourceData()

            Dim table As New DataTable()
            For Each field As String In fillParameters.DataFields
                table.Columns.Add(field)
            Next field
            For i As Integer = 0 To data.Count - 1
                Dim row(fillParameters.DataFields.Length - 1) As Object
                For j As Integer = 0 To fillParameters.DataFields.Length - 1
                    row(j) = GetPropertyValue(data(i), fillParameters.DataFields(j))
                Next j
                table.Rows.Add(row)
            Next i
            Return table.DefaultView
        End Function
        Private Function GetPropertyValue(ByVal obj As SalesPersonData, ByVal propName As String) As Object
            Return If(propName = "SalesPerson", DirectCast(obj.SalesPerson, Object), DirectCast(obj.Quantity, Object))
        End Function
    End Class
End Namespace