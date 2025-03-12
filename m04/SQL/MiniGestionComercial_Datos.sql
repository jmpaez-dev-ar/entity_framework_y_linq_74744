USE [MiniGestionComercial_Instructor]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (1, N'C001', N'Laptops')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (2, N'C002', N'Periféricos')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (3, N'C003', N'Monitores')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (4, N'C004', N'Software')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (5, N'C005', N'Almacenamiento')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (6, N'C006', N'Impresoras')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (7, N'C007', N'Componentes')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (8, N'C008', N'Redes')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (9, N'C009', N'Accesorios')
GO
INSERT [dbo].[Categorias] ([Id], [Codigo], [Nombre]) VALUES (10, N'C010', N'Energia')
GO
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (1, N'P001', N'Laptop HP Pavilion 15', CAST(800.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (2, N'P002', N'Laptop Dell Inspiron 14', CAST(750.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (3, N'P003', N'Laptop Lenovo ThinkPad E15', CAST(900.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (4, N'P004', N'Laptop Asus VivoBook S14', CAST(850.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (5, N'P005', N'Laptop Acer Aspire 5', CAST(700.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (6, N'P006', N'Teclado Logitech K380', CAST(40.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (7, N'P007', N'Mouse Inalámbrico Microsoft', CAST(35.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (8, N'P008', N'Audífonos JBL Quantum 100', CAST(50.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (9, N'P009', N'Cámara Web Logitech C920', CAST(100.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (10, N'P010', N'Micrófono Blue Yeti', CAST(130.00 AS Decimal(18, 2)), 2)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (11, N'P011', N'Monitor LG UltraFine 24"', CAST(250.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (12, N'P012', N'Monitor Dell 27" 4K', CAST(400.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (13, N'P013', N'Monitor Samsung Curve 32"', CAST(350.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (14, N'P014', N'Monitor HP 22" Full HD', CAST(180.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (15, N'P015', N'Monitor Acer Predator 27"', CAST(500.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (16, N'P016', N'Microsoft Office 2024', CAST(120.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (17, N'P017', N'Antivirus Kaspersky 1 Año', CAST(50.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (18, N'P018', N'Adobe Photoshop 2024', CAST(240.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (19, N'P019', N'AutoCAD 2024', CAST(1500.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (20, N'P020', N'CorelDRAW 2024', CAST(500.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (21, N'P021', N'Disco SSD Samsung 1TB', CAST(100.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (22, N'P022', N'Disco Duro Seagate 2TB', CAST(80.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (23, N'P023', N'Pendrive Kingston 64GB', CAST(20.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (24, N'P024', N'Tarjeta MicroSD Sandisk 128GB', CAST(25.00 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Productos] ([Id], [Codigo], [Nombre], [PrecioUnitario], [CategoriaId]) VALUES (25, N'P025', N'NAS Synology 4 Bahías', CAST(600.00 AS Decimal(18, 2)), 5)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (1, N'CLI001', N'Pérez', N'Juan', CAST(N'1990-01-15' AS Date), N'juan.perez@MyServer.com', NULL, NULL, N'Calle Falsa 123', N'Buenos Aires', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (2, N'CLI002', N'González', N'María', CAST(N'1985-03-22' AS Date), N'maria.gonzalez@MyServer.com', NULL, NULL, N'Av. Mitre 456', N'Córdoba', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (3, N'CLI003', N'López', N'Carlos', CAST(N'1978-07-11' AS Date), N'carlos.lopez@MyServer.com', NULL, NULL, N'Calle Colón 789', N'Rosario', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (4, N'CLI004', N'Martínez', N'Ana', CAST(N'1992-11-05' AS Date), N'ana.martinez@MyServer.com', NULL, NULL, N'Av. Libertador 321', N'Mendoza', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (5, N'CLI005', N'Rodríguez', N'Jorge', CAST(N'1980-04-19' AS Date), N'jorge.rodriguez@MyServer.com', NULL, NULL, N'Calle San Juan 654', N'Salta', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (6, N'CLI006', N'Fernández', N'Sofía', CAST(N'1995-09-30' AS Date), N'sofia.fernandez@MyServer.com', NULL, NULL, N'Calle Mendoza 987', N'Neuquén', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (7, N'CLI007', N'Gutiérrez', N'Martín', CAST(N'1987-06-14' AS Date), N'martin.gutierrez@MyServer.com', NULL, NULL, N'Calle Tucumán 123', N'Tucumán', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (8, N'CLI008', N'Ramírez', N'Lucía', CAST(N'1983-08-21' AS Date), N'lucia.ramirez@MyServer.com', NULL, NULL, N'Av. Corrientes 456', N'La Plata', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (9, N'CLI009', N'Sosa', N'Federico', CAST(N'1975-02-10' AS Date), N'federico.sosa@MyServer.com', NULL, NULL, N'Calle Mitre 789', N'San Juan', N'Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [Codigo], [Apellido], [Nombre], [FechaNacimiento], [Email], [CuitCuil], [RazonSocial], [Direccion], [Ciudad], [Pais]) VALUES (10, N'CLI010', N'Díaz', N'Carolina', CAST(N'1998-12-03' AS Date), N'carolina.diaz@MyServer.com', NULL, NULL, N'Av. Pueyrredón 321', N'Río Cuarto', N'Argentina')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedidos] ON 
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (1, CAST(N'2024-12-26' AS Date), 1, 1, CAST(300.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (2, CAST(N'2024-12-26' AS Date), 2, 2, CAST(400.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (3, CAST(N'2024-12-26' AS Date), 3, 3, CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (4, CAST(N'2024-12-26' AS Date), 4, 4, CAST(600.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (5, CAST(N'2024-12-26' AS Date), 5, 5, CAST(700.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (6, CAST(N'2024-12-26' AS Date), 6, 6, CAST(250.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (7, CAST(N'2024-12-26' AS Date), 7, 7, CAST(1000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (8, CAST(N'2024-12-26' AS Date), 8, 8, CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (9, CAST(N'2024-12-26' AS Date), 9, 9, CAST(300.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedidos] ([Id], [FechaPedido], [Numero], [ClienteId], [Total]) VALUES (10, CAST(N'2024-12-26' AS Date), 10, 10, CAST(450.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Pedidos] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesPedidos] ON 
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (1, 1, 1, 1, CAST(800.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (2, 1, 6, 2, CAST(40.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (3, 1, 11, 1, CAST(250.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (4, 2, 2, 1, CAST(750.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (5, 2, 7, 1, CAST(35.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (6, 2, 12, 2, CAST(400.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (7, 3, 3, 1, CAST(900.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (8, 3, 8, 2, CAST(50.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (9, 3, 13, 1, CAST(350.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (10, 4, 4, 1, CAST(850.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (11, 4, 9, 1, CAST(100.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (12, 4, 14, 2, CAST(180.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (13, 5, 5, 1, CAST(700.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (14, 5, 10, 3, CAST(130.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (15, 5, 15, 1, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (16, 6, 16, 1, CAST(120.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (17, 6, 17, 2, CAST(50.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (18, 6, 18, 1, CAST(240.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (19, 7, 19, 1, CAST(1500.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (20, 7, 20, 1, CAST(500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (21, 7, 21, 2, CAST(100.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (22, 8, 22, 1, CAST(80.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (23, 8, 23, 3, CAST(20.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (24, 8, 24, 2, CAST(25.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (25, 9, 25, 1, CAST(600.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (26, 9, 1, 2, CAST(800.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (27, 9, 6, 1, CAST(40.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (28, 10, 11, 2, CAST(250.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (29, 10, 16, 1, CAST(120.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[DetallesPedidos] ([Id], [PedidoId], [ProductoId], [Cantidad], [PrecioUnitario], [DescuentoPorcentaje]) VALUES (30, 10, 17, 1, CAST(50.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(5, 2)))
GO
SET IDENTITY_INSERT [dbo].[DetallesPedidos] OFF
GO
