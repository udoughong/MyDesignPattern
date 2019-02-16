namespace SDP_AbstractFactoryPattern
{
    class OracleFactory : DbFactory
    {
        public override Connection CreateConnection => new OracleConnection();

        public override Command CreateCommean => new OracleCommand();

        public override Transaction CreateTransaction => new OracleTransaction();
    }
}
