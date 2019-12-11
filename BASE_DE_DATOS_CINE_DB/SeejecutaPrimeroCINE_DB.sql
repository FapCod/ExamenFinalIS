Create database CineDB 
use CineDB 
--Creamos la tabla PELICULA (SE EJECUTA 1)--
create table pelicula (
idpelicula int IDENTITY(1,1) PRIMARY KEY not null, 
nombrepelicula varchar (50) not null,
generopelicula varchar (30) not null, 
clasificacionpelicula varchar(20) not null, 
fechaestrenopelicula date,
estadopelicula varchar(20)
)
--Final de la creacion de la table PELICULA-- 

--creacion de la tabla SALA (SE EJECUTA 2)--
create table sala (
idsala int IDENTITY(1,1) PRIMARY KEY not null, 
ubicacionsala varchar(20) not null, 
capacidadsala int not null,
tiposala varchar (20) not null, 
estadosala varchar(20) not null
)
--final de creacion de la tabla SALA-- 

--Creamos la tabla FUNCION (SE EJECUTA 3)--
create table funcion (
idfuncion int IDENTITY(1,1) PRIMARY KEY not null,
idsala int not null, 
idpelicula int not null,
preciofuncion float,
horafuncion time, 
fechainiciofuncion date, 
fechafinfuncion date,
CONSTRAINT fk_sala FOREIGN KEY (idsala) REFERENCES sala (idsala),
CONSTRAINT fk_pelicula FOREIGN KEY (idpelicula) REFERENCES pelicula (idpelicula)
)
--Final de la creacion de la tabla FUNCION--

--Creamos la tabla ENTRADA (SE EJECUTA 4)-- 
create table entrada (
identrada int IDENTITY(1,1) PRIMARY KEY not null, 
idfuncion int not null, 
fechaentrada date not null, 
asientoentrada int not null,
CONSTRAINT fk_funcion FOREIGN KEY (idfuncion) REFERENCES funcion (idfuncion)
)
--Final de la creacion de la tabla ENTRADA 
