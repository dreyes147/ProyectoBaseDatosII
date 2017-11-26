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
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snippetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gENERALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radEditor = new Telerik.WinControls.UI.Docking.RadDock();
            this.dwsEditor = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.ptbNumeros = new System.Windows.Forms.PictureBox();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.twsBasesDatos = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.TrvDatos = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.lbDML = new System.Windows.Forms.Label();
            this.cbDDL = new System.Windows.Forms.ComboBox();
            this.lbDDL = new System.Windows.Forms.Label();
            this.lbBD = new System.Windows.Forms.Label();
            this.btnEjecutar = new Telerik.WinControls.UI.RadButton();
            this.btnRefreshTrv = new Telerik.WinControls.UI.RadButton();
            this.cbBasesDeDatos = new System.Windows.Forms.ComboBox();
            this.lbTiempoReal = new System.Windows.Forms.Label();
            this.lbNumTiempoReal = new System.Windows.Forms.Label();
            this.lbTiempoEstimado = new System.Windows.Forms.Label();
            this.lbNumTiempoEstimado = new System.Windows.Forms.Label();
            this.lbDiferencia = new System.Windows.Forms.Label();
            this.lbNumDiferencia = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radEditor)).BeginInit();
            this.radEditor.SuspendLayout();
            this.dwsEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.twsBasesDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshTrv)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.AcceptsTab = true;
            this.rtbEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEditor.BackColor = System.Drawing.Color.White;
            this.rtbEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEditor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEditor.Location = new System.Drawing.Point(51, 3);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(730, 425);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            this.rtbEditor.TextChanged += new System.EventHandler(this.rtbEditor_TextChanged);
            this.rtbEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbEditor_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1010, 22);
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
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
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
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar ";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snippetsToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // snippetsToolStripMenuItem
            // 
            this.snippetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDLToolStripMenuItem,
            this.toolStripSeparator2,
            this.gENERALToolStripMenuItem});
            this.snippetsToolStripMenuItem.Name = "snippetsToolStripMenuItem";
            this.snippetsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.snippetsToolStripMenuItem.Text = "Snippets";
            // 
            // dDLToolStripMenuItem
            // 
            this.dDLToolStripMenuItem.Name = "dDLToolStripMenuItem";
            this.dDLToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dDLToolStripMenuItem.Text = "Especifico";
            this.dDLToolStripMenuItem.Click += new System.EventHandler(this.dDLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // gENERALToolStripMenuItem
            // 
            this.gENERALToolStripMenuItem.Name = "gENERALToolStripMenuItem";
            this.gENERALToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.gENERALToolStripMenuItem.Text = "General";
            this.gENERALToolStripMenuItem.Click += new System.EventHandler(this.gENERALToolStripMenuItem_Click);
            // 
            // radEditor
            // 
            this.radEditor.ActiveWindow = this.twsBasesDatos;
            this.radEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radEditor.CausesValidation = false;
            this.radEditor.Controls.Add(this.toolTabStrip1);
            this.radEditor.Controls.Add(this.documentContainer1);
            this.radEditor.IsCleanUpTarget = true;
            this.radEditor.Location = new System.Drawing.Point(0, 70);
            this.radEditor.MainDocumentContainer = this.documentContainer1;
            this.radEditor.Name = "radEditor";
            this.radEditor.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radEditor.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radEditor.Size = new System.Drawing.Size(1003, 469);
            this.radEditor.TabIndex = 4;
            this.radEditor.TabStop = false;
            this.radEditor.Text = "radDock1";
            this.radEditor.ThemeName = "Office2013Light";
            // 
            // dwsEditor
            // 
            this.dwsEditor.Controls.Add(this.rtbEditor);
            this.dwsEditor.Controls.Add(this.ptbNumeros);
            this.dwsEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dwsEditor.Location = new System.Drawing.Point(5, 31);
            this.dwsEditor.Name = "dwsEditor";
            this.dwsEditor.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dwsEditor.Size = new System.Drawing.Size(783, 433);
            this.dwsEditor.Text = "Query";
            this.dwsEditor.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // ptbNumeros
            // 
            this.ptbNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbNumeros.BackColor = System.Drawing.Color.White;
            this.ptbNumeros.Location = new System.Drawing.Point(3, 3);
            this.ptbNumeros.Name = "ptbNumeros";
            this.ptbNumeros.Size = new System.Drawing.Size(42, 428);
            this.ptbNumeros.TabIndex = 1;
            this.ptbNumeros.TabStop = false;
            this.ptbNumeros.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbNumeros_Paint);
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
            this.toolTabStrip1.Size = new System.Drawing.Size(206, 469);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(206, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(6, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "Office2013Light";
            // 
            // twsBasesDatos
            // 
            this.twsBasesDatos.Caption = null;
            this.twsBasesDatos.Controls.Add(this.TrvDatos);
            this.twsBasesDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.twsBasesDatos.Location = new System.Drawing.Point(4, 26);
            this.twsBasesDatos.Name = "twsBasesDatos";
            this.twsBasesDatos.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.twsBasesDatos.Size = new System.Drawing.Size(198, 439);
            this.twsBasesDatos.Text = "Bases de Datos";
            this.twsBasesDatos.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // TrvDatos
            // 
            this.TrvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TrvDatos.BackColor = System.Drawing.Color.AliceBlue;
            this.TrvDatos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrvDatos.ImageIndex = 0;
            this.TrvDatos.ImageList = this.imageList1;
            this.TrvDatos.Location = new System.Drawing.Point(3, 5);
            this.TrvDatos.Name = "TrvDatos";
            this.TrvDatos.SelectedImageKey = "base-de-datos.png";
            this.TrvDatos.Size = new System.Drawing.Size(190, 454);
            this.TrvDatos.TabIndex = 0;
            this.TrvDatos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvDatos_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "base-de-datos.png");
            this.imageList1.Images.SetKeyName(1, "cuadricula-de-la-tabla.png");
            this.imageList1.Images.SetKeyName(2, "diseno-de-tres-columnas.png");
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(793, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-6, 0);
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
            this.documentTabStrip1.Size = new System.Drawing.Size(793, 469);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "Office2013Light";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbDatos
            // 
            this.cbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDatos.BackColor = System.Drawing.Color.LightBlue;
            this.cbDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDatos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(657, 37);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(146, 21);
            this.cbDatos.TabIndex = 6;
            this.cbDatos.SelectedIndexChanged += new System.EventHandler(this.cbDatos_SelectedIndexChanged);
            // 
            // lbDML
            // 
            this.lbDML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDML.AutoSize = true;
            this.lbDML.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDML.Location = new System.Drawing.Point(610, 41);
            this.lbDML.Name = "lbDML";
            this.lbDML.Size = new System.Drawing.Size(41, 14);
            this.lbDML.TabIndex = 7;
            this.lbDML.Text = "DML:";
            // 
            // cbDDL
            // 
            this.cbDDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDDL.BackColor = System.Drawing.Color.LightBlue;
            this.cbDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDDL.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDDL.FormattingEnabled = true;
            this.cbDDL.Location = new System.Drawing.Point(859, 36);
            this.cbDDL.Name = "cbDDL";
            this.cbDDL.Size = new System.Drawing.Size(145, 21);
            this.cbDDL.TabIndex = 8;
            this.cbDDL.SelectedIndexChanged += new System.EventHandler(this.cbDDL_SelectedIndexChanged);
            // 
            // lbDDL
            // 
            this.lbDDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDDL.AutoSize = true;
            this.lbDDL.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDDL.Location = new System.Drawing.Point(813, 39);
            this.lbDDL.Name = "lbDDL";
            this.lbDDL.Size = new System.Drawing.Size(40, 14);
            this.lbDDL.TabIndex = 9;
            this.lbDDL.Text = "DDL:";
            // 
            // lbBD
            // 
            this.lbBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBD.AutoSize = true;
            this.lbBD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBD.Location = new System.Drawing.Point(378, 39);
            this.lbBD.Name = "lbBD";
            this.lbBD.Size = new System.Drawing.Size(39, 14);
            this.lbBD.TabIndex = 11;
            this.lbBD.Text = "USE:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEjecutar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(205, 33);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(110, 24);
            this.btnEjecutar.TabIndex = 12;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click_1);
            // 
            // btnRefreshTrv
            // 
            this.btnRefreshTrv.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefreshTrv.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTrv.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTrv.Location = new System.Drawing.Point(12, 33);
            this.btnRefreshTrv.Name = "btnRefreshTrv";
            this.btnRefreshTrv.Size = new System.Drawing.Size(110, 24);
            this.btnRefreshTrv.TabIndex = 13;
            this.btnRefreshTrv.Text = "Refresh";
            this.btnRefreshTrv.Click += new System.EventHandler(this.btnRefreshTrv_Click_1);
            // 
            // cbBasesDeDatos
            // 
            this.cbBasesDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBasesDeDatos.BackColor = System.Drawing.Color.LightBlue;
            this.cbBasesDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasesDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBasesDeDatos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBasesDeDatos.FormattingEnabled = true;
            this.cbBasesDeDatos.Location = new System.Drawing.Point(423, 36);
            this.cbBasesDeDatos.Name = "cbBasesDeDatos";
            this.cbBasesDeDatos.Size = new System.Drawing.Size(162, 21);
            this.cbBasesDeDatos.TabIndex = 10;
            // 
            // lbTiempoReal
            // 
            this.lbTiempoReal.AutoSize = true;
            this.lbTiempoReal.BackColor = System.Drawing.Color.LightBlue;
            this.lbTiempoReal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoReal.Location = new System.Drawing.Point(609, 5);
            this.lbTiempoReal.Name = "lbTiempoReal";
            this.lbTiempoReal.Size = new System.Drawing.Size(88, 14);
            this.lbTiempoReal.TabIndex = 14;
            this.lbTiempoReal.Text = "Tiempo Real:";
            // 
            // lbNumTiempoReal
            // 
            this.lbNumTiempoReal.AutoSize = true;
            this.lbNumTiempoReal.BackColor = System.Drawing.Color.LightBlue;
            this.lbNumTiempoReal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumTiempoReal.Location = new System.Drawing.Point(703, 5);
            this.lbNumTiempoReal.Name = "lbNumTiempoReal";
            this.lbNumTiempoReal.Size = new System.Drawing.Size(15, 14);
            this.lbNumTiempoReal.TabIndex = 15;
            this.lbNumTiempoReal.Text = "0";
            // 
            // lbTiempoEstimado
            // 
            this.lbTiempoEstimado.AutoSize = true;
            this.lbTiempoEstimado.BackColor = System.Drawing.Color.LightBlue;
            this.lbTiempoEstimado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTiempoEstimado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoEstimado.Location = new System.Drawing.Point(349, 5);
            this.lbTiempoEstimado.Name = "lbTiempoEstimado";
            this.lbTiempoEstimado.Size = new System.Drawing.Size(119, 14);
            this.lbTiempoEstimado.TabIndex = 16;
            this.lbTiempoEstimado.Text = "Tiempo Estimado:";
            // 
            // lbNumTiempoEstimado
            // 
            this.lbNumTiempoEstimado.AutoSize = true;
            this.lbNumTiempoEstimado.BackColor = System.Drawing.Color.LightBlue;
            this.lbNumTiempoEstimado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumTiempoEstimado.Location = new System.Drawing.Point(474, 5);
            this.lbNumTiempoEstimado.Name = "lbNumTiempoEstimado";
            this.lbNumTiempoEstimado.Size = new System.Drawing.Size(15, 14);
            this.lbNumTiempoEstimado.TabIndex = 17;
            this.lbNumTiempoEstimado.Text = "0";
            // 
            // lbDiferencia
            // 
            this.lbDiferencia.AutoSize = true;
            this.lbDiferencia.BackColor = System.Drawing.Color.LightBlue;
            this.lbDiferencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiferencia.Location = new System.Drawing.Point(840, 5);
            this.lbDiferencia.Name = "lbDiferencia";
            this.lbDiferencia.Size = new System.Drawing.Size(74, 14);
            this.lbDiferencia.TabIndex = 18;
            this.lbDiferencia.Text = "Diferencia:";
            // 
            // lbNumDiferencia
            // 
            this.lbNumDiferencia.AutoSize = true;
            this.lbNumDiferencia.BackColor = System.Drawing.Color.LightBlue;
            this.lbNumDiferencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumDiferencia.Location = new System.Drawing.Point(920, 5);
            this.lbNumDiferencia.Name = "lbNumDiferencia";
            this.lbNumDiferencia.Size = new System.Drawing.Size(15, 14);
            this.lbNumDiferencia.TabIndex = 19;
            this.lbNumDiferencia.Text = "0";
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 570);
            this.Controls.Add(this.lbNumDiferencia);
            this.Controls.Add(this.lbDiferencia);
            this.Controls.Add(this.btnRefreshTrv);
            this.Controls.Add(this.lbNumTiempoEstimado);
            this.Controls.Add(this.lbTiempoEstimado);
            this.Controls.Add(this.lbNumTiempoReal);
            this.Controls.Add(this.lbTiempoReal);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lbBD);
            this.Controls.Add(this.cbBasesDeDatos);
            this.Controls.Add(this.lbDDL);
            this.Controls.Add(this.cbDDL);
            this.Controls.Add(this.lbDML);
            this.Controls.Add(this.cbDatos);
            this.Controls.Add(this.radEditor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radEditor)).EndInit();
            this.radEditor.ResumeLayout(false);
            this.dwsEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.twsBasesDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshTrv)).EndInit();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbBD;
        private Telerik.WinControls.UI.RadButton btnEjecutar;
        private Telerik.WinControls.UI.RadButton btnRefreshTrv;
        private System.Windows.Forms.ComboBox cbBasesDeDatos;
        private System.Windows.Forms.Label lbTiempoReal;
        private System.Windows.Forms.Label lbNumTiempoReal;
        private System.Windows.Forms.Label lbTiempoEstimado;
        private System.Windows.Forms.Label lbNumTiempoEstimado;
        private System.Windows.Forms.Label lbDiferencia;
        private System.Windows.Forms.Label lbNumDiferencia;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snippetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gENERALToolStripMenuItem;
    }
}