CREATE TABLE [dbo].[Teacher] (
    [Id]     INT           NOT NULL IDENTITY,
    [name]   NVARCHAR (50) NOT NULL,
    [N_code] NVARCHAR (10) NOT NULL,
    [Mobile] NVARCHAR (11) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Student] (
    [Id]           INT           NOT NULL IDENTITY,
    [name]         NVARCHAR (50) NOT NULL,
    [Student_code] NVARCHAR (10) NOT NULL,
    [mobile]       NVARCHAR (11) NOT NULL,
    [N_code]       NVARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);