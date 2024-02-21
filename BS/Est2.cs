using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BS
{
    public class Est2
    {
        public static int agregar(Est Est) 
        {
          int retorna = 0;

            using (SqlConnection conn = Conexion.obtenerc()) 
            {
                string query = "insert into Dato (CAR,NOM,APD,ACU,EXA,FIN) values ('"+Est.carnet+ "' , '"+Est.nombre+ "' , '"+Est.apelli+ "' , '"+Est.acum+ "' , '"+Est.exam+ "' , '"+Est.final+"')";
                SqlCommand cmd = new SqlCommand(query,conn);

                retorna = cmd.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
