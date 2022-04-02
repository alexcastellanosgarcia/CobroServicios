using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CobroServicios.Clientes;

namespace CobroServicios.Clientes
{
    public partial class frmClientes : MaterialForm
    {
        TCN_Clientes ObjCN_clientes = new TCN_Clientes();

        public frmClientes()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            var cliente = ObjCN_clientes.Consultar(txtid.Text);
            if(cliente != null)
            {
                txtidentidad.Text = cliente.Identidad;
                txtnombre.Text = cliente.Nombre;
                txtdireccion.Text = cliente.Direccion;
                txttelefono.Text = cliente.Telefono;
                txtcorreo.Text = cliente.Correo;
                txtmunicipio.Text = cliente.Municipio;             

            }

            
        }
    }
}
