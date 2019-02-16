using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StatePattern
{
    class DbTable
    {
        User user;
        public void SetUser(User user)
        {
            this.user = user;
        }
        public void DisplayState()
        {
            Console.WriteLine("Current user is {0}.",user.ToString());
        }
        public void View()
        {
            user.View();
        }
        public void Write()
        {
            user.Write();
        }
    }
}
