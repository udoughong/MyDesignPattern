using System;

namespace SDP_ObserverPattern
{
    class PieChartView : View
    {
        public override void Update(string data)
        {
            Console.WriteLine("[PieChartView]Notified of data change " + data);
        }
    }
}