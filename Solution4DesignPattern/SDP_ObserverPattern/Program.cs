using System;

namespace SDP_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BarChartView barChart = new BarChartView();
            PieChartView pieChart = new PieChartView();
            DataObject dataObject = new DataObject();
            dataObject.AddView(barChart);
            dataObject.AddView(pieChart);
            dataObject.SetData("some data");
            dataObject.LoadData();
            Console.ReadLine();
        }
    }
}
/*Output:
[BarChartView]Notified of data change
[PieChartView]Notified of data change some data
[BarChartView]Notified of data change
[PieChartView]Notified of data change Data is loaded from a file
*/