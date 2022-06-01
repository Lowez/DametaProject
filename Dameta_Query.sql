CREATE DATABASE dameta_db
GO

USE dameta_db
GO

-- Creates Table
CREATE TABLE cargos (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_CARGOS PRIMARY KEY(id)
);
GO

CREATE TABLE generos (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_GENEROS PRIMARY KEY(id)
);
GO

CREATE TABLE estados (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	UF NVARCHAR(2) NOT NULL,
	CONSTRAINT PK_ESTADOS PRIMARY KEY(id)
);
GO

CREATE TABLE cidades (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_CIDADES PRIMARY KEY(id)
);
GO

CREATE TABLE estoque (
	id INT IDENTITY(1,1),
	qtd INT NOT NULL,
	CONSTRAINT PK_ESTOQUE PRIMARY KEY(id)
);
GO

CREATE TABLE tipo_produtos (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_TIPO_PRODUTOS PRIMARY KEY(id)
);
GO

CREATE TABLE fornecedores (
	id INT IDENTITY(1,1),
	nome NVARCHAR(100) NOT NULL,
	telefone NVARCHAR(14) NOT NULL,
	CNPJ NVARCHAR(16) NOT NULL,
	CONSTRAINT PK_FORNECEDORES PRIMARY KEY(id)
);
GO

CREATE TABLE estabelecimentos (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	nome_rua NVARCHAR(50) NOT NULL,
	numero INT NOT NULL,
	telefone NVARCHAR(14) NOT NULL,
	CEP NVARCHAR(9) NOT NULL,
	estados_id INT NOT NULL,
	cidades_id INT NOT NULL,
	CONSTRAINT PK_ESTABELECIMENTOS PRIMARY KEY(id),
	CONSTRAINT FK_ESTADOS_ESTABELECIMENTOS FOREIGN KEY(estados_id) REFERENCES estados(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_CIDADES_ESTABELECIMENTOS FOREIGN KEY(cidades_id) REFERENCES cidades(id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE funcionarios (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	nascimento DATE NOT NULL CONSTRAINT DF_NASC_FUNCIONARIO DEFAULT GETDATE(),
	email NVARCHAR(100) NOT NULL,
	CPF NVARCHAR(14) NOT NULL,
	senha NVARCHAR(50) NOT NULL,
	salario MONEY NOT NULL,
	generos_id INT NOT NULL,
	cargos_id INT NOT NULL,
	estabelecimentos_id INT NOT NULL,
	CONSTRAINT PK_FUNCIONARIOS PRIMARY KEY(id),
	CONSTRAINT FK_GENEROS_FUNCIONARIOS FOREIGN KEY(generos_id) REFERENCES generos(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_CARGOS_FUNCIONARIOS FOREIGN KEY(cargos_id) REFERENCES cargos(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_ESTABELECIMENTOS_FUNCIONARIOS FOREIGN KEY(estabelecimentos_id) REFERENCES estabelecimentos(id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE premium_usuarios (
	id INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	nascimento DATE NOT NULL CONSTRAINT DF_NASC_USUARIO DEFAULT GETDATE(),
	CPF NVARCHAR(14) NOT NULL,
	telefone NVARCHAR(14) NOT NULL,
	CEP NVARCHAR(10),
	estados_id INT NOT NULL,
	cidades_id INT NOT NULL,
	generos_id INT NOT NULL,
	CONSTRAINT PK_USUARIOS PRIMARY KEY(id),
	CONSTRAINT FK_GENEROS_USUARIOS FOREIGN KEY(generos_id) REFERENCES generos(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_ESTADOS_USUARIOS FOREIGN KEY(estados_id) REFERENCES estados(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_CIDADES_USUARIOS FOREIGN KEY(cidades_id) REFERENCES cidades(id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE produtos (
	cod_produto INT NOT NULL,
	nome NVARCHAR(100) NOT NULL,
	preco MONEY NOT NULL,
	tipo_produtos_id INT NOT NULL,
	fornecedores_id INT NOT NULL,
	estoque_id INT NOT NULL,
	CONSTRAINT PK_PRODUTOS PRIMARY KEY(cod_produto),
	CONSTRAINT FK_TIPOPRODUTOS_PRODUTOS FOREIGN KEY(tipo_produtos_id) REFERENCES tipo_produtos(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_FORNECEDORES_PRODUTOS FOREIGN KEY(fornecedores_id) REFERENCES fornecedores(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_ESTOQUE_PRUDOTS FOREIGN KEY(estoque_id) REFERENCES estoque(id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE estabelecimento_produto (
	id INT IDENTITY(1,1),
	estabelecimentos_id INT NOT NULL,
	produtos_cod_produto INT NOT NULL,
	CONSTRAINT PK_ESTABELECIMENTO_PRODUTO PRIMARY KEY(id),
	CONSTRAINT FK_ESTABELECIMENTOS_ESTABELECIMENTOPRODUTO FOREIGN KEY(estabelecimentos_id) REFERENCES estabelecimentos(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_PRODUTOS_ESTABELECIMENTOPRODUTO FOREIGN KEY(produtos_cod_produto) REFERENCES produtos(cod_produto) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE estabelecimento_fornecedor (
	id INT IDENTITY(1,1),
	estabelecimentos_id INT NOT NULL,
	fornecedores_id INT NOT NULL,
	CONSTRAINT PK_ESTABELECIMENTO_FORNECEDOR PRIMARY KEY(id),
	CONSTRAINT FK_ESTABELECIMENTOS_ESTABELECIMENTOSFORNECEDOR FOREIGN KEY(estabelecimentos_id) REFERENCES estabelecimentos(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_FORNECEDORES_ESTABELECIMENTOSFORNECEDOR FOREIGN KEY(fornecedores_id) REFERENCES fornecedores(id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

CREATE TABLE compras (
	id INT IDENTITY(1,1),
	created DATE NOT NULL CONSTRAINT DF_COMPRA_CRIADA DEFAULT GETDATE(),
	preco_total MONEY NOT NULL,
	premium_usuarios_id INT NOT NULL,
	estabelecimentos_id INT NOT NULL,
	CONSTRAINT PK_COMPRAS PRIMARY KEY(id),
	CONSTRAINT FK_USUARIOS_COMPRAS FOREIGN KEY(premium_usuarios_id) REFERENCES premium_usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_ESTABELECIMENTOS_COMPRAS FOREIGN KEY(estabelecimentos_id) REFERENCES estabelecimentos(id)
)
GO

CREATE TABLE item_venda (
	id INT IDENTITY(1,1),
	qtd INTEGER NOT NULL,
	preco_parcial MONEY NOT NULL,
	produtos_cod_produto INT NOT NULL,
	compras_id INT NOT NULL,
	CONSTRAINT PK_ITEM_VENDA PRIMARY KEY(id),
	CONSTRAINT FK_PRODUTOS_ITEMVENDA FOREIGN KEY(produtos_cod_produto) REFERENCES produtos(cod_produto) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_COMPRAS_ITEMVENDA FOREIGN KEY(compras_id) REFERENCES compras(id) ON DELETE CASCADE ON UPDATE CASCADE,
);
GO