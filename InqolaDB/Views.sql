USE [InqolaYevangeli]
GO

-- Viewing members details 
CREATE VIEW MemberDetails AS
SELECT 
    m.[FirstName], m.[LastName], m.[DateOfBirth], m.[Gender], m.[Email], m.[Phone], m.[Password], m.[JoinDate], 
    b.[Name] AS BranchName, b.[Province], b.[Country],
    s.[Name] AS StatusName,
    r.[Name] AS RoleName,
    e.[emplyment]
FROM 
    [dbo].[Members] AS m JOIN
    [dbo].[Branches] AS b ON m.BranchID = b.ID JOIN
    [dbo].[Status] AS s ON m.StatusID = s.ID JOIN
    [dbo].[Roles] AS r ON m.RoleID = r.ID JOIN
    [dbo].[EmployeeStatus] AS e ON m.[EmployeeID] = e.ID;

-- Viewing branches details
CREATE VIEW BranchesDetails AS
SELECT 
    b.[Name] AS BranchName, b.[Province], b.[Country], 
    COUNT(m.BranchID) AS NumberOfMembers
FROM 
    [dbo].[Branches] AS b 
LEFT JOIN
    [dbo].[Members] AS m ON b.ID = m.BranchID
GROUP BY 
    b.[Name], b.[Province], b.[Country];

-- Viewing Activities details
Create view ActivtiesDetails as
SELECT 
    a.Name as ActivityName, 
    m.[FirstName] as FirstName, m.LastName, m.Phone, m.Email, 
    s.[Name], 
    e.[emplyment], 
    b.[Name] as BranchName, b.Province
FROM 
    [dbo].[MemberActivities] AS ma
JOIN 
    [dbo].[Activity] AS a ON ma.ActivityID = a.ID
JOIN 
    [dbo].[Members] AS m ON ma.MemberID = m.ID
JOIN 
    [dbo].[Status] AS s ON m.StatusID = s.ID
JOIN 
    [dbo].[EmployeeStatus] AS e ON m.[EmployeeID] = e.ID
JOIN 
    [dbo].[Branches] AS b ON m.BranchID = b.ID;


