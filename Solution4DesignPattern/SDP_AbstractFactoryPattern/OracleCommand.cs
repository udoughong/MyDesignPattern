using System;

namespace SDP_AbstractFactoryPattern
{
    internal class OracleCommand : Command
    {
        public override ResultSet GetExecute()
        {
            Console.WriteLine("[OracleCommand] Execute");
            return new OracleResultSet();
        }
    }
}
