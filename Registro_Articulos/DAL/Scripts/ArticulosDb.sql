CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	ArticuloId int primary key identity,
	Fecha Date,
	Descripcion Varchar(max),
	Precio Money,
	Cantidad int,
	CantidadCotizada int
);
