CREATE TABLE trabalhos (
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(100),
	subtitulo VARCHAR(50),
	descricao TEXT, -- armazena textos grandes
	data_publicacao DATETIME2, -- data e hora
	tipo VARCHAR(15)
);

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo',
	'Como degustar uma pizza de calabresa',
	'Grande descrição aki',
	'1994-06-04',
	'Receita');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean code',
	'Como trabalhar melhor no seu dia-a-dia',
	'Utilizar var no lugar de tipo primitivos, Identar seu código, Utilizar constantes',
	'2000-03-20',
	'Leitura técnica');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo',
	'Aprenda o que não fazer na sua vida',
	'Jogue o pudim no lixo e faça outro',
	'2022-07-06',
	'Receita');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados',
	'Como sofrer sem saber, porém é necessário',
	'Importante para aprender fifo, lifo, fefo, listas encadeadas',
	'1980-05-11',
	'Leitura técnica');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Strogonoff de frango',
	'A vitória da batata palha',
	'Compre frango e batata palha, jogue na penela, acenda o fogão, espera 5 minutinhos e ta plonto o sorvetinho',
	'2000-09-10',
	'Receita');

SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo
	FROM trabalhos;

-- Concatenar duas columas dando um título para a coluna
SELECT
	CONCAT(titulo, ' - ', subtitulo) AS 'Título completo'
	FROM trabalhos;

-- Consultar a descrição, limitando a quantidade de caracteres
SELECT
	titulo AS 'Título',
	CONCAT(SUBSTRING(descricao, 0, 30), '...') AS 'Descrição'
	FROM trabalhos;

-- Consultar os trabalhos filtrando por ano da publicacao entre 1990 até 2010
SELECT id, titulo, data_publicacao
	FROM trabalhos
	WHERE YEAR(data_publicacao) >= 1990	AND
	YEAR(data_publicacao) <= 2010;

-- Consultar data publicação formato BR huehue
-- BR: dia/mes/ano
SELECT id, titulo,
	CONCAT(
	DAY(data_publicacao),'/',
	MONTH(data_publicacao), '/',
	YEAR(data_publicacao)) as 'Data BR'
	FROM trabalhos;

-- Consultar data publicação formatando no padrão BR, utilizando função para isso
SELECT id, titulo,
	FORMAT(data_publicacao, 'dd/MM/yyyy') AS 'Data BR'
	FROM trabalhos;

-- Limitar a consulta para dois registros
SELECT TOP(2) id, titulo FROM trabalhos;

-- Apresentando o código, nome, preço, se está favoritado
-- Filtando por Placa mãe ou Placa de vídeo em ordem decrescente de preço
--SELECT TOP(20) id, nome, preco, favoritado
--	FROM produtos
--	WHERE categoria = 'Placa mãe' OR categoria = 'Placa de vídeo'
--	ORDER BY preco DESC;

-- Consulta com paginação apresentando 2 registros na página 1
SELECT TOP(2) id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros na página 2
SELECT TOP(2) id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros na página 3
SELECT TOP(2) id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;