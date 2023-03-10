CREATE DATABASE TAREA_PROVEEDORES
GO
USE TAREA_PROVEEDORES

CREATE TABLE tbProveedores
(
		prov_ID						INT IDENTITY (1,1)	PRIMARY KEY,
		prov_Empresa				NVARCHAR(MAX)	NOT NULL,
		prov_NombreContacto			NVARCHAR(MAX)	NOT NULL,
		prov_TelefonoContacto		NVARCHAR(MAX)	NOT NULL,
		prov_DireccionExacta		NVARCHAR(MAX)	NOT NULL,
		prov_DireccionExactaEmpresa	NVARCHAR(MAX)	NOT NULL,
		prov_SexoContacto			CHAR(1)			NOT NULL

		CONSTRAINT CK_prov_SexoContacto CHECK (prov_SexoContacto IN ('F','M') )
);

INSERT INTO tbProveedores
VALUES ('Pet Hipermercado', 'Karla Alejandro Lopez', '9898-9899', 'Choloma, Cort�s', 'San Pedro Sula, Cortes', 'F'),
	   ('Cerveceria Hondure�a', 'Eder S�nchez', '9998-9699', 'Choloma, Cort�s', 'San Pedro Sula, Cortes', 'M'),
	   ('Abarroterias Wendy', 'Wendy Salom�n', '8898-9899', 'La Lima, Cort�s', 'San Pedro Sula, Cortes', 'F'),
	   ('Planta Manufacturera', 'Julieta Reyes', '3898-9899', 'Villanueva, Cort�s', 'San Pedro Sula, Cortes', 'F')

	   select*from tbProveedores