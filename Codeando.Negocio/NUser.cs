using Codeando.Datos;
using Codeando.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codeando.Negocio
{
    public class NUser
    {
        public bool verificarUsuario (string nombreUsuario, string contraseña)
        {
            try
            {
                User usuario = new User(nombreUsuario, contraseña);
                DUser usuarioDatos = new DUser();

                return usuarioDatos.verificarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            //hola
        }
    }
}
