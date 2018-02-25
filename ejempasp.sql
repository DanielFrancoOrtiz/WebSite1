create database ejemasp;
use ejemasp;

create table empleado(
id				int 	primary key auto_increment,
nombre_emp		varchar(45) null,
edad			int null,
direccion		varchar(45) null,
telefono		varchar(16) null
);
 
 insert into empleado values(null,'Empleado1',25,'direccion empleado1','4552424242');
 insert into empleado values(null,'Empleado2',30,'direccion empleado2','4552427637');
 select * from empleado;
 
 