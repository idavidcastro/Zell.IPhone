Create database Esteban;
use Esteban;

create table Registro(FechaIngreso nvarchar(60), Nombre nvarchar(60), Iphone nvarchar(60), AppleWatch nvarchar(60), Samsung nvarchar(60), GB nvarchar(10), Color nvarchar(60), IMEI1 nvarchar(60),
					IMEI2 nvarchar(60), Entrada nvarchar(60), Salida nvarchar(60), Observacion nvarchar(500));

DROP TABLE Registro

select *from Registro

select *from Registro order by convert(FechaIngreso) desc;

select *from Registro order by (convert(varchar(30), getdate(),103)) AS FechaIngreso;

//arreglar