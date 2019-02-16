using System;

namespace SDP_AbstractFactoryPattern
{
    internal class SqlResultSet : ResultSet
    {
        public override void HasNext() => Console.WriteLine("[SqlResultSet] HasNext");
    }
}
