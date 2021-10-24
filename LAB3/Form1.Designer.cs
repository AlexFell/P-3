namespace LAB3
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчитатьToolStripMenuItem,
            this.вводДанныхToolStripMenuItem,
            this.отчиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расчитатьToolStripMenuItem
            // 
            this.расчитатьToolStripMenuItem.Name = "расчитатьToolStripMenuItem";
            this.расчитатьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.расчитатьToolStripMenuItem.Text = "Расчитать";
            this.расчитатьToolStripMenuItem.Click += new System.EventHandler(this.расчитатьToolStripMenuItem_Click);
            // 
            // вводДанныхToolStripMenuItem
            // 
            this.вводДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exelToolStripMenuItem,
            this.googleTableToolStripMenuItem});
            this.вводДанныхToolStripMenuItem.Name = "вводДанныхToolStripMenuItem";
            this.вводДанныхToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.вводДанныхToolStripMenuItem.Text = "Ввод данных";
            this.вводДанныхToolStripMenuItem.Click += new System.EventHandler(this.вводДанныхToolStripMenuItem_Click);
            // 
            // exelToolStripMenuItem
            // 
            this.exelToolStripMenuItem.Name = "exelToolStripMenuItem";
            this.exelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exelToolStripMenuItem.Text = "Excel";
            this.exelToolStripMenuItem.Click += new System.EventHandler(this.exelToolStripMenuItem_Click);
            // 
            // googleTableToolStripMenuItem
            // 
            this.googleTableToolStripMenuItem.Name = "googleTableToolStripMenuItem";
            this.googleTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.googleTableToolStripMenuItem.Text = "Google Table";
            this.googleTableToolStripMenuItem.Click += new System.EventHandler(this.googleTableToolStripMenuItem_Click);
            // 
            // отчиститьToolStripMenuItem
            // 
            this.отчиститьToolStripMenuItem.Name = "отчиститьToolStripMenuItem";
            this.отчиститьToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.отчиститьToolStripMenuItem.Text = "Отчистить";
            this.отчиститьToolStripMenuItem.Click += new System.EventHandler(this.отчиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem расчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleTableToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

