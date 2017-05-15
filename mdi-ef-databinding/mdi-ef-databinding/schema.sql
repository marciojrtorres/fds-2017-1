CREATE TABLE Contato (
	Id INT IDENTITY PRIMARY KEY,
	Nome NVARCHAR(20),
	Sobrenome NVARCHAR(20)
);

CREATE TABLE Telefone (
	Id INT IDENTITY PRIMARY KEY,
	Tipo INT,
	Numero NVARCHAR(15),
	ContatoId INT,
	FOREIGN KEY (ContatoId)
	REFERENCES Contato (Id)
);

INSERT INTO Contato (Nome, Sobrenome)
VALUES ('Mauricio', 'Jost');

INSERT INTO Contato (Nome, Sobrenome)
VALUES ('Guilherme', 'Reguffe');

INSERT INTO Telefone (Tipo, Numero, ContatoId)
VALUES (0, '999882233', 1);

INSERT INTO Telefone (Tipo, Numero, ContatoId)
VALUES (0, '21213344', 1);

INSERT INTO Telefone (Tipo, Numero, ContatoId)
VALUES (0, '77882233', 2);
