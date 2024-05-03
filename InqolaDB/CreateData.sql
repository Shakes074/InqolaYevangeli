use [InqolaYevangeli];
go

INSERT INTO Roles ([Name], [Description])
VALUES
    ('Super Admin', 'System administrator with full access'),
    ('Branch Manager', 'Manages a specific branch'),
    ('Regular User', 'Regular church member');

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

INSERT INTO YourTableName 
(FirstName, LastName, MaritalStatus, 
DateOfBirth, Gender, Email, 
Phone, [Password], JoinDate, 
BranchID, StatusID, RoleID)

VALUES

    ('John', 'Doe', 1, '1990-05-15', 'M', 'john.doe@example.com', '555-1234', 'password1', '2022-01-01', 5, 4, 3),
    ('Jane', 'Smith', 0, '2000-11-22', 'F', 'jane.smith@example.com', '555-5678', 'password2', '2021-06-15', 3, 2, 3),
    ('Michael', 'Johnson', 1, '2010-03-10', 'M', 'michael.johnson@example.com', '555-9012', 'password3', '2020-09-01', 3, 3, 3),
    ('Emily', 'Williams', 0, '1995-07-18', 'F', 'emily.williams@example.com', '555-3456', 'password4', '2023-02-28', 2, 4, 2),
    ('David', 'Brown', 1, '2006-12-05', 'M', 'david.brown@example.com', '555-7890', 'password5', '2022-07-10', 2, 4, 1),
    ('Sarah', 'Davis', 0, '1991-09-30', 'F', 'sarah.davis@example.com', '555-2345', 'password6', '2021-03-20', 8, 3, 2),
    ('Robert', 'Wilson', 1, '2019-06-12', 'M', 'robert.wilson@example.com', '555-6789', 'password7', '2019-11-05', 3, 5, 3),
    ('Jessica', 'Anderson', 0, '1988-02-28', 'F', 'jessica.anderson@example.com', '555-0123', 'password8', '2022-09-15', 3, 1, 3),
    ('Daniel', 'Taylor', 1, '1980-08-20', 'M', 'daniel.taylor@example.com', '555-4567', 'password9', '2021-12-01', 5, 3, 2),
    ('Olivia', 'Thomas', 0, '2021-04-03', 'F', 'olivia.thomas@example.com', '555-8901', 'password0', '2023-04-01', 1, 2, 3);

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

INSERT INTO EmployeeStatus (emplyment, discription)
VALUES
    ('Student', 'Currently enrolled as a student in an educational institution'),
    ('Unemployed', 'Not currently employed or seeking employment'),
    ('Employed', 'Currently employed and working for an organization');




/**
INSERT INTO MemberStatus (MemberID, StatusID, JoiningDate)
VALUES
    (1, 1, '2022-01-15'),
    (5, 2, '2021-06-22'),
    (3, 5, '2023-03-01'),
    (8, 2, '2020-09-12'),
    (1, 5, '2022-11-05');
**/
    
--------------------------
    
  