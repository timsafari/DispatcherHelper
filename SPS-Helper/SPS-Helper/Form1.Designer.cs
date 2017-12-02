namespace SPS_Helper
{
    partial class EntryPoint
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
            this.Стартовые_точки = new System.Windows.Forms.Panel();
            this.Подписки_на_отчеты_native = new System.Windows.Forms.LinkLabel();
            this.Подписки_на_отчеты_SPS = new System.Windows.Forms.LinkLabel();
            this.Навигация = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Стартовые_точки.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Стартовые_точки
            // 
            this.Стартовые_точки.Controls.Add(this.Подписки_на_отчеты_native);
            this.Стартовые_точки.Controls.Add(this.Подписки_на_отчеты_SPS);
            this.Стартовые_точки.Dock = System.Windows.Forms.DockStyle.Left;
            this.Стартовые_точки.Location = new System.Drawing.Point(0, 0);
            this.Стартовые_точки.Name = "Стартовые_точки";
            this.Стартовые_точки.Size = new System.Drawing.Size(186, 593);
            this.Стартовые_точки.TabIndex = 0;
            // 
            // Подписки_на_отчеты_native
            // 
            this.Подписки_на_отчеты_native.AutoSize = true;
            this.Подписки_на_отчеты_native.Location = new System.Drawing.Point(4, 39);
            this.Подписки_на_отчеты_native.Name = "Подписки_на_отчеты_native";
            this.Подписки_на_отчеты_native.Size = new System.Drawing.Size(142, 13);
            this.Подписки_на_отчеты_native.TabIndex = 1;
            this.Подписки_на_отчеты_native.TabStop = true;
            this.Подписки_на_отчеты_native.Text = "Подписки на отчеты native";
            this.Подписки_на_отчеты_native.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Подписки_на_отчеты_Rep_LinkClicked);
            // 
            // Подписки_на_отчеты_SPS
            // 
            this.Подписки_на_отчеты_SPS.AutoSize = true;
            this.Подписки_на_отчеты_SPS.Location = new System.Drawing.Point(4, 4);
            this.Подписки_на_отчеты_SPS.Name = "Подписки_на_отчеты_SPS";
            this.Подписки_на_отчеты_SPS.Size = new System.Drawing.Size(168, 13);
            this.Подписки_на_отчеты_SPS.TabIndex = 0;
            this.Подписки_на_отчеты_SPS.TabStop = true;
            this.Подписки_на_отчеты_SPS.Text = "Подписки на отчеты_SharePoint";
            this.Подписки_на_отчеты_SPS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Подписки_на_отчеты_LinkClicked);
            // 
            // Навигация
            // 
            this.Навигация.Dock = System.Windows.Forms.DockStyle.Top;
            this.Навигация.Location = new System.Drawing.Point(186, 0);
            this.Навигация.Name = "Навигация";
            this.Навигация.Size = new System.Drawing.Size(736, 26);
            this.Навигация.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(186, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 567);
            this.dataGridView1.TabIndex = 2;
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Навигация);
            this.Controls.Add(this.Стартовые_точки);
            this.Name = "EntryPoint";
            this.Text = "SharePointServices Reporting Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryPoint_FormClosing);
            this.Load += new System.EventHandler(this.EntryPoint_Load);
            this.Стартовые_точки.ResumeLayout(false);
            this.Стартовые_точки.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Стартовые_точки;
        private System.Windows.Forms.LinkLabel Подписки_на_отчеты_SPS;
        private System.Windows.Forms.Panel Навигация;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel Подписки_на_отчеты_native;
    }
}

