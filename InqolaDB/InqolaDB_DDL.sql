CREATE DATABASE InqolaYevangeli;
GO

-- Create the Branches table
CREATE TABLE Branches (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(100) NOT NULL,
    Province VARCHAR(50) NOT NULL,
    Country VARCHAR(50) NOT NULL
);

-- Create the Roles table
CREATE TABLE Roles (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(200) NOT NULL
);

-- Create the Statuses table
CREATE TABLE [Status] (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(200) NOT NULL,
    Criteria VARCHAR(200) NOT NULL
);

-- Create the Activity table
CREATE TABLE Activity (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(200) NOT NULL
);

-- Create the Employment table
CREATE TABLE EmployeeStatus(
ID int identity (1,1) primary key,
emplyment varchar(50),
discription varchar(150)
);

-- Create the Members table
CREATE TABLE Members (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    MaritalStatus bit NOT NULL,
    DateOfBirth DATE DEFAULT FORMAT(GETDATE(), 'yyyy-MM-dd')NOT NULL,
    Gender CHAR(1) NOT NULL,
    Email VARCHAR(50) UNIQUE,
    Phone VARCHAR(13),
    [Password] VARCHAR(10),
    JoinDate DATE DEFAULT FORMAT(GETDATE(), 'yyyy-MM-dd') NOT NULL,
    BranchID INT NOT NULL,
    StatusID INT NOT NULL,
    RoleID INT NOT NULL,
    EmployeeID int NOT NULL,
    FOREIGN KEY (BranchID) REFERENCES Branches(ID),
    FOREIGN KEY (StatusID) REFERENCES [Status](ID),
    FOREIGN KEY (RoleID) REFERENCES Roles(ID),
    FOREIGN KEY (EmployeeID) REFERENCES EmployeeStatus(ID)
);    

-- Create the MemberActivities table
CREATE TABLE MemberActivities (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL,
    ActivityID INT NOT NULL,
    FOREIGN KEY (MemberID) REFERENCES Members(ID),
    FOREIGN KEY (ActivityID) REFERENCES Activity(ID)
);


use InqolaYevangeli;
GO

drop table [dbo].[Branches];
drop table [dbo].[Roles];
drop table [dbo].[Status];
drop table [dbo].[Activity];
drop table [dbo].[EmployeeStatus];
drop table [dbo].[Members];
drop table [dbo].[MemberActivities];


