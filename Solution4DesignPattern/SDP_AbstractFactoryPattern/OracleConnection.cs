using System;

namespace SDP_AbstractFactoryPattern
{
    internal class OracleConnection : Connection
    {
        public override void Connect() => Console.WriteLine("[OracleConnection] Connection");
    }
}
