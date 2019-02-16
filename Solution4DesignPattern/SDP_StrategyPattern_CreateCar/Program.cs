using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StrategyPattern_CreateCar
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTransfer dt = new DataTransfer();
            dt.SetProtocol(new Bluetooth());
            dt.LoadStream();
            dt.SendStream();
        }
    }
}
