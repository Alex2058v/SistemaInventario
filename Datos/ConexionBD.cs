using Microsoft.Data.SqlClient;

namespace SistemaInventario.Datos
{
    public static class ConexionBD
    {
        // Si se usa SQL Server Express
        // @"Server=.\SQLEXPRESS;Database=SistemaInventario;Trusted_Connection=True;TrustServerCertificate=True;"
        private const string CadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=SistemaInventario;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
