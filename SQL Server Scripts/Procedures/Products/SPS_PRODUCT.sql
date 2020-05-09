USE LOJA_ROUPAS
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE XTYPE = 'P' AND NAME = 'SPS_PRODUCT')
BEGIN 
	DROP PROCEDURE SPS_PRODUCT
	PRINT '<<< PROCEDURE SPS_PRODUCT EXCLUÍDA COM SUCESSO >>>'
END
GO

CREATE PROCEDURE SPS_PRODUCT
(
	@Id				INT = 0,
	@ProductName	VARCHAR(60) = NULL,
	@Description	TEXT = NULL,
	@Activated		BIT = 0
)
AS
BEGIN
	IF (@Id = 0)
	BEGIN
		SELECT	*
		FROM	Products AS A
	END
	ELSE
	BEGIN 
		SELECT	*
		FROM	Products AS A
		WHERE	A.Id = @Id
	END
END
GO

IF EXISTS (SELECT TOP 1 1 FROM SYSOBJECTS WHERE XTYPE = 'P' AND NAME = 'SPS_PRODUCT')
BEGIN 
	PRINT '<<< PROCEDURE SPS_PRODUCT CRIADA COM SUCESSO >>>'
END
GO

INSERT INTO Stocks (Amount, UnitPrice, ProductName) VALUES (10000, 8.50, 'Meia do Meu Malvado Favorito')
INSERT INTO Products (ProductName, ProductDescription, Activated, StockId)
values ('Meia do Meu Malvado Favorito', 'Meia Infantil Meu Malvado Favorito', 1, 1)

select	*
from	products