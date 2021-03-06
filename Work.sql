USE [master]
GO
/****** Object:  Database [Work]    Script Date: 16.04.2016 0:26:57 ******/
CREATE DATABASE [Work]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Work', FILENAME = N'D:\VStudio\Provider\Work.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Work_log', FILENAME = N'D:\VStudio\Provider\Work_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Work] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Work].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Work] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Work] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Work] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Work] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Work] SET ARITHABORT OFF 
GO
ALTER DATABASE [Work] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Work] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Work] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Work] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Work] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Work] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Work] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Work] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Work] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Work] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Work] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Work] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Work] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Work] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Work] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Work] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Work] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Work] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Work] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Work] SET  MULTI_USER 
GO
ALTER DATABASE [Work] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Work] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Work] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Work] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Work]
GO
/****** Object:  Table [dbo].[Abonent]    Script Date: 16.04.2016 0:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Abonent](
	[AbonentId] [int] IDENTITY(1,1) NOT NULL,
	[TarifId] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Abonent] PRIMARY KEY CLUSTERED 
(
	[AbonentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tarif]    Script Date: 16.04.2016 0:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarif](
	[TarifId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Discription] [nvarchar](150) NULL,
 CONSTRAINT [PK_Tarif] PRIMARY KEY CLUSTERED 
(
	[TarifId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Abonent] ON 

INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (1, 5, N'eeee', N'rrrr')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (2, 3, N'12345', N'eerrr')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (3, 7, N'123456', N'12345')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (4, 3, N'111', N'222')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (5, 5, N'222', N'333')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (6, 7, N'3333', N'4444')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (7, 5, N'44553', N'ffdfdf')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (8, 5, N'eererere', N'eererer')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (9, 3, N'vvbvbbbv', N'vbvbvb')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (10, 6, N'vbvbvb', N'fgfgfgf')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (11, 6, N'fgffgfg', N'bvbvb')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (12, 6, N'eerere', N'erdfdf')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (13, 5, N'wewewe', N'wwewe')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (14, 7, N'wewew', N'weww')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (15, 5, N'ewwf ', N'wrwrewr')
INSERT [dbo].[Abonent] ([AbonentId], [TarifId], [Name], [Address]) VALUES (16, 5, N'eeeer', N'rrrrr')
SET IDENTITY_INSERT [dbo].[Abonent] OFF
SET IDENTITY_INSERT [dbo].[Tarif] ON 

INSERT [dbo].[Tarif] ([TarifId], [Name], [Price], [Discription]) VALUES (3, N'Минимальный', 350, N'Минимум')
INSERT [dbo].[Tarif] ([TarifId], [Name], [Price], [Discription]) VALUES (5, N'Средний', 500, N'Получше')
INSERT [dbo].[Tarif] ([TarifId], [Name], [Price], [Discription]) VALUES (6, N'Большой', 800, N'Хороший')
INSERT [dbo].[Tarif] ([TarifId], [Name], [Price], [Discription]) VALUES (7, N'Максимальный', 1200, N'Лучше вех')
SET IDENTITY_INSERT [dbo].[Tarif] OFF
ALTER TABLE [dbo].[Abonent]  WITH CHECK ADD  CONSTRAINT [FK_Abonent_Tarif] FOREIGN KEY([TarifId])
REFERENCES [dbo].[Tarif] ([TarifId])
GO
ALTER TABLE [dbo].[Abonent] CHECK CONSTRAINT [FK_Abonent_Tarif]
GO
USE [master]
GO
ALTER DATABASE [Work] SET  READ_WRITE 
GO
