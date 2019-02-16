using System;

namespace SDP_AbstractFactoryPattern
{
    internal class SqlTransaction : Transaction
    {
        public override void Transact() => Console.WriteLine("[SqlTransaction] Transact");
    }
}
