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
    public partial class Menu_Editor : Form
    {

        IntPtr active_obj_handler = new IntPtr();
        string active_obj_type = "";

        public Menu_Editor()
        {
            InitializeComponent();
        }

        private void lbl_SQL_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pnl_menu_scheme_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbl_SQL_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnl_menu_scheme_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lbl_SQL_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.PictureBox shape;
            shape = new System.Windows.Forms.PictureBox();
            shape.Parent = pnl_menu_scheme;
            shape.Left = 10;
            shape.Top = 10;
            shape.Image = Properties.Resources.SQL_Command;
            active_obj_handler = shape.Handle;
            active_obj_type = "SQL";            
        }

        private void pnl_menu_scheme_MouseClick(object sender, MouseEventArgs e)
        {
            if ((active_obj_handler != null) && (active_obj_type != ""))
            {                
                Command_Editor cmd_editor = new Command_Editor(active_obj_type);
                active_obj_handler = (IntPtr)null;
                active_obj_type = "";
                cmd_editor.ShowDialog();
            }
        }

        private void pnl_menu_scheme_MouseMove(object sender, MouseEventArgs e)
        {
            if ((active_obj_handler != null) && (active_obj_type != ""))
            {                
                Control rb = Control.FromHandle(active_obj_handler);
                rb.Left = e.X+20;
                rb.Top = e.Y-20;
            }
        }

        private void lbl_PS_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox shape;
            shape = new System.Windows.Forms.PictureBox();
            shape.Parent = pnl_menu_scheme;
            shape.Left = 10;
            shape.Top = 10;
            shape.Image = Properties.Resources.PS_command;
            active_obj_handler = shape.Handle;
            active_obj_type = "PowerShell";
        }
    }
}
