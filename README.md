# Query문 VS의 Local DB를 사용하였습니다.
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
```

# 세차장 관리 프로그램
winform을 이용해서 직원 계정과 고객을 관리하는 세차장 관리 프로그램입니다.

# 실행 방법
1."관리자"로 로그인을 합니다. <br/>
   비밀번호는 Password 입니다. <br/>
2."직원 계정 생성"페이지에서 계정을 생성합니다. <br/>
   "직원 로그인"을 할때 사용하게 됩니다. <br/>
3."고객관리" 페이지에서는 고객의 개인정보를 입력하고. 서비스 상태를 입력합니다. <br/>
4."서비스" 페이지에서 서비스 이름과 가격을 저장을 합니다.

