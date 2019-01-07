CREATE TABLE [dbo].[Deduction] (
    [Id]              INT           NOT NULL,
    [Emp_id]          VARCHAR (50)  NOT NULL,
    [firstname]       NVARCHAR (50) NULL,
    [surname]         NVARCHAR (50) NULL,
    [Deduction_amount]        NVARCHAR (50) NULL,
    [Reason]         NVARCHAR (50) NULL,
    [Made_by]           NVARCHAR (50) NULL,
    [salary]          NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Deduction_Employee_informations] FOREIGN KEY ([Emp_id]) REFERENCES [dbo].[Employee_informations] ([Emp_id])
);

