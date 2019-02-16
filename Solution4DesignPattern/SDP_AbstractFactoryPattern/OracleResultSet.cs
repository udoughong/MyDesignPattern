using System;

namespace SDP_AbstractFactoryPattern
{
    internal class OracleResultSet : ResultSet
    {
        public override void HasNext() => Console.WriteLine("[OracleResultSet] HasNext");
    }
}
