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


insert into Usuarios(Usuario, Pass, TipoUser)
values ('nico', 'nico',1)

insert into Usuarios(Usuario, Pass, TipoUser)
values ('NICO', 'NICO',2)

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










SELECT P.estado as Estado, Prov.nombre as NombreProveedor, Prov.idProveedor as idProveedor , P.idProducto AS Id, P.nombre AS Nombre, 
P.precioCompra AS PrecioCompra, C.idCategoria as idCategoria, C.nombre as NombreCategoria, P.precioVenta AS PrecioVenta, M.nombre as NombreMarca,M.idMarca as idMarca, 
C.nombre AS NombreCategoria, P.stockActual AS StockActual, P.stockMinimo AS StockMinimo, 
P.descripcion as Descripcion   FROM Productos P  INNER JOIN Marcas M ON P.idMarca = M.idMarca inner join Categorias C on P.idCategoria = C.idCategoria inner join Proveedores prov on prov.idProveedor = P.idProveedor
  

update Productos set estado = 1


INSERT INTO Productos (nombre, precioCompra, precioVenta, idMarca, idCategoria, stockActual, stockMinimo, estado, descripcion, idProveedor)
VALUES ('@nombre', @precioCompra,@precioVenta ,@idMarca , @idCategoria, @stockActual,@stockMinimo, 1, '@descripcion', @idProveedor);


INSERT INTO Detalles_Venta (idVenta, idProducto, cantidad, precio)
VALUES (2, 2, 2, 15.50),
       (2, 1, 1, 30.00);

-- Insertar datos de vendedores en la tabla
INSERT INTO Vendedores (nombre, direccion, telefono, correo)
VALUES 
  ('Juan Pérez', 'Calle A #123', '123-456-7890', 'juan@example.com'),
  ('María Gómez', 'Avenida B #456', '987-654-3210', 'maria@example.com'),
  ('Carlos Rodríguez', 'Carrera C #789', '555-123-4567', 'carlos@example.com');



INSERT INTO Ventas (idCliente, fecha, observacion)
VALUES (1, '2023-11-15', 'Venta de productos al cliente habitual');

select * from Ventas
select * from Detalles_Venta
select * from Vendedores
select * from Clientes

update Ventas set idVendedor = 2 where idCliente = 1



	
	
	SELECT V.idVenta, SUM(DetV.cantidad * DetV.precio) as totalVenta, SUM( DetV.cantidad) as cantidadProductos, C.nombreFantasia as nombreCliente,  V.fecha as fecha, V.idCliente as idCliente,  V.observacion as observacion, V.idVendedor as idVendedor, vend.nombre as nombreVendedor   FROM  Ventas V   INNER JOIN Vendedores vend ON vend.idVendedor = V.idVendedor  INNER JOIN Clientes C ON V.idCliente = C.idCliente  INNER JOIN Detalles_Venta DetV ON DetV.idVenta = V.idVenta  GROUP BY  V.idVenta, C.nombreFantasia, V.fecha, V.idCliente, V.observacion, V.idVendedor, vend.nombre;


select DetV.cantidad as cantidadPRoductos, DetV.precio, (DetV.precio * DetV.cantidad) as totalPorProducto, P.nombre as nombreProducto,  V.idVenta as idVenta from Ventas V  
inner join Vendedores vend on vend.idVendedor = V.idVendedor 
inner join Detalles_Venta DetV on DetV.idVenta = V.idVenta 
inner join Productos P on P.idProducto = DetV.idProducto
      