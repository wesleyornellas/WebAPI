USE FCamara;  
GO 

CREATE TABLE tb_usuarios
(
Id uniqueidentifier NOT NULL
	DEFAULT newid(),  
Nome varchar(60),
PerguntaSecreta int,
RespostaSecreta varchar(80),
Email varchar(60),
Senha varchar(15),
StatusUsuario bit,
);
GO 

ALTER TABLE tb_usuarios
ADD CONSTRAINT Usuarios_pk PRIMARY KEY (Id);  
GO  

INSERT INTO tb_usuarios (Nome, PerguntaSecreta, RespostaSecreta, Email, Senha, StatusUsuario)
VALUES ('Matheus', 1, 'São Pualo', 'matheus@outlook.com', '@mk1903', 'true');
GO 

INSERT INTO tb_usuarios (Nome, PerguntaSecreta, RespostaSecreta, Email, Senha, StatusUsuario)
VALUES ('Joana', 2, 'Pizza', 'joana@outlook.com', '#jlk8803', 'true');
GO 

INSERT INTO tb_usuarios (Nome, PerguntaSecreta, RespostaSecreta, Email, Senha, StatusUsuario)
VALUES ('Hugo', 3, 'Fransisca', 'hugo@outlook.com', '#hgtlk8803', 'true');
GO 

SELECT * FROM tb_usuarios;
GO