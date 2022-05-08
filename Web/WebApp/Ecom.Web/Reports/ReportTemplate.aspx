﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportTemplate.aspx.cs" Inherits="Ecom.Web.Reports.ReportTemplate" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="scriptReport" runat="server"></asp:ScriptManager>
            <rsweb:ReportViewer runat="server" ID="rvSite" Width="1200" ShowPrintButton="false"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
