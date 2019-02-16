using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BuilderPattern
{
    class TourAgent
    {
        TourBuilder builder;
        public TourAgent(TourBuilder b)
        {
            builder = b;
        }
        public void BuildTour()
        {
            builder.BookHotel();
            builder.BookRestaurant();
            builder.BookTickets();
            builder.BookExtras();
        }
    }
}
