CREATE DATABASE BookstoreDB
GO

USE [BookstoreDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_Authors_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Books]    Script Date: 25.7.2013 г. 16:35:27 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[ISBN] [nvarchar](15) NULL,
	[Price] [money] NULL,
	[WebSite] [varchar](256) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Books_Authors]    Script Date: 25.7.2013 г. 16:35:27 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Authors](
	[AuthorId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
 CONSTRAINT [PK_Books_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Books_Reviews]    Script Date: 25.7.2013 г. 16:35:27 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Reviews](
	[BookId] [int] NOT NULL,
	[ReviewId] [int] NOT NULL,
 CONSTRAINT [PK_Books_Reviews] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC,
	[ReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 25.7.2013 г. 16:35:27 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewId] [int] IDENTITY(1,1) NOT NULL,
	[DateOfCreation] [datetime] NOT NULL,
	[AuthorId] [int] NULL,
	[ReviewText] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[ReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Books_Authors]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Books_Authors] CHECK CONSTRAINT [FK_Books_Authors_Authors]
GO
ALTER TABLE [dbo].[Books_Authors]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[Books_Authors] CHECK CONSTRAINT [FK_Books_Authors_Books]
GO
ALTER TABLE [dbo].[Books_Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Books_Reviews_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[Books_Reviews] CHECK CONSTRAINT [FK_Books_Reviews_Books]
GO
ALTER TABLE [dbo].[Books_Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Books_Reviews_Reviews] FOREIGN KEY([ReviewId])
REFERENCES [dbo].[Reviews] ([ReviewId])
GO
ALTER TABLE [dbo].[Books_Reviews] CHECK CONSTRAINT [FK_Books_Reviews_Reviews]
GO
