using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CobroServicios.AdminDB
{
    class TParamConexionSql
    {
        private SqlConnectionStringBuilder ConectorSql = new SqlConnectionStringBuilder();

        public TParamConexionSql()
        {
            ConectorSql.DataSource = "DESKTOP-27BVAGI";
            ConectorSql.InitialCatalog = "COBROSERVICIOS";
            ConectorSql.UserID = "sa";
            ConectorSql.Password = "Admin%123";


        }

    }
}
