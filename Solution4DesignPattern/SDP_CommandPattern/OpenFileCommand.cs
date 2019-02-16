using System;

namespace SDP_CommandPattern
{
    class OpenFileCommand : CommandListener
    {
        Application app;

        public OpenFileCommand(Application app)
        {
            this.app = app;
        }

        public void Execute()
        {
            Console.WriteLine("[OpenFileCommand] Execute");
            app.OpenFile();
        }
    }
}