namespace SDP_ObserverPattern_NewsPaper
{
    public interface ISubject
    {
        void RegisterObserver(IObserver pObserver);
        void RemoveObserver(IObserver pObserver);
        void notifyObservers(string pContent);
    }
}
