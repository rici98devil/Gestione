using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestione
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cmdEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescrizione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete
                  & e.KeyCode != Keys.Oemcomma)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {

                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        e.SuppressKeyPress = true;

                    }

                }
            }
        }

        private void txtTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete
                & e.KeyCode != Keys.Oemcomma)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {

                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        e.SuppressKeyPress = true;

                    }

                }
            }
        }

        private void txtVitaIniziale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete
                  & e.KeyCode != Keys.Oemcomma)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {

                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        e.SuppressKeyPress = true;

                    }

                }
            }
        }

        private void cmdSalva_Click(object sender, EventArgs e)
        {
            Controllo();

            if (Global.Completa == true)
            {

                Global.Matricola = txtMatricola.Text.ToString();
                Global.Min = txtPassa.Text.ToString();
                Global.Max = txtNonPassa.Text.ToString();
                Global.Risoluzione = txtUtile.Text.ToString();
                Global.Uso = txtPosizione.Text.ToString();
                Global.Varie = txtVarie.Text.ToString();
                Global.salvataggio = true;

                if (this.Text == "Inserisci")
                {
                    this.calibr_LisciTableAdapter.InsertQuery(Global.Matricola, Global.Min, Global.Max, decimal.Parse(Global.Risoluzione),Global.Varie,Global.Uso);
                    var result = MessageBox.Show("Vuoi inserire altri calibri ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        txtMatricola.Clear();
                        txtPassa.Clear();
                        txtNonPassa.Clear();
                        txtUtile.Clear();
                        txtPosizione.Clear();
                        txtVarie.Clear();
                        calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                    }
                    else
                    {
                        this.Close();
                        this.Dispose();
                    }
                }

                if (this.Text == "Modifica")
                {
                    this.Close();
                    this.Dispose();
                }



            }
            else
            {
                MessageBox.Show("Tutte le caselle devono essere piene", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Controllo()
        {
            Global.Completa = true;
            if (txtMatricola.Text == "")
            {
                txtMatricola.BackColor = Color.Yellow;
                Global.Completa = false;

                return;
            }
            else
            {
                txtMatricola.BackColor = Color.White;
            }
            if (txtPassa.Text == "")
            {
                txtPassa.BackColor = Color.Yellow;
                Global.Completa = false;
                return;
            }
            else
            {
                txtPassa.BackColor = Color.White;
            }
            if (txtNonPassa.Text == "")
            {
                txtNonPassa.BackColor = Color.Yellow;
              Global.Completa = false;
                return;
            }
            else
            {
                txtNonPassa.BackColor = Color.White;
            }
            if (txtUtile.Text == "")
            {
                txtUtile.BackColor = Color.Yellow;
                Global.Completa = false;
                return;
            }
            else
            {
                txtUtile.BackColor = Color.White;
            }


        }

        private void calibr_LisciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calibr_LisciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calibri_LisciDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'calibri_LisciDataSet.Calibr_Lisci'. È possibile spostarla o rimuoverla se necessario.
            this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
            Global.salvataggio = false;
            cmdEsci.ToolTipText = "Esce senza apportare nessuna modifica alla tabella";
            if (this.Text == "Modifica")
            {
               txtMatricola.Text = Global.Matricola;
               txtPassa.Text = Global.Min;
               txtNonPassa.Text = Global.Max;
               txtUtile.Text = Global.Risoluzione;
               txtVarie.Text = Global.Varie;
               txtPosizione.Text = Global.Uso; 

                cmdSalva.Text = "Modifica";
                cmdSalva.ToolTipText = "Salva in tabella le modifiche effetuate";
            }

            if (this.Text == "Inserisci")
            {

                cmdSalva.Text = "Inserisci";
                cmdSalva.ToolTipText = "Inserisce un nuovo calibro nella tabella";
                               
            }






        }

        private void txtMatricola_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                calibr_LisciTableAdapter.FillByMatricola(this.calibri_LisciDataSet.Calibr_Lisci, txtMatricola.Text.ToString());
            }
            catch (Exception)
            {

                calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
            }
        }

        private void txtMatricola_Leave(object sender, EventArgs e)
        {
            int i = 0;// calibr_LisciDataGridView.RowCount;

            if (i > 0)
            {
                MessageBox.Show("Matricola gia esistente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricola.Clear();
                txtMatricola.Focus();

                calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
            }
        }

       
    }
}