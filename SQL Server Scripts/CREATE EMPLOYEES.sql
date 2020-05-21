USE LOJA_ROUPAS
GO

CREATE TABLE Employees
(
	Id				INT NOT NULL IDENTITY,
	EmployeeName	VARCHAR(100) NOT NULL,
	CPF				VARCHAR(11) UNIQUE NOT NULL,
	BirthDate		DATE NOT NULL,
	RecordDate		DATE NOT NULL,
	Department		VARCHAR(50) NOT NULL,
	Position		VARCHAR(25) NOT NULL,
	Salary			FLOAT NOT NULL,
	IsActivated		BIT NOT NULL,
	CompanyId	    INT NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (CompanyId) REFERENCES Companies(Id)
)
GO

INSERT INTO Employees (EmployeeName, CPF, BirthDate, RecordDate, Department, Position, Salary, IsActivated, CompanyId)
VALUES ('Bete Silva', '48594039271', '1970-03-20', GETDATE(), 'Human Resources', 'Director', 20000, 1, 1)


