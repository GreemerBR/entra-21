-- Exercício 01
CREATE TABLE pessoas(
	nome VARCHAR(100),
	cpf VARCHAR(14) PRIMARY KEY,
	rg VARCHAR(12),
	data_nascimento DATETIME2,
	idade INTEGER
	);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Erick Bryan Enrico Vieira',
	 '699.734.958-70',
	 '90.745.276-0',
	 '1989-05-28',
	 29);