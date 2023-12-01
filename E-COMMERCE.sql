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

INSERT INTO Usuarios( Usuario, PASS, TipoUser) VALUES ('NIK', 'NIK' ,2)
INSERT INTO Usuarios( Usuario, PASS, TipoUser) VALUES ('MATEO', 'MATEO' ,1)

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

/* en productos se agrego descripcion, estado y proveedor
*/
alter table Productos
add estado int not null  check(estado = 1 or estado = 0) default  1,
descripcion varchar(50) null,
idProveedor int not null foreign key (idProveedor) references Proveedores

/* en Ventas se agrego id de vendedor
*/
alter table Ventas
add idVendedor int null foreign key (idVendedor) references Vendedores


/*se creo la tabla vendedores*/


CREATE TABLE Vendedores (
  idVendedor INT PRIMARY KEY IDENTITY (1, 1),
  nombre VARCHAR(50) not null,
  direccion VARCHAR(50) null,
  telefono VARCHAR(20) null,
  correo VARCHAR(50) null,
  estado int not null  check(estado = 1 or estado = 0) default  1
);


/*pongo estado en donde faltaba*/
alter table Ventas
add entregado bit not null  check(entregado = 1 or entregado = 0) default  0

alter table Compras
add entregado int not null  check(entregado = 1 or entregado = 0) default  0


alter table Clientes
add estado int not null  check(estado = 1 or estado = 0) default  1

alter table Proveedores
add estado int not null  check(estado = 1 or estado = 0) default  1


; -- Reemplaza 'nombre_restriccion' con el nombre de tu restricción CHECK







update Ventas set entregado = 0 where idVenta = @id


select * from usuarios
Select Id, usuario, pass, tipouser from Usuarios
DELETE FROM USUARIOS


	
SELECT V.idVenta, V.entregado as entregado, SUM(DetV.cantidad * DetV.precio) as totalVenta, SUM( DetV.cantidad) as cantidadProductos, C.nombreFantasia as nombreCliente,
V.fecha as fecha, V.idCliente as idCliente,  V.observacion as observacion, V.idVendedor as idVendedor, vend.nombre as nombreVendedor   
FROM  Ventas V   INNER JOIN Vendedores vend ON vend.idVendedor = V.idVendedor  
INNER JOIN Clientes C ON V.idCliente = C.idCliente  
INNER JOIN Detalles_Venta DetV ON DetV.idVenta = V.idVenta  GROUP BY  V.idVenta, C.nombreFantasia, V.fecha, V.idCliente, V.observacion, V.idVendedor, vend.nombre, V.entregado





