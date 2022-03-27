
namespace CobroServicios.Herramientas
{
    partial class frmLogin
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxusuario = new MaterialSkin.Controls.MaterialTextBox();
            this.tbxpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEntrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(136, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(136, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            // 
            // tbxusuario
            // 
            this.tbxusuario.AnimateReadOnly = false;
            this.tbxusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxusuario.Depth = 0;
            this.tbxusuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxusuario.LeadingIcon = null;
            this.tbxusuario.Location = new System.Drawing.Point(240, 87);
            this.tbxusuario.MaxLength = 50;
            this.tbxusuario.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxusuario.Multiline = false;
            this.tbxusuario.Name = "tbxusuario";
            this.tbxusuario.Size = new System.Drawing.Size(199, 50);
            this.tbxusuario.TabIndex = 2;
            this.tbxusuario.Text = "";
            this.tbxusuario.TrailingIcon = null;
            // 
            // tbxpassword
            // 
            this.tbxpassword.AnimateReadOnly = false;
            this.tbxpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxpassword.Depth = 0;
            this.tbxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbxpassword.LeadingIcon = null;
            this.tbxpassword.Location = new System.Drawing.Point(240, 162);
            this.tbxpassword.MaxLength = 50;
            this.tbxpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbxpassword.Multiline = false;
            this.tbxpassword.Name = "tbxpassword";
            this.tbxpassword.Size = new System.Drawing.Size(199, 50);
            this.tbxpassword.TabIndex = 3;
            this.tbxpassword.Text = "";
            this.tbxpassword.TrailingIcon = null;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.HighEmphasis = true;
            this.btnEntrar.Icon = null;
            this.btnEntrar.Location = new System.Drawing.Point(264, 239);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEntrar.Size = new System.Drawing.Size(158, 36);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEntrar.UseAccentColor = false;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 309);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxpassword);
            this.Controls.Add(this.tbxusuario);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox tbxusuario;
        private MaterialSkin.Controls.MaterialTextBox tbxpassword;
        private MaterialSkin.Controls.MaterialButton btnEntrar;
    }
}