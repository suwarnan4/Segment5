CREATE PROCEDURE InsertRegistration
	@StudentId char(10),
	@Name varchar(50),
	@DOB datetime,
	@GradePointAvg decimal(18, 2),
	@Active bit
AS
BEGIN
	insert into Registration values (@StudentId, @Name, @DOB, @GradePointAvg, @Active)
END
