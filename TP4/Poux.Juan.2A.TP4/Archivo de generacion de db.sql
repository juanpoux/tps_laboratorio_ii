CREATE DATABASE [Poux.Juan.2A.TPFinal];
GO
USE [Poux.Juan.2A.TPFinal];
GO
CREATE TABLE [Poux.Juan.2A.TPFinal].dbo.Clientes
    (
    id INT IDENTITY(1,1) PRIMARY KEY ,
    nombre VARCHAR(60) NOT NULL,
    telefono VARCHAR(60) NOT NULL ,
    direccion VARCHAR(60) NOT NULL,
    activo BIT NOT NULL,
    );
GO
Insert into Clientes VALUES ('Juan Poux','1166035063','Saavedra 352', 1)
Insert into Clientes VALUES ('Camila Jauregui','1122334455','Diaz Velez 254', 1)
Insert into Clientes VALUES ('Marcos Andrada','1234567891','Gorriti 113', 1)
Insert into Clientes VALUES ('Lucas Vitry','42485006','Colombres 256', 1)
Insert into Clientes VALUES ('Federico Bugallo','68655491','Boedo 554', 1)
Insert into Clientes VALUES ('Ramiro Prieto','1244787593','Pereyra Lucena 1165', 1)
Insert into Clientes VALUES ('Nicolas Campana','45474849','Hipolito Yrigoyen 8932', 1)
Insert into Clientes VALUES ('Ezequiel Scarpini','1566448877','Vieytes 1655', 1)
Insert into Clientes VALUES ('Juan Campi','1166449977','Alvear 2557', 1)
Insert into Clientes VALUES ('Monica Moras','42489012','Comahue 1649', 1)
Insert into Clientes VALUES ('Micaela Gonzalez','1164875695','Fonrouge 295', 1)
Insert into Clientes VALUES ('Miguel Entin','1144995874','Rosales 1233', 1)