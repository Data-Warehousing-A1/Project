USE [DW_Medical]
GO

/****** Object:  StoredProcedure [master].[update_stemi]    Script Date: 03/12/2013 15:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[master].[update_stemi]') AND type in (N'P', N'PC'))
DROP Procedure [master].[update_stemi]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [master].[update_stemi]

    /* Parameters */

as

begin
update m
set m.category = 'cardiac'
from
	master.dispatcher_report m
where
	chief_complaint like '%stemi%'


end

