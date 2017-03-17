CREATE TABLE [dbo].[Contacts] (
    [Id_Request] INT          NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Email]      VARCHAR (50) NOT NULL,
    [Phone]      VARCHAR (12) NOT NULL,
    [Address]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id_Request] ASC),
    CONSTRAINT [FK_Contacts_Requests] FOREIGN KEY ([Id_Request]) REFERENCES [dbo].[Requests] ([Id])
); 

