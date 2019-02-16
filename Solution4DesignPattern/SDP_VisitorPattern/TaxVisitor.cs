using System;

namespace SDP_VisitorPattern
{
    class TaxVisitor : Visitor
    {
        //Can be used to accumulate the total tax of the employees
        private double totalTax;
        public override void VisitProgrammer(Programmer p)
        {
            //Business logic to calculate tax of programmers
            double tax = p.GetSalary() * 0.1f;
            totalTax += tax;
        }

        public override void VisitTechLead(TechLead t)
        {
            //Business logic to calculate tax of tech leads
            double tax = t.GetSalary() * 0.15f;
            totalTax += tax;
        }
        public void ShowTotalTax()
        {
            Console.WriteLine("Total tax:{0}", totalTax);
        }
    }
}