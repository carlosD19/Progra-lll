CREATE DATABASE progra_db;
--Pasarse a la base de datos y crear la tabla
CREATE TABLE public.usuario
(
    id serial NOT NULL PRIMARY KEY,
    cedula text NOT NULL UNIQUE,
    usuario text NOT NULL UNIQUE,
    nombre text NOT NULL ,
    apellido_uno text NOT NULL,
    apellido_dos text NOT NULL,
    pass text NOT NULL,
    email text NOT NULL UNIQUE
);

--Insertar dos usuarios.
