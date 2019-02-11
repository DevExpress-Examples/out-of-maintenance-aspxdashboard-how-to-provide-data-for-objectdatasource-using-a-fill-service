<!-- default file list -->
*Files to look at*:
* [CustomObjectDataSourceCustomFillService.cs](./CS/DXWebApplication5/CustomObjectDataSourceCustomFillService.cs) (VB: [CustomObjectDataSourceCustomFillService.vb](./VB/DXWebApplication5/CustomObjectDataSourceCustomFillService.vb))
* [SalesPersonData.cs](./CS/DXWebApplication5/SalesPersonData.cs) (VB: [SalesPersonData.cs](./VB/DXWebApplication5/SalesPersonData.cs))
* [Default.aspx](./CS/DXWebApplication5/Default.aspx) (VB: [Default.aspx](./VB/DXWebApplication5/Default.aspx))
* [Default.aspx.cs](./CS/DXWebApplication5/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/DXWebApplication5/Default.aspx.cs))
<!-- default file list end -->
# ASPxDashboard - How to provide data for ObjectDataSource using a fill service

This example shows how to bind the <a href="https://documentation.devexpress.com/Dashboard/16976/Creating-the-Designer-and-Viewer-Applications/Web-Dashboard/ASP-NET-Web-Forms-Dashboard-Control">ASP.NET Web Forms Dashboard Control
</a> to the <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardCommonDashboardObjectDataSourcetopic">Object Data Source</a> and supply it with data using a custom fill service by implementing a <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardCommon.IObjectDataSourceCustomFillService.class">IObjectDataSourceCustomFillService</a> interface. In this example, the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardCommon.ObjectDataSourceFillParameters.DataFields.property">ObjectDataSourceFillParameters.DataFields</a> parameter is used to load data only for required fields.

<br/>
