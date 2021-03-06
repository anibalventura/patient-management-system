USE [master]
GO
/****** Object:  Database [PatientMgmtSys]    Script Date: 11/22/2021 12:26:08 PM ******/
CREATE DATABASE [PatientMgmtSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PatientMgmtSys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PatientMgmtSys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PatientMgmtSys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PatientMgmtSys_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PatientMgmtSys] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PatientMgmtSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PatientMgmtSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PatientMgmtSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PatientMgmtSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PatientMgmtSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PatientMgmtSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET RECOVERY FULL 
GO
ALTER DATABASE [PatientMgmtSys] SET  MULTI_USER 
GO
ALTER DATABASE [PatientMgmtSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PatientMgmtSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PatientMgmtSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PatientMgmtSys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PatientMgmtSys] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PatientMgmtSys] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PatientMgmtSys', N'ON'
GO
ALTER DATABASE [PatientMgmtSys] SET QUERY_STORE = OFF
GO
USE [PatientMgmtSys]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 11/22/2021 12:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPatient] [int] NULL,
	[IdDoctor] [int] NULL,
	[DateAndTime] [datetime] NULL,
	[Cause] [varchar](100) NULL,
	[IdAppointmentStatus] [int] NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppointmentStatus]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppointmentStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_AppointmentStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[AppointmentStatus](Name) VALUES('Complete')
INSERT INTO [dbo].[AppointmentStatus](Name) VALUES('Pending Results')
INSERT INTO [dbo].[AppointmentStatus](Name) VALUES('Pending Consult')

/****** Object:  Table [dbo].[Doctors]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](80) NULL,
	[Phone] [varchar](30) NULL,
	[Identification] [varchar](20) NULL,
	[Photo] [varchar](max) NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabResults]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabResults](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPatient] [int] NULL,
	[IdAppointment] [int] NULL,
	[IdLabTest] [int] NULL,
	[IdDoctor] [int] NULL,
	[Result] [varchar](200) NULL,
	[IdResultStatus] [int] NULL,
 CONSTRAINT [PK_LabResults] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTests]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
 CONSTRAINT [PK_LabTests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phone] [varchar](30) NULL,
	[Address] [varchar](100) NULL,
	[Identification] [varchar](20) NULL,
	[BirthDate] [datetime] NULL,
	[Smoker] [bit] NULL,
	[Allergies] [varchar](100) NULL,
	[Photo] [varchar](max) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultStatus]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_ResultStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[ResultStatus](Name) VALUES('Complete')
INSERT INTO [dbo].[ResultStatus](Name) VALUES('Pending')

/****** Object:  Table [dbo].[Users]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](80) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[IdUserType] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 11/22/2021 12:26:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[UserType](Name) VALUES('Admin')
INSERT INTO [dbo].[UserType](Name) VALUES('Doctor')

ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_AppointmentStatus] FOREIGN KEY([IdAppointmentStatus])
REFERENCES [dbo].[AppointmentStatus] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_AppointmentStatus]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Doctors] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Doctors] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Doctors]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Patients] FOREIGN KEY([IdPatient])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Patients]
GO
ALTER TABLE [dbo].[LabResults]  WITH CHECK ADD  CONSTRAINT [FK_LabResults_Doctors] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Doctors] ([Id])
GO
ALTER TABLE [dbo].[LabResults] CHECK CONSTRAINT [FK_LabResults_Doctors]
GO
ALTER TABLE [dbo].[LabResults]  WITH CHECK ADD  CONSTRAINT [FK_LabResults_LabTests] FOREIGN KEY([IdLabTest])
REFERENCES [dbo].[LabTests] ([Id])
GO
ALTER TABLE [dbo].[LabResults] CHECK CONSTRAINT [FK_LabResults_LabTests]
GO
ALTER TABLE [dbo].[LabResults]  WITH CHECK ADD  CONSTRAINT [FK_LabResults_Patients] FOREIGN KEY([IdPatient])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[LabResults] CHECK CONSTRAINT [FK_LabResults_Patients]
GO
ALTER TABLE [dbo].[LabResults]  WITH CHECK ADD  CONSTRAINT [FK_LabResults_ResultStatus] FOREIGN KEY([IdResultStatus])
REFERENCES [dbo].[ResultStatus] ([Id])
GO
ALTER TABLE [dbo].[LabResults] CHECK CONSTRAINT [FK_LabResults_ResultStatus]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserType] FOREIGN KEY([IdUserType])
REFERENCES [dbo].[UserType] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserType]
GO
USE [master]
GO
ALTER DATABASE [PatientMgmtSys] SET  READ_WRITE 
GO
