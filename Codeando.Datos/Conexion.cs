using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codeando.Datos
{
    public class Conexion
    {
        private readonly string cadenaConexion;
        private string Servidor;
        private string Base;
        private string Usuario;
        private string Password;
        private bool SeguridadIntegrada;
        private bool ConfiarCertificado;

        public Conexion ()
        {
            Servidor = "servidor-nuevo.database.windows.net";
            Base = "dbCodeando";
            Password = "\\6jLJV4r71yF";
            Usuario = "KANYELAPARA";
            SeguridadIntegrada = false;
            ConfiarCertificado = true;

            this.cadenaConexion = new SqlConnectionStringBuilder
            {
                DataSource = Servidor,
                InitialCatalog = Base,
                IntegratedSecurity = SeguridadIntegrada,
                UserID = Usuario,
                Password = Password,
                TrustServerCertificate = ConfiarCertificado
            }.ConnectionString;
        }

        public SqlConnection crearConexion ()
        {
            try
            {
                return new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
