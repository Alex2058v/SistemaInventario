using System.Collections.Generic;

namespace SistemaInventario.Modelos
{
    
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
