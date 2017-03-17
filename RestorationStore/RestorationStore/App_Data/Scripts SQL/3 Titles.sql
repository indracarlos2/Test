CREATE TABLE [dbo].[Titles] (
    [Id_Request]   INT          NOT NULL,
    [TitleMessage] VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Request] ASC),
    CONSTRAINT [FK_Titles_ToRequest] FOREIGN KEY ([Id_Request]) REFERENCES [dbo].[Requests] ([Id])
);

 