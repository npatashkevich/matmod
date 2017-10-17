namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имитацияСлучайногоСобытияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имитацияСложногоСобытияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видыToolStripMenuItem
            // 
            this.видыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имитацияСлучайногоСобытияToolStripMenuItem,
            this.имитацияСложногоСобытияToolStripMenuItem,
            this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem,
            this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem});
            this.видыToolStripMenuItem.Name = "видыToolStripMenuItem";
            this.видыToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.видыToolStripMenuItem.Text = "Виды";
            // 
            // имитацияСлучайногоСобытияToolStripMenuItem
            // 
            this.имитацияСлучайногоСобытияToolStripMenuItem.Name = "имитацияСлучайногоСобытияToolStripMenuItem";
            this.имитацияСлучайногоСобытияToolStripMenuItem.Size = new System.Drawing.Size(445, 22);
            this.имитацияСлучайногоСобытияToolStripMenuItem.Text = "Имитация случайного события";
            this.имитацияСлучайногоСобытияToolStripMenuItem.Click += new System.EventHandler(this.имитацияСлучайногоСобытияToolStripMenuItem_Click);
            // 
            // имитацияСложногоСобытияToolStripMenuItem
            // 
            this.имитацияСложногоСобытияToolStripMenuItem.Name = "имитацияСложногоСобытияToolStripMenuItem";
            this.имитацияСложногоСобытияToolStripMenuItem.Size = new System.Drawing.Size(445, 22);
            this.имитацияСложногоСобытияToolStripMenuItem.Text = "Имитация сложного события";
            this.имитацияСложногоСобытияToolStripMenuItem.Click += new System.EventHandler(this.имитацияСложногоСобытияToolStripMenuItem_Click);
            // 
            // имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem
            // 
            this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem.Name = "имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem";
            this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem.Size = new System.Drawing.Size(445, 22);
            this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem.Text = "Имитация сложного события, состоящего из зависимых событий. ";
            this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem.Click += new System.EventHandler(this.имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem_Click);
            // 
            // имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem
            // 
            this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem.Name = "имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem";
            this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem.Size = new System.Drawing.Size(445, 22);
            this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem.Text = "Имитация событий, составляющих полную группу";
            this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem.Click += new System.EventHandler(this.имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность события А:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0,5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вероятность события В:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вероятность события В/А:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Генерация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(161, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 8;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Статистика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(286, 77);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(365, 300);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.P});
            this.dataGridView1.Location = new System.Drawing.Point(15, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 99);
            this.dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Задать вероятности:";
            // 
            // N
            // 
            this.N.HeaderText = "Название";
            this.N.Name = "N";
            // 
            // P
            // 
            this.P.HeaderText = "Вероятность";
            this.P.Name = "P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 385);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Имитация случайных событий";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имитацияСлучайногоСобытияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имитацияСложногоСобытияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имитацияСложногоСобытияСостоящегоИзЗависимыхСобытийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имитацияСобытийСоставляющихПолнуюГруппуToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
    }
}

