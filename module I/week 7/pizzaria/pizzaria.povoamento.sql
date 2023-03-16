ALTER TABLE pedido ADD CONSTRAINT UC_pizza_pedido UNIQUE(pizzaId);

INSERT INTO borda (nome) VALUES 
('Catupiry'),
('Cheddar'),
('Chocolate Preto'),
('Chocolate Branco');

INSERT INTO massa (nome) VALUES
('Tradicional'),
('Temperada'),
('Integral');

INSERT INTO sabor (nome) VALUES
('Calabresa'),
('4 Queijos'),
('Sensação'),
('Filé');

INSERT INTO status (nome) VALUES
('Recebido'),
('Em preparação'),
('Saiu para entrega');

INSERT INTO pizza (massaId, bordaId) VALUES
(2, 1),
(3, 3);

INSERT INTO pizzaSabores (pizzaId, saborId) VALUES
(1, 2),
(2, 3);

INSERT INTO pedido (pizzaId, statusId) VALUES
(1, 3),
(2, 1);

