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

 Date: 17/03/2022 18:17:44
*/


-- ----------------------------
-- Table structure for 人员信息表
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[人员信息表]') AND type IN ('U'))
	DROP TABLE [dbo].[人员信息表]
GO

CREATE TABLE [dbo].[人员信息表] (
  [JobId] varchar(30) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Name] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Identity] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [Password] varchar(30) COLLATE Chinese_PRC_CI_AS  NULL,
  [State] int  NULL
)
GO

ALTER TABLE [dbo].[人员信息表] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of 人员信息表
-- ----------------------------
INSERT INTO [dbo].[人员信息表] ([JobId], [Name], [Identity], [Password], [State]) VALUES (N'1                             ', N'张三                          ', N'工人                          ', N'1                             ', N'1')
GO

INSERT INTO [dbo].[人员信息表] ([JobId], [Name], [Identity], [Password], [State]) VALUES (N'2                             ', N'李四                          ', N'管理员                        ', N'2                             ', N'1')
GO

