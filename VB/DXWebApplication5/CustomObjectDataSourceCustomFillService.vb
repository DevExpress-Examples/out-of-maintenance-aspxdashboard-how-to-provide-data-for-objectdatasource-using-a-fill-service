Imports DevExpress.DashboardCommon
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace DXWebApplication5
	Public Class CustomObjectDataSourceCustomFillService
		Implements IObjectDataSourceCustomFillService

		Public Function GetData(ByVal dataSource As DashboardObjectDataSource, ByVal fillParameters As ObjectDataSourceFillParameters) As Object Implements IObjectDataSourceCustomFillService.GetData
			If fillParameters.DataFields Is Nothing OrElse fillParameters.DataFields.Length = 0 Then
				Return Nothing
			End If

			Dim data As List(Of SalesPersonData) = DataGenerator.Data

			Dim table As New DataTable()
			For Each field As String In fillParameters.DataFields
				table.Columns.Add(field)
			Next field

			Dim NumberOfRecordsToRetrieveParameter As Integer = CInt(Fix(If(fillParameters.Parameters.FirstOrDefault(Function(i) i.Name = "NumberOfRecords") Is Nothing, Nothing, fillParameters.Parameters.FirstOrDefault(Function(i) i.Name = "NumberOfRecords").Value)))
			Dim NumberOfRecordsToRetrieve As Integer = If(NumberOfRecordsToRetrieveParameter <= data.Count, NumberOfRecordsToRetrieveParameter, data.Count)

			For i As Integer = 0 To NumberOfRecordsToRetrieve - 1
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