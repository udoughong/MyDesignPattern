namespace SDP_ObserverPattern_NewsPaper
{
    public interface IObserver
    {
        string Name { get; }

        void Update(string pMessage);
    }
}