CREATE TABLE [dbo].[Widget]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Base_Price] DECIMAL(10, 2) NOT NULL, 
    [Discount_Indicator] BIT NOT NULL
)
