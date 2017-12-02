using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace SPS_Helper
{
    public partial class EntryPoint : Form
    {

        public EntryPoint()
        {
            InitializeComponent();
        }

        private void Подписки_на_отчеты_Click(object sender, EventArgs e)
        {

        }

        private void Подписки_на_отчеты_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Rows.Clear();

            int ConnID = Connections.OpenConnection/*Async*/("Data Source=AS-MSK-N0203\\CONTENT;Initial Catalog=ReportingService_test2DB;Integrated Security=SSPI;");

            using (DataGridView dgv = SqlCommands.ExecuteSQLCommand(ConnID, "GetReports", true))
            {
                int rownumber = 0;
                for (int i = 0; i < dgv.Columns.Count; i++)
                    dataGridView1.Columns.Add(dgv.Columns[i].Name, dgv.Columns[i].Name);
                for (int j = 0; j < dgv.RowCount; j++)
                {
                    rownumber = dataGridView1.Rows.Add();
                    for (int k = 0; k < dgv.Columns.Count; k++)
                        dataGridView1.Rows[rownumber].Cells[k].Value = dgv.Rows[rownumber].Cells[k].Value;
                }

            }
            dataGridView1.Refresh();

        }

        private void EntryPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connections.CloseConnection(0);
        }

        private void Подписки_на_отчеты_Rep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.Rows.Clear();

            int ConnID = Connections.OpenConnection/*Async*/("Data Source=AS-MSK-N0131;Initial Catalog=ReportServer;Integrated Security=SSPI;");

            using (DataGridView dgv = SqlCommands.ExecuteSQLCommand(ConnID, "GetReports", true))
            {
                int rownumber = 0;
                for (int i = 0; i < dgv.Columns.Count; i++)
                    dataGridView1.Columns.Add(dgv.Columns[i].Name, dgv.Columns[i].Name);
                for (int j = 0; j < dgv.RowCount; j++)
                {
                    rownumber = dataGridView1.Rows.Add();
                    for (int k = 0; k < dgv.Columns.Count; k ++)
                        dataGridView1.Rows[rownumber].Cells[k].Value = dgv.Rows[rownumber].Cells[k].Value;
                }
                    
            }
            dataGridView1.Refresh();
        }

        private void EntryPoint_Load(object sender, EventArgs e)
        {
            SqlCommands.Initialize();
        }
    }
}
