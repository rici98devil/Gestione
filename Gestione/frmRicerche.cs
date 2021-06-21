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
    public partial class frmRicerche : Form
    {
        public frmRicerche()
        {
            InitializeComponent();
        }

        private void gestioneCalibriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gestioneCalibriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestione_CalibriDataSet);

        }

        private void frmRicerche_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'gestione_CalibriDataSet.GestioneCalibri'. È possibile spostarla o rimuoverla se necessario.
            this.gestioneCalibriTableAdapter.Fill(this.gestione_CalibriDataSet.GestioneCalibri);

        }

        private void frmRicerche_Activated(object sender, EventArgs e)
        {
            if (Text=="Scaduti")
            {
 gestioneCalibriTableAdapter.FillByScaduti(gestione_CalibriDataSet.GestioneCalibri);
            }
            else
            {
                gestioneCalibriTableAdapter.FillByVitainScadenza(gestione_CalibriDataSet.GestioneCalibri);
            }
           
            Colore();
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

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // printDocument1.Print();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
       

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.gestioneCalibriDataGridView.Width, this.gestioneCalibriDataGridView.Height);
            gestioneCalibriDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.gestioneCalibriDataGridView.Width, this.gestioneCalibriDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
