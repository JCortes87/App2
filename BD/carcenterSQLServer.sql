create login carcenterLogin
with password ='carcenterLogin';

GO
create database carcenterDB;
GO

use carcenterDB;

create user carcenterUser
for login carcenterLogin;
GO
EXEC sp_addrolemember 'db_datareader', 'carcenterUser';
GRANT CREATE TABLE TO carcenterUser;
GO

GRANT ALTER, CONTROL, CREATE SEQUENCE, DELETE, EXECUTE,
INSERT, REFERENCES, SELECT, TAKE OWNERSHIP, VIEW CHANGE TRACKING, 
VIEW DEFINITION, UPDATE ON SCHEMA :: dbo TO carcenterUser;
GO

create table DOMINIOS (

tipo_dominio varchar (50), 
id_dominio varchar(10), 
vlr_dominio varchar (50) not null,

primary key (tipo_dominio,id_dominio)

)

create table FACTURAS (

num_factura numeric(10) primary key,
fecha_factura datetime not null

)

create table PERSONAS (

identificacion numeric (15),
nombres varchar (100) not null,
telefono numeric (10) not null,
direccion varchar (100),
correo varchar (100) unique not null,
especialidad varchar (10),
tipo_persona varchar (10),
contrasena varchar (12) not null,
estado_persona varchar (10) not null

primary key (identificacion, tipo_persona)

)

create table VEHICULOS (

placa varchar (6) primary key,
marca varchar (10) not null,
modelo numeric (4) not null,
color varchar (10) not null,
tipo_vehiculo varchar(10) not null

)

create table PERSONA_VEHICULO (

estado_prop varchar(10),
placa varchar(6),
identificacion numeric (15),
tipo_persona varchar (10)

foreign key (placa) references VEHICULOS,
foreign key (identificacion, tipo_persona) references PERSONAS

)

create table CITAS (

id_cita numeric (5) primary key,
fecha_solicitud datetime not null,
estado_cita varchar(10) not null,
fecha_cierre datetime,
diagnostico varchar (300),
motivo_cita varchar (300) not null

)

create table SERVICIOS (

id_servicio numeric (5) primary key,
desc_servicio varchar (300) not null,
tipo_servicio varchar (10) not null,
tiempo_estimado numeric (3,1) not null,
estado_servicio varchar (10) not null,
valor_servicio numeric (6) not null,
fecha_servicio datetime not null,
num_factura numeric (10),
id_cita numeric (5),

foreign key (num_factura) references FACTURAS,
foreign key (id_cita) references CITAS

)

create table FOTOS (

id_foto numeric (10) primary key,
url_foto varchar (50) not null,
id_cita numeric (5)

foreign key (id_cita) references CITAS

)

create table MENSAJES (

id_mensaje numeric (10) primary key,
desc_mensaje varchar (500) not null,
fecha_mensaje datetime not null,
id_cita numeric (5)

foreign key (id_cita) references CITAS
)

create table REPUESTOS (

id_repuesto numeric (10) primary key,
nom_repuesto varchar (100) unique not null

)

create table SERVICIO_REPUESTO (

cantidad numeric (3) not null,
valor_repuesto numeric (7) not null,
id_servicio numeric (5),
id_repuesto numeric (10)

foreign key (id_servicio) references SERVICIOS,
foreign key (id_repuesto) references REPUESTOS

)