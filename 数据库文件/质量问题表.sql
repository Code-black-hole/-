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

 Date: 17/03/2022 18:18:07
*/


-- ----------------------------
-- Table structure for 质量问题表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[质量问题表]') AND type IN ('U'))
	DROP TABLE [dbo].[质量问题表]
GO

CREATE TABLE [dbo].[质量问题表] (
  [Id] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProductId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProcessId] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Problem] varchar(300) COLLATE Chinese_PRC_CI_AS  NULL,
  [JobId] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Date] datetime  NULL,
  [Annex] varchar(100) COLLATE Chinese_PRC_CI_AS  NULL,
  [SolveDate] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Memo] varchar(100) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[质量问题表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 质量问题表
-- ----------------------------
INSERT INTO [dbo].[质量问题表] ([Id], [ProductId], [ProcessId], [Problem], [JobId], [Date], [Annex], [SolveDate], [Memo]) VALUES (N'2', N'1', N'3', N'喷漆错误', N'2', N'2022-03-13 10:53:31.000', N'无', N'', N'、')
GO

