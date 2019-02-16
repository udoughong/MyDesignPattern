using System;

namespace SDP_AbstractFactoryPattern
{
    internal class SqlCommand : Command
    {
        public override ResultSet GetExecute()
        {
            Console.WriteLine("[SqlCommand] Execute");
            return new SqlResultSet();
        }
    }
}
