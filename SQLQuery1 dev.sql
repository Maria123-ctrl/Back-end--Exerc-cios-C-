USE tb_ddevconnect;

ALTER TABLE tabela_publicacao
ALTER COLUMN id_usuario INT NULL;

ALTER TABLE tabela_curtida
ADD UNIQUE(id_usuario, id_publicacao);

-- DROP TABLE tabela_seguidor;

CREATE TABLE tabela_seguidor(
	idusuarioSeguir		INT NOT NULL,
	idusuarioSeguidor	INT NOT NULL,

	PRIMARY KEY(IdUsuarioSeguir, IdUsuarioSeguidor),
	FOREIGN KEY(IdUsuarioSeguir) REFERENCES tabela_usuario(id),
	FOREIGN KEY(IdUsuarioSeguidor) REFERENCES tabela_usuario(id)
);

SELECT * FROM tabela_usuario;

SELECT * FROM tabela_publicacao;