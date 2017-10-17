namespace Lab3
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
            this.z1 = new ZedGraph.ZedGraphControl();
            this.z2 = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // z1
            // 
            this.z1.IsShowPointValues = false;
            this.z1.Location = new System.Drawing.Point(12, 12);
            this.z1.Name = "z1";
            this.z1.PointValueFormat = "G";
            this.z1.Size = new System.Drawing.Size(375, 381);
            this.z1.TabIndex = 1;
            // 
            // z2
            // 
            this.z2.IsShowPointValues = false;
            this.z2.Location = new System.Drawing.Point(595, 12);
            this.z2.Name = "z2";
            this.z2.PointValueFormat = "G";
            this.z2.Size = new System.Drawing.Size(375, 381);
            this.z2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Демонстрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl z1;
        private ZedGraph.ZedGraphControl z2;
        private System.Windows.Forms.Button button1;
    }
}

