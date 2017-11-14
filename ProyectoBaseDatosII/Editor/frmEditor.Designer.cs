namespace ProyectoBaseDatosII.Editor
{
    partial class frmEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.ptbNumeros = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radEditor = new Telerik.WinControls.UI.Docking.RadDock();
            this.twsBasesDatos = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.TrvDatos = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.dwsEditor = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.btnRefreshTrv = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.lbDML = new System.Windows.Forms.Label();
            this.cbDDL = new System.Windows.Forms.ComboBox();
            this.lbDDL = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cbBasesDeDatos = new System.Windows.Forms.ComboBox();
            this.lbBD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNumeros)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radEditor)).BeginInit();
            this.radEditor.SuspendLayout();
            this.twsBasesDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.dwsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEditor.Location = new System.Drawing.Point(51, 3);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(735, 601);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            this.rtbEditor.TextChanged += new System.EventHandler(this.rtbEditor_TextChanged);
            this.rtbEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbEditor_KeyUp);
            // 
            // ptbNumeros
            // 
            this.ptbNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbNumeros.BackColor = System.Drawing.Color.White;
            this.ptbNumeros.Location = new System.Drawing.Point(3, 2);
            this.ptbNumeros.Name = "ptbNumeros";
            this.ptbNumeros.Size = new System.Drawing.Size(42, 602);
            this.ptbNumeros.TabIndex = 1;
            this.ptbNumeros.TabStop = false;
            this.ptbNumeros.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbNumeros_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlblFecha
            // 
            this.tlblFecha.Image = global::ProyectoBaseDatosII.Properties.Resources.IconoCalendario;
            this.tlblFecha.Name = "tlblFecha";
            this.tlblFecha.Size = new System.Drawing.Size(16, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar ";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // radEditor
            // 
            this.radEditor.ActiveWindow = this.dwsEditor;
            this.radEditor.CausesValidation = false;
            this.radEditor.Controls.Add(this.toolTabStrip1);
            this.radEditor.Controls.Add(this.documentContainer1);
            this.radEditor.IsCleanUpTarget = true;
            this.radEditor.Location = new System.Drawing.Point(0, 65);
            this.radEditor.MainDocumentContainer = this.documentContainer1;
            this.radEditor.Name = "radEditor";
            this.radEditor.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radEditor.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radEditor.Size = new System.Drawing.Size(1003, 642);
            this.radEditor.TabIndex = 4;
            this.radEditor.TabStop = false;
            this.radEditor.Text = "radDock1";
            this.radEditor.ThemeName = "Office2013Light";
            // 
            // twsBasesDatos
            // 
            this.twsBasesDatos.Caption = null;
            this.twsBasesDatos.Controls.Add(this.TrvDatos);
            this.twsBasesDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.twsBasesDatos.Location = new System.Drawing.Point(4, 26);
            this.twsBasesDatos.Name = "twsBasesDatos";
            this.twsBasesDatos.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.twsBasesDatos.Size = new System.Drawing.Size(192, 612);
            this.twsBasesDatos.Text = "Bases de Datos";
            this.twsBasesDatos.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // TrvDatos
            // 
            this.TrvDatos.ImageIndex = 0;
            this.TrvDatos.ImageList = this.imageList1;
            this.TrvDatos.Location = new System.Drawing.Point(-1, 7);
            this.TrvDatos.Name = "TrvDatos";
            this.TrvDatos.SelectedImageKey = "base-de-datos.png";
            this.TrvDatos.Size = new System.Drawing.Size(194, 605);
            this.TrvDatos.TabIndex = 0;
            this.TrvDatos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvDatos_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "base-de-datos.png");
            this.imageList1.Images.SetKeyName(1, "cuadricula-de-la-tabla.png");
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.twsBasesDatos);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 642);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "Office2013Light";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.TabIndex = 2;
            this.documentContainer1.ThemeName = "Office2013Light";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.dwsEditor);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(799, 642);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "Office2013Light";
            // 
            // dwsEditor
            // 
            this.dwsEditor.Controls.Add(this.rtbEditor);
            this.dwsEditor.Controls.Add(this.ptbNumeros);
            this.dwsEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dwsEditor.Location = new System.Drawing.Point(5, 31);
            this.dwsEditor.Name = "dwsEditor";
            this.dwsEditor.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dwsEditor.Size = new System.Drawing.Size(789, 606);
            this.dwsEditor.Text = "Query";
            this.dwsEditor.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // btnRefreshTrv
            // 
            this.btnRefreshTrv.Location = new System.Drawing.Point(0, 39);
            this.btnRefreshTrv.Name = "btnRefreshTrv";
            this.btnRefreshTrv.Size = new System.Drawing.Size(78, 23);
            this.btnRefreshTrv.TabIndex = 5;
            this.btnRefreshTrv.Text = "Refresh";
            this.btnRefreshTrv.UseVisualStyleBackColor = true;
            this.btnRefreshTrv.Click += new System.EventHandler(this.btnRefreshTrv_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbDatos
            // 
            this.cbDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(684, 41);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(121, 21);
            this.cbDatos.TabIndex = 6;
            this.cbDatos.SelectedIndexChanged += new System.EventHandler(this.cbDatos_SelectedIndexChanged);
            // 
            // lbDML
            // 
            this.lbDML.AutoSize = true;
            this.lbDML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDML.Location = new System.Drawing.Point(641, 44);
            this.lbDML.Name = "lbDML";
            this.lbDML.Size = new System.Drawing.Size(37, 13);
            this.lbDML.TabIndex = 7;
            this.lbDML.Text = "DML:";
            // 
            // cbDDL
            // 
            this.cbDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDDL.FormattingEnabled = true;
            this.cbDDL.Location = new System.Drawing.Point(882, 39);
            this.cbDDL.Name = "cbDDL";
            this.cbDDL.Size = new System.Drawing.Size(121, 21);
            this.cbDDL.TabIndex = 8;
            this.cbDDL.SelectedIndexChanged += new System.EventHandler(this.cbDDL_SelectedIndexChanged);
            // 
            // lbDDL
            // 
            this.lbDDL.AutoSize = true;
            this.lbDDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDDL.Location = new System.Drawing.Point(840, 42);
            this.lbDDL.Name = "lbDDL";
            this.lbDDL.Size = new System.Drawing.Size(36, 13);
            this.lbDDL.TabIndex = 9;
            this.lbDDL.Text = "DDL:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(204, 39);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cbBasesDeDatos
            // 
            this.cbBasesDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasesDeDatos.FormattingEnabled = true;
            this.cbBasesDeDatos.Location = new System.Drawing.Point(419, 41);
            this.cbBasesDeDatos.Name = "cbBasesDeDatos";
            this.cbBasesDeDatos.Size = new System.Drawing.Size(121, 21);
            this.cbBasesDeDatos.TabIndex = 10;
            // 
            // lbBD
            // 
            this.lbBD.AutoSize = true;
            this.lbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBD.Location = new System.Drawing.Point(377, 42);
            this.lbBD.Name = "lbBD";
            this.lbBD.Size = new System.Drawing.Size(39, 15);
            this.lbBD.TabIndex = 11;
            this.lbBD.Text = "USE:";
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.lbBD);
            this.Controls.Add(this.cbBasesDeDatos);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lbDDL);
            this.Controls.Add(this.cbDDL);
            this.Controls.Add(this.lbDML);
            this.Controls.Add(this.cbDatos);
            this.Controls.Add(this.btnRefreshTrv);
            this.Controls.Add(this.radEditor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNumeros)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radEditor)).EndInit();
            this.radEditor.ResumeLayout(false);
            this.twsBasesDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.dwsEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.PictureBox ptbNumeros;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlblFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private Telerik.WinControls.UI.Docking.RadDock radEditor;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentWindow dwsEditor;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow twsBasesDatos;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.TreeView TrvDatos;
        private System.Windows.Forms.Button btnRefreshTrv;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbDatos;
        private System.Windows.Forms.Label lbDML;
        private System.Windows.Forms.ComboBox cbDDL;
        private System.Windows.Forms.Label lbDDL;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbBasesDeDatos;
        private System.Windows.Forms.Label lbBD;
    }
}