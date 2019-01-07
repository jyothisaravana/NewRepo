CREATE TABLE [dbo].[Employee_information] (
    [Emp_id]      INT NOT NULL IDENTITY,
    [first_name]  NVARCHAR (50)  NULL,
    [surname]     NVARCHAR (50)  NULL,
    [Dob]         NVARCHAR (50)  NULL,
    [Email]       NVARCHAR (50)  NULL,
    [Telephone]   NVARCHAR (50)  NULL,
    [Address1]    NVARCHAR (MAX) NULL,
    [Address2]    NVARCHAR (MAX) NULL,
    [Department]  NVARCHAR (50)  NULL,
    [Image]       IMAGE          NULL,
    [Gender]      NCHAR (10)     NULL,
    [Salary]      NVARCHAR (50)  NULL,
    [Designation] NVARCHAR (50)  NULL,
    [Status]      NVARCHAR (50)  NULL,
    [Date_hired]  NVARCHAR (MAX) NULL,
    [Job_title]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Emp_id] ASC)
);

