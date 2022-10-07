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
    public partial class sit : Form
    {
        public sit()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formlogin().Show();
        }
        public static string ชื่อ,เบอร์โทร;
        private void sit_Shown(object sender, EventArgs e)
        {
            textBox1.Text = regis.name1;
            textBox2.Text = regis.call1;
        }
        public static string วันที่ = "Day";

        private void button7_Click(object sender, EventArgs e)
        {
            if (โต้ะ != "-" && textBox1.Text !=  "" && textBox2.Text.Length == 10)
            {
                ชื่อ= textBox1.Text;
                เบอร์โทร= textBox2.Text;
                this.Hide();
                new Formmenu().Show();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกโต๊ะ","เตือน!!!");
            }                       
        }
        private void sit_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chocolate;
            button2.BackColor = Color.Chocolate;
            button3.BackColor = Color.Chocolate;
            button4.BackColor = Color.Chocolate;
            button5.BackColor = Color.Chocolate;
        }

        public static string โต้ะ="-";
        private void button1_Click(object sender, EventArgs e)
        {
            โต้ะ = "A1";
            if (button1.BackColor == Color.Chocolate)
            {
                if (MessageBox.Show("ต้องการเลือกโต๊ะนี่ใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button1.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("ต้องการเปลี่ยนโต๊ะใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button1.BackColor = Color.Chocolate;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            โต้ะ = "A2";
            if (button2.BackColor == Color.Chocolate)
            {
                if (MessageBox.Show("ต้องการเลือกโต๊ะนี่ใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button2.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("ต้องการเปลี่ยนโต๊ะใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button2.BackColor = Color.Chocolate;
            }
        }              
        private void button3_Click(object sender, EventArgs e)
        {
            โต้ะ = "A3";
            if (button3.BackColor == Color.Chocolate)
            {
                if (MessageBox.Show("ต้องการเลือกโต๊ะนี่ใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button3.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("ต้องการเปลี่ยนโต๊ะใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button3.BackColor = Color.Chocolate;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            โต้ะ = "A4";
            if (button4.BackColor == Color.Chocolate)
            {
                if (MessageBox.Show("ต้องการเลือกโต๊ะนี่ใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button4.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("ต้องการเปลี่ยนโต๊ะใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button4.BackColor = Color.Chocolate;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            โต้ะ = "A5";
            if (button5.BackColor == Color.Chocolate)
            {
                if (MessageBox.Show("ต้องการเลือกโต๊ะนี่ใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button5.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("ต้องการเปลี่ยนโต๊ะใช่ไหม", "เตือน!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button5.BackColor = Color.Chocolate;
            }
        }               
    }
}
