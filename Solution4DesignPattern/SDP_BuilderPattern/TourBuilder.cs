using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BuilderPattern
{
    abstract class TourBuilder
    {
        public abstract void BookHotel();
        public abstract void BookRestaurant();
        public abstract void BookTickets();
        public virtual void BookExtras()
        {
        }
    }
}
