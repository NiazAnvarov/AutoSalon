USE [master]
GO
/****** Object:  Database [AutoSalon]    Script Date: 30.11.2023 17:25:37 ******/
CREATE DATABASE [AutoSalon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoSalon', FILENAME = N'D:\Учёба\Внедрение и поддержка компьютерных систем\Project\DataBase\AutoSalon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoSalon_log', FILENAME = N'D:\Учёба\Внедрение и поддержка компьютерных систем\Project\DataBase\AutoSalon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoSalon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoSalon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoSalon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoSalon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoSalon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoSalon] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoSalon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoSalon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoSalon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoSalon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoSalon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoSalon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoSalon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoSalon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoSalon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoSalon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoSalon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoSalon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoSalon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoSalon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoSalon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoSalon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoSalon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoSalon] SET RECOVERY FULL 
GO
ALTER DATABASE [AutoSalon] SET  MULTI_USER 
GO
ALTER DATABASE [AutoSalon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoSalon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoSalon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoSalon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoSalon] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AutoSalon', N'ON'
GO
USE [AutoSalon]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CarMake] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[KPP] [int] NOT NULL,
	[WheelDrive] [int] NOT NULL,
	[Power] [decimal](18, 1) NOT NULL,
	[Volume] [decimal](18, 2) NOT NULL,
	[Color] [int] NOT NULL,
	[Photo] [nvarchar](max) NULL,
	[Cost] [int] NOT NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Firstname] [nvarchar](max) NOT NULL,
	[Patronymic] [nvarchar](max) NULL,
	[Login] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColorTable]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorTable](
	[ID] [int] NOT NULL,
	[Color] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[Patronymic] [nvarchar](max) NULL,
	[RoleID] [int] NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KPPTable]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KPPTable](
	[ID] [int] NOT NULL,
	[KPP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KPP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[DateOfSale] [date] NOT NULL,
	[ClientID] [int] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WheelDriveTable]    Script Date: 30.11.2023 17:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WheelDriveTable](
	[ID] [int] NOT NULL,
	[WheelDrive] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_WheelDrive] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (1, N'LADA', N'Granta', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 1, N'photo/LG1.png', 700000, 2)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (2, N'LADA', N'Granta', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 3, N'photo/LG2.png', 720000, 3)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (3, N'LADA', N'Granta', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 4, N'photo/LG3.png', 725000, 1)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (4, N'LADA', N'Granta', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 2, N'photo/LG4.png', 700000, 2)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (5, N'LADA', N'Granta Cross', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 1, N'photo/LGC1.png', 945000, 1)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (6, N'LADA', N'Granta Cross', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 3, N'photo/LGC2.png', 965000, 1)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (7, N'LADA', N'Granta Cross', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 4, N'photo/LGC3.png', 970000, 1)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (8, N'LADA', N'Granta Cross', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 2, N'photo/LGC4.png', 945000, 2)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (9, N'LADA', N'Largus', 1, 1, CAST(106.0 AS Decimal(18, 1)), CAST(1.60 AS Decimal(18, 2)), 1, N'photo/LL1.png', 1920000, 3)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (10, N'UAZ', N'Patriot', 1, 3, CAST(128.0 AS Decimal(18, 1)), CAST(2.70 AS Decimal(18, 2)), 1, N'photo/UPP1.png', 1400000, 1)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (11, N'UAZ', N'Patriot', 1, 3, CAST(128.0 AS Decimal(18, 1)), CAST(2.70 AS Decimal(18, 2)), 2, N'photo/UPP2.png', 1416000, 2)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (12, N'UAZ', N'Patriot', 1, 3, CAST(150.0 AS Decimal(18, 1)), CAST(2.70 AS Decimal(18, 2)), 1, N'photo/UPR1.png', 1740000, 1)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (13, N'UAZ', N'Patriot', 1, 3, CAST(150.0 AS Decimal(18, 1)), CAST(2.70 AS Decimal(18, 2)), 2, N'photo/UPR2.png', 1756000, 2)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (14, N'UAZ', N'Patriot', 2, 3, CAST(150.0 AS Decimal(18, 1)), CAST(2.70 AS Decimal(18, 2)), 1, N'photo/UPRA1.png', 1840000, 2)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (15, N'UAZ', N'Patriot', 2, 3, CAST(150.0 AS Decimal(18, 1)), CAST(2.70 AS Decimal(18, 2)), 2, N'photo/UPRA2.png', 1856000, 3)
INSERT [dbo].[Cars] ([ID], [CarMake], [Model], [KPP], [WheelDrive], [Power], [Volume], [Color], [Photo], [Cost], [Count]) VALUES (16, N'TOYOTA', N'Land Cruiser', 2, 3, CAST(204.0 AS Decimal(18, 1)), CAST(4.20 AS Decimal(18, 2)), 2, NULL, 2700000, 1)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (1, N'Пирогов', N'Ярослав', N'Платонович', N'Flowenni', N'iJ0CEcta')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (2, N'Ковалева', N'Диана', N'Савельевна', N'Anleyn', N'uhH3vFKH')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (3, N'Черных', N'Вячеслав', N'Романович', N'Gfhrr43', N'B2Kzb7Jj')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (4, N'Соболев', N'Игорь', N'Михайлович', N'Client', N't5FJHhIi')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (5, N'Кравцова', N'Алисия', N'Марковна', N'Rain', N'TuM6N88q')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (6, N'Орехова', N'Алиса', N'Данииловна', N'Eland', N'KeNRwX6D')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (7, N'Русанов', N'Артём', N'Артёмович', N'Daniemu', N'julaDr5V')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (8, N'Голубев', N'Матвей', N'Егорович', N'Finaha', N'R4SRR9l5')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (9, N'Краснова', N'Злата', N'Андреевна', N'Tucker', N'2Ulk5A1r')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (10, N'Чернышев', N'Серафим', N'Артёмович', N'Parrance', N'stSwY3XS')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (11, N'Давыдов', N'Тимофей', N'Денисович', N'Charl', N'Gb0G9bSB')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (12, N'Абрамов', N'Тимофей', N'Михайлович', N'Januari', N'MYZAM7pg')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (13, N'Козин', N'Сергей', N'Константинович', N'Miravein', N'Q4awGdNC')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (14, N'Трофимова', N'Антонина', N'Егоровна', N'Deaco', N'kjY84l0O')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (15, N'Павлов', N'Артём', N'Павлович', N'Kuroryd', N'f8gDpswo')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (16, N'Митрофанов', N'Владимир', N'Тимофеевич', N'Mervidi', N'62voFMwo')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (17, N'Иванова', N'Кира', N'Адамовна', N'Zariang', N'VbNcw62P')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (18, N'Лукьянова', N'Екатерина', N'Тимофеевна', N'Kaiaha', N'N7EoKSm4')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (19, N'Сычев', N'Дмитрий', N'Андреевич', N'Fjuniamo', N'Db8zkf0Y')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (20, N'Зайцева', N'Эмилия', N'Семёновна', N'Kimb', N'vZJE04mn')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (21, N'Смирнов', N'Александр', N'Денисович', N'Alex12', N'n6BnDFLr')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (22, N'Новикова', N'Варвара', N'Матвеевна', N'Var2', N'M4pxFUuS')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (23, N'Королева', N'Марина', N'Марковна', N'Mrina2001', N'YChN2FpK')
INSERT [dbo].[Clients] ([ID], [Surname], [Firstname], [Patronymic], [Login], [Password]) VALUES (24, N'Андреева', N'Мадина', N'Михайловна', N'Andr232', N'h9BZNihb')
GO
INSERT [dbo].[ColorTable] ([ID], [Color]) VALUES (1, N'Белый')
INSERT [dbo].[ColorTable] ([ID], [Color]) VALUES (2, N'Черный')
INSERT [dbo].[ColorTable] ([ID], [Color]) VALUES (3, N'Красный')
INSERT [dbo].[ColorTable] ([ID], [Color]) VALUES (4, N'Синий')
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([ID], [Surname], [FirstName], [Patronymic], [RoleID], [Login], [Password]) VALUES (1, N'Мещерякова', N'Мария', N'Макаровна', 1, N'Admin', N'Admin')
INSERT [dbo].[Employees] ([ID], [Surname], [FirstName], [Patronymic], [RoleID], [Login], [Password]) VALUES (2, N'Коновалов', N'Давид', N'Максимович', 2, N'Okerre', N'cs7JdmYR')
INSERT [dbo].[Employees] ([ID], [Surname], [FirstName], [Patronymic], [RoleID], [Login], [Password]) VALUES (3, N'Сергеев', N'Дмитрий', N'Камильевич', 2, N'Meng1', N'Meng')
INSERT [dbo].[Employees] ([ID], [Surname], [FirstName], [Patronymic], [RoleID], [Login], [Password]) VALUES (4, N'Корнилова', N'Милана', N'Евгеньевна', 1, N'Admin21', N'wGtbEi4o')
INSERT [dbo].[Employees] ([ID], [Surname], [FirstName], [Patronymic], [RoleID], [Login], [Password]) VALUES (5, N'Маслов', N'Лев', N'Александрович', 2, N'Jerra', N'Cw7ZuYD0')
INSERT [dbo].[Employees] ([ID], [Surname], [FirstName], [Patronymic], [RoleID], [Login], [Password]) VALUES (6, N'Захарова', N'Полина', N'Александровна', 2, N'Meng3', N'fQkUo4iG')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[KPPTable] ([ID], [KPP]) VALUES (1, N'МКПП')
INSERT [dbo].[KPPTable] ([ID], [KPP]) VALUES (2, N'АКПП')
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Role]) VALUES (1, N'Администратор')
INSERT [dbo].[Role] ([ID], [Role]) VALUES (2, N'Менеджер')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (1, 2, CAST(N'2023-09-29' AS Date), 1)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (2, 4, CAST(N'2023-10-15' AS Date), 3)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (3, 1, CAST(N'2023-10-19' AS Date), 4)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (4, 10, CAST(N'2023-09-26' AS Date), 2)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (5, 11, CAST(N'2023-11-24' AS Date), 7)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (6, 14, CAST(N'2023-09-14' AS Date), 9)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (7, 8, CAST(N'2023-10-20' AS Date), 24)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (8, 6, CAST(N'2023-10-08' AS Date), 17)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (9, 9, CAST(N'2023-10-25' AS Date), 13)
INSERT [dbo].[Sales] ([ID], [CarID], [DateOfSale], [ClientID]) VALUES (10, 12, CAST(N'2023-09-26' AS Date), 19)
SET IDENTITY_INSERT [dbo].[Sales] OFF
GO
INSERT [dbo].[WheelDriveTable] ([ID], [WheelDrive]) VALUES (1, N'Передний')
INSERT [dbo].[WheelDriveTable] ([ID], [WheelDrive]) VALUES (2, N'Задний')
INSERT [dbo].[WheelDriveTable] ([ID], [WheelDrive]) VALUES (3, N'Полный')
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Color] FOREIGN KEY([Color])
REFERENCES [dbo].[ColorTable] ([ID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Color]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_KPP] FOREIGN KEY([KPP])
REFERENCES [dbo].[KPPTable] ([ID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_KPP]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_WheelDrive] FOREIGN KEY([WheelDrive])
REFERENCES [dbo].[WheelDriveTable] ([ID])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_WheelDrive]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Users_Role]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Cars] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([ID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Cars]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Clients]
GO
USE [master]
GO
ALTER DATABASE [AutoSalon] SET  READ_WRITE 
GO
