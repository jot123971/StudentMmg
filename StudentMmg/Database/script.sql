SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (1, N'software', N'2021-01-15 00:00:00', N'2021-01-28 00:00:00', N'2021-01-28')
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (2, N'webdeveloper', N'2021-01-01 00:00:00', N'2021-01-19 00:00:00', N'2021-01-26')
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (3, N'health care', N'2021-01-08 00:00:00', N'2021-01-28 00:00:00', N'2021-02-05')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[Enrol] ON
INSERT INTO [dbo].[Enrol] ([ID], [CourseID], [StudentID]) VALUES (1, 3, 2)
INSERT INTO [dbo].[Enrol] ([ID], [CourseID], [StudentID]) VALUES (2, 1, 1)
INSERT INTO [dbo].[Enrol] ([ID], [CourseID], [StudentID]) VALUES (3, 2, 3)
INSERT INTO [dbo].[Enrol] ([ID], [CourseID], [StudentID]) VALUES (4, 2, 1)
SET IDENTITY_INSERT [dbo].[Enrol] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([StudentID], [Studentname], [StudentDoB], [StudentAddress]) VALUES (1, N'jot', N'15/05/2000', N'83 waterside drive')
INSERT INTO [dbo].[Student] ([StudentID], [Studentname], [StudentDoB], [StudentAddress]) VALUES (2, N'lakhwinder', N'1/12/1999', N'83 waterside drive')
INSERT INTO [dbo].[Student] ([StudentID], [Studentname], [StudentDoB], [StudentAddress]) VALUES (3, N'jass', N'4/4/2001', N'83 waterside drive')
INSERT INTO [dbo].[Student] ([StudentID], [Studentname], [StudentDoB], [StudentAddress]) VALUES (4, N'lakhwinder', N'1/12/1999', N'83 waterside drive')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (1, N'software', N'2021-01-15 00:00:00', N'2021-01-28 00:00:00', N'2021-01-28')
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (2, N'webdeveloper', N'2021-01-01 00:00:00', N'2021-01-19 00:00:00', N'2021-01-26')
INSERT INTO [dbo].[Course] ([CourseID], [CourseName], [StartDate], [EndDate], [CourseDuration]) VALUES (3, N'health care', N'2021-01-08 00:00:00', N'2021-01-28 00:00:00', N'2021-02-05')
SET IDENTITY_INSERT [dbo].[Course] OFF

