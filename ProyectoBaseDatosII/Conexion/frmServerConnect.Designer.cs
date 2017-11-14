namespace ProyectoBaseDatosII
{
    partial class frmServerConnect
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnConectar = new Telerik.WinControls.UI.RadButton();
            this.cboInstancias2 = new System.Windows.Forms.ComboBox();
            this.cboAutentificacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectar)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(80, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Server Name";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(220, 166);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(110, 24);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.ThemeName = "Office2013Light";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cboInstancias2
            // 
            this.cboInstancias2.FormattingEnabled = true;
            this.cboInstancias2.Location = new System.Drawing.Point(186, 30);
            this.cboInstancias2.Name = "cboInstancias2";
            this.cboInstancias2.Size = new System.Drawing.Size(188, 21);
            this.cboInstancias2.TabIndex = 4;
            // 
            // cboAutentificacion
            // 
            this.cboAutentificacion.FormattingEnabled = true;
            this.cboAutentificacion.Location = new System.Drawing.Point(187, 67);
            this.cboAutentificacion.Name = "cboAutentificacion";
            this.cboAutentificacion.Size = new System.Drawing.Size(188, 21);
            this.cboAutentificacion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Authentificacion";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(250, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(250, 102);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(125, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // frmServerConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 264);
            this.Controls.Add(this.cboAutentificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboInstancias2);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.radLabel1);
            this.Name = "frmServerConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServerConnect";
            this.Load += new System.EventHandler(this.frmServerConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnConectar;
        private System.Windows.Forms.ComboBox cboInstancias2;
        private System.Windows.Forms.ComboBox cboAutentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}