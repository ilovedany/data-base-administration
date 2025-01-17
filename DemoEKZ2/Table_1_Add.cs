using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEKZ2
{
    public partial class Table_1_Add : Form
    {
        public Table_1_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(conn = new System.Data.SqlClient.SqlConnection(Data.value))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Партнеры (Партнеры_ключ, Наименование_компании, ИНН, Логотип, Рейтинг, Директор_ключ, Юр_адрес_ключ, Места_продаж_ключ) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", conn))
                    {
                        cmd.ExecuteNonQuery();


                        mainform mainform = (mainform)this.Owner;
                        mainform.партнерыToolStripMenuItem1_Click(sender, e);
                        MessageBox.Show("Добавлено");
                        Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                
                }
            }
        }

        private void Table_1_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
