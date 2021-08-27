<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/170140470/18.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830466)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:
* [CustomObjectDataSourceCustomFillService.cs](./CS/DXWebApplication5/CustomObjectDataSourceCustomFillService.cs) (VB: [CustomObjectDataSourceCustomFillService.vb](./VB/DXWebApplication5/CustomObjectDataSourceCustomFillService.vb))
* [SalesPersonData.cs](./CS/DXWebApplication5/SalesPersonData.cs) (VB: [SalesPersonData.vb](./VB/DXWebApplication5/SalesPersonData.vb))
* [Default.aspx](./CS/DXWebApplication5/Default.aspx) (VB: [Default.aspx](./VB/DXWebApplication5/Default.aspx))
* [Default.aspx.cs](./CS/DXWebApplication5/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/DXWebApplication5/Default.aspx.vb))
<!-- default file list end -->
# Dashboard for Web Forms - How to Use a Service to Fill the ObjectDataSource
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/170140470/)**
<!-- run online end -->

This example shows how to bind the [ASP.NET Web Forms Dashboard Control](https://docs.devexpress.com/Dashboard/16976) to the [Object Data Source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardObjectDataSource) and supply it with data using a custom fill service by implementing a [IObjectDataSourceCustomFillService](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.IObjectDataSourceCustomFillService) interface. In this example, the [ObjectDataSourceFillParameters.Parameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ObjectDataSourceFillParameters.Parameters) collection of dashboard parameters is used to load the specified number of records.

![screenshot](images/screenshot.png)

## Documentation

- [Object Data Source](https://docs.devexpress.com/Dashboard/401410/)
- [IObjectDataSourceCustomFillService](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.IObjectDataSourceCustomFillService)

## Examples

- [Dashboard for Web Forms - How to provide data for ObjectDataSource using the DataLoading event](https://github.com/DevExpress-Examples/aspxdashboard-how-to-provide-data-for-objectdatasource-using-the-dataloading-event-t428195)
- [Dashboard for Web Forms - How to replace DashboardSqlDataSource with DashboardObjectDataSource with filtered data](https://github.com/DevExpress-Examples/how-to-replace-dashboardsqldatasource-with-dashboardobjectdatasource-with-filtered-data-t556759)
- [Dashboard for MVC - How to provide data for ObjectDataSource using a fill service](https://github.com/DevExpress-Examples/aspnet-mvc-dashboard-how-to-provide-data-for-objectdatasource-using-a-fill-service-t583015)
