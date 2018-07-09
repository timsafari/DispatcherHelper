using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Helper
{
    public partial class Command_Editor : Form
    {
        public Command_Editor()
        {
            InitializeComponent();
        }


        public Command_Editor(string cb_selected_command)
        {
            InitializeComponent();
            cb_comm_type.SelectedItem = cb_selected_command;
        }
        

        private void cb_comm_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_check_command_Click(object sender, EventArgs e)
        {
            if (chb_Use_Conn_Str.Checked)
            {

            }
            else
            {

            }
        }
    }
}
