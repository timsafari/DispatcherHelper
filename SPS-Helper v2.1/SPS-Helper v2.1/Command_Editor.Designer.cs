namespace SPS_Helper
{
    partial class Command_Editor
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
            this.pnl_Result_Actions = new System.Windows.Forms.Panel();
            this.btn_Write = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВыполнитьКоманду = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КакПараметр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПравилоПреобразования = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Command_Type = new System.Windows.Forms.Panel();
            this.lbl_comm_type = new System.Windows.Forms.Label();
            this.cb_comm_type = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_Use_Conn_Str = new System.Windows.Forms.CheckBox();
            this.lbl_Conn_Str = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_check_command = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnl_Result_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_Command_Type.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Result_Actions
            // 
            this.pnl_Result_Actions.Controls.Add(this.btn_Write);
            this.pnl_Result_Actions.Controls.Add(this.dataGridView1);
            this.pnl_Result_Actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Result_Actions.Location = new System.Drawing.Point(0, 366);
            this.pnl_Result_Actions.Name = "pnl_Result_Actions";
            this.pnl_Result_Actions.Size = new System.Drawing.Size(613, 263);
            this.pnl_Result_Actions.TabIndex = 10;
            // 
            // btn_Write
            // 
            this.btn_Write.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Write.Location = new System.Drawing.Point(460, 235);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(137, 23);
            this.btn_Write.TabIndex = 8;
            this.btn_Write.Text = "Записать";
            this.btn_Write.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.ВыполнитьКоманду,
            this.КакПараметр,
            this.ПравилоПреобразования});
            this.dataGridView1.Location = new System.Drawing.Point(16, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 228);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Столбец";
            this.Column_name.Name = "Column_name";
            this.Column_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ВыполнитьКоманду
            // 
            this.ВыполнитьКоманду.HeaderText = "Выполнить команду";
            this.ВыполнитьКоманду.Name = "ВыполнитьКоманду";
            // 
            // КакПараметр
            // 
            this.КакПараметр.HeaderText = "Номер параметра";
            this.КакПараметр.Name = "КакПараметр";
            // 
            // ПравилоПреобразования
            // 
            this.ПравилоПреобразования.HeaderText = "Правило преобразования";
            this.ПравилоПреобразования.Name = "ПравилоПреобразования";
            // 
            // pnl_Command_Type
            // 
            this.pnl_Command_Type.Controls.Add(this.lbl_comm_type);
            this.pnl_Command_Type.Controls.Add(this.cb_comm_type);
            this.pnl_Command_Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Command_Type.Location = new System.Drawing.Point(0, 0);
            this.pnl_Command_Type.Name = "pnl_Command_Type";
            this.pnl_Command_Type.Size = new System.Drawing.Size(613, 34);
            this.pnl_Command_Type.TabIndex = 11;
            // 
            // lbl_comm_type
            // 
            this.lbl_comm_type.AutoSize = true;
            this.lbl_comm_type.Location = new System.Drawing.Point(3, 9);
            this.lbl_comm_type.Name = "lbl_comm_type";
            this.lbl_comm_type.Size = new System.Drawing.Size(75, 13);
            this.lbl_comm_type.TabIndex = 3;
            this.lbl_comm_type.Text = "Тип команды";
            // 
            // cb_comm_type
            // 
            this.cb_comm_type.FormattingEnabled = true;
            this.cb_comm_type.Items.AddRange(new object[] {
            "",
            "SQL",
            "MDX",
            "PowerShell"});
            this.cb_comm_type.Location = new System.Drawing.Point(84, 6);
            this.cb_comm_type.Name = "cb_comm_type";
            this.cb_comm_type.Size = new System.Drawing.Size(65, 21);
            this.cb_comm_type.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_Use_Conn_Str);
            this.groupBox1.Controls.Add(this.lbl_Conn_Str);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_check_command);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 332);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команда";
            // 
            // chb_Use_Conn_Str
            // 
            this.chb_Use_Conn_Str.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_Use_Conn_Str.AutoSize = true;
            this.chb_Use_Conn_Str.Location = new System.Drawing.Point(443, 310);
            this.chb_Use_Conn_Str.Name = "chb_Use_Conn_Str";
            this.chb_Use_Conn_Str.Size = new System.Drawing.Size(15, 14);
            this.chb_Use_Conn_Str.TabIndex = 14;
            this.chb_Use_Conn_Str.UseVisualStyleBackColor = true;
            // 
            // lbl_Conn_Str
            // 
            this.lbl_Conn_Str.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Conn_Str.AutoSize = true;
            this.lbl_Conn_Str.Location = new System.Drawing.Point(16, 310);
            this.lbl_Conn_Str.Name = "lbl_Conn_Str";
            this.lbl_Conn_Str.Size = new System.Drawing.Size(106, 13);
            this.lbl_Conn_Str.TabIndex = 13;
            this.lbl_Conn_Str.Text = "Строка соединения";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btn_check_command
            // 
            this.btn_check_command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_command.Location = new System.Drawing.Point(464, 305);
            this.btn_check_command.Name = "btn_check_command";
            this.btn_check_command.Size = new System.Drawing.Size(137, 23);
            this.btn_check_command.TabIndex = 11;
            this.btn_check_command.Text = "Проверить";
            this.btn_check_command.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(585, 280);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Command_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_Command_Type);
            this.Controls.Add(this.pnl_Result_Actions);
            this.Name = "Command_Editor";
            this.Text = "Command_Editor";
            this.pnl_Result_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_Command_Type.ResumeLayout(false);
            this.pnl_Command_Type.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Result_Actions;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВыполнитьКоманду;
        private System.Windows.Forms.DataGridViewTextBoxColumn КакПараметр;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПравилоПреобразования;
        private System.Windows.Forms.Panel pnl_Command_Type;
        private System.Windows.Forms.Label lbl_comm_type;
        private System.Windows.Forms.ComboBox cb_comm_type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_Use_Conn_Str;
        private System.Windows.Forms.Label lbl_Conn_Str;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_check_command;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}