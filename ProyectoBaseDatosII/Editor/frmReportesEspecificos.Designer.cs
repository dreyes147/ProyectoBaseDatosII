﻿namespace ProyectoBaseDatosII.Editor
{
    partial class frmReportesEspecificos
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
            this.groupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.rdbDDL = new System.Windows.Forms.RadioButton();
            this.rdbDML = new System.Windows.Forms.RadioButton();
            this.dgvReportes = new Telerik.WinControls.UI.RadGridView();
            this.btnConsulta = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox.Controls.Add(this.rdbDDL);
            this.groupBox.Controls.Add(this.rdbDML);
            this.groupBox.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Bottom;
            this.groupBox.HeaderText = "";
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(178, 41);
            this.groupBox.TabIndex = 0;
            // 
            // rdbDDL
            // 
            this.rdbDDL.AutoSize = true;
            this.rdbDDL.Location = new System.Drawing.Point(85, 11);
            this.rdbDDL.Name = "rdbDDL";
            this.rdbDDL.Size = new System.Drawing.Size(46, 17);
            this.rdbDDL.TabIndex = 1;
            this.rdbDDL.TabStop = true;
            this.rdbDDL.Text = "DDL";
            this.rdbDDL.UseVisualStyleBackColor = true;
            // 
            // rdbDML
            // 
            this.rdbDML.AutoSize = true;
            this.rdbDML.Location = new System.Drawing.Point(16, 11);
            this.rdbDML.Name = "rdbDML";
            this.rdbDML.Size = new System.Drawing.Size(48, 17);
            this.rdbDML.TabIndex = 0;
            this.rdbDML.TabStop = true;
            this.rdbDML.Text = "DML";
            this.rdbDML.UseVisualStyleBackColor = true;
            // 
            // dgvReportes
            // 
            this.dgvReportes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReportes.Location = new System.Drawing.Point(12, 59);
            // 
            // 
            // 
            this.dgvReportes.MasterTemplate.AllowAddNewRow = false;
            this.dgvReportes.MasterTemplate.AllowColumnReorder = false;
            this.dgvReportes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.Size = new System.Drawing.Size(640, 259);
            this.dgvReportes.TabIndex = 1;
            this.dgvReportes.Text = "radGridView1";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsulta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(196, 21);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(110, 24);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // frmReportesEspecificos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 325);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.groupBox);
            this.Name = "frmReportesEspecificos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReportesEspecificos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox groupBox;
        private System.Windows.Forms.RadioButton rdbDDL;
        private System.Windows.Forms.RadioButton rdbDML;
        private Telerik.WinControls.UI.RadGridView dgvReportes;
        private Telerik.WinControls.UI.RadButton btnConsulta;
    }
}