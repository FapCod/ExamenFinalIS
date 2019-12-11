---procedimiento almacenado para datagridview que ira en frmEntrada------
create procedure listarDgvFuncion
as 
begin
SELECT dbo.funcion.idfuncion, dbo.pelicula.nombrepelicula, dbo.funcion.horafuncion, dbo.sala.idsala
FROM     dbo.funcion INNER JOIN
                  dbo.pelicula ON dbo.funcion.idpelicula = dbo.pelicula.idpelicula INNER JOIN
                  dbo.sala ON dbo.funcion.idsala = dbo.sala.idsala
end
------------------------------------------------------------------------------------

--procedimiento almacenado para combobox que llenara peliculas que ira en funcion---
create procedure listarComboboxPelicula
as 
begin 
select idpelicula, nombrepelicula from pelicula 
end
-----------------------------------------------------------

--procedimiento almacenado para combobox que llenara sala que ira en funcion
create procedure listarComboboxSala
as 
begin 
select idsala from sala 
end