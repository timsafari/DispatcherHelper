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

        static IntPtr active_obj_handler = new IntPtr();
        static string active_obj_type = "";
        public static List<IntPtr> obj_handlers;

        public Menu_Editor()
        {
            InitializeComponent();
        }

        

        public class Shape : System.Windows.Forms.PictureBox
        {
            public string objectType = "";
            public bool IsSelected = false;

            private static void InitializeComponent()
            {

            }

            static Shape()
            {
                Shape.InitializeComponent();
            }

            public Shape(string Type,Control Parent)
            {
                InitializeComponent();
                Left = 10;
                Top = 10;
                obj_handlers.Add(this.Handle);
                switch (Type)
                {
                    case "SQL":
                        Image = Properties.Resources.SQL_Command;
                        break;
                    case "PowerShell":
                        Image = Properties.Resources.PS_Command;
                        break;
                    case "MDX":
                        Image = Properties.Resources.MDX_Command;
                        break;            
                }

                this.BorderStyle = BorderStyle.FixedSingle;
                this.Parent = Parent;
                
                this.Click += new System.EventHandler(Shape_Click);

                active_obj_handler = this.Handle;
                active_obj_type = Type;

            }

            private void Shape_Click(object sender, EventArgs e)
            {
                IsSelected = !IsSelected;

                switch(IsSelected)
                {
                    case true:
                        this.BorderStyle = BorderStyle.Fixed3D;
                        break;
                    case false:
                        this.BorderStyle = BorderStyle.FixedSingle;
                        break;
                }
                            
            }

            private void Shape_Destroy(object sender, EventArgs e)
            {
                obj_handlers.Remove(Handle);
                Shape.Destroy();
            }

        }




        private void lbl_SQL_MouseClick(object sender, MouseEventArgs e)
        {
            Shape shape;
            shape = new Shape("SQL", pnl_menu_scheme);         
                      
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
            Shape shape;
            shape = new Shape("PowerShell", pnl_menu_scheme);
        }

        private void lbl_MDX_command_Click(object sender, EventArgs e)
        {
            Shape shape;
            shape = new Shape("MDX", pnl_menu_scheme);
        }
    }
}
