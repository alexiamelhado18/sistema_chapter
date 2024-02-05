CREATE DATABASE Chapter;

USE Chapter;

CREATE TABLE Livros (
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);

