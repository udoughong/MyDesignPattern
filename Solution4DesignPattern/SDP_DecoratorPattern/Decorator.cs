namespace SDP_DecoratorPattern
{
    abstract class Decorator:Stream
    {
        Stream stream;

        public Decorator(Stream s)
        {
            stream = s;
        }

        public override void Write()
        {
            stream.Write();
        }

        public override void Read()
        {
            stream.Read();
        }
    }
}