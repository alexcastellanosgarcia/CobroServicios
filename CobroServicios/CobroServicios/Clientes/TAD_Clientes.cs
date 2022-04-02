using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CobroServicios.Modelo;
using CobroServicios.AdminDB;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace CobroServicios.Clientes
{
    class TAD_Clientes
    {
        TModelClientes ObjCliente = new TModelClientes(); //Instanciacion de modelo cliente.
        TParamConexionSql ObjetoConexionSql = new TParamConexionSql(); //Instanciacion de conexion Sql.


        public TAD_Clientes()
        {

        }
        public TModelClientes Consultar(int Id)
        {            
            using (SqlConnection conexion = new SqlConnection(ObjetoConexionSql.getStringConexion()))
            {                                
                try
                {
                    conexion.Open();
                    SqlCommand query = new SqlCommand($"SELECT * FROM CLIENTES WHERE ID = {Id}", conexion);
                    DataTable dtClientes = new DataTable();
                    dtClientes.Load(query.ExecuteReader());                    
                    if (dtClientes.Rows.Count > 0)
                    {
                        foreach (DataRow Fila in dtClientes.Rows)
                        {
                            ObjCliente.Id = Convert.ToInt32(Fila["ID"].ToString());
                            ObjCliente.Identidad = Fila["IDENTIDAD"].ToString();
                            ObjCliente.Nombre = Fila["NOMBRE"].ToString();
                            ObjCliente.Direccion = Fila["DIRECCION"].ToString();
                            ObjCliente.Telefono = Fila["TELEFONO"].ToString();
                            ObjCliente.Correo = Fila["CORREO"].ToString();
                            ObjCliente.Municipio = Fila["MUNICIPIO"].ToString();                                                      
                            ObjCliente.UsuarioCreacion = Fila["USUARIO_CREACION"].ToString();
                            ObjCliente.UsuarioModificacion = Fila["USUARIO_MODIFICACION"].ToString();
                            /*DateTime Fecha_Creacion = new DateTime();
                            ObjCliente.UsuarioCreacion = (DateTime.TryParse(Fila["FECHA_CREACION"].ToString(), out Fecha_Creacion));*/
                        }
                    }
                    conexion.Close();
                }
                catch(Exception Err)
                {
                    MessageBox.Show($"La Operacion no se pudo Completar \n{Err.Message}");
                }
            }

            return ObjCliente;
        }

        public bool Guardar(TModelClientes prmCliente) 
        {
            return false;
        }

        public bool Actualizar(TModelClientes prmCliente)
        {
            return false;
        }

        public bool Anular(int prmIdCliente)
        {
            return false;
        }



    }
}
