namespace SDP_SimpleFactoryPattern
{
    public class SimpleBeverageFactory
    {
        public IBeverageProvide CreateBeverage(string pBeverageType)
        {
            IBeverageProvide beverage;
            switch (pBeverageType)
            {
                case "GreenTea":
                    beverage = new GreenTea();
                    break;
                case "BlackTea":
                    beverage = new BlackTea();
                    break;
                default:
                    beverage = null;
                    break;
            }
            return beverage;
        }
    }
}