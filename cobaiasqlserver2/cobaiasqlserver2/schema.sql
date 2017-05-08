-- DDL ou SCHEMA
CREATE TABLE Clientes (
	Id INT IDENTITY,
	Nome NVARCHAR(50),
	PRIMARY KEY (Id)
);

CREATE TABLE Pedidos (
	Id INT IDENTITY,
	Descricao TEXT,
	ClienteId INT,
	PRIMARY KEY (Id),
	FOREIGN KEY (ClienteId) REFERENCES Clientes (Id)
);