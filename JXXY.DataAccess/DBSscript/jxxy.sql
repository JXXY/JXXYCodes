USE [jxxy]
GO
/****** Object:  Table [dbo].[TestStudent]    Script Date: 02/06/2016 10:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestStudent]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TestStudent](
	[Id] [varchar](50) NOT NULL,
	[StudentId] [varchar](50) NOT NULL,
	[TestId] [varchar](50) NOT NULL,
	[Result] [int] NOT NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDate] [date] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDate] [date] NULL,
 CONSTRAINT [PK_TestStudent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Test]    Script Date: 02/06/2016 10:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Test]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Test](
	[Id] [varchar](50) NOT NULL,
	[Subject] [varchar](50) NOT NULL,
	[TDate] [date] NOT NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatdDate] [date] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDate] [date] NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 02/06/2016 10:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Teacher](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[MobileNumber] [varchar](8) NULL,
	[LoginName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDate] [date] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDate] [date] NULL,
	[SchoolId] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 02/06/2016 10:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Student](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IDCard] [varchar](20) NOT NULL,
	[MobileNumber] [varchar](8) NOT NULL,
	[WeiXinCode] [varchar](50) NULL,
	[Status] [int] NOT NULL,
	[Image] [varbinary](max) NULL,
	[Sex] [int] NOT NULL,
	[SchoolId] [varchar](50) NOT NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDate] [date] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDate] [date] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[School]    Script Date: 02/06/2016 10:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[School]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[School](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](500) NOT NULL,
	[Address] [varchar](500) NULL,
	[Remark] [varchar](500) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_School] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
