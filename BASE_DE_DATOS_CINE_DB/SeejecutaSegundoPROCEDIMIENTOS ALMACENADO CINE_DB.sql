--PROCEDIMIENTOS ALMACENADOS DE LA BASE DE DATOS CINEDB 
use CineDB
--------------------------------------------------------------------------------------------------------
--<<<<<<<<<<<<<<<<<<<<<Procedimientos de la tabla PELICULA>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<---
--------------------------------------------------------------------------------------------------------

--Creamos un procedimiento almacenado para que REGISTRA una nueva PELICULA
create procedure registroPelicula(
@nombrepelicula varchar (50) ,
@generopelicula varchar (30) , 
@clasificacionpelicula varchar(20) , 
@fechaestrenopelicula date,
@estadopelicula varchar (20) 
)
as 
begin 
insert into pelicula values (@nombrepelicula, @generopelicula, @clasificacionpelicula, @fechaestrenopelicula, @estadopelicula)
end 
--Final de la creacion del procedimiento almacenado registroPelicula--

--creamos un procedimiento almacenado que liste todas las peliculas-- 
create procedure listarPelicula 
as
begin 
select * from pelicula 
end
--Final del procedimiento almacenado listarPelicula-- 

---------------------------------------------------------------------------------------------------
--<<<<<<<<<<<<<<<<<<<<<Procedimientos de la tabla SALA>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<---
---------------------------------------------------------------------------------------------------

--Creamos un procedimiento almacenado que registre las salas-- 
create procedure registroSala (
@ubicacionsala varchar(20) , 
@capacidadsala int,
@tiposala varchar (20), 
@estadosala varchar(20) 
)
as
begin
insert into sala values (@ubicacionsala, @capacidadsala, @tiposala, @estadosala) 
end
--Final de la creacion del procedimiento almacenado registroSala

--Creamos un procedimiento almacenado que liste las salas-- 
create procedure listarSala 
as
begin 
select * from sala
end 
--Final de la creacion del procedimiento almacenado listarSala-- 

---------------------------------------------------------------------------------------------------
--<<<<<<<<<<<<<<<<<<<<<Procedimientos de la tabla FUNCION>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<---
---------------------------------------------------------------------------------------------------

--creamos un procedimiento almacenado que registre las funciones--
create procedure registroFuncion (
@idsala int , 
@idpelicula int,
@preciofuncion float,
@horafuncion time, 
@fechainiciofuncion date, 
@fechafinfuncion date
)
as 
begin 
insert into funcion values ( @idsala, @idpelicula, @preciofuncion, @horafuncion, @fechainiciofuncion, @fechafinfuncion)
end
--fin de la creacion del procedimiento almacenado-- 

--creamos un procedimiento almacenado que liste las funciones
create procedure listarFuncion 
as 
begin 
select * from funcion 
end

--fin de la creacion del procedimiento almacenado listarFuncion 

--creamos un procedimiento almacenado que busque una funcion 
create procedure buscarFuncion(
@idfuncion  int 
)
as 
begin 
select * from funcion
 where idfuncion = @idfuncion
end
--final de la creacion del procedimiento almacenado buscarFuncion 

--creamos un procedimiento almanceado que elimine una funcion-- 
create procedure eliminarFuncion (
@idfuncion int
)
as 
begin 
delete from funcion 
where idfuncion = @idfuncion
end
--final de la creacion del procedimiento almacenado eliminarFuncion.. 

--creamos un procedimiento almacenado que actualice una funcion
create procedure actualizarFuncion (
@idfuncion int,
@idsala int , 
@idpelicula int,
@preciofuncion float,
@horafuncion time, 
@fechainiciofuncion date, 
@fechafinfuncion date
)
as 
begin
update funcion set idsala = @idsala, idpelicula = @idpelicula, preciofuncion = @preciofuncion , horafuncion = @horafuncion , fechainiciofuncion = @fechainiciofuncion, fechafinfuncion = @fechafinfuncion
where idfuncion = @idfuncion 
end
--fin de la creacion del procedimiento almacenado actualizarFuncion--
---------------------------------------------------------------------------------------------------
--<<<<<<<<<<<<<<<<<<<<<Procedimientos de la tabla ENTRADAS>>>>>>>>>>>>>>>>>>>>>>>>><<<<---
---------------------------------------------------------------------------------------------------
--creamos un procedimiento almacenado que registre las entradas--
create procedure registrarEntrada (
@idfuncion int , 
@fechaentrada date, 
@asientoentrada int 
)
as 
begin
insert into entrada values (@idfuncion, @fechaentrada, @asientoentrada)
end
--final de la creacion del procedimiento almacenado registrarEntrada-- 

--creamos un procedimiento almacenado que liste las entradas--
create procedure listarEntrada
as 
begin
select * from entrada
end 
--final de la creacion del procedimiento almacenado listarEntrada