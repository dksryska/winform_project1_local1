# Query는 Local DB로 만들었습니다.
```sql
CREATE TABLE [dbo].[CustomerTbl] (
    [CId] INT IDENTITY (1, 1) NOT NULL,
    [CName] NVARCHAR (50) NOT NULL,
    [CPhone] VARCHAR (50) NOT NULL,
    [CAdd] NVARCHAR (50) NOT NULL,
    [CStatus] NVARCHAR (50) NOT NULL,
    [CCar] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CId] ASC)
);

CREATE TABLE [dbo].[EmployeeTbl] (
    [EId]    INT           IDENTITY (1, 1) NOT NULL,
    [EName]  NVARCHAR (50) NOT NULL,
    [EPhone] VARCHAR (50)  NOT NULL,
    [EGen]   VARCHAR (50)  NOT NULL,
    [EAdd]   NVARCHAR (50) NOT NULL,
    [EPass]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EId] ASC)
);

CREATE TABLE [dbo].[InvoiceTbl] (
    [INum]      INT           IDENTITY (1, 1) NOT NULL,
    [CustName]  NVARCHAR (50) NOT NULL,
    [CustPhone] NVARCHAR (50) NOT NULL,
    [EName]     NVARCHAR (50) NOT NULL,
    [Amt]       INT           NOT NULL,
    [IDate]     DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([INum] ASC)
);

CREATE TABLE [dbo].[ServiceTbl] (
    [SId]    INT           IDENTITY (1, 1) NOT NULL,
    [SName]  NVARCHAR (50) NOT NULL,
    [SPrice] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([SId] ASC)
);

CREATE TABLE [dbo].[Table] (
    [EId]    INT          IDENTITY (1, 1) NOT NULL,
    [EName]  VARCHAR (50) NOT NULL,
    [EPhone] VARCHAR (50) NOT NULL,
    [EGen]   VARCHAR (50) NOT NULL,
    [EAdd]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([EId] ASC)
);
