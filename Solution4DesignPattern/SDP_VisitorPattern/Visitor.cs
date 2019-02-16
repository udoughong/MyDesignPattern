namespace SDP_VisitorPattern
{
    public abstract class Visitor
    {
        public abstract void VisitProgrammer(Programmer p);
        public abstract void VisitTechLead(TechLead t);
    }
}