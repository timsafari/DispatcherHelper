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
            this.редакторМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСоединенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытыеСоединенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторКомандToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таймерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редакторМенюToolStripMenuItem,
            this.соединенияToolStripMenuItem1,
            this.редакторКомандToolStripMenuItem,
            this.таймерыToolStripMenuItem,
            this.справкаToolStripMenuItem});
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
            // редакторМенюToolStripMenuItem
            // 
            this.редакторМенюToolStripMenuItem.Name = "редакторМенюToolStripMenuItem";
            this.редакторМенюToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.редакторМенюToolStripMenuItem.Text = "Редактор меню";
            this.редакторМенюToolStripMenuItem.Click += new System.EventHandler(this.редакторМенюToolStripMenuItem_Click);
            // 
            // соединенияToolStripMenuItem1
            // 
            this.соединенияToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСоединенийToolStripMenuItem,
            this.открытыеСоединенияToolStripMenuItem});
            this.соединенияToolStripMenuItem1.Name = "соединенияToolStripMenuItem1";
            this.соединенияToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.соединенияToolStripMenuItem1.Text = "Соединения";
            // 
            // списокСоединенийToolStripMenuItem
            // 
            this.списокСоединенийToolStripMenuItem.Name = "списокСоединенийToolStripMenuItem";
            this.списокСоединенийToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.списокСоединенийToolStripMenuItem.Text = "Список соединений";
            this.списокСоединенийToolStripMenuItem.Click += new System.EventHandler(this.списокСоединенийToolStripMenuItem_Click);
            // 
            // открытыеСоединенияToolStripMenuItem
            // 
            this.открытыеСоединенияToolStripMenuItem.Name = "открытыеСоединенияToolStripMenuItem";
            this.открытыеСоединенияToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.открытыеСоединенияToolStripMenuItem.Text = "Открытые соединения";
            // 
            // редакторКомандToolStripMenuItem
            // 
            this.редакторКомандToolStripMenuItem.Name = "редакторКомандToolStripMenuItem";
            this.редакторКомандToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.редакторКомандToolStripMenuItem.Text = "Редактор команд";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // таймерыToolStripMenuItem
            // 
            this.таймерыToolStripMenuItem.Name = "таймерыToolStripMenuItem";
            this.таймерыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таймерыToolStripMenuItem.Text = "Таймеры";
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
        private System.Windows.Forms.ToolStripMenuItem редакторМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторКомандToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокСоединенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытыеСоединенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таймерыToolStripMenuItem;
    }
}

