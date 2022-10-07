using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login1
{
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form2()
        {
            InitializeComponent();
            showEquipment();
        }

        public static string globaluser;
        private void button3_Click(object sender, EventArgs e)
        {
            globaluser = txtname.Text;
            printPreviewDialog1.Document = printDocument1;
            //Hide();
            printPreviewDialog1.ShowDialog();

            string sql = "SELECT * FROM cart ";
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            printPreviewDialog1.Document = printDocument1;
            //Hide();
            printPreviewDialog1.ShowDialog();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string sql1 = "DELETE FROM cart";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            int rows1 = cmd1.ExecuteNonQuery();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formmenu2().Show();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            txtname.Text = sit.ชื่อ;
            txttabel.Text = sit.โต้ะ;
            txtcall.Text = sit.เบอร์โทร;
            label8.Text = Formmenu.raka;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtcall_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formmenu().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("         กัญชา กัญใจ", new Font("Century Gothic", 26, FontStyle.Bold), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("Date " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new PointF(500, 150));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 190));
            e.Graphics.DrawString(" ชื่อสินค้า                          จำนวน                       ราคา", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(100, 220));

            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = $"SELECT เมนู,จำนวน,ราคา FROM cart";
            MySqlDataReader dr = cmd.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                e.Graphics.DrawString(dr.GetString("เมนู"), new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new Point(100, 270 + 40 * b));
                e.Graphics.DrawString(dr.GetString("จำนวน"), new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new Point(480, 270 + 40 * b));
                e.Graphics.DrawString(dr.GetString("ราคา"), new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new Point(680, 270 + 40 * b));
                b++;
            }
            conn.Close();
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 190));
            int y = 320;
            e.Graphics.DrawString("ราคารวม", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, (y + 500)));
            e.Graphics.DrawString($"{Formmenu.raka} Bath", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(600, (y + 500)));
            e.Graphics.DrawString("กัญชา กัญใจ               ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(120, ((y + 600) + 45) + 45));
            e.Graphics.DrawString("ทักษิณ  มัตวงษ์          ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(80, (((y + 600) + 45) + 45) + 45));
                      
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT เมนู,จำนวน,ราคา FROM cart ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
