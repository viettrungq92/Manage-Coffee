CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống'  ,    ---- Trống || Có người
)
GO
CREATE TABLE Account
(
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Dev',
	UserName NVARCHAR(100) NOT NULL PRIMARY KEY,
	PassWord NVARCHAR(1000)NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- admin(1) || staff(0)
)
GO
CREATE TABLE Category
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO
CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL,
	FOREIGN KEY (idCategory) REFERENCES dbo.Category(id)
)
GO
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- đã thanh toán(1) || chưa thanh toán(0)
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0,
	FOREIGN KEY (idBill) REFERENCES dbo.Bill (id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food (id)
)
GO

INSERT INTO dbo.Account
(UserName,
DisplayName,
PassWord,
Type
)

VALUES (N'Trung',
		N'VietTrung',
		N'1',
		1)

INSERT INTO dbo.Account(
		UserName,
		DisplayName,
		PassWord,
		Type
		)

VALUES	(N'Kieu',
		N'KieuHoang',
		N'1',
		1)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'Trung' -- nvarchar(100)

GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

-- thêm bàn
DECLARE @i INT = 0

WHILE @i <=10
BEGIN
	INSERT dbo.TableFood(name) VALUES	(N'Bàn ' + CAST(@i AS nvarchar(100))) 
	SET @i = @i +1
END
GO


CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

UPDATE dbo.TableFood SET STATUS = N'Có người' WHERE id = 1
EXEC dbo.USP_GetTableList
GO

--thêm category
INSERT dbo.Category
		(name )
VALUES	(N'Hải sản')

INSERT dbo.Category
		(name)
VALUES	(N'Thịt')

INSERT dbo.Category
		(name)
VALUES	(N'Nước')

INSERT dbo.Category
		(name)
VALUES	(N'Trái cây')

-- thêm món ăn
INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Mực nướng sa tế',   --name
		1,    --idCategory
		120000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Ngêu hấp xả',   --name
		1,    --idCategory
		50000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Lẩu cá đuối',   --name
		1,    --idCategory
		200000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Vú dê nướng',   --name
		2,    --idCategory
		150000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Heo nướng mọi',   --name
		2,    --idCategory
		170000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Gà nướng sa tế',   --name
		2,    --idCategory
		170000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Sting',   --name
		3,    --idCategory
		20000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Pepsi',   --name
		3,    --idCategory
		20000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Cà phê',   --name
		3,    --idCategory
		30000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Xoài',   --name
		4,    --idCategory
		25000)

INSERT dbo.Food
		(name, idCategory, price)
VALUES	(N'Cam sành',   --name
		4,    --idCategory
		25000)

SELECT * FROM dbo.TableFood
-- thêm bill
INSERT dbo.Bill
		(DateCheckIn,
		DateCheckOut,
		idTable,
		status)
VALUES	(GETDATE(),  -- DateCheckIn
		NULL,	--	DateCheckout
		1,  -- idTable
		0 -- status
		)

INSERT dbo.Bill
		(DateCheckIn,
		DateCheckOut,
		idTable,
		status)
VALUES	(GETDATE(),  -- DateCheckIn
		NULL,	--	DateCheckout
		2,  -- idTable
		0 -- status
		)
SELECT * FROM dbo.Bill
INSERT dbo.Bill
		(DateCheckIn,
		DateCheckOut,
		idTable,
		status)
VALUES	(GETDATE(),  -- DateCheckIn
		NULL,	--	DateCheckout
		3,  -- idTable
		1 -- status
		)

-- Thêm BillInfo
INSERT	dbo.BillInfo
		(idBill, idFood, count)
VALUES	(1,	--	idBill
		1,	--	idFood
		2	--	count
		)

INSERT	dbo.BillInfo
		(idBill, idFood, count)
VALUES	(1,	--	idBill
		2,	--	idFood
		4	--	count
		)

INSERT	dbo.BillInfo
		(idBill, idFood, count)
VALUES	(1,	--	idBill
		3,	--	idFood
		1	--	count
		)

INSERT	dbo.BillInfo
		(idBill, idFood, count)
VALUES	(2,	--	idBill
		4,	--	idFood
		2	--	count
		)

INSERT	dbo.BillInfo
		(idBill, idFood, count)
VALUES	(2,	--	idBill
		5,	--	idFood
		2	--	count
		)

INSERT	dbo.BillInfo
		(idBill, idFood, count)
VALUES	(3,	--	idBill
		6,	--	idFood
		2	--	count
		)

GO
SELECT f.name, bi.count,f.price, f.price*bi.count AS TotalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 3

SELECT * FROM dbo.TableFood
GO
SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Food
SELECT * FROM dbo.Category
GO
SELECT * FROM dbo.Account
GO

create PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			idTable,
			status,
			discount
			)
	VALUES	(GETDATE(),
			NULL,
			@idTable,
			0,
			0
			)
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	INSERT	dbo.BillInfo
				(idBill,idFood,count)
	VALUES	(@idBill,
				@idFood,
				@count)
END
GO

ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE	@isExitsBillInfo INT
	DECLARE	@foodCount	INT	= 1

	SELECT	@isExitsBillInfo = id, @foodCount = b.count
	FROM	dbo.BillInfo AS b
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE	@newCount INT = @foodCount + @count
		IF(@newCount >0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
				(idBill,idFood,count)
		VALUES	(@idBill,
				@idFood,
				@count)
	END
END
GO

SELECT MAX(id) FROM dbo.BillInfo
GO

SELECT * FROM dbo.TableFood
GO

UPDATE dbo.Bill SET status = 1 WHERE id = 1
GO

DELETE dbo.BillInfo

DELETE dbo.Bill
GO



CREATE TRIGGER UTG_UpdateBillInfo
ON	dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF (@count > 0)
	BEGIN
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	END
	ELSE
	BEGIN
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
	END
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = id FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count int = 0

	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0

	IF(@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable

END
GO

ALTER TABLE dbo.Bill
ADD discount INT

UPDATE dbo.Bill SET discount = 0

CREATE PROC USP_SwitchTable
@idTable1 int, @idTable2 int
AS BEGIN
		DECLARE @idFirstBill int 
		DECLARE @idSecondBill int

		DECLARE @isFirstTableEmpty INT = 1
		DECLARE @isSecondTableEmpty INT = 1

		SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

		IF (@idFirstBill is NULL)
		BEGIN
			INSERT dbo.Bill(
			DateCheckIn, DateCheckOut, idTable, status)
			VALUES (
			GETDATE(), NULL, @idTable1, 0)
			SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		END

		SELECT @isFirstTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

		IF (@idSecondBill is NULL)
		BEGIN
			INSERT dbo.Bill(
			DateCheckIn, DateCheckOut, idTable, status)
			VALUES (
			GETDATE(), NULL, @idTable2, 0)
			SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		END
		
		SELECT @isSecondTableEmpty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSecondBill

		SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill
		UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill
		UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id in (SELECT * FROM IDBillInfoTable)
		DROP TABLE IDBillInfoTable

		IF (@isFirstTableEmpty = 0)
			UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2

		IF (@isSecondTableEmpty = 0)
			UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END 
GO
