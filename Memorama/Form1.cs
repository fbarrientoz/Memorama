using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void widow_cover_1_Click(object sender, EventArgs e)
        {
            widow_cover_1.Visible = false;
            widow_1.Visible = true;
        
        }
    }
}
