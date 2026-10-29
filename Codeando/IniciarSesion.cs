using Codeando.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Codeando.Presentation
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        #region variables globales
        SoundPlayer sonidoMinecraft = new SoundPlayer(
                "C:\\Sonidos Codeando\\minecraft-click_HRhlZ0U6.wav"
                );
        #endregion

        #region Metodos

        private void mensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void abrirFormulario(Form form)
        {
            form.Show();
            this.Hide();
        }
        private async void verificarUsuario()
        {
            var usuario = new NUser();
            bool existe = usuario.verificarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (existe)
            {
                DashBoard dashBoard = new DashBoard();
                await Task.Delay(1);
                abrirFormulario(dashBoard);
            }

            else
            {
                mensajeError("Datos incorrectos, intente nuevamente.");
            }
        }

        public void EmitirSonidoMinecraft()
        {
            sonidoMinecraft.Play();
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmitirSonidoMinecraft();
            verificarUsuario();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Está seguro de que desea salir?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
