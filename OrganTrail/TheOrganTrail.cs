using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganTrail
{
    public partial class TheOrganTrail : Form
    {
        public TheOrganTrail()
        {
            InitializeComponent();

        }

        private void txtChoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar; 
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        private void TheOrganTrail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTest.Text = "Key Pressed: " + e.KeyChar;
        }
       
        
    }
}
