
namespace CobroServicios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.TabMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabOpcionClientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClienteRegistro = new System.Windows.Forms.TabPage();
            this.tabClienteConsulta = new System.Windows.Forms.TabPage();
            this.tabSelectorClientes = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabSelectorServicios = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionServicios = new MaterialSkin.Controls.MaterialTabControl();
            this.tabServicioConsultas = new System.Windows.Forms.TabPage();
            this.tabServiciosConsultas = new System.Windows.Forms.TabPage();
            this.tabServiciosPrecios = new System.Windows.Forms.TabPage();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.tabSelectorPagos = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionPagos = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPagosListamora = new System.Windows.Forms.TabPage();
            this.tabPagosPlanespago = new System.Windows.Forms.TabPage();
            this.tabPagosNotificaciones = new System.Windows.Forms.TabPage();
            this.tabConfiguraciones = new System.Windows.Forms.TabPage();
            this.tabSelectorConfiguracion = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcionConfiguracion = new MaterialSkin.Controls.MaterialTabControl();
            this.tabConfiguracionUsuarios = new System.Windows.Forms.TabPage();
            this.tabConfiguracionAccesos = new System.Windows.Forms.TabPage();
            this.tabConfiguracionModulos = new System.Windows.Forms.TabPage();
            this.tabConfiguracionParametros = new System.Windows.Forms.TabPage();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.TabMenuPrincipal.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabOpcionClientes.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.tabOpcionServicios.SuspendLayout();
            this.tabPagos.SuspendLayout();
            this.tabOpcionPagos.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.tabOpcionConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenuPrincipal
            // 
            this.TabMenuPrincipal.Controls.Add(this.tabClientes);
            this.TabMenuPrincipal.Controls.Add(this.tabServicios);
            this.TabMenuPrincipal.Controls.Add(this.tabPagos);
            this.TabMenuPrincipal.Controls.Add(this.tabConfiguraciones);
            this.TabMenuPrincipal.Depth = 0;
            this.TabMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMenuPrincipal.ImageList = this.listaImagenes;
            this.TabMenuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.TabMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMenuPrincipal.Multiline = true;
            this.TabMenuPrincipal.Name = "TabMenuPrincipal";
            this.TabMenuPrincipal.SelectedIndex = 0;
            this.TabMenuPrincipal.Size = new System.Drawing.Size(1323, 699);
            this.TabMenuPrincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabOpcionClientes);
            this.tabClientes.Controls.Add(this.tabSelectorClientes);
            this.tabClientes.ImageKey = "clientes.png";
            this.tabClientes.Location = new System.Drawing.Point(4, 25);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1315, 670);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabOpcionClientes
            // 
            this.tabOpcionClientes.Controls.Add(this.tabClienteRegistro);
            this.tabOpcionClientes.Controls.Add(this.tabClienteConsulta);
            this.tabOpcionClientes.Depth = 0;
            this.tabOpcionClientes.Location = new System.Drawing.Point(6, 52);
            this.tabOpcionClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionClientes.Multiline = true;
            this.tabOpcionClientes.Name = "tabOpcionClientes";
            this.tabOpcionClientes.SelectedIndex = 0;
            this.tabOpcionClientes.Size = new System.Drawing.Size(1304, 441);
            this.tabOpcionClientes.TabIndex = 1;
            // 
            // tabClienteRegistro
            // 
            this.tabClienteRegistro.Location = new System.Drawing.Point(4, 25);
            this.tabClienteRegistro.Name = "tabClienteRegistro";
            this.tabClienteRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabClienteRegistro.Size = new System.Drawing.Size(1296, 412);
            this.tabClienteRegistro.TabIndex = 0;
            this.tabClienteRegistro.Text = "Registro";
            this.tabClienteRegistro.UseVisualStyleBackColor = true;
            // 
            // tabClienteConsulta
            // 
            this.tabClienteConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabClienteConsulta.Name = "tabClienteConsulta";
            this.tabClienteConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabClienteConsulta.Size = new System.Drawing.Size(1296, 412);
            this.tabClienteConsulta.TabIndex = 1;
            this.tabClienteConsulta.Text = "Consulta";
            this.tabClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // tabSelectorClientes
            // 
            this.tabSelectorClientes.BaseTabControl = this.tabOpcionClientes;
            this.tabSelectorClientes.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorClientes.Depth = 0;
            this.tabSelectorClientes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorClientes.Location = new System.Drawing.Point(6, 6);
            this.tabSelectorClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorClientes.Name = "tabSelectorClientes";
            this.tabSelectorClientes.Size = new System.Drawing.Size(1304, 40);
            this.tabSelectorClientes.TabIndex = 0;
            this.tabSelectorClientes.Text = "materialTabSelector1";
            this.tabSelectorClientes.Click += new System.EventHandler(this.tabSelectorClientes_Click);
            // 
            // tabServicios
            // 
            this.tabServicios.Controls.Add(this.tabSelectorServicios);
            this.tabServicios.Controls.Add(this.tabOpcionServicios);
            this.tabServicios.ImageKey = "services.png";
            this.tabServicios.Location = new System.Drawing.Point(4, 25);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(1315, 670);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabSelectorServicios
            // 
            this.tabSelectorServicios.BaseTabControl = this.tabOpcionServicios;
            this.tabSelectorServicios.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorServicios.Depth = 0;
            this.tabSelectorServicios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorServicios.Location = new System.Drawing.Point(9, 6);
            this.tabSelectorServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorServicios.Name = "tabSelectorServicios";
            this.tabSelectorServicios.Size = new System.Drawing.Size(1300, 40);
            this.tabSelectorServicios.TabIndex = 3;
            this.tabSelectorServicios.Text = "materialTabSelector1";
            // 
            // tabOpcionServicios
            // 
            this.tabOpcionServicios.Controls.Add(this.tabServicioConsultas);
            this.tabOpcionServicios.Controls.Add(this.tabServiciosConsultas);
            this.tabOpcionServicios.Controls.Add(this.tabServiciosPrecios);
            this.tabOpcionServicios.Depth = 0;
            this.tabOpcionServicios.Location = new System.Drawing.Point(6, 47);
            this.tabOpcionServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionServicios.Multiline = true;
            this.tabOpcionServicios.Name = "tabOpcionServicios";
            this.tabOpcionServicios.SelectedIndex = 0;
            this.tabOpcionServicios.Size = new System.Drawing.Size(1304, 617);
            this.tabOpcionServicios.TabIndex = 2;
            // 
            // tabServicioConsultas
            // 
            this.tabServicioConsultas.Location = new System.Drawing.Point(4, 25);
            this.tabServicioConsultas.Name = "tabServicioConsultas";
            this.tabServicioConsultas.Size = new System.Drawing.Size(1296, 588);
            this.tabServicioConsultas.TabIndex = 2;
            this.tabServicioConsultas.Text = "Registro";
            this.tabServicioConsultas.UseVisualStyleBackColor = true;
            this.tabServicioConsultas.Click += new System.EventHandler(this.tabServicioConsultas_Click);
            // 
            // tabServiciosConsultas
            // 
            this.tabServiciosConsultas.Location = new System.Drawing.Point(4, 25);
            this.tabServiciosConsultas.Name = "tabServiciosConsultas";
            this.tabServiciosConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiciosConsultas.Size = new System.Drawing.Size(1296, 588);
            this.tabServiciosConsultas.TabIndex = 0;
            this.tabServiciosConsultas.Text = "Consultas";
            this.tabServiciosConsultas.UseVisualStyleBackColor = true;
            // 
            // tabServiciosPrecios
            // 
            this.tabServiciosPrecios.Location = new System.Drawing.Point(4, 25);
            this.tabServiciosPrecios.Name = "tabServiciosPrecios";
            this.tabServiciosPrecios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiciosPrecios.Size = new System.Drawing.Size(1296, 588);
            this.tabServiciosPrecios.TabIndex = 1;
            this.tabServiciosPrecios.Text = "Precios";
            this.tabServiciosPrecios.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            this.tabPagos.Controls.Add(this.tabSelectorPagos);
            this.tabPagos.Controls.Add(this.tabOpcionPagos);
            this.tabPagos.ImageKey = "pagos.png";
            this.tabPagos.Location = new System.Drawing.Point(4, 25);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Size = new System.Drawing.Size(1315, 670);
            this.tabPagos.TabIndex = 2;
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
            // 
            // tabSelectorPagos
            // 
            this.tabSelectorPagos.BaseTabControl = this.tabOpcionPagos;
            this.tabSelectorPagos.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorPagos.Depth = 0;
            this.tabSelectorPagos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorPagos.Location = new System.Drawing.Point(7, 6);
            this.tabSelectorPagos.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorPagos.Name = "tabSelectorPagos";
            this.tabSelectorPagos.Size = new System.Drawing.Size(1300, 40);
            this.tabSelectorPagos.TabIndex = 4;
            this.tabSelectorPagos.Text = "materialTabSelector1";
            // 
            // tabOpcionPagos
            // 
            this.tabOpcionPagos.Controls.Add(this.tabPagosListamora);
            this.tabOpcionPagos.Controls.Add(this.tabPagosPlanespago);
            this.tabOpcionPagos.Controls.Add(this.tabPagosNotificaciones);
            this.tabOpcionPagos.Depth = 0;
            this.tabOpcionPagos.Location = new System.Drawing.Point(3, 52);
            this.tabOpcionPagos.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionPagos.Multiline = true;
            this.tabOpcionPagos.Name = "tabOpcionPagos";
            this.tabOpcionPagos.SelectedIndex = 0;
            this.tabOpcionPagos.Size = new System.Drawing.Size(1304, 441);
            this.tabOpcionPagos.TabIndex = 3;
            // 
            // tabPagosListamora
            // 
            this.tabPagosListamora.Location = new System.Drawing.Point(4, 25);
            this.tabPagosListamora.Name = "tabPagosListamora";
            this.tabPagosListamora.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagosListamora.Size = new System.Drawing.Size(1296, 412);
            this.tabPagosListamora.TabIndex = 0;
            this.tabPagosListamora.Text = "Lista Moras";
            this.tabPagosListamora.UseVisualStyleBackColor = true;
            // 
            // tabPagosPlanespago
            // 
            this.tabPagosPlanespago.Location = new System.Drawing.Point(4, 25);
            this.tabPagosPlanespago.Name = "tabPagosPlanespago";
            this.tabPagosPlanespago.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagosPlanespago.Size = new System.Drawing.Size(1296, 412);
            this.tabPagosPlanespago.TabIndex = 1;
            this.tabPagosPlanespago.Text = "Planes de Pago";
            this.tabPagosPlanespago.UseVisualStyleBackColor = true;
            // 
            // tabPagosNotificaciones
            // 
            this.tabPagosNotificaciones.Location = new System.Drawing.Point(4, 25);
            this.tabPagosNotificaciones.Name = "tabPagosNotificaciones";
            this.tabPagosNotificaciones.Size = new System.Drawing.Size(1296, 412);
            this.tabPagosNotificaciones.TabIndex = 2;
            this.tabPagosNotificaciones.Text = "Notificaciones";
            this.tabPagosNotificaciones.UseVisualStyleBackColor = true;
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.tabSelectorConfiguracion);
            this.tabConfiguraciones.Controls.Add(this.tabOpcionConfiguracion);
            this.tabConfiguraciones.ImageKey = "preference.png";
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.Size = new System.Drawing.Size(1315, 670);
            this.tabConfiguraciones.TabIndex = 3;
            this.tabConfiguraciones.Text = "Configuraciones";
            this.tabConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // tabSelectorConfiguracion
            // 
            this.tabSelectorConfiguracion.BaseTabControl = this.tabOpcionConfiguracion;
            this.tabSelectorConfiguracion.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelectorConfiguracion.Depth = 0;
            this.tabSelectorConfiguracion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorConfiguracion.Location = new System.Drawing.Point(7, 3);
            this.tabSelectorConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorConfiguracion.Name = "tabSelectorConfiguracion";
            this.tabSelectorConfiguracion.Size = new System.Drawing.Size(1296, 40);
            this.tabSelectorConfiguracion.TabIndex = 5;
            this.tabSelectorConfiguracion.Text = "materialTabSelector1";
            // 
            // tabOpcionConfiguracion
            // 
            this.tabOpcionConfiguracion.Controls.Add(this.tabConfiguracionUsuarios);
            this.tabOpcionConfiguracion.Controls.Add(this.tabConfiguracionAccesos);
            this.tabOpcionConfiguracion.Controls.Add(this.tabConfiguracionModulos);
            this.tabOpcionConfiguracion.Controls.Add(this.tabConfiguracionParametros);
            this.tabOpcionConfiguracion.Depth = 0;
            this.tabOpcionConfiguracion.Location = new System.Drawing.Point(3, 43);
            this.tabOpcionConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionConfiguracion.Multiline = true;
            this.tabOpcionConfiguracion.Name = "tabOpcionConfiguracion";
            this.tabOpcionConfiguracion.SelectedIndex = 0;
            this.tabOpcionConfiguracion.Size = new System.Drawing.Size(1304, 441);
            this.tabOpcionConfiguracion.TabIndex = 4;
            // 
            // tabConfiguracionUsuarios
            // 
            this.tabConfiguracionUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguracionUsuarios.Name = "tabConfiguracionUsuarios";
            this.tabConfiguracionUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracionUsuarios.Size = new System.Drawing.Size(1296, 412);
            this.tabConfiguracionUsuarios.TabIndex = 0;
            this.tabConfiguracionUsuarios.Text = "Usuarios";
            this.tabConfiguracionUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionAccesos
            // 
            this.tabConfiguracionAccesos.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguracionAccesos.Name = "tabConfiguracionAccesos";
            this.tabConfiguracionAccesos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracionAccesos.Size = new System.Drawing.Size(1296, 412);
            this.tabConfiguracionAccesos.TabIndex = 1;
            this.tabConfiguracionAccesos.Text = "Accesos";
            this.tabConfiguracionAccesos.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionModulos
            // 
            this.tabConfiguracionModulos.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguracionModulos.Name = "tabConfiguracionModulos";
            this.tabConfiguracionModulos.Size = new System.Drawing.Size(1296, 412);
            this.tabConfiguracionModulos.TabIndex = 2;
            this.tabConfiguracionModulos.Text = "Modulos";
            this.tabConfiguracionModulos.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionParametros
            // 
            this.tabConfiguracionParametros.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguracionParametros.Name = "tabConfiguracionParametros";
            this.tabConfiguracionParametros.Size = new System.Drawing.Size(1296, 412);
            this.tabConfiguracionParametros.TabIndex = 3;
            this.tabConfiguracionParametros.Text = "Parametros";
            this.tabConfiguracionParametros.UseVisualStyleBackColor = true;
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "clientes.png");
            this.listaImagenes.Images.SetKeyName(1, "pagos.png");
            this.listaImagenes.Images.SetKeyName(2, "preference.png");
            this.listaImagenes.Images.SetKeyName(3, "services.png");
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 766);
            this.Controls.Add(this.TabMenuPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabMenuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSPAYSER (Sistema Pago de Servicios)";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.TabMenuPrincipal.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabOpcionClientes.ResumeLayout(false);
            this.tabServicios.ResumeLayout(false);
            this.tabOpcionServicios.ResumeLayout(false);
            this.tabPagos.ResumeLayout(false);
            this.tabOpcionPagos.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabOpcionConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabMenuPrincipal;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.TabPage tabConfiguraciones;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionClientes;
        private System.Windows.Forms.TabPage tabClienteRegistro;
        private System.Windows.Forms.TabPage tabClienteConsulta;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorClientes;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionServicios;
        private System.Windows.Forms.TabPage tabServiciosConsultas;
        private System.Windows.Forms.TabPage tabServiciosPrecios;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionPagos;
        private System.Windows.Forms.TabPage tabPagosListamora;
        private System.Windows.Forms.TabPage tabPagosPlanespago;
        private MaterialSkin.Controls.MaterialTabControl tabOpcionConfiguracion;
        private System.Windows.Forms.TabPage tabConfiguracionUsuarios;
        private System.Windows.Forms.TabPage tabConfiguracionAccesos;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorServicios;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorPagos;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorConfiguracion;
        private System.Windows.Forms.TabPage tabServicioConsultas;
        private System.Windows.Forms.TabPage tabConfiguracionModulos;
        private System.Windows.Forms.TabPage tabConfiguracionParametros;
        private System.Windows.Forms.TabPage tabPagosNotificaciones;
        private System.Windows.Forms.ImageList listaImagenes;
    }
}

