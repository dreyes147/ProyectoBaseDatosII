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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectar)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(68, 72);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(70, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Server Name";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(204, 140);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(110, 24);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.ThemeName = "Office2013Light";
            // 
            // cboInstancias2
            // 
            this.cboInstancias2.FormattingEnabled = true;
            this.cboInstancias2.Location = new System.Drawing.Point(179, 70);
            this.cboInstancias2.Name = "cboInstancias2";
            this.cboInstancias2.Size = new System.Drawing.Size(188, 21);
            this.cboInstancias2.TabIndex = 4;
            // 
            // frmServerConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 264);
            this.Controls.Add(this.cboInstancias2);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.radLabel1);
            this.Name = "frmServerConnect";
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
    }
}