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
    public partial class frmVita : Form
    {


        public frmVita()
        {
            InitializeComponent();

        }


        private void frmVita_Load(object sender, EventArgs e)
        {
            Cancella();
            toolTip1.SetToolTip(this.txtConsegnato, "es: 01/12/2020");
            toolTip1.SetToolTip(this.txtUltima, "es: 01/12/2020");
            toolTip1.SetToolTip(this.txtscadenza, "es: 01/12/2020");
            Forma();
            if (this.Text == "Inserisci")
            {
                DateTime data1 = DateTime.Today;
                DateTime data0 = data1.AddMonths(12);
                txtscadenza.Text = data0.ToString("dd/MM/yyyy");
                txtUltima.Text = data1.ToString("dd/MM/yyyy");
                txtConsegnato.Text = data1.ToString("dd/MM/yyyy");
                txtFdt.Text = "12";

            }
            else
            {
               


                try
                {
                    DateTime Data0 = DateTime.Parse(Global.Scadenza);
                    txtscadenza.Text = Data0.ToString("dd/MM/yyyy");

                }
                catch { }

                if (Global.UltTaratura.ToString() != "")
                {
                    DateTime data1 = DateTime.Parse(Global.UltTaratura);
                    txtUltima.Text = data1.ToString("dd/MM/yyyy");
                }

                try
                {
                    DateTime data2 = DateTime.Parse(Global.Consegnato);
                    txtConsegnato.Text = data2.ToString("dd/MM/yyyy");
                }
                catch { }



                switch (this.Tag)
                {
                    case 0:
                        txtMatricola.Enabled = false;
                        txtMatricola.Text = Global.Matricola;
                        txtRisoluzione.Text = Global.Risoluzione;
                        txtMin.Text = Global.Min;
                        txtMax.Text = Global.Max;
                        txtFornitore.Text = Global.Fornitore;
                        txtCostruttore.Text = Global.Costrurrore;
                        txtDescrizione.Text = Global.Descrizione;
                        txtDestinazione.Text = Global.Destinazione;
                        txtNsch.Text = Global.Nsch;
                        txtFdt.Text = Global.Fdt;

                        txtCausa.Text = Global.Causa;
                        txtNote.Text = Global.Note;
                        break;
                    case 1:
                        txtMatricola.Enabled = false;
                        txtMatricola.Text = Global.Matricola;
                        txtRisoluzione.Text = Global.Risoluzione;
                        txtMin.Text = Global.Min;
                        txtMax.Text = Global.Max;
                        txtFornitore.Text = Global.Uso;
                        txtCostruttore.Text = Global.Costrurrore;
                        txtDescrizione.Text = Global.Descrizione;
                        txtDestinazione.Text = Global.Destinazione;
                        txtNsch.Text = Global.Nsch;
                        txtFdt.Text = Global.Fdt;


                        txtCausa.Text = Global.Causa;
                        txtNote.Text = Global.Note;
                        break;
                    case 2:
                        txtMatricola.Enabled = false;
                        txtMatricola.Text = Global.Matricola;
                        txtRisoluzione.Text = Global.Risoluzione;
                        txtMin.Text = Global.Min;
                        txtMax.Text = Global.Max;
                        txtFornitore.Text = Global.Uso;
                        txtCostruttore.Text = Global.Costrurrore;
                        txtDescrizione.Text = Global.Descrizione;
                        txtDestinazione.Text = Global.Destinazione;
                        txtNsch.Text = Global.Nsch;
                        txtFdt.Text = Global.Fdt;
                        txtFdt.Text = Global.Fdt;

                        txtCausa.Text = Global.Causa;
                        txtNote.Text = Global.Note;
                        break;
                    case 3:
                        txtMatricola.Enabled = false;
                        txtMatricola.Text = Global.Matricola;
                        txtRisoluzione.Text = Global.Risoluzione;
                        txtMin.Text = Global.Min;
                        txtMax.Text = Global.Max;
                        txtUnita.Text = Global.Unita;
                        txtFornitore.Text = Global.Uso;
                        txtCostruttore.Text = Global.Costrurrore;
                        txtDescrizione.Text = Global.Descrizione;
                        txtDestinazione.Text = Global.Destinazione;
                        txtNsch.Text = Global.Nsch;
                        txtFdt.Text = Global.Fdt;

                        break;
                    case 4:
                        txtMatricola.Enabled = false;
                        txtMatricola.Text = Global.Matricola;
                        txtRisoluzione.Text = Global.Risoluzione;
                        txtUnita.Text = Global.Unita;
                        txtFornitore.Text = Global.Uso;
                        txtDestinazione.Text = Global.Destinazione;
                        txtNsch.Text = Global.Nsch;
                        txtFdt.Text = Global.Fdt;

                        txtCausa.Text = Global.Causa;
                        break;

                    default:
                        txtMatricola.Text = Global.Matricola;
                        txtFornitore.Text = Global.Descrizione;
                        txtDestinazione.Text = Global.Destinazione;
                        txtFdt.Text = Global.Fdt;

                        break;
                }
            }

        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Forma()
        {
            switch (this.Tag)
            {
                case 0:
                    lblRisoluzione.Enabled = true;
                    txtRisoluzione.Enabled = true;
                    lblMin.Enabled = true;
                    txtMin.Enabled = true;
                    lblMax.Enabled = true;
                    txtMax.Enabled = true;
                    lblUnita.Enabled = false;
                    txtUnita.Enabled = false;
                    lblCostruttore.Enabled = true;
                    txtCostruttore.Enabled = true;
                    lblDescrizione.Enabled = true;
                    txtDescrizione.Enabled = true;
                    lblNsch.Enabled = true;
                    txtNsch.Enabled = true;
                    lblConsegnato.Enabled = true;
                    txtConsegnato.Enabled = true;
                    lblScadenza.Enabled = true;
                    txtscadenza.Enabled = true;
                    lblCausa.Enabled = true;
                    txtCausa.Enabled = true;
                    lblNote.Enabled = true;
                    txtNote.Enabled = true;

                    lblCausa.Text = "Causa";
                    lblCausa.Location = new Point(352,287);
                    lblDestinazione.Text = "Destinazione";
                    lblDestinazione.Location = new Point(308, 43);
                    lblfornitore.Text = "Fornitore";
                    lblfornitore.Location = new Point(60, 246);

                    break;
                case 1:
                    lblRisoluzione.Enabled = true;
                    txtRisoluzione.Enabled = true;
                    lblMin.Enabled = true;
                    txtMin.Enabled = true;
                    lblMax.Enabled = true;
                    txtMax.Enabled = true;
                    lblUnita.Enabled = false;
                    txtUnita.Enabled = false;
                    lblCostruttore.Enabled = true;
                    txtCostruttore.Enabled = true;
                    lblDescrizione.Enabled = true;
                    txtDescrizione.Enabled = true;
                    lblNsch.Enabled = true;
                    txtNsch.Enabled = true;
                    lblConsegnato.Enabled = true;
                    txtConsegnato.Enabled = true;
                    lblScadenza.Enabled = true;
                    txtscadenza.Enabled = true;
                    lblCausa.Enabled = true;
                    txtCausa.Enabled = true;
                    lblNote.Enabled = true;
                    txtNote.Enabled = true;
                    lblCausa.Text = "Causa";
                    lblCausa.Location = new Point(352, 287);
                    lblDestinazione.Text = "Destinazione";
                    lblDestinazione.Location = new Point(308, 43);
                    lblfornitore.Text = "Uso";
                    lblfornitore.Location = new Point(92,246);
                    break;
                case 2:

                    lblRisoluzione.Enabled = true;
                    txtRisoluzione.Enabled = true;
                    lblMin.Enabled = true;
                    txtMin.Enabled = true;
                    lblMax.Enabled = true;
                    txtMax.Enabled = true;
                    lblUnita.Enabled = false;
                    txtUnita.Enabled = false;
                    lblCostruttore.Enabled = true;
                    txtCostruttore.Enabled = true;
                    lblDescrizione.Enabled = true;
                    txtDescrizione.Enabled = true;
                    lblNsch.Enabled = true;
                    txtNsch.Enabled = true;
                    lblConsegnato.Enabled = true;
                    txtConsegnato.Enabled = true;
                    lblScadenza.Enabled = true;
                    txtscadenza.Enabled = true;
                    lblCausa.Enabled = true;
                    txtCausa.Enabled = true;
                    lblNote.Enabled = true;
                    txtNote.Enabled = true;

                    lblCausa.Text = "Causa";
                    lblCausa.Location = new Point(352, 287);
                    lblDestinazione.Text = "Destinazione";
                    lblDestinazione.Location = new Point(308, 43);
                    lblfornitore.Text = "Uso";
                    lblfornitore.Location = new Point(92, 246);
                    break;
                case 3:

                    lblRisoluzione.Enabled = true;
                    txtRisoluzione.Enabled = true;
                    lblMin.Enabled = true;
                    txtMin.Enabled = true;
                    lblMax.Enabled = true;
                    txtMax.Enabled = true;
                    lblUnita.Enabled = true;
                    txtUnita.Enabled = true;
                    lblCostruttore.Enabled = true;
                    txtCostruttore.Enabled = true;
                    lblDescrizione.Enabled = true;
                    txtDescrizione.Enabled = true;
                    lblNsch.Enabled = true;
                    txtNsch.Enabled = true;
                    lblConsegnato.Enabled = false;
                    txtConsegnato.Enabled = false;
                    lblScadenza.Enabled = true;
                    txtscadenza.Enabled = true;
                    lblCausa.Enabled = false;
                    txtCausa.Enabled = false;
                    lblNote.Enabled = false;
                    txtNote.Enabled = false;

                    lblCausa.Text = "Causa";
                    lblCausa.Location = new Point(352, 287);
                    lblDestinazione.Text = "Destinazione";
                    lblDestinazione.Location = new Point(308, 43);
                    lblfornitore.Text = "Uso";
                    lblfornitore.Location = new Point(92, 246);
                    break;
                case 4:

                    lblRisoluzione.Enabled = true;
                    txtRisoluzione.Enabled = true;
                    lblMin.Enabled = false;
                    txtMin.Enabled = false;
                    lblMax.Enabled = false;
                    txtMax.Enabled = false;
                    lblUnita.Enabled = true;
                    txtUnita.Enabled = true;
                    lblCostruttore.Enabled = false;
                    txtCostruttore.Enabled = false;
                    lblDescrizione.Enabled = false;
                    txtDescrizione.Enabled = false;
                    lblNsch.Enabled = true;
                    txtNsch.Enabled = true;
                    lblConsegnato.Enabled = false;
                    txtConsegnato.Enabled = false;
                    lblScadenza.Enabled = false;
                    txtscadenza.Enabled = false;
                    lblCausa.Enabled = true;
                    txtCausa.Enabled = true;
                    lblNote.Enabled = false;
                    txtNote.Enabled = false;


                    lblCausa.Text = "Valore";
                    lblCausa.Location = new Point(352, 287);
                    lblDestinazione.Text = "Destinazione";
                    lblDestinazione.Location = new Point(308, 43);
                    lblfornitore.Text = "Uso";
                    lblfornitore.Location = new Point(92,246);
                    break;

                default:

                    lblRisoluzione.Enabled = false;
                    txtRisoluzione.Enabled = false;
                    lblMin.Enabled = false;
                    txtMin.Enabled = false;
                    lblMax.Enabled = false;
                    txtMax.Enabled = false;
                    lblUnita.Enabled = false;
                    txtUnita.Enabled = false;
                    lblCostruttore.Enabled = false;
                    txtCostruttore.Enabled = false;
                    lblDescrizione.Enabled = false;
                    txtDescrizione.Enabled = false;
                    lblNsch.Enabled = false;
                    txtNsch.Enabled = false;
                    lblConsegnato.Enabled = false;
                    txtConsegnato.Enabled = false;
                    lblScadenza.Enabled = false;
                    txtscadenza.Enabled = false;
                    lblCausa.Enabled = false;
                    txtCausa.Enabled = false;
                    lblNote.Enabled = false;
                    txtNote.Enabled = false;

                    txtFdt.Text = "60";
                    txtscadenza.Text = "";
                    lblCausa.Text = "Causa";
                    lblCausa.Location = new Point(352, 287);
                    lblDestinazione.Text = "Reparto";
                    lblDestinazione.Location = new Point(308, 43);
                    lblfornitore.Text = "Strumento";
                    lblfornitore.Location = new Point(51,246);
                    break;
            }
        }


        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Global.Matricola = txtMatricola.Text;
            Global.Risoluzione = txtRisoluzione.Text;
            Global.Min = txtMin.Text;
            Global.Max = txtMax.Text;
            Global.Fornitore = txtFornitore.Text;
            Global.Uso = txtFornitore.Text;
            Global.Costrurrore = txtCostruttore.Text;
            Global.Fdt = txtFdt.Text;
            Global.Descrizione = txtDescrizione.Text;
            Global.Unita = txtUnita.Text;
            Global.Consegnato = txtConsegnato.Text;
            Global.UltTaratura = txtUltima.Text;
            Global.Nsch = txtNsch.Text;
            Global.Scadenza = txtscadenza.Text;
            Global.Destinazione = txtDestinazione.Text;
            Global.Note = txtNote.Text;
            Global.Causa = txtCausa.Text;

            Controllo();
            switch (this.Tag)
            {
                case 0:
                    if (Global.Completa==true)
                    {


                        if (this.Text == "Inserisci")
                        {



                            this.foglio1TableAdapter.InsertQuery(Int16.Parse(Global.Matricola), Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max),
                                                                           Global.Fornitore, Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                               int.Parse(Global.Fdt), Global.Causa, Global.Note, Global.vita);

                            if (Global.Consegnato.ToString() != "")
                            {
                                this.foglio1TableAdapter.UpdateConsegnato(DateTime.Parse(Global.Consegnato), Int16.Parse(Global.Matricola));
                            }
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio1TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio1TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }

                            var result = MessageBox.Show("Vuoi inserire altri strumenti ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Cancella();


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
                        MessageBox.Show("Ci sono alcune caselle vuote", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;
                case 1:
                    if (Global.Completa == true)
                    {



                        if (this.Text == "Inserisci")
                        {


                            this.foglio2TableAdapter.InsertQuery(Int16.Parse(Global.Matricola), Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max), Global.Uso,
                               Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                           int.Parse(Global.Fdt), Global.Causa, Global.Note);

                            if (Global.Consegnato.ToString() != "")
                            {
                                this.foglio2TableAdapter.UpdateConsegnato(DateTime.Parse(Global.Consegnato), Int16.Parse(Global.Matricola));
                            }
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio2TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio2TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }




                            var result = MessageBox.Show("Vuoi inserire altri strumenti ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Cancella();

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
                        MessageBox.Show("Ci sono alcune caselle vuote", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;
                case 2:

                    if (Global.Completa == true)
                    {




                        if (this.Text == "Inserisci")
                        {
                            this.foglio3TableAdapter.InsertQuery(Int16.Parse(Global.Matricola), Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max), Global.Uso,
                              Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                          int.Parse(Global.Fdt), Global.Causa, Global.Note);


                            if (Global.Consegnato.ToString() != "")
                            {
                                this.foglio3TableAdapter.UpdateConsegnato(DateTime.Parse(Global.Consegnato), Int16.Parse(Global.Matricola));
                            }
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio3TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio3TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }



                            var result = MessageBox.Show("Vuoi inserire altri strumenti ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Cancella();

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
                        MessageBox.Show("Ci sono alcune caselle vuote", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    break;
                case 3:
                    if (Global.Completa == true)
                    {





                        if (this.Text == "Inserisci")
                        {
                            this.foglio8TableAdapter.InsertQuery(Int16.Parse(Global.Matricola), Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max), Global.Uso,
                              Global.Unita, Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                          int.Parse(Global.Fdt));


                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio8TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio8TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }



                            var result = MessageBox.Show("Vuoi inserire altri strumenti ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Cancella();

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
                        MessageBox.Show("Ci sono alcune caselle vuote", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }


                    break;
                case 4:
                    if (Global.Completa == true)


                    {


                        if (this.Text == "Inserisci")
                        {
                            this.foglio6TableAdapter.InsertQuery(Int16.Parse(Global.Matricola), Decimal.Parse(Global.Risoluzione), Global.Unita, Global.Uso,
                               Global.Destinazione, Global.Nsch, int.Parse(Global.Fdt), decimal.Parse(Global.Causa));

                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio6TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }



                            var result = MessageBox.Show("Vuoi inserire altri strumenti ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Cancella();

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
                        MessageBox.Show("Ci sono alcune caselle vuote", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    break;
                default:

                    if (Global.Completa == true)


                    {


                        if (this.Text == "Inserisci")
                        {
                            this.foglio7TableAdapter.InsertQuery(Global.Matricola, Global.Uso, Global.Destinazione, Int16.Parse(Global.Fdt), DateTime.Parse(Global.UltTaratura));
                            var result = MessageBox.Show("Vuoi inserire altri strumenti ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Cancella();

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
                        MessageBox.Show("Ci sono alcune caselle vuote", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }





                    break;
            }





        }
        private void Cancella()
        {
            txtMatricola.Clear();
            txtRisoluzione.Clear();
            txtMin.Clear();
            txtMax.Clear();
            txtFornitore.Clear();
            txtCostruttore.Clear();
            txtFdt.Clear();
            txtDescrizione.Clear();
            txtNsch.Clear();
            txtDestinazione.Clear();
            txtNote.Clear();
            txtCausa.Clear();
            txtUnita.Clear();
            txtUnita.Clear();
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio8'. È possibile spostarla o rimuoverla se necessario.
            this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio7'. È possibile spostarla o rimuoverla se necessario.
            this.foglio7TableAdapter.Fill(this.database1DataSet.Foglio7);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio6'. È possibile spostarla o rimuoverla se necessario.
            this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio3'. È possibile spostarla o rimuoverla se necessario.
            this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio2'. È possibile spostarla o rimuoverla se necessario.
            this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio1'. È possibile spostarla o rimuoverla se necessario.
            this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);



        }
        private void txtMatricola_KeyDown(object sender, KeyEventArgs e)
        {
            switch (this.Tag)
            {
                case 5:
                    txtMatricola.MaxLength = 20;
                    break;

                default:
                    txtMatricola.MaxLength = 4;
                    {
                        if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete)
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
                    break;
            }
        }

        private void txtRisoluzione_KeyDown(object sender, KeyEventArgs e)
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

        private void txtMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete & e.KeyCode != Keys.Oemcomma)
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

        private void txtMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete & e.KeyCode != Keys.Oemcomma)
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

        private void txtFdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete)
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

        private void txtNsch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete)
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



        private void txtConsegnato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete
                & e.KeyCode != Keys.OemBackslash)
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

        private void txtUltima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete
                & e.KeyCode != Keys.OemBackslash)
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

        private void txtscadenza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back & e.KeyCode != Keys.Delete
                & e.KeyCode != Keys.OemBackslash)
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

        private void txtUltima_Leave(object sender, EventArgs e)
        {
            try
            {
                int data2 = Int16.Parse(txtFdt.Text);
                DateTime data6 = DateTime.Parse(txtUltima.Text);
                DateTime data0 = data6.AddMonths(data2);
                txtscadenza.Text = data0.ToString("dd/MM/yyyy");
            }
            catch { }
        }

        private void txtFdt_Leave(object sender, EventArgs e)
        {
            if (txtFdt.Text != "" & txtUltima.Text != "")
            {
                int data2 = Int16.Parse(txtFdt.Text);
                DateTime data6 = DateTime.Parse(txtUltima.Text);
                DateTime data0 = data6.AddMonths(data2);
                txtscadenza.Text = data0.ToString("dd/MM/yyyy");
            }
        }

        private void txtMatricola_KeyUp(object sender, KeyEventArgs e)
        {
            switch (this.Tag)
            {
                case 0:
                    try
                    {
                        int convertitore = Int16.Parse(txtMatricola.Text.ToString());
                        foglio1TableAdapter.FillByMatricola(this.database1DataSet.Foglio1, convertitore);

                    }
                    catch (Exception)
                    {

                        this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);
                    }
                    break;
                case 1:
                    try
                    {
                        int convertitore1 = Int16.Parse(txtMatricola.Text.ToString());
                        foglio2TableAdapter.FillByMatricola(this.database1DataSet.Foglio2, convertitore1);

                    }
                    catch (Exception)
                    {

                        this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
                    }
                    break;

                case 2:
                    try
                    {
                        int convertitore2 = Int16.Parse(txtMatricola.Text.ToString());
                        foglio3TableAdapter.FillByMatricola(this.database1DataSet.Foglio3, convertitore2);

                    }
                    catch (Exception)
                    {

                        this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
                    }
                    break;
                case 3:
                    try
                    {
                        int convertitore3 = Int16.Parse(txtMatricola.Text.ToString());
                        foglio8TableAdapter.FillByMatricola(this.database1DataSet.Foglio8, convertitore3);

                    }
                    catch (Exception)
                    {

                        this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
                    }
                    break;
                case 4:
                    try
                    {
                        int convertitore4 = Int16.Parse(txtMatricola.Text.ToString());
                        foglio6TableAdapter.FillByMatricola(this.database1DataSet.Foglio6, convertitore4);

                    }
                    catch (Exception)
                    {

                        this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
                    }
                    break;



                default:
                    break;
            }

        }

        private void txtMatricola_Leave(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case 0:


                    int i = Foglio1dataGridView.RowCount;
                    if (i > 0)
                    {
                        MessageBox.Show("Matricola gia esistente o nessuna matricola inserita ", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);

                    }
                    try
                    {
                        if (Int16.Parse(txtMatricola.Text) < 1000 || Int16.Parse(txtMatricola.Text) > 1999)
                        {
                            MessageBox.Show("Valore Matricola fuori scala", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatricola.Clear();
                            txtMatricola.Focus();
                            this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);

                        }
                    }
                    catch (Exception)
                    {


                    }

                    break;
                case 1:

                    int i1 = Foglio2dataGridView.RowCount;
                    if (i1 > 0)
                    {
                        MessageBox.Show("Matricola gia esistente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);

                    }
                    if (Int16.Parse(txtMatricola.Text) < 2000 || Int16.Parse(txtMatricola.Text) > 2999)
                    {
                        MessageBox.Show("Valore Matricola fuori scala", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);

                    }
                    break;

                case 2:

                    int i2 = Foglio3dataGridView.RowCount;
                    if (i2 > 0)
                    {
                        MessageBox.Show("Matricola gia esistente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);

                    }
                    if (Int16.Parse(txtMatricola.Text) < 3000 || Int16.Parse(txtMatricola.Text) > 3999)
                    {
                        MessageBox.Show("Valore Matricola fuori scala", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);

                    }
                    break;
                case 3:

                    int i3 = Foglio8dataGridView.RowCount;
                    if (i3 > 0)
                    {
                        MessageBox.Show("Matricola gia esistente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);

                    }
                    if (Int16.Parse(txtMatricola.Text) < 4000 || Int16.Parse(txtMatricola.Text) > 4999)
                    {
                        MessageBox.Show("Valore Matricola fuori scala", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);

                    }
                    break;
                case 4:

                    int i4 = Foglio6dataGridView.RowCount;
                    if (i4 > 0)
                    {
                        MessageBox.Show("Matricola gia esistente", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);

                    }
                    if (Int16.Parse(txtMatricola.Text) < 6000 || Int16.Parse(txtMatricola.Text) > 6999)
                    {
                        MessageBox.Show("Valore Matricola fuori scala", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatricola.Clear();
                        txtMatricola.Focus();
                        this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);

                    }
                    break;
                default:
                    break;
            }

        }
        private void Controllo()
        {

            Global.Completa = true;
            switch (this.Tag)
            {
                case 0:
                    if (txtMatricola.Text == "")
                    {
                        txtMatricola.BackColor = Color.Yellow;
                        txtMatricola.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMatricola.BackColor = Color.White;
                    }
                    if (txtRisoluzione.Text == "")
                    {
                        txtRisoluzione.BackColor = Color.Yellow;
                        txtRisoluzione.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtRisoluzione.BackColor = Color.White;
                    }
                    if (txtMin.Text == "")
                    {
                        txtMin.BackColor = Color.Yellow;
                        txtMin.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMin.BackColor = Color.White;
                    }
                    if (txtMax.Text == "")
                    {
                        txtMax.BackColor = Color.Yellow;
                        txtMax.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMax.BackColor = Color.White;
                    }
                    if (txtFdt.Text == "")
                    {
                        txtFdt.BackColor = Color.Yellow;
                        txtFdt.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtFdt.BackColor = Color.White;
                    }



                    break;
                case 1:

                    if (txtMatricola.Text == "")
                    {
                        txtMatricola.BackColor = Color.Yellow;
                        txtMatricola.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMatricola.BackColor = Color.White;
                    }
                    if (txtRisoluzione.Text == "")
                    {
                        txtRisoluzione.BackColor = Color.Yellow;
                        txtRisoluzione.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtRisoluzione.BackColor = Color.White;
                    }
                    if (txtMin.Text == "")
                    {
                        txtMin.BackColor = Color.Yellow;
                        txtMin.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMin.BackColor = Color.White;
                    }
                    if (txtMax.Text == "")
                    {
                        txtMax.BackColor = Color.Yellow;
                        txtMax.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMax.BackColor = Color.White;
                    }
                    if (txtFdt.Text == "")
                    {
                        txtFdt.BackColor = Color.Yellow;
                        txtFdt.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtFdt.BackColor = Color.White;
                    }




                    break;
                case 2:
                    if (txtMatricola.Text == "")
                    {
                        txtMatricola.BackColor = Color.Yellow;
                        txtMatricola.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMatricola.BackColor = Color.White;
                    }
                    if (txtRisoluzione.Text == "")
                    {
                        txtRisoluzione.BackColor = Color.Yellow;
                        txtRisoluzione.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtRisoluzione.BackColor = Color.White;
                    }
                    if (txtMin.Text == "")
                    {
                        txtMin.BackColor = Color.Yellow;
                        txtMin.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMin.BackColor = Color.White;
                    }
                    if (txtMax.Text == "")
                    {
                        txtMax.BackColor = Color.Yellow;
                        txtMax.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMax.BackColor = Color.White;
                    }
                    if (txtFdt.Text == "")
                    {
                        txtFdt.BackColor = Color.Yellow;
                        txtFdt.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtFdt.BackColor = Color.White;
                    }
                    break;
                case 3:
                    if (txtMatricola.Text == "")
                    {
                        txtMatricola.BackColor = Color.Yellow;
                        txtMatricola.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMatricola.BackColor = Color.White;
                    }
                    if (txtRisoluzione.Text == "")
                    {
                        txtRisoluzione.BackColor = Color.Yellow;
                        txtRisoluzione.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtRisoluzione.BackColor = Color.White;
                    }

                    if (txtMin.Text == "")
                    {
                        txtMin.BackColor = Color.Yellow;
                        txtMin.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMin.BackColor = Color.White;
                    }
                    if (txtMax.Text == "")
                    {
                        txtMax.BackColor = Color.Yellow;
                        txtMax.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMax.BackColor = Color.White;
                    }
                    if (txtFdt.Text == "")
                    {
                        txtFdt.BackColor = Color.Yellow;
                        txtFdt.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtFdt.BackColor = Color.White;
                    }
                    break;

                case 4:
                    if (txtMatricola.Text == "")
                    {

                        txtMatricola.BackColor = Color.Yellow;
                        txtMatricola.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMatricola.BackColor = Color.White;
                    }
                    if (txtRisoluzione.Text == "")
                    {
                        txtRisoluzione.BackColor = Color.Yellow;
                        txtRisoluzione.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtRisoluzione.BackColor = Color.White;
                    }
                    if (txtFdt.Text == "")
                    {

                        txtFdt.BackColor = Color.Yellow;
                        txtFdt.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtFdt.BackColor = Color.White;
                    }

                    if (txtCausa.Text == "")
                    {
                        txtCausa.BackColor = Color.Yellow;
                        txtCausa.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtCausa.BackColor = Color.White;
                    }
                    break;

                default:
                    if (txtMatricola.Text == "")
                    {
                        txtMatricola.BackColor = Color.Yellow;
                        txtMatricola.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtMatricola.BackColor = Color.White;
                    }

                    if (txtFdt.Text == "")
                    {
                        txtFdt.BackColor = Color.Yellow;
                        txtFdt.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtFdt.BackColor = Color.White;
                    }
                    if (txtUltima.Text == "")
                    {
                        txtUltima.BackColor = Color.Yellow;
                        txtUltima.Focus();
                        Global.Completa = false;
                        break;
                    }
                    else
                    {
                        txtUltima.BackColor = Color.White;
                    }
                    break;
            }

        }

      
    }
        
    
}
