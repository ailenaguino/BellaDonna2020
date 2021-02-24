CREATE DATABASE BellaDonnaDB ON PRIMARY
(	NAME = 'BellaDonnaDB',
	FILENAME = 'D:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BellaDonnaDB.mdf',
	SIZE = 4096KB,
	MAXSIZE = 20480KB,
	FILEGROWTH = 10%
)
LOG ON
(	NAME = 'BellaDonna_log',
	FILENAME = 'D:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BellaDonna_log.ldf',
	SIZE = 2048KB,
	MAXSIZE = 10240KB,
	FILEGROWTH = 10%
)
go

use BellaDonnaDB
go

create schema Tratamientos
go

create table Tratamientos.Tratamientos
(
	IdTratamiento int identity(1,1) not null,
	Nombre nvarchar(75) not null,
	Descripcion nvarchar(500) not null,
	Precio int not null constraint DF_PrecioTratamiento default(0),
	constraint PK_Tratamiento primary key (IdTratamiento)
);

create table Tratamientos.Promos
(
	IdPromo int identity(1,1) not null,
	Precio int not null constraint DF_PrecioPromo default(0),
	Sesiones int not null constraint DF_SesionPromo default(4),
	constraint PK_Promo primary key (IdPromo)
);

create table Tratamientos.TratamientoPromo
(
	IdTratamiento int not null,
	IdPromo int not null,
	constraint PK_TratamientoPromo primary key (IdPromo, IdTratamiento),
	constraint FK_Promo foreign key (IdPromo) references Tratamientos.Promos(IdPromo),
	constraint FK_Tratamiento foreign key (IdTratamiento) 
	references Tratamientos.Tratamientos(IdTratamiento)
);