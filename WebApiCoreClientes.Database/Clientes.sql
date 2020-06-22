CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL, 
    [Cpf] NVARCHAR(14) NULL, 
    [Idade] INT NULL, 
    [DataNascimento] DATETIME NULL
)
