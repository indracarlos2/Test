CREATE TABLE [dbo].[Requests] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Estatus]       VARCHAR (25)    NOT NULL,
    [Description]   VARCHAR (MAX)   NOT NULL,
    [InitialDate]   DATETIME        NOT NULL,
    [InitialImage]  VARBINARY (MAX) NULL,
    [ImageMimeType] VARCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
); 

