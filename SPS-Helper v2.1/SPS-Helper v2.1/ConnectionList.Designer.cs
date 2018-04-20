namespace SPS_Helper
{
    partial class ConnectionList
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
            this.ConnectionTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionTable
            // 
            this.ConnectionTable.AccessibleName = "ConnectionTable";
            this.ConnectionTable.AllowUserToAddRows = false;
            this.ConnectionTable.AllowUserToDeleteRows = false;
            this.ConnectionTable.AllowUserToOrderColumns = true;
            this.ConnectionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ConnectionString,
            this.State,
            this.CommandCount});
            this.ConnectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConnectionTable.Location = new System.Drawing.Point(0, 0);
            this.ConnectionTable.Name = "ConnectionTable";
            this.ConnectionTable.ReadOnly = true;
            this.ConnectionTable.Size = new System.Drawing.Size(887, 509);
            this.ConnectionTable.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ConnectionString
            // 
            this.ConnectionString.HeaderText = "Строка соединения";
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.ReadOnly = true;
            this.ConnectionString.Width = 500;
            // 
            // State
            // 
            this.State.HeaderText = "Состояние";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // CommandCount
            // 
            this.CommandCount.HeaderText = "Количество команд, использующих соединение";
            this.CommandCount.Name = "CommandCount";
            this.CommandCount.ReadOnly = true;
            // 
            // ConnectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 509);
            this.Controls.Add(this.ConnectionTable);
            this.Name = "ConnectionList";
            this.Text = "ConnectionList";
            this.Load += new System.EventHandler(this.ConnectionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConnectionTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionString;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandCount;
    }
}