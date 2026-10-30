using Codeando.Negocio;
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

        #region metodos

        public void ponerTextoCodigo (string codigo)
        {
            NCompilacion compilador = new NCompilacion();
            txtConsola.Text = compilador.Compilar(codigo);
        }


        #endregion

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ponerTextoCodigo(txtCodigo.Text);
        }
    }
}
