Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System

Namespace DXWebApplication5
	Partial Public Class Default1
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
			ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)

			Dim dataSourceStorage As New DataSourceInMemoryStorage()
			Dim objDataSource As New DashboardObjectDataSource("Object Data Source", GetType(SalesPersonData))
			dataSourceStorage.RegisterDataSource("objDataSource", objDataSource.SaveToXml())
			ASPxDashboard1.SetDataSourceStorage(dataSourceStorage)

			ASPxDashboard1.ServiceContainer.AddService(GetType(IObjectDataSourceCustomFillService), New CustomObjectDataSourceCustomFillService())
		End Sub
	End Class
End Namespace