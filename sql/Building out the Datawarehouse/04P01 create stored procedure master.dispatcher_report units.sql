USE [DW_Medical]
GO

/****** Object:  StoredProcedure [master].[update_unit_values]   Script Date: 03/28/2013 15:14:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[master].[update_unit_values]') AND type in (N'P', N'PC'))
DROP Procedure [master].[update_unit_values]
GO

USE [DW_Medical]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [master].[update_unit_values]

    /* Parameters */

as

begin

    /* Setup */
    set nocount on;

	/* Declare Variables */
    --declare @variable datatype
	
    /* Initialize Variables */
	--set @variable = @default_value;
	
--remove carriage returns and linefeeds from the chief_complaint column
update master.dispatcher_report
set chief_complaint = replace(chief_complaint, char(10), '')
where chief_complaint like '%' + char(10) + '%'

update master.dispatcher_report
set chief_complaint = replace(chief_complaint, char(13), ' ')
where chief_complaint like '%' + char(13) + '%'


--attempt to fill in the unit variable for missing units
create table #units
(
	unit varchar(20),
	id bigint
)

insert into #units
select
	case 
		when
			county is null and
			isnull(unit, 'other') = 'other' and
			chief_complaint not like '%baker act%' and
			chief_complaint like '%baker r[0-9][0-9]%'
		then
			'baker-r-' + substring(chief_complaint, patindex('%baker r%', chief_complaint) + 7, 2)
		when
			county is null and
			isnull(unit, 'other') = 'other' and
			chief_complaint not like '%baker act%' and
			chief_complaint like '%baker r-[0-9][0-9]%'
		then
			'baker-r-' + substring(chief_complaint, patindex('%baker r-%', chief_complaint) + 8, 2)
		
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint not like '%baker act%' and
			chief_complaint like '%baker co r[0-9][0-9]%'
		then
			'baker-r-' + substring(chief_complaint, patindex('%baker co r%', chief_complaint) + 10, 2)
		when 
			isnull(unit, 'other') = 'other' and
			chief_complaint not like '%baptist%' and
			chief_complaint like '%apt[0-9][0-9]%'
		then
			'apt-' + substring(chief_complaint, patindex('%apt%', chief_complaint) + 3, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint not like '%baptist%' and
			(chief_complaint like '%apt-[0-9][0-9]%' or chief_complaint like '%apt [0-9][0-9]%')
		then
			'apt-' + substring(chief_complaint, patindex('%apt%', chief_complaint) + 4, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%asi [0-9][0-9]%'
		then
			'asi-' + substring(chief_complaint, patindex('%asi%', chief_complaint) + 4, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%asi-[0-9]%'
		then
			'asi-' + substring(chief_complaint, patindex('%asi%', chief_complaint) + 4, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%asi [0-9]%'
		then
			'asi-' + substring(chief_complaint, patindex('%asi%', chief_complaint) + 4, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%asi[0-9][0-9]%'
		then
			'asi-' + substring(chief_complaint, patindex('%asi%', chief_complaint) + 4, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%asi[0-9]%'
		then
			'asi-' + substring(chief_complaint, patindex('%asi%', chief_complaint) + 3, 1)		
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%century [0-9][0-9]%'
		then
			'cent-' + substring(chief_complaint, patindex('%century%', chief_complaint) + 8, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%cent [0-9][0-9]%'
		then
			'cent-' + substring(chief_complaint, patindex('%cent%', chief_complaint)+5, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%century [0-9]%'
		then
			'cent-' + substring(chief_complaint, patindex('%century%', chief_complaint) + 8, 1)
		
		when
			county is not null and
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%r[0-9][0-9]%'
		then
			'r-' + substring(chief_complaint, patindex('%r[0-9]%', chief_complaint)+1, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%liberty [0-9][0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%liberty%', chief_complaint) + 8, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%liberty [0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%liberty%', chief_complaint) + 8, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%lib-[0-9][0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%lib%', chief_complaint) + 4, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%lib-[0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%lib%', chief_complaint) + 4, 1)	
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%lib [0-9][0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%lib%', chief_complaint) + 4, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%lib [0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%lib%', chief_complaint) + 4, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%liberty - [0-9][0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%liberty%', chief_complaint) + 10, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%liberty - [0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%liberty%', chief_complaint) + 10, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%lib[0-9][0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%lib%', chief_complaint) + 3, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%lib[0-9]%'
		then
			'liberty-' + substring(chief_complaint, patindex('%lib%', chief_complaint) + 3, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%jfrd r-[0-9][0-9]%'
		then
			'jfrd-' + substring(chief_complaint, patindex('%jfrd%', chief_complaint) + 7, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%jfrd r-[0-9]%'
		then
			'jfrd-' + substring(chief_complaint, patindex('%jfrd%', chief_complaint) + 7, 1)


		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%airevac [0-9][0-9]%'
		then
			'airevac-' + substring(chief_complaint, patindex('%airevac %', chief_complaint) + 8, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%air evoc %'
		then
			'airevac-' + substring(chief_complaint, patindex('%air evoc %', chief_complaint) + 9, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%r-[0-9][0-9]%'
		then
			'r-' + substring(chief_complaint, patindex('%r-%', chief_complaint) + 2, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%r- [0-9][0-9]%'
		then
			'r-' + substring(chief_complaint, patindex('%r- %', chief_complaint) + 3, 2)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%r-[0-9]%'
		then
			'r-' + substring(chief_complaint, patindex('%r-%', chief_complaint) + 2, 1)
		when
			isnull(unit, 'other') = 'other' and
			chief_complaint like '%r- [0-9]%'
		then
			'r-' + substring(chief_complaint, patindex('%r- %', chief_complaint) + 3, 1)
	end, master_dispatcher_report_wk
from 
	master.dispatcher_report
where 
	(	
		(county is null or unit is null) and
		(
		(chief_complaint like '%apt%') or
		(chief_complaint like '%lib%') or 
		(chief_complaint like '%cent%') or
		(chief_complaint like '%ae%') or
		(chief_complaint like '%airevac%') or
		(chief_complaint like '%asi%') or
		(chief_complaint like '%(r%' and county is not null) or
		(chief_complaint like '%baker%') or
		(chief_complaint like '%camden%') or
		(chief_complaint like '%heli%') or
		(chief_complaint like '%nassau%') or
		(chief_complaint like '%[0-9%]%')
		)
	) 

update m
set m.unit = s.unit
from #units s
inner join master.dispatcher_report m on m.master_dispatcher_report_wk = s.id

 --   /* Cleanup */
drop table #units

end
