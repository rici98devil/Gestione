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
    public partial class Form5 : Form
    {
        bool salva = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void calibr_LisciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calibr_LisciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.calibri_LisciDataSet);
            salva = false;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'calibri_LisciDataSet.Calibr_Lisci'. È possibile spostarla o rimuoverla se necessario.
            this.calibr_LisciTableAdapter.Fill(this.calibri_LisciDataSet.Calibr_Lisci);

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salva==true)
            {

                var result = MessageBox.Show("Tabella non salvat, vuoi salvare ?", "Attenzione",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    this.Validate();
                    this.calibr_LisciBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.calibri_LisciDataSet);



                }
            }
           
        }

        private void calibr_LisciDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            salva = true;
        }
    }
}
