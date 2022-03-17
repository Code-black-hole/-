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

 Date: 17/03/2022 18:17:51
*/


-- ----------------------------
-- Table structure for 生产计划表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[生产计划表]') AND type IN ('U'))
	DROP TABLE [dbo].[生产计划表]
GO

CREATE TABLE [dbo].[生产计划表] (
  [Id] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Date] datetime  NULL,
  [Product] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Quantity] int  NULL
)
GO

ALTER TABLE [dbo].[生产计划表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 生产计划表
-- ----------------------------
