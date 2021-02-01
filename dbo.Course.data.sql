SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (1, N'software', N'2021-01-15 00:00:00', N'2021-01-28 00:00:00', N'2021-01-28')
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (2, N'webdeveloper', N'2021-01-01 00:00:00', N'2021-01-19 00:00:00', N'2021-01-26')
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (3, N'health care', N'2021-01-08 00:00:00', N'2021-01-28 00:00:00', N'2021-02-05')
SET IDENTITY_INSERT [dbo].[Course] OFF
