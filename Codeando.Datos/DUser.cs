using Codeando.Entidad;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Codeando.Datos
{
    public class DUser
    {
        public bool verificarUsuario (User Usuario)
        {
            try
            {
                using var conexion = new Conexion().crearConexion();

                int resultado = conexion.QuerySingle<int>(
                    "verificar_usuario",
                    new
                    {
                        nombreUsuario = Usuario.username,
                        contraseña = Usuario.password
                    },
                    commandType: CommandType.StoredProcedure
                    );

                return resultado == 1;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
