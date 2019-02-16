using System.Collections.Generic;

namespace SDP_VisitorPattern
{
    class Organization
    {
        List<Visitable> employees = new List<Visitable>();
        public void VisitEmployees(Visitor v)
        {
            foreach (Visitable item in employees)
            {
                item.Accept(v);
            }
        }
        public void Add(Visitable visitable)
        {
            employees.Add(visitable);
        }
        //Implementation
    }
}