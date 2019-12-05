/*
 Navicat Premium Data Transfer

 Source Server         : Microsoft SQL Server - @localhost
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : localhost:1433
 Source Catalog        : winform_demo
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 06/12/2019 00:32:54
*/


-- ----------------------------
-- Table structure for category
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type IN ('U'))
	DROP TABLE [dbo].[category]
GO

CREATE TABLE [dbo].[category] (
  [id] bigint  IDENTITY(1,1) NOT NULL,
  [category_name] varchar(32) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [is_leaf] tinyint  NULL,
  [parent_id] bigint  NULL
)
GO

ALTER TABLE [dbo].[category] SET (LOCK_ESCALATION = AUTO)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'category',
'COLUMN', N'id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'分类名称',
'SCHEMA', N'dbo',
'TABLE', N'category',
'COLUMN', N'category_name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否叶子节点',
'SCHEMA', N'dbo',
'TABLE', N'category',
'COLUMN', N'is_leaf'
GO

EXEC sp_addextendedproperty
'MS_Description', N'父节点Id',
'SCHEMA', N'dbo',
'TABLE', N'category',
'COLUMN', N'parent_id'
GO


-- ----------------------------
-- Records of category
-- ----------------------------
SET IDENTITY_INSERT [dbo].[category] ON
GO

INSERT INTO [dbo].[category] ([id], [category_name], [is_leaf], [parent_id]) VALUES (N'1', N'哈哈', N'1', NULL)
GO

INSERT INTO [dbo].[category] ([id], [category_name], [is_leaf], [parent_id]) VALUES (N'2', N'汽车', N'1', NULL)
GO

SET IDENTITY_INSERT [dbo].[category] OFF
GO


-- ----------------------------
-- Table structure for Student
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type IN ('U'))
	DROP TABLE [dbo].[Student]
GO

CREATE TABLE [dbo].[Student] (
  [Id] bigint  IDENTITY(1,1) NOT NULL,
  [Name] varchar(32) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Sex] int  NOT NULL,
  [Phone] varchar(32) COLLATE Chinese_PRC_CI_AS  NULL,
  [NativePlace] varchar(225) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Student] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Student',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'姓名',
'SCHEMA', N'dbo',
'TABLE', N'Student',
'COLUMN', N'Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'性别',
'SCHEMA', N'dbo',
'TABLE', N'Student',
'COLUMN', N'Sex'
GO

EXEC sp_addextendedproperty
'MS_Description', N'手机',
'SCHEMA', N'dbo',
'TABLE', N'Student',
'COLUMN', N'Phone'
GO

EXEC sp_addextendedproperty
'MS_Description', N'籍贯',
'SCHEMA', N'dbo',
'TABLE', N'Student',
'COLUMN', N'NativePlace'
GO


-- ----------------------------
-- Records of Student
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student] ON
GO

INSERT INTO [dbo].[Student] ([Id], [Name], [Sex], [Phone], [NativePlace]) VALUES (N'1', N'张三', N'0', N'15012312345', N'浙江德清')
GO

INSERT INTO [dbo].[Student] ([Id], [Name], [Sex], [Phone], [NativePlace]) VALUES (N'2', N'李四', N'0', N'13032165452', N'浙江杭州')
GO

INSERT INTO [dbo].[Student] ([Id], [Name], [Sex], [Phone], [NativePlace]) VALUES (N'3', N'王五', N'1', N'17796385256', N'浙江德清')
GO

INSERT INTO [dbo].[Student] ([Id], [Name], [Sex], [Phone], [NativePlace]) VALUES (N'4', N'小米', N'0', N'82484567', N'deq')
GO

INSERT INTO [dbo].[Student] ([Id], [Name], [Sex], [Phone], [NativePlace]) VALUES (N'5', N'小明', N'0', N'13265498778', N'dddddd')
GO

SET IDENTITY_INSERT [dbo].[Student] OFF
GO


-- ----------------------------
-- Auto increment value for category
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[category]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table category
-- ----------------------------
ALTER TABLE [dbo].[category] ADD CONSTRAINT [PK__tmp_ms_x__3213E83F8EB0937D] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Student
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Student]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [PK__Student__3213E83F7878FD6E] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

