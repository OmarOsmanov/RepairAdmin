USE [turkshhhhDB]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [CreatedDate], [Discriminator], [Name], [Surname]) VALUES (N'535bc5fc-1b05-4650-9d0e-7f9a4eeb5ae3', N'osmanovomer494@gmail.com', N'OSMANOVOMER494@GMAIL.COM', N'osmanovomer494@gmail.com', N'OSMANOVOMER494@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEPcACFCtqjUNg2oyigw/P1cRgLcxXde8J/+wvkgYKD3Soa4Fz0OOE3W8YJlBYJNwVg==', N'FLDGBT7USMWVCP4GVX4PIGEPMCTNRLVD', N'f566b5f3-d64b-4f3a-88d6-d6c10c71fef9', N'0554034430', 0, 0, NULL, 1, 0, N'2128. Sokak no:4/ı (KOLİ DEPO) KL366606', CAST(N'2021-12-28T18:29:52.4538034' AS DateTime2), N'CustomUser', N'omar', N'osmanov')
GO
SET IDENTITY_INSERT [dbo].[BlogCategories] ON 

INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (1, N'Technologym')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (3, N'mmm')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (4, N'Fashion')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (6, N'Lifestyle')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (7, N'ghfhghfhfm')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (10, N'Namee')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (11, N'nnmnm')
INSERT [dbo].[BlogCategories] ([Id], [Name]) VALUES (12, N'mmm')
SET IDENTITY_INSERT [dbo].[BlogCategories] OFF
GO
