Create database Esteban;
use Esteban;

create table Registro(FechaIngreso Date, Nombre nvarchar(60), Iphone nvarchar(60), AppleWatch nvarchar(60), Samsung nvarchar(60), GB nvarchar(10), Color nvarchar(60), IMEI1 nvarchar(60),
					IMEI2 nvarchar(60), Entrada nvarchar(60), Salida nvarchar(60), Observacion nvarchar(500));

select *from Registro 

select *from Registro order by FechaIngreso asc

select *from Registro order by convert(FechaIngreso) desc;

select convert(varchar(15),FechaIngreso, 103) As Fecha, Nombre, Iphone, AppleWatch, Samsung, GB, Color, IMEI1, IMEI2, Entrada, Salida, Observacion  from Registro Order By Fecha desc
--order by (convert(varchar(30), getdate(),103)) AS FechaIngreso;

--arreglar