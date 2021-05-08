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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform5));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform5()
        {
            Application.Run(new Form5());
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
