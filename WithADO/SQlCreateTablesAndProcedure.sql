USE [TestSeaExpress1]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUser] 
	@nameF nvarchar(50),
	@nameL nvarchar(50),
	@nameM nvarchar(50),
	@email nvarchar(50)
AS
BEGIN
	insert into Persons (FirstName, LastName, MiddleName, email) values (@nameF,@nameL,@nameM,@email)
END

GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUser] 
	@id int
AS
BEGIN
	select * from Persons where id=@id
END

GO
/****** Object:  StoredProcedure [dbo].[GetUsers]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUsers]
	
AS
BEGIN
	select * from Persons
END

GO
/****** Object:  StoredProcedure [dbo].[Init]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Init]
	
AS
BEGIN
	insert into Persons (FirstName, LastName, MiddleName, email) values ('Михайлов','Сергей','Иванович','rusu@sea.ru')
	insert into Persons (FirstName, LastName, MiddleName, email) values ('Круглов','Алексей','Петрович','a.kruglof@sea.ru')
	insert into Persons (FirstName, LastName, MiddleName, email) values ('Потапов','Иван','Алексеевич','i.potapov@sea.ru')
END

GO
/****** Object:  StoredProcedure [dbo].[RemovePersonID]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RemovePersonID]
	@id int
AS
BEGIN
	delete from Persons where id=@id
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 11.07.2016 10:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateUser]
		@idUser int,
		@nameF nvarchar(50),
		@nameL nvarchar(50),
		@nameM nvarchar(50),
		@email nvarchar(50)
AS
BEGIN
	update Persons set FirstName=@nameF, LastName=@nameL, MiddleName=@nameM, email=@email where id=@idUser
END

GO
