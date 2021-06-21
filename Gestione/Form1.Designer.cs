namespace Gestione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPsw = new System.Windows.Forms.ToolStripTextBox();
            this.calibriLisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitaInScadenzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scadutiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneCalibriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestione_CalibriDataSet = new Gestione.Gestione_CalibriDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblistruzioni = new System.Windows.Forms.ToolStripStatusLabel();
            this.foglio1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Gestione.Database1DataSet();
            this.foglio2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foglio3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foglio8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foglio6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foglio7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calibr_LisciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calibri_LisciDataSet = new Gestione.Calibri_LisciDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.foglio1TableAdapter = new Gestione.Database1DataSetTableAdapters.Foglio1TableAdapter();
            this.foglio2TableAdapter = new Gestione.Database1DataSetTableAdapters.Foglio2TableAdapter();
            this.foglio3TableAdapter = new Gestione.Database1DataSetTableAdapters.Foglio3TableAdapter();
            this.foglio8TableAdapter = new Gestione.Database1DataSetTableAdapters.Foglio8TableAdapter();
            this.foglio6TableAdapter = new Gestione.Database1DataSetTableAdapters.Foglio6TableAdapter();
            this.foglio7TableAdapter = new Gestione.Database1DataSetTableAdapters.Foglio7TableAdapter();
            this.gestioneCalibriTableAdapter = new Gestione.Gestione_CalibriDataSetTableAdapters.GestioneCalibriTableAdapter();
            this.tableAdapterManager = new Gestione.Gestione_CalibriDataSetTableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.calibr_LisciTableAdapter = new Gestione.Calibri_LisciDataSetTableAdapters.Calibr_LisciTableAdapter();
            this.tableAdapterManager1 = new Gestione.Calibri_LisciDataSetTableAdapters.TableAdapterManager();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.calibr_LisciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.foglio1DataGridView = new System.Windows.Forms.DataGridView();
            this.matDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consegnatoNuovoIlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultTarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scadenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.foglio2DataGridView = new System.Windows.Forms.DataGridView();
            this.matDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consegnatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultTarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scadenzaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.foglio3DataGridView = new System.Windows.Forms.DataGridView();
            this.matDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risolDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costrDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSchDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdTDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consegnaInRepartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultTarDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scadenzaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.foglio8DataGridView = new System.Windows.Forms.DataGridView();
            this.matrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risolDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udiMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costruttoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSchDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultTarDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scadenzaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.foglio6DataGridView = new System.Windows.Forms.DataGridView();
            this.matrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diametroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSchDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaTarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoreRilevatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.foglio7DataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalloTaraturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltimaTaraturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gestioneCalibriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestione_CalibriDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibri_LisciDataSet)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio1DataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio2DataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio3DataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio8DataGridView)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio6DataGridView)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio7DataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vitaInScadenzaToolStripMenuItem,
            this.scadutiToolStripMenuItem,
            this.ricercaToolStripMenuItem,
            this.cancellaFiltroToolStripMenuItem,
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem,
            this.inserisciToolStripMenuItem1,
            this.cancellaToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.calibriLisciToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // inserisciToolStripMenuItem1
            // 
            this.inserisciToolStripMenuItem1.Name = "inserisciToolStripMenuItem1";
            this.inserisciToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.inserisciToolStripMenuItem1.Text = "Inserisci";
            this.inserisciToolStripMenuItem1.Click += new System.EventHandler(this.inserisciToolStripMenuItem1_Click);
            // 
            // cancellaToolStripMenuItem
            // 
            this.cancellaToolStripMenuItem.Name = "cancellaToolStripMenuItem";
            this.cancellaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cancellaToolStripMenuItem.Text = "Cancella";
            this.cancellaToolStripMenuItem.Click += new System.EventHandler(this.cancellaToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPsw});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // toolStripPsw
            // 
            this.toolStripPsw.MaxLength = 4;
            this.toolStripPsw.Name = "toolStripPsw";
            this.toolStripPsw.Size = new System.Drawing.Size(100, 23);
            this.toolStripPsw.ToolTipText = "Metti la password per poter modificare le tabelle";
            this.toolStripPsw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripPsw_KeyUp);
            // 
            // calibriLisciToolStripMenuItem
            // 
            this.calibriLisciToolStripMenuItem.Name = "calibriLisciToolStripMenuItem";
            this.calibriLisciToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.calibriLisciToolStripMenuItem.Text = "Tabella Calibri";
            this.calibriLisciToolStripMenuItem.Click += new System.EventHandler(this.calibriLisciToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click_1);
            // 
            // vitaInScadenzaToolStripMenuItem
            // 
            this.vitaInScadenzaToolStripMenuItem.Name = "vitaInScadenzaToolStripMenuItem";
            this.vitaInScadenzaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.vitaInScadenzaToolStripMenuItem.Text = "In Scadenza";
            this.vitaInScadenzaToolStripMenuItem.Click += new System.EventHandler(this.vitaInScadenzaToolStripMenuItem_Click);
            // 
            // scadutiToolStripMenuItem
            // 
            this.scadutiToolStripMenuItem.Name = "scadutiToolStripMenuItem";
            this.scadutiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.scadutiToolStripMenuItem.Text = "Scaduti";
            this.scadutiToolStripMenuItem.Click += new System.EventHandler(this.scadutiToolStripMenuItem_Click);
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ricercaToolStripMenuItem.Text = "Ricerca";
            this.ricercaToolStripMenuItem.Click += new System.EventHandler(this.ricercaToolStripMenuItem_Click);
            // 
            // cancellaFiltroToolStripMenuItem
            // 
            this.cancellaFiltroToolStripMenuItem.Name = "cancellaFiltroToolStripMenuItem";
            this.cancellaFiltroToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.cancellaFiltroToolStripMenuItem.Text = "Cancella Filtro";
            this.cancellaFiltroToolStripMenuItem.Click += new System.EventHandler(this.cancellaFiltroToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sToolStripMenuItem.Text = "Stampa";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // gestioneCalibriBindingSource
            // 
            this.gestioneCalibriBindingSource.DataMember = "GestioneCalibri";
            this.gestioneCalibriBindingSource.DataSource = this.gestione_CalibriDataSet;
            // 
            // gestione_CalibriDataSet
            // 
            this.gestione_CalibriDataSet.DataSetName = "Gestione_CalibriDataSet";
            this.gestione_CalibriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblistruzioni});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblistruzioni
            // 
            this.lblistruzioni.Name = "lblistruzioni";
            this.lblistruzioni.Size = new System.Drawing.Size(55, 17);
            this.lblistruzioni.Text = "Istruzioni";
            // 
            // foglio1BindingSource
            // 
            this.foglio1BindingSource.DataMember = "Foglio1";
            this.foglio1BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foglio2BindingSource
            // 
            this.foglio2BindingSource.DataMember = "Foglio2";
            this.foglio2BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // foglio3BindingSource
            // 
            this.foglio3BindingSource.DataMember = "Foglio3";
            this.foglio3BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // foglio8BindingSource
            // 
            this.foglio8BindingSource.DataMember = "Foglio8";
            this.foglio8BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // foglio6BindingSource
            // 
            this.foglio6BindingSource.DataMember = "Foglio6";
            this.foglio6BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // foglio7BindingSource
            // 
            this.foglio7BindingSource.DataMember = "Foglio7";
            this.foglio7BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // calibr_LisciBindingSource
            // 
            this.calibr_LisciBindingSource.DataMember = "Calibr Lisci";
            this.calibr_LisciBindingSource.DataSource = this.calibri_LisciDataSet;
            // 
            // calibri_LisciDataSet
            // 
            this.calibri_LisciDataSet.DataSetName = "Calibri_LisciDataSet";
            this.calibri_LisciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foglio1TableAdapter
            // 
            this.foglio1TableAdapter.ClearBeforeFill = true;
            // 
            // foglio2TableAdapter
            // 
            this.foglio2TableAdapter.ClearBeforeFill = true;
            // 
            // foglio3TableAdapter
            // 
            this.foglio3TableAdapter.ClearBeforeFill = true;
            // 
            // foglio8TableAdapter
            // 
            this.foglio8TableAdapter.ClearBeforeFill = true;
            // 
            // foglio6TableAdapter
            // 
            this.foglio6TableAdapter.ClearBeforeFill = true;
            // 
            // foglio7TableAdapter
            // 
            this.foglio7TableAdapter.ClearBeforeFill = true;
            // 
            // gestioneCalibriTableAdapter
            // 
            this.gestioneCalibriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GestioneCalibriTableAdapter = this.gestioneCalibriTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestione.Gestione_CalibriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // calibr_LisciTableAdapter
            // 
            this.calibr_LisciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Calibr_LisciTableAdapter = this.calibr_LisciTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Gestione.Calibri_LisciDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.calibr_LisciDataGridView);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(826, 459);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Calibri Lisci";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // calibr_LisciDataGridView
            // 
            this.calibr_LisciDataGridView.AllowUserToAddRows = false;
            this.calibr_LisciDataGridView.AllowUserToDeleteRows = false;
            this.calibr_LisciDataGridView.AutoGenerateColumns = false;
            this.calibr_LisciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calibr_LisciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.ID});
            this.calibr_LisciDataGridView.DataSource = this.calibr_LisciBindingSource;
            this.calibr_LisciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibr_LisciDataGridView.Location = new System.Drawing.Point(0, 0);
            this.calibr_LisciDataGridView.Name = "calibr_LisciDataGridView";
            this.calibr_LisciDataGridView.ReadOnly = true;
            this.calibr_LisciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calibr_LisciDataGridView.Size = new System.Drawing.Size(826, 459);
            this.calibr_LisciDataGridView.TabIndex = 0;
            this.calibr_LisciDataGridView.Tag = "0";
            this.calibr_LisciDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.calibr_LisciDataGridView_CellMouseDoubleClick);
            this.calibr_LisciDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.calibr_LisciDataGridView_RowEnter);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Matricola";
            this.dataGridViewTextBoxColumn9.HeaderText = "Matricola";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Dimensione Passa";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dimensione Passa";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Dimensione non Passa";
            this.dataGridViewTextBoxColumn11.HeaderText = "Dimensione non Passa";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Utile (Passa)";
            this.dataGridViewTextBoxColumn12.HeaderText = "Utile (Passa)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Destinazione";
            this.dataGridViewTextBoxColumn13.HeaderText = "Destinazione";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Varie";
            this.dataGridViewTextBoxColumn14.HeaderText = "Varie";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Posizione CQ";
            this.dataGridViewTextBoxColumn15.HeaderText = "Posizione CQ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anagrafica strumenti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(820, 453);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Tag = "0";
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl2_Selected);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.foglio1DataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 427);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "1000";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // foglio1DataGridView
            // 
            this.foglio1DataGridView.AllowUserToAddRows = false;
            this.foglio1DataGridView.AllowUserToDeleteRows = false;
            this.foglio1DataGridView.AutoGenerateColumns = false;
            this.foglio1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglio1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matDataGridViewTextBoxColumn,
            this.risolDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.fornDataGridViewTextBoxColumn,
            this.costrDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.destinazDataGridViewTextBoxColumn,
            this.nSchDataGridViewTextBoxColumn,
            this.fdTDataGridViewTextBoxColumn,
            this.consegnatoNuovoIlDataGridViewTextBoxColumn,
            this.ultTarDataGridViewTextBoxColumn,
            this.scadenzaDataGridViewTextBoxColumn,
            this.causaDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.vitaDataGridViewTextBoxColumn});
            this.foglio1DataGridView.DataSource = this.foglio1BindingSource;
            this.foglio1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foglio1DataGridView.Location = new System.Drawing.Point(3, 3);
            this.foglio1DataGridView.Name = "foglio1DataGridView";
            this.foglio1DataGridView.ReadOnly = true;
            this.foglio1DataGridView.Size = new System.Drawing.Size(806, 421);
            this.foglio1DataGridView.TabIndex = 0;
            this.foglio1DataGridView.Tag = "0";
            this.foglio1DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foglio1DataGridView_RowEnter);
            // 
            // matDataGridViewTextBoxColumn
            // 
            this.matDataGridViewTextBoxColumn.DataPropertyName = "Mat";
            this.matDataGridViewTextBoxColumn.HeaderText = "Mat";
            this.matDataGridViewTextBoxColumn.Name = "matDataGridViewTextBoxColumn";
            this.matDataGridViewTextBoxColumn.ReadOnly = true;
            this.matDataGridViewTextBoxColumn.Width = 50;
            // 
            // risolDataGridViewTextBoxColumn
            // 
            this.risolDataGridViewTextBoxColumn.DataPropertyName = "Risol";
            this.risolDataGridViewTextBoxColumn.HeaderText = "Risol";
            this.risolDataGridViewTextBoxColumn.Name = "risolDataGridViewTextBoxColumn";
            this.risolDataGridViewTextBoxColumn.ReadOnly = true;
            this.risolDataGridViewTextBoxColumn.Width = 50;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn.HeaderText = "min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            this.minDataGridViewTextBoxColumn.Width = 50;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxDataGridViewTextBoxColumn.Width = 49;
            // 
            // fornDataGridViewTextBoxColumn
            // 
            this.fornDataGridViewTextBoxColumn.DataPropertyName = "Forn";
            this.fornDataGridViewTextBoxColumn.HeaderText = "Forn";
            this.fornDataGridViewTextBoxColumn.Name = "fornDataGridViewTextBoxColumn";
            this.fornDataGridViewTextBoxColumn.ReadOnly = true;
            this.fornDataGridViewTextBoxColumn.Width = 50;
            // 
            // costrDataGridViewTextBoxColumn
            // 
            this.costrDataGridViewTextBoxColumn.DataPropertyName = "Costr";
            this.costrDataGridViewTextBoxColumn.HeaderText = "Costr";
            this.costrDataGridViewTextBoxColumn.Name = "costrDataGridViewTextBoxColumn";
            this.costrDataGridViewTextBoxColumn.ReadOnly = true;
            this.costrDataGridViewTextBoxColumn.Width = 50;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrDataGridViewTextBoxColumn.Width = 50;
            // 
            // destinazDataGridViewTextBoxColumn
            // 
            this.destinazDataGridViewTextBoxColumn.DataPropertyName = "Destinaz";
            this.destinazDataGridViewTextBoxColumn.HeaderText = "Destinaz";
            this.destinazDataGridViewTextBoxColumn.Name = "destinazDataGridViewTextBoxColumn";
            this.destinazDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinazDataGridViewTextBoxColumn.Width = 50;
            // 
            // nSchDataGridViewTextBoxColumn
            // 
            this.nSchDataGridViewTextBoxColumn.DataPropertyName = "NSch";
            this.nSchDataGridViewTextBoxColumn.HeaderText = "NSch";
            this.nSchDataGridViewTextBoxColumn.Name = "nSchDataGridViewTextBoxColumn";
            this.nSchDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSchDataGridViewTextBoxColumn.Width = 50;
            // 
            // fdTDataGridViewTextBoxColumn
            // 
            this.fdTDataGridViewTextBoxColumn.DataPropertyName = "FdT";
            this.fdTDataGridViewTextBoxColumn.HeaderText = "FdT";
            this.fdTDataGridViewTextBoxColumn.Name = "fdTDataGridViewTextBoxColumn";
            this.fdTDataGridViewTextBoxColumn.ReadOnly = true;
            this.fdTDataGridViewTextBoxColumn.Width = 50;
            // 
            // consegnatoNuovoIlDataGridViewTextBoxColumn
            // 
            this.consegnatoNuovoIlDataGridViewTextBoxColumn.DataPropertyName = "Consegnato nuovo il";
            this.consegnatoNuovoIlDataGridViewTextBoxColumn.HeaderText = "Consegnato nuovo il";
            this.consegnatoNuovoIlDataGridViewTextBoxColumn.Name = "consegnatoNuovoIlDataGridViewTextBoxColumn";
            this.consegnatoNuovoIlDataGridViewTextBoxColumn.ReadOnly = true;
            this.consegnatoNuovoIlDataGridViewTextBoxColumn.Width = 50;
            // 
            // ultTarDataGridViewTextBoxColumn
            // 
            this.ultTarDataGridViewTextBoxColumn.DataPropertyName = "UltTar";
            this.ultTarDataGridViewTextBoxColumn.HeaderText = "UltTar";
            this.ultTarDataGridViewTextBoxColumn.Name = "ultTarDataGridViewTextBoxColumn";
            this.ultTarDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultTarDataGridViewTextBoxColumn.Width = 49;
            // 
            // scadenzaDataGridViewTextBoxColumn
            // 
            this.scadenzaDataGridViewTextBoxColumn.DataPropertyName = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn.HeaderText = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn.Name = "scadenzaDataGridViewTextBoxColumn";
            this.scadenzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.scadenzaDataGridViewTextBoxColumn.Width = 50;
            // 
            // causaDataGridViewTextBoxColumn
            // 
            this.causaDataGridViewTextBoxColumn.DataPropertyName = "Causa";
            this.causaDataGridViewTextBoxColumn.HeaderText = "Causa";
            this.causaDataGridViewTextBoxColumn.Name = "causaDataGridViewTextBoxColumn";
            this.causaDataGridViewTextBoxColumn.ReadOnly = true;
            this.causaDataGridViewTextBoxColumn.Width = 50;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 50;
            // 
            // vitaDataGridViewTextBoxColumn
            // 
            this.vitaDataGridViewTextBoxColumn.DataPropertyName = "Vita";
            this.vitaDataGridViewTextBoxColumn.HeaderText = "Vita";
            this.vitaDataGridViewTextBoxColumn.Name = "vitaDataGridViewTextBoxColumn";
            this.vitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vitaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.foglio2DataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(812, 427);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "2000";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // foglio2DataGridView
            // 
            this.foglio2DataGridView.AllowUserToAddRows = false;
            this.foglio2DataGridView.AllowUserToDeleteRows = false;
            this.foglio2DataGridView.AutoGenerateColumns = false;
            this.foglio2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglio2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matDataGridViewTextBoxColumn1,
            this.risolDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1,
            this.usoDataGridViewTextBoxColumn,
            this.costrDataGridViewTextBoxColumn1,
            this.descrDataGridViewTextBoxColumn1,
            this.destinazDataGridViewTextBoxColumn1,
            this.nSchDataGridViewTextBoxColumn1,
            this.fdTDataGridViewTextBoxColumn1,
            this.consegnatoDataGridViewTextBoxColumn,
            this.ultTarDataGridViewTextBoxColumn1,
            this.scadenzaDataGridViewTextBoxColumn1,
            this.causaDataGridViewTextBoxColumn1,
            this.noteDataGridViewTextBoxColumn1});
            this.foglio2DataGridView.DataSource = this.foglio2BindingSource;
            this.foglio2DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foglio2DataGridView.Location = new System.Drawing.Point(3, 3);
            this.foglio2DataGridView.Name = "foglio2DataGridView";
            this.foglio2DataGridView.ReadOnly = true;
            this.foglio2DataGridView.Size = new System.Drawing.Size(806, 421);
            this.foglio2DataGridView.TabIndex = 0;
            this.foglio2DataGridView.Tag = "0";
            this.foglio2DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foglio2DataGridView_RowEnter);
            // 
            // matDataGridViewTextBoxColumn1
            // 
            this.matDataGridViewTextBoxColumn1.DataPropertyName = "Mat";
            this.matDataGridViewTextBoxColumn1.HeaderText = "Mat";
            this.matDataGridViewTextBoxColumn1.Name = "matDataGridViewTextBoxColumn1";
            this.matDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // risolDataGridViewTextBoxColumn1
            // 
            this.risolDataGridViewTextBoxColumn1.DataPropertyName = "Risol";
            this.risolDataGridViewTextBoxColumn1.HeaderText = "Risol";
            this.risolDataGridViewTextBoxColumn1.Name = "risolDataGridViewTextBoxColumn1";
            this.risolDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "min";
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            this.minDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "max";
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            this.maxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usoDataGridViewTextBoxColumn
            // 
            this.usoDataGridViewTextBoxColumn.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn.Name = "usoDataGridViewTextBoxColumn";
            this.usoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costrDataGridViewTextBoxColumn1
            // 
            this.costrDataGridViewTextBoxColumn1.DataPropertyName = "Costr";
            this.costrDataGridViewTextBoxColumn1.HeaderText = "Costr";
            this.costrDataGridViewTextBoxColumn1.Name = "costrDataGridViewTextBoxColumn1";
            this.costrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn1
            // 
            this.descrDataGridViewTextBoxColumn1.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn1.HeaderText = "Descr";
            this.descrDataGridViewTextBoxColumn1.Name = "descrDataGridViewTextBoxColumn1";
            this.descrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // destinazDataGridViewTextBoxColumn1
            // 
            this.destinazDataGridViewTextBoxColumn1.DataPropertyName = "Destinaz";
            this.destinazDataGridViewTextBoxColumn1.HeaderText = "Destinaz";
            this.destinazDataGridViewTextBoxColumn1.Name = "destinazDataGridViewTextBoxColumn1";
            this.destinazDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nSchDataGridViewTextBoxColumn1
            // 
            this.nSchDataGridViewTextBoxColumn1.DataPropertyName = "NSch";
            this.nSchDataGridViewTextBoxColumn1.HeaderText = "NSch";
            this.nSchDataGridViewTextBoxColumn1.Name = "nSchDataGridViewTextBoxColumn1";
            this.nSchDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fdTDataGridViewTextBoxColumn1
            // 
            this.fdTDataGridViewTextBoxColumn1.DataPropertyName = "FdT";
            this.fdTDataGridViewTextBoxColumn1.HeaderText = "FdT";
            this.fdTDataGridViewTextBoxColumn1.Name = "fdTDataGridViewTextBoxColumn1";
            this.fdTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // consegnatoDataGridViewTextBoxColumn
            // 
            this.consegnatoDataGridViewTextBoxColumn.DataPropertyName = "Consegnato";
            this.consegnatoDataGridViewTextBoxColumn.HeaderText = "Consegnato";
            this.consegnatoDataGridViewTextBoxColumn.Name = "consegnatoDataGridViewTextBoxColumn";
            this.consegnatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultTarDataGridViewTextBoxColumn1
            // 
            this.ultTarDataGridViewTextBoxColumn1.DataPropertyName = "UltTar";
            this.ultTarDataGridViewTextBoxColumn1.HeaderText = "UltTar";
            this.ultTarDataGridViewTextBoxColumn1.Name = "ultTarDataGridViewTextBoxColumn1";
            this.ultTarDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // scadenzaDataGridViewTextBoxColumn1
            // 
            this.scadenzaDataGridViewTextBoxColumn1.DataPropertyName = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn1.HeaderText = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn1.Name = "scadenzaDataGridViewTextBoxColumn1";
            this.scadenzaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // causaDataGridViewTextBoxColumn1
            // 
            this.causaDataGridViewTextBoxColumn1.DataPropertyName = "Causa";
            this.causaDataGridViewTextBoxColumn1.HeaderText = "Causa";
            this.causaDataGridViewTextBoxColumn1.Name = "causaDataGridViewTextBoxColumn1";
            this.causaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.foglio3DataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(812, 427);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "3000";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // foglio3DataGridView
            // 
            this.foglio3DataGridView.AllowUserToAddRows = false;
            this.foglio3DataGridView.AllowUserToDeleteRows = false;
            this.foglio3DataGridView.AutoGenerateColumns = false;
            this.foglio3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglio3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matDataGridViewTextBoxColumn2,
            this.risolDataGridViewTextBoxColumn2,
            this.minDataGridViewTextBoxColumn2,
            this.maxDataGridViewTextBoxColumn2,
            this.usoDataGridViewTextBoxColumn1,
            this.costrDataGridViewTextBoxColumn2,
            this.descrDataGridViewTextBoxColumn2,
            this.destinazDataGridViewTextBoxColumn2,
            this.nSchDataGridViewTextBoxColumn2,
            this.fdTDataGridViewTextBoxColumn2,
            this.consegnaInRepartoDataGridViewTextBoxColumn,
            this.ultTarDataGridViewTextBoxColumn2,
            this.scadenzaDataGridViewTextBoxColumn2,
            this.causaDataGridViewTextBoxColumn2,
            this.noteDataGridViewTextBoxColumn2});
            this.foglio3DataGridView.DataSource = this.foglio3BindingSource;
            this.foglio3DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foglio3DataGridView.Location = new System.Drawing.Point(0, 0);
            this.foglio3DataGridView.Name = "foglio3DataGridView";
            this.foglio3DataGridView.ReadOnly = true;
            this.foglio3DataGridView.Size = new System.Drawing.Size(812, 427);
            this.foglio3DataGridView.TabIndex = 0;
            this.foglio3DataGridView.Tag = "0";
            this.foglio3DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foglio3DataGridView_RowEnter);
            // 
            // matDataGridViewTextBoxColumn2
            // 
            this.matDataGridViewTextBoxColumn2.DataPropertyName = "Mat";
            this.matDataGridViewTextBoxColumn2.HeaderText = "Mat";
            this.matDataGridViewTextBoxColumn2.Name = "matDataGridViewTextBoxColumn2";
            this.matDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // risolDataGridViewTextBoxColumn2
            // 
            this.risolDataGridViewTextBoxColumn2.DataPropertyName = "Risol";
            this.risolDataGridViewTextBoxColumn2.HeaderText = "Risol";
            this.risolDataGridViewTextBoxColumn2.Name = "risolDataGridViewTextBoxColumn2";
            this.risolDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn2
            // 
            this.minDataGridViewTextBoxColumn2.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn2.HeaderText = "min";
            this.minDataGridViewTextBoxColumn2.Name = "minDataGridViewTextBoxColumn2";
            this.minDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn2
            // 
            this.maxDataGridViewTextBoxColumn2.DataPropertyName = "max";
            this.maxDataGridViewTextBoxColumn2.HeaderText = "max";
            this.maxDataGridViewTextBoxColumn2.Name = "maxDataGridViewTextBoxColumn2";
            this.maxDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // usoDataGridViewTextBoxColumn1
            // 
            this.usoDataGridViewTextBoxColumn1.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn1.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn1.Name = "usoDataGridViewTextBoxColumn1";
            this.usoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costrDataGridViewTextBoxColumn2
            // 
            this.costrDataGridViewTextBoxColumn2.DataPropertyName = "Costr";
            this.costrDataGridViewTextBoxColumn2.HeaderText = "Costr";
            this.costrDataGridViewTextBoxColumn2.Name = "costrDataGridViewTextBoxColumn2";
            this.costrDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn2
            // 
            this.descrDataGridViewTextBoxColumn2.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn2.HeaderText = "Descr";
            this.descrDataGridViewTextBoxColumn2.Name = "descrDataGridViewTextBoxColumn2";
            this.descrDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // destinazDataGridViewTextBoxColumn2
            // 
            this.destinazDataGridViewTextBoxColumn2.DataPropertyName = "Destinaz";
            this.destinazDataGridViewTextBoxColumn2.HeaderText = "Destinaz";
            this.destinazDataGridViewTextBoxColumn2.Name = "destinazDataGridViewTextBoxColumn2";
            this.destinazDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nSchDataGridViewTextBoxColumn2
            // 
            this.nSchDataGridViewTextBoxColumn2.DataPropertyName = "NSch";
            this.nSchDataGridViewTextBoxColumn2.HeaderText = "NSch";
            this.nSchDataGridViewTextBoxColumn2.Name = "nSchDataGridViewTextBoxColumn2";
            this.nSchDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fdTDataGridViewTextBoxColumn2
            // 
            this.fdTDataGridViewTextBoxColumn2.DataPropertyName = "FdT";
            this.fdTDataGridViewTextBoxColumn2.HeaderText = "FdT";
            this.fdTDataGridViewTextBoxColumn2.Name = "fdTDataGridViewTextBoxColumn2";
            this.fdTDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // consegnaInRepartoDataGridViewTextBoxColumn
            // 
            this.consegnaInRepartoDataGridViewTextBoxColumn.DataPropertyName = "Consegna in reparto";
            this.consegnaInRepartoDataGridViewTextBoxColumn.HeaderText = "Consegna in reparto";
            this.consegnaInRepartoDataGridViewTextBoxColumn.Name = "consegnaInRepartoDataGridViewTextBoxColumn";
            this.consegnaInRepartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultTarDataGridViewTextBoxColumn2
            // 
            this.ultTarDataGridViewTextBoxColumn2.DataPropertyName = "UltTar";
            this.ultTarDataGridViewTextBoxColumn2.HeaderText = "UltTar";
            this.ultTarDataGridViewTextBoxColumn2.Name = "ultTarDataGridViewTextBoxColumn2";
            this.ultTarDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // scadenzaDataGridViewTextBoxColumn2
            // 
            this.scadenzaDataGridViewTextBoxColumn2.DataPropertyName = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn2.HeaderText = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn2.Name = "scadenzaDataGridViewTextBoxColumn2";
            this.scadenzaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // causaDataGridViewTextBoxColumn2
            // 
            this.causaDataGridViewTextBoxColumn2.DataPropertyName = "Causa";
            this.causaDataGridViewTextBoxColumn2.HeaderText = "Causa";
            this.causaDataGridViewTextBoxColumn2.Name = "causaDataGridViewTextBoxColumn2";
            this.causaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn2
            // 
            this.noteDataGridViewTextBoxColumn2.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn2.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn2.Name = "noteDataGridViewTextBoxColumn2";
            this.noteDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.foglio8DataGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(812, 427);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "4000";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // foglio8DataGridView
            // 
            this.foglio8DataGridView.AllowUserToAddRows = false;
            this.foglio8DataGridView.AllowUserToDeleteRows = false;
            this.foglio8DataGridView.AutoGenerateColumns = false;
            this.foglio8DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foglio8DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglio8DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrDataGridViewTextBoxColumn,
            this.risolDataGridViewTextBoxColumn3,
            this.minDataGridViewTextBoxColumn3,
            this.maxDataGridViewTextBoxColumn3,
            this.usoDataGridViewTextBoxColumn2,
            this.udiMDataGridViewTextBoxColumn,
            this.costruttoreDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.destinazDataGridViewTextBoxColumn3,
            this.nSchDataGridViewTextBoxColumn3,
            this.fDiTDataGridViewTextBoxColumn,
            this.ultTarDataGridViewTextBoxColumn3,
            this.scadenzaDataGridViewTextBoxColumn3});
            this.foglio8DataGridView.DataSource = this.foglio8BindingSource;
            this.foglio8DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foglio8DataGridView.Location = new System.Drawing.Point(0, 0);
            this.foglio8DataGridView.Name = "foglio8DataGridView";
            this.foglio8DataGridView.ReadOnly = true;
            this.foglio8DataGridView.Size = new System.Drawing.Size(812, 427);
            this.foglio8DataGridView.TabIndex = 0;
            this.foglio8DataGridView.Tag = "0";
            this.foglio8DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foglio8DataGridView_RowEnter);
            // 
            // matrDataGridViewTextBoxColumn
            // 
            this.matrDataGridViewTextBoxColumn.DataPropertyName = "Matr";
            this.matrDataGridViewTextBoxColumn.HeaderText = "Matr";
            this.matrDataGridViewTextBoxColumn.Name = "matrDataGridViewTextBoxColumn";
            this.matrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // risolDataGridViewTextBoxColumn3
            // 
            this.risolDataGridViewTextBoxColumn3.DataPropertyName = "Risol";
            this.risolDataGridViewTextBoxColumn3.HeaderText = "Risol";
            this.risolDataGridViewTextBoxColumn3.Name = "risolDataGridViewTextBoxColumn3";
            this.risolDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn3
            // 
            this.minDataGridViewTextBoxColumn3.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn3.HeaderText = "min";
            this.minDataGridViewTextBoxColumn3.Name = "minDataGridViewTextBoxColumn3";
            this.minDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn3
            // 
            this.maxDataGridViewTextBoxColumn3.DataPropertyName = "max";
            this.maxDataGridViewTextBoxColumn3.HeaderText = "max";
            this.maxDataGridViewTextBoxColumn3.Name = "maxDataGridViewTextBoxColumn3";
            this.maxDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // usoDataGridViewTextBoxColumn2
            // 
            this.usoDataGridViewTextBoxColumn2.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn2.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn2.Name = "usoDataGridViewTextBoxColumn2";
            this.usoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // udiMDataGridViewTextBoxColumn
            // 
            this.udiMDataGridViewTextBoxColumn.DataPropertyName = "Udi M";
            this.udiMDataGridViewTextBoxColumn.HeaderText = "Udi M";
            this.udiMDataGridViewTextBoxColumn.Name = "udiMDataGridViewTextBoxColumn";
            this.udiMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costruttoreDataGridViewTextBoxColumn
            // 
            this.costruttoreDataGridViewTextBoxColumn.DataPropertyName = "Costruttore";
            this.costruttoreDataGridViewTextBoxColumn.HeaderText = "Costruttore";
            this.costruttoreDataGridViewTextBoxColumn.Name = "costruttoreDataGridViewTextBoxColumn";
            this.costruttoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinazDataGridViewTextBoxColumn3
            // 
            this.destinazDataGridViewTextBoxColumn3.DataPropertyName = "Destinaz";
            this.destinazDataGridViewTextBoxColumn3.HeaderText = "Destinaz";
            this.destinazDataGridViewTextBoxColumn3.Name = "destinazDataGridViewTextBoxColumn3";
            this.destinazDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nSchDataGridViewTextBoxColumn3
            // 
            this.nSchDataGridViewTextBoxColumn3.DataPropertyName = "NSch";
            this.nSchDataGridViewTextBoxColumn3.HeaderText = "NSch";
            this.nSchDataGridViewTextBoxColumn3.Name = "nSchDataGridViewTextBoxColumn3";
            this.nSchDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fDiTDataGridViewTextBoxColumn
            // 
            this.fDiTDataGridViewTextBoxColumn.DataPropertyName = "F di T";
            this.fDiTDataGridViewTextBoxColumn.HeaderText = "F di T";
            this.fDiTDataGridViewTextBoxColumn.Name = "fDiTDataGridViewTextBoxColumn";
            this.fDiTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultTarDataGridViewTextBoxColumn3
            // 
            this.ultTarDataGridViewTextBoxColumn3.DataPropertyName = "Ult Tar";
            this.ultTarDataGridViewTextBoxColumn3.HeaderText = "Ult Tar";
            this.ultTarDataGridViewTextBoxColumn3.Name = "ultTarDataGridViewTextBoxColumn3";
            this.ultTarDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // scadenzaDataGridViewTextBoxColumn3
            // 
            this.scadenzaDataGridViewTextBoxColumn3.DataPropertyName = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn3.HeaderText = "Scadenza";
            this.scadenzaDataGridViewTextBoxColumn3.Name = "scadenzaDataGridViewTextBoxColumn3";
            this.scadenzaDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.foglio6DataGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(812, 427);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "6000";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // foglio6DataGridView
            // 
            this.foglio6DataGridView.AllowUserToAddRows = false;
            this.foglio6DataGridView.AllowUserToDeleteRows = false;
            this.foglio6DataGridView.AllowUserToResizeColumns = false;
            this.foglio6DataGridView.AllowUserToResizeRows = false;
            this.foglio6DataGridView.AutoGenerateColumns = false;
            this.foglio6DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglio6DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrDataGridViewTextBoxColumn1,
            this.diametroDataGridViewTextBoxColumn,
            this.udmDataGridViewTextBoxColumn,
            this.usoDataGridViewTextBoxColumn3,
            this.destinazioneDataGridViewTextBoxColumn,
            this.nSchDataGridViewTextBoxColumn4,
            this.frequenzaDataGridViewTextBoxColumn,
            this.ultimaTarDataGridViewTextBoxColumn,
            this.valoreRilevatoDataGridViewTextBoxColumn});
            this.foglio6DataGridView.DataSource = this.foglio6BindingSource;
            this.foglio6DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foglio6DataGridView.Location = new System.Drawing.Point(0, 0);
            this.foglio6DataGridView.Name = "foglio6DataGridView";
            this.foglio6DataGridView.ReadOnly = true;
            this.foglio6DataGridView.Size = new System.Drawing.Size(812, 427);
            this.foglio6DataGridView.TabIndex = 0;
            this.foglio6DataGridView.Tag = "0";
            this.foglio6DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foglio6DataGridView_RowEnter);
            // 
            // matrDataGridViewTextBoxColumn1
            // 
            this.matrDataGridViewTextBoxColumn1.DataPropertyName = "Matr";
            this.matrDataGridViewTextBoxColumn1.HeaderText = "Matr";
            this.matrDataGridViewTextBoxColumn1.Name = "matrDataGridViewTextBoxColumn1";
            this.matrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // diametroDataGridViewTextBoxColumn
            // 
            this.diametroDataGridViewTextBoxColumn.DataPropertyName = "diametro";
            this.diametroDataGridViewTextBoxColumn.HeaderText = "diametro";
            this.diametroDataGridViewTextBoxColumn.Name = "diametroDataGridViewTextBoxColumn";
            this.diametroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // udmDataGridViewTextBoxColumn
            // 
            this.udmDataGridViewTextBoxColumn.DataPropertyName = "Udm";
            this.udmDataGridViewTextBoxColumn.HeaderText = "Udm";
            this.udmDataGridViewTextBoxColumn.Name = "udmDataGridViewTextBoxColumn";
            this.udmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usoDataGridViewTextBoxColumn3
            // 
            this.usoDataGridViewTextBoxColumn3.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn3.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn3.Name = "usoDataGridViewTextBoxColumn3";
            this.usoDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // destinazioneDataGridViewTextBoxColumn
            // 
            this.destinazioneDataGridViewTextBoxColumn.DataPropertyName = "Destinazione";
            this.destinazioneDataGridViewTextBoxColumn.HeaderText = "Destinazione";
            this.destinazioneDataGridViewTextBoxColumn.Name = "destinazioneDataGridViewTextBoxColumn";
            this.destinazioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nSchDataGridViewTextBoxColumn4
            // 
            this.nSchDataGridViewTextBoxColumn4.DataPropertyName = "N Sch";
            this.nSchDataGridViewTextBoxColumn4.HeaderText = "N Sch";
            this.nSchDataGridViewTextBoxColumn4.Name = "nSchDataGridViewTextBoxColumn4";
            this.nSchDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frequenzaDataGridViewTextBoxColumn
            // 
            this.frequenzaDataGridViewTextBoxColumn.DataPropertyName = "Frequenza";
            this.frequenzaDataGridViewTextBoxColumn.HeaderText = "Frequenza";
            this.frequenzaDataGridViewTextBoxColumn.Name = "frequenzaDataGridViewTextBoxColumn";
            this.frequenzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultimaTarDataGridViewTextBoxColumn
            // 
            this.ultimaTarDataGridViewTextBoxColumn.DataPropertyName = "Ultima tar";
            this.ultimaTarDataGridViewTextBoxColumn.HeaderText = "Ultima tar";
            this.ultimaTarDataGridViewTextBoxColumn.Name = "ultimaTarDataGridViewTextBoxColumn";
            this.ultimaTarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoreRilevatoDataGridViewTextBoxColumn
            // 
            this.valoreRilevatoDataGridViewTextBoxColumn.DataPropertyName = "Valore rilevato";
            this.valoreRilevatoDataGridViewTextBoxColumn.HeaderText = "Valore rilevato";
            this.valoreRilevatoDataGridViewTextBoxColumn.Name = "valoreRilevatoDataGridViewTextBoxColumn";
            this.valoreRilevatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.foglio7DataGridView);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(812, 427);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "varie";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // foglio7DataGridView
            // 
            this.foglio7DataGridView.AllowUserToAddRows = false;
            this.foglio7DataGridView.AllowUserToDeleteRows = false;
            this.foglio7DataGridView.AutoGenerateColumns = false;
            this.foglio7DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foglio7DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.matricolaDataGridViewTextBoxColumn,
            this.strumentoDataGridViewTextBoxColumn,
            this.repartoDataGridViewTextBoxColumn,
            this.intervalloTaraturaDataGridViewTextBoxColumn,
            this.dataUltimaTaraturaDataGridViewTextBoxColumn});
            this.foglio7DataGridView.DataSource = this.foglio7BindingSource;
            this.foglio7DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foglio7DataGridView.Location = new System.Drawing.Point(0, 0);
            this.foglio7DataGridView.Name = "foglio7DataGridView";
            this.foglio7DataGridView.ReadOnly = true;
            this.foglio7DataGridView.Size = new System.Drawing.Size(812, 427);
            this.foglio7DataGridView.TabIndex = 0;
            this.foglio7DataGridView.Tag = "0";
            this.foglio7DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.foglio7DataGridView_RowEnter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // matricolaDataGridViewTextBoxColumn
            // 
            this.matricolaDataGridViewTextBoxColumn.DataPropertyName = "Matricola";
            this.matricolaDataGridViewTextBoxColumn.HeaderText = "Matricola";
            this.matricolaDataGridViewTextBoxColumn.Name = "matricolaDataGridViewTextBoxColumn";
            this.matricolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strumentoDataGridViewTextBoxColumn
            // 
            this.strumentoDataGridViewTextBoxColumn.DataPropertyName = "Strumento";
            this.strumentoDataGridViewTextBoxColumn.HeaderText = "Strumento";
            this.strumentoDataGridViewTextBoxColumn.Name = "strumentoDataGridViewTextBoxColumn";
            this.strumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repartoDataGridViewTextBoxColumn
            // 
            this.repartoDataGridViewTextBoxColumn.DataPropertyName = "Reparto";
            this.repartoDataGridViewTextBoxColumn.HeaderText = "Reparto";
            this.repartoDataGridViewTextBoxColumn.Name = "repartoDataGridViewTextBoxColumn";
            this.repartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intervalloTaraturaDataGridViewTextBoxColumn
            // 
            this.intervalloTaraturaDataGridViewTextBoxColumn.DataPropertyName = "Intervallo taratura";
            this.intervalloTaraturaDataGridViewTextBoxColumn.HeaderText = "Intervallo taratura";
            this.intervalloTaraturaDataGridViewTextBoxColumn.Name = "intervalloTaraturaDataGridViewTextBoxColumn";
            this.intervalloTaraturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataUltimaTaraturaDataGridViewTextBoxColumn
            // 
            this.dataUltimaTaraturaDataGridViewTextBoxColumn.DataPropertyName = "Data ultima taratura";
            this.dataUltimaTaraturaDataGridViewTextBoxColumn.HeaderText = "Data ultima taratura";
            this.dataUltimaTaraturaDataGridViewTextBoxColumn.Name = "dataUltimaTaraturaDataGridViewTextBoxColumn";
            this.dataUltimaTaraturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gestioneCalibriDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calibri Filettati";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gestioneCalibriDataGridView
            // 
            this.gestioneCalibriDataGridView.AllowUserToAddRows = false;
            this.gestioneCalibriDataGridView.AllowUserToDeleteRows = false;
            this.gestioneCalibriDataGridView.AllowUserToResizeRows = false;
            this.gestioneCalibriDataGridView.AutoGenerateColumns = false;
            this.gestioneCalibriDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gestioneCalibriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gestioneCalibriDataGridView.DataSource = this.gestioneCalibriBindingSource;
            this.gestioneCalibriDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gestioneCalibriDataGridView.Location = new System.Drawing.Point(3, 3);
            this.gestioneCalibriDataGridView.Name = "gestioneCalibriDataGridView";
            this.gestioneCalibriDataGridView.ReadOnly = true;
            this.gestioneCalibriDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gestioneCalibriDataGridView.RowHeadersVisible = false;
            this.gestioneCalibriDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gestioneCalibriDataGridView.RowTemplate.ReadOnly = true;
            this.gestioneCalibriDataGridView.ShowCellToolTips = false;
            this.gestioneCalibriDataGridView.Size = new System.Drawing.Size(820, 453);
            this.gestioneCalibriDataGridView.StandardTab = true;
            this.gestioneCalibriDataGridView.TabIndex = 2;
            this.gestioneCalibriDataGridView.Tag = "0";
            this.gestioneCalibriDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gestioneCalibriDataGridView_CellMouseClick);
            this.gestioneCalibriDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gestioneCalibriDataGridView_CellMouseDoubleClick);
            this.gestioneCalibriDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gestioneCalibriDataGridView_ColumnHeaderMouseClick);
            this.gestioneCalibriDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gestioneCalibriDataGridView_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MATRICOLA";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "MATRICOLA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIZION";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIZION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TIPO";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VITA";
            this.dataGridViewTextBoxColumn5.HeaderText = "VITA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UTENTE";
            this.dataGridViewTextBoxColumn6.HeaderText = "DESTINAZIONE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VARIE";
            this.dataGridViewTextBoxColumn7.HeaderText = "VARIE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VITA INIZIALE";
            this.dataGridViewTextBoxColumn8.HeaderText = "VITA INIZIALE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 485);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Calibri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestione_CalibriDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foglio1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglio7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibri_LisciDataSet)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foglio1DataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foglio2DataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foglio3DataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foglio8DataGridView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foglio6DataGridView)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foglio7DataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitaInScadenzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scadutiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private Gestione_CalibriDataSet gestione_CalibriDataSet;
        private System.Windows.Forms.BindingSource gestioneCalibriBindingSource;
        private Gestione_CalibriDataSetTableAdapters.GestioneCalibriTableAdapter gestioneCalibriTableAdapter;
        private Gestione_CalibriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblistruzioni;
        private System.Windows.Forms.ToolStripMenuItem ricercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaFiltroToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripPsw;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource foglio1BindingSource;
        private Database1DataSetTableAdapters.Foglio1TableAdapter foglio1TableAdapter;
        private System.Windows.Forms.BindingSource foglio2BindingSource;
        private Database1DataSetTableAdapters.Foglio2TableAdapter foglio2TableAdapter;
        private System.Windows.Forms.BindingSource foglio3BindingSource;
        private Database1DataSetTableAdapters.Foglio3TableAdapter foglio3TableAdapter;
        private System.Windows.Forms.BindingSource foglio8BindingSource;
        private Database1DataSetTableAdapters.Foglio8TableAdapter foglio8TableAdapter;
        private System.Windows.Forms.BindingSource foglio6BindingSource;
        private Database1DataSetTableAdapters.Foglio6TableAdapter foglio6TableAdapter;
        private System.Windows.Forms.BindingSource foglio7BindingSource;
        private Database1DataSetTableAdapters.Foglio7TableAdapter foglio7TableAdapter;
        private Calibri_LisciDataSet calibri_LisciDataSet;
        private System.Windows.Forms.BindingSource calibr_LisciBindingSource;
        private Calibri_LisciDataSetTableAdapters.Calibr_LisciTableAdapter calibr_LisciTableAdapter;
        private Calibri_LisciDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView calibr_LisciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView foglio1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn risolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consegnatoNuovoIlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultTarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView foglio2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn risolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consegnatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultTarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadenzaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn causaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView foglio3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn risolDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costrDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSchDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdTDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn consegnaInRepartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultTarDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadenzaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn causaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView foglio8DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn risolDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn udiMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costruttoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSchDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultTarDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadenzaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView foglio6DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diametroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSchDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaTarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoreRilevatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView foglio7DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalloTaraturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltimaTaraturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gestioneCalibriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem calibriLisciToolStripMenuItem;
    }
}

