USE [DW_Medical]
GO

/****** Object:  StoredProcedure [bpa].[remove_duplicates]    Script Date: 03/12/2013 15:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[master].[remove_duplicates]') AND type in (N'P', N'PC'))
DROP Procedure [master].[remove_duplicates]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [master].[remove_duplicates]

    /* Parameters */

as

begin

;with cte as (
SELECT 
	sod.dispatch_date, 
	sod.county, 
	sod.unit, 
	sod.age, 
	sod.age_type, 
	sod.master_dispatcher_report_wk,
	row_number() over (partition by sod.dispatch_date, sod.county, sod.unit, sod.age, sod.age_type order by sod.master_dispatcher_report_wk desc) as rank
FROM master.dispatcher_report AS sod
    inner join master.dispatcher_report AS soh
    ON 
		sod.dispatch_date = soh.dispatch_date and
		sod.county = sod.county and
		sod.unit = soh.unit and
		sod.age = soh.age and
		sod.age_type = soh.age_type and
		sod.master_dispatcher_report_wk <> soh.master_dispatcher_report_wk
 )
delete m
from master.dispatcher_report m
inner join cte c on c.master_dispatcher_report_wk = m.master_dispatcher_report_wk
where
	c.rank > 1

end
