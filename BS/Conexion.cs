using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BS
{
    public class Conexion
    {
        public static SqlConnection obtenerc() 
        {
          SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=formulario;Data Source=DESKTOP-E4EN6EA\\SQLEXPRESS");
            con.Open();

            return con;
        }
    }
}
