CREATE TABLE [dbo].[jovem] (
    [Id]                  INT           NOT NULL,
    [Nome]                NVARCHAR (50) DEFAULT (NULL) NOT NULL,
    [Telefone]            NUMERIC (18)  DEFAULT (NULL) NULL,
    [Idade]               NUMERIC (18)  DEFAULT (NULL) NULL,
    [Paroquia]            NVARCHAR (50) DEFAULT (NULL) NULL,
    [Apelido]             NVARCHAR (50) DEFAULT (NULL) NULL,
    [Batismo]             TINYINT       DEFAULT (NULL) NULL,
    [Primeira_Eucaristia] TINYINT       DEFAULT (NULL) NULL,
    [Crisma]              TINYINT       DEFAULT (NULL) NULL,
    [Nome_Pai]            NVARCHAR (50) DEFAULT (NULL) NULL,
    [Nome_Mae]            NVARCHAR (50) DEFAULT (NULL) NULL,
    [Foto]                IMAGE         DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Nome])
);

