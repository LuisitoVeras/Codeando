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
        private bool SeguridadIntegrada;
        private bool ConfiarCertificado;

        public Conexion ()
        {
            Servidor = "MSI\\SQLEXPRESS";
            Base = "dbCodeando";
            SeguridadIntegrada = true;
            ConfiarCertificado = true;

            this.cadenaConexion = new SqlConnectionStringBuilder
            {
                DataSource = Servidor,
                InitialCatalog = Base,
                IntegratedSecurity = SeguridadIntegrada,
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
