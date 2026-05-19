CREATE DATABASE desafio2bimestre;
GO

USE desafio2bimestre;
GO

CREATE TABLE CEP (
    cd_cep VARCHAR(8) PRIMARY KEY,
    nm_rua VARCHAR(100) NOT NULL,
    nm_bairro VARCHAR(100) NOT NULL,
    nm_cidade VARCHAR(100) NOT NULL,
    sg_uf CHAR(2) NOT NULL
);
GO

CREATE TABLE Usuario (
    ds_login VARCHAR(50) PRIMARY KEY,
    cd_cep VARCHAR(8) NOT NULL FOREIGN KEY REFERENCES CEP(cd_cep),
    ds_senha VARCHAR(64) NOT NULL,
    nm_usuario VARCHAR(100) NOT NULL,
    ds_telefone VARCHAR(20) NOT NULL,
    ds_email VARCHAR(100) NOT NULL UNIQUE,
    ds_numero VARCHAR(10) NOT NULL,
    ds_complemento VARCHAR(100),
    ic_tipo VARCHAR(10) NOT NULL DEFAULT 'USUARIO',

    CONSTRAINT CK_Usuario_Tipo 
        CHECK (ic_tipo IN ('ADMIN', 'USUARIO'))
);
GO

CREATE TABLE Equipamento (
    cd_patrimonio VARCHAR(50) PRIMARY KEY,
    nm_local VARCHAR(100) NOT NULL,
    nm_fabricante VARCHAR(100) NOT NULL,
    nm_modelo VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Peca (
    cd_peca INT IDENTITY(1,1) PRIMARY KEY,
    nm_peca VARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Equipamento_Peca (
    cd_patrimonio VARCHAR(50) NOT NULL 
        FOREIGN KEY REFERENCES Equipamento(cd_patrimonio),

    cd_peca INT NOT NULL 
        FOREIGN KEY REFERENCES Peca(cd_peca),

    PRIMARY KEY (cd_patrimonio, cd_peca)
);
GO

CREATE TABLE Tarefa (
    cd_tarefa INT IDENTITY(1,1) PRIMARY KEY,
    cd_patrimonio VARCHAR(50) NOT NULL,
    cd_peca INT NOT NULL,

    ds_login VARCHAR(50) NOT NULL 
        FOREIGN KEY REFERENCES Usuario(ds_login),

    ic_tipo_manutencao VARCHAR(20) NOT NULL,
    ic_tipo_servico VARCHAR(20) NOT NULL,
    dt_manutencao DATE NOT NULL,
    ds_observacoes VARCHAR(500),

    FOREIGN KEY (cd_patrimonio, cd_peca)
        REFERENCES Equipamento_Peca(cd_patrimonio, cd_peca),

    CONSTRAINT CK_Tarefa_TipoManutencao
        CHECK (ic_tipo_manutencao IN ('Preventiva', 'Corretiva')),

    CONSTRAINT CK_Tarefa_TipoServico
        CHECK (ic_tipo_servico IN ('Reparo', 'Troca'))
);
GO

INSERT INTO CEP (
    cd_cep,
    nm_rua,
    nm_bairro,
    nm_cidade,
    sg_uf
)
VALUES (
    '11525050',
    'Rua Jefferson Damião do Amaral',
    'Vila Nova',
    'Cubatão',
    'SP'
);
GO

INSERT INTO Usuario (
    ds_login,
    cd_cep,
    ds_senha,
    nm_usuario,
    ds_telefone,
    ds_email,
    ds_numero,
    ds_complemento,
    ic_tipo
)
VALUES (
    'rudneiadm',
    '11525050',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'Rudnei Souza',
    '(13)99737-9065',
    'rudneidsouzas@gmail.com',
    '169',
    'Casa 1',
    'ADMIN'
);
GO