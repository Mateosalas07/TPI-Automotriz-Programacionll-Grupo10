--CREATE DATABASE Automotrizp

--drop database Automotrizp

use Automotrizp
go
CREATE TABLE Tipo_Vehiculos (
    id_tipo_vehiculo int not NULL, 
	tipo_vehiculo varchar (50) not NULL,
    CONSTRAINT PK_id_tipo_vehiculo PRIMARY KEY (id_tipo_vehiculo)
)

CREATE TABLE Marcas (
    id_marca int not NULL, 
	marca varchar (50) not NULL,
    CONSTRAINT PK_id_marca PRIMARY KEY (id_marca)
)

-- IN Marca
insert into Marcas(id_marca, marca) values (1, 'Fiat')
insert into Marcas(id_marca, marca) values (2, 'Renault')
insert into Marcas(id_marca, marca) values (3, 'Ford')
insert into Marcas(id_marca, marca) values (4, 'Volkswagen')
insert into Marcas(id_marca, marca) values (5, 'Toyota')
insert into Marcas(id_marca, marca) values (6, 'Peugeot')

CREATE TABLE Modelos(
id_modelo int not NULL,
modelo varchar (50) not NULL,

id_marca int not NULL,
id_tipo_vehiculo int not NULL, 

CONSTRAINT PK_id_modelo PRIMARY KEY (id_modelo),

CONSTRAINT id_marca_FK_Mo FOREIGN KEY (id_marca)
REFERENCES Marcas (id_marca),

CONSTRAINT id_tipo_vehiculo_FK_Mo FOREIGN KEY (id_tipo_vehiculo)
REFERENCES Tipo_Vehiculos (id_tipo_vehiculo)


)

-- IN Tipos vehiculo
insert into Tipo_Vehiculos(id_tipo_vehiculo, tipo_vehiculo) values (1, 'Camioneta')
insert into Tipo_Vehiculos(id_tipo_vehiculo, tipo_vehiculo) values (2, 'Hatchbag')
insert into Tipo_Vehiculos(id_tipo_vehiculo, tipo_vehiculo) values (3, 'Sedan')
insert into Tipo_Vehiculos(id_tipo_vehiculo, tipo_vehiculo) values (4, 'Utilitario')
insert into Tipo_Vehiculos(id_tipo_vehiculo, tipo_vehiculo) values (5, 'SUV')
insert into Tipo_Vehiculos(id_tipo_vehiculo, tipo_vehiculo) values (6, 'Berlina')

--IN Modelos
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (1, 'Palio', 1, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (2, 'Cronos', 1, 3)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (3, 'Argo', 1, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (4, 'Toro', 1, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (5, 'Fiorino', 1, 4)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (6, 'Cubo', 1, 4)

insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (7, 'Focus', 3, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (8, 'Fiesta', 3, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (9, 'Ka', 3, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (10, 'Ranger', 3, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (11, 'Raptor', 3, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (12, 'Eco-sport', 3, 5)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (13, 'Maverick', 3, 1)

insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (14, 'Clio', 2, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (15, 'Logan', 2, 3)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (16, 'Sandero', 2, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (17, 'Oroch', 2, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (18, 'Duster', 2, 5)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (19, 'Alaskan', 2, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (20, 'Kangoo', 2, 4)

insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (21, 'Polo', 4, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (22, 'Gol', 4, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (23, 'Golf', 4, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (24, 'Virtus', 4, 3)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (25, 'Voyage', 4, 3)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (26, 'Amarok', 4, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (27, 'Suran', 4, 5)

insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (28, 'Etios', 5, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (29, 'Corolla', 5, 3)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (30, 'Yaris', 5, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (31, 'Hilux', 5, 1)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (32, 'Rav4', 5, 5)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (33, 'Sw4', 5, 5)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (34, 'Prius', 5, 3)

insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (35, '208', 6, 2)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (36, '3008', 6, 5)
insert into Modelos(id_modelo, modelo, id_marca, id_tipo_vehiculo) values (37, 'Partner', 6, 4)


CREATE TABLE Vehiculos (
    id_vehiculo int NOT NULL ,
    
	descripcion varchar (50),
	precio_act int not NULL,
	año date not NULL,
    color varchar (20) not NUll,

	id_modelo int Not Null,
	
	CONSTRAINT PK_id_Vehiculo PRIMARY KEY (id_vehiculo),
	
	CONSTRAINT FK_id_modelo_Ve FOREIGN KEY (id_modelo)
	REFERENCES Modelos (id_modelo)

)

-- In Vehiculo
select * from Vehiculos

insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (1, '', 1500000, '09-06-2022', 'Rosa',21)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (2, '', 1500000, '10-05-2021', 'Negro',21)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (3, 'Gama media Ford', 2500000, '03-20-2022', 'Azul',8)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (4, 'Ruedas Bridgestone', 4000000, '08-21-2020', 'Blanco',33)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (5, '', 1800000, '05-08-2019', 'Gris', 23)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (6, '', 1200000, '10-05-2018', 'Marron',22)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (7, '', 1500000, '07-05-2020', 'Negro', 20)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (8, '', 2800000, '07-05-2022', 'Gris',25)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo) 
values (9, '', 3000000, '08-08-2022', 'Azul',24)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (10, '', 1500000, '06-16-2020', 'Rojo',28)
insert into Vehiculos(id_vehiculo, descripcion, precio_act, año, color, id_modelo ) 
values (11, '', 1500000, '10-18-2021', 'Rojo',28)

--Todo para Clientes

CREATE TABLE Paises (
    id_pais int not NULL, 
	pais varchar (50) not NULL,
    CONSTRAINT PK_id_pais PRIMARY KEY (id_pais)
)

insert into Paises(id_pais, pais) values(1, 'Argentina')
insert into Paises(id_pais, pais) values(2, 'Brasil')
insert into Paises(id_pais, pais) values(3, 'Mexico')
insert into Paises(id_pais, pais) values(4, 'Uruguay')
insert into Paises(id_pais, pais) values(5, 'Peru')
insert into Paises(id_pais, pais) values(6, 'Colombia')

CREATE TABLE Provincias(
id_provincia int not NULL,
provincia varchar (50) not NULL,
id_pais int not NULL,


CONSTRAINT PK_id_provincia PRIMARY KEY (id_provincia),
CONSTRAINT FK_id_pais FOREIGN KEY (id_pais)
REFERENCES Paises (id_pais)
)

insert into Provincias(id_provincia, provincia, id_pais) values(1, 'Cordoba', 1)
insert into Provincias(id_provincia, provincia, id_pais) values(2, 'Buenos Aires', 1)
insert into Provincias(id_provincia, provincia, id_pais) values(3, 'Misiones', 1)
insert into Provincias(id_provincia, provincia, id_pais) values(4, 'Mendoza', 1)

CREATE TABLE Localidades(
id_localidad int not NULL,
localidad varchar (50) not NULL,
id_provincia int not NULL,

CONSTRAINT PK_id_localidad PRIMARY KEY (id_localidad),
CONSTRAINT FK_id_provincia FOREIGN KEY (id_provincia)
REFERENCES Provincias (id_provincia)
)

insert into Localidades(id_localidad, localidad, id_provincia) values(1, 'Capital', 1)
insert into Localidades(id_localidad, localidad, id_provincia) values(2, 'Cosquin', 1)
insert into Localidades(id_localidad, localidad, id_provincia) values(3, 'Los Reartes', 1)

CREATE TABLE Barrios(
id_barrio int not NULL,
barrio varchar (50) not NULL,
id_localidad int not NULL,


CONSTRAINT PK_id_barrio PRIMARY KEY (id_barrio),
CONSTRAINT FK_id_localidad FOREIGN KEY (id_localidad)
REFERENCES Localidades (id_localidad)
)

insert into Barrios(id_barrio, barrio, id_localidad) values(1, 'San Carlos', 1)
insert into Barrios(id_barrio, barrio, id_localidad) values(2, 'San Vicente', 1)
insert into Barrios(id_barrio, barrio, id_localidad) values(3, 'Villa Revol', 1)
insert into Barrios(id_barrio, barrio, id_localidad) values(4, 'Observatorio', 1)


CREATE TABLE Tipos_Clientes (
    id_tipo_cliente int not NULL, 
	tipo_cliente varchar (50) not NULL,
    CONSTRAINT PK_id_tipo_cliente PRIMARY KEY (id_tipo_cliente)
)

insert into Tipos_Clientes(id_tipo_cliente, tipo_cliente) values(1, 'Consumidor Final')
insert into Tipos_Clientes(id_tipo_cliente, tipo_cliente) values(2, 'Responsable Inscripto')
insert into Tipos_Clientes(id_tipo_cliente, tipo_cliente) values(3, 'Sociedad Anonima')
insert into Tipos_Clientes(id_tipo_cliente, tipo_cliente) values(4, 'Autonomo')


CREATE TABLE Clientes (
    cod_cliente int NOT NULL ,
    
	nombre varchar (50)not NULL,
	apellido varchar (50)not NULL,
	telefono varchar(50),
	correo varchar (50),
	calle varchar (50),
    altura int,
	
	id_tipo_cliente int not NULL,
	id_barrio int not NULL,
	
	CONSTRAINT PK_cod_cliente PRIMARY KEY (cod_cliente),
	
	CONSTRAINT FK_id_tipo_cliente FOREIGN KEY (id_tipo_cliente)
	REFERENCES Tipos_Clientes (id_tipo_cliente),

	CONSTRAINT FK_id_barrio FOREIGN KEY (id_barrio)
	REFERENCES Barrios (id_barrio)

)
select * from Clientes
-- In Clientes
insert into Clientes (cod_cliente, nombre, apellido, telefono, correo, calle, altura, id_tipo_cliente, id_barrio)
values(1, 'Martin', 'Rivolta', '3513445563', 'mrivolta@gmail.com', 'Concepcion de Mayo', 3322, 1, 1)
insert into Clientes (cod_cliente, nombre, apellido, telefono, correo, calle, altura, id_tipo_cliente, id_barrio)
values(2, 'Ricardo', 'Casero', '3515443413', 'rcasero@gmail.com', 'Bv los andes', 4552, 2, 2)
insert into Clientes (cod_cliente, nombre, apellido, telefono, correo, calle, altura, id_tipo_cliente, id_barrio)
values(3, 'Manuel', 'Gomez', '3513146289', 'mgomez@gmail.com', 'Ituzaingo', 3253, 3, 2)
insert into Clientes (cod_cliente, nombre, apellido, telefono, correo, calle, altura, id_tipo_cliente, id_barrio)
values(4, 'Lucas', 'Rodriguez', '3524598563', 'lrodriguez@gmail.com', 'Pampayasta', 1633, 3, 1)


--Todo para Facturas
CREATE TABLE Metodos_pago (
    id_forma_pago int not NULL, 
	forma_pago varchar (50) not NULL,
    CONSTRAINT PK_id_forma_pago PRIMARY KEY (id_forma_pago)
)

-- In Metodos
insert into Metodos_pago(id_forma_pago, forma_pago) values (1, 'Efectivo')
insert into Metodos_pago(id_forma_pago, forma_pago) values (2, 'Transferencia')
insert into Metodos_pago(id_forma_pago, forma_pago) values (3, 'Tarjeta Debito')
insert into Metodos_pago(id_forma_pago, forma_pago) values (4, 'Otro/a Convenir')


CREATE TABLE Facturas(
    nro_factura int NOT NULL ,
    
	fecha date not NULL,
	fecha_baja date,
	
	id_forma_pago int not NULL,
	cod_cliente int not NULL,
	
	CONSTRAINT PK_nro_factura PRIMARY KEY (nro_factura),
	
	CONSTRAINT id_forma_pago_FK FOREIGN KEY (id_forma_pago)
	REFERENCES Metodos_pago (id_forma_pago),

	CONSTRAINT cod_clienteFK FOREIGN KEY (cod_cliente)
	REFERENCES Clientes (cod_cliente),

)

-- in Facturas
insert into Facturas(nro_factura, fecha, id_forma_pago, cod_cliente) values (1, '02/01/2022', 2, 1)
insert into Facturas(nro_factura, fecha, id_forma_pago, cod_cliente) values (2, '02/01/2022', 2, 1)

insert into Facturas(nro_factura, fecha, id_forma_pago, cod_cliente) values (3, '10/03/2022', 1, 2)

insert into Facturas(nro_factura, fecha, id_forma_pago, cod_cliente) values (4, '02/04/2022', 1, 1)
insert into Facturas(nro_factura, fecha, id_forma_pago, cod_cliente) values (5, '12/04/2022', 3, 4)

select * from Facturas

CREATE TABLE Autopartes (
    id_autoparte int not NULL, 
	
	nombre varchar (50) not NULL,
	descripcion varchar (50) not NULL,
	precio_act int not NULL,
    color varchar (20),
	CONSTRAINT PK_id_autoparte PRIMARY KEY (id_autoparte)
)

insert into Autopartes (id_autoparte, nombre, descripcion, precio_act, color) 
values (1, 'Optica', 'Golf gti de primera gen.', 25000, 'Gris')
insert into Autopartes (id_autoparte, nombre, descripcion, precio_act, color) 
values (2, 'Paragolpe', 'Sandero logan Brasilero.', 40000, 'Naranja')
insert into Autopartes (id_autoparte, nombre, descripcion, precio_act, color) 
values (3, 'Axial', 'Amarok 4x2 aspirado.', 150000, 'Azul')
insert into Autopartes (id_autoparte, nombre, descripcion, precio_act, color) 
values (4, 'Diferencial', 'Peugeot 208 Mexicano delantero.', 500000, 'Negro')

--Detalles Facturas
CREATE TABLE Detalles_facturas (
    id_detalle_factura int NOT NULL ,
	
	precio int not NULL,
	cantidad int not NULL,
	
	id_autoparte int,
	id_vehiculo int,
	nro_factura int not NULL,
	
	CONSTRAINT PK_id_detalle_factura PRIMARY KEY (id_detalle_factura),
	
	CONSTRAINT id_autoparteFK FOREIGN KEY (id_autoparte)
	REFERENCES Autopartes (id_autoparte),

	CONSTRAINT id_vehiculoFK FOREIGN KEY (id_vehiculo)
	REFERENCES Vehiculos (id_vehiculo),

	CONSTRAINT FK_nro_factura FOREIGN KEY (nro_factura)
	REFERENCES Facturas (nro_factura),
)

set dateformat mdy