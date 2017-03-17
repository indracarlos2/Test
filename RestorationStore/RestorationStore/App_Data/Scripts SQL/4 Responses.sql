CREATE TABLE [dbo].[Responses] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Id_Request]    INT             NOT NULL,
    [Cost]          DECIMAL (18)    NOT NULL,
    [Description]   VARCHAR (MAX)   NOT NULL,
    [FinalDate]     DATETIME        NOT NULL,
    [FinalImage]    VARBINARY (MAX) NULL,
    [ImageMimeType] VARCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Responses_Requests] FOREIGN KEY ([Id_Request]) REFERENCES [dbo].[Requests] ([Id])
);
 
