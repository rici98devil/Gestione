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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Matricola");
            Global.Id = "";
            switch (this.Tag)
            {
                case 0:
                    comboBox1.Items.Add("Descrizione");
                    break;
                case 1:

                    break;    
                default:
                    
                     comboBox1.Items.Add("Passa");
                     comboBox1.Items.Add("Non Passa");
                     comboBox1.Items.Add("Lunghezza utile");
                    break;
            }
           
           
            comboBox1.SelectedIndex = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Select();




            }
            else
            {
                Global.Id = comboBox1.SelectedIndex.ToString();
                Global.Ricerca = textBox1.Text;
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
