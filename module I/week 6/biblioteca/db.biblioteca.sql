CREATE DATABASE biblioteca;

CREATE TABLE categoria (
	idCategoria INT IDENTITY PRIMARY KEY,
	codigoCategoria VARCHAR(45) NOT NULL,
	descricao VARCHAR(45) NOT NULL
);
CREATE TABLE livro (
	idLivro INT IDENTITY PRIMARY KEY,
	categoriaId INT NOT NULL,
	isbn VARCHAR(45) NOT NULL,
	titulo VARCHAR(45) NOT NULL,
	ano VARCHAR(45) NOT NULL
	CONSTRAINT FK_categoria FOREIGN KEY (categoriaId) REFERENCES categoria(idCategoria)
);
CREATE TABLE autor (
	idAutor INT IDENTITY PRIMARY KEY,
	nome VARCHAR(45) NOT NULL,
	nacionalidade VARCHAR(45) NOT NULL
);
CREATE TABLE livroAutores (
	idLivroAutores INT IDENTITY PRIMARY KEY,
	livroId INT NOT NULL,
	autorId INT NOT NULL,
	CONSTRAINT FK_livro FOREIGN KEY (livroId) REFERENCES livro(idLivro),
	CONSTRAINT FK_autor FOREIGN KEY (autorId) REFERENCES autor(idAutor)
);
