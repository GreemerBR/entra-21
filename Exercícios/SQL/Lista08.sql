-- Exercício 01
CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR(12),
	data_nascimento DATETIME2,
	idade INTEGER);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Erick Bryan Enrico Vieira',
	 '699.734.958-70',
	 '90.745.276-0',
	 '1989-05-28',
	 29);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Samuel Ruan Dias',
	 '802.790.194-40',
	 '55.318.691-7',
	 '1988-02-08',
	 30);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Fábio Benjamin Souza',
	 '522.445.349-60',
	 '54.715.232-2',
	 '1970-03-22',
	 48);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Elias Miguel Aparicio',
	 '293.928.821-65',
	 '12.680.444-8',
	 '1986-06-07',
	 32);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Alexandre Gustavo Cardoso',
	 '617.408.878-24',
	 '8.888.574-4',
	 '2003-04-15',
	 15);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Kauê Lucca Duarte',
	 '943.163.990-47',
	 '46.977.509-90',
	 '1965-06-15',
	 53);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Marcos Bryan Guilherme Mendes',
	 '955.129.235-95',
	 '84.050.077-4',
	 '2015-02-06',
	 3);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Benedito Pedro Carlos da Mota',
	 '510.505.472-50',
	 '43.588.124-3',
	 '1981-04-19',
	 37);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Luís Igor Barbosa',
	 '370.570.311-06',
	 '40.651.407-0',
	 '2013-05-06',
	 5);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'José Heitor Ramos',
	 '675.624.925-81',
	 '83.962.258-2',
	 '1965-04-11',
	 53);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Lucca Tiago Galvão',
	 '788.124.508-57',
	 '3.293.335-6',
	 '1977-06-17',
	 41);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Tiago Edson Oliveira',
	 '389.969.352-39',
	 '8.198.446-9',
	 '1977-06-09',
	 41);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Enrico Julio Fábio Martins',
	 '529.078.166-83',
	 '99.886.242-30',
	 '2017-03-11',
	 1);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Oliver Victor Benjamin da Mota',
	 '798.556.805-02',
	 '5.103.578-9',
	 '1985-03-27',
	 33);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES(
	'Bryan Caio Lopes',
	 '213.217.201-30',
	 '12.949.454-9',
	 '1970-06-18',
	 48);

SELECT id, nome, cpf, rg, data_nascimento, idade FROM pessoas;

---------------------------------------------------------------------------------------------------------- Exercício 02

CREATE TABLE enderecos (
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	estado VARCHAR(2),
	cidade VARCHAR(140),
	bairro VARCHAR(120),
	cep VARCHAR(10),
	logradouro VARCHAR(250),
	numero INTEGER,
	complemento TEXT);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES(
	'AC',
	'Rio Branco',
	'Ayrton Senna',
	'69.911-866',
	'Estrada Deputado José Rui da Silveira Lino',
	282,
	'Casa');

INSERT INTO enderecos (estado, cidade, bairro, cep, numero) VALUES(
	'SC',
	'Biguaçu',
	'Fundos',
	'88.161-400',
	'Estrada Deputado José Rui da Silveira Lino',
	995);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES(
	'MG',
	'Santa Luzia',
	'Padre Miguel',
	'33.082-050',
	'Rua Buenos Aires',
	371,
	'Apartamento');

INSERT INTO enderecos (estado, bairro, cep, logradouro, numero) VALUES(
	'BA',
	'São Tomé de Paripe',
	'40.800-361',
	'Travessa Luís Hage',
	685);

INSERT INTO enderecos (estado, cidade, bairro, logradouro, numero) VALUES(
	'MG',
	'Ipatinga',
	'Vila Celeste',
	'Rua Antônio Boaventura Batista',
	645);

INSERT INTO enderecos (estado, cidade, bairro, cep, numero) VALUES(
	'RS',
	'Passo Fundo',
	'Nenê Graeff',
	'99.030-250',
	154);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES(
	'AM',
	'Manaus',
	'Petrópolis',
	'69.079-300',
	'Rua Coronel Ferreira Sobrinho',
	2644,
	'Fundos');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero) VALUES(
	'TO',
	'Gurupi',
	'Muniz Santana',
	'77.402-130',
	'Rua Adelmo Aires Negri',
	794);

INSERT INTO enderecos (estado, bairro, logradouro, numero, complemento) VALUES(
	'AC',
	'Preventório',
	'Beco da Ligação II',
	212,
	'Bloco B');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero) VALUES(
	'AP',
	'Santana',
	'Comercial',
	'68.925-073',
	'Rua Calçoene',
	648);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero) VALUES(
	'PB',
	'Cabedelo',
	'Camalaú',
	'58.103-052',
	'Rua Siqueira Campos',
	249);

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos;

UPDATE enderecos SET logradouro = 'Rua Julio Teodoro Martins', completemento = 'Casa' WHERE id = 2;

UPDATE enderecos SET cidade = 'Salvador', completemento = 'Casa' WHERE id = 4;

UPDATE enderecos SET cep = '35.162-484', completemento = 'Bloco C' WHERE id = 5;

UPDATE enderecos SET logradouro = 'Rua Itu', completemento = 'Ap 102' WHERE id = 6;

UPDATE enderecos SET completemento = 'Fundos' WHERE id = 8;

UPDATE enderecos SET Cidade = 'Rio Branco', cep = '69.900-162' WHERE id = 9;

UPDATE enderecos SET completemento = 'Casa' WHERE id = 10;

UPDATE enderecos SET completemento = 'Casa' WHERE id = 11;

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos;
---------------------------------------------------------------------------------------------------------- Exercício 03

CREATE TABLE champions (
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(9),
	descricao VARCHAR(23),
	habilidade1 VARCHAR(21),
	habilidade2 VARCHAR(31),
	habilidade3 VARCHAR(30),
	habilidade4 VARCHAR(20),
	habilidade5 VARCHAR(15));

INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES(
	'Katarina',
	'a Lâmina Sinistra',
	'Voracidade',
	'Lâmina Saltitante',
	'Preparação',
	'Shunpo',
	'Lótus da Morte');

INSERT INTO champions (nome, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES(
	'Yasuo',
	'Estilo do Errante',
	'Tempestade de Aço ',
	'Parede de Vento',
	'Espada Ágil',
	'Último Suspiro');

INSERT INTO champions (nome, descricao, habilidade1) VALUES(
	'Master Yi ',
	'o Espadachim Wuju ',
	'Ataque Duplo ');

INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES(
	'Vayne',
	'a Caçadora Noturna ',
	'Caçadora Noturna',
	'Rolamento',
	'Dardos de Prata',
	'Condenar',
	'Hora Final');

INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4) VALUES(
	'Lee Sin',
	'o Monge Cego',
	'Agitação',
	'Onda Sônica / Ataque Ressonante',
	'Proteger / Vontade de Ferro',
	'Tempestade / Mutilar');

INSERT INTO champions (nome, descricao, habilidade1, habilidade3, habilidade4, habilidade5) VALUES(
	'Vi',
	'a Defensora de Piltover',
	'Blindagem',
	'Pancada Certeira',
	'Força Excessiva',
	'Saque e Enterrada');

INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES(
	'Diana',
	'o Escárnio da Lua ',
	'Espada de Prata Lunar',
	'Golpe Crescente',
	'Cascata Lívida',
	'Colapso Minguante',
	'Zênite Lunar');

INSERT INTO champions (nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES(
	'Annie',
	'a Criança Sombria ',
	'Piromania',
	'Desintegrar',
	'Incinerar',
	'Escudo Fundido',
	'Invocar: Tibbers');

INSERT INTO champions (nome, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5) VALUES(
	'Aatrox',
	'Poço de Sangue',
	'Voo Sombrio ',
	'Sede de Sangue / Preço em Sangue',
	'Lâminas da Aflição',
	'Massacre');

SELECT id, nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5 FROM champions;

UPDATE champions SET descricao = 'o Imperdoável' WHERE id = 2;

UPDATE champions SET habilidade2 = 'Ataque Alpha', habilidade3 = 'Meditar', habilidade4 = 'Eestilo Wuiu', habilidade5 = 'Highlander' WHERE id = 3;

UPDATE champions SET habilidade5 = 'Fúria do Dragão' WHERE id = 5;

UPDATE champions SET habilidade1 = 'Quebra-cofres' WHERE id = 6;

UPDATE champions SET descricao = 'a Espada Darkin' WHERE id = 9;

SELECT id, nome, descricao, habilidade1, habilidade2, habilidade3, habilidade4, habilidade5 FROM champions;