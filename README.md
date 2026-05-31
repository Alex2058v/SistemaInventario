# SistemaInventario - Fase 2

Sistema de gestión de inventario desarrollado en C# Windows Forms con conexión a SQL Server.

## Funcionalidades

- Gestión de productos: agregar, editar, eliminar, buscar y consultar inventario.
- Registro de ventas con validación de stock.
- Actualización automática del stock al vender.
- Historial de ventas.
- Dashboard con resumen y gráfica básica de ventas por producto.
- Script SQL incluido.

## Base de datos

1. Abrir SQL Server Management Studio.
2. Ejecutar el archivo `Script_BaseDatos.sql`.
3. Verificar que exista la base `SistemaInventario`.

## Cadena de conexión

El proyecto usa por defecto LocalDB:

```csharp
Server=(localdb)\MSSQLLocalDB;Database=SistemaInventario;Trusted_Connection=True;TrustServerCertificate=True;
```

Si usas SQL Server Express, modificar `Datos/ConexionBD.cs` y usar:

```csharp
Server=.\SQLEXPRESS;Database=SistemaInventario;Trusted_Connection=True;TrustServerCertificate=True;
```
