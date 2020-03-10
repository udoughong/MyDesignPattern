using System;

namespace SDP_FactoryMethodPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.SetFactory(new TextDocFactory());
            controller.Initialize();
            controller.SetFactory(new SpreadSheetDocFactory());
            controller.Initialize();
            Console.Read();
        }
    }
}
/*Output:
[TextDocument] Open
[SpreadSheetDocument] Open
 */
