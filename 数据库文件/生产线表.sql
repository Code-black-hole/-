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

 Date: 17/03/2022 18:17:57
*/


-- ----------------------------
-- Table structure for 生产线表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[生产线表]') AND type IN ('U'))
	DROP TABLE [dbo].[生产线表]
GO

CREATE TABLE [dbo].[生产线表] (
  [ProductionLineId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProductionLineName] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProductionWorkshop] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProductId] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProductName] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Time] datetime  NULL,
  [State] varchar(10) COLLATE Chinese_PRC_CI_AS  NULL,
  [Memo] varchar(50) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[生产线表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 生产线表
-- ----------------------------
INSERT INTO [dbo].[生产线表] ([ProductionLineId], [ProductionLineName], [ProductionWorkshop], [ProductId], [ProductName], [Time], [State], [Memo]) VALUES (N'BPQ001', N'变频器', N'', N'2', N'001变频器', N'2022-03-17 15:59:05.000', N'开启', N'')
GO

