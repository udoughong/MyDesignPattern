using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDP_ObserverPattern_AspNet
{
    public partial class SalesReport1 : System.Web.UI.UserControl, IReport
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region IReport Members

        public void Update(DashboardPage page)
        {
            this.Label1.Text = page.SelectedProduct;
            this.Label2.Text = page.SelectedDate.ToLongDateString();
        }

        #endregion
    }
}