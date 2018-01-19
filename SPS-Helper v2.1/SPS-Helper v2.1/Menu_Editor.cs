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
            System.Windows.Forms.RadioButton radioButton_n;
            radioButton_n = new System.Windows.Forms.RadioButton();
            radioButton_n.Parent = pnl_menu_scheme;
            radioButton_n.Left = 10;
            radioButton_n.Top = 10;
            active_obj_handler = radioButton_n.Handle;
            active_obj_type = "rb";            
        }

        private void pnl_menu_scheme_MouseClick(object sender, MouseEventArgs e)
        {
            if ((active_obj_handler != null) && (active_obj_type == "rb"))
            {
                active_obj_handler = (IntPtr)null;
                active_obj_type = "";
            }
        }

        private void pnl_menu_scheme_MouseMove(object sender, MouseEventArgs e)
        {
            if ((active_obj_handler != null) && (active_obj_type == "rb"))
            {                
                Control rb = Control.FromHandle(active_obj_handler);
                rb.Left = e.X+20;
                rb.Top = e.Y-20;
            }
        }

        public void radioButton_n_MouseClick()
        {
            MessageBox.Show("Клик");
        }
    }
}
