USE [hms]
GO
/****** Object:  StoredProcedure [dbo].[GETBatchId]    Script Date: 16-09-2023 13:36:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GETBatchId]
AS 
select top 1 BatchId from HMSAutomationResult order by Id Desc
GO
