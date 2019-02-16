using System;

namespace SDP_AbstractFactoryPattern
{
    internal class SqlConnection : Connection
    {
        public override void Connect() => Console.WriteLine("[SqlConnection] Connection");
    }
}
