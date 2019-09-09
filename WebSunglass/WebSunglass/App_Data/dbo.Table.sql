CREATE TABLE [dbo].[Customer]
(
	[IdCustomer] INT NOT NULL PRIMARY KEY, 
    [Id] INT NOT NULL, 
    [FirstName] NCHAR(10) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [Email] NCHAR(10) NOT NULL
)
