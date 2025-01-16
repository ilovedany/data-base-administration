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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new login();
            log.ShowDialog();
        }

        private void партнерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.value != null) {
                Table_1();
            }
            else
            {
                MessageBox.Show("Подлючитесь к БД!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void директорToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        public void партнерыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var table_1_add = new Table_1_Add();
            table_1_add.Owner = this;
            if (Data.value != null)
            {
                table_1_add.ShowDialog();
            }
            else
            {
                MessageBox.Show("Подлючитесь к БД!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };


        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void отобразитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
