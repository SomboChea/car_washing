/*
 Navicat Premium Data Transfer

 Source Server         : MSSQL
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : .:1433
 Source Catalog        : CAR_WASHING
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 16/08/2018 09:53:33
*/


-- ----------------------------
-- Table structure for Employee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type IN ('U'))
	DROP TABLE [dbo].[Employee]
GO

CREATE TABLE [dbo].[Employee] (
  [EmpID] int  IDENTITY(1,1) NOT NULL,
  [EmpCode] AS ('EMP'+right('0000'+CONVERT([nvarchar](5),[EmpID]),(5))) PERSISTED NOT NULL,
  [Name] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Address] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tel] varchar(15) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Salary] money  NULL,
  [PosID] int  NULL,
  [Username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Password] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Email] varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Status] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Employee] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Employee
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Employee] ON
GO

INSERT INTO [dbo].[Employee] ([EmpID], [Name], [Address], [Tel], [Salary], [PosID], [Username], [Password], [Email], [Status]) VALUES (N'5', N'Administrator', N'PP', N'012888888', N'123.0000', N'1', N'admin', N'123', N'admin@gmail.com', N'Enable')
GO

INSERT INTO [dbo].[Employee] ([EmpID], [Name], [Address], [Tel], [Salary], [PosID], [Username], [Password], [Email], [Status]) VALUES (N'6', N'Seller', N'PP', N'0229992292', N'100.0000', N'2', N'seller', N'123', N'sel@g.cv', N'Enable')
GO

SET IDENTITY_INSERT [dbo].[Employee] OFF
GO


-- ----------------------------
-- Table structure for Invoice
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice]') AND type IN ('U'))
	DROP TABLE [dbo].[Invoice]
GO

CREATE TABLE [dbo].[Invoice] (
  [InvoiceID] int  IDENTITY(1,1) NOT NULL,
  [InvoiceCode] AS ('INV'+right('0000'+CONVERT([nvarchar](5),[InvoiceID]),(5))) PERSISTED NOT NULL,
  [InvoiceDate] datetime2(7)  NULL,
  [TotalPrice] money  NULL,
  [EmpID] int  NULL
)
GO

ALTER TABLE [dbo].[Invoice] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for InvoiceDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceDetail]') AND type IN ('U'))
	DROP TABLE [dbo].[InvoiceDetail]
GO

CREATE TABLE [dbo].[InvoiceDetail] (
  [InvoiceID] int  NOT NULL,
  [ServiceID] int  NOT NULL,
  [ServiceQty] int  NULL,
  [ServiceAmount] money  NULL
)
GO

ALTER TABLE [dbo].[InvoiceDetail] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Position
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type IN ('U'))
	DROP TABLE [dbo].[Position]
GO

CREATE TABLE [dbo].[Position] (
  [PosID] int  IDENTITY(1,1) NOT NULL,
  [PosCode] AS ('POS'+right('0000'+CONVERT([nvarchar](5),[PosID]),(5))) PERSISTED NOT NULL,
  [Position] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Position] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Position
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Position] ON
GO

INSERT INTO [dbo].[Position] ([PosID], [Position]) VALUES (N'1', N'Admin')
GO

INSERT INTO [dbo].[Position] ([PosID], [Position]) VALUES (N'2', N'Seller')
GO

SET IDENTITY_INSERT [dbo].[Position] OFF
GO


-- ----------------------------
-- Table structure for Service
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Service]') AND type IN ('U'))
	DROP TABLE [dbo].[Service]
GO

CREATE TABLE [dbo].[Service] (
  [ServiceID] int  IDENTITY(1,1) NOT NULL,
  [ServiceCode] AS ('SV'+right('0000'+CONVERT([nvarchar](5),[ServiceID]),(5))) PERSISTED NOT NULL,
  [ServiceName] varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ServicePrice] money  NULL,
  [ServiceTypeID] int  NULL,
  [ServiceStatus] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Service] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for ServiceType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ServiceType]') AND type IN ('U'))
	DROP TABLE [dbo].[ServiceType]
GO

CREATE TABLE [dbo].[ServiceType] (
  [ServiceTypeID] int  IDENTITY(1,1) NOT NULL,
  [ServiceTypeCode] AS ('ST'+right('0000'+CONVERT([nvarchar](5),[ServiceTypeID]),(5))) PERSISTED NOT NULL,
  [ServiceType] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[ServiceType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ServiceType
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ServiceType] ON
GO

INSERT INTO [dbo].[ServiceType] ([ServiceTypeID], [ServiceType]) VALUES (N'1', N'Car Washing')
GO

INSERT INTO [dbo].[ServiceType] ([ServiceTypeID], [ServiceType]) VALUES (N'2', N'Soft Drink')
GO

INSERT INTO [dbo].[ServiceType] ([ServiceTypeID], [ServiceType]) VALUES (N'3', N'Oil')
GO

SET IDENTITY_INSERT [dbo].[ServiceType] OFF
GO


-- ----------------------------
-- View structure for reportRevenueDaily
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reportRevenueDaily]') AND type IN ('V'))
	DROP VIEW [dbo].[reportRevenueDaily]
GO

CREATE VIEW [dbo].[reportRevenueDaily] AS SELECT CONVERT(DATE,i.InvoiceDate) AS [Date], SUM(id.ServiceAmount) Amount
FROM InvoiceDetail id
INNER JOIN Invoice i
ON id.InvoiceID = i.InvoiceID
GROUP BY CONVERT(date,i.InvoiceDate)
GO


-- ----------------------------
-- View structure for reportRevenueWeekly
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[reportRevenueWeekly]') AND type IN ('V'))
	DROP VIEW [dbo].[reportRevenueWeekly]
GO

CREATE VIEW [dbo].[reportRevenueWeekly] AS SELECT
CONVERT(DATE,DATEADD(DAY,1-DATEPART(dw, MIN([InvoiceDate])),MIN([InvoiceDate]))) AS START_DATE,
CONVERT(DATE,DATEADD(DAY,7-DATEPART(dw, MIN([InvoiceDate])),MIN([InvoiceDate]))) AS END_DATE,
SUM(TotalPrice) AS Amount FROM Invoice 
GROUP BY YEAR([InvoiceDate]),MONTH([InvoiceDate]),DATEPART(ww, [InvoiceDate])
GO


-- ----------------------------
-- View structure for viewEmployee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewEmployee]') AND type IN ('V'))
	DROP VIEW [dbo].[viewEmployee]
GO

CREATE VIEW [dbo].[viewEmployee] AS SELECT EmpCode,Name,Address,Tel,Salary,p.Position,Username,Password,Email,Status 
FROM Employee e
INNER JOIN Position p
ON p.PosID = e.PosID
WHERE Status='Enable'
GO


-- ----------------------------
-- View structure for viewInvoice
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoice]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoice]
GO

CREATE VIEW [dbo].[viewInvoice] AS SELECT InvoiceCode, CONVERT(date,InvoiceDate) Date, format(InvoiceDate,'hh:mm:ss tt') [Time],e.Name, TotalPrice Amount
FROM Invoice i
INNER JOIN Employee e
ON e.EmpID = i.EmpID
GO


-- ----------------------------
-- View structure for viewInvoiceDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoiceDetail]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoiceDetail]
GO

CREATE VIEW [dbo].[viewInvoiceDetail] AS SELECT i.InvoiceCode,s.ServiceName, st.ServiceType, id.ServiceQty, s.ServicePrice, id.ServiceQty * s.ServicePrice AS [ServiceAmount]
FROM InvoiceDetail id
INNER JOIN Invoice i
ON id.InvoiceID = i.InvoiceID
INNER JOIN Service s
ON s.ServiceID = id.ServiceID
INNER JOIN ServiceType st
ON st.ServiceTypeID = s.ServiceTypeID
GO


-- ----------------------------
-- View structure for viewInvoiceDetail2
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewInvoiceDetail2]') AND type IN ('V'))
	DROP VIEW [dbo].[viewInvoiceDetail2]
GO

CREATE VIEW [dbo].[viewInvoiceDetail2] AS SELECT i.InvoiceCode,format(i.InvoiceDate,'dd-MMM-yyyy hh:mm:ss tt') [Date],s.ServiceCode,	s.ServiceName, st.ServiceType, id.ServiceQty, s.ServicePrice, e.Name,id.ServiceQty * s.ServicePrice AS [ServiceAmount]
FROM InvoiceDetail id
INNER JOIN Invoice i
ON id.InvoiceID = i.InvoiceID
INNER JOIN Service s
ON s.ServiceID = id.ServiceID
INNER JOIN ServiceType st
ON st.ServiceTypeID = s.ServiceTypeID
INNER JOIN Employee e
ON e.EmpID = i.EmpID
GO


-- ----------------------------
-- View structure for viewService
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[viewService]') AND type IN ('V'))
	DROP VIEW [dbo].[viewService]
GO

CREATE VIEW [dbo].[viewService] AS SELECT ServiceCode,ServiceName,ServicePrice,ServiceType,ServiceStatus
FROM Service s
INNER JOIN ServiceType st
ON st.ServiceTypeID = s.ServiceTypeID
GO


-- ----------------------------
-- Procedure structure for listInvoiceByType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[listInvoiceByType]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[listInvoiceByType]
GO

CREATE PROCEDURE [dbo].[listInvoiceByType](@type VARCHAR(25))
AS
SELECT *
FROM viewInvoiceDetail
WHERE ServiceType = @type;
GO


-- ----------------------------
-- Procedure structure for listInvoiceDetail2
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[listInvoiceDetail2]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[listInvoiceDetail2]
GO

CREATE PROCEDURE [dbo].[listInvoiceDetail2](@InvoiceCode VARCHAR(50))
AS
SELECT *
FROM viewInvoiceDetail2
WHERE InvoiceCode = @InvoiceCode;
GO


-- ----------------------------
-- Procedure structure for listInvoiceDaily
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[listInvoiceDaily]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[listInvoiceDaily]
GO

CREATE PROCEDURE [dbo].[listInvoiceDaily](@date DATE)
AS
SELECT *
FROM viewInvoice
WHERE CONVERT(DATE,Date)=@date;
GO


-- ----------------------------
-- Procedure structure for listInvoiceDetail
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[listInvoiceDetail]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[listInvoiceDetail]
GO

CREATE PROCEDURE [dbo].[listInvoiceDetail](@InvoiceCode VARCHAR(50))
AS
SELECT *
FROM viewInvoiceDetail
WHERE InvoiceCode = @InvoiceCode;
GO


-- ----------------------------
-- Procedure structure for listInvoiceWeekly
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[listInvoiceWeekly]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[listInvoiceWeekly]
GO

CREATE PROCEDURE [dbo].[listInvoiceWeekly](@start_date DATE, @end_date DATE)
AS
SELECT *
FROM viewInvoice
WHERE CONVERT(DATE,Date) BETWEEN @start_date AND @end_date;
GO


-- ----------------------------
-- Checks structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [CK__Employee__Status__45F365D3] CHECK ([Status]='Disable' OR [Status]='Pending' OR [Status]='Enable')
GO


-- ----------------------------
-- Primary Key structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [PK__Employee__AF2DBA799364559B] PRIMARY KEY CLUSTERED ([EmpID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Invoice
-- ----------------------------
ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [PK__Invoice__D796AAD5540B6118] PRIMARY KEY CLUSTERED ([InvoiceID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table InvoiceDetail
-- ----------------------------
ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [PK__InvoiceD__6BC711DB3002F32C] PRIMARY KEY CLUSTERED ([InvoiceID], [ServiceID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Position
-- ----------------------------
ALTER TABLE [dbo].[Position] ADD CONSTRAINT [PK__Position__67572BB391E14E32] PRIMARY KEY CLUSTERED ([PosID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Service
-- ----------------------------
ALTER TABLE [dbo].[Service] ADD CONSTRAINT [PK__Service__C51BB0EAD1783F44] PRIMARY KEY CLUSTERED ([ServiceID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ServiceType
-- ----------------------------
ALTER TABLE [dbo].[ServiceType] ADD CONSTRAINT [PK__ServiceT__8ADFAA0C38DD93DF] PRIMARY KEY CLUSTERED ([ServiceTypeID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Employee
-- ----------------------------
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT [FK__Employee__PosID__46E78A0C] FOREIGN KEY ([PosID]) REFERENCES [dbo].[Position] ([PosID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Invoice
-- ----------------------------
ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [FK__Invoice__EmpID__4F7CD00D] FOREIGN KEY ([EmpID]) REFERENCES [dbo].[Employee] ([EmpID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table InvoiceDetail
-- ----------------------------
ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [FK__InvoiceDe__Invoi__47DBAE45] FOREIGN KEY ([InvoiceID]) REFERENCES [dbo].[Invoice] ([InvoiceID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [FK__InvoiceDe__Servi__48CFD27E] FOREIGN KEY ([ServiceID]) REFERENCES [dbo].[Service] ([ServiceID]) ON DELETE CASCADE ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table Service
-- ----------------------------
ALTER TABLE [dbo].[Service] ADD CONSTRAINT [FK__Service__Service__4E88ABD4] FOREIGN KEY ([ServiceTypeID]) REFERENCES [dbo].[ServiceType] ([ServiceTypeID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

