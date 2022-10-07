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
    public partial class History : Form
    {
        
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectkam;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM menu";
            MySqlDataAdapter projectkam = new MySqlDataAdapter(cmd);
            projectkam.Fill(ds);

            conn.Close();

            dataEquipment.DataSource = ds.Tables[0].DefaultView;

        }
        
        public History()
        {
            InitializeComponent();
        }

        
        private void History_Load(object sender, EventArgs e)
        {
            showEquipment1("SELECT * FROM menu");
            showEquipment();
            searchData("");
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;user=root;password=;database=projectkam");
        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM menu WHERE CONCAT (ชื่อ) LIKE '%" + valueToFind + "%'";
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adapter3.Fill(table);
            dataEquipment.DataSource = table;
        }
        private void showEquipment1(string sql)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
            MySqlDataReader reader = cmd.ExecuteReader();
            int maxcolumnsum = 0;
            while (reader.Read())
            {
                maxcolumnsum += reader.GetInt32("ราคา");
            }
            label2.Text = maxcolumnsum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formmenu2().Show();
        }
        private void dataEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }
       
        string wdp;
        private void choosedmy()
        {
            if (comboBox1.Text != "")
            {
                wdp = "%" + comboBox1.Text + "%";
            }
            if (comboBox2.Text != "")
            {
                wdp = "%" + comboBox2.Text + "/" + comboBox1.Text + "%";
            }
            if (comboBox3.Text != "")
            {
                wdp = "%" + comboBox3.Text + "/" + comboBox2.Text + "/" + comboBox1.Text + "%";
            }
            showEquipment1("SELECT * FROM menu WHERE วันที่ LIKE '" + wdp + "'");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            int day_ = 0;
            if (comboBox2.Text == "1" || comboBox2.Text == "3" || comboBox2.Text == "5" || comboBox2.Text == "7" || comboBox2.Text == "8" || comboBox2.Text == "10" || comboBox2.Text == "12")
            {
                day_ = 31;
            }
            else if (comboBox2.Text == "4" || comboBox2.Text == "6" || comboBox2.Text == "9" || comboBox2.Text == "11")
            {
                day_ = 30;
            }
            else if (comboBox2.Text == "2")
            {
                day_ = 28;
            }
            comboBox3.Items.Add("");

            for (int i = 1; i <= day_; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
            choosedmy();
        }
                
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedmy();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedmy();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
