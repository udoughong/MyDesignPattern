using System;

namespace SDP_BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BudgetTour bt = new BudgetTour();
            TourAgent agent1 = new TourAgent(bt);
            agent1.BuildTour();
            LuxuryTour lt = new LuxuryTour();
            TourAgent agent2 = new TourAgent(lt);
            agent2.BuildTour();
            Console.ReadLine();
        }
    }
}
/*
[BudgetTour] Book a budget hotel
[BudgetTour] Book a budget restaurant
[BudgetTour] Book train tickets
[LuxuryTour] Book a 5-star hotel
[LuxuryTour] Book a 5-star restaurant
[LuxuryTour] Book first class tickets
[LuxuryTour] Book table in Casino
*/
