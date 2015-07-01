CREATE PROCEDURE GetRowsCount
AS
BEGIN
	select count(StudentId) from Registration
END
