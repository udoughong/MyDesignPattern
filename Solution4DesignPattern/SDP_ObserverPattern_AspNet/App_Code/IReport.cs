using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_ObserverPattern_AspNet
{
    public interface IReport
    {
#pragma warning disable CS0436 // 類型與所匯入的類型衝突
        void Update(DashboardPage page);
#pragma warning restore CS0436 // 類型與所匯入的類型衝突
    }
}
