namespace SPS_Helper
{
    partial class _frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторКомандToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.соединенияToolStripMenuItem,
            this.редакторМенюToolStripMenuItem,
            this.редакторКомандToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // соединенияToolStripMenuItem
            // 
            this.соединенияToolStripMenuItem.Name = "соединенияToolStripMenuItem";
            this.соединенияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.соединенияToolStripMenuItem.Text = "Соединения";
            // 
            // редакторМенюToolStripMenuItem
            // 
            this.редакторМенюToolStripMenuItem.Name = "редакторМенюToolStripMenuItem";
            this.редакторМенюToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.редакторМенюToolStripMenuItem.Text = "Редактор меню";
            this.редакторМенюToolStripMenuItem.Click += new System.EventHandler(this.редакторМенюToolStripMenuItem_Click);
            // 
            // редакторКомандToolStripMenuItem
            // 
            this.редакторКомандToolStripMenuItem.Name = "редакторКомандToolStripMenuItem";
            this.редакторКомандToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.редакторКомандToolStripMenuItem.Text = "Редактор команд";
            // 
            // _frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 617);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_frm_Menu";
            this.Text = "SPS-Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this._frm_Menu_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторКомандToolStripMenuItem;
    }
}

