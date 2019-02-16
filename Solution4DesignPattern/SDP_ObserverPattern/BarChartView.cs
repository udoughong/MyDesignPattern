using System;

namespace SDP_ObserverPattern
{
    class BarChartView : View
    {
        public override void Update(string data)
        {
            Console.WriteLine("[BarChartView]Notified of data change "/*+data*/);
        }
    }
}