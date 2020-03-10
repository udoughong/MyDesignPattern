using System;

namespace SDP_SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageStores store = new BeverageStores(new SimpleBeverageFactory());//1
            Console.WriteLine("A 客人點了綠茶");
            store.BeverageOrders("GreenTea");
            Console.WriteLine("B 客人點了紅茶");
            store.BeverageOrders("BlackTea");
            Console.ReadLine();
        }
    }
}
/*
A 客人點了綠茶
店員:加入綠茶包
店員:沖泡
店員:將綠茶裝杯
B 客人點了紅茶
店員:加入紅茶包
店員:沖泡
店員:將紅茶裝杯
 */
