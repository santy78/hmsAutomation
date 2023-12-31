USE [hms]
GO
/****** Object:  Table [dbo].[HMSAutomationResult]    Script Date: 16-09-2023 13:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HMSAutomationResult](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BatchId] [int] NULL,
	[ScreenName] [nvarchar](max) NULL,
	[ResponseType] [nvarchar](max) NULL,
	[Request] [nvarchar](max) NULL,
	[Response] [nvarchar](max) NULL,
	[Errors] [nvarchar](max) NULL,
	[DateTime] [nvarchar](max) NULL,
 CONSTRAINT [PK_HMSAutomationResult] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
