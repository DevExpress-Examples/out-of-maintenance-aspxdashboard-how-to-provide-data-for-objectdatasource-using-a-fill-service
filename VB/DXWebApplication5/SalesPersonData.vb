Imports System
Imports System.Collections.Generic

Namespace DXWebApplication5
	Public Class SalesPersonData
		Public Property SalesPerson() As String
		Public Property Quantity() As Integer
		Public Property Checked() As Boolean
	End Class

	Public NotInheritable Class DataGenerator

		Private Sub New()
		End Sub
		Private Shared _data As List(Of SalesPersonData)

		Public Shared ReadOnly Property Data() As List(Of SalesPersonData)
			Get
				If _data Is Nothing Then
					_data = CreateSourceData()
				End If
				Return _data
			End Get
		End Property
		Public Shared Function CreateSourceData() As List(Of SalesPersonData)
'INSTANT VB NOTE: The variable data was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim data_Renamed As New List(Of SalesPersonData)()
			Dim salesPersons() As String = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio", "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" }
			Dim seed As Integer = CInt(Date.Now.Ticks) And &HFFFF
			Dim rand As New Random(seed)

			For i As Integer = 0 To 9999
				Dim record As New SalesPersonData()

				record.SalesPerson = salesPersons(rand.Next(0, salesPersons.Length))
				record.Quantity = (New Random(seed)).Next(0, 100)
				data_Renamed.Add(record)
			Next i
			Return data_Renamed
		End Function
	End Class
End Namespace