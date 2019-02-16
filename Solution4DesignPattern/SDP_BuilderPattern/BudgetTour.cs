using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BuilderPattern
{
    class BudgetTour : TourBuilder
    {
        public override void BookHotel()
        {
            Console.WriteLine("[BudgetTour] Book a budget hotel");
        }

        public override void BookRestaurant()
        {
            Console.WriteLine("[BudgetTour] Book a budget restaurant");
        }

        public override void BookTickets()
        {
            Console.WriteLine("[BudgetTour] Book train tickets");
        }
    }
}
