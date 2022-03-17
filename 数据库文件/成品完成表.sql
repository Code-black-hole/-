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

 Date: 17/03/2022 18:17:14
*/


-- ----------------------------
-- Table structure for 成品完成表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[成品完成表]') AND type IN ('U'))
	DROP TABLE [dbo].[成品完成表]
GO

CREATE TABLE [dbo].[成品完成表] (
  [ProductId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProductName] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [FinishedProductID] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Date] datetime  NULL
)
GO

ALTER TABLE [dbo].[成品完成表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 成品完成表
-- ----------------------------
