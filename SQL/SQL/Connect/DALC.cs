using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Connect
{
    public class Dalc
    {
       public static string GetConnect
        {
            get { return "Data Source = DESKTOP-SQ9BA76\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True"; }
        }
    }
}
