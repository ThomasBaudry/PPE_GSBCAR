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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform2));
            monthread.Start();
            this.Close();
        }

        public static void ouvrirnouveauform2()
        {
            Application.Run(new Form2());
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauconnexion));
            monthread.Start();
            this.Close();
        }

        public static void ouvrirnouveauconnexion()
        {
            Application.Run(new Connexion());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform3));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform3()
        {
            Application.Run(new Form3());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform4));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform4()
        {
            Application.Run(new Form4());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
