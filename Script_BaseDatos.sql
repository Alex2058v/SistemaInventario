CREATE DATABASE SistemaInventario;
GO

USE SistemaInventario;
GO

CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    CONSTRAINT CK_Productos_Precio CHECK (Precio >= 0),
    CONSTRAINT CK_Productos_Stock CHECK (Stock >= 0)
);
GO

CREATE TABLE Ventas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductoId INT NOT NULL,
    Cantidad INT NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Ventas_Productos FOREIGN KEY (ProductoId) REFERENCES Productos(Id),
    CONSTRAINT CK_Ventas_Cantidad CHECK (Cantidad > 0),
    CONSTRAINT CK_Ventas_Total CHECK (Total >= 0)
);
GO

INSERT INTO Productos (Nombre, Precio, Stock) VALUES
('Camisa deportiva', 15.99, 20),
('Pantalón deportivo', 24.50, 15),
('Tenis básicos', 39.99, 10);
GO
