/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ScheduleID]
      ,[ReportID]
      ,[SubscriptionID]
      ,[ReportAction]
  FROM [ReportingService_test2DB].[dbo].[ReportSchedule]