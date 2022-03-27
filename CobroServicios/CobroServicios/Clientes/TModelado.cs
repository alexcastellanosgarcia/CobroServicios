using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobroServicios.Clientes
{
    public class TModelClientes
    {
        int Id { set; get; }
        String Identidad { set; get; }
        String Nombre { set; get; }
        String Direccion { set; get; }
        String Telefono { set; get; }
        String Correo { set; get; }
        String Municipio { set; get; }
        String FechaNacimiento { set; get; }
        String FechaCreacion { set; get; }
        String FechaModificacion { set; get; }
        String UsuarioCreacion { set; get; }
        String UsuarioModificacion { set; get; }

    }
}
