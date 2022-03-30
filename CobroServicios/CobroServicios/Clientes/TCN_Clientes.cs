using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CobroServicios.Modelo;
using CobroServicios.Clientes;

namespace CobroServicios.Clientes
{
    class TCN_Clientes
    {
        TAD_Clientes ObjAD_Clientes = new TAD_Clientes();

        public TModelClientes Consultar(String Id)
        {
            var Result = int.TryParse(Id, out int ValId);

            if (Result)
                return ObjAD_Clientes.Consultar(ValId);
            else
                return default;            
        }

    }
}
