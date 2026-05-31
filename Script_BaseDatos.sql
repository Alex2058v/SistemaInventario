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
('Tenis básicos', 39.99, 10),
('Calcetas deportivas', 5.99, 50),
('Gorra deportiva', 12.50, 25),
('Mochila deportiva', 29.99, 12),
('Balón de fútbol', 18.75, 18),
('Botella térmica', 9.99, 30),
('Sudadera deportiva', 34.99, 8),
('Guantes deportivos', 14.50, 16);
GO

INSERT INTO Ventas (ProductoId, Cantidad, Total, Fecha) VALUES
(1, 2, 31.98, '2026-05-01'),
(2, 1, 24.50, '2026-05-02'),
(3, 1, 39.99, '2026-05-03'),
(4, 5, 29.95, '2026-05-04'),
(5, 2, 25.00, '2026-05-05'),
(6, 1, 29.99, '2026-05-06'),
(7, 3, 56.25, '2026-05-07'),
(8, 4, 39.96, '2026-05-08'),
(9, 1, 34.99, '2026-05-09'),
(10, 2, 29.00, '2026-05-10'),
(1, 3, 47.97, '2026-05-11'),
(2, 2, 49.00, '2026-05-12'),
(3, 1, 39.99, '2026-05-13'),
(6, 2, 59.98, '2026-05-14'),
(7, 1, 18.75, '2026-05-15');
GO
