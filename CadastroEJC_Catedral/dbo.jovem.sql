CREATE TABLE [dbo].[jovem] (
    [Id]                  INT           IDENTITY (1, 1) NOT NULL,
    [Nome]                NVARCHAR (50) NULL,
    [Telefone]            NUMERIC (18)  DEFAULT (NULL) NULL,
    [Data_Nascimento]               DATE  DEFAULT (NULL) NULL,
    [Paroquia]            NVARCHAR (50) DEFAULT (NULL) NULL,
    [Apelido]             NVARCHAR (50) DEFAULT (NULL) NULL,
    [Batismo]             TINYINT       DEFAULT (NULL) NULL,
    [Primeira_Eucaristia] TINYINT       DEFAULT (NULL) NULL,
    [Crisma]              TINYINT       DEFAULT (NULL) NULL,
    [Nome_Pai]            NVARCHAR (50) DEFAULT (NULL) NULL,
    [Nome_Mae]            NVARCHAR (50) DEFAULT (NULL) NULL,
    [Foto]                IMAGE         DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

