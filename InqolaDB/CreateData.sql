use [InqolaYevangeli];
go

INSERT INTO Roles ([Name], [Description])
VALUES
    ('Admin', 'System administrator with full access'),
    ('Branch Manager', 'Manages a specific branch'),
    ('Member', 'Regular church member');

INSERT INTO Branches ([Name], Province, Country)
VALUES
    ('Johannesburg Central', 'Gauteng', 'South Africa'),
    ('Cape Town', 'Western Cape', 'South Africa'),
    ('Durban', 'KwaZulu-Natal', 'South Africa'),
    ('Pretoria', 'Gauteng', 'South Africa'),
    ('Bloemfontein', 'Free State', 'South Africa'),
    ('Lusaka', 'Lusaka', 'Zambia'),
    ('Nairobi', 'Nairobi', 'Kenya'),
    ('Gaborone', 'Gaborone', 'Botswana'),
    ('Harare', 'Harare', 'Zimbabwe'),
    ('Windhoek', 'Khomas', 'Namibia');

INSERT INTO [Status] ([Name], [Description], Criteria)
VALUES
    ('Sealed', 'Members who have been officially sealed as part of the church', 'Completed required courses and ceremonies'),
    ('Welcomed', 'New members who have been welcomed into the church', 'Attended introduction sessions'),
    ('Testifier', 'Members who have given their testimony', 'Shared their personal story and experience'),
    ('Baptized', 'Members who have been baptized', 'Completed baptism ceremony'),
    ('Waiting for Sealing', 'Members in the process of being sealed', 'Currently attending required courses'),
    ('Inactive', 'Members who have not been active recently', 'No participation for a specified period'),
    ('Lapsed', 'Members who have left the church', 'Officially withdrawn or removed from membership'),
    ('Suspended', 'Members temporarily suspended from participation', 'Disciplinary action taken'),
    ('Probationary', 'New members on a probationary period', 'Initial evaluation period before full membership'),
    ('Transferring', 'Members in the process of transferring to another branch', 'Requested a branch transfer');

INSERT INTO Activity ([Name], [Description])
VALUES
    ('Sunday Service', 'Attendance at the weekly Sunday service'),
    ('Bible Study', 'Participation in a Bible study group'),
    ('Prayer Meeting', 'Attendance at a prayer meeting'),
    ('Outreach Event', 'Involvement in community outreach activities'),
    ('Youth Program', 'Participation in youth-specific programs and events'),
    ('Choir Practice', 'Attendance at choir practice sessions'),
    ('Volunteer Work', 'Volunteering for church-related tasks or events'),
    ('Retreat', 'Attendance at a spiritual retreat'),
    ('Baptism', 'Participation in a baptism ceremony'),
    ('Sealing Ceremony', 'Participation in a sealing ceremony');

INSERT INTO Members (FirstName, LastName, DateOfBirth, Gender, JoinDate, BranchID, StatusID, RoleID)
VALUES
    ('John', 'Doe', '1985-05-15', 'M', '2020-03-01', 1, 1, 3), -- Johannesburg Central, Sealed, Member
    ('Jane', 'Smith', '1992-11-22', 'F', '2022-09-10', 2, 2, 3), -- Cape Town, Welcomed, Member
    ('Michael', 'Johnson', '1978-07-03', 'M', '2018-02-28', 3, 3, 3), -- Durban, Testifier, Member
    ('Emily', 'Williams', '2000-12-18', 'F', '2021-06-15', 4, 4, 3), -- Pretoria, Baptized, Member
    ('David', 'Brown', '1989-03-25', 'M', '2019-10-01', 5, 5, 3), -- Bloemfontein, Waiting for Sealing, Member
    ('Sarah', 'Jones', '1965-08-12', 'F', '2015-05-20', 1, 1, 3), -- Johannesburg Central, Sealed, Member
    ('Robert', 'Garcia', '1975-01-30', 'M', '2017-11-01', 6, 3, 2), -- Lusaka, Testifier, Branch Manager
    ('Amanda', 'Miller', '1998-06-08', 'F', '2023-01-05', 7, 2, 3), -- Nairobi, Welcomed, Member
    ('Xoli', 'Zulu', '1995-05-15', 'F', '2020-03-01', 1, 1, 3), -- Durban Central, Sealed, Member
    ('Spe', 'Xulu', '1999-11-22', 'M', '2022-09-10', 2, 2, 3), -- Cape Town, Welcomed, Member
    ('Christopher', 'Davis', '1982-09-20', 'M', '2016-04-10', 8, 3, 2), -- Gaborone, Testifier, Branch Manager
    ('Olivia', 'Rodriguez', '1994-03-03', 'F', '2019-07-15', 9, 5, 3); -- Harare, Waiting for Sealing, Member

INSERT INTO MemberAgeGroups (MemberID, AgeGroupID, StartDate, EndDate)
VALUES
    (1, 3, '2020-03-01', NULL), -- John Doe, Adult
    (2, 3, '2022-09-10', NULL), -- Jane Smith, Adult
    (3, 3, '2018-02-28', NULL), -- Michael Johnson, Adult
    (4, 1, '2021-06-15', NULL), -- Emily Williams, Youth
    (5, 3, '2019-10-01', NULL), -- David Brown, Adult
    (6, 4, '2015-05-20', NULL), -- Sarah Jones, Senior
    (7, 3, '2017-11-01', NULL), -- Robert Garcia, Adult
    (8, 1, '2023-01-05', NULL), -- Amanda Miller, Youth
    (9, 3, '2016-04-10', NULL), -- Christopher Davis, Adult
    (10, 3, '2019-07-15', NULL), -- Olivia Rodriguez, Adult
    (11, 2, '2017-09-01', '2021-08-31'), -- New member, Sunday School (historical record)
    (12, 2, '2021-09-01', NULL); -- New member, Sunday School (current)

INSERT INTO MemberActivities (MemberID, ActivityID)
VALUES
    (1, 1), -- John Doe, Sunday Service
    (1, 2), -- John Doe, Bible Study
    (2, 1), -- Jane Smith, Sunday Service
    (3, 1), -- Michael Johnson, Sunday Service
    (3, 3), -- Michael Johnson, Prayer Meeting
    (4, 1), -- Emily Williams, Sunday Service
    (4, 4), -- Emily Williams, Outreach Event
    (5, 1), -- David Brown, Sunday Service
    (5, 5), -- David Brown, Youth Program
    (6, 1); -- Sarah Jones, Sunday Service


    CREATE PROCEDURE [dbo].[spInsetRole]
	@Name varchar(200),
	@Description varchar(200)
AS
BEGIN
	INSERT INTO ROLES VALUES (@Name, @Description)
END;
