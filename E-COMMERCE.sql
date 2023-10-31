Create Database ECOMMERCE_DB
use ECOMMERCE_DB
CREATE TABLE Clientes (
  idCliente INT PRIMARY KEY IDENTITY (1, 1),
  nombreFantasia VARCHAR(50) null,
  direccion VARCHAR(100) null,
  telefono VARCHAR(20) null,
  correo VARCHAR(50) null,
  fechaNacimiento date not null 
)

CREATE TABLE Proveedores (
  idProveedor INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) not null,
  direccion VARCHAR(50) null,
  telefono VARCHAR(20) null,
  correo VARCHAR(50) null
)

Go
CREATE TABLE Marcas (
  idMarca INT PRIMARY KEY IDENTITY (1, 1) ,
  nombre VARCHAR(50) not null
)
Go
CREATE TABLE Categorias (
  idCategoria INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) NOT NULL
)


CREATE TABLE Productos (
  idProducto INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) not null,
  precioCompra DECIMAL(10, 2) check(precioCompra > 0) not null,
  precioVenta  DECIMAL(10, 2) not null check(precioVenta > 0),
  idMarca INT not null,
  idCategoria INT not null,
  stockActual INT not null,
  stockMinimo INT not null,
  FOREIGN KEY (idMarca) REFERENCES Marcas(idMarca),
  FOREIGN KEY (idCategoria) REFERENCES Categorias(idCategoria)
)


CREATE TABLE Compras (
  idCompra INT PRIMARY KEY IDENTITY (1, 1),
  idProveedor INT not null,
  fecha DATE not null,
  observacion varchar (100) NULL,
  metodoPago char(1) not null check (metodoPago = 'E' or metodoPago = 'T')
  FOREIGN KEY (idProveedor) REFERENCES Proveedores(idProveedor)

)


CREATE TABLE Ventas (
  idVenta INT PRIMARY KEY IDENTITY (1, 1),
  idCliente INT not null,
  fecha DATE not null,
  observacion varchar(100) null
  FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente)
)


CREATE TABLE Usuarios (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Usuario]  VARCHAR (50) NULL,
    [Pass]     VARCHAR (50) NULL,
    [TipoUser] INT          NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE Detalles_Venta ( --Productos Vendidos---
  idVenta INT not null,
  idProducto INT not null,
  cantidad INT not null,
  precio DECIMAL(10, 2),
  FOREIGN KEY (idVenta) REFERENCES Ventas(idVenta),
  FOREIGN KEY (idProducto) REFERENCES Productos(idProducto)
)

CREATE TABLE Detalles_Compra (
  idCompra INT not null,
  idProducto INT not null,
  cantidad INT not null,
  precio DECIMAL(10, 2) not null,
  FOREIGN KEY (idCompra) REFERENCES Compras(idCompra),
  FOREIGN KEY (idProducto) REFERENCES Productos(idProducto)
)