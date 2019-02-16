using System;

namespace SDP_VisitorPattern
{
    public class Programmer : Visitable
    {
        private string name;
        private double salary;
        public Programmer(String name, double salary)
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
            v.VisitProgrammer(this);
        }
    }
}