create database ServiceApp
use ServiceApp

create table cliente 
(
id int identity primary key,
nombre nvarchar (30),
clave  nvarchar (30),
cedula  nvarchar (30),
fecha_registro date,
correo nvarchar(30),
estatus  nvarchar (3),
monto numeric,
telefono  nvarchar (30),
cargo   nvarchar (30)
)



create table usuario
(
codigo nvarchar (30) primary key,
nombre nvarchar (30),
clave  nvarchar (30),
TipoUser nvarchar (3),  -- Cli, EMP
estatus  nvarchar (3),
Id_departamento   int,
cargo   nvarchar (30),
idroll int,
fecha datetime
)  
 
create table departamento
(
id int identity  primary key,
descripcion   nvarchar (30)
)

 create table Rol
(
id int identity primary key,
descripcion  nvarchar (30)
)

create table Rol_Operacion
(
id int identity primary key,
idrol int,
idOperacion int
)

create table Operacion
(
id int identity primary key,
nombre nvarchar (30),
idModulo int
)

create table modulo 
(
id int identity primary key,
nombre nvarchar (30)
)

create table producto 
(
id int identity primary key,
descripcion nvarchar(50) not null,
monto numeric(14,10)
)

create table producto_cliente
(
id int identity primary key,
id_producto int,
id_cliente int,
cantidad int
)

create table queja
(
id int primary key,
fecha datetime
)

create table reclamo 
(
id int primary key,
fecha datetime
)

 create table caso
(
id int identity  primary key,
id_cliente int,
codigo_usuario nvarchar (30),
relevancia nvarchar (3),
tipo_caso nvarchar(3),
id_queja int,
id_reclamo int,
id_departamento int,
fecha  date,
Comentario nvarchar (30),
estatus nvarchar (3)
)

create table solucion 
(
id int identity primary key,
id_caso int,
ComenSolu nvarchar (200)
)

  create table valoracion_respuesta
(
id int identity primary key,
id_caso int,
id_cliente int,
id_usuario nvarchar (30),
valor numeric 
)

create table Estatus 
(
CodEst nvarchar(3) primary key,
DescripEst nvarchar(10)
)

create table Relevancias 
(
CodRel nvarchar(3) primary key,
DescripRel nvarchar(10)
)

create table Tipo_Caso 
(
CodTip nvarchar(3) primary key,
DescripTip nvarchar(10)
)

create table Esta_Usua_clien
(
CodTip_U_C nvarchar(3) primary key,
DescripTip_U_C nvarchar(10)
)

ALTER TABLE Rol_Operacion add
FOREIGN KEY (idrol) REFERENCES Rol(id);

ALTER TABLE Rol_Operacion add
FOREIGN KEY (idOperacion) REFERENCES Operacion(id);

ALTER TABLE Operacion add
FOREIGN KEY (idModulo) REFERENCES modulo(id);
 
ALTER TABLE usuario add
FOREIGN KEY (idroll) REFERENCES rol(id);

ALTER TABLE usuario add
FOREIGN KEY (Id_departamento) REFERENCES departamento(id);

ALTER TABLE producto_cliente add
FOREIGN KEY (id_producto) REFERENCES producto(id);

ALTER TABLE producto_cliente add
FOREIGN KEY (id_cliente) REFERENCES cliente(id);

ALTER TABLE caso add
FOREIGN KEY (id_cliente) REFERENCES cliente(id);

ALTER TABLE caso add
FOREIGN KEY (id_reclamo) REFERENCES reclamo(id);

ALTER TABLE caso add
FOREIGN KEY (id_queja) REFERENCES queja(id);

ALTER TABLE caso add
FOREIGN KEY (codigo_usuario) REFERENCES usuario(codigo);

ALTER TABLE caso add
FOREIGN KEY (Id_departamento) REFERENCES departamento(id);

ALTER TABLE usuario add
FOREIGN KEY (estatus) REFERENCES Esta_Usua_clien(CodTip_U_C);

alter table cliente add 
Foreign key (estatus) references Esta_Usua_clien(CodTip_U_C)

ALTER TABLE solucion add
FOREIGN KEY (id_caso) REFERENCES caso(id);

ALTER TABLE caso add
FOREIGN KEY (tipo_caso) REFERENCES Tipo_Caso (CodTip);

ALTER TABLE caso add
FOREIGN KEY (estatus) REFERENCES estatus(CodEst);

ALTER TABLE caso add
FOREIGN KEY (relevancia) REFERENCES Relevancias (CodRel);
 
ALTER TABLE valoracion_respuesta add
FOREIGN KEY (id_cliente) REFERENCES cliente(id);

ALTER TABLE valoracion_respuesta add
FOREIGN KEY (id_caso) REFERENCES caso(id);

ALTER TABLE valoracion_respuesta add
FOREIGN KEY (id_usuario) REFERENCES usuario(codigo);
 
 
CREATE TRIGGER Usuario_Cliente ON cliente
AFTER INSERT
AS 
    BEGIN
        INSERT INTO usuario (codigo,nombre, clave, TipoUser,idroll,Id_departamento,cargo,estatus,fecha)
        SELECT nombre+'@gmail.com',nombre,clave,'CLI',2,2,cargo,'ACT',GETDATE() from inserted       
END 


insert into modulo (nombre) values ('Contacto')
insert into Operacion (nombre, idModulo) values ('VerContacto',1)
insert into Rol (descripcion) values ('Operador')
insert into Rol_Operacion (idrol,idOperacion) values (1,1)
insert into departamento (descripcion) values ('Informatica')
insert into Esta_Usua_clien values ('INA','INACTIVO') 
insert into Esta_Usua_clien values ('ACT','ACTIVO') 
insert into Estatus values ('PEN','PENDIENTE') 
insert into Estatus values ('ACT','ACTIVA') 
insert into Estatus values ('ENP','EN ESPERA') 
insert into Relevancias values ('A','ALTO') 
insert into Relevancias values ('M','MEDIO')
insert into Relevancias values ('B','BAJO') 
insert into Tipo_Caso values ('Q','QUEJA')
insert into Tipo_Caso values ('R','RECLAMO')
insert into usuario (codigo,nombre,clave,estatus,Id_departamento,cargo,idroll,fecha) values ('ArnettJIm@gmail.com','Arnett Jimenez','1234','ACT',1,'Analista',1,GETDATE())




 