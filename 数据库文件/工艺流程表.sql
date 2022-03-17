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

 Date: 17/03/2022 18:17:36
*/


-- ----------------------------
-- Table structure for 工艺流程表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[工艺流程表]') AND type IN ('U'))
	DROP TABLE [dbo].[工艺流程表]
GO

CREATE TABLE [dbo].[工艺流程表] (
  [ProductId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProcessId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProcessName] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [WorkUnit] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProcessingTime] datetime  NULL,
  [ProcessingPersonnel] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [SortId] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[工艺流程表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 工艺流程表
-- ----------------------------
INSERT INTO [dbo].[工艺流程表] ([ProductId], [ProcessId], [ProcessName], [WorkUnit], [ProcessingTime], [ProcessingPersonnel], [SortId]) VALUES (N'1', N'YKQ1', N'焊接', N'1车间', N'2022-03-07 16:15:16.000', NULL, N'1')
GO

INSERT INTO [dbo].[工艺流程表] ([ProductId], [ProcessId], [ProcessName], [WorkUnit], [ProcessingTime], [ProcessingPersonnel], [SortId]) VALUES (N'2', N'BPQ1', N'喷漆1', N'', N'2022-03-16 20:49:11.000', NULL, N'1')
GO

INSERT INTO [dbo].[工艺流程表] ([ProductId], [ProcessId], [ProcessName], [WorkUnit], [ProcessingTime], [ProcessingPersonnel], [SortId]) VALUES (N'2', N'BPQ2', N'喷漆2', N'', N'2022-03-16 20:49:46.000', NULL, N'2')
GO

INSERT INTO [dbo].[工艺流程表] ([ProductId], [ProcessId], [ProcessName], [WorkUnit], [ProcessingTime], [ProcessingPersonnel], [SortId]) VALUES (N'1', N'YKQ2', N'焊接2', NULL, NULL, NULL, N'2')
GO

