
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/21/2021 16:49:09
-- Generated from EDMX file: D:\Projects\C#\CUOnline\DataLayer\CUOnline.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CUOnlineDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Assignments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Assignments];
GO
IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[Instructors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Instructors];
GO
IF OBJECT_ID(N'[dbo].[Questions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Questions];
GO
IF OBJECT_ID(N'[dbo].[Quiz]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Quiz];
GO
IF OBJECT_ID(N'[dbo].[Results]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Results];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[CUOnlineDatabaseModelStoreContainer].[CourseData]', 'U') IS NOT NULL
    DROP TABLE [CUOnlineDatabaseModelStoreContainer].[CourseData];
GO
IF OBJECT_ID(N'[CUOnlineDatabaseModelStoreContainer].[Registrations]', 'U') IS NOT NULL
    DROP TABLE [CUOnlineDatabaseModelStoreContainer].[Registrations];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Assignments'
CREATE TABLE [dbo].[Assignments] (
    [RegistrationID] nvarchar(10)  NOT NULL,
    [TotalMarks] int  NOT NULL,
    [Discription] varchar(max)  NULL,
    [StartTime] datetime  NULL,
    [EndTime] datetime  NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseCode] int  NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [CreditHours] int  NOT NULL
);
GO

-- Creating table 'Instructors'
CREATE TABLE [dbo].[Instructors] (
    [InstructorID] int  NOT NULL,
    [Name] nchar(32)  NOT NULL,
    [FatherName] nchar(32)  NOT NULL,
    [Email] nchar(32)  NOT NULL,
    [Password] varchar(32)  NOT NULL,
    [Nationality] nchar(16)  NOT NULL,
    [DOB] datetime  NOT NULL,
    [ContactNo] nchar(16)  NOT NULL
);
GO

-- Creating table 'Questions'
CREATE TABLE [dbo].[Questions] (
    [QuestionID] int  NOT NULL,
    [RegistrationID] nvarchar(10)  NOT NULL,
    [Material] varbinary(max)  NULL
);
GO

-- Creating table 'Quizs'
CREATE TABLE [dbo].[Quizs] (
    [RegistrationID] nvarchar(10)  NOT NULL,
    [QuizID] int  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [EndTime] datetime  NULL,
    [TotalMarks] int  NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [RegistrationID] nvarchar(10)  NOT NULL,
    [QuestionID] int  NULL,
    [TotalMarks] int  NULL,
    [MarksObtained] int  NULL,
    [ExamDate] datetime  NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StudentID] int  NOT NULL,
    [Name] nchar(32)  NOT NULL,
    [FatherName] nchar(32)  NOT NULL,
    [Email] nchar(32)  NOT NULL,
    [Password] varchar(32)  NOT NULL,
    [Nationality] nchar(16)  NOT NULL,
    [DOB] datetime  NOT NULL,
    [ContactNo] nchar(16)  NOT NULL,
    [Batch] nchar(4)  NOT NULL,
    [Program] nchar(4)  NOT NULL,
    [Gender] nchar(10)  NOT NULL
);
GO

-- Creating table 'CourseDatas'
CREATE TABLE [dbo].[CourseDatas] (
    [RegistrationID] nvarchar(10)  NOT NULL,
    [Material] nvarchar(50)  NULL
);
GO

-- Creating table 'Registrations'
CREATE TABLE [dbo].[Registrations] (
    [RegistrationID] nvarchar(10)  NOT NULL,
    [StudentID] nvarchar(10)  NOT NULL,
    [CourseID] nvarchar(10)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [RegistrationID] in table 'Assignments'
ALTER TABLE [dbo].[Assignments]
ADD CONSTRAINT [PK_Assignments]
    PRIMARY KEY CLUSTERED ([RegistrationID] ASC);
GO

-- Creating primary key on [CourseCode] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseCode] ASC);
GO

-- Creating primary key on [InstructorID] in table 'Instructors'
ALTER TABLE [dbo].[Instructors]
ADD CONSTRAINT [PK_Instructors]
    PRIMARY KEY CLUSTERED ([InstructorID] ASC);
GO

-- Creating primary key on [QuestionID] in table 'Questions'
ALTER TABLE [dbo].[Questions]
ADD CONSTRAINT [PK_Questions]
    PRIMARY KEY CLUSTERED ([QuestionID] ASC);
GO

-- Creating primary key on [RegistrationID], [QuizID] in table 'Quizs'
ALTER TABLE [dbo].[Quizs]
ADD CONSTRAINT [PK_Quizs]
    PRIMARY KEY CLUSTERED ([RegistrationID], [QuizID] ASC);
GO

-- Creating primary key on [RegistrationID] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([RegistrationID] ASC);
GO

-- Creating primary key on [StudentID], [Batch], [Program] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StudentID], [Batch], [Program] ASC);
GO

-- Creating primary key on [RegistrationID] in table 'CourseDatas'
ALTER TABLE [dbo].[CourseDatas]
ADD CONSTRAINT [PK_CourseDatas]
    PRIMARY KEY CLUSTERED ([RegistrationID] ASC);
GO

-- Creating primary key on [RegistrationID], [StudentID], [CourseID] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [PK_Registrations]
    PRIMARY KEY CLUSTERED ([RegistrationID], [StudentID], [CourseID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------