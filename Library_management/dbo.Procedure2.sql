CREATE PROCEDURE [dbo].[Login_details_proc1]
(
	@Uname varchar(50),
	@Pword varchar(50)
)
AS
	SELECT * from Login_details1 where uname=@Uname and pword = @Pword
RETURN 0
