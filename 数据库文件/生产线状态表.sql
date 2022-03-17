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

 Date: 17/03/2022 18:18:02
*/


-- ----------------------------
-- Table structure for 生产线状态表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[生产线状态表]') AND type IN ('U'))
	DROP TABLE [dbo].[生产线状态表]
GO

CREATE TABLE [dbo].[生产线状态表] (
  [ProductionLineId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [State] varchar(10) COLLATE Chinese_PRC_CI_AS  NULL,
  [OperationDate] datetime  NULL,
  [Operator] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[生产线状态表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 生产线状态表
-- ----------------------------
INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'开启', N'2022-03-16 20:00:50.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'关闭', N'2022-03-16 20:03:47.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'开启', N'2022-03-16 20:12:28.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'关闭', N'2022-03-17 14:41:32.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'关闭', N'2022-03-17 15:58:41.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'开启', N'2022-03-17 14:41:37.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'关闭', N'2022-03-17 14:51:49.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'开启', N'2022-03-17 15:52:10.000', N'李四')
GO

INSERT INTO [dbo].[生产线状态表] ([ProductionLineId], [State], [OperationDate], [Operator]) VALUES (N'BPQ001', N'开启', N'2022-03-17 15:58:54.000', N'李四')
GO

