namespace SDP_AbstractFactoryPattern
{
    public abstract class DbFactory
    {
        public abstract Connection CreateConnection { get; }

        public abstract Command CreateCommean { get; }

        public abstract Transaction CreateTransaction { get; }
    }
}
