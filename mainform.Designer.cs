using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace DemoEKZ2
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        public void Table_1()
        {
            using (DataTable dt = new DataTable()) {
                using (conn = new SqlConnection(Data.value))
                {
                    using (SqlDataAdapter sd = new SqlDataAdapter("SELECT * FROM Партнеры", conn))
                    {
                        sd.Fill(dt);
                    }

                }
                dataGridView1.DataSource = dt;
            }
            
        }

        



        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.войтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партнерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.директорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеВТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.партнерыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиToolStripMenuItem,
            this.отобразитьТаблицуToolStripMenuItem,
            this.добавитьДанныеВТаблицуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // войтиToolStripMenuItem
            // 
            this.войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
            this.войтиToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.войтиToolStripMenuItem.Text = "Войти";
            this.войтиToolStripMenuItem.Click += new System.EventHandler(this.войтиToolStripMenuItem_Click);
            // 
            // отобразитьТаблицуToolStripMenuItem
            // 
            this.отобразитьТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.партнерыToolStripMenuItem,
            this.директорToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.отобразитьТаблицуToolStripMenuItem.Name = "отобразитьТаблицуToolStripMenuItem";
            this.отобразитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.отобразитьТаблицуToolStripMenuItem.Text = "Таблицы бд";
            this.отобразитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.отобразитьТаблицуToolStripMenuItem_Click);
            // 
            // партнерыToolStripMenuItem
            // 
            this.партнерыToolStripMenuItem.Name = "партнерыToolStripMenuItem";
            this.партнерыToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.партнерыToolStripMenuItem.Text = "Партнеры";
            this.партнерыToolStripMenuItem.Click += new System.EventHandler(this.партнерыToolStripMenuItem_Click);
            // 
            // директорToolStripMenuItem
            // 
            this.директорToolStripMenuItem.Name = "директорToolStripMenuItem";
            this.директорToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.директорToolStripMenuItem.Text = "Директор";
            this.директорToolStripMenuItem.Click += new System.EventHandler(this.директорToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // добавитьДанныеВТаблицуToolStripMenuItem
            // 
            this.добавитьДанныеВТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.партнерыToolStripMenuItem1,
            this.studentToolStripMenuItem1});
            this.добавитьДанныеВТаблицуToolStripMenuItem.Name = "добавитьДанныеВТаблицуToolStripMenuItem";
            this.добавитьДанныеВТаблицуToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.добавитьДанныеВТаблицуToolStripMenuItem.Text = "Добавить данные в таблицу";
            // 
            // партнерыToolStripMenuItem1
            // 
            this.партнерыToolStripMenuItem1.Name = "партнерыToolStripMenuItem1";
            this.партнерыToolStripMenuItem1.Size = new System.Drawing.Size(149, 24);
            this.партнерыToolStripMenuItem1.Text = "Партнеры";
            this.партнерыToolStripMenuItem1.Click += new System.EventHandler(this.партнерыToolStripMenuItem1_Click);
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(149, 24);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 286);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(340, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(347, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мастер пол";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "Мастер пол - Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SqlConnection conn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem войтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеВТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партнерыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem директорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem партнерыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

