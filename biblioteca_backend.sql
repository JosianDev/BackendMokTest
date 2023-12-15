-- Crear la base de datos Biblioteca
CREATE DATABASE Biblioteca;
GO

-- Usar la base de datos Biblioteca
USE Biblioteca;
GO

-- Crear la tabla Books para almacenar información sobre libros
CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255),
    Author VARCHAR(255),
    Genre VARCHAR(50),
    PublishDate DATE
);
GO

-- Crear la tabla Users para almacenar información sobre usuarios para JWT
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(256) NOT NULL
);
GO
