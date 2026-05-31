using System.Collections.Generic;

namespace SistemaInventario.Modelos
{
    // Esta clase se conserva para evidenciar la estructura de datos List<Producto>
    // planteada en el proyecto. La persistencia final se realiza en SQL Server.
    public class Inventario
    {
        public List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto p)
        {
            productos.Add(p);
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
