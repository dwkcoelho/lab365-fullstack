CREATE DATABASE lojaroupa;

CREATE TABLE produto (
	idProduto INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) NOT NULL, 
	preco INT NOT NULL CONSTRAINT teste_valor CHECK (preco > 50),
	tamanho VARCHAR(5)
);

CREATE TABLE pedido (
	idPedido INT IDENTITY(1,1) PRIMARY KEY,
	dataPedido DATE NOT NULL,
	formaPagamento VARCHAR(30),
	logradouro VARCHAR(20),
	bairro VARCHAR(20) NOT NULL,
	numero VARCHAR(20) NOT NULL,
	cidade VARCHAR(20) NOT NULL,
	estado VARCHAR(20) NOT NULL
);

CREATE TABLE produtoPedido (
	idProdutoPedido INT IDENTITY(1,1) PRIMARY KEY,
	pedidoId INT NOT NULL,
	produtoId INT NOT NULL,
	CONSTRAINT fk_produtoPedido_pedido FOREIGN KEY (pedidoId) REFERENCES pedido(idPedido),
	CONSTRAINT fk_produtoPedido_produto FOREIGN KEY (produtoId) REFERENCES produto(idProduto)
);



