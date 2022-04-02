
namespace CobroServicios.Clientes
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnbuscar = new MaterialSkin.Controls.MaterialButton();
            this.lblnombre = new MaterialSkin.Controls.MaterialLabel();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lblidentidad = new MaterialSkin.Controls.MaterialLabel();
            this.txtidentidad = new MaterialSkin.Controls.MaterialTextBox();
            this.lblid = new MaterialSkin.Controls.MaterialLabel();
            this.txtid = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txttelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmunicipio = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.txtdireccion);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txtmunicipio);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtcorreo);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txttelefono);
            this.materialCard1.Controls.Add(this.btnbuscar);
            this.materialCard1.Controls.Add(this.lblnombre);
            this.materialCard1.Controls.Add(this.txtnombre);
            this.materialCard1.Controls.Add(this.lblidentidad);
            this.materialCard1.Controls.Add(this.txtidentidad);
            this.materialCard1.Controls.Add(this.lblid);
            this.materialCard1.Controls.Add(this.txtid);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(739, 638);
            this.materialCard1.TabIndex = 0;
            // 
            // btnbuscar
            // 
            this.btnbuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnbuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnbuscar.Depth = 0;
            this.btnbuscar.HighEmphasis = true;
            this.btnbuscar.Icon = null;
            this.btnbuscar.Location = new System.Drawing.Point(342, 21);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnbuscar.Size = new System.Drawing.Size(77, 36);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnbuscar.UseAccentColor = false;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Depth = 0;
            this.lblnombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblnombre.Location = new System.Drawing.Point(16, 113);
            this.lblnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 19);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(161, 82);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(283, 50);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            this.txtnombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // lblidentidad
            // 
            this.lblidentidad.AutoSize = true;
            this.lblidentidad.Depth = 0;
            this.lblidentidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblidentidad.Location = new System.Drawing.Point(17, 254);
            this.lblidentidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblidentidad.Name = "lblidentidad";
            this.lblidentidad.Size = new System.Drawing.Size(67, 19);
            this.lblidentidad.TabIndex = 3;
            this.lblidentidad.Text = "Direccion";
            // 
            // txtidentidad
            // 
            this.txtidentidad.AnimateReadOnly = false;
            this.txtidentidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidentidad.Depth = 0;
            this.txtidentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtidentidad.LeadingIcon = null;
            this.txtidentidad.Location = new System.Drawing.Point(161, 152);
            this.txtidentidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidentidad.MaxLength = 50;
            this.txtidentidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtidentidad.Multiline = false;
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(283, 50);
            this.txtidentidad.TabIndex = 2;
            this.txtidentidad.Text = "";
            this.txtidentidad.TrailingIcon = null;
            this.txtidentidad.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Depth = 0;
            this.lblid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblid.Location = new System.Drawing.Point(17, 47);
            this.lblid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(66, 19);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Cliente Id";
            // 
            // txtid
            // 
            this.txtid.AnimateReadOnly = false;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Depth = 0;
            this.txtid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtid.LeadingIcon = null;
            this.txtid.Location = new System.Drawing.Point(161, 17);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.MaxLength = 50;
            this.txtid.MouseState = MaterialSkin.MouseState.OUT;
            this.txtid.Multiline = false;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(137, 50);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "";
            this.txtid.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 322);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.AnimateReadOnly = false;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono.Depth = 0;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txttelefono.LeadingIcon = null;
            this.txttelefono.Location = new System.Drawing.Point(161, 291);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttelefono.MaxLength = 50;
            this.txttelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txttelefono.Multiline = false;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(283, 50);
            this.txttelefono.TabIndex = 7;
            this.txttelefono.Text = "";
            this.txttelefono.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 392);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.AnimateReadOnly = false;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Depth = 0;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcorreo.LeadingIcon = null;
            this.txtcorreo.Location = new System.Drawing.Point(161, 361);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcorreo.MaxLength = 50;
            this.txtcorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcorreo.Multiline = false;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(283, 50);
            this.txtcorreo.TabIndex = 9;
            this.txtcorreo.Text = "";
            this.txtcorreo.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 454);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Municipio";
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.AnimateReadOnly = false;
            this.txtmunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmunicipio.Depth = 0;
            this.txtmunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmunicipio.LeadingIcon = null;
            this.txtmunicipio.Location = new System.Drawing.Point(161, 423);
            this.txtmunicipio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmunicipio.MaxLength = 50;
            this.txtmunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmunicipio.Multiline = false;
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(283, 50);
            this.txtmunicipio.TabIndex = 11;
            this.txtmunicipio.Text = "";
            this.txtmunicipio.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 510);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Fecha Nacim.";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(16, 183);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Identidad";
            // 
            // txtdireccion
            // 
            this.txtdireccion.AnimateReadOnly = false;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdireccion.LeadingIcon = null;
            this.txtdireccion.Location = new System.Drawing.Point(161, 223);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdireccion.MaxLength = 50;
            this.txtdireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdireccion.Multiline = false;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(283, 50);
            this.txtdireccion.TabIndex = 15;
            this.txtdireccion.Text = "";
            this.txtdireccion.TrailingIcon = null;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 732);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmClientes";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblnombre;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialLabel lblidentidad;
        private MaterialSkin.Controls.MaterialTextBox txtidentidad;
        private MaterialSkin.Controls.MaterialLabel lblid;
        private MaterialSkin.Controls.MaterialTextBox txtid;
        private MaterialSkin.Controls.MaterialButton btnbuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtmunicipio;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtcorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txttelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtdireccion;
    }
}