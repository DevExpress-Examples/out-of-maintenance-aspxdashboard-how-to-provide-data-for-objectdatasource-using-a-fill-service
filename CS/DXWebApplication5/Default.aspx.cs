using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;

namespace DXWebApplication5 {
    public partial class Default1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage);

            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("Object Data Source", typeof(SalesPersonData));
            dataSourceStorage.RegisterDataSource("objDataSource", objDataSource.SaveToXml());
            ASPxDashboard1.SetDataSourceStorage(dataSourceStorage);

            ASPxDashboard1.ServiceContainer.AddService(typeof(IObjectDataSourceCustomFillService), new CustomObjectDataSourceCustomFillService());
        }
    }
}