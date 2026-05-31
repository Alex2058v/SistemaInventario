using Microsoft.Data.SqlClient;
using SistemaInventario.Datos;
using SistemaInventario.Modelos;
using System.Data;

namespace SistemaInventario.Repositorios
{
    public class ProductoRepositorio
    {
        public DataTable ObtenerTodos()
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand("SELECT Id, Nombre, Precio, Stock FROM Productos ORDER BY Id", conexion);
            using var adaptador = new SqlDataAdapter(comando);
            var tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public DataTable Buscar(string filtro)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand(@"
                SELECT Id, Nombre, Precio, Stock
                FROM Productos
                WHERE Nombre LIKE @Filtro OR CAST(Id AS VARCHAR(20)) LIKE @Filtro
                ORDER BY Id", conexion);
            comando.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

            using var adaptador = new SqlDataAdapter(comando);
            var tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public void Agregar(Producto producto)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand(@"
                INSERT INTO Productos (Nombre, Precio, Stock)
                VALUES (@Nombre, @Precio, @Stock)", conexion);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);

            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void Actualizar(Producto producto)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand(@"
                UPDATE Productos
                SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock
                WHERE Id = @Id", conexion);
            comando.Parameters.AddWithValue("@Id", producto.Id);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);

            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand("DELETE FROM Productos WHERE Id = @Id", conexion);
            comando.Parameters.AddWithValue("@Id", id);

            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
