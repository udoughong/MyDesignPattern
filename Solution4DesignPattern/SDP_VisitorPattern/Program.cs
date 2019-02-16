using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Organization();
            org.Add(new Programmer("Sameer",1000));
            org.Add(new Programmer("Mubeen",2000));
            org.Add(new TechLead("Yousuf",1000));
            org.Add(new Programmer("Shafiq",2000));
            TaxVisitor tvisitor = new TaxVisitor();
            org.VisitEmployees(tvisitor);
            tvisitor.ShowTotalTax();
            Console.ReadLine();
        }
    }
}
