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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gb_therm.Visible = false;
            gb_elec.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Vehicule Thermique")
            {
                gb_therm.Visible = true;
                gb_elec.Visible = false;
            }
            else
            {
                if(comboBox1.SelectedItem.ToString() == "Vehicule Electrique")
                {
                    gb_elec.Visible = true;
                    gb_therm.Visible = false;
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label29_Click(object sender, EventArgs e)
        {

        }

        private void Gb_elec_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
