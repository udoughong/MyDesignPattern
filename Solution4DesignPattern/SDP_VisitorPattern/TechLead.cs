using System;

namespace SDP_VisitorPattern
{
    public class TechLead : Visitable
    {
        private string name;
        private double salary;
        public TechLead(String name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public String GetName()
        {
            return name;
        }
        public double GetSalary()
        {
            //Business logic to calculate salary
            return salary;
        }
        public void Accept(Visitor v)
        {
            v.VisitTechLead(this);
        }
    }
}