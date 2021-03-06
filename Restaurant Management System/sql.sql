USE [restaurantdb]
GO
/****** Object:  Table [dbo].[bookingtbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bookingtbl](
	[bookingId] [varchar](50) NOT NULL,
	[bookingDate] [varchar](50) NOT NULL,
	[bookingStartTime] [varchar](50) NOT NULL,
	[bookingEndTime] [varchar](50) NOT NULL,
	[NoOfGuest] [int] NULL,
	[NoOfTable] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carttbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carttbl](
	[itemId] [varchar](50) NOT NULL,
	[itemName] [varchar](50) NOT NULL,
	[itemPrice] [int] NOT NULL,
	[itemQuantity] [int] NOT NULL,
	[totalPrice] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customerbookingtbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerbookingtbl](
	[customerId] [varchar](50) NOT NULL,
	[bookingId] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customertbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customertbl](
	[customerId] [varchar](50) NOT NULL,
	[customerName] [varchar](50) NOT NULL,
	[customerEmail] [varchar](50) NULL,
	[customerPhoneNo] [int] NULL,
	[customerAddress] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[itemtbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itemtbl](
	[itemId] [varchar](50) NOT NULL,
	[itemName] [varchar](50) NOT NULL,
	[itemType] [varchar](50) NOT NULL,
	[itemPrice] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ordertbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ordertbl](
	[orderId] [varchar](50) NULL,
	[customerId] [varchar](50) NULL,
	[deliveryDate] [varchar](50) NULL,
	[deliveryAddress] [varchar](50) NULL,
	[totalItem] [int] NULL,
	[totalQuantity] [int] NULL,
	[totalBill] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usertbl]    Script Date: 08-Aug-17 4:09:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usertbl](
	[userid] [varchar](50) NOT NULL,
	[passcode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_usertbl] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
