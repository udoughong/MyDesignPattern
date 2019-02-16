namespace SDP_VisitorPattern
{
    public interface Visitable
    {
        void Accept(Visitor v);
    }
}