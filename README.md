# Gestión de Artículos

Una aplicación hecha para crear, guardar, mostrar, eliminar y búscar tus artículos. Desarrollada en C#, utiliza .Net Framework para la interfaz de usuario y SQL Server para obtener información de los artículos almacenados.

## Características Principales
- **Nuevo Artículo:** Podrás ingresar nuevos artículos a la base de datos.
- **Modificar datos:** de forma rápida y sencilla.
- **Búsqueda:** Permite buscar Artículos por nombre, marca y código.
- **Filtros:** Filtra tus artículos por marca y categoría.
- **Información:** Proporciona detalles almacenados sobre cada artículo, como marca, categoría, precio, y descripción.
- **Eliminar:** Es posible enviar artículos a la papelera.
- **Papelera:** Donde podrás recuperar todos los artículos eliminados antes de cerrar la aplicación. Importante: Los artículos enviados a la papelera serán eliminados de forma permanente una vez cerrada la aplicación.
- **Cierre del programa**: Únicamente preguntará, antes de cerrar el programa y si la papelera tiene artículos, si deseas eliminar todos los artículos. 
- **Interfaz Intuitiva:** Diseño práctico y fácil de usar.

## Tecnologías Utilizadas

- **Lenguaje:** C#
- **.Net Framework:** Utilizado para la interfaz de usuario.
- **SQL Server:** Base de datos proporcionada por el Profesor sin posibilidad de modificarla, se trabajó únicamente con consultas sobre los datos.

## Requisitos de Instalación

- **SQL Server:** Asegúrate de tener SQL Server instalado y configurado en tu sistema.
- **Visual Studio:** Para compilar y ejecutar la aplicación.

## Configuración de la Base de Datos

1. Abre SQL Server.
2. Inicia una "Query" nueva.
3. Copia y pega el siguiente script:
~~~   
USE [master]
GO
/****** Creacion de la BD******/
CREATE DATABASE CATALOGO_DB;
GO

USE [CATALOGO_DB];

-- Crea la tabla ARTICULOS
CREATE TABLE [dbo].[ARTICULOS](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Codigo] VARCHAR(50) NULL,
	[Nombre] VARCHAR(50) NULL,
	[Descripcion] VARCHAR(150) NULL,
	[IdMarca] INT NULL,
	[IdCategoria] INT NULL,
	[ImagenUrl] VARCHAR(1000) NULL,
	[Precio] MONEY NULL,
	CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Crea la tabla CATEGORIAS
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NULL,
	CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Crea la tabla MARCAS
CREATE TABLE [dbo].[MARCAS](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NULL,
	CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED ([Id] ASC)
);

~~~
4. **Ejecuta** el script SQL proporcionado para crear la estructura de la base de datos. Y listo, ahora podrás añadir los artículos que desees! 👍

## Uso

1. Clona el repositorio a tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Configura la base de datos según las instrucciones anteriores.
4. Compila y ejecuta la aplicación.

## Información Adicional
Este proyecto fue creado con fines de aprendizaje. Es menester comprender que su principal objetivo es construir conocimiento.
