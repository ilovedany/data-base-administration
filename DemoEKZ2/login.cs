using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEKZ2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(conn = new System.Data.SqlClient.SqlConnection("Server="+textBox1.Text+ ";Database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text+""))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Подключено!");
                    this.Hide();
                    Data.value = "Server=" + textBox1.Text + ";Database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text + "";
                }
                catch(Exception help) {
                    MessageBox.Show(help.Message);
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
