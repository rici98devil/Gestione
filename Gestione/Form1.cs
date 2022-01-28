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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }




        private void esciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'calibri_LisciDataSet.Calibr_Lisci'. È possibile spostarla o rimuoverla se necessario.
            this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio7'. È possibile spostarla o rimuoverla se necessario.
            this.foglio7TableAdapter.Fill(this.database1DataSet.Foglio7);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio6'. È possibile spostarla o rimuoverla se necessario.
            this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio8'. È possibile spostarla o rimuoverla se necessario.
            this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio3'. È possibile spostarla o rimuoverla se necessario.
            this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio2'. È possibile spostarla o rimuoverla se necessario.
            this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.Foglio1'. È possibile spostarla o rimuoverla se necessario.
            this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);



            // TODO: questa riga di codice carica i dati nella tabella 'gestione_CalibriDataSet.GestioneCalibri'. È possibile spostarla o rimuoverla se necessario.
            this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
            cancellaFiltroToolStripMenuItem.Visible = false;
            passwordToolStripMenuItem.Visible = false;
            
            calibriLisciToolStripMenuItem.Visible = false;
            // se la tabella contiene dati
            int v = gestione_CalibriDataSet.GestioneCalibri.Count;
            if (gestione_CalibriDataSet.GestioneCalibri.Count > 0)
            {

                gestioneCalibriDataGridView.Visible = true;
                scadutiToolStripMenuItem.Visible = true;
                vitaInScadenzaToolStripMenuItem.Visible = true;
                lblistruzioni.Text = "L'archivio  contiene i dati di " + v.ToString() + " calibri";

                DateTime date3 = DateTime.Today;
                for (int i = 0; i < v - 1; i++)
                {

                    if (gestioneCalibriDataGridView.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        DateTime data6 = DateTime.Parse(gestioneCalibriDataGridView.Rows[i].Cells[3].Value.ToString());
                        TimeSpan data5 = date3.Subtract(data6);
                        Double data7 = data5.TotalDays;
                        int risp = Int32.Parse(gestioneCalibriDataGridView.Rows[i].Cells[4].Value.ToString());
                        risp = risp - Int32.Parse(data7.ToString());
                        gestioneCalibriDataGridView.Rows[i].Cells[4].Value = risp;


                    }
                }
                Colore();

            }

        }
        private void Colore()
        {
            int v1 = gestione_CalibriDataSet.GestioneCalibri.Count;
            // in giallo matricole < 1000 e azzurro >=5000 vita da 1 a 10,rosso <1
            string pp;
            string pvita;
            for (int i = 0; i < v1; i++)
            {
                pp = gestioneCalibriDataGridView.Rows[i].Cells[0].Value.ToString();
                pvita = gestioneCalibriDataGridView.Rows[i].Cells[4].Value.ToString();
                if (pp != "")
                {
                    int contenuto = Int32.Parse(pp);
                    int vita = Int32.Parse(pvita);

                    if (vita >= 1 & vita <= 10)
                    {
                        gestioneCalibriDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Yellow;

                    }

                    if (vita < 1)
                    {
                        gestioneCalibriDataGridView.Rows[i].Cells[4].Style.BackColor = Color.Red;

                    }

                    if (contenuto < 5001)
                    {
                        gestioneCalibriDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        gestioneCalibriDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        gestioneCalibriDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Azure;
                        gestioneCalibriDataGridView.Rows[i].Cells[1].Style.BackColor = Color.Azure;
                    }

                }
            }
        }


        private void gestioneCalibriDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Colore();
        }



        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                frmInserimenti frmInserimenti = new frmInserimenti();
                frmInserimenti.Text = "Modifica";

                Global.Matricola = gestioneCalibriDataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                Global.Descrizione = gestioneCalibriDataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                Global.Tipo = gestioneCalibriDataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                Global.VitaIniziale = gestioneCalibriDataGridView.Rows[Global.riga].Cells[7].Value.ToString();


                frmInserimenti.ShowDialog();
                if (Global.salvataggio)
                {
                    this.gestioneCalibriTableAdapter.UpdateQuery(Global.Descrizione, Global.Tipo, Int16.Parse(Global.VitaIniziale), Int16.Parse(Global.Matricola));
                    this.gestioneCalibriTableAdapter.UpdateVita(Int16.Parse(Global.VitaIniziale), Int16.Parse(Global.Matricola));
                    this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                    Colore();

                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                frmVita frmVita = new frmVita();
                frmVita.Text = "Modifica";
                frmVita.Tag = tabControl2.Tag;

                switch (tabControl2.Tag)
                {
                    case 0:
                        Global.Matricola = foglio1DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        Global.Risoluzione = foglio1DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        Global.Min = foglio1DataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                        Global.Max = foglio1DataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                        Global.Fornitore = foglio1DataGridView.Rows[Global.riga].Cells[4].Value.ToString();
                        Global.Costrurrore = foglio1DataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                        Global.Descrizione = foglio1DataGridView.Rows[Global.riga].Cells[6].Value.ToString();
                        Global.Destinazione = foglio1DataGridView.Rows[Global.riga].Cells[7].Value.ToString();
                        Global.Nsch = foglio1DataGridView.Rows[Global.riga].Cells[8].Value.ToString();
                        Global.Fdt = foglio1DataGridView.Rows[Global.riga].Cells[9].Value.ToString();
                        Global.Consegnato = foglio1DataGridView.Rows[Global.riga].Cells[10].Value.ToString();
                        Global.UltTaratura = foglio1DataGridView.Rows[Global.riga].Cells[11].Value.ToString();
                        Global.Scadenza = foglio1DataGridView.Rows[Global.riga].Cells[12].Value.ToString();
                        Global.Causa = foglio1DataGridView.Rows[Global.riga].Cells[13].Value.ToString();
                        Global.Note = foglio1DataGridView.Rows[Global.riga].Cells[14].Value.ToString();
                        break;
                    case 1:
                        Global.Matricola = foglio2DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        Global.Risoluzione = foglio2DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        Global.Min = foglio2DataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                        Global.Max = foglio2DataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                        Global.Uso = foglio2DataGridView.Rows[Global.riga].Cells[4].Value.ToString();
                        Global.Costrurrore = foglio2DataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                        Global.Descrizione = foglio2DataGridView.Rows[Global.riga].Cells[6].Value.ToString();
                        Global.Destinazione = foglio2DataGridView.Rows[Global.riga].Cells[7].Value.ToString();
                        Global.Nsch = foglio2DataGridView.Rows[Global.riga].Cells[8].Value.ToString();
                        Global.Fdt = foglio2DataGridView.Rows[Global.riga].Cells[9].Value.ToString();
                        Global.Consegnato = foglio2DataGridView.Rows[Global.riga].Cells[10].Value.ToString();
                        Global.UltTaratura = foglio2DataGridView.Rows[Global.riga].Cells[11].Value.ToString();
                        Global.Scadenza = foglio2DataGridView.Rows[Global.riga].Cells[12].Value.ToString();
                        Global.Causa = foglio2DataGridView.Rows[Global.riga].Cells[13].Value.ToString();
                        Global.Note = foglio2DataGridView.Rows[Global.riga].Cells[14].Value.ToString();
                        break;
                    case 2:
                        Global.Matricola = foglio3DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        Global.Risoluzione = foglio3DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        Global.Min = foglio3DataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                        Global.Max = foglio3DataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                        Global.Uso = foglio3DataGridView.Rows[Global.riga].Cells[4].Value.ToString();
                        Global.Costrurrore = foglio3DataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                        Global.Descrizione = foglio3DataGridView.Rows[Global.riga].Cells[6].Value.ToString();
                        Global.Destinazione = foglio3DataGridView.Rows[Global.riga].Cells[7].Value.ToString();
                        Global.Nsch = foglio3DataGridView.Rows[Global.riga].Cells[8].Value.ToString();
                        Global.Fdt = foglio3DataGridView.Rows[Global.riga].Cells[9].Value.ToString();
                        Global.Consegnato = foglio3DataGridView.Rows[Global.riga].Cells[10].Value.ToString();
                        Global.UltTaratura = foglio3DataGridView.Rows[Global.riga].Cells[11].Value.ToString();
                        Global.Scadenza = foglio3DataGridView.Rows[Global.riga].Cells[12].Value.ToString();
                        Global.Causa = foglio3DataGridView.Rows[Global.riga].Cells[13].Value.ToString();
                        Global.Note = foglio3DataGridView.Rows[Global.riga].Cells[14].Value.ToString();
                        break;
                    case 3:
                        Global.Matricola = foglio8DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        Global.Risoluzione = foglio8DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        Global.Min = foglio8DataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                        Global.Max = foglio8DataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                        Global.Uso = foglio8DataGridView.Rows[Global.riga].Cells[4].Value.ToString();
                        Global.Unita = foglio8DataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                        Global.Costrurrore = foglio8DataGridView.Rows[Global.riga].Cells[6].Value.ToString();
                        Global.Descrizione = foglio8DataGridView.Rows[Global.riga].Cells[7].Value.ToString();
                        Global.Destinazione = foglio8DataGridView.Rows[Global.riga].Cells[8].Value.ToString();
                        Global.Nsch = foglio8DataGridView.Rows[Global.riga].Cells[9].Value.ToString();
                        Global.Fdt = foglio8DataGridView.Rows[Global.riga].Cells[10].Value.ToString();
                        Global.UltTaratura = foglio8DataGridView.Rows[Global.riga].Cells[11].Value.ToString();
                        Global.Scadenza = foglio8DataGridView.Rows[Global.riga].Cells[12].Value.ToString();

                        break;
                    case 4:
                        Global.Matricola = foglio6DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        Global.Risoluzione = foglio6DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        Global.Unita = foglio6DataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                        Global.Uso = foglio6DataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                        Global.Destinazione = foglio6DataGridView.Rows[Global.riga].Cells[4].Value.ToString();
                        Global.Nsch = foglio6DataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                        Global.Fdt = foglio6DataGridView.Rows[Global.riga].Cells[6].Value.ToString();
                        Global.UltTaratura = foglio6DataGridView.Rows[Global.riga].Cells[7].Value.ToString();
                        Global.Causa = foglio6DataGridView.Rows[Global.riga].Cells[8].Value.ToString();
                        break;

                    default:
                        Global.Id = foglio7DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        Global.Matricola = foglio7DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        Global.Descrizione = foglio7DataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                        Global.Destinazione = foglio7DataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                        Global.Fdt = foglio7DataGridView.Rows[Global.riga].Cells[4].Value.ToString();
                        Global.UltTaratura = foglio7DataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                        break;

                }

                frmVita.ShowDialog();


                if (Global.Completa == true)
                {
                    switch (tabControl2.Tag)
                    {
                        case 0:

                            this.foglio1TableAdapter.UpdateQuery(Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max),
                                                                      Global.Fornitore, Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                          int.Parse(Global.Fdt), Global.Causa, Global.Note, Global.vita, Int16.Parse(Global.Matricola));

                            if (Global.Consegnato.ToString() != "")
                            {
                                this.foglio1TableAdapter.UpdateConsegnato(DateTime.Parse(Global.Consegnato), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio1TableAdapter.UpdateConsegnato(null, Int16.Parse(Global.Matricola));
                            }
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio1TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio1TableAdapter.UpdateUltima(null, Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio1TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio1TableAdapter.UpdateScadenza(null, Int16.Parse(Global.Matricola));
                            }


                            this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);
                            break;
                        case 1:

                            this.foglio2TableAdapter.UpdateQuery(Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max),
                                                                    Global.Uso, Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                        Int16.Parse(Global.Fdt), Global.Causa, Global.Note, Int16.Parse(Global.Matricola));

                            if (Global.Consegnato.ToString() != "")
                            {
                                this.foglio2TableAdapter.UpdateConsegnato(DateTime.Parse(Global.Consegnato), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio2TableAdapter.UpdateConsegnato(null, Int16.Parse(Global.Matricola));
                            }
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio2TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio2TableAdapter.UpdateUltima(null, Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio2TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio2TableAdapter.UpdateScadenza(null, Int16.Parse(Global.Matricola));
                            }

                            this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
                            break;
                        case 2:

                            this.foglio3TableAdapter.UpdateQuery(Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max),
                                                                  Global.Uso, Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                      Int16.Parse(Global.Fdt), Global.Causa, Global.Note, Int16.Parse(Global.Matricola));

                            if (Global.Consegnato.ToString() != "")
                            {
                                this.foglio3TableAdapter.UpdateConsegnato(DateTime.Parse(Global.Consegnato), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio3TableAdapter.UpdateConsegnato(null, Int16.Parse(Global.Matricola));
                            }
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio3TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio3TableAdapter.UpdateUltima(null, Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio3TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }
                            else
                            {
                                this.foglio3TableAdapter.UpdateScadenza(null, Int16.Parse(Global.Matricola));
                            }
                            this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
                            break;
                        case 3:
                            this.foglio8TableAdapter.UpdateQuery(Decimal.Parse(Global.Risoluzione), Decimal.Parse(Global.Min), Decimal.Parse(Global.Max),
                                                                  Global.Uso, Global.Unita, Global.Costrurrore, Global.Descrizione, Global.Destinazione, Global.Nsch,
                                                      Int16.Parse(Global.Fdt), Int16.Parse(Global.Matricola));

                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio8TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }
                            if (Global.Scadenza.ToString() != "")
                            {
                                this.foglio8TableAdapter.UpdateScadenza(DateTime.Parse(Global.Scadenza), Int16.Parse(Global.Matricola));
                            }
                            this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
                            break;
                        case 4:

                            this.foglio6TableAdapter.UpdateQuery(Decimal.Parse(Global.Risoluzione), Global.Unita, Global.Uso, Global.Destinazione, Global.Nsch,
                                                      Int16.Parse(Global.Fdt), Decimal.Parse(Global.Causa), Int16.Parse(Global.Matricola));

                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio6TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Matricola));
                            }

                            this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
                            break;

                        default:
                            this.foglio7TableAdapter.UpdateQuery(Global.Matricola, Global.Fornitore, Global.Destinazione,
                                Decimal.Parse(Global.Fdt), Int16.Parse(Global.Id));
                            if (Global.UltTaratura.ToString() != "")
                            {
                                this.foglio7TableAdapter.UpdateUltima(DateTime.Parse(Global.UltTaratura), Int16.Parse(Global.Id));
                            }


                            this.foglio7TableAdapter.Fill(this.database1DataSet.Foglio7);
                            break;

                    }

                }


            }
            if (tabControl1.SelectedIndex == 2)
            {
                Form3 form3 = new Form3();
                form3.Text = "Modifica";

                Global.Matricola = calibr_LisciDataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                Global.Min = calibr_LisciDataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                Global.Max = calibr_LisciDataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                Global.Risoluzione = calibr_LisciDataGridView.Rows[Global.riga].Cells[3].Value.ToString();
                Global.Varie= calibr_LisciDataGridView.Rows[Global.riga].Cells[5].Value.ToString();
                Global.Uso = calibr_LisciDataGridView.Rows[Global.riga].Cells[6].Value.ToString();
                Global.Id= calibr_LisciDataGridView.Rows[Global.riga].Cells[7].Value.ToString();


                form3.ShowDialog();
                if (Global.salvataggio)
                {
                    this.calibr_LisciTableAdapter.UpdateQuery(Global.Matricola,Global.Min, Global.Max, Decimal.Parse(Global.Risoluzione),Global.Varie,Global.Uso, Int16.Parse(Global.Id));
                    this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                }




            }
            //end modifica
        }

        private void inserisciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                frmInserimenti frmInserimenti = new frmInserimenti();
                frmInserimenti.Text = "Inserisci";
                frmInserimenti.ShowDialog();
                if (Global.salvataggio)
                {

                    this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                    Colore();

                }

            }
            if (tabControl1.SelectedIndex == 1)
            {

                frmVita frmVita = new frmVita();
                frmVita.Text = "Inserisci";
                frmVita.Tag = tabControl2.Tag;
                frmVita.ShowDialog();
                switch (tabControl2.Tag)
                {
                    case 0:
                        this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);
                        break;
                    case 1:
                        this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
                        break;
                    case 2:
                        this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
                        break;
                    case 3:
                        this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
                        break;
                    case 4:
                        this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
                        break;

                    default:

                        this.foglio7TableAdapter.Fill(this.database1DataSet.Foglio7);
                        break;

                }



            }
            if (tabControl1.SelectedIndex == 2)
            {
                Form3 form3 = new Form3();
                form3.Text = "Inserisci";
                form3.ShowDialog();
                if (Global.salvataggio)
                {

                    this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);

                }



            }


        }

        private void cancellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {



                Global.Matricola = gestioneCalibriDataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                Global.Descrizione = gestioneCalibriDataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                Global.Tipo = gestioneCalibriDataGridView.Rows[Global.riga].Cells[2].Value.ToString();
                Global.VitaIniziale = gestioneCalibriDataGridView.Rows[Global.riga].Cells[7].Value.ToString();

                for (int i = 0; i < 8; i++)
                {
                    gestioneCalibriDataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                }
              

                var result = MessageBox.Show("Vuoi cancellare il  calibro con matricola " + Global.Matricola + " ?", "Attenzione",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    this.gestioneCalibriTableAdapter.CancellaDati(Int16.Parse(Global.Matricola));
                    this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                    Colore();



                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        gestioneCalibriDataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                        Colore();
                    }
                }

            }

            if (tabControl1.SelectedIndex == 1)
            {




                switch (tabControl2.Tag)
                {
                    case 0:
                        Global.Matricola = foglio1DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        for (int i = 0; i < 16; i++)
                        {
                            foglio1DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                        }
                        break;
                    case 1:
                        Global.Matricola = foglio2DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        for (int i = 0; i < 15; i++)
                        {
                            foglio2DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        Global.Matricola = foglio3DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        for (int i = 0; i < 15; i++)
                        {
                            foglio3DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        Global.Matricola = foglio8DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        for (int i = 0; i < 13; i++)
                        {
                            foglio8DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        Global.Matricola = foglio6DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                        for (int i = 0; i < 9; i++)
                        {
                            foglio6DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                        }
                        break;
                    default:
                        Global.Matricola = foglio7DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
                        for (int i = 0; i < 6; i++)
                        {
                            foglio7DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                        }
                        break;
                }

                var result = MessageBox.Show("Vuoi cancellare il  calibro con matricola " + Global.Matricola + " ?", "Attenzione",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    switch (tabControl2.Tag)
                    {
                        case 0:
                            foglio1TableAdapter.DeleteQuery(Int16.Parse(Global.Matricola));
                            this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);
                            break;
                        case 1:
                            foglio2TableAdapter.DeleteQuery(Int16.Parse(Global.Matricola));
                            this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
                            break;
                        case 2:
                            foglio3TableAdapter.DeleteQuery(Int16.Parse(Global.Matricola));
                            this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
                            break;
                        case 3:
                            foglio8TableAdapter.DeleteQuery(Int16.Parse(Global.Matricola));
                            this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
                            break;
                        case 4:
                            foglio6TableAdapter.DeleteQuery(Int16.Parse(Global.Matricola));
                            this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
                            break;
                        default:
                            Global.Matricola = foglio7DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                            foglio7TableAdapter.DeleteQuery(Int16.Parse(Global.Matricola));
                            this.foglio7TableAdapter.Fill(this.database1DataSet.Foglio7);
                            break;
                    }



                }
                else
                {
                    switch (tabControl2.Tag)
                    {
                        case 0:
                         
                            for (int i = 0; i < 16; i++)
                            {
                                foglio1DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                            }
                            break;
                        case 1:
                           
                            for (int i = 0; i < 15; i++)
                            {
                                foglio2DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                            }
                            break;
                        case 2:
                         
                            for (int i = 0; i < 15; i++)
                            {
                                foglio3DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                            }
                            break;
                        case 3:
                          
                            for (int i = 0; i < 13; i++)
                            {
                                foglio8DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                            }
                            break;
                        case 4:
                           
                            for (int i = 0; i < 9; i++)
                            {
                                foglio6DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                            }
                            break;
                        default:
                         
                            for (int i = 0; i < 6; i++)
                            {
                                foglio7DataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                            }
                            break;
                    }
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                Global.Id = calibr_LisciDataGridView.Rows[Global.riga].Cells[7].Value.ToString();
                Global.Matricola = calibr_LisciDataGridView.Rows[Global.riga].Cells[0].Value.ToString();
                for (int i = 0; i < 7; i++)
                {
                    calibr_LisciDataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.Red;
                }


                var result = MessageBox.Show("Vuoi cancellare il  calibro con matricola " + Global.Matricola + " ?", "Attenzione",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
               

                if (result == DialogResult.Yes)
                {
                    this.calibr_LisciTableAdapter.DeleteQuery(Int16.Parse(Global.Id));
                    this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        calibr_LisciDataGridView.Rows[Global.riga].Cells[i].Style.BackColor = Color.White;
                    }
                }

            }

        }



        private void vitaInScadenzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRicerche frmRicerche = new frmRicerche();
            frmRicerche.Text = "In scadenza";

            frmRicerche.ShowDialog();

        }

        private void scadutiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRicerche frmRicerche = new frmRicerche();
            frmRicerche.Text = "Scaduti";

            frmRicerche.ShowDialog();
        }

      

      

        private void gestioneCalibriDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int riga = e.RowIndex;
            if (3 == e.ColumnIndex)
            {

                string gg = gestioneCalibriDataGridView.Rows[riga].Cells[3].Value.ToString();
                if (gg == "")
                {

                    var result = MessageBox.Show("Vuoi Registrare l'uscita?", "Attenzione",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.Yes)
                    {

                        frmUscita frmUscita = new frmUscita();
                        frmUscita.Tag = 0;
                        frmUscita.ShowDialog();

                        if (Global.Destinazione.ToString() != "")

                        {
                            DateTime date3 = DateTime.Today;
                            int vita = Int16.Parse(gestioneCalibriDataGridView.Rows[riga].Cells[4].Value.ToString());
                            int matricola = Int16.Parse(gestioneCalibriDataGridView.Rows[riga].Cells[0].Value.ToString());
                            gestioneCalibriTableAdapter.UpdatGESTIONECALIBRO(date3.Date, vita, Global.Destinazione, Global.Varie, matricola);
                            gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                            Colore();
                            gestioneCalibriDataGridView.CurrentCell = gestioneCalibriDataGridView.Rows[riga].Cells[0];
                            gestioneCalibriDataGridView.Rows[riga].Cells[0].Selected = true;
                        }


                    }

                }
                else
                {

                    var result = MessageBox.Show("Vuoi Registrare il rientro ?", "Attenzione",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {


                        int vita = Int16.Parse(gestioneCalibriDataGridView.Rows[riga].Cells[4].Value.ToString());
                        int matricola = Int16.Parse(gestioneCalibriDataGridView.Rows[riga].Cells[0].Value.ToString());

                        gestioneCalibriTableAdapter.UpdatGESTIONECALIBRO(null, vita, "", "", matricola);
                        gestioneCalibriTableAdapter.UpdateVITAINIZIALE(vita, matricola);
                        gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                        Colore();
                        gestioneCalibriDataGridView.CurrentCell = gestioneCalibriDataGridView.Rows[riga].Cells[0];
                        gestioneCalibriDataGridView.Rows[riga].Cells[0].Selected = true;

                    }
                }


            }




        }

        private void gestioneCalibriDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + gestioneCalibriDataGridView.Rows[Global.riga].Cells[0].Value.ToString();
        }



        private void cancellaFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            cancellaFiltroToolStripMenuItem.Visible = false;
            if (tabControl1.SelectedIndex == 0)
            {

              

                gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                Colore();

                gestioneCalibriDataGridView.Tag = 0;


            }
            if (tabControl1.SelectedIndex == 1)
            {

                switch (tabControl2.Tag)
                {

                    case 0:

                        this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);
                        foglio1DataGridView.Tag = 0;
                        break;
                    case 1:

                        this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
                        foglio2DataGridView.Tag = 0;
                        break;
                    case 2:

                        this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
                        foglio3DataGridView.Tag = 0;
                        break;
                    case 3:

                        this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
                        foglio8DataGridView.Tag = 0;
                        break;
                    case 4:

                        this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
                        foglio6DataGridView.Tag = 0;
                        break;
                    default:

                        this.foglio7TableAdapter.Fill(this.database1DataSet.Foglio7);
                        foglio7DataGridView.Tag = 0;
                        break;

                }

                if (tabControl1.SelectedIndex == 2)
                {

                    this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                    calibr_LisciDataGridView.Tag = 0;


                }







            }
            if (tabControl1.SelectedIndex == 2)
            {
                this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                calibr_LisciDataGridView.Tag = 0;



            }
        }
        private void gestioneCalibriDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int riga = e.RowIndex;
            try
            {
 if (5 == e.ColumnIndex)
            {

                toolTip1.SetToolTip(this.gestioneCalibriDataGridView, gestioneCalibriDataGridView.Rows[riga].Cells[5].Value.ToString());
                toolTip1.Active = true;
            }
            }
            catch (Exception)
            {

              
            }
           
        }



        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            if (e.TabPageIndex == 0)
            {
                scadutiToolStripMenuItem.Visible = true;
                vitaInScadenzaToolStripMenuItem.Visible = true;
                passwordToolStripMenuItem.Visible = false;
                calibriLisciToolStripMenuItem.Visible = false;
                cancellaToolStripMenuItem.Visible = true;
                modificaToolStripMenuItem.Visible = true;
                inserisciToolStripMenuItem1.Visible = true;
                tabControl1.Tag = 0;


                int v = gestione_CalibriDataSet.GestioneCalibri.Count;
                lblistruzioni.Text = "L'archivio  contiene i dati di " + v.ToString() + " calibri";


                if (this.gestioneCalibriDataGridView.Tag.ToString() == "1")
                {
                    cancellaFiltroToolStripMenuItem.Visible = true;
                }
                else
                {
                    cancellaFiltroToolStripMenuItem.Visible = false;
                }




            }
            if (tabControl1.SelectedIndex == 1)
            {
               
                scadutiToolStripMenuItem.Visible = false;
                vitaInScadenzaToolStripMenuItem.Visible = false;
               
                calibriLisciToolStripMenuItem.Visible = false;
                tabControl1.Tag = 1;
                Selezione(Int16.Parse(tabControl2.Tag.ToString()));
                if (toolStripPsw.Text.ToString() == "1234")
                {
                    modificaToolStripMenuItem.Visible = true;
                    inserisciToolStripMenuItem1.Visible = true;
                    cancellaToolStripMenuItem.Visible = true;


                }
                else
                {

                    modificaToolStripMenuItem.Visible = false;
                    inserisciToolStripMenuItem1.Visible = false;
                    cancellaToolStripMenuItem.Visible = false;
                    passwordToolStripMenuItem.Visible = true;
                }

            }
            if (tabControl1.SelectedIndex == 2)
            {

           
                scadutiToolStripMenuItem.Visible = false;
                vitaInScadenzaToolStripMenuItem.Visible = false;
                tabControl1.Tag = 2;
                modificaToolStripMenuItem.Visible = true;
                inserisciToolStripMenuItem1.Visible = true;
                cancellaToolStripMenuItem.Visible = true;
                passwordToolStripMenuItem.Visible = false;
                calibriLisciToolStripMenuItem.Visible = true;


                int v = calibri_LisciDataSet.Calibr_Lisci.Count;
                lblistruzioni.Text = "L'archivio  contiene i dati di " + v.ToString() + " calibri";


                if (this.calibr_LisciDataGridView.Tag.ToString() == "1")
                {
                    cancellaFiltroToolStripMenuItem.Visible = true;
                }
                else
                {
                    cancellaFiltroToolStripMenuItem.Visible = false;
                }
                
            }
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            Selezione(e.TabPageIndex);

        }
        private void Selezione(int sel)
        {
            tabControl2.Tag = sel;
            int v;

            switch (sel)
            {
                case 0:
                    v = database1DataSet.Foglio1.Count;

                    if (this.foglio1DataGridView.Tag.ToString() == "1")
                    {
                        cancellaFiltroToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        cancellaFiltroToolStripMenuItem.Visible = false;
                    }



                    break;
                case 1:
                    v = database1DataSet.Foglio2.Count;
                    if (foglio2DataGridView.Tag.ToString() == "1")
                    {
                        cancellaFiltroToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        cancellaFiltroToolStripMenuItem.Visible = false;
                    }
                    break;
                case 2:
                    v = database1DataSet.Foglio3.Count;
                    if (foglio3DataGridView.Tag.ToString() == "1")
                    {
                        cancellaFiltroToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        cancellaFiltroToolStripMenuItem.Visible = false;
                    }
                    break;
                case 3:
                    v = database1DataSet.Foglio8.Count;
                    if (foglio8DataGridView.Tag.ToString() == "1")
                    {
                        cancellaFiltroToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        cancellaFiltroToolStripMenuItem.Visible = false;
                    }
                    break;
                case 4:
                    v = database1DataSet.Foglio6.Count;
                    if (foglio6DataGridView.Tag.ToString() == "1")
                    {
                        cancellaFiltroToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        cancellaFiltroToolStripMenuItem.Visible = false;
                    }
                    break;
                default:
                    if (foglio7DataGridView.Tag.ToString() == "1")
                    {
                        cancellaFiltroToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        cancellaFiltroToolStripMenuItem.Visible = false;
                    }
                    v = database1DataSet.Foglio7.Count;
                    break;
            }
            lblistruzioni.Text = "L'archivio  contiene " + v.ToString() + " dati";



        }





        private void toolStripPsw_KeyUp(object sender, KeyEventArgs e)
        {
            if (toolStripPsw.Text.ToString() == "1234")
            {

                modificaToolStripMenuItem.Visible = true;
                inserisciToolStripMenuItem1.Visible = true;
                cancellaToolStripMenuItem.Visible = true;
                passwordToolStripMenuItem.Visible = false;
                toolStripPsw.Visible = false;

                lblistruzioni.Text = "Modifiche abilitate";
            }
            else
            {
                modificaToolStripMenuItem.Visible = false;
                inserisciToolStripMenuItem1.Visible = false;
                cancellaToolStripMenuItem.Visible = false;
                Selezione(Int16.Parse(tabControl2.Tag.ToString()));

            }

        }

        private void foglio1DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + this.foglio1DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
        }

        private void foglio2DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + this.foglio2DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
        }

        private void foglio3DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + this.foglio3DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
        }

        private void foglio8DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + this.foglio8DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
        }

        private void foglio6DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + this.foglio6DataGridView.Rows[Global.riga].Cells[0].Value.ToString();
        }

        private void foglio7DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            lblistruzioni.Text = "Maticola selezionata: " + this.foglio7DataGridView.Rows[Global.riga].Cells[1].Value.ToString();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calibr_LisciDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Global.riga = e.RowIndex;
            try
            {
               lblistruzioni.Text = "Maticola selezionata: " + calibr_LisciDataGridView.Rows[Global.riga].Cells[0].Value.ToString();
            }
            catch (Exception)
            {

                
            }
            
        }

     

       

       

        private void calibr_LisciDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int v = this.calibri_LisciDataSet.Calibr_Lisci.Count;
            int riga = e.RowIndex;
            string pul = e.Button.ToString();
         
                if (4 == e.ColumnIndex|| pul == "Right")
            {

                string gg = calibr_LisciDataGridView.Rows[riga].Cells[4].Value.ToString();
                Global.Matricola= calibr_LisciDataGridView.Rows[riga].Cells[0].Value.ToString();
                Global.Id= calibr_LisciDataGridView.Rows[riga].Cells[7].Value.ToString();
                if (gg == "")
                {

                    var result = MessageBox.Show("Vuoi Registrare l'uscita?", "Attenzione",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.Yes)
                    {

                        frmUscita frmUscita = new frmUscita();
                        frmUscita.Tag = 2;
                         frmUscita.ShowDialog();

                        if (Global.Destinazione.ToString() != "")

                        {
                            
                            for (int i = 0; i < v; i++)
                            {
                                if (calibr_LisciDataGridView.Rows[i].Cells[0].Selected==true)
                                {

                                    Global.Id = calibr_LisciDataGridView.Rows[i].Cells[7].Value.ToString();
                                    calibr_LisciTableAdapter.UpdateDestinazione(Global.Destinazione, Int16.Parse(Global.Id));
                                }
                                 
                              
                            }
                            


                            this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                            calibr_LisciDataGridView.CurrentCell = calibr_LisciDataGridView.Rows[riga].Cells[0];
                            calibr_LisciDataGridView.Rows[riga].Cells[0].Selected = true;



                        }


                    }

                }
                else
                {

                    var result = MessageBox.Show("Vuoi Registrare il rientro ?", "Attenzione",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        Global.Destinazione = "";
                        for (int i = 0; i < v; i++)
                        {
                            if (calibr_LisciDataGridView.Rows[i].Cells[0].Selected == true)
                            {

                                Global.Id = calibr_LisciDataGridView.Rows[i].Cells[7].Value.ToString();
                                calibr_LisciTableAdapter.UpdateDestinazione(Global.Destinazione, Int16.Parse(Global.Id));
                            }


                        }
                       
                        this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                        calibr_LisciDataGridView.CurrentCell = calibr_LisciDataGridView.Rows[riga].Cells[0];
                        calibr_LisciDataGridView.Rows[riga].Cells[0].Selected = true;

                    }
                }
            }
        }
      

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // printDocument1.Print();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Bitmap bm = new Bitmap(this.gestioneCalibriDataGridView.Width, this.gestioneCalibriDataGridView.Height);
                    gestioneCalibriDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.gestioneCalibriDataGridView.Width, this.gestioneCalibriDataGridView.Height));
                    e.Graphics.DrawImage(bm, 0, 0);

                    break;

                case 1:
                    switch (tabControl2.SelectedIndex)
                    {
                        case 0:
                            Bitmap f1 = new Bitmap(this.foglio1DataGridView.Width, this.foglio1DataGridView.Height);
                            foglio1DataGridView.DrawToBitmap(f1, new Rectangle(0, 0, this.foglio1DataGridView.Width, this.foglio1DataGridView.Height));
                            e.Graphics.DrawImage(f1, 0, 0);
                            break;

                        case 1:
                            Bitmap f2 = new Bitmap(this.foglio2DataGridView.Width, this.foglio2DataGridView.Height);
                            foglio2DataGridView.DrawToBitmap(f2, new Rectangle(0, 0, this.foglio2DataGridView.Width, this.foglio2DataGridView.Height));
                            e.Graphics.DrawImage(f2, 0, 0);
                            break;
                        case 2:
                            Bitmap f3 = new Bitmap(this.foglio3DataGridView.Width, this.foglio3DataGridView.Height);
                            foglio3DataGridView.DrawToBitmap(f3, new Rectangle(0, 0, this.foglio3DataGridView.Width, this.foglio3DataGridView.Height));
                            e.Graphics.DrawImage(f3, 0, 0);
                            break;
                        case 3:
                            Bitmap f8 = new Bitmap(this.foglio8DataGridView.Width, this.foglio8DataGridView.Height);
                            foglio8DataGridView.DrawToBitmap(f8, new Rectangle(0, 0, this.foglio8DataGridView.Width, this.foglio8DataGridView.Height));
                            e.Graphics.DrawImage(f8, 0, 0);
                            break;
                        case 4:
                            Bitmap f6 = new Bitmap(this.foglio6DataGridView.Width, this.foglio6DataGridView.Height);
                            foglio6DataGridView.DrawToBitmap(f6, new Rectangle(0, 0, this.foglio6DataGridView.Width, this.foglio6DataGridView.Height));
                            e.Graphics.DrawImage(f6, 0, 0);
                            break;

                        default:
                            Bitmap f7 = new Bitmap(this.foglio7DataGridView.Width, this.foglio7DataGridView.Height);
                            foglio7DataGridView.DrawToBitmap(f7, new Rectangle(0, 0, this.foglio7DataGridView.Width, this.foglio7DataGridView.Height));
                            e.Graphics.DrawImage(f7, 0, 0);
                            break;
                    }

                    break;
                case 2:
                    Bitmap bm2 = new Bitmap(this.calibr_LisciDataGridView.Width, this.calibr_LisciDataGridView.Height);
                    calibr_LisciDataGridView.DrawToBitmap(bm2, new Rectangle(0, 0, this.calibr_LisciDataGridView.Width, this.calibr_LisciDataGridView.Height));
                    e.Graphics.DrawImage(bm2, 0, 0);
                    break;

            }
        }

      
     

     

      


        private void calibriLisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form5 Form5 = new Form5();
           
            Form5.ShowDialog();
            this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
           
            this.Refresh();
        }

     

        private void ricercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Tag = tabControl1.SelectedIndex;
            form4.ShowDialog();
            if (Global.Id == "")
            {
                return;
            }
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    switch (Int16.Parse(Global.Id))
                    {
                        case 0:



                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;

                                int convertitore = Int16.Parse(Global.Ricerca.ToString());
                                gestioneCalibriTableAdapter.FillByMatricola(this.gestione_CalibriDataSet.GestioneCalibri, convertitore);
                                gestioneCalibriDataGridView.Tag = 1;
                            }
                            catch
                            {
                                gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                gestioneCalibriDataGridView.Tag = 0;
                            }
                            Colore();

                            break;
                        default:
                            cancellaFiltroToolStripMenuItem.Visible = true;
                            gestioneCalibriTableAdapter.FillByDESCRIZIONE(this.gestione_CalibriDataSet.GestioneCalibri, Global.Ricerca + "%");
                            Colore();
                            break;
                    }
                    break;
                case 1:
                    switch (tabControl2.Tag)
                    {

                        case 0:
                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;
                                foglio1TableAdapter.FillByMatricola(this.database1DataSet.Foglio1, Int16.Parse(Global.Ricerca.ToString()));
                                foglio1DataGridView.Tag = 1;

                            }
                            catch (Exception)
                            {
                                this.foglio1TableAdapter.Fill(this.database1DataSet.Foglio1);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                foglio1DataGridView.Tag = 0;
                            }


                            break;
                        case 1:
                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;
                                foglio2TableAdapter.FillByMatricola(this.database1DataSet.Foglio2, Int16.Parse(Global.Ricerca.ToString()));
                                foglio2DataGridView.Tag = 1;
                            }
                            catch (Exception)
                            {
                                this.foglio2TableAdapter.Fill(this.database1DataSet.Foglio2);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                foglio2DataGridView.Tag = 0;
                            }
                            break;
                        case 2:
                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;
                                foglio3TableAdapter.FillByMatricola(this.database1DataSet.Foglio3, Int16.Parse(Global.Ricerca.ToString()));
                                foglio3DataGridView.Tag = 1;
                            }
                            catch (Exception)
                            {
                                this.foglio3TableAdapter.Fill(this.database1DataSet.Foglio3);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                foglio3DataGridView.Tag = 0;
                            }
                            break;
                        case 3:

                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;
                                foglio8TableAdapter.FillByMatricola(this.database1DataSet.Foglio8, Int16.Parse(Global.Ricerca.ToString()));
                                foglio8DataGridView.Tag = 1;
                            }
                            catch (Exception)
                            {
                                this.foglio8TableAdapter.Fill(this.database1DataSet.Foglio8);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                foglio8DataGridView.Tag = 0;
                            }
                            break;
                        case 4:

                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;
                                foglio6TableAdapter.FillByMatricola(this.database1DataSet.Foglio6, Int16.Parse(Global.Ricerca.ToString()));
                                foglio6DataGridView.Tag = 1;
                            }
                            catch (Exception)
                            {
                                this.foglio6TableAdapter.Fill(this.database1DataSet.Foglio6);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                foglio6DataGridView.Tag = 0;
                            }
                            break;
                        default:

                            cancellaFiltroToolStripMenuItem.Visible = true;
                            foglio7TableAdapter.FillByMatricola(this.database1DataSet.Foglio7, Global.Ricerca);
                            foglio7DataGridView.Tag = 1;

                            break;
                    }



                    break;


                default:
                    switch (Int16.Parse(Global.Id))
                    {
                        case 0:
                            cancellaFiltroToolStripMenuItem.Visible = true;
                            calibr_LisciTableAdapter.FillByMatricola(this.calibri_LisciDataSet.Calibr_Lisci, Global.Ricerca + "%");
                            calibr_LisciDataGridView.Tag = 1;
                            break;
                        case 1:
                            cancellaFiltroToolStripMenuItem.Visible = true;
                            calibr_LisciTableAdapter.FillByPassa(this.calibri_LisciDataSet.Calibr_Lisci, Global.Ricerca + "%");
                            calibr_LisciDataGridView.Tag = 1;
                            break;
                        case 2:
                            cancellaFiltroToolStripMenuItem.Visible = true;
                            calibr_LisciTableAdapter.FillByNonPassa(this.calibri_LisciDataSet.Calibr_Lisci, Global.Ricerca + "%");
                            calibr_LisciDataGridView.Tag = 1;
                            break;


                        default:

                            try
                            {
                                cancellaFiltroToolStripMenuItem.Visible = true;
                                this.calibr_LisciTableAdapter.FillByUtile(calibri_LisciDataSet.Calibr_Lisci, decimal.Parse(Global.Ricerca));
                                calibr_LisciDataGridView.Tag = 1;
                            }
                            catch (Exception)
                            {
                                this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);
                                cancellaFiltroToolStripMenuItem.Visible = false;
                                calibr_LisciDataGridView.Tag = 0;
                            }
                            break;
                    }
                    break;




            }
        }

        
    }
}
