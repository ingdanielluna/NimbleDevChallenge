CREATE TABLE [dbo].[BaseTea]
(
    [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newsequentialid(), 
    [Name] NVARCHAR(1000) NOT NULL,
    [Price] INT NOT NULL,
    [CreateDate] DATETIME2 NOT NULL DEFAULT getdate(), 
    [UpdateDate] DATETIME2 NOT NULL DEFAULT getdate()
)
