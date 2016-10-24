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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cl = comboCl.Text;
            string sal = salle.Text;
            string sp = comboSpe.Text;
            string m = comboMat.Text;
            string h = comboHoraire.Text;
            string d = combodate.Text;
          //  string d= dtm.Value.Date.ToString("dd/MM/yyyy");

            try
            {
                OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb");
                con1.Open();
                //   OleDbCommand cmd1 = new OleDbCommand("INSERT into matiere (salle,specialite,classe,mat,horaire)values('" + sal + "','" + sp + "','" + cl + "','" + m + "','" + h + "')", con1);
                OleDbCommand cmd1 = new OleDbCommand("INSERT into matiere (salle,specialite,classe,mat,horaire,date1)values('" + sal + "','" + sp + "','" + cl + "','" + m + "','" + h + "','"+d+"')", con1);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Matiere ajouté.");
                //lbl_msg.Text = "Record inserted successfully.";
                con1.Close();
            }
            catch
            {
                MessageBox.Show("error.");

            }
            // String etat = comboBox1.Text;
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //   string strSql = "Select * from Ardia_DB where Etat ='" + etat + "'";
            string strSql = "Select * from matiere where classe ='" + cl + "'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            dataGridView2.DataSource = scores;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cl = comboCl.Text;
            string sal = salle.Text;
            string sp = comboSpe.Text;
            try
            {
                OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb");
                con1.Open();
                OleDbCommand cmd1 = new OleDbCommand("INSERT into classe (salle,specialite,classe)values('"+sal+"','"+sp+"','"+cl+"')", con1);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Classe ajouté.");
                //lbl_msg.Text = "Record inserted successfully.";
                con1.Close();
            }
            catch
            {
                MessageBox.Show("error.");

            }

            // String etat = comboBox1.Text;
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //   string strSql = "Select * from Ardia_DB where Etat ='" + etat + "'";
            string strSql = "Select * from classe";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);
            //dataGridView1.DataSource = scores;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Form2 f1 = new Form2();
            f1.Hide();
        }
    }
}
