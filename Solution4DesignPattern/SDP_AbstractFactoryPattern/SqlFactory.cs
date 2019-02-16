namespace SDP_AbstractFactoryPattern
{
    public class SqlFactory : DbFactory
    {
        public override Connection CreateConnection => new SqlConnection();
        public override Command CreateCommean => new SqlCommand();
        public override Transaction CreateTransaction => new SqlTransaction();
    }
}
