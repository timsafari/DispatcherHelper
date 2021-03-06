﻿namespace SPS_Helper
{
    partial class Menu_Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Screen = new System.Windows.Forms.Label();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.lbl_PS = new System.Windows.Forms.Label();
            this.lbl_MDX_command = new System.Windows.Forms.Label();
            this.lbl_SQL = new System.Windows.Forms.Label();
            this.pnl_menu_scheme = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Screen);
            this.groupBox1.Controls.Add(this.lbl_Link);
            this.groupBox1.Controls.Add(this.lbl_Menu);
            this.groupBox1.Controls.Add(this.lbl_PS);
            this.groupBox1.Controls.Add(this.lbl_MDX_command);
            this.groupBox1.Controls.Add(this.lbl_SQL);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы";
            // 
            // lbl_Screen
            // 
            this.lbl_Screen.AutoSize = true;
            this.lbl_Screen.Location = new System.Drawing.Point(17, 141);
            this.lbl_Screen.Name = "lbl_Screen";
            this.lbl_Screen.Size = new System.Drawing.Size(38, 13);
            this.lbl_Screen.TabIndex = 5;
            this.lbl_Screen.Text = "Экран";
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Location = new System.Drawing.Point(17, 116);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(38, 13);
            this.lbl_Link.TabIndex = 4;
            this.lbl_Link.Text = "Связь";
            this.lbl_Link.Click += new System.EventHandler(this.lbl_Link_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(17, 94);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(68, 13);
            this.lbl_Menu.TabIndex = 3;
            this.lbl_Menu.Text = "Пункт меню";
            // 
            // lbl_PS
            // 
            this.lbl_PS.AutoSize = true;
            this.lbl_PS.Location = new System.Drawing.Point(17, 69);
            this.lbl_PS.Name = "lbl_PS";
            this.lbl_PS.Size = new System.Drawing.Size(107, 13);
            this.lbl_PS.TabIndex = 2;
            this.lbl_PS.Text = "PowerShell-команда";
            this.lbl_PS.Click += new System.EventHandler(this.lbl_PS_Click);
            // 
            // lbl_MDX_command
            // 
            this.lbl_MDX_command.AutoSize = true;
            this.lbl_MDX_command.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_MDX_command.Location = new System.Drawing.Point(17, 44);
            this.lbl_MDX_command.Name = "lbl_MDX_command";
            this.lbl_MDX_command.Size = new System.Drawing.Size(78, 13);
            this.lbl_MDX_command.TabIndex = 1;
            this.lbl_MDX_command.Text = "MDX-команда";
            this.lbl_MDX_command.Click += new System.EventHandler(this.lbl_MDX_command_Click);
            // 
            // lbl_SQL
            // 
            this.lbl_SQL.AutoSize = true;
            this.lbl_SQL.Location = new System.Drawing.Point(17, 20);
            this.lbl_SQL.Name = "lbl_SQL";
            this.lbl_SQL.Size = new System.Drawing.Size(75, 13);
            this.lbl_SQL.TabIndex = 0;
            this.lbl_SQL.Text = "SQL-команда";
            this.lbl_SQL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_SQL_MouseClick);
            // 
            // pnl_menu_scheme
            // 
            this.pnl_menu_scheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_menu_scheme.Location = new System.Drawing.Point(159, 0);
            this.pnl_menu_scheme.Name = "pnl_menu_scheme";
            this.pnl_menu_scheme.Size = new System.Drawing.Size(644, 490);
            this.pnl_menu_scheme.TabIndex = 1;
            this.pnl_menu_scheme.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_scheme_Paint);
            this.pnl_menu_scheme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_menu_scheme_MouseClick);
            this.pnl_menu_scheme.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_menu_scheme_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 490);
            this.Controls.Add(this.pnl_menu_scheme);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu_Editor";
            this.Text = "Menu_Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Screen;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Label lbl_PS;
        private System.Windows.Forms.Label lbl_MDX_command;
        private System.Windows.Forms.Label lbl_SQL;
        private System.Windows.Forms.Panel pnl_menu_scheme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}