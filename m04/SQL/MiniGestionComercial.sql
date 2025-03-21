USE [master]
GO
/****** Object:  Database [MiniGestionComercial]    Script Date: 19/3/2025 05:09:12 ******/
CREATE DATABASE [MiniGestionComercial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiniGestionComercial', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MiniGestionComercialDemo' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MiniGestionComercial_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MiniGestionComercialDemo_Log' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MiniGestionComercial] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniGestionComercial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniGestionComercial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniGestionComercial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniGestionComercial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiniGestionComercial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniGestionComercial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MiniGestionComercial] SET  MULTI_USER 
GO
ALTER DATABASE [MiniGestionComercial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniGestionComercial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniGestionComercial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniGestionComercial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MiniGestionComercial] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MiniGestionComercial] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MiniGestionComercial] SET QUERY_STORE = OFF
GO
USE [MiniGestionComercial]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 19/3/2025 05:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorias_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Categorias_Codigo] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/3/2025 05:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CuitCuil] [varchar](13) NULL,
	[RazonSocial] [varchar](50) NULL,
	[Direccion] [varchar](150) NULL,
	[Ciudad] [varchar](50) NULL,
	[Pais] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Clientes_Codigo] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPedido]    Script Date: 19/3/2025 05:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesPedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PedidoId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[DescuentoPorcentaje] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_DetallesPedido_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 19/3/2025 05:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaPedido] [date] NOT NULL,
	[Numero] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_Pedidos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 19/3/2025 05:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[CategoriaId] [int] NOT NULL,
 CONSTRAINT [PK_Productos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Productos_Codigo] UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_Numero]    Script Date: 19/3/2025 05:09:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Pedidos_Numero] ON [dbo].[Pedidos]
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetallesPedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPedido_Pedidos] FOREIGN KEY([PedidoId])
REFERENCES [dbo].[Pedidos] ([Id])
GO
ALTER TABLE [dbo].[DetallesPedido] CHECK CONSTRAINT [FK_DetallesPedido_Pedidos]
GO
ALTER TABLE [dbo].[DetallesPedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPedido_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[DetallesPedido] CHECK CONSTRAINT [FK_DetallesPedido_Productos]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Clientes]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
/****** Object:  StoredProcedure [dbo].[GetAllCategorias]    Script Date: 19/3/2025 05:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAllCategorias]
as
set nocount on
select * from Categorias
order by Nombre
GO
USE [master]
GO
ALTER DATABASE [MiniGestionComercial] SET  READ_WRITE 
GO
