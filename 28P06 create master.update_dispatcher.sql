USE [DW_Medical]
GO

/****** Object:  StoredProcedure [master].[update_dispatcher]    Script Date: 03/12/2013 15:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[master].[update_dispatcher]') AND type in (N'P', N'PC'))
DROP Procedure [master].[update_dispatcher]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [master].[update_dispatcher]

    /* Parameters */

as

begin
update m
set m.dispatcher_wk = d.dispatcher_wk
from
	master.dispatcher_report m
	inner join stage.dispatcher d on d.county = m.county
where
	m.dispatcher_wk is null

end

