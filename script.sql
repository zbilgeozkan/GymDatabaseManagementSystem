USE [gym]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 27.05.2023 16:33:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[EID] [int] IDENTITY(1,1) NOT NULL,
	[EquipName] [varchar](250) NOT NULL,
	[EDescription] [varchar](450) NOT NULL,
	[MUsed] [varchar](250) NOT NULL,
	[DDate] [varchar](150) NOT NULL,
	[Cost] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewMember]    Script Date: 27.05.2023 16:33:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewMember](
	[MID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](150) NOT NULL,
	[Lname] [varchar](150) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[Dob] [varchar](100) NOT NULL,
	[Mobile] [bigint] NOT NULL,
	[Email] [varchar](150) NULL,
	[JoinDate] [varchar](100) NOT NULL,
	[Gymtime] [varchar](120) NOT NULL,
	[Maddress] [varchar](250) NOT NULL,
	[MembershipTime] [varchar](120) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewStaff]    Script Date: 27.05.2023 16:33:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewStaff](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](150) NOT NULL,
	[Lname] [varchar](150) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
	[Dob] [varchar](100) NOT NULL,
	[Mobile] [bigint] NOT NULL,
	[Email] [varchar](150) NULL,
	[JoinDate] [varchar](100) NOT NULL,
	[Statee] [varchar](100) NOT NULL,
	[City] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
