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
        public static List<IntPtr> obj_handlers = new List<IntPtr>();
        public static bool link_mode = false;
        public static int linked_objects_count = 0;
        public static IntPtr link_source_handler = new IntPtr();
        public static IntPtr link_dest_handler = new IntPtr();

        public Menu_Editor()
        {
            InitializeComponent();
        }

        private static void Draw_Link(IntPtr Source_Object, IntPtr Dest_Object, PaintEventArgs e)
        {
            //paint the line between objects
            MessageBox.Show("Из X=" + FromHandle(link_source_handler).Bounds.Left.ToString() + ",Y=" + FromHandle(link_source_handler).Bounds.Top + " в X=" + FromHandle(link_source_handler).Bounds.Right.ToString() + ", Y=" + FromHandle(link_source_handler).Bounds.Bottom.ToString(), "Координаты точек");
            Pen SomePen = new Pen(Brushes.Black);
            SomePen.Width = 12.0F;
            MessageBox.Show(e.Graphics.IsClipEmpty.ToString(), "IsClipEmpty");
            e.Graphics.DrawLine(SomePen, FromHandle(link_source_handler).Bounds.Left, FromHandle(link_source_handler).Bounds.Top, FromHandle(link_source_handler).Bounds.Right, FromHandle(link_source_handler).Bounds.Bottom);

            //Dispose of the pen.
            SomePen.Dispose();
            link_source_handler = new IntPtr();
            link_dest_handler = new IntPtr();
            link_mode = false;
            Menu_Editor.ActiveForm.Cursor = Cursors.Default;
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
                if (link_mode)
                {
                    IsSelected = !IsSelected;

                    switch (IsSelected)
                    {
                        case true:
                            this.BorderStyle = BorderStyle.Fixed3D;
                            if (linked_objects_count == 0)
                            {
                                link_source_handler = this.Handle;
                                linked_objects_count = linked_objects_count + 1;
                                break;
                            }
                            if (linked_objects_count == 1)
                            {
                                link_dest_handler = this.Handle;
                                linked_objects_count = linked_objects_count + 1;

                                
                                break;
                            }
                            break;
                        case false:
                            this.BorderStyle = BorderStyle.FixedSingle;
                            if (linked_objects_count == 1)
                            {
                                link_source_handler = IntPtr.Zero;
                                linked_objects_count = linked_objects_count - 1;

                            }
                            if (linked_objects_count == 2)
                            {
                                link_dest_handler = IntPtr.Zero;
                                linked_objects_count = linked_objects_count - 1;
                            }
                            break;
                    }
                }         
            }

            private void Shape_Destroy(object sender, EventArgs e)
            {
                obj_handlers.Remove(Handle);
                //Shape.Destroy;
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

        private void lbl_Link_Click(object sender, EventArgs e)
        {
            if (obj_handlers.Capacity >= 2)
            {
                link_mode = true;
                this.Cursor = Cursors.Cross;
            }
        }

        private void pnl_menu_scheme_Paint(object sender, PaintEventArgs e)
        {
            if (obj_handlers.Capacity >= 2 && link_source_handler.ToString() != "0" && link_dest_handler.ToString() != "0")
            {
                MessageBox.Show("obj_handlers.Capacity = " + obj_handlers.Capacity.ToString() + "; link_source_handler = " + link_source_handler.ToString() + "; link_dest_handler = " + link_dest_handler.ToString(), "pnl_menu_scheme_Paint");
                Menu_Editor.Draw_Link(link_source_handler, link_dest_handler, e);
            }
        }
    }
}
