------------------------------------------------------
-- 			USO GENERAL
------------------------------------------------------
USE [AngularWebDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------
-- 			USO GENERAL
------------------------------------------------------




CREATE TABLE [dbo].[GeneralPage](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GeneralPage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO





------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|
-- 			ABOUT                                                                                           |
------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|



------------------------------------------------------
-- 			Home TABLE
------------------------------------------------------
CREATE TABLE [dbo].[Home](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sectionName] [varchar](20) NOT NULL, --Home
	[title] [varchar](50) NOT NULL,
	[subtitle] [varchar](150) NOT NULL,
	[backgroundImagePath] [varchar](500) NOT NULL,
	[startButton] [varchar](15) NOT NULL,
	[videoButton] [varchar](15) NULL,
	[videoButtonUrl] [bit] NOT NULL,
	[generalPageId] [bigint] NOT NULL,
 CONSTRAINT [PK_Home] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Home]  WITH CHECK ADD  CONSTRAINT [FK_Home_GeneralPage] FOREIGN KEY([generalPageId])
REFERENCES [dbo].[GeneralPage] ([id])
GO

ALTER TABLE [dbo].[Home] CHECK CONSTRAINT [FK_Home_GeneralPage]
GO



------------------------------------------------------
-- 			HomeItems TABLE
------------------------------------------------------
CREATE TABLE [dbo].[HomeItems](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[icon] [varchar](25) NOT NULL,
	[linkUrl] [varchar](MAX) NOT NULL,
	[enabledItem] [bit] NOT NULL,
	[homeId] [bigint] NOT NULL,
 CONSTRAINT [PK_HomeItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[HomeItems] ADD  DEFAULT ((1)) FOR [enabledItem]
GO

ALTER TABLE [dbo].[HomeItems]  WITH CHECK ADD  CONSTRAINT [FK_HomeItems_Home] FOREIGN KEY([homeId])
REFERENCES [dbo].[Home] ([id])
GO

ALTER TABLE [dbo].[HomeItems] CHECK CONSTRAINT [FK_HomeItems_Home]
GO





------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|
-- 			ABOUT                                                                                           |
------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|



------------------------------------------------------
-- 			About TABLE
------------------------------------------------------
CREATE TABLE [dbo].[About](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sectionName] [varchar](20) NOT NULL, 
	[title] [varchar](50) NOT NULL,
	[mainSubtitle] [varchar](300) NOT NULL,
	[secondarySubtitle] [varchar](300) NOT NULL,
	[description] [varchar](300) NOT NULL,
	[mainImagePath] [varchar](500) NOT NULL,
	[generalPageId] [bigint] NOT NULL,
 CONSTRAINT [PK_About] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[About]  WITH CHECK ADD  CONSTRAINT [FK_About_GeneralPage] FOREIGN KEY([generalPageId])
REFERENCES [dbo].[GeneralPage] ([id])
GO

ALTER TABLE [dbo].[About] CHECK CONSTRAINT [FK_About_GeneralPage]
GO



------------------------------------------------------
-- 			AboutItems TABLE
------------------------------------------------------
CREATE TABLE [dbo].[AboutItems](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](70) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[icon] [varchar](25) NOT NULL,
	[enabledItem] [bit] NOT NULL,
	[aboutId] [bigint] NOT NULL,
 CONSTRAINT [PK_AboutItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AboutItems] ADD  DEFAULT ((1)) FOR [enabledItem]
GO

ALTER TABLE [dbo].[AboutItems]  WITH CHECK ADD  CONSTRAINT [FK_AboutItems_About] FOREIGN KEY([aboutId])
REFERENCES [dbo].[About] ([id])
GO

ALTER TABLE [dbo].[AboutItems] CHECK CONSTRAINT [FK_AboutItems_About]
GO




------------------------------------------------------
-- 			AboutTecnologies TABLE
------------------------------------------------------
CREATE TABLE [dbo].[AboutTecnologies](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[percentage] [int] NOT NULL,
	[aboutId] [bigint] NOT NULL,
 CONSTRAINT [PK_AboutTecnologies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[AboutTecnologies]  WITH CHECK ADD  CONSTRAINT [FK_AboutTecnologies_About] FOREIGN KEY([aboutId])
REFERENCES [dbo].[About] ([id])
GO

ALTER TABLE [dbo].[AboutTecnologies] CHECK CONSTRAINT [FK_AboutTecnologies_About]
GO



------------------------------------------------------
-- 			AboutStatistics TABLE
------------------------------------------------------
CREATE TABLE [dbo].[AboutStatistics](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
	[icon] [varchar](25) NOT NULL,
	[aboutId] [bigint] NOT NULL,
 CONSTRAINT [PK_AboutStatistics] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AboutStatistics]  WITH CHECK ADD  CONSTRAINT [FK_AboutStatistics_About] FOREIGN KEY([aboutId])
REFERENCES [dbo].[About] ([id])
GO

ALTER TABLE [dbo].[AboutStatistics] CHECK CONSTRAINT [FK_AboutStatistics_About]
GO



------------------------------------------------------
-- 			AboutSponsors TABLE
------------------------------------------------------
CREATE TABLE [dbo].[AboutSponsors](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[imagePath] [varchar](500) NOT NULL,
	[enabledItem] [bit] NOT NULL,
	[aboutId] [bigint] NOT NULL,
 CONSTRAINT [PK_AboutSponsors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
GO

ALTER TABLE [dbo].[AboutSponsors] ADD  DEFAULT ((1)) FOR [enabledItem]
GO


ALTER TABLE [dbo].[AboutSponsors]  WITH CHECK ADD  CONSTRAINT [FK_AboutSponsors_About] FOREIGN KEY([aboutId])
REFERENCES [dbo].[About] ([id])
GO

ALTER TABLE [dbo].[AboutSponsors] CHECK CONSTRAINT [FK_AboutSponsors_About]
GO





------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|
-- 			SERVICES                                                                                        |
------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|



------------------------------------------------------
-- 			Services TABLE
------------------------------------------------------
CREATE TABLE [dbo].[Services](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sectionName] [varchar](20) NOT NULL, 
	[title] [varchar](50) NOT NULL,
	[generalPageId] [bigint] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_GeneralPage] FOREIGN KEY([generalPageId])
REFERENCES [dbo].[GeneralPage] ([id])
GO

ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_GeneralPage]
GO



------------------------------------------------------
-- 			ServicesItems TABLE
------------------------------------------------------
CREATE TABLE [dbo].[ServicesItems](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](70) NOT NULL,
	[description] [varchar](250) NOT NULL,
	[icon] [varchar](25) NOT NULL,
	[linkUrl] [varchar](MAX) NOT NULL,
	[servicesId] [bigint] NOT NULL,
 CONSTRAINT [PK_ServicesItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[ServicesItems]  WITH CHECK ADD  CONSTRAINT [FK_ServicesItems_Services] FOREIGN KEY([servicesId])
REFERENCES [dbo].[Services] ([id])
GO

ALTER TABLE [dbo].[ServicesItems] CHECK CONSTRAINT [FK_ServicesItems_Services]
GO



------------------------------------------------------
-- 			ServicesEmployees TABLE
------------------------------------------------------
CREATE TABLE [dbo].[ServicesEmployees](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[job] [varchar](50) NOT NULL,
	[description] [varchar](250) NOT NULL,
	[stars] [int] NOT NULL,
	[pictureUrl] [varchar](MAX) NOT NULL,
	[servicesId] [bigint] NOT NULL,
 CONSTRAINT [CK_stars] CHECK ([stars] BETWEEN 1 AND 5),
 CONSTRAINT [PK_ServicesEmployees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[ServicesEmployees]  WITH CHECK ADD  CONSTRAINT [FK_ServicesEmployees_Services] FOREIGN KEY([servicesId])
REFERENCES [dbo].[Services] ([id])
GO

ALTER TABLE [dbo].[ServicesEmployees] CHECK CONSTRAINT [FK_ServicesEmployees_Services]
GO






------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|
-- 			PORTFOLIO                                                                                        |
------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|



------------------------------------------------------
-- 			Portfolio TABLE
------------------------------------------------------
CREATE TABLE [dbo].[Portfolio](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sectionName] [varchar](20) NOT NULL, 
	[title] [varchar](50) NOT NULL,
	[generalPageId] [bigint] NOT NULL,
 CONSTRAINT [PK_Portfolio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Portfolio]  WITH CHECK ADD  CONSTRAINT [FK_Portfolio_GeneralPage] FOREIGN KEY([generalPageId])
REFERENCES [dbo].[GeneralPage] ([id])
GO

ALTER TABLE [dbo].[Portfolio] CHECK CONSTRAINT [FK_Portfolio_GeneralPage]
GO



------------------------------------------------------
-- 			PortfolioItems TABLE
------------------------------------------------------
CREATE TABLE [dbo].[PortfolioItems](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](70) NOT NULL,
	[description] [varchar](250) NOT NULL,
	[pictureUrl] [varchar](MAX) NOT NULL,
	[portfolioId] [bigint] NOT NULL,
 CONSTRAINT [PK_PortfolioItems] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[PortfolioItems]  WITH CHECK ADD  CONSTRAINT [FK_PortfolioItems_Portfolio] FOREIGN KEY([portfolioId])
REFERENCES [dbo].[Portfolio] ([id])
GO

ALTER TABLE [dbo].[PortfolioItems] CHECK CONSTRAINT [FK_PortfolioItems_Portfolio]
GO






------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|
-- 			CONTACT                                                                                        |
------------------------------------------------------------------------------------------------------------|
------------------------------------------------------------------------------------------------------------|



------------------------------------------------------
-- 			Contact TABLE
------------------------------------------------------
CREATE TABLE [dbo].[Contact](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sectionName] [varchar](20) NOT NULL, 
	[title] [varchar](50) NOT NULL,
	[videoButton] [varchar](15) NULL,
	[generalPageId] [bigint] NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_GeneralPage] FOREIGN KEY([generalPageId])
REFERENCES [dbo].[GeneralPage] ([id])
GO

ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_GeneralPage]
GO



------------------------------------------------------
-- 			ContactData TABLE
------------------------------------------------------
CREATE TABLE [dbo].[ContactData](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[phone] [varchar](15) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[mapIframeSrc] [varchar](MAX) NOT NULL,
	[contactId] [bigint] NOT NULL,
 CONSTRAINT [PK_ContactData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[ContactData]  WITH CHECK ADD  CONSTRAINT [FK_ContactData_Contact] FOREIGN KEY([contactId])
REFERENCES [dbo].[Contact] ([id])
GO

ALTER TABLE [dbo].[ContactData] CHECK CONSTRAINT [FK_ContactData_Contact]
GO



------------------------------------------------------
-- 			ContactMessages TABLE
------------------------------------------------------
CREATE TABLE [dbo].[ContactMessages](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[subject] [varchar](150) NOT NULL,
	[messageText] [varchar](MAX) NOT NULL,
	[contactId] [bigint] NOT NULL,
 CONSTRAINT [PK_ContactMessages] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[ContactMessages]  WITH CHECK ADD  CONSTRAINT [FK_ContactMessages_Contact] FOREIGN KEY([contactId])
REFERENCES [dbo].[Contact] ([id])
GO

ALTER TABLE [dbo].[ContactMessages] CHECK CONSTRAINT [FK_ContactMessages_Contact]
GO


