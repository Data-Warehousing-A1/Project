
drop table stage.response


create table stage.response
(
	county varchar(15),
	unit varchar(10)
)

insert into stage.response
(
	county,
	unit
)
select
	distinct
	county,
	unit
from
	master.dispatcher_report
where
	county is not null and
	unit is not null

select *
from stage.response
order by county, unit