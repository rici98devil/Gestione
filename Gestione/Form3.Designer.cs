namespace Gestione
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.txtUtile = new System.Windows.Forms.TextBox();
            this.txtNonPassa = new System.Windows.Forms.TextBox();
            this.txtPassa = new System.Windows.Forms.TextBox();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdSalva = new System.Windows.Forms.ToolStripButton();
            this.cmdEsci = new System.Windows.Forms.ToolStripButton();
            this.calibri_LisciDataSet = new Gestione.Calibri_LisciDataSet();
            this.calibr_LisciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calibr_LisciTableAdapter = new Gestione.Calibri_LisciDataSetTableAdapters.Calibr_LisciTableAdapter();
            this.tableAdapterManager = new Gestione.Calibri_LisciDataSetTableAdapters.TableAdapterManager();
            this.calibr_LisciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVarie = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibri_LisciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lunghez. Utile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dim. non Passa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dim. Passa";
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricola.Location = new System.Drawing.Point(12, 47);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(69, 18);
            this.lblMatricola.TabIndex = 13;
            this.lblMatricola.Text = "Matricola";
            // 
            // txtUtile
            // 
            this.txtUtile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtile.Location = new System.Drawing.Point(161, 154);
            this.txtUtile.MaxLength = 99;
            this.txtUtile.Name = "txtUtile";
            this.txtUtile.Size = new System.Drawing.Size(142, 24);
            this.txtUtile.TabIndex = 12;
            this.txtUtile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVitaIniziale_KeyDown);
            // 
            // txtNonPassa
            // 
            this.txtNonPassa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNonPassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonPassa.Location = new System.Drawing.Point(160, 121);
            this.txtNonPassa.MaxLength = 99;
            this.txtNonPassa.Name = "txtNonPassa";
            this.txtNonPassa.Size = new System.Drawing.Size(142, 24);
            this.txtNonPassa.TabIndex = 11;
            this.txtNonPassa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipo_KeyDown);
            // 
            // txtPassa
            // 
            this.txtPassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassa.Location = new System.Drawing.Point(161, 83);
            this.txtPassa.MaxLength = 99;
            this.txtPassa.Name = "txtPassa";
            this.txtPassa.Size = new System.Drawing.Size(141, 24);
            this.txtPassa.TabIndex = 10;
            this.txtPassa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescrizione_KeyDown);
            // 
            // txtMatricola
            // 
            this.txtMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricola.Location = new System.Drawing.Point(160, 44);
            this.txtMatricola.MaxLength = 99;
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(142, 24);
            this.txtMatricola.TabIndex = 9;
            this.txtMatricola.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMatricola_KeyUp);
            this.txtMatricola.Leave += new System.EventHandler(this.txtMatricola_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Posizione CQ";
            // 
            // txtPosizione
            // 
            this.txtPosizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosizione.Location = new System.Drawing.Point(160, 221);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(142, 24);
            this.txtPosizione.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSalva,
            this.cmdEsci});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(342, 27);
            this.toolStrip1.TabIndex = 22;
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
            // calibri_LisciDataSet
            // 
            this.calibri_LisciDataSet.DataSetName = "Calibri_LisciDataSet";
            this.calibri_LisciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calibr_LisciBindingSource
            // 
            this.calibr_LisciBindingSource.DataMember = "Calibr Lisci";
            this.calibr_LisciBindingSource.DataSource = this.calibri_LisciDataSet;
            // 
            // calibr_LisciTableAdapter
            // 
            this.calibr_LisciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calibr_LisciTableAdapter = this.calibr_LisciTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestione.Calibri_LisciDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calibr_LisciDataGridView
            // 
            this.calibr_LisciDataGridView.AllowUserToAddRows = false;
            this.calibr_LisciDataGridView.AllowUserToDeleteRows = false;
            this.calibr_LisciDataGridView.AutoGenerateColumns = false;
            this.calibr_LisciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calibr_LisciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.calibr_LisciDataGridView.DataSource = this.calibr_LisciBindingSource;
            this.calibr_LisciDataGridView.Location = new System.Drawing.Point(0, 303);
            this.calibr_LisciDataGridView.Name = "calibr_LisciDataGridView";
            this.calibr_LisciDataGridView.ReadOnly = true;
            this.calibr_LisciDataGridView.Size = new System.Drawing.Size(142, 48);
            this.calibr_LisciDataGridView.TabIndex = 23;
            this.calibr_LisciDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricola";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricola";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dimensione Passa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dimensione Passa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dimensione non Passa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dimensione non Passa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Utile (Passa)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Utile (Passa)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Destinazione";
            this.dataGridViewTextBoxColumn5.HeaderText = "Destinazione";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Varie";
            this.dataGridViewTextBoxColumn6.HeaderText = "Varie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Posizione CQ";
            this.dataGridViewTextBoxColumn7.HeaderText = "Posizione CQ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Varie";
            // 
            // txtVarie
            // 
            this.txtVarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarie.Location = new System.Drawing.Point(160, 188);
            this.txtVarie.Name = "txtVarie";
            this.txtVarie.Size = new System.Drawing.Size(142, 24);
            this.txtVarie.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(342, 267);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVarie);
            this.Controls.Add(this.calibr_LisciDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPosizione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatricola);
            this.Controls.Add(this.txtUtile);
            this.Controls.Add(this.txtNonPassa);
            this.Controls.Add(this.txtPassa);
            this.Controls.Add(this.txtMatricola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibri_LisciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calibr_LisciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.TextBox txtUtile;
        private System.Windows.Forms.TextBox txtNonPassa;
        private System.Windows.Forms.TextBox txtPassa;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdSalva;
        private System.Windows.Forms.ToolStripButton cmdEsci;
        private Calibri_LisciDataSet calibri_LisciDataSet;
        private System.Windows.Forms.BindingSource calibr_LisciBindingSource;
        private Calibri_LisciDataSetTableAdapters.Calibr_LisciTableAdapter calibr_LisciTableAdapter;
        private Calibri_LisciDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView calibr_LisciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVarie;
    }
}