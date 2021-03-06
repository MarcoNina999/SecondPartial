USE [purchases]
GO
/****** Object:  Table [dbo].[Buy]    Script Date: 30/6/2020 12:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buy](
	[id_buy] [int] NOT NULL,
	[date_buy] [date] NULL,
	[total_buy] [varchar](30) NULL,
	[observation_buy] [varchar](50) NULL,
	[state_buy] [varchar](50) NULL,
 CONSTRAINT [Buy_PK] PRIMARY KEY CLUSTERED 
(
	[id_buy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Buy_Detail]    Script Date: 30/6/2020 12:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buy_Detail](
	[id_bd] [int] NOT NULL,
	[amount_bd] [varchar](30) NULL,
	[price] [varchar](30) NULL,
	[sub_total] [varchar](30) NULL,
	[Product_id_prod] [int] NOT NULL,
	[Buy_id_buy] [int] NOT NULL,
 CONSTRAINT [Buy_Detail_PK] PRIMARY KEY CLUSTERED 
(
	[id_bd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PayDetail]    Script Date: 30/6/2020 12:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PayDetail](
	[id_pd] [int] NOT NULL,
	[date_pd] [date] NULL,
	[pay_pd] [varchar](30) NULL,
	[bank_pd] [varchar](50) NULL,
	[Buy_id_buy] [int] NOT NULL,
 CONSTRAINT [PayDetail_PK] PRIMARY KEY CLUSTERED 
(
	[id_pd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 30/6/2020 12:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[id_prod] [int] NOT NULL,
	[nom_prod] [varchar](30) NULL,
	[desc_prod] [varchar](50) NULL,
	[Provider_id_prov] [int] NOT NULL,
 CONSTRAINT [Product_PK] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 30/6/2020 12:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provider](
	[id_prov] [int] NOT NULL,
	[name_prov] [varchar](30) NULL,
	[country_prov] [varchar](30) NULL,
	[swift_prov] [varchar](30) NULL,
 CONSTRAINT [Provider_PK] PRIMARY KEY CLUSTERED 
(
	[id_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Buy_Detail]  WITH CHECK ADD  CONSTRAINT [Buy_Detail_Buy_FK] FOREIGN KEY([Buy_id_buy])
REFERENCES [dbo].[Buy] ([id_buy])
GO
ALTER TABLE [dbo].[Buy_Detail] CHECK CONSTRAINT [Buy_Detail_Buy_FK]
GO
ALTER TABLE [dbo].[Buy_Detail]  WITH CHECK ADD  CONSTRAINT [Buy_Detail_Product_FK] FOREIGN KEY([Product_id_prod])
REFERENCES [dbo].[Product] ([id_prod])
GO
ALTER TABLE [dbo].[Buy_Detail] CHECK CONSTRAINT [Buy_Detail_Product_FK]
GO
ALTER TABLE [dbo].[PayDetail]  WITH CHECK ADD  CONSTRAINT [PayDetail_Buy_FK] FOREIGN KEY([Buy_id_buy])
REFERENCES [dbo].[Buy] ([id_buy])
GO
ALTER TABLE [dbo].[PayDetail] CHECK CONSTRAINT [PayDetail_Buy_FK]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [Product_Provider_FK] FOREIGN KEY([Provider_id_prov])
REFERENCES [dbo].[Provider] ([id_prov])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [Product_Provider_FK]
GO
