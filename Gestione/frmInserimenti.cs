using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione
{
    public partial class frmInserimenti : Form
    {
        public frmInserimenti()
        {
            InitializeComponent();
        }

        private void cmdEsci_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtMatricola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete & e.KeyCode !=Keys.Enter)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {

                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        e.SuppressKeyPress = true;

                    }

                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmdSalva_Click(object sender, EventArgs e)
        {

            Controllo();
            if (Global.Completa == true)
            {

            Global.Matricola = txtMatricola.Text.ToString();
            Global.Descrizione = txtDescrizione.Text.ToString();
            Global.Tipo = txtTipo.Text.ToString();
            Global.VitaIniziale = txtVitaIniziale.Text.ToString();
            Global.salvataggio = true;

                if (this.Text == "Inserisci")
                {
                    this.gestioneCalibriTableAdapter.InserimentoDati(Int16.Parse(Global.Matricola), Global.Descrizione, Global.Tipo, Int16.Parse(Global.VitaIniziale), Int16.Parse(Global.VitaIniziale));
                    var result = MessageBox.Show("Vuoi inserire altri calibri ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        txtMatricola.Clear();
                        txtDescrizione.Clear();
                        txtTipo.Clear();
                        txtVitaIniziale.Clear();
                        this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);

                    }
                    else
                    {
                       this.Close();
                      this.Dispose();
                    }
                }

                if (this.Text == "Modifica") {
                    this.Close();
                    this.Dispose();
                }



            }
            else
            {
                MessageBox.Show("Tutte le caselle devono essere piene", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          


        }

        private void txtVitaIniziale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete & e.KeyCode != Keys.Enter)
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

        private void frmInserimenti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'gestione_CalibriDataSet.GestioneCalibri'. È possibile spostarla o rimuoverla se necessario.
            this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
            Global.salvataggio = false;
            cmdEsci.ToolTipText = "Esce senza apportare nessuna modifica alla tabella";
            if (this.Text == "Modifica")
            {
                txtMatricola.Text = Global.Matricola;
                txtDescrizione.Text = Global.Descrizione;
                txtTipo.Text = Global.Tipo;
                txtVitaIniziale.Text = Global.VitaIniziale;

                txtMatricola.Enabled = false;
                txtDescrizione.Enabled = true;
                txtTipo.Enabled = true;
                txtVitaIniziale.Enabled = true;
                cmdSalva.Text = "Modifica";
                cmdSalva.ToolTipText = "Salva in tabella le modifiche effetuate";
            }
         
            if (this.Text == "Inserisci")
            {
               
                txtMatricola.Enabled = true;
                txtDescrizione.Enabled = true;
                txtTipo.Enabled = true;
                txtVitaIniziale.Enabled = true;
                cmdSalva.Text = "Inserisci";
                cmdSalva.ToolTipText = "Inserisce un nuovo calibro nella tabella";





            }




        }

        private void txtMatricola_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                int convertitore = Int16.Parse(txtMatricola.Text.ToString());
                gestioneCalibriTableAdapter.FillByMatricola(this.gestione_CalibriDataSet.GestioneCalibri, convertitore);
            }
            catch (Exception)
            {

                gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
            }
                
            
           
       
        }

        private void txtMatricola_Leave(object sender, EventArgs e)
        {
            int i = gestioneCalibriDataGridView.RowCount;
            if (i>0)
            {
                MessageBox.Show("Matricola gia esistente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricola.Clear();
                txtMatricola.Focus();
                gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
            }
        }
        private void Controllo()
        {
            Global.Completa = true;
            if (txtMatricola.Text== "")
            {
                txtMatricola.BackColor = Color.Yellow;
                Global.Completa = false;

                return;
            }
            else
            {
                txtMatricola.BackColor = Color.White;
            }
            if (txtDescrizione.Text== "")
            {
                txtDescrizione.BackColor = Color.Yellow;
                Global.Completa = false;
                return;
            }
            else
            {
                txtDescrizione.BackColor = Color.White;
            }
            if (txtDescrizione.Text== "")
            {
                txtDescrizione.BackColor = Color.Yellow;
                Global.Completa = false;
                return;
            }
            else
            {
                txtDescrizione.BackColor = Color.White;
            }
            if (txtVitaIniziale.Text== "")
            {
                txtVitaIniziale.BackColor = Color.Yellow;
                Global.Completa = false;
                return;
            }
            else
            {
                txtVitaIniziale.BackColor = Color.White;
            }


        }





    }
}
