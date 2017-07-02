# CustomerWebApp

Database Setup:

> Create CustomerDB database in your sql server instance.

> Run the following sql statement to create the table:
CREATE TABLE [Customer](
      [CustomerID] [int] IDENTITY(1,1) NOT NULL,
      [FirstName] [nvarchar](50) NOT NULL,
      [Lastname] [nvarchar](50) NOT NULL,
      [Address1] [nvarchar](50) NOT NULL,
      [Address2] [nvarchar](50) NOT NULL,
      [Town] [nvarchar](50) NOT NULL,
      [County] [nvarchar](50) NOT NULL,
      [Postcode] [nvarchar](50) NOT NULL,
      [Age] [int] NOT NULL,
      [EmailAddress] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED
(
      [CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
 
GO

> Edit Web.Config in the provided sample to replace with your own values in line
    data source=nwb-dushyantp\sqlexpress;initial catalog=CustomerDB;

To run the web app:

> Build from a Visual Studio command prompt by running the script at root level:

    buildall.bat

> Open .sln file in Visual Studio 2017
> Ctrl+F5
> Click Customers link on home page.

To run tests:
> Open Solution in Visual Studio
> Open Test Explorer from Test menu.
> Click Run All Tests in Test Explorer windoow. It will run all the 6561 unit test cases.