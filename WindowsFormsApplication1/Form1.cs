using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = mp.Text;
            string l = log.Text;
            if ((m == "ESPRIT" && l == "ESPRIT")|| (m == "INSAT" && l == "INSAT"))
            {
                Form2 f = new Form2();
                f.Show();
            }
            else
            { label3.Text = "Verifier votre Login et Mot de passe !! "; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
