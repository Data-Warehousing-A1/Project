USE [DW_Medical]
GO

/****** Object:  StoredProcedure [bpa].[update_county_units2]    Script Date: 03/12/2013 15:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[master].[update_county_units2]') AND type in (N'P', N'PC'))
DROP Procedure [master].[update_county_units2]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [master].[update_county_units2]

    /* Parameters */

as

begin

update m
set county =
	case 
		when unit like '%cent-%' then 'duval'
		when unit like '%liberty%' then 'duval'
		when unit like '%apt%' then 'duval'
		when unit like '%asi%' then 'duval'
	end
--select *
from 
	master.dispatcher_report m
where 
	m.county is null and 
	m.unit is not null and
	m.unit not like '%r-%' and
	m.unit not like '%airevac%' and
	m.unit not like '%other%'
end