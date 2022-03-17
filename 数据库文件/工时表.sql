/*
 Navicat Premium Data Transfer

 Source Server         : .
 Source Server Type    : SQL Server
 Source Server Version : 15002080
 Source Catalog        : 中铁生产线人员信息
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002080
 File Encoding         : 65001

 Date: 17/03/2022 18:17:27
*/


-- ----------------------------
-- Table structure for 工时表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[工时表]') AND type IN ('U'))
	DROP TABLE [dbo].[工时表]
GO

CREATE TABLE [dbo].[工时表] (
  [JobId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Name] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Date] datetime  NULL,
  [Operation] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProductionLineId] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProcessId] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [SpeedOfProgress] int  NULL
)
GO

ALTER TABLE [dbo].[工时表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 工时表
-- ----------------------------
INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:39:38.000', N'开始', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:39:45.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:39:46.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:42:58.000', N'开始', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:43:05.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:43:07.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:43:49.000', N'开始', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:43:53.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:37.000', N'开始', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:40.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:42.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:44.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:45.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:48.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:50.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:53.000', N'继续', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 16:17:45.000', N'开始', N'001型遥控器生产线', N'喷漆3', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 16:18:23.000', N'开始', N'001型遥控器生产线', N'喷漆1', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-16 15:38:13.000', N'开始', N'001型遥控器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-16 15:40:45.000', N'开始', N'001型变频器生产线', N'喷漆1', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-16 15:40:51.000', N'暂停', N'001型变频器生产线', N'喷漆1', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:43:10.000', N'开始', N'001型变频器生产线', N'焊接', N'1')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-10 19:43:52.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:46.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:51.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-16 15:41:05.000', N'继续', N'001型变频器生产线', N'喷漆1', N'0')
GO

INSERT INTO [dbo].[工时表] ([JobId], [Name], [Date], [Operation], [ProductionLineId], [ProcessId], [SpeedOfProgress]) VALUES (N'1', N'张三', N'2022-03-13 09:55:49.000', N'暂停', N'001型变频器生产线', N'焊接', N'0')
GO

