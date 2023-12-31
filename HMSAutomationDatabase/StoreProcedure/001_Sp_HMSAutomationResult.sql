USE [hms]
GO
/****** Object:  StoredProcedure [dbo].[Sp_HMSAutomationResult]    Script Date: 16-09-2023 13:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_HMSAutomationResult]
           		   @AutomationResult varchar(max)
		   AS

		  
INSERT INTO HMSAutomationResult(
     [BatchId],
    [ScreenName],
 [ResponseType],
[Request],
    [Response],
    [Errors] ,
    [DateTime]
  	)

SELECT *
FROM OPENJSON (@AutomationResult)
WITH
(
            [BatchId] int
            ,[ScreenName] varchar(max)
           ,[ResponseType]varchar(max)
           ,[Request]varchar(max)
           ,[Response]varchar(max)
           ,[Errors]varchar(max)
           ,[DateTime] varchar(max)
)

GO
