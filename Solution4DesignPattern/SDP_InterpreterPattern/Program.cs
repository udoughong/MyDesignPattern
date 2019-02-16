using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PolishUsage();
            Console.ReadLine();
        }

        static void PolishUsage()
        {
            SDP_InterpreterPattern.Expression op1 = new SDP_InterpreterPattern.IntegerExpression(5);
            SDP_InterpreterPattern.Expression op2 = new SDP_InterpreterPattern.IntegerExpression(8);
            SDP_InterpreterPattern.Expression exp = new AdditionExpression(op1,op2);
            Console.WriteLine(exp.Evaluate());
        }
    }
}
