namespace ProyectoBaseDatosII
{
    partial class radGrid
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.gridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(557, 373);
            this.gridView.TabIndex = 0;
            this.gridView.Text = "radGridView1";
            // 
            // radGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 397);
            this.Controls.Add(this.gridView);
            this.Name = "radGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Response";
            this.Load += new System.EventHandler(this.dataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridView;
    }
}

