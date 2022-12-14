USE [master]
GO
/****** Object:  Database [Hostel_Management_Project]    Script Date: 7/13/2022 10:46:33 PM ******/
CREATE DATABASE [Hostel_Management_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hostel_Management_Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hostel_Management_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hostel_Management_Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hostel_Management_Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hostel_Management_Project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hostel_Management_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hostel_Management_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hostel_Management_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hostel_Management_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hostel_Management_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hostel_Management_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET RECOVERY FULL 
GO
ALTER DATABASE [Hostel_Management_Project] SET  MULTI_USER 
GO
ALTER DATABASE [Hostel_Management_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hostel_Management_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hostel_Management_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hostel_Management_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hostel_Management_Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hostel_Management_Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hostel_Management_Project', N'ON'
GO
ALTER DATABASE [Hostel_Management_Project] SET QUERY_STORE = OFF
GO
USE [Hostel_Management_Project]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[contractID] [int] IDENTITY(1,1) NOT NULL,
	[customerID] [int] NOT NULL,
	[roomID] [int] NOT NULL,
	[startDate] [date] NOT NULL,
	[endDate] [date] NOT NULL,
	[depositMoney] [int] NULL,
	[depositMoneyStatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[contractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[gender] [nvarchar](50) NULL,
	[customerName] [nvarchar](50) NULL,
	[dob] [date] NULL,
	[phoneNumber] [char](10) NULL,
	[documentID] [char](12) NULL,
	[roomId] [int] NULL,
	[isRenting] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[equipmentID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[quantity] [int] NOT NULL,
	[price] [float] NULL,
	[roomID] [int] NOT NULL,
	[status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[equipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HostelOwner]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HostelOwner](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[invoiceID] [int] IDENTITY(1,1) NOT NULL,
	[invoiceName] [nvarchar](50) NOT NULL,
	[roomID] [int] NOT NULL,
	[customerID] [int] NOT NULL,
	[roomCharge] [float] NOT NULL,
	[serviceCharge] [float] NOT NULL,
	[total] [float] NOT NULL,
	[createDate] [smalldatetime] NULL,
	[note] [nvarchar](255) NULL,
	[status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[invoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[roomID] [int] IDENTITY(1,1) NOT NULL,
	[price] [float] NOT NULL,
	[roomName] [nvarchar](50) NULL,
	[roomStatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[roomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[service]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service](
	[serviceID] [int] IDENTITY(1,1) NOT NULL,
	[serviceName] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[serviceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usedService]    Script Date: 7/13/2022 10:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usedService](
	[usedServiceID] [int] IDENTITY(1,1) NOT NULL,
	[serviceID] [int] NOT NULL,
	[roomID] [int] NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NOT NULL,
	[invoiceID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[usedServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contract] ON 

INSERT [dbo].[Contract] ([contractID], [customerID], [roomID], [startDate], [endDate], [depositMoney], [depositMoneyStatus]) VALUES (5, 4, 4, CAST(N'2022-11-25' AS Date), CAST(N'2022-11-25' AS Date), 5000000, 1)
INSERT [dbo].[Contract] ([contractID], [customerID], [roomID], [startDate], [endDate], [depositMoney], [depositMoneyStatus]) VALUES (6, 5, 2, CAST(N'2022-08-12' AS Date), CAST(N'2022-08-12' AS Date), 6000000, 1)
INSERT [dbo].[Contract] ([contractID], [customerID], [roomID], [startDate], [endDate], [depositMoney], [depositMoneyStatus]) VALUES (13, 9, 3, CAST(N'2022-09-12' AS Date), CAST(N'2022-09-12' AS Date), 50000000, 1)
INSERT [dbo].[Contract] ([contractID], [customerID], [roomID], [startDate], [endDate], [depositMoney], [depositMoneyStatus]) VALUES (14, 5, 1, CAST(N'2022-07-12' AS Date), CAST(N'2023-07-12' AS Date), 10000000, 1)
INSERT [dbo].[Contract] ([contractID], [customerID], [roomID], [startDate], [endDate], [depositMoney], [depositMoneyStatus]) VALUES (17, 5, 4, CAST(N'2022-07-12' AS Date), CAST(N'2022-07-12' AS Date), 12, 1)
SET IDENTITY_INSERT [dbo].[Contract] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([customerID], [gender], [customerName], [dob], [phoneNumber], [documentID], [roomId], [isRenting]) VALUES (3, N'Nam', N'Nam', CAST(N'2006-01-01' AS Date), N'0387788935', N'241122337   ', 4, 1)
INSERT [dbo].[Customer] ([customerID], [gender], [customerName], [dob], [phoneNumber], [documentID], [roomId], [isRenting]) VALUES (4, N'Nam', N'Xuân Hùng1', CAST(N'2009-01-01' AS Date), N'0387788991', N'241122339   ', 3, 1)
INSERT [dbo].[Customer] ([customerID], [gender], [customerName], [dob], [phoneNumber], [documentID], [roomId], [isRenting]) VALUES (5, N'Nam', N'Xuân Hùng1', CAST(N'2009-01-14' AS Date), N'0387788991', N'241122333   ', 3, 1)
INSERT [dbo].[Customer] ([customerID], [gender], [customerName], [dob], [phoneNumber], [documentID], [roomId], [isRenting]) VALUES (9, N'Nam', N'3', CAST(N'2022-07-13' AS Date), N'3         ', N'3           ', 2, 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipment] ON 

INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (1, N'Quạt', 1, 100000, 1, 1)
INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (2, N'Tủ lạnh', 1, 5000001, 1, 1)
INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (3, N'Quạt', 1, 50000, 2, 1)
INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (4, N'Quạt', 1, 99999, 3, 1)
INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (6, N'Giuong', 1, 99999, 1, 1)
INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (9, N'333', 33, 33333, 3, 1)
INSERT [dbo].[Equipment] ([equipmentID], [name], [quantity], [price], [roomID], [status]) VALUES (10, N'Quat ', 6, 100000, 7, 1)
SET IDENTITY_INSERT [dbo].[Equipment] OFF
GO
SET IDENTITY_INSERT [dbo].[HostelOwner] ON 

INSERT [dbo].[HostelOwner] ([userID], [username], [password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[HostelOwner] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (4, N'1', 1, 5, 3000000, 30502, 3030502, CAST(N'2022-07-13T01:55:00' AS SmallDateTime), N'1', 1)
INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (5, N'tien thang 6', 4, 3, 3000001, 0, 3000001, CAST(N'2022-07-13T14:25:00' AS SmallDateTime), N'test', 1)
INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (6, N'tien thang 6', 4, 3, 3000001, 0, 3000001, CAST(N'2022-07-13T14:28:00' AS SmallDateTime), N'test2', 1)
INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (7, N'tien thang 6', 3, 3, 3000001, 1000012, 4000013, CAST(N'2022-07-13T14:28:00' AS SmallDateTime), N'test3', 1)
INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (8, N'2', 3, 5, 3000001, 0, 3000001, CAST(N'2022-07-13T14:35:00' AS SmallDateTime), N'2', 0)
INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (9, N'1', 3, 4, 3000001, 0, 3000001, CAST(N'2022-07-13T16:28:00' AS SmallDateTime), N'', 0)
INSERT [dbo].[Invoice] ([invoiceID], [invoiceName], [roomID], [customerID], [roomCharge], [serviceCharge], [total], [createDate], [note], [status]) VALUES (11, N'111', 3, 5, 3000001, 4, 3000005, CAST(N'2022-07-13T22:23:00' AS SmallDateTime), N'1', 0)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([roomID], [price], [roomName], [roomStatus]) VALUES (1, 3000000, N'Phòng 101', 0)
INSERT [dbo].[Room] ([roomID], [price], [roomName], [roomStatus]) VALUES (2, 3000000, N'Phòng 102', 0)
INSERT [dbo].[Room] ([roomID], [price], [roomName], [roomStatus]) VALUES (3, 3000001, N'Phòng 109', 1)
INSERT [dbo].[Room] ([roomID], [price], [roomName], [roomStatus]) VALUES (4, 3000001, N'Phòng 103', 0)
INSERT [dbo].[Room] ([roomID], [price], [roomName], [roomStatus]) VALUES (7, 3600000, N'Phòng 105', 0)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[service] ON 

INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (1, N'Điện', 3500)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (2, N'Nước', 20000)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (3, N'Wifi', 1000012)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (4, N'Giữ xe', 50000)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (5, N'test', 2)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (6, N'1', 2)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (7, N'Test2', 100000)
INSERT [dbo].[service] ([serviceID], [serviceName], [price]) VALUES (8, N'1', 2)
SET IDENTITY_INSERT [dbo].[service] OFF
GO
SET IDENTITY_INSERT [dbo].[usedService] ON 

INSERT [dbo].[usedService] ([usedServiceID], [serviceID], [roomID], [price], [quantity], [invoiceID]) VALUES (1, 1, 1, 500, 1, 4)
INSERT [dbo].[usedService] ([usedServiceID], [serviceID], [roomID], [price], [quantity], [invoiceID]) VALUES (2, 1, 1, 30000, 1, 4)
INSERT [dbo].[usedService] ([usedServiceID], [serviceID], [roomID], [price], [quantity], [invoiceID]) VALUES (5, 4, 2, 50000, 1, NULL)
INSERT [dbo].[usedService] ([usedServiceID], [serviceID], [roomID], [price], [quantity], [invoiceID]) VALUES (6, 3, 3, 1000012, 1, 7)
INSERT [dbo].[usedService] ([usedServiceID], [serviceID], [roomID], [price], [quantity], [invoiceID]) VALUES (7, 6, 3, 2, 2, 11)
SET IDENTITY_INSERT [dbo].[usedService] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__HostelOw__F3DBC572261A35AC]    Script Date: 7/13/2022 10:46:33 PM ******/
ALTER TABLE [dbo].[HostelOwner] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT (getdate()) FOR [createDate]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_ContractCustomer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_ContractCustomer]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_ContractRoom] FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_ContractRoom]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_CustomerRoom] FOREIGN KEY([roomId])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_CustomerRoom]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_EquipmentRoom] FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_EquipmentRoom]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceCustomer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([customerID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_InvoiceCustomer]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceRoom] FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_InvoiceRoom]
GO
ALTER TABLE [dbo].[usedService]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceService] FOREIGN KEY([serviceID])
REFERENCES [dbo].[service] ([serviceID])
GO
ALTER TABLE [dbo].[usedService] CHECK CONSTRAINT [FK_InvoiceService]
GO
ALTER TABLE [dbo].[usedService]  WITH CHECK ADD  CONSTRAINT [FK_Service] FOREIGN KEY([invoiceID])
REFERENCES [dbo].[Invoice] ([invoiceID])
GO
ALTER TABLE [dbo].[usedService] CHECK CONSTRAINT [FK_Service]
GO
ALTER TABLE [dbo].[usedService]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRoom] FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[usedService] CHECK CONSTRAINT [FK_ServiceRoom]
GO
USE [master]
GO
ALTER DATABASE [Hostel_Management_Project] SET  READ_WRITE 
GO
