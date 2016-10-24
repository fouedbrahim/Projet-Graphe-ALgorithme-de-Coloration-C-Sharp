using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom1 = nom.Text;
            string pwd1 = pwd.Text;
            string log = login.Text;
           // string n = nom.Text;
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT into univeristy (nom,login,pwd)values('"+nom1+"','"+log+"','"+pwd1+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Université ajouté.");
                //lbl_msg.Text = "Record inserted successfully.";
                con.Close();
            }
            catch
            {
                MessageBox.Show("error.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            
        }
    }
}
