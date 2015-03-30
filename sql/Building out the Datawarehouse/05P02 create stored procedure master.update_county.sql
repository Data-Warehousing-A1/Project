USE [DW_Medical]
GO

/****** Object:  StoredProcedure [master].[update_county_values]    Script Date: 03/12/2013 15:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[master].[update_county_values]') AND type in (N'P', N'PC'))
DROP Procedure [master].[update_county_values] 
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [master].[update_county_values]

    /* Parameters */

as

begin

    /* Setup */
    set nocount on;

	/* Declare Variables */
    --declare @variable datatype
	
    /* Initialize Variables */
	--set @variable = @default_value;

create table #county
(
	county varchar(30),
	id bigint
)

insert into #county
(
	county,
	id
) 
select
	case when chief_complaint like '%camden co%' then 'camden'
		 when chief_complaint like '%baker co%' then 'baker'
		 when chief_complaint like '%charlton co%' then 'charlton'
		 when chief_complaint like '%duval%' then 'duval'
		 when chief_complaint like '%nassau%' then 'nassau'
		 when chief_complaint like '%columbia%' then 'columbia'
		end, master_dispatcher_report_wk
from
	master.dispatcher_report
where
	county is null

update m
set m.county = s.county
from
	master.dispatcher_report m
	inner join #county s on s.id = m.master_dispatcher_report_wk
where
	s.county is not null

end

