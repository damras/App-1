CREATE TABLE [dbo].[Employees] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [Department] NVARCHAR (MAX) NULL,
    
    [Phone] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);

