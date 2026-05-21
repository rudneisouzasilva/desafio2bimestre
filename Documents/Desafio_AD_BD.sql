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

-- CEPs
INSERT INTO CEP (
    cd_cep,
    nm_rua,
    nm_bairro,
    nm_cidade,
    sg_uf
)
VALUES
('11525050', 'Rua Jefferson Damião do Amaral', 'Vila Nova', 'Cubatão', 'SP'),
('11015000', 'Avenida Ana Costa', 'Gonzaga', 'Santos', 'SP'),
('11310000', 'Avenida Presidente Kennedy', 'Centro', 'São Vicente', 'SP'),
('11700000', 'Avenida Presidente Kennedy', 'Aviação', 'Praia Grande', 'SP'),
('11680000', 'Rua da Praia', 'Centro', 'Ubatuba', 'SP');
GO

-- Usuários
-- Senha igual para todos:
-- CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5

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
VALUES
(
    'rudneiadm',
    '11525050',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'Rudnei Souza',
    '(13)99737-9065',
    'rudneidsouzas@gmail.com',
    '169',
    'Casa 1',
    'ADMIN'
),
(
    'alexandreadm',
    '11015000',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'Alexandre Silva',
    '(13)98888-1111',
    'alexandre@email.com',
    '100',
    NULL,
    'ADMIN'
),
(
    'diogoadm',
    '11310000',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'Diogo Santos',
    '(13)97777-2222',
    'diogo@email.com',
    '200',
    NULL,
    'ADMIN'
),
(
    'joaosilva',
    '11700000',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'João Silva',
    '(13)96666-3333',
    'joao@email.com',
    '300',
    NULL,
    'USUARIO'
),
(
    'mariaoliveira',
    '11680000',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'Maria Oliveira',
    '(13)95555-4444',
    'maria@email.com',
    '400',
    'Apartamento 12',
    'USUARIO'
),
(
    'carlosuser',
    '11525050',
    'CA3713AB124C57B322118A5B08DBC3FD4F773AE2EF3FCFA915D0321ED69848A5',
    'Carlos Pereira',
    '(13)94444-5555',
    'carlos@email.com',
    '500',
    NULL,
    'USUARIO'
);
GO

-- Equipamentos
INSERT INTO Equipamento (
    cd_patrimonio,
    nm_local,
    nm_fabricante,
    nm_modelo
)
VALUES
('PAT001', 'Laboratório de Informática', 'Dell', 'Optiplex 3090'),
('PAT002', 'Secretaria', 'HP', 'LaserJet Pro M404'),
('PAT003', 'Sala dos Professores', 'Lenovo', 'ThinkCentre M70q'),
('PAT004', 'Biblioteca', 'Samsung', 'Monitor LED 24'),
('PAT005', 'Coordenação', 'Epson', 'EcoTank L3250');
GO

-- Peças
INSERT INTO Peca (
    nm_peca
)
VALUES
('Memória RAM'),
('HD'),
('SSD'),
('Fonte'),
('Placa-mãe'),
('Processador'),
('Monitor'),
('Teclado'),
('Mouse'),
('Cartucho'),
('Cabo de Rede');
GO

-- Relação Equipamento x Peça
INSERT INTO Equipamento_Peca (
    cd_patrimonio,
    cd_peca
)
VALUES
('PAT001', 1),
('PAT001', 2),
('PAT001', 3),
('PAT001', 4),
('PAT001', 5),
('PAT001', 6),

('PAT002', 10),
('PAT002', 11),

('PAT003', 1),
('PAT003', 3),
('PAT003', 4),
('PAT003', 5),
('PAT003', 6),

('PAT004', 7),
('PAT004', 11),

('PAT005', 10),
('PAT005', 11);
GO

-- Tarefas
INSERT INTO Tarefa (
    cd_patrimonio,
    cd_peca,
    ds_login,
    ic_tipo_manutencao,
    ic_tipo_servico,
    dt_manutencao,
    ds_observacoes
)
VALUES
(
    'PAT001',
    1,
    'joaosilva',
    'Preventiva',
    'Reparo',
    '2026-05-01',
    'Verificação preventiva da memória RAM.'
),
(
    'PAT001',
    3,
    'mariaoliveira',
    'Corretiva',
    'Troca',
    '2026-05-03',
    'Substituição do SSD com falha.'
),
(
    'PAT002',
    10,
    'carlosuser',
    'Corretiva',
    'Troca',
    '2026-05-05',
    'Troca do cartucho da impressora.'
),
(
    'PAT003',
    4,
    'joaosilva',
    'Preventiva',
    'Reparo',
    '2026-05-07',
    'Teste preventivo na fonte do equipamento.'
),
(
    'PAT004',
    7,
    'mariaoliveira',
    'Corretiva',
    'Reparo',
    '2026-05-10',
    'Monitor apresentando falha de imagem.'
),
(
    'PAT005',
    11,
    'carlosuser',
    'Preventiva',
    'Reparo',
    '2026-05-12',
    'Verificação do cabo de rede da impressora.'
);
GO
