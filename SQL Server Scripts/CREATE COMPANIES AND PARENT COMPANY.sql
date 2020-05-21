USE LOJA_ROUPAS
GO

CREATE TABLE Companies
(
	Id				INT NOT NULL IDENTITY,
	CompanyName		VARCHAR(50) UNIQUE NOT NULL,
	CNPJ			VARCHAR(14) UNIQUE NOT NULL,
	IsParentCompany BIT not null,
	IsActivated		BIT NOT NULL,
	CityId			INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (CityId) REFERENCES Cities(Id)
)
GO

INSERT INTO Companies(CompanyName, CNPJ, IsParentCompany, IsActivated, CityId)
VALUES ('Xagasalhos Matriz', '29405947382917', 1, 1, 5767)

