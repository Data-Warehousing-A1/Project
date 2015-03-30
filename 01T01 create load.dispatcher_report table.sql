create database DW_Medical

create schema load
create schema master
create schema stage

drop table load.dispatcher_report

CREATE TABLE [load].[dispatcher_report](
	[Date] [varchar](8000) NULL,
	[Time] [varchar](8000) NULL,
	[County] [varchar](8000) NULL,
	[Unit] [varchar](8000) NULL,
	[Age] [varchar](8000) NULL,
	[Ped Color] [varchar](8000) NULL,
	[Sex] [varchar](8000) NULL,
	[Category] [varchar](8000) NULL,
	[Description] [varchar](8000) NULL,
	[CC] [varchar](8000) NULL,
	[BP 1] [varchar](8000) NULL,
	[BP 2] [varchar](8000) NULL,
	[Pulse 1] [varchar](8000) NULL,
	[Pulse 2] [varchar](8000) NULL,
	[Resp 1] [varchar](8000) NULL,
	[Resp 2] [varchar](8000) NULL,
	[O2 Sat 1] [varchar](8000) NULL,
	[O2 Sat 2] [varchar](8000) NULL,
	[BGL 1] [varchar](8000) NULL,
	[BGL 2] [varchar](8000) NULL,
	[LOC] [varchar](8000) NULL,
	[GCS] [varchar](8000) NULL,
	[T A] [varchar](8000) NULL,
	[S A] [varchar](8000) NULL,
	[Stemi] [varchar](8000) NULL,
	[Dept] [varchar](8000) NULL,
	[Level] [varchar](8000) NULL,
	[Resus] [varchar](8000) NULL,
	[ETA] [varchar](8000) NULL,
	[MPS] [varchar](8000) NULL,
	[id] [bigint] IDENTITY(1,1) NOT NULL
)

