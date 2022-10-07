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
    public partial class Formmenu : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment() /*เมนูเพิ่มเติม*/
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM inputmenu";
            MySqlDataAdapter projectkam = new MySqlDataAdapter(cmd);
            projectkam.Fill(ds);
            conn.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        ListViewItem itm;
        String[] arl = new String[4];
        Formlogin form1 = new Formlogin();
        public Formmenu()
        {
            InitializeComponent();
        }
         
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label13.Text = Convert.ToString(gtotal);
        }
        string menu1="";
        int num=0,money=0,day=0;
        private void button2_Click(object sender, EventArgs e)
        {            
            {
                int P = 60;
                arl[0] = "ผัดไข่ใบกัญชา";
                arl[1] = numericUpDown1.Value.ToString();
                arl[2] = 60 + " ";

                menu1 += $"ผัดไข่ใบกัญชา [{numericUpDown1.Value}] 60 บาท\n ";
                num += Convert.ToInt32(numericUpDown1.Value);
                money += 60 * Convert.ToInt32(numericUpDown1.Value);

                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown1.Maximum = numericUpDown1.Maximum - numericUpDown1.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ผัดไข่ใบกัญชา','{numericUpDown1.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();                                        
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                int P = 50;
                arl[0] = "ไข่ข้นกัญชาไก่กรอบ";
                arl[1] = numericUpDown11.Value.ToString();
                arl[2] = 50 + " ";

                menu1 += $"ไข่ข้นกัญชาไก่กรอบ [{numericUpDown11.Value}] 50 บาท\n";
                num += Convert.ToInt32(numericUpDown11.Value);
                money += 50 * Convert.ToInt32(numericUpDown11.Value);
                if (numericUpDown11.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown11.Maximum = numericUpDown11.Maximum - numericUpDown11.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ไข่ข้นกัญชาไก่กรอบ','{numericUpDown11.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();                                       
                }
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            {
                int P = 50;
                arl[0] = "ยำใบกัญชากรอบ";
                arl[1] = numericUpDown2.Value.ToString();
                arl[2] = 50 + " ";

                menu1 += $"ยำใบกัญชากรอบ [{numericUpDown2.Value}] 50 บาท\n";
                num += Convert.ToInt32(numericUpDown2.Value);
                money += 50 * Convert.ToInt32(numericUpDown2.Value);
                if (numericUpDown2.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown2.Maximum = numericUpDown2.Maximum - numericUpDown2.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ยำใบกัญชากรอบ','{numericUpDown2.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int P = 60;
                arl[0] = "แกงเขียวหวานใบกัญชา";
                arl[1] = numericUpDown3.Value.ToString();
                arl[2] = 60 + " ";

                menu1 += $"แกงเขียวหวานใบกัญชา [{numericUpDown3.Value}] 60 บาท\n ";
                num += Convert.ToInt32(numericUpDown3.Value);
                money += 60 * Convert.ToInt32(numericUpDown3.Value);

                if (numericUpDown3.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown3.Maximum = numericUpDown3.Maximum - numericUpDown3.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('แกงเขียวหวานใบกัญชา','{numericUpDown3.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                int P = 60;
                arl[0] = "ลาบหมู x กัญชา";
                arl[1] = numericUpDown4.Value.ToString();
                arl[2] = 60 + " ";

                menu1 += $"ลาบหมู x กัญชา [{numericUpDown4.Value}] 60 บาท\n ";
                num += Convert.ToInt32(numericUpDown4.Value);
                money += 60 * Convert.ToInt32(numericUpDown4.Value);
                if (numericUpDown4.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown4.Maximum = numericUpDown4.Maximum - numericUpDown4.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ลาบหมู x กัญชา','{numericUpDown4.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();


                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                int P = 60;
                arl[0] = "กัญชากรอบ";
                arl[1] = numericUpDown8.Value.ToString();
                arl[2] = 60 + " ";

                menu1 += $"กัญชากรอบ [{numericUpDown8.Value}] 60 บาท\n";
                num += Convert.ToInt32(numericUpDown8.Value);
                money += 60 * Convert.ToInt32(numericUpDown8.Value);
                if (numericUpDown8.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown8.Maximum = numericUpDown8.Maximum - numericUpDown8.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('กัญชากรอบ','{numericUpDown8.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                int P = 40;
                arl[0] = "ปังหน้ากัญชา";
                arl[1] = numericUpDown7.Value.ToString();
                arl[2] = 40 + " ";
                menu1 += $"ปังหน้ากัญชา [{numericUpDown7.Value}] 40 บาท\n";
                num += Convert.ToInt32(numericUpDown7.Value);
                money += 40 * Convert.ToInt32(numericUpDown7.Value);

                if (numericUpDown7.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown7.Maximum = numericUpDown7.Maximum - numericUpDown7.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ปังหน้ากัญชา','{numericUpDown7.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                int P = 70;
                arl[0] = "ต้มแซบกัญชา";
                arl[1] = numericUpDown6.Value.ToString();
                arl[2] = 70 + " ";
                menu1 += $"ต้มแซบกัญชา [{numericUpDown6.Value}] 70 บาท\n";
                num += Convert.ToInt32(numericUpDown6.Value);
                money += 70 * Convert.ToInt32(numericUpDown6.Value);

                if (numericUpDown6.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown6.Maximum = numericUpDown6.Maximum - numericUpDown6.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ต้มแซบกัญชา','{numericUpDown6.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                int P = 50;
                arl[0] = "ไข่เจียวกัญชากรอบ";
                arl[1] = numericUpDown5.Value.ToString();
                arl[2] = 50 + " ";
                menu1 += $"ไข่เจียวกัญชากรอบ [{numericUpDown5.Value}] 50 บาท\n";
                num += Convert.ToInt32(numericUpDown5.Value);
                money += 50 * Convert.ToInt32(numericUpDown5.Value);

                if (numericUpDown5.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
        
                }
                else
                {
                    numericUpDown5.Maximum = numericUpDown5.Maximum - numericUpDown5.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ไข่เจียวกัญชากรอบ','{numericUpDown5.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                int P = 50;
                arl[0] = "ไข่เข้นกัญชาหมูกรอบ";
                arl[1] = numericUpDown12.Value.ToString();
                arl[2] = 50 + " ";
                menu1 += $"ไข่เข้นกัญชาหมูกรอบ [{numericUpDown12.Value}] 50 บาท\n";
                num += Convert.ToInt32(numericUpDown12.Value);
                money += 50 * Convert.ToInt32(numericUpDown12.Value);

                if (numericUpDown12.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown12.Maximum = numericUpDown12.Maximum - numericUpDown12.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ไข่เข้นกัญชาหมูกรอบ','{numericUpDown12.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                int P = 50;
                arl[0] = "ไข่ข้นกัญชาหมู";
                arl[1] = numericUpDown10.Value.ToString();
                arl[2] = 50 + " ";
                menu1 += $"ไข่ข้นกัญชาหมู [{numericUpDown10.Value}] 50 บาท\n";
                num += Convert.ToInt32(numericUpDown10.Value);
                money += 50 * Convert.ToInt32(numericUpDown10.Value);

                if (numericUpDown10.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown10.Maximum = numericUpDown10.Maximum - numericUpDown10.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ไข่ข้นกัญชาหมู','{numericUpDown10.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                int P = 70;
                arl[0] = "ต้มไก่กัญชา";
                arl[1] = numericUpDown9.Value.ToString();
                arl[2] = 70 + " ";
                menu1 += $"ต้มไก่กัญชา [{numericUpDown9.Value}] 70 บาท\n";
                num += Convert.ToInt32(numericUpDown9.Value);
                money += 70 * Convert.ToInt32(numericUpDown9.Value);

                if (numericUpDown9.Value == 0)
                {
                    MessageBox.Show("สินค้าหมด");
                }
                else
                {
                    numericUpDown9.Maximum = numericUpDown9.Maximum - numericUpDown9.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);

                    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
                    con.Open();
                    String sql = $"INSERT INTO cart (เมนู,จำนวน,ราคา) VALUES ('ต้มไก่กัญชา','{numericUpDown9.Value}','{P}')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        public static string raka;
        private void Formmenu_Load(object sender, EventArgs e)
        {
            label18.Text = System.DateTime.Now.ToShortDateString();
            showEquipment();
        }

        private void button14_Click_1(object sender, EventArgs e) /*ปุ่มลบ*/
        {
           
            MessageBox.Show(listView1.SelectedItems[0].Text);

            if (listView1.SelectedItems[0].Text == "ผัดไข่ใบกัญชา")
            {
                menu1 = menu1.Replace($"ผัดไข่ใบกัญชา [{numericUpDown1.Value}]\n ", "");
                num -= Convert.ToInt32(numericUpDown1.Value);
                money -= 60 * Convert.ToInt32(numericUpDown1.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ไข่ข้นกัญชาไก่กรอบ")
            {
                menu1 = menu1.Replace($"ไข่ข้นกัญชาไก่กรอบ[{numericUpDown11.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown11.Value);
                money -= 50 * Convert.ToInt32(numericUpDown11.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ยำใบกัญชากรอบ")
            {
                menu1 = menu1.Replace($"ยำใบกัญชากรอบ [{numericUpDown2.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown2.Value);
                money -= 50 * Convert.ToInt32(numericUpDown2.Value);
            }
            else if (listView1.SelectedItems[0].Text == "แกงเขียวหวานใบกัญชา")
            {
                menu1 = menu1.Replace($"แกงเขียวหวานใบกัญชา [{numericUpDown3.Value}]\n ", "");
                num -= Convert.ToInt32(numericUpDown3.Value);
                money -= 60 * Convert.ToInt32(numericUpDown3.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ลาบหมู x กัญชา")
            {
                menu1 = menu1.Replace($"ลาบหมู x กัญชา [{numericUpDown4.Value}]\n ", "");
                num -= Convert.ToInt32(numericUpDown4.Value);
                money -= 60 * Convert.ToInt32(numericUpDown4.Value);
            }
            else if (listView1.SelectedItems[0].Text == "กัญชากรอบ")
            {
                menu1 = menu1.Replace($"กัญชากรอบ [{numericUpDown8.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown8.Value);
                money -= 60 * Convert.ToInt32(numericUpDown2.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ปังหน้ากัญชา")
            {
                menu1 = menu1.Replace($"ปังหน้ากัญชา [{numericUpDown7.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown7.Value);
                money -= 40 * Convert.ToInt32(numericUpDown7.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ต้มแซบกัญชา")
            {
                menu1 = menu1.Replace($"ต้มแซบกัญชา [{numericUpDown6.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown6.Value);
                money -= 70 * Convert.ToInt32(numericUpDown6.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ไข่เจียวกัญชากรอบ")
            {
                menu1 = menu1.Replace($"ไข่เจียวกัญชากรอบ [{numericUpDown5.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown5.Value);
                money -= 50 * Convert.ToInt32(numericUpDown5.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ไข่เข้นกัญชาหมูกรอบ")
            {
                menu1 = menu1.Replace($"ไข่เข้นกัญชาหมูกรอบ [{numericUpDown12.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown12.Value);
                money -= 50 * Convert.ToInt32(numericUpDown12.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ไข่ข้นกัญชาหมู")
            {
                menu1 = menu1.Replace($"ไข่ข้นกัญชาหมู [{numericUpDown10.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown10.Value);
                money -= 50 * Convert.ToInt32(numericUpDown10.Value);
            }
            else if (listView1.SelectedItems[0].Text == "ต้มไก่กัญชา")
            {
                menu1 = menu1.Replace($"ต้มไก่กัญชา [{numericUpDown9.Value}]\n", "");
                num -= Convert.ToInt32(numericUpDown9.Value);
                money -= 70 * Convert.ToInt32(numericUpDown9.Value);
            }
           
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
            con.Open();
            String sql = $"DELETE FROM cart WHERE เมนู = '{listView1.SelectedItems[0].Text}'";
            menukam = menu1;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            
            con.Close();

            if (rows >= 0)
            {
                MessageBox.Show("ลบเสร็จแล้ว");
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string menukam;
        private void button15_Click_1(object sender, EventArgs e)
        {
            raka = label13.Text;

            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;");
            con.Open();
            String sql = $"INSERT INTO menu (วันที่,โต๊ะ,ชื่อ,รายการ,จำนวน,ราคา) VALUES ('{label18.Text}','{sit.โต้ะ}','{sit.ชื่อ}','{menu1}','{num}','{money}')";
            menukam = menu1;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows >= 0)
            {
                MessageBox.Show("สั่งสินค้าเรียบร้อยแล้ว");
            }
            this.Hide();
            new Form2().Show();
        }

       private void Formmenu_Shown(object sender, EventArgs e)
        {
            label14.Text = sit.โต้ะ ;
            label17.Text = sit.ชื่อ;          
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToShortDateString();
            label18.Text = DateTime.Now.ToShortDateString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            new sit().Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {
            
        }

       
    }
   
    
}
