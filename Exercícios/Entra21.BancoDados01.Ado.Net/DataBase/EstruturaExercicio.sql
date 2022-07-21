CREATE TABLE cidades(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_unidade_federativa INTEGER,
	nome VARCHAR(30),
	quantidade_habitantes INTEGER,
	data_hora_fundacao DATETIME2,
	pib DECIMAL(17,2)
	);

CREATE TABLE unidades_federativas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(20),
	sigla VARCHAR(2)
	);