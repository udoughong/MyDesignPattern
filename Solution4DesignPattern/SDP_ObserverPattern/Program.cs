using System;
using System.Collections.Generic;

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
