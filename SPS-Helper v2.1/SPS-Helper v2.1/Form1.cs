using SPS_Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SPS_Helper
{
    public partial class _frm_Menu : Form
    {
        public _frm_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void _frm_Menu_Click(object sender, EventArgs e)
        {
            object[] args = new object[1];
            args[0] = "some path";
            Errors.ShowByCode_Dialog(-6, args);
        }

        private void редакторМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Menu_Editor();
            a.Show();
        }
    }
}
