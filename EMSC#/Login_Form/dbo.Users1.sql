CREATE TABLE [dbo].[Users1] (
    [Id]       INT            NOT NULL,
    [username] NVARCHAR (MAX) NULL,
    [password] NVARCHAR (MAX) NULL,
    [division] NVARCHAR (MAX) NULL,
    [Emp_id]   INT            NULL,
    CONSTRAINT [PK_Users1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users1_Employee_information1] FOREIGN KEY ([Emp_id]) REFERENCES [dbo].[Employee_information1] ([Emp_id])
);

