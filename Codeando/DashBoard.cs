using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Codeando.Presentation
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close unicamente temporal en lo que se hace un Front más decente (Esto no es necesariamente la mejor opción)
            Application.Exit();
        }
    }
}
