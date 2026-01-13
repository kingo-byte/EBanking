USE [EBanking]
GO
/****** Object:  Table [dbo].[t_User]    Script Date: 13/01/2026 09:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_User](
	[Id] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Dob] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[t_User] ADD  CONSTRAINT [DF_t_User_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetUsers]    Script Date: 13/01/2026 09:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetUsers] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id]
      ,[UserName]
      ,[Password]
      ,[Dob]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[LastModifiedDate]
      ,[LastModifiedBy]
    FROM [dbo].[t_User]	
END
GO
USE [master]
GO
ALTER DATABASE [EBanking] SET  READ_WRITE 
GO
