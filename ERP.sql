USE [ERP]
GO
/****** Object:  Table [dbo].[ProductList]    Script Date: 2021/12/5 上午 02:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductList](
	[Product_ID] [nvarchar](50) NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Product_Class] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Create_ID] [int] NOT NULL,
	[Create_Time] [date] NOT NULL,
	[Update_ID] [int] NULL,
	[Update_Time] [date] NULL,
	[Isdelete] [bit] NULL,
	[Delete_Time] [date] NULL,
 CONSTRAINT [PK_ProductList] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseDetail]    Script Date: 2021/12/5 上午 02:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetail](
	[Sid] [int] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [nvarchar](50) NOT NULL,
	[Product_ID] [nvarchar](50) NULL,
	[Product_Quantity] [int] NULL,
	[Purchase_Class] [int] NOT NULL,
	[ArriveTime] [date] NOT NULL,
	[Isdelete] [bit] NOT NULL,
	[DeleteMember] [int] NULL,
	[DeleteTime] [datetime] NULL,
 CONSTRAINT [PK_PurchaseList] PRIMARY KEY CLUSTERED 
(
	[Sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffList]    Script Date: 2021/12/5 上午 02:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffList](
	[Staff_ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff_Name] [nvarchar](50) NOT NULL,
	[Staff_Level] [int] NOT NULL,
	[Create_Staff_ID] [int] NOT NULL,
	[CreateTime] [date] NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Update_Staff_ID] [int] NULL,
	[UpdateTime] [date] NULL,
	[Isdelete] [bit] NULL,
	[DeleteTime] [date] NULL,
 CONSTRAINT [PK_StaffList] PRIMARY KEY CLUSTERED 
(
	[Staff_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProductList] ([Product_ID], [Product_Name], [Product_Class], [Price], [Create_ID], [Create_Time], [Update_ID], [Update_Time], [Isdelete], [Delete_Time]) VALUES (N'P01', N'精油', N'A', CAST(600 AS Decimal(18, 0)), 1, CAST(N'2021-06-18' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductList] ([Product_ID], [Product_Name], [Product_Class], [Price], [Create_ID], [Create_Time], [Update_ID], [Update_Time], [Isdelete], [Delete_Time]) VALUES (N'P02', N'浴鹽', N'B', CAST(500 AS Decimal(18, 0)), 1, CAST(N'2021-06-18' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductList] ([Product_ID], [Product_Name], [Product_Class], [Price], [Create_ID], [Create_Time], [Update_ID], [Update_Time], [Isdelete], [Delete_Time]) VALUES (N'P03', N'肥皂', N'C', CAST(400 AS Decimal(18, 0)), 1, CAST(N'2021-06-18' AS Date), NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductList] ([Product_ID], [Product_Name], [Product_Class], [Price], [Create_ID], [Create_Time], [Update_ID], [Update_Time], [Isdelete], [Delete_Time]) VALUES (N'P04', N'芳香劑', N'D', CAST(300 AS Decimal(18, 0)), 1, CAST(N'2021-07-01' AS Date), NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[PurchaseDetail] ON 

INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (1, N'ASN-0001', N'P01', 10, 3, CAST(N'2021-06-29' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (4, N'ASN-0001', N'P03', 5, 3, CAST(N'2021-06-29' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (5, N'ASN-0002', N'P01', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (6, N'ASN-0003', N'P01', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (7, N'ASN-0004', N'P01', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (8, N'ASN-0005', N'P01', 1, 2, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (9, N'ASN-0005', N'P01', 1, 2, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (11, N'ASN-0006', N'P01', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (12, N'ASN-0007', N'P02', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (13, N'ASN-0008', N'P03', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (14, N'ASN-0009', N'P01', 1, 1, CAST(N'2021-06-30' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (57, N'ASN-0010', N'P02', 1, 3, CAST(N'2021-07-05' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (1039, N'ASN-0010', N'P01', 2, 3, CAST(N'2021-07-15' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (1040, N'ASN-0010', N'P02', 1, 3, CAST(N'2021-07-15' AS Date), 0, NULL, NULL)
INSERT [dbo].[PurchaseDetail] ([Sid], [Purchase_ID], [Product_ID], [Product_Quantity], [Purchase_Class], [ArriveTime], [Isdelete], [DeleteMember], [DeleteTime]) VALUES (1041, N'ASN-0010', N'P03', 1, 3, CAST(N'2021-07-15' AS Date), 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PurchaseDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[StaffList] ON 

INSERT [dbo].[StaffList] ([Staff_ID], [Staff_Name], [Staff_Level], [Create_Staff_ID], [CreateTime], [Account], [Password], [Update_Staff_ID], [UpdateTime], [Isdelete], [DeleteTime]) VALUES (1, N'饒經理', 0, 1, CAST(N'2021-06-18' AS Date), N'admin', N'admin', NULL, NULL, NULL, NULL)
INSERT [dbo].[StaffList] ([Staff_ID], [Staff_Name], [Staff_Level], [Create_Staff_ID], [CreateTime], [Account], [Password], [Update_Staff_ID], [UpdateTime], [Isdelete], [DeleteTime]) VALUES (4, N'饒員工', 1, 1, CAST(N'2021-06-18' AS Date), N'menber', N'menber', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[StaffList] OFF
GO
ALTER TABLE [dbo].[ProductList]  WITH CHECK ADD  CONSTRAINT [FK_ProductList_StaffList] FOREIGN KEY([Create_ID])
REFERENCES [dbo].[StaffList] ([Staff_ID])
GO
ALTER TABLE [dbo].[ProductList] CHECK CONSTRAINT [FK_ProductList_StaffList]
GO
ALTER TABLE [dbo].[PurchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetail_ProductList] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[ProductList] ([Product_ID])
GO
ALTER TABLE [dbo].[PurchaseDetail] CHECK CONSTRAINT [FK_PurchaseDetail_ProductList]
GO
