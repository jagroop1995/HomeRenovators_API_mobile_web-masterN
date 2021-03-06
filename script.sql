USE [master]
GO
/****** Object:  Database [HomeRenovators]    Script Date: 11/23/2020 6:53:09 PM ******/
CREATE DATABASE [HomeRenovators]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HomeRenovators_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HomeRenovators.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HomeRenovators_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HomeRenovators.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HomeRenovators] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeRenovators].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeRenovators] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeRenovators] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeRenovators] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeRenovators] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeRenovators] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeRenovators] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeRenovators] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeRenovators] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeRenovators] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeRenovators] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeRenovators] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeRenovators] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeRenovators] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeRenovators] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeRenovators] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeRenovators] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeRenovators] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeRenovators] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeRenovators] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeRenovators] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeRenovators] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeRenovators] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeRenovators] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HomeRenovators] SET  MULTI_USER 
GO
ALTER DATABASE [HomeRenovators] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeRenovators] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeRenovators] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeRenovators] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HomeRenovators] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HomeRenovators] SET QUERY_STORE = OFF
GO
USE [HomeRenovators]
GO
/****** Object:  Table [dbo].[LoginDetail]    Script Date: 11/23/2020 6:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginDetail](
	[loginName] [varchar](50) NULL,
	[loginPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentDetail]    Script Date: 11/23/2020 6:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Salary] [varchar](50) NULL,
	[PaymentDate] [varchar](50) NULL,
 CONSTRAINT [PK_PaymentDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QueryDetail]    Script Date: 11/23/2020 6:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QueryDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_QueryDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceDetail]    Script Date: 11/23/2020 6:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Charges] [varchar](50) NULL,
 CONSTRAINT [PK_ServiceDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SkilledLabourDetail]    Script Date: 11/23/2020 6:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkilledLabourDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Skills] [varchar](50) NULL,
 CONSTRAINT [PK_SkilledLabourDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffDetail]    Script Date: 11/23/2020 6:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Salary] [varchar](50) NULL,
 CONSTRAINT [PK_StaffDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoginDetail] ([loginName], [loginPassword]) VALUES (N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[QueryDetail] ON 

INSERT [dbo].[QueryDetail] ([id], [Name], [Contact], [Message]) VALUES (1, N'Test', N'48548485', N'bdvjhsbd')
SET IDENTITY_INSERT [dbo].[QueryDetail] OFF
SET IDENTITY_INSERT [dbo].[ServiceDetail] ON 

INSERT [dbo].[ServiceDetail] ([id], [Name], [Charges]) VALUES (1, N'Home Renovation', N'150')
SET IDENTITY_INSERT [dbo].[ServiceDetail] OFF
SET IDENTITY_INSERT [dbo].[SkilledLabourDetail] ON 

INSERT [dbo].[SkilledLabourDetail] ([id], [Name], [Contact], [Skills]) VALUES (1, N'UTTAM SINGH', N'545841561', N'speaking')
SET IDENTITY_INSERT [dbo].[SkilledLabourDetail] OFF
SET IDENTITY_INSERT [dbo].[StaffDetail] ON 

INSERT [dbo].[StaffDetail] ([id], [Name], [Contact], [Designation], [Salary]) VALUES (1, N'Harpreet Singh', N'51545454', N'manager', N'5200')
SET IDENTITY_INSERT [dbo].[StaffDetail] OFF
USE [master]
GO
ALTER DATABASE [HomeRenovators] SET  READ_WRITE 
GO
