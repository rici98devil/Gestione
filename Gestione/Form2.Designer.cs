namespace Gestione
{
    partial class frmUscita
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
            this.bntOk = new System.Windows.Forms.Button();
            this.txtDestinazione = new System.Windows.Forms.TextBox();
            this.txtDesrizione = new System.Windows.Forms.TextBox();
            this.lblVarie = new System.Windows.Forms.Label();
            this.lbldestinazione = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(8, 95);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(119, 42);
            this.bntOk.TabIndex = 0;
            this.bntOk.Text = "Ok";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // txtDestinazione
            // 
            this.txtDestinazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinazione.Location = new System.Drawing.Point(8, 59);
            this.txtDestinazione.Name = "txtDestinazione";
            this.txtDestinazione.Size = new System.Drawing.Size(260, 24);
            this.txtDestinazione.TabIndex = 1;
            // 
            // txtDesrizione
            // 
            this.txtDesrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesrizione.Location = new System.Drawing.Point(8, 125);
            this.txtDesrizione.Multiline = true;
            this.txtDesrizione.Name = "txtDesrizione";
            this.txtDesrizione.Size = new System.Drawing.Size(260, 83);
            this.txtDesrizione.TabIndex = 2;
            // 
            // lblVarie
            // 
            this.lblVarie.AutoSize = true;
            this.lblVarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarie.Location = new System.Drawing.Point(12, 95);
            this.lblVarie.Name = "lblVarie";
            this.lblVarie.Size = new System.Drawing.Size(41, 18);
            this.lblVarie.TabIndex = 3;
            this.lblVarie.Text = "Varie";
            // 
            // lbldestinazione
            // 
            this.lbldestinazione.AutoSize = true;
            this.lbldestinazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldestinazione.Location = new System.Drawing.Point(12, 22);
            this.lbldestinazione.Name = "lbldestinazione";
            this.lbldestinazione.Size = new System.Drawing.Size(94, 18);
            this.lbldestinazione.TabIndex = 4;
            this.lbldestinazione.Text = "Destinazione";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Esci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUscita
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(272, 332);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldestinazione);
            this.Controls.Add(this.lblVarie);
            this.Controls.Add(this.txtDesrizione);
            this.Controls.Add(this.txtDestinazione);
            this.Controls.Add(this.bntOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUscita";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uscita";
            this.Load += new System.EventHandler(this.frmUscita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.TextBox txtDestinazione;
        private System.Windows.Forms.TextBox txtDesrizione;
        private System.Windows.Forms.Label lblVarie;
        private System.Windows.Forms.Label lbldestinazione;
        private System.Windows.Forms.Button button1;
    }
}