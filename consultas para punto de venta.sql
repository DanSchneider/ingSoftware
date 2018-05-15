drop database p_venta1;

CREATE DATABASE p_venta1;
USE p_venta1;


CREATE TABLE usuarios
(
    ID_USUARIO INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    NOMBRE TEXT,
    APELLIDO_P VARCHAR(20),
    APELLIDO_M VARCHAR(20),
    NICKNAME VARCHAR(20),
    PASSWORD VARCHAR(20)
);

CREATE TABLE `admins` (
  `ID_ADMIN` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE` text DEFAULT NULL,
  `APELLIDO_P` varchar(20) DEFAULT NULL,
  `APELLIDO_M` varchar(20) DEFAULT NULL,
  `NICKNAME` varchar(20) DEFAULT NULL,
  `PASS` varchar(20) DEFAULT NULL,

  PRIMARY KEY (`ID_ADMIN`)
);


CREATE TABLE productos
(
  ID_PRODUCTO INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  NOMBRE TEXT,
  EXISTENCIA INT,
  PRECIO_NETO INT,
  PRECIO_VENTA INT
);


CREATE TABLE ventas
(
  ID_VENTA INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  ID_USUARIO INT,
  ID_PRODUCTO INT,

  FOREIGN KEY (ID_USUARIO) REFERENCES usuarios(ID_USUARIO),
  FOREIGN KEY (ID_PRODUCTO) REFERENCES  productos(ID_PRODUCTO)
);




insert into usuarios values (1,'Luis Gerardo','Roman','Marin','luis5648','12345');


insert into admins values (1,'Jose Luis','Del Toro','Gomez','admin','Administrad0r');

insert into admins values (1,'Jose Luis','Del Toro','Gomez','admin','Administrad0r')

<<<<<<< HEAD
=======
insert into proveedores values (1','Cafe Colombia','CaffeColom@hotmail.com','5556148755');

>>>>>>> 07563f7ea25bffcd481edefce1d8d9485b469cd6
insert into productos values (1,'Cafe americano chico','50','10','16','1')
insert into productos values (2,'Cafe americano mediano','50','13','19','1')
insert into productos values (3,'Cafe americano grande','50','15','21','1')
insert into productos values (4,'Cafe espreso','50','13','16','1')
insert into productos values (5,'Cafe espreso doble','50','16','24','1')


