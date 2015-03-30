drop table master.dispatcher_report

create table master.dispatcher_report
(
	[dispatch_date] datetime,
	[county] varchar(15),
	[unit] varchar(10),
	[age] int,
	[age_type] varchar(3),
	[pediactric_color] varchar(10),
	[sex] varchar(1),
	[category] varchar(15),
	[description] varchar(25),
	[chief_complaint] varchar(255),
	[blood_pressure1_systolic] int,
	[blood_pressure1_diastolic] int,
	[blood_pressure2_systolic] int,
	[blood_pressure2_diastolic] int,
	[pulse1] int,
	[pulse2] int,
	[respiratory1] int,
	[respiratory2] int,
	[oxygen_saturation1] int,
	[oxygen_saturation2] int,
	[blood_glucose_level1] int,
	[blood_glucose_level2] int,
	[loss_of_consciousness] bit,
	[glascow_coma_scale] int,
	[trauma_alert] bit,
	[stroke_alert] bit,
	[stemi] bit,
	[resuscitation] bit,
	[estimated_time_of_arrival] int,
	[mps] bit,
	[master_dispatcher_report_wk] int identity(1,1)
)


insert into master.dispatcher_report
	(
		dispatch_date,
		county,
		unit,
		age,
		age_type,
		pediactric_color,
		sex,
		category,
		description,
		chief_complaint,
		blood_pressure1_systolic,
		blood_pressure1_diastolic,
		blood_pressure2_systolic,
		blood_pressure2_diastolic,
		pulse1,
		pulse2,
		respiratory1,
		respiratory2,
		oxygen_saturation1,
		oxygen_saturation2,
		blood_glucose_level1,
		blood_glucose_level2,
		loss_of_consciousness,
		glascow_coma_scale,
		trauma_alert,
		stroke_alert,
		stemi,
		resuscitation,
		estimated_time_of_arrival,
		mps
	)
	select
		date + ' ' + 
		cast(cast(RIGHT(CONVERT(varchar(30), CAST(STUFF(
			(case 
				when len(time) = 1 then '000' + time
				when len(time) = 2 then '00' + time
				when len(time) = 3 then '0' + time
				when len(time) = 4 then time
				else null end)
		, 3, 0, ':') AS datetime), 0), 7) as varchar) as datetime) as dispatch_date,
		case 
			when county = 'unknown' then null 
			when county = 'other' then null
			else lower(county) end as county,
		case 
			when unit = 'unknown' then null 
			when unit = 'other' then null
			else lower(unit) end as unit,
		case 
			when len(age) > 3 and age like '% %' then substring(age, 0, patindex('% %', age)) 
			when len(age) < 1 then null
			when age > 125 then -1
			when isnumeric(age) = 1 then age
			else null end as age,
		case when len(age) > 3 and age like '% %' then lower(substring(age, patindex('% %', age)+1, len(age)))
			 when len(age) < 1 then null
			 else 'yrs' end as age_type,
		case 
			when [ped color] = '' then null
			when [ped color] = 'N/A' then null
			else lower([ped color]) end as pediatric_color,
		case
			when sex = '' then null
			else lower(sex) end as sex,
		
		lower([category]) as category,
		lower([description]) as description,
		lower(cc) as chief_complaint,
		
		case 
			when [bp 1] not like '%/%' then null
			when [bp 1] = '' then null
			when isnumeric(substring([bp 1], 0, patindex('%/%', [bp 1]))) = 1 then substring([bp 1], 0, patindex('%/%', [bp 1]))
			else null end as blood_pressure1_systolic,
		case
			when [bp 1] not like '%/%' then null
			when [bp 1] = '' then null
			when isnumeric(substring([bp 1], patindex('%/%', [bp 1]) + 1, len([bp 1]))) = 1 then substring([bp 1], patindex('%/%', [bp 1]) + 1, len([bp 1]))
			else null end as blood_pressure1_diastolic,
		case 
			when [bp 2] not like '%/%' then null
			when [bp 2] = '' then null
			when isnumeric(substring([bp 2], 0, patindex('%/%', [bp 2]))) = 1 then substring([bp 2], 0, patindex('%/%', [bp 2]))
			else null end as blood_pressure2_systolic,
		case
			when [bp 2] not like '%/%' then null
			when [bp 2] = '' then null
			when isnumeric(substring([bp 2], patindex('%/%', [bp 2]) + 1, len([bp 2]))) = 1 then substring([bp 2], patindex('%/%', [bp 2]) + 1, len([bp 2]))
			else null end as blood_pressure2_diastolic,
		case 
			when [Pulse 1] > 300 then -1
			when isnumeric([Pulse 1]) = 1 then [Pulse 1] 
			else null end as pulse1,
		case 
			when [Pulse 2] > 300 then -1
			when isnumeric([Pulse 2]) = 1 then [Pulse 2] 
			else null end as pulse2,
		case 
			when isnumeric([Resp 1]) = 1 and [Resp 1] < 120 then [Resp 1]
			when [Resp 1] > 120 then -1
			else null end as respiratory1,
		case
			when isnumeric([Resp 2]) = 1 and [Resp 2] < 120 then [Resp 2]
			when [Resp 2] > 120 then -1
			else null end as respiratory2,
		case
			when isnumeric([O2 Sat 1]) = 1 and [O2 Sat 1] <= 100 then [O2 Sat 1]
			when [O2 Sat 1] > 100 then -1
			else null end as oxygen_saturation1,
		case
			when isnumeric([O2 Sat 2]) = 1 and [O2 Sat 2] <= 100 then [O2 Sat 2]
			when [O2 Sat 2] > 100 then -1
			else null end as oxygen_saturation2,
		case
			when isnumeric([BGL 1]) = 1 and [BGL 1] < 999 then [BGL 1]
			when [BGL 1] > 999 then -1
			else null end as blood_glucose_level1,
		case
			when isnumeric([BGL 2]) = 1 and [BGL 2] < 999 then [BGL 2]
			when [BGL 2] > 999 then -1
			else null end as blood_glucose_level2,
		case
			when loc = 'Y' then 1
			when loc = 'N' then 0
			else null end as loss_of_consciousness,
		case
			when len(gcs) < 1 then null
			when isnumeric(gcs) = 1 and gcs >= 3 and gcs <= 15 then gcs
			when isnumeric(gcs) = 1 and (gcs < 3 or gcs > 15) then -1
			else null end as glascow_coma_scale,
		case
			when [T A]= 'Y' then 1
			when [T A] = 'N' then 0
			else null end as trauma_alert,
		case
			when [S A] = 'Y' then 1
			when [S A] = 'N' then 0
			else null end as stroke_alert,
		case
			when stemi = 'Y' then 1
			when stemi = 'N' then 0
			else null end as stemi,
		case
			when resus = 'Y' then 1
			when resus = 'N' then 0
			else null end as resuscitation,
		case
			when isnumeric(eta) = 1 then eta
			else null end as estimated_time_of_arrival,
		case
			when mps = 'Y' then 1
			when mps = 'N' then 0
			else null end as mps
	from
		load.dispatcher_report r


--truncate table master.dispatcher_report



/*

stage.patient
	patient_wk
	age
	sex
		--derived from combination of time, date, age, sex, county

stage.report_cc
	date
	time
	unit
	county
	dispatcher_wk
	patient_wk
	action

stage.cc
	cc_wk
	description

stage.category
	category_wk
	name

stage.nurse
	nurse_wk
	name
	home_address
	home_phone
	area_of_work
	specialty

stage.physician
	physician_wk
	name
	home_address
	home_phone
	office_location
	office_number
	office_phone
	specialty

stage.dispatcher_report
	date
	time
	unit
	county
	dispatcher_wk
	patient_wk
	ped_color
	desription
	bp1
	bp2
	pulse1
	pulse2
	resp1
	resp2
	o2_sat1
	o2_sat2
	bgl1
	bgl2
	loc
	gcs
	t_a
	s_a
	stemi
	dept
	level
	resus
	eta
	mps

stage.dispatcher
	dispatcher_wk
	name
	address
	phone
	work_location
	skill_level


select * from dbo.bgl
*/