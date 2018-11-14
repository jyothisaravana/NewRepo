CREATE PROCEDURE [dbo].[Login_details_proc]
(
	@Uname varchar(50),
	@Pword varchar(50),
	@Email varchar(20)
)
AS
	insert into Login_details1 values(@Uname,@Pword,@Email)
