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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform4));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform4()
        {
            Application.Run(new Form4());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vehicule supprimé avec succé.");
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
