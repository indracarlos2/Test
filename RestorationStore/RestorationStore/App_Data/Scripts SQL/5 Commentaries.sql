CREATE TABLE [dbo].[Commentaries] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Author]      VARCHAR (25)  NOT NULL,
    [Message]     VARCHAR (100) NOT NULL,
    [Id_Response] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Commentaries_Responses] FOREIGN KEY ([Id_Response]) REFERENCES [dbo].[Responses] ([Id])
);

 