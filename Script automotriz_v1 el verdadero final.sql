--CREATE DATABASE automotriz_v1

----drop database automotriz_v1
--use automotriz_v1

--set dateformat dmy

CREATE TABLE vehiculos(
	
	id_vehiculo int IDENTITY(1,1) NOT NULL,
	modelo varchar(100),
	precio int,
	color varchar(20),
	tipo_v varchar(20),
	activo varchar(2),

	CONSTRAINT PK_id_vehiculo PRIMARY KEY (id_vehiculo),

)

insert into vehiculos(modelo, precio, color, tipo_v) 
values ('Fiesta', 1000000,'Rosa','Hatchbag')
insert into vehiculos(modelo, precio, color, tipo_v) 
values ('Focus', 1000000,'Negro','Sedan')
insert into vehiculos(modelo, precio, color, tipo_v) 
values ('Palio', 1000000,'Negro','Sedan')
insert into vehiculos(modelo, precio, color, tipo_v) 
values ('Hilux', 1000000,'Blanco','Camioneta')



CREATE TABLE autopartes(
	
	id_autoparte int IDENTITY(1,1) NOT NULL,
	nombre varchar(100),
	precio int,
	color varchar(20),
	tipo_a varchar(20),
	activo varchar(2),

	CONSTRAINT PK_id_autoparte PRIMARY KEY (id_autoparte),

)

insert into autopartes(nombre, precio, color, tipo_a)
values ('Optica Golf', 10000, 'Negro', 'Iluminacion')
insert into autopartes(nombre, precio, color, tipo_a)
values ('Diferencial', 10000, 'Negro', 'Interno')
insert into autopartes(nombre, precio, color, tipo_a)
values ('Luneta', 10000, 'Negro', 'Externo')
insert into autopartes(nombre, precio, color, tipo_a)
values ('Axial', 10000, 'Negro', 'Interno')

CREATE TABLE facturas(
    nro_factura int IDENTITY(1,1) NOT NULL,
    
	cliente varchar(100),
	fecha date,
	fecha_baja date,
	total money,
	forma_pago varchar(50)
	
	
	CONSTRAINT PK_nro_factura PRIMARY KEY (nro_factura),
	

)

alter table detalles_facturas
alter column id_vehiculo int

CREATE TABLE detalles_facturas (
    id_detalle_factura int NOT NULL ,
	
	
	cantidad int,
	
	id_autoparte int NOT NULL,
	id_vehiculo int NOT NULL,
	nro_factura int NOT NULL ,
	
	CONSTRAINT PK_id_detalle_factura PRIMARY KEY (id_detalle_factura),
	
	CONSTRAINT id_autoparteFK FOREIGN KEY (id_autoparte)
	REFERENCES autopartes (id_autoparte),

	CONSTRAINT id_vehiculoFK FOREIGN KEY (id_vehiculo)
	REFERENCES vehiculos (id_vehiculo),

	CONSTRAINT FK_nro_factura FOREIGN KEY (nro_factura)
	REFERENCES facturas (nro_factura),
)
-- -------------------------------------------------------------------------------------------------------------------
--SPs

GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_AUTOPARTES]
AS
BEGIN
	
	SELECT * from autopartes;
END
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_VEHICULOS]
AS
BEGIN
	
	SELECT * from vehiculos;
END

GO
ALTER PROCEDURE [dbo].[SP_INSERTAR_VEHICULO] 
	@modelo varchar(100),
	@precio money,
	@color varchar(20),
	@tipo_v varchar(20),
	
	
	@id_vehiculo int OUTPUT

AS
BEGIN
	INSERT INTO vehiculos(modelo, precio, color, tipo_v, activo)
    VALUES (@modelo, @precio, @color, @tipo_v, 'Si');
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @id_vehiculo = SCOPE_IDENTITY();

END
GO
alter PROCEDURE [dbo].[SP_MODIFICAR_VEHICULO] 
	@modelo varchar(100),
	@precio money,
	@color varchar(20),
	@tipo_v varchar(20),

	@id_vehiculo int

AS
BEGIN
	UPDATE vehiculos SET modelo = @modelo, precio = @precio, color = @color, tipo_v = @tipo_v
	WHERE id_vehiculo = @id_vehiculo;
	
END
GO
CREATE PROCEDURE [dbo].[SP_ELIMINAR_VEHICULO] 
	@id_vehiculo int
AS
BEGIN
	UPDATE vehiculos SET activo = 'No'
	WHERE id_vehiculo = @id_vehiculo;
END
GO


Alter PROCEDURE [dbo].[SP_INSERTAR_FACTURA] 

	@cliente varchar(100),	
	@total money,
	@forma_pago varchar(50),
	
	@nro_factura int OUTPUT
    
	

AS
BEGIN
	INSERT INTO facturas(cliente, fecha, total, forma_pago)
    VALUES (@cliente, getdate(), @total, @forma_pago);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @nro_factura = SCOPE_IDENTITY();

END
GO

Alter PROCEDURE [dbo].[SP_CONSULTAR_FACTURAS]
	@fecha_desde Datetime,
	@fecha_hasta Datetime,
	@cliente varchar(50)
AS
BEGIN
	SELECT * 
	FROM facturas
	WHERE (@fecha_desde is null OR fecha >= @fecha_desde)
	AND (@fecha_hasta is null OR fecha <= @fecha_hasta)
	AND (@cliente is null OR cliente LIKE '%' + @cliente + '%')
	--AND fecha_baja is null;
END
GO

CREATE PROCEDURE [dbo].[SP_ELIMINAR_FACTURA] 
	@nro_factura int
AS
BEGIN
	UPDATE facturas SET fecha_baja = GETDATE()
	WHERE nro_factura = @nro_factura;
END
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_MAESTRO] 

	@cliente varchar(100),
	@fecha date,
	@total int,
	@forma_pago varchar(50),
	
	@nro_factura int

AS
BEGIN
	UPDATE facturas SET cliente = @cliente, fecha = @fecha, total = @total, forma_pago = @forma_pago
	WHERE nro_factura = @nro_factura;
	
	DELETE detalles_facturas
	WHERE nro_factura = @nro_factura;
END
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@nro_factura int,
	@id_autoparte int, 
	@id_vehiculo int, 
	@cantidad int


AS
BEGIN
	INSERT INTO detalles_facturas(nro_factura,id_vehiculo, id_autoparte, cantidad)
    VALUES (@nro_factura, @id_vehiculo, @id_autoparte, @cantidad);
  
END
GO

ALTER PROCEDURE [dbo].[SP_CONSULTAR_DETALLES_FACTURA] 
	@nro_factura int
AS
BEGIN
	Declare @grupo int;
	set @grupo = (select count(*)
					from detalles_facturas
					where nro_factura = @nro_factura and id_vehiculo is not null)
if(@grupo >0)
	SELECT df.nro_factura,df.id_detalle_factura, df.id_vehiculo, df.id_autoparte,df.cantidad,
	t2.modelo as Nombre, t2.precio,t2.color,t2.tipo_v as Tipo, t3.cliente, t3.fecha, t3.total, t3.forma_pago
	FROM detalles_facturas df join vehiculos t2 on df.id_vehiculo = t2.id_vehiculo
	join facturas t3 on df.nro_factura = t3.nro_factura	
	WHERE df.nro_factura = @nro_factura;
else
	SELECT df.nro_factura,df.id_detalle_factura,df.id_autoparte, df.id_autoparte,df.cantidad,
	a.nombre as Nombre, a.precio,a.color,a.tipo_a as Tipo, t3.cliente, t3.fecha, t3.total, t3.forma_pago
	FROM detalles_facturas df join autopartes a on df.id_autoparte = a.id_autoparte
	join facturas t3 on df.nro_factura = t3.nro_factura	
	WHERE df.nro_factura = @nro_factura;
END
GO

alter PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT Count(nro_factura)+1  FROM facturas);
END
GO

Update  Vehiculos
set activo = 'Si'


select * from facturas
select * from autopartes

alter table facturas
alter column total money


INSERT INTO facturas(cliente, fecha, total, forma_pago)
    VALUES ('Lauti', '01/01/2022', 5450000, 'Efectivo');

	INSERT INTO detalles_facturas(id_detalle_factura,nro_factura,id_vehiculo,  cantidad)
    VALUES (1, 1,1,  1);

	SELECT * FROM detalles_facturas
EXEC SP_CONSULTAR_DETALLES_FACTURA 1

select count(*)
from detalles_facturas
where nro_factura = 1 and id_vehiculo is not null