<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DXWebApplication5.Default1" %>

<%@ Register Assembly="DevExpress.Dashboard.v18.2.Web.WebForms, Version=18.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position: absolute;top: 0;left: 0; bottom: 0;right: 0;overflow: hidden;">
            <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" Width="100%" Height="100%" UseNeutralFilterMode="true">
            </dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>
