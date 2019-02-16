using System;

namespace SDP_AbstractFactoryPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            DbFactory factory = new SqlFactory();
            transact(new SqlFactory());
            transact(new OracleFactory());
            Console.ReadLine();
        }

        private static void transact(DbFactory db)
        {
            Connection con = db.CreateConnection;
            con.Connect();
            Command cmd = db.CreateCommean;
            ResultSet set = cmd.GetExecute();
            set.HasNext();
            Transaction trans = db.CreateTransaction;
            trans.Transact();
        }
    }
}
