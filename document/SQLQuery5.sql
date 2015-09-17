USE [UserDB]
GO

DECLARE	 
		@Total int,
		@Pages int

SELECT	@Total = 0
SELECT	@Pages = 0

EXEC	[dbo].[ProcGetDataPagerList]
		@TableName = N'[User]',
		@Fields = N'*',
		@Condition='',
		@Orderby='',
		@PageIndex = 1,
		@PageSize = 10,
		@Total = @Total OUTPUT,
		@Pages = @Pages OUTPUT

SELECT	@Total as N'@Total',
		@Pages as N'@Pages'

		
--exec ProcGetDataPagerList @Condition=N'',@Fields=N'*',@Orderby=N'',@PageIndex=0,@Pages=0,@PageSize=10,@TableName=N'[User]',@Total=0


GO


