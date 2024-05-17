------- LOGIN AND SHOW MEMBERS DATA.
-----*** DETAILS

SELECT m.[FirstName], m.[LastName],
       CASE 
           WHEN m.[MaritalStatus] = 1 THEN 'YES'
           ELSE 'NO'
       END AS MaritalStatus,
       m.[DateOfBirth], m.[Gender], m.[Email], m.[Phone], m.[Password], m.[JoinDate],
       b.[Name], b.[Province],
       r.[Name],
       s.[Name],
       e.[emplyment]
FROM members AS m
INNER JOIN branches AS b ON m.branchid = b.id
INNER JOIN roles AS r ON m.roleid = r.id
INNER JOIN [status] AS s ON m.statusid = s.id
INNER JOIN employeestatus AS e ON m.employeeid = e.id
where [Email] = 'john.doe@example.com' and [Password] = 'password1';
-----*** ACTIVITIES
SELECT m.[FirstName], m.[LastName], m.[Gender], m.[Phone],
       a.[Name]
FROM members AS m
INNER JOIN [dbo].[MemberActivities] AS ma ON m.id = ma.memberid
INNER JOIN activity AS a ON ma.activityid = a.id
WHERE m.[Email] = 'emily.williams@example.com';
------------------------------------------------------------------------------------
------- REGISTER

insert into [dbo].[Members] ([FirstName], [LastName], [MaritalStatus],
                             [DateOfBirth], [Gender], [Email],
                             [Phone], [Password], [JoinDate],
                             [BranchID], [StatusID], [RoleID], [EmployeeID])
values ('Zakwe', 'Zungu', 
        (SELECT CASE 
            WHEN 'NO' = 'YES' THEN 1
        ELSE 0
            END AS MaritalStatus), 
        '01/01/1999', 
        (SELECT CASE 
            WHEN 'Female' = 'Male' THEN 'M'
        ELSE 'F'
            END AS MaritalStatus), 
        'zz@gmail.com', '0735484123', '123456', '01/01/1999', 
        (select id from [dbo].[Branches] where [name] = 'Durban'), 
        (select id from [dbo].[Status] where [name] = 'Inactive'),
        (select id from [dbo].[Roles] where [name] = 'Regular User'),
        (select id from [dbo].[EmployeeStatus] where [emplyment] = 'Employed'));

------- VIEW ALL MEMBERS USING A VIEW

select * from [dbo].[MemberDetails];

------- VIEW ALL BRANCHES USING A VIEW

select * from [dbo].[BranchesDetails];

------- VIEW ALL MEMBERS ACTIVITES USING A VIEW

select * from [dbo].[MembersActivtiesDetails];

------- VIEW ACTIVITIES USING A VIEW

select * from allactivities;
  
------- UPDATE MEMBER

UPDATE [dbo].[Members]
SET [LastName] = '',
    [MaritalStatus] = '',
    [Phone] = '',
    [Password] = 'M',
    [BranchID] = 1,
    [StatusID] = 1,
    [RoleID] = 1,
    [EmployeeID] = 1 
WHERE [Email] = 'michael.johnson@example.com'; 

------- REMOVE MEMBER ACTIVITY

------- REMOVE BRANCE

------- UPDATE PASSWORD FORGOT PASSWORD
UPDATE [dbo].[Members]
SET 
    [Email] = (select email from memberdetails where email = 'john.doe@example.com'),
    [Password] = 'M'
WHERE [Email] = 'michael.johnson@example.com'; 

------- TRANSFER MEMBER UPDATE MEMBER BRANCH

UPDATE [dbo].[Members]
SET [BranchID] = 1
WHERE [Email] = 'michael.johnson@example.com'; 

-------

-------
-------

