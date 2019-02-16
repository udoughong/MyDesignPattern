using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
