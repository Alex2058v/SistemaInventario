using Microsoft.Data.SqlClient;
using SistemaInventario.Datos;
using System.Data;

namespace SistemaInventario.Repositorios
{
    public class VentaRepositorio
    {
        public void RegistrarVenta(int productoId, int cantidad)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            using var transaccion = conexion.BeginTransaction();

            try
            {
                using var consultar = new SqlCommand(@"
                    SELECT Nombre, Precio, Stock
                    FROM Productos WITH (UPDLOCK)
                    WHERE Id = @Id", conexion, transaccion);
                consultar.Parameters.AddWithValue("@Id", productoId);

                using var lector = consultar.ExecuteReader();
                if (!lector.Read())
                {
                    throw new Exception("El producto no existe.");
                }

                decimal precio = lector.GetDecimal(1);
                int stockActual = lector.GetInt32(2);
                lector.Close();

                if (stockActual < cantidad)
                {
                    throw new Exception("Stock insuficiente para realizar la venta.");
                }

                decimal total = precio * cantidad;

                using var actualizar = new SqlCommand(@"
                    UPDATE Productos
                    SET Stock = Stock - @Cantidad
                    WHERE Id = @Id", conexion, transaccion);
                actualizar.Parameters.AddWithValue("@Cantidad", cantidad);
                actualizar.Parameters.AddWithValue("@Id", productoId);
                actualizar.ExecuteNonQuery();

                using var insertar = new SqlCommand(@"
                    INSERT INTO Ventas (ProductoId, Cantidad, Total, Fecha)
                    VALUES (@ProductoId, @Cantidad, @Total, GETDATE())", conexion, transaccion);
                insertar.Parameters.AddWithValue("@ProductoId", productoId);
                insertar.Parameters.AddWithValue("@Cantidad", cantidad);
                insertar.Parameters.AddWithValue("@Total", total);
                insertar.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }

        public DataTable ObtenerHistorial()
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand(@"
                SELECT V.Id, P.Nombre AS Producto, V.Cantidad, V.Total, V.Fecha
                FROM Ventas V
                INNER JOIN Productos P ON P.Id = V.ProductoId
                ORDER BY V.Fecha DESC", conexion);
            using var adaptador = new SqlDataAdapter(comando);
            var tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public DataTable VentasPorProducto()
        {
            using var conexion = ConexionBD.ObtenerConexion();
            using var comando = new SqlCommand(@"
                SELECT TOP 10 P.Nombre AS Producto, SUM(V.Total) AS TotalVendido
                FROM Ventas V
                INNER JOIN Productos P ON P.Id = V.ProductoId
                GROUP BY P.Nombre
                ORDER BY TotalVendido DESC", conexion);
            using var adaptador = new SqlDataAdapter(comando);
            var tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
