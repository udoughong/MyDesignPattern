namespace SDP_FactoryMethodPattern
{
    internal class SpreadSheetDocFactory : DocumentFactory
    {
        public override Document Create => new SpreadSheetDocument();
    }
}
