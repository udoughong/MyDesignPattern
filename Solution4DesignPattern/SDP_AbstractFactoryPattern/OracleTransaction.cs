using System;

namespace SDP_AbstractFactoryPattern
{
    internal class OracleTransaction : Transaction
    {
        public override void Transact() => Console.WriteLine("[OracleTransaction] Transact");
    }
}
