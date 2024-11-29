create database Hotel;
use Hotel;

create table Usuarios(
    idUsuario int primary key auto_increment,
    Username varchar(255) unique,
    Password varchar(255),
    Rol enum('Administrador', 'Empleado')
);
alter table Usuarios add column Nombre varchar(255);
alter table Usuarios add column Apellidos varchar(255);
describe Usuarios;

create table Clientes(
    idCliente int primary key auto_increment,
    Nombre varchar(255),
    ApellidoP varchar(255),
    ApellidoM varchar(255)
);
alter table Clientes add column Email varchar(255);
alter table Clientes add column Telefono varchar(10);
describe Clientes;
select * from clientes;

drop table Habitaciones;
create table Habitaciones(
    idHabitacion int primary key auto_increment,
    Tipo enum('Simple', 'Suite'),
    Capacidad int,
    PrecioNoche decimal(10,2),
    Estado enum('Disponible', 'Ocupada'),
    Descripcion varchar(255)
);
describe Habitaciones;
select * from clientes;
select * from usuarios;
select * from habitaciones;

create table reservaciones(
    idReservacion int primary key auto_increment,
    FK_IdCliente int,
    FK_IdHabitacion int,
    Dias int,
    FechaReservacion timestamp default current_timestamp,
    FechaTermino date
);


------------------- PROCEDIMIENTOS ALMACENADOS -------------------------

-- CRUD Usuarios --
drop procedure if exists p_AgregarUsuario;
create procedure p_AgregarUsuario(
    in p_Username varchar(255),
    in p_Password varchar(255),
    in p_Rol varchar(255),
    in p_Nombre varchar(255),
    in p_Apellidos varchar(255)
)
begin
    if p_Rol in ('Administrador', 'Empleado') then
        insert into Usuarios (Username, Password, Rol, Nombre, Apellidos)
        values (p_Username, p_Password, p_Rol, p_Nombre, p_Apellidos);
    else
        signal sqlstate '45000'
        set message_text = 'El rol ingresado no es válido. Debe ser Administrador o Empleado.';
    end if;
end;

drop procedure if exists p_EditarUsuario;
create procedure p_EditarUsuario(
    in p_idUsuario int,
    in p_Username varchar(255),
    in p_Password varchar(255),
    in p_Rol varchar(255),
    in p_Nombre varchar(255),
    in p_Apellidos varchar(255)
)
begin
    if p_Rol in ('Administrador', 'Empleado') then
        update Usuarios 
            set Username = p_Username,
                Password = p_Password,
                Rol = p_Rol,
                Nombre = p_Nombre,
                Apellidos = p_Apellidos
            where idUsuario = p_idUsuario;
    else 
        signal sqlstate '45000'
        set message_text = 'El rol ingresado no es valido. Debe de ser Administrador o Empleado.';
    end if;
end;

drop procedure if exists p_EliminarUsuario;
create procedure p_EliminarUsuario(
    in p_idUsuario int
)
begin
    delete from Usuarios where idUsuario = p_idUsuario;
end;

-- CRUD Clientes --
drop procedure if exists p_AgregarCliente;
create procedure p_AgregarCliente(
    in p_Nombre varchar(255),
    in p_ApellidoP varchar(255),
    in p_ApellidoM varchar(255), 
    in p_Email varchar(255),
    in p_Telefono varchar(10)
)
begin
    insert into Clientes (Nombre, ApellidoP, ApellidoM, Email, Telefono)
    values (p_Nombre, p_ApellidoP, p_ApellidoM, Email, Telefono);
end;

drop procedure if exists p_EditarCliente;
create procedure p_EditarCliente(
    in p_idCliente int,
    in p_Nombre varchar(255),
    in p_ApellidoP varchar(255),
    in p_ApellidoM varchar(255),
    in p_Email varchar(255),
    in p_Telefono varchar(10)
)
begin
    update Clientes
    set Nombre = p_Nombre,
        ApellidoP = p_ApellidoP,
        ApellidoM = p_ApellidoM,
        Email = p_Email,
        Telefono = p_Telefono
    where idCliente = p_idCliente;
end;

drop procedure if exists p_EliminarCliente;
create procedure p_EliminarCliente(
    in p_idCliente int
)
begin
    delete from Clientes where idCliente = p_idCliente;
end;


-- CRUD Habitaciones --
drop procedure if exists p_AgregarHabitacion;
create procedure p_AgregarHabitacion(
    in p_Tipo varchar(50),
    in p_Capacidad int,
    in p_PrecioNoche decimal(10,2),
    in p_Estado varchar(50),
    in p_Descripcion varchar(255)
)
begin
    if p_Tipo in ('Simple', 'Suite') 
    and p_Estado in ('Disponible', 'Ocupada') then
        insert into Habitaciones (Tipo, Capacidad, PrecioNoche, Estado, Descripcion)
        values (p_Tipo, p_Capacidad, p_PrecioNoche, p_Estado, p_Descripcion);
    else
        signal sqlstate '45000'
        set message_text = 'El tipo o el estado ingresado no es válido.';
    end if;
end;

drop procedure if exists p_EditarHabitacion;
create procedure p_EditarHabitacion(
    in p_idHabitacion int,
    in p_Tipo varchar(50),
    in p_Capacidad int,
    in p_PrecioNoche decimal(10,2),
    in p_Estado varchar(50),
    in p_Descripcion varchar(255)
)
begin
    if p_Tipo in ('Simple', 'Suite') 
    and p_Estado in ('Disponible', 'Ocupada') then
        update Habitaciones
        set Tipo = p_Tipo,
            Capacidad = p_Capacidad,
            PrecioNoche = p_PrecioNoche,
            Estado = p_Estado,
            Descripcion = p_Descripcion
        where idHabitacion = p_idHabitacion;
    else
        signal sqlstate '45000'
        set message_text = 'El tipo o el estado ingresado no es válido.';
    end if;
end;

drop procedure if exists p_EliminarHabitacion;
create procedure p_EliminarHabitacion(
    in p_idHabitacion int
)
begin
    delete from Habitaciones where idHabitacion = p_idHabitacion;
end;


-- CRUD Reservaciones --
DROP PROCEDURE IF EXISTS p_AgregarReservacion;
CREATE PROCEDURE p_AgregarReservacion(
    IN p_FK_IdCliente INT,
    IN p_FK_IdHabitacion INT,
    IN p_Dias INT
)
BEGIN
    -- Verificar existencia del cliente y la habitación
    IF EXISTS (SELECT 1 FROM Clientes WHERE idCliente = p_FK_IdCliente)
    AND EXISTS (SELECT 1 FROM Habitaciones WHERE idHabitacion = p_FK_IdHabitacion) THEN
        
        -- Insertar la reservación y calcular la FechaTermino
        INSERT INTO Reservaciones (FK_IdCliente, FK_IdHabitacion, Dias, FechaTermino)
        VALUES (p_FK_IdCliente, p_FK_IdHabitacion, p_Dias, 
                DATE_ADD(NOW(), INTERVAL p_Dias DAY));
        
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'El cliente o la habitación no existen.';
    END IF;
END;


drop procedure if exists p_EliminarReservacion;
create procedure p_EliminarReservacion(
    in p_idReservacion int
)
begin
    delete from Reservaciones where idReservacion = p_idReservacion;
end;

--------------------------------- VALIDAR LOGIN ---------------------------------
DROP procedure if exists p_validar; 
create procedure p_validar
(
	in _user varchar(255),
	in _pass varchar(255)
)
begin 

	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE Username = _user AND Password = _pass INTO x;
	if x > 0 then
		SELECT 'Correcto' AS rs, (SELECT Rol FROM usuarios WHERE Username = _user) AS Nivel;
	ELSE
		SELECT 'Error' AS rs, 0 AS Nivel;
	END if;
END;

------------------------------- REGISTROS ---------------------------------------
CALL p_AgregarUsuario('pepin', SHA1('1234'), 'Administrador');
CALL p_AgregarUsuario('pepinilla', SHA1('1234'), 'Empleado');

CALL p_AgregarCliente('Juan', 'Pérez', 'Martínez');
CALL p_AgregarCliente('Ana', 'López', 'Hernández');

CALL p_AgregarHabitacion('Individual', 1, 500.00, 'Disponible', 'Habitación pequeña para una persona');
CALL p_AgregarHabitacion('Matrimonial', 2, 800.00, 'Disponible', 'Habitación para parejas con cama matrimonial');

CALL p_AgregarReservacion(1, 1, 3, '2024-11-30'); -- Juan Pérez reservando habitación individual por 3 días
CALL p_AgregarReservacion(2, 2, 5, '2024-12-05'); -- Ana López reservando habitación matrimonial por 5 días
CALL p_AgregarReservacion(1, 1, 7);
CALL p_EditarReservacion(1, 1, 2, 10);

CALL p_validar('pepinilla',sha1('1234'));
----------------------------- VISTAS -------------------------------------------
select * from Usuarios;
select * from Clientes;
select * from Habitaciones;
select * from Reservaciones;

drop view Historial_Cliente;
create view Historial_Cliente as
select  c.idCliente as ID,
        c.Nombre as Nombre_Cliente, 
        c.ApellidoP as Apellido_Pat, 
        c.ApellidoM as Apellido_Mat, 
        h.idHabitacion as Habitacion, 
        h.Tipo as Tipo, 
        r.dias as dias,
        r.FechaReservacion as Fecha_De_Reservacion,
        r.FechaTermino as Fecha_De_Termino
    from Reservaciones as r 
    Left join Clientes as c on c.idCliente = r.FK_IdCliente
    Left join Habitaciones as h on r.FK_IdHabitacion = h.idHabitacion;

select * from Historial_Cliente where ID = 2;
select * from Historial_Cliente where ID = 1;
select * from Clientes;

drop view Vista_Reservaciones;
CREATE VIEW Vista_Reservaciones AS
SELECT 
    r.idReservacion AS ID,
    c.Nombre AS Nombre_Cliente,
    c.ApellidoP AS Apellido_Paterno,
    c.ApellidoM AS Apellido_Materno,
    h.idHabitacion AS ID_Habitacion,
    h.Tipo AS Tipo_Habitacion,
    r.Dias AS Dias_Reservados,
    r.FechaReservacion AS Fecha_Inicio,
    r.FechaTermino AS Fecha_Fin
FROM 
    Reservaciones r
JOIN 
    Clientes c ON r.FK_IdCliente = c.idCliente
JOIN 
    Habitaciones h ON r.FK_IdHabitacion = h.idHabitacion;

select * from Vista_Reservaciones where Nombre_Cliente = "Ana";
select * from habitaciones;

