create database System_Lf
go

use System_Lf
go

--Tabla Usuarios

create Table Usuarios
(
ID_Usuario int identity(1,1) primary key ,
Nombre_Usuario nvarchar(50) not null,
Contraseña nvarchar(50) not null,
Nombre nvarchar(50) not null,
Apellido nvarchar(59) not null,
Cargo nvarchar(30) not null,
Email nvarchar(100) not null

)

insert into Usuarios values('Luis','luis1234','Luis','Flores','Administrador','lf016158@gmail.com')
insert into Usuarios values('0703200003793','luis1234flores','Luis','Flores','Gerente','polar5461@gmail.com')
select * from Usuarios where Nombre_Usuario = 'Luis' and Contraseña = 'luis1234'