using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BuilderPattern
{
    class LuxuryTour : TourBuilder
    {
        public override void BookHotel()
        {
            Console.WriteLine("[LuxuryTour] Book a 5-star hotel");
        }

        public override void BookRestaurant()
        {
            Console.WriteLine("[LuxuryTour] Book a 5-star restaurant");
        }

        public override void BookTickets()
        {
            Console.WriteLine("[LuxuryTour] Book first class tickets");
        }

        public override void BookExtras()
        {
            Console.WriteLine("[LuxuryTour] Book table in Casino");
        }
    }
}
