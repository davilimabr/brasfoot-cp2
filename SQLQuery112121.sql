CREATE TABLE [dbo].[Estatistica_Time] (
    [Estatistica_id] INT NOT NULL,
    [GolsPro]        INT NOT NULL,
    [GoslContra]     INT NOT NULL,
    [Pontos]         INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Estatistica_id] ASC)
);

CREATE TABLE [dbo].[Time] (
    [Time_id]      INT          NOT NULL,
    [Nome]         VARCHAR (50) NOT NULL,
    [Estatistica]  INT          NOT NULL,
    [Nome_Tecnico] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Time_id] ASC),
    FOREIGN KEY ([Estatistica]) REFERENCES [dbo].[Estatistica_Time] ([Estatistica_id])
);

CREATE TABLE [dbo].[Jogador_Especificacao] (
    [Especificacao_id] INT         NOT NULL,
    [Ataque]           INT         NOT NULL,
    [Defesa]           INT         NOT NULL,
    [Resistencia]      FLOAT (53)  NOT NULL,
    [Titularidade]     TINYINT     NOT NULL,
    [Gols]             INT         NOT NULL,
    [Posicao]          VARCHAR (1) NOT NULL,
    PRIMARY KEY CLUSTERED ([Especificacao_id] ASC)
);

CREATE TABLE [dbo].[Jogador] (
    [Jogador_id]     INT          NOT NULL,
    [Nome]           VARCHAR (50) NOT NULL,
    [Time_id]        INT          NOT NULL,
    [Especificacoes] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Jogador_id] ASC),
    FOREIGN KEY ([Time_id]) REFERENCES [dbo].[Time] ([Time_id]),
    FOREIGN KEY ([Especificacoes]) REFERENCES [dbo].[Jogador_Especificacao] ([Especificacao_id])
);

CREATE TABLE [dbo].[Partidas] (
    [Partida_id]    INT NOT NULL,
    [Rodada]        INT NOT NULL,
    [Time_Casa]     INT NOT NULL,
    [Time_Fora]     INT NOT NULL,
    [Gols_timeCasa] INT NOT NULL,
    [Gols_timeFora] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Partida_id] ASC),
    FOREIGN KEY ([Time_Casa]) REFERENCES [dbo].[Time] ([Time_id]),
    FOREIGN KEY ([Time_Fora]) REFERENCES [dbo].[Time] ([Time_id])
);




DROP TABLE Partidas;

DROP TABLE Jogador;

DROP TABLE Jogador_Especificacao;

DROP TABLE Time;

DROP TABLE Estatistica_Time;



