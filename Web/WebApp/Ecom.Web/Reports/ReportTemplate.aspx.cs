using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom.Web.Reports
{
    public partial class ReportTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rvSite.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
                rvSite.ServerReport.ReportServerUrl = new Uri("https://localhost/ReportServer");
                rvSite.ServerReport.ReportPath = "/EcomDb/" + Request["reportUrl"];
                rvSite.ServerReport.Refresh();
            }
        }
    }
}