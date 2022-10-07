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
    public partial class regis : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=register;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formlogin().Show();
        }
        public regis()
        {
            InitializeComponent();
        }

        public static string name1, call1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 10)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "เตือน");
                return;
            }
            else 
            {
                name1 = textBox1.Text+"  "+textBox2.Text;
                call1= textBox3.Text;
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;charset=utf8;");
                String sql = "INSERT INTO regis (Name,Lastname,Phone) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ","เตือน");
                    this.Hide();
                    new sit().Show();
                }
            }
        }
               
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regis_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
       
}
