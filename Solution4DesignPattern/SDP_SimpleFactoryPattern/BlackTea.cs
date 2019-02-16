using System;

namespace SDP_SimpleFactoryPattern
{

    public class BlackTea : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("店員:加入紅茶包");
        }

        public void Brew()
        {
            Console.WriteLine("店員:沖泡");
        }

        public void PouredCup()
        {
            Console.WriteLine("店員:將紅茶裝杯");
        }
    }
}