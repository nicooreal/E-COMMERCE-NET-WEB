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

select * from compras

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


select * from Productos

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
add entregado varchar(50) not null   default 'PENDIENTE'

alter table Compras
add entregado int not null  check(entregado = 1 or entregado = 0) default  0


alter table Clientes
add estado int not null  check(estado = 1 or estado = 0) default  1

alter table Proveedores
add estado int not null  check(estado = 1 or estado = 0) default  1




update Ventas set entregado = 0 where idVenta = @id


select idVenta from Ventas
Select Id, usuario, pass, tipouser from Usuarios
DELETE FROM USUARIOS


	
SELECT V.idVenta, V.entregado as entregado, SUM(DetV.cantidad * DetV.precio) as totalVenta, SUM( DetV.cantidad) as cantidadProductos, C.nombreFantasia as nombreCliente,
V.fecha as fecha, V.idCliente as idCliente,  V.observacion as observacion, V.idVendedor as idVendedor, vend.nombre as nombreVendedor   
FROM  Ventas V   INNER JOIN Vendedores vend ON vend.idVendedor = V.idVendedor  
INNER JOIN Clientes C ON V.idCliente = C.idCliente  
INNER JOIN Detalles_Venta DetV ON DetV.idVenta = V.idVenta  GROUP BY  V.idVenta, C.nombreFantasia, V.fecha, V.idCliente, V.observacion, V.idVendedor, vend.nombre, V.entregado



insert into Marcas(nombre) values ('BONAFIDE')


select * from Compras
select * from Detalles_Compra
select * from Productos
delete from Compras
DBCC CHECKIDENT ('Compras', RESEED,0)  



select * from ventas



INSERT INTO Compras (idProveedor, fecha, observacion, estado) VALUES (1,GETDATE(), 'buena compra', 'pendiente')



create procedure SP_detalleCompra
@idCompra int,
@idProducto int,
@cantidadDeProductos int,
@precio int

as
INSERT INTO Detalles_Compra (idCompra, idProducto, cantidad, precio)
VALUES (@idCompra, @idProducto, @cantidadDeProductos, @precio); 

select C.idCompra as idCompra, C.fecha as fecha, C.idProveedor as proveedor,C.entregado as entregado ,C.observacion as observacion,SUM(DetC.cantidad * DetC.precio) as totalCompra ,SUM( DetC.cantidad) as cantidadProductos from Compras C inner join Detalles_Compra DetC on C.idCompra = DetC.idCompra



SELECT C.idCompra AS idCompra, C.fecha AS fecha, C.idProveedor AS proveedor ,C.estado AS estado, C.observacion AS observacion, SUM(DetC.cantidad * DetC.precio) AS totalCompra, SUM(DetC.cantidad) AS cantidadProductos,P.nombre FROM Compras C INNER JOIN Detalles_Compra DetC ON C.idCompra = DetC.idCompra inner join Proveedores P on P.idProveedor = C.idProveedor GROUP BY C.idCompra, C.fecha, C.idProveedor,  C.estado, C.observacion, P.nombre;






select DetC.cantidad as cantidadPRoductos, P.idProducto as idProducto ,DetC.precio, (DetC.precio * DetC.cantidad) as totalPorProducto, P.nombre as nombreProducto,  C.idCompra as idCompra from Compras C   inner join Detalles_Compra DetC on DetC.idCompra = C.idCompra inner join Productos P on P.idProducto = DetC.idProducto