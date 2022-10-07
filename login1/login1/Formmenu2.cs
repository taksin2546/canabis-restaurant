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
    public partial class Formmenu2 : Form
    {
        public Formmenu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new History().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new input().Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Formlogin().Show();
        }
        private void Formmenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
