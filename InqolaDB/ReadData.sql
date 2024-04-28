use [InqolaYevangeli];

select * from [dbo].[Activity];
select * from [dbo].[Branches];
select * from [dbo].[MemberActivities];
select * from [dbo].[Members];
select * from [dbo].[MemberStatus];
select * from [dbo].[Roles];
select * from [dbo].[Status];



CREATE PROCEDURE [dbo].[spSelectRoles]
AS
begin
	SELECT * from [Roles]
end;

