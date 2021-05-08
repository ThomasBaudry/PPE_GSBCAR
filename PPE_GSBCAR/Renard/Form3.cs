using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renard
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Label29_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gb_elecM.Visible = false;
            gb_thermM.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Vehicule Thermique")
            {
                gb_thermM.Visible = true;
                gb_elecM.Visible = false;
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Vehicule Electrique")
                {
                    gb_elecM.Visible = true;
                    gb_thermM.Visible = false;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform1));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform1()
        {
            Application.Run(new Form1());
        }
    }
}
