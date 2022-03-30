using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CobroServicios.AdminDB
{
    public class TParamConexionSql
    {
        private SqlConnectionStringBuilder ConectorSql = new SqlConnectionStringBuilder();

        public TParamConexionSql()
        {
            ConectorSql.DataSource = "DESKTOP-27BVAGI";
            ConectorSql.InitialCatalog = "COBROSERVICIOS";
            ConectorSql.UserID = "sa";
            ConectorSql.Password = "Admin%123";


        }

        public String getStringConexion() //metodo retorna la cadena de conexion
        {
            return ConectorSql.ConnectionString; 
        }

    }
}
