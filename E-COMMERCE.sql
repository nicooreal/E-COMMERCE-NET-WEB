
Create Database ECOMMERCE_DB


CREATE TABLE Usuarios (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Usuario]  VARCHAR (50) NULL,
    [Pass]     VARCHAR (50) NULL,
    [TipoUser] INT          NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([Id] ASC)
)

go
CREATE TABLE Marcas (
  idMarca INT PRIMARY KEY IDENTITY (1, 1) ,
  nombre VARCHAR(50) not null
)
go
CREATE TABLE Categorias (
  idCategoria INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) NOT NULL
)
go
CREATE TABLE Clientes (
  idCliente INT PRIMARY KEY IDENTITY (1, 1),
  nombreFantasia VARCHAR(50) null,
  direccion VARCHAR(100) null,
  telefono VARCHAR(20) null,
  correo VARCHAR(50) null,
  fechaNacimiento date not null,
  estado int not null  check(estado = 1 or estado = 0) default  1
)

CREATE TABLE Vendedores (
  idVendedor INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) not null,
  direccion VARCHAR(50) null,
  telefono VARCHAR(20) null,
  correo VARCHAR(50) null,
  estado int not null  check(estado = 1 or estado = 0) default  1
);

go
CREATE TABLE Ventas (
  idVenta INT PRIMARY KEY IDENTITY (1, 1),
  idCliente INT not null,
  fecha DATE not null,
  observacion varchar(100) null,
  idVendedor int null foreign key (idVendedor) references Vendedores,
  entregado varchar(50) not null   default 'PENDIENTE',
  FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente)
)
go

CREATE TABLE Proveedores (
  idProveedor INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) not null,
  direccion VARCHAR(50) null,
  telefono VARCHAR(20) null,
  correo VARCHAR(50) null,
  estado int not null  check(estado = 1 or estado = 0) default  1  
)
go
CREATE TABLE Productos (
  idProducto INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) not null,
  precioCompra DECIMAL(10, 2) check(precioCompra > 0) not null,
  precioVenta  DECIMAL(10, 2) not null check(precioVenta > 0),
  idMarca INT not null,
  idCategoria INT not null,
  stockActual INT not null,
  stockMinimo INT not null,
  estado int not null  check(estado = 1 or estado = 0) default  1,
  descripcion varchar(50) null,
  idProveedor int not null foreign key (idProveedor) references Proveedores,
  FOREIGN KEY (idMarca) REFERENCES Marcas(idMarca),
  FOREIGN KEY (idCategoria) REFERENCES Categorias(idCategoria)
)

go
CREATE TABLE Detalles_Venta ( --Productos Vendidos---
  idVenta INT not null,
  idProducto INT not null,
  cantidad INT not null,
  precio DECIMAL(10, 2),
  FOREIGN KEY (idVenta) REFERENCES Ventas(idVenta),
  FOREIGN KEY (idProducto) REFERENCES Productos(idProducto)
)

Go

Go
CREATE TABLE Compras (
  idCompra INT PRIMARY KEY IDENTITY (1, 1),
  idProveedor INT not null,
  fecha DATE not null,
  observacion varchar (100) NULL,
  metodoPago char(1) not null check (metodoPago = 'E' or metodoPago = 'T'),
  entregado int not null  check(entregado = 1 or entregado = 0) default  0,
  Estado varchar(20) default 'PENDIENTE'
  FOREIGN KEY (idProveedor) REFERENCES Proveedores(idProveedor)

)


CREATE TABLE Detalles_Compra (
  idCompra INT not null,
  idProducto INT not null,
  cantidad INT not null,
  precio DECIMAL(10, 2) not null,
  FOREIGN KEY (idCompra) REFERENCES Compras(idCompra),
  FOREIGN KEY (idProducto) REFERENCES Productos(idProducto)
)



create procedure SP_detalleventa  @idVenta int,  @idProducto int,  @cantidadDeProductos int,  @precio int    as  INSERT INTO Detalles_Venta (idVenta, idProducto, cantidad, precio)  VALUES (@idVenta, @idProducto, @cantidadDeProductos, @precio);   

CREATE PROCEDURE SP_restarStock  @cantidadDeProductos int,  @idProducto int  as  update Productos set stockActual = stockActual - @cantidadDeProductos  where idProducto = @idProducto  

CREATE PROCEDURE SP_sumarStock  @cantidadDeProductos int,  @idProducto int  as  update Productos set stockActual = stockActual + @cantidadDeProductos  where idProducto = @idProducto  

create procedure SP_detalleCompra  @idCompra int,  @idProducto int,  @cantidadDeProductos int,  @precio int    as  INSERT INTO Detalles_Compra (idCompra, idProducto, cantidad, precio)  VALUES (@idCompra, @idProducto, @cantidadDeProductos, @precio);     







--EJEMPLOS PARA BASE


INSERT INTO Usuarios (Usuario, Pass, TipoUser)
VALUES ('NIK', '1234', 2),
       ('MATEO', '1234', 1);



	   INSERT INTO Marcas (nombre)
VALUES ('Marca A'),
       ('Marca B'),
       ('Marca C');


INSERT INTO Categorias (nombre)
VALUES ('Categoría 1'),
       ('Categoría 2'),
       ('Categoría 3');


INSERT INTO Proveedores (nombre, direccion, telefono, correo)
VALUES ('Proveedor 1', 'Dirección 1', '123456789', 'proveedor1@ejemplo.com'),
       ('Proveedor 2', 'Dirección 2', '987654321', 'proveedor2@ejemplo.com');



INSERT INTO Vendedores (nombre, direccion, telefono, correo)
VALUES ('Vendedor 1', 'Dirección 1', '111111111', 'vendedor1@ejemplo.com'),
       ('Vendedor 2', 'Dirección 2', '222222222', 'vendedor2@ejemplo.com');


INSERT INTO Clientes (nombreFantasia, direccion, telefono, correo, fechaNacimiento)
VALUES ('Cliente A', 'Dirección A', '555555555', 'clienteA@ejemplo.com', '2000-01-01'),
       ('Cliente B', 'Dirección B', '666666666', 'clienteB@ejemplo.com', '1995-05-05');


