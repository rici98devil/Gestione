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
    public partial class frmUscita : Form
    {
        public frmUscita()
        {
            InitializeComponent();
        }

        private void frmUscita_Load(object sender, EventArgs e)
        {            
           
            Global.Destinazione = "";
            Global.Varie = "";

            this.txtDesrizione.Clear();
            this.txtDestinazione.Clear();
            DateTime date3 = DateTime.Today;
            this.Text = "Data di Uscita : " + date3.ToString("MM/ dd/ yyyy");
            switch (this.Tag)
            {
                case 0:
                    lblVarie.Visible = true;
                    txtDesrizione.Visible = true;
                    this.Height = 328;
                    button1.Location = new Point(146, 229);
                    bntOk.Location = new Point(8, 229);
                    break;
                default:
                    lblVarie.Visible = false;
                    txtDesrizione.Visible = false;
                    this.Height = 192;
                    button1.Location = new Point(146, 95);
                    bntOk.Location = new Point(8, 95);
                    break;



            }



        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            if (txtDestinazione.Text.ToString()!="")
            {
               
                Global.Destinazione = txtDestinazione.Text.ToString();
                Global.Varie = txtDesrizione.Text.ToString();
                this.Close();
            }
            else
            {

            MessageBox.Show("Destinazione Mancante", "Attenzione",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
