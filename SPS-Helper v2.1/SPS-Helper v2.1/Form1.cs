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
            SQLCommand s = new SQLCommand();
            Core.Initialize();
            //s.Load("C:\\temp\\tezzt.txt");
        }
    }
}
