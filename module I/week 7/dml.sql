/*M1S07 Ex01*/
SELECT nome FROM tabelaB
FULL OUTER JOIN tabelaA ON tabelaB.nome = tabelaA.nome
ORDER BY nome ASC;

/*M1S07 Ex04*/
UPDATE aluno 
SET idade = 27
WHERE id = 3;

/*M1S07 Ex05*/
UPDATE aluno
SET endereco = 'Av. Norte, 350, Recife-PE'
WHERE id = 2;

/*M1S07 Ex06*/
SELECT * FROM aluno WHERE idade > 21 AND nome_aluno LIKE '%Silva%';

/*M1S07 Ex07*/
ALTER TABLE aluno ADD data_nascimento DATE;

/*M1S07 Ex08*/
ALTER TABLE pedidos ALTER COLUMN datapedido VARCHAR(60);

/*M2S09 Ex05*/
SELECT AVG(idade) AS media FROM aluno;

