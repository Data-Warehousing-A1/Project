/*Build the DataWarehouse*/

--run file: 01T01 create load.dispatcher_report table.sql
--import data using the dtsx file: 02S01 load_dispatcher_report.dtsx
--run file: 03T02 create master.dispatcher_report and move data from load into it.sql
--run file: 04P01 create stored procedure master.dispatcher_report units.sql
--run script: exec master.update_unit_values
--run file: 05P02 create stored procedure master.update_county.sql
--run script: exec master.update_county_values
--run file: 06P03 create stored procedure master.update_stemi.sql
--run script: exec master.update_stemi_values
--run file: 07P04 create stored procedure master.remove_duplicates.sql
--run script: exec master.remove_duplicates
--run file: 25T03 create stage response data.sql
--run file: 26T04 create dispatcher fake data.sql
--run file: 26P05 create master.update_county_units2.sql
--run script: exec master.update_county_units2
--run file: 28P06 create master.update_dispatcher.sql
--run script: exec master.update_dispatcher
--run file: 29T07 create dbo.code table and populate it 
