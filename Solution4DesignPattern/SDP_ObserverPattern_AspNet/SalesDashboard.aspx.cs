using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDP_ObserverPattern_AspNet
{
    public partial class SalesDashboard : DashboardPage
    {
        protected override void OnLoad(EventArgs e)
        {
            SelectedProduct = this.DropDownList1.SelectedValue;
            SelectedDate = this.Calendar1.SelectedDate;

            Add(SalesReport11);
            Add(SalesReport21);

            base.OnLoad(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadProducts();
        }

        private void LoadProducts()
        {
            List<string> products = new List<string>
            {
                "HP",
                "Dell",
                "Microsoft",
                "Google"
            };

            this.DropDownList1.DataSource = products;
            this.DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}