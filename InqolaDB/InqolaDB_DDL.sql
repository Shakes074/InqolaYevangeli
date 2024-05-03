﻿CREATE DATABASE InqolaYevangeli;
GO

USE InqolaYevangeli;
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

-- Create the Types table
CREATE TABLE Activity (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL,
    [Description] VARCHAR(200) NOT NULL
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
    EmplymentStatusID int NOT NULL,
    FOREIGN KEY (BranchID) REFERENCES Branches(ID),
    FOREIGN KEY (StatusID) REFERENCES [Status](ID),
    FOREIGN KEY (RoleID) REFERENCES Roles(ID),
    FOREIGN KEY (EmplymentStatusID) REFERENCES EmploymentStatus(ID)
);    

-- Create the MemberActivities table
CREATE TABLE MemberActivities (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MemberID INT NOT NULL,
    ActivityID INT NOT NULL,
    FOREIGN KEY (MemberID) REFERENCES Members(ID),
    FOREIGN KEY (ActivityID) REFERENCES Activity(ID)
);

CREATE TABLE EmployeeStatus(
ID int identity (1,1) primary key,
emplyment varchar(50),
discription varchar(150)
);





--CREATE TABLE MemberStatus (
    --ID INT IDENTITY(1,1) PRIMARY KEY,
    --MemberID INT NOT NULL,
    --StatusID INT NOT NULL,
    --JoiningDate DATE DEFAULT FORMAT(GETDATE(), 'yyyy-MM-dd')NOT NULL,
    --FOREIGN KEY (MemberID) REFERENCES Members(ID),
    --FOREIGN KEY (StatusID) REFERENCES [Status](ID)
--);

