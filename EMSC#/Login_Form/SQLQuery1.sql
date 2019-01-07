CREATE TABLE [dbo].[Allowance]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Emp_id] VARCHAR(50) NOT NULL, 
    [firstname] NVARCHAR(50) NULL, 
    [surname] NVARCHAR(50) NULL, 
    [Dob] NVARCHAR(50) NULL, 
    [Department] NVARCHAR(50) NULL, 
    [overtime] NVARCHAR(50) NULL, 
    [medical] NVARCHAR(50) NULL, 
    [bonus] NVARCHAR(50) NULL, 
    [other] NVARCHAR(50) NULL, 
    [created_by] VARCHAR(50) NULL, 
    [rate] NVARCHAR(50) NULL, 
    [total_allowance] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Allowance_Employee_informations] FOREIGN KEY ([Emp_id]) REFERENCES [Employee_informations]([Emp_id])
)