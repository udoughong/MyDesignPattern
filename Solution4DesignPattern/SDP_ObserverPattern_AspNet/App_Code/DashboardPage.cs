using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDP_ObserverPattern_AspNet
{
    public class DashboardPage : System.Web.UI.Page
    {
#pragma warning disable CS0436 // 類型與所匯入的類型衝突
        private List<IReport> _ReportCollection = new List<IReport>();
#pragma warning restore CS0436 // 類型與所匯入的類型衝突

        public string SelectedProduct { get; set; }
        public DateTime SelectedDate { get; set; }

        public DashboardPage()
        {
        }

#pragma warning disable CS0436 // 類型與所匯入的類型衝突
        public void Add(IReport module)
#pragma warning restore CS0436 // 類型與所匯入的類型衝突
        {
            if (module == null)
            {
                throw new ArgumentNullException(nameof(module));
            }

            _ReportCollection.Add(module);
        }

#pragma warning disable CS0436 // 類型與所匯入的類型衝突
        public void Remove(IReport module)
#pragma warning restore CS0436 // 類型與所匯入的類型衝突
        {
            if (module == null)
            {
                throw new ArgumentNullException(nameof(module));
            }

            _ReportCollection.Remove(module);
        }

        public void Update()
        {
            foreach (var m in _ReportCollection)
            {
                m.Update(this);
            }
        }
    }
}