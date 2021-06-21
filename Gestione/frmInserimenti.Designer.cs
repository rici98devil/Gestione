namespace Gestione
{
    partial class frmInserimenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserimenti));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdSalva = new System.Windows.Forms.ToolStripButton();
            this.cmdEsci = new System.Windows.Forms.ToolStripButton();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtVitaIniziale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gestione_CalibriDataSet = new Gestione.Gestione_CalibriDataSet();
            this.gestioneCalibriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneCalibriTableAdapter = new Gestione.Gestione_CalibriDataSetTableAdapters.GestioneCalibriTableAdapter();
            this.tableAdapterManager = new Gestione.Gestione_CalibriDataSetTableAdapters.TableAdapterManager();
            this.gestioneCalibriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestione_CalibriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSalva,
            this.cmdEsci});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(268, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdSalva
            // 
            this.cmdSalva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdSalva.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalva.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalva.Image")));
            this.cmdSalva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSalva.Name = "cmdSalva";
            this.cmdSalva.Size = new System.Drawing.Size(48, 24);
            this.cmdSalva.Text = "Salva";
            this.cmdSalva.Click += new System.EventHandler(this.cmdSalva_Click);
            // 
            // cmdEsci
            // 
            this.cmdEsci.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdEsci.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEsci.Image = ((System.Drawing.Image)(resources.GetObject("cmdEsci.Image")));
            this.cmdEsci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEsci.Name = "cmdEsci";
            this.cmdEsci.Size = new System.Drawing.Size(38, 24);
            this.cmdEsci.Text = "Esci";
            this.cmdEsci.Click += new System.EventHandler(this.cmdEsci_Click);
            // 
            // txtMatricola
            // 
            this.txtMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricola.Location = new System.Drawing.Point(130, 39);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(111, 24);
            this.txtMatricola.TabIndex = 1;
            this.txtMatricola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatricola_KeyDown);
            this.txtMatricola.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMatricola_KeyUp);
            this.txtMatricola.Leave += new System.EventHandler(this.txtMatricola_Leave);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrizione.Location = new System.Drawing.Point(131, 78);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(110, 24);
            this.txtDescrizione.TabIndex = 2;
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(130, 116);
            this.txtTipo.MaxLength = 1;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(111, 24);
            this.txtTipo.TabIndex = 3;
            // 
            // txtVitaIniziale
            // 
            this.txtVitaIniziale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitaIniziale.Location = new System.Drawing.Point(131, 152);
            this.txtVitaIniziale.MaxLength = 4;
            this.txtVitaIniziale.Name = "txtVitaIniziale";
            this.txtVitaIniziale.Size = new System.Drawing.Size(110, 24);
            this.txtVitaIniziale.TabIndex = 4;
            this.txtVitaIniziale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVitaIniziale_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matricola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vita iniziale";
            // 
            // gestione_CalibriDataSet
            // 
            this.gestione_CalibriDataSet.DataSetName = "Gestione_CalibriDataSet";
            this.gestione_CalibriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestioneCalibriBindingSource
            // 
            this.gestioneCalibriBindingSource.DataMember = "GestioneCalibri";
            this.gestioneCalibriBindingSource.DataSource = this.gestione_CalibriDataSet;
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
            // gestioneCalibriDataGridView
            // 
            this.gestioneCalibriDataGridView.AllowUserToAddRows = false;
            this.gestioneCalibriDataGridView.AllowUserToDeleteRows = false;
            this.gestioneCalibriDataGridView.AutoGenerateColumns = false;
            this.gestioneCalibriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.gestioneCalibriDataGridView.Location = new System.Drawing.Point(-19, 195);
            this.gestioneCalibriDataGridView.Name = "gestioneCalibriDataGridView";
            this.gestioneCalibriDataGridView.ReadOnly = true;
            this.gestioneCalibriDataGridView.Size = new System.Drawing.Size(68, 51);
            this.gestioneCalibriDataGridView.TabIndex = 9;
            this.gestioneCalibriDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MATRICOLA";
            this.dataGridViewTextBoxColumn1.HeaderText = "MATRICOLA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIZION";
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
            this.dataGridViewTextBoxColumn6.HeaderText = "UTENTE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VARIE";
            this.dataGridViewTextBoxColumn7.HeaderText = "VARIE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VITA INIZIALE";
            this.dataGridViewTextBoxColumn8.HeaderText = "VITA INIZIALE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmInserimenti
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(268, 200);
            this.ControlBox = false;
            this.Controls.Add(this.gestioneCalibriDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVitaIniziale);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserimenti";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuovi dati";
            this.Load += new System.EventHandler(this.frmInserimenti_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestione_CalibriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneCalibriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdSalva;
        private System.Windows.Forms.ToolStripButton cmdEsci;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtVitaIniziale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Gestione_CalibriDataSet gestione_CalibriDataSet;
        private System.Windows.Forms.BindingSource gestioneCalibriBindingSource;
        private Gestione_CalibriDataSetTableAdapters.GestioneCalibriTableAdapter gestioneCalibriTableAdapter;
        private Gestione_CalibriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gestioneCalibriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}