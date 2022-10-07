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
    public partial class input : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "host=localhost;user=root;password=;database=projectkam";
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
            cmd.CommandText = "SELECT * FROM inputmenu";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;

        }
        public input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formmenu2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO inputmenu (เมนู, ราคา) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");

                showEquipment();
            }
            showEquipment();
        }

        private void input_Load(object sender, EventArgs e)
        {
            showEquipment();
        }        
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedRow = dataEquipment.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataEquipment.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM inputmenu WHERE id = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showEquipment();
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEquipment.CurrentRow.Selected = true;
            textBox1.Text = dataEquipment.Rows[e.RowIndex].Cells["เมนู"].FormattedValue.ToString();
            textBox2.Text = dataEquipment.Rows[e.RowIndex].Cells["ราคา"].FormattedValue.ToString();
        }
                
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }    
}
