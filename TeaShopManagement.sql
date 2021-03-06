USE [master]
GO
/****** Object:  Database [TeaShopManagement]    Script Date: 11/3/2021 6:11:27 PM ******/
CREATE DATABASE [TeaShopManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TeaShopManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TeaShopManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TeaShopManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TeaShopManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TeaShopManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TeaShopManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TeaShopManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TeaShopManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TeaShopManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TeaShopManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TeaShopManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [TeaShopManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TeaShopManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TeaShopManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TeaShopManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TeaShopManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TeaShopManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TeaShopManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TeaShopManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TeaShopManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TeaShopManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TeaShopManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TeaShopManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TeaShopManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TeaShopManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TeaShopManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TeaShopManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TeaShopManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TeaShopManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [TeaShopManagement] SET  MULTI_USER 
GO
ALTER DATABASE [TeaShopManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TeaShopManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TeaShopManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TeaShopManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TeaShopManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TeaShopManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TeaShopManagement', N'ON'
GO
ALTER DATABASE [TeaShopManagement] SET QUERY_STORE = OFF
GO
USE [TeaShopManagement]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[userName] [nvarchar](100) NOT NULL,
	[roleId] [int] NOT NULL,
	[accountName] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBill]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dateCheckIn] [date] NOT NULL,
	[dateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [nvarchar](100) NOT NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBillInfo]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategories]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFoods]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFoods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
	[status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoles]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoles](
	[roleId] [int] NOT NULL,
	[roleName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTable]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([userName], [roleId], [accountName], [password], [status]) VALUES (N'nhut', 1, N'phan minh nhutt', N'1', N'active')
INSERT [dbo].[tblAccount] ([userName], [roleId], [accountName], [password], [status]) VALUES (N'staff1', 0, N'staff 1', N'2', N'active')
INSERT [dbo].[tblAccount] ([userName], [roleId], [accountName], [password], [status]) VALUES (N'staff2', 0, N'staff 2', N'123', N'active')
INSERT [dbo].[tblAccount] ([userName], [roleId], [accountName], [password], [status]) VALUES (N'staff3', 0, N'staff 3333', N'123', N'active')
INSERT [dbo].[tblAccount] ([userName], [roleId], [accountName], [password], [status]) VALUES (N'staff4', 1, N'staff 4', N'123', N'active')
INSERT [dbo].[tblAccount] ([userName], [roleId], [accountName], [password], [status]) VALUES (N'staff5', 1, N'staff 5', N'123', N'active')
GO
SET IDENTITY_INSERT [dbo].[tblBill] ON 

INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (35, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-22' AS Date), 2, N'PAID', 156000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (36, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-19' AS Date), 9, N'PAID', 78000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (37, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-22' AS Date), 5, N'PAID', 146000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (38, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-22' AS Date), 13, N'PAID', 70000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (39, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-19' AS Date), 7, N'PAID', 70000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (40, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-19' AS Date), 14, N'PAID', 98000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (41, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-22' AS Date), 11, N'PAID', 116000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (42, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-22' AS Date), 10, N'PAID', 39000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (43, CAST(N'2021-10-19' AS Date), CAST(N'2021-10-22' AS Date), 9, N'PAID', 312000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (44, CAST(N'2021-10-26' AS Date), CAST(N'2021-10-27' AS Date), 8, N'PAID', 70000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (45, CAST(N'2021-10-26' AS Date), CAST(N'2021-10-27' AS Date), 2, N'PAID', 78000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (49, CAST(N'2021-10-27' AS Date), CAST(N'2021-10-27' AS Date), 9, N'PAID', 30000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (50, CAST(N'2021-10-28' AS Date), CAST(N'2021-10-28' AS Date), 2, N'PAID', 180000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (51, CAST(N'2021-10-28' AS Date), CAST(N'2021-10-28' AS Date), 9, N'PAID', 0)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (52, CAST(N'2021-10-28' AS Date), CAST(N'2021-10-28' AS Date), 15, N'PAID', 70000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (53, CAST(N'2021-11-02' AS Date), CAST(N'2021-11-02' AS Date), 8, N'PAID', 78000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (54, CAST(N'2021-11-02' AS Date), CAST(N'2021-11-02' AS Date), 4, N'PAID', 126000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (55, CAST(N'2021-11-03' AS Date), NULL, 9, N'UNPAID', NULL)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (56, CAST(N'2021-11-03' AS Date), NULL, 10, N'UNPAID', NULL)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (57, CAST(N'2021-11-03' AS Date), CAST(N'2021-11-03' AS Date), 7, N'PAID', 479000)
INSERT [dbo].[tblBill] ([id], [dateCheckIn], [dateCheckOut], [idTable], [status], [totalPrice]) VALUES (58, CAST(N'2021-11-03' AS Date), NULL, 4, N'UNPAID', NULL)
SET IDENTITY_INSERT [dbo].[tblBill] OFF
GO
SET IDENTITY_INSERT [dbo].[tblBillInfo] ON 

INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (75, 35, 1, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (76, 35, 2, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (77, 36, 2, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (78, 37, 2, 3)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (79, 38, 14, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (80, 39, 14, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (81, 40, 11, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (82, 41, 23, 4)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (83, 37, 4, 1)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (84, 42, 1, 1)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (85, 43, 1, 4)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (86, 43, 2, 4)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (87, 44, 14, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (95, 45, 1, 1)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (96, 45, 3, 1)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (97, 49, 38, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (98, 50, 15, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (99, 50, 14, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (101, 52, 14, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (104, 53, 1, 2)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (106, 54, 1, 1)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (107, 54, 20, 3)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (111, 57, 1, 1)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (112, 57, 16, 3)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (113, 57, 15, 3)
INSERT [dbo].[tblBillInfo] ([id], [idBill], [idFood], [count]) VALUES (114, 57, 12, 2)
SET IDENTITY_INSERT [dbo].[tblBillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[tblCategories] ON 

INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (1, N'Vietnamese PHIN coffee', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (2, N'Tea', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (3, N'Ice Blended', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (4, N'Espresso Coffee', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (5, N'Pastry', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (6, N'Other Drinks', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (7, N'Snacks', N'active')
INSERT [dbo].[tblCategories] ([id], [name], [status]) VALUES (8, N'Cake', N'passive')
SET IDENTITY_INSERT [dbo].[tblCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[tblFoods] ON 

INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (1, N'Iced Coffee with Condensed Milk', 1, 39000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (2, N'Iced Black Coffee', 1, 39000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (3, N'White PHIN Coffee & Condensed Milk', 1, 39000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (4, N'Tea with Lotus Seeds', 2, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (5, N'Tea with Peach Jelly', 2, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (6, N'Peach Tea with Lemon Grass', 2, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (7, N'Tea with Lychee Jelly', 2, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (8, N'Green Tea & Red Beans', 2, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (9, N'Green Tea Freeze', 3, 49000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (10, N'Chocolate Freeze', 3, 49000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (11, N'Cookies & Cream', 3, 49000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (12, N'Caramel Phin Freeze', 3, 49000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (13, N'Classic Phin Freeze', 3, 49000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (14, N'Espresso/Americano', 4, 35000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (15, N'Cappuccino/Latte', 4, 55000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (16, N'Mocha/Caramel Macchiato', 4, 59000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (17, N'Tiramisu', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (18, N'Banana Cake', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (19, N'Peach Mousse', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (20, N'Cocoa Mousse', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (21, N'Green Tea Cheese Cake', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (22, N'Passion Fruit Cheese Cake', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (23, N'Coffee Cheese Cake', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (24, N'Caramel Cheese Cake', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (25, N'Chocolate Cake', 5, 29000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (26, N'Iced Lime Juice', 6, 39000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (27, N'Iced Passion Fruit Juice', 6, 39000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (28, N'Iced Kumquat Jiuce', 6, 39000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (29, N'Dark Chocolate H', 6, 55000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (30, N'Dark Chocolate C', 6, 55000, N'active')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (32, N'Mango Juice', 1, 39000, N'passive')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (35, N'Banana Blue Cake', 5, 39000, N'passive')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (38, N'Su Su Cake', 5, 15000, N'passive')
INSERT [dbo].[tblFoods] ([id], [name], [idCategory], [price], [status]) VALUES (39, N'Milk Tea', 2, 100000, N'passive')
SET IDENTITY_INSERT [dbo].[tblFoods] OFF
GO
INSERT [dbo].[tblRoles] ([roleId], [roleName]) VALUES (0, N'staff')
INSERT [dbo].[tblRoles] ([roleId], [roleName]) VALUES (1, N'admin')
GO
SET IDENTITY_INSERT [dbo].[tblTable] ON 

INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (1, N'Table 0', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (2, N'Table 1', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (3, N'Table 2', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (4, N'Table 3', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (5, N'Table 4', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (6, N'Table 5', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (7, N'Table 6', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (8, N'Table 7', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (9, N'Table 8', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (10, N'Table 9', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (11, N'Table 10', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (12, N'Table 11', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (13, N'Table 12', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (14, N'Table 13', N'Empty')
INSERT [dbo].[tblTable] ([id], [name], [status]) VALUES (15, N'Table 14', N'Empty')
SET IDENTITY_INSERT [dbo].[tblTable] OFF
GO
ALTER TABLE [dbo].[tblBill] ADD  DEFAULT (getdate()) FOR [dateCheckIn]
GO
ALTER TABLE [dbo].[tblBill] ADD  DEFAULT (N'not pay') FOR [status]
GO
ALTER TABLE [dbo].[tblBillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[tblFoods] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[tblTable] ADD  DEFAULT (N'Empty') FOR [status]
GO
ALTER TABLE [dbo].[tblAccount]  WITH CHECK ADD FOREIGN KEY([roleId])
REFERENCES [dbo].[tblRoles] ([roleId])
GO
ALTER TABLE [dbo].[tblBill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[tblTable] ([id])
GO
ALTER TABLE [dbo].[tblBillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[tblBill] ([id])
GO
ALTER TABLE [dbo].[tblBillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[tblFoods] ([id])
GO
ALTER TABLE [dbo].[tblFoods]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[tblCategories] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteBillInfo]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--
CREATE proc [dbo].[USP_DeleteBillInfo] @idBill int, @idFood int, @count int
as
begin
	declare @isExistBillInfo int
	declare @foodCount int = 1

	select @isExistBillInfo = id, @foodCount =bi.count
	from tblBillInfo as bi
	where idBill = @idBIll and idFood = @idFood
	if(@isExistBillInfo > 0)
	begin
		declare @newCount int = @foodCount - @count
		update tblBillInfo set count = @foodCount - @count where idFood = @idFood and idBill = @idBill 
		if(@newCount <= 0)
			
			delete tblBillInfo where idBill = @idBill and idFood = @idFood 
	end

end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
as
begin
	select * from tblAccount where userName = @userName
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetTableList]
as select * from tblTable
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_InsertBill] @idTable int 
as
begin
	insert tblBill (dateCheckIn, dateCheckOut, idTable, status)
	values (getdate(), null, @idTable, 'UNPAID')
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--create roi moi alter proc

CREATE proc [dbo].[USP_InsertBillInfo] 
@idBIll int, @idFood int, @count int
as
begin
	
	declare @isExistBillInfo int

	declare @foodCount int = 1

	select @isExistBillInfo = id, @foodCount =bi.count
	from tblBillInfo as bi
	where idBill = @idBIll and idFood = @idFood

	if(@isExistBillInfo > 0)
	begin
		
			update tblBillInfo set count = @foodCount + @count where idFood = @idFood and idBill = @idBIll 
		
	end
	else
	begin
		insert tblBillInfo (idBill, idFood, count)
		values (@idBIll, @idFood, @count)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccountInfo]    Script Date: 11/3/2021 6:11:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_UpdateAccountInfo]
@userName nvarchar(100), @displayName nvarchar(100), @passWord int, @newPass int
as
begin
	declare @isCorrectPass int = 0
	select @isCorrectPass = count(*) from tblAccount where userName = @userName and password = @passWord

	if(@isCorrectPass = 1)
	begin
		if(@newPass = null or @newPass = '')
		begin
			update tblAccount set accountName = @displayName where userName = @userName
		end
		else
			update tblAccount set accountName = @displayName, password = @newPass where userName = @userName
	end
end
GO
USE [master]
GO
ALTER DATABASE [TeaShopManagement] SET  READ_WRITE 
GO
