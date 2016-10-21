USE [DB_Real_Estate_Strorage];
GO

--SP Estate--

CREATE PROC spGetEstates
AS
BEGIN
-- Review VM: better to use 'SELECT *' when you have to get all columns.
	SELECT dbo.Estate.Id, dbo.Estate.District, dbo.Estate.Rooms, dbo.Estate.Area, dbo.Estate.Address, 
		dbo.Estate.EstOwner, dbo.Estate.Price, dbo.Estate.Rent, dbo.Estate.Sale
	FROM dbo.Estate;
END;
GO

CREATE PROC spGetEstateById
	@Id INT
AS
BEGIN
	SELECT dbo.Estate.Id, dbo.Estate.District, dbo.Estate.Rooms, dbo.Estate.Area, dbo.Estate.Address, 
		dbo.Estate.EstOwner, dbo.Estate.Price, dbo.Estate.Rent, dbo.Estate.Sale
	FROM dbo.Estate
	WHERE (Id = @Id)
END;

-- Review VM: Missed 'GO' statement, which causes troubles with creating of the next procedure.

CREATE PROC spInsertEstate
	@District INT NULL,
	@EstOwner INT,
	@Rooms INT,
	@Area REAL,
	@Address NVARCHAR(40),
	@Price INT,
	@Rent BIT,
	@Sale BIT
AS
BEGIN
	INSERT INTO dbo.Estate (EstOwner, Area, Rooms, District, Address, Price, Rent, Sale)
	VALUES (@EstOwner, @Area, @Rooms, @District, @Address, @Price, @Rent, @Sale);	
END;
GO


CREATE PROC spUpdateEstate
	@Id INT,
	@District INT NULL,
	@EstOwner INT,
	@Rooms INT,
	@Area REAL,
	@Address NVARCHAR(40),
	@Price INT,
	@Rent BIT,
	@Sale BIT
AS
BEGIN
		UPDATE dbo.Estate
		SET District = @District,
			EstOwner = @EstOwner,
			Area = @Area, 
			Rooms = @Rooms,
			Address = @Address, 
			Price = @Price, 
			Rent = @Rent, 
			Sale = @Sale
		WHERE (Id = @Id)
END;
GO


CREATE PROC spDeleteEstate
	@Id INT,
	@EstOwnerId INT OUT
AS
BEGIN
	SELECT @EstOwnerId = EstOwner 
	FROM Estate 
	WHERE (Id = @Id);

	DELETE
	FROM dbo.Estate
	WHERE (Id=@Id);
END;
GO

---------------------


-----SP Person-------

CREATE PROC spGetPersonByID
	@Id INT
AS
BEGIN
	SELECT Id, FirstName, LastName, Phone, Mail
	FROM dbo.Person
	WHERE (Id = @Id);
END;
GO

CREATE PROC spInsertPerson
	@FirstName NVARCHAR(20),
	@LastName NVARCHAR(30),
	@Phone NVARCHAR(13),
	@Mail NVARCHAR(40),
	@Id INT OUT
AS
BEGIN
		INSERT INTO dbo.Person (FirstName, LastName, Phone, Mail)
		VALUES (@FirstName, @LastName, @Phone, @Mail);
		SELECT @Id = @@IDENTITY;
END;
GO

CREATE PROC spUpdatePerson
	@FirstName NVARCHAR(20),
	@LastName NVARCHAR(30),
	@Phone NVARCHAR(13),
	@Mail NVARCHAR(40),
	@Id INT 
AS
BEGIN
		UPDATE dbo.Person
		SET FirstName = @FirstName,
			LastName = @LastName,
			Phone = @Phone,
			Mail = @Mail
		WHERE(Id = @Id);
END;
GO


CREATE PROC spDeletePerson
	@Id INT
AS
BEGIN
	DELETE
	FROM dbo.Person
	WHERE (Id=@Id);
END;
GO

---------------------


----SP District------

CREATE PROC spGetDistrictById
	@Id INT
AS
BEGIN
	SELECT Id, Name
	FROM dbo.District
	WHERE (Id = @Id)
END;
GO


CREATE PROC spGetDistricts
AS
BEGIN
	SELECT Id, Name
	FROM dbo.District;
END;
GO

---------------------



------SP USER--------


CREATE PROC spGetUser
	@Login NVARCHAR(40),
	@Password NVARCHAR (40)
AS
BEGIN
	SELECT Id, Login, PersID
	FROM dbo.DBUser
	WHERE (Login = @Login AND Password = @Password);
END;
GO

---------------------


----SP Contract------

CREATE PROC spGetContracts
AS
BEGIN
	SELECT Id, CustomerId, EmployeeId, EstateId, Date
	FROM dbo.Contracts;
END;
GO

CREATE PROC spInsertContract
	@EmployeeId INT,
	@CustomerId INT,
	@EstateId INT
AS
BEGIN
	INSERT INTO dbo.Contracts(EmployeeId, CustomerId, EstateId)
	VALUES (@EmployeeId, @CustomerId, @EstateId);
END;
GO
