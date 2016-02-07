DECLARE @schoolNum INT
SET @schoolNum = 0
SELECT @schoolNum = COUNT(School.Id) FROM School
IF @schoolNum = 0
BEGIN
	INSERT INTO dbo.School(Id,Name,[Address],Remark,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)VALUES('43370629-1F20-415B-A7B3-03B0F004A43C','SYSTEM','SYSTEM','SYSTEM','system',getdate(),'system',getdate())
END

DECLARE @teacherNum INT
SET @teacherNum = 0
SELECT @teacherNum = COUNT(Teacher.Id)FROM Teacher
IF @teacherNum = 0 
BEGIN
 INSERT INTO Teacher(Id,Name,MobileNumber,LoginName,[Password],CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,SchoolId)values('BE2C01D8-B259-4653-8F30-3449FFD09D70','System','0000000','admin','3INSq0tQVzIbQqEqH7d+r2UbCeJchs9gIeEcqB6tZ34=','system',getdate(),'system',getdate(),'43370629-1F20-415B-A7B3-03B0F004A43C')
END