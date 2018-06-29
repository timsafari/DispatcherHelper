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
            this.cb_comm_type = new System.Windows.Forms.ComboBox();
            this.lbl_comm_type = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_comm_text = new System.Windows.Forms.Label();
            this.btn_check_command = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВыполнитьКоманду = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КакПараметр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПравилоПреобразования = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Write = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_comm_type
            // 
            this.cb_comm_type.FormattingEnabled = true;
            this.cb_comm_type.Items.AddRange(new object[] {
            "",
            "SQL",
            "MDX",
            "PowerShell"});
            this.cb_comm_type.Location = new System.Drawing.Point(94, 10);
            this.cb_comm_type.Name = "cb_comm_type";
            this.cb_comm_type.Size = new System.Drawing.Size(65, 21);
            this.cb_comm_type.TabIndex = 0;
            this.cb_comm_type.SelectedIndexChanged += new System.EventHandler(this.cb_comm_type_SelectedIndexChanged);
            // 
            // lbl_comm_type
            // 
            this.lbl_comm_type.AutoSize = true;
            this.lbl_comm_type.Location = new System.Drawing.Point(13, 13);
            this.lbl_comm_type.Name = "lbl_comm_type";
            this.lbl_comm_type.Size = new System.Drawing.Size(75, 13);
            this.lbl_comm_type.TabIndex = 1;
            this.lbl_comm_type.Text = "Тип команды";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(585, 280);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // lbl_comm_text
            // 
            this.lbl_comm_text.AutoSize = true;
            this.lbl_comm_text.Location = new System.Drawing.Point(16, 34);
            this.lbl_comm_text.Name = "lbl_comm_text";
            this.lbl_comm_text.Size = new System.Drawing.Size(52, 13);
            this.lbl_comm_text.TabIndex = 3;
            this.lbl_comm_text.Text = "Команда";
            // 
            // btn_check_command
            // 
            this.btn_check_command.Location = new System.Drawing.Point(464, 339);
            this.btn_check_command.Name = "btn_check_command";
            this.btn_check_command.Size = new System.Drawing.Size(137, 23);
            this.btn_check_command.TabIndex = 4;
            this.btn_check_command.Text = "Проверить";
            this.btn_check_command.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.ВыполнитьКоманду,
            this.КакПараметр,
            this.ПравилоПреобразования});
            this.dataGridView1.Location = new System.Drawing.Point(16, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 228);
            this.dataGridView1.TabIndex = 5;
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
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(464, 604);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(137, 23);
            this.btn_Write.TabIndex = 6;
            this.btn_Write.Text = "Записать";
            this.btn_Write.UseVisualStyleBackColor = true;
            // 
            // Command_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 629);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_check_command);
            this.Controls.Add(this.lbl_comm_text);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_comm_type);
            this.Controls.Add(this.cb_comm_type);
            this.Name = "Command_Editor";
            this.Text = "Command_Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_comm_type;
        private System.Windows.Forms.Label lbl_comm_type;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_comm_text;
        private System.Windows.Forms.Button btn_check_command;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВыполнитьКоманду;
        private System.Windows.Forms.DataGridViewTextBoxColumn КакПараметр;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПравилоПреобразования;
        private System.Windows.Forms.Button btn_Write;
    }
}