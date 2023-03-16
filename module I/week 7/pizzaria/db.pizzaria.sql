CREATE DATABASE pizzaria;

CREATE TABLE massa (
	idMassa INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) NOT NULL
);
CREATE TABLE borda (
	idBorda INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) NOT NULL
);
CREATE TABLE sabor (
	idSabor INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) NOT NULL
);

CREATE TABLE status (
	idStatus INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) NOT NULL
);
CREATE TABLE pizza(
	idPizza INT IDENTITY(1,1) PRIMARY KEY,
	massaId INT NOT NULL,
	bordaId INT NOT NULL,
	CONSTRAINT fk_pizza_massa FOREIGN KEY (massaId) REFERENCES massa(idMassa),
	CONSTRAINT fk_pizzA_borda FOREIGN KEY (bordaId) REFERENCES borda(idBorda)
);
CREATE TABLE pizzaSabores (
	idPizzaSabores INT IDENTITY(1,1) PRIMARY KEY,
	pizzaId INT NOT NULL,
	saborId INT NOT NULL,
	CONSTRAINT fk_pizzaSabores_pizza FOREIGN KEY (pizzaId) REFERENCES pizza(idPizza),
	CONSTRAINT fk_pizzaSabores_sabor FOREIGN KEY (saborId) REFERENCES sabor(idSabor)
);
CREATE TABLE pedido (
	idPedido INT IDENTITY(1,1) PRIMARY KEY,
	pizzaId INT NOT NULL,
	statusId INT NOT NULL,
	CONSTRAINT fk_pedido_pizza FOREIGN KEY (pizzaId) REFERENCES pizza(idPizza),
	CONSTRAINT fk_status_pizza FOREIGN KEY (statusId) REFERENCES status(idStatus)
);