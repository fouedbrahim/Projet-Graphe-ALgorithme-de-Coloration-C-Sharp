using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        
        DataRow dr;
        public Form4()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        public void lundi()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Lundi' and horaire ='Matin'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label2.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Lundi' and horaire ='Matin'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox1.Items.Add(mat.Substring(16));

            }
        }

        public void LundiAPr() {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Lundi' and horaire ='Apre midi'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label3.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Lundi' and horaire ='Apre midi'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox2.Items.Add(mat.Substring(16));

            }
        }


        // mardi 
        public void mardi()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Mardi' and horaire ='Matin'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label5.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Mardi' and horaire ='Matin'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox3.Items.Add(mat.Substring(16));

            }
        }

        public void MardiAPr()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Mardi' and horaire ='Apre midi'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label10.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Mardi' and horaire ='Apre midi'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox8.Items.Add(mat.Substring(16));

            }
        }

        //fin mardi

        //Mercredi
        public void mercredi()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Mercredi' and horaire ='Matin'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label6.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Mercredi' and horaire ='Matin'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox4.Items.Add(mat.Substring(16));

            }
        }

        public void MercrediAPr()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Mercredi' and horaire ='Apre midi'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label11.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Mercredi' and horaire ='Apre midi'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox9.Items.Add(mat.Substring(16));

            }
        }

        //fin mercredi

        //jeudi
        public void jeudi()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Jeudi' and horaire ='Matin'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label7.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Jeudi' and horaire ='Matin'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox5.Items.Add(mat.Substring(16));

            }
        }

        public void JeudiAPr()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Jeudi' and horaire ='Apre midi'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label12.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Jeudi' and horaire ='Apre midi'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox10.Items.Add(mat.Substring(16));

            }
        }

        //fin jeudi

        //vendredi
        public void vendredi()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Vendredi' and horaire ='Matin'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label8.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Vendredi' and horaire ='Matin'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox6.Items.Add(mat.Substring(16));

            }
        }

        public void VendrediAPr()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Vendredi' and horaire ='Apre midi'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label13.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Vendredi' and horaire ='Apre midi'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox11.Items.Add(mat.Substring(16));

            }
        }

        //fin vendredi

        //samedi
        public void Samedi()
        {
            string co = comboCl.Text;
            //   string connString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";
            //listView1.View = View.Details;
            // SqlConnection con = new SqlConnection(connString);
            //SqlDataAdapter ada = new SqlDataAdapter("Select * from matiere", con);
            //DataTable dt = new DataTable();
            string strProvider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\graph1.accdb";

            //lundi Matin
            string strSql = "Select * from matiere where classe='" + co + "' and date1='Samedi' and horaire ='Matin'";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable scores = new DataTable();
            da.Fill(scores);

            for (int i = 0; i < scores.Rows.Count; i++)
            {
                DataRow dr = scores.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["mat"].ToString()).ToString();

                label9.Text = mat.Substring(16);


            }

            //lundi Matin spec
            string strSql1 = "Select distinct specialite from matiere where classe='" + co + "' and date1='Samedi' and horaire ='Matin'";
            OleDbConnection con1 = new OleDbConnection(strProvider);
            OleDbCommand cmd1 = new OleDbCommand(strSql, con);
            //  con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
            DataTable scores1 = new DataTable();
            da.Fill(scores1);

            for (int i = 0; i < scores1.Rows.Count; i++)
            {
                dr = scores1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());

                string mat = listitem.SubItems.Add(dr["specialite"].ToString()).ToString();



                listBox7.Items.Add(mat.Substring(16));

            }
        }

       

        //fin samedi
        private void button1_Click(object sender, EventArgs e)
        {

            lundi();
            LundiAPr();
            mardi();
            MardiAPr();
            mercredi();
            jeudi();
            JeudiAPr();
            vendredi();
            VendrediAPr();
            Samedi();


          
//appl methodes





        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graphDataSet.matiere' table. You can move, or remove it, as needed.
            //       this.matiereTableAdapter.Fill(this.graphDataSet.matiere);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            Form4 f1 = new Form4();
            f1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }


        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
