CREATE TABLE [dbo].[Login] (
    [Usuario]  VARCHAR (10)  NOT NULL,
    [Password] VARCHAR (8)  NOT NULL,
    [Role]     VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Usuario] ASC)
); 
INSERT INTO [dbo].[Login] ([Usuario], [Password], [Role]) 
VALUES (N'6391183404', N'12345log', N'ShopAdministrator');
INSERT INTO [dbo].[Login] ([Usuario], [Password], [Role]) 
VALUES (N'9361183404', N'12345log', N'ShopOwner');