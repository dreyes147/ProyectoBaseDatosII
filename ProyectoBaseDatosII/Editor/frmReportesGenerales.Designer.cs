namespace ProyectoBaseDatosII.Editor
{
    partial class frmReporteGeneral
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
            this.dgvReporteGeneral = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGeneral.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteGeneral
            // 
            this.dgvReporteGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteGeneral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteGeneral.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvReporteGeneral.MasterTemplate.AllowAddNewRow = false;
            this.dgvReporteGeneral.MasterTemplate.AllowColumnReorder = false;
            this.dgvReporteGeneral.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteGeneral.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvReporteGeneral.Name = "dgvReporteGeneral";
            this.dgvReporteGeneral.ReadOnly = true;
            this.dgvReporteGeneral.Size = new System.Drawing.Size(585, 313);
            this.dgvReporteGeneral.TabIndex = 1;
            this.dgvReporteGeneral.Text = "radGridView1";
            // 
            // frmReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 313);
            this.Controls.Add(this.dgvReporteGeneral);
            this.Name = "frmReporteGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGeneral.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvReporteGeneral;
    }
}