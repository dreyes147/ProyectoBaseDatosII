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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnConectar = new Telerik.WinControls.UI.RadButton();
            this.cboInstancias = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.cboInstancias2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboInstancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboInstancias.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboInstancias.EditorControl.MasterTemplate)).BeginInit();
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
            // cboInstancias
            // 
            this.cboInstancias.AutoSize = true;
            // 
            // cboInstancias.NestedRadGridView
            // 
            this.cboInstancias.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cboInstancias.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInstancias.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboInstancias.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.cboInstancias.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cboInstancias.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cboInstancias.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.cboInstancias.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cboInstancias.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.cboInstancias.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.cboInstancias.EditorControl.Name = "NestedRadGridView";
            this.cboInstancias.EditorControl.ReadOnly = true;
            this.cboInstancias.EditorControl.ShowGroupPanel = false;
            this.cboInstancias.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.cboInstancias.EditorControl.TabIndex = 0;
            this.cboInstancias.Location = new System.Drawing.Point(186, 72);
            this.cboInstancias.Name = "cboInstancias";
            this.cboInstancias.Size = new System.Drawing.Size(188, 21);
            this.cboInstancias.TabIndex = 3;
            this.cboInstancias.TabStop = false;
            this.cboInstancias.ThemeName = "Office2013Light";
            // 
            // cboInstancias2
            // 
            this.cboInstancias2.FormattingEnabled = true;
            this.cboInstancias2.Location = new System.Drawing.Point(186, 111);
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
            this.Controls.Add(this.cboInstancias);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.radLabel1);
            this.Name = "frmServerConnect";
            this.Text = "frmServerConnect";
            this.Load += new System.EventHandler(this.frmServerConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboInstancias.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboInstancias.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboInstancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnConectar;
        private Telerik.WinControls.UI.RadMultiColumnComboBox cboInstancias;
        private System.Windows.Forms.ComboBox cboInstancias2;
    }
}