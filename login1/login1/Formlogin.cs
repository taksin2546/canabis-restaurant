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
    public partial class Formlogin : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");

        public Formlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "1234567890"))
            {
                this.Hide();
                new regis().Show();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณากรอก Username", "เตือน");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("กรุณากรอก password", "เตือน");
                textBox2.Focus();
            }
            else if (textBox1.Text != "admin")
            {
                MessageBox.Show("Username คุณผิดกรุณาตรวจสอบ", "เตือน");
                textBox1.Focus();
                textBox1.SelectAll();
            }
            else if (textBox2.Text != "1234567890")
            {
                MessageBox.Show("Password คุณผิดกรุณาตรวจสอบ", "เตือน");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "1234567890"))
            {
                this.Hide();
                new Formmenu2().Show();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณากรอก Username", "เตือน");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("กรุณากรอก password", "เตือน");
                textBox2.Focus();
            }
            else if (textBox1.Text != "admin")
            {
                MessageBox.Show("Username คุณผิดกรุณาตรวจสอบ", "เตือน");
                textBox1.Focus();
                textBox1.SelectAll();
            }
            else if (textBox2.Text != "1234567890")
            {
                MessageBox.Show("Password คุณผิดกรุณาตรวจสอบ", "เตือน");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }
    }
    }

    

       
        

       
   

