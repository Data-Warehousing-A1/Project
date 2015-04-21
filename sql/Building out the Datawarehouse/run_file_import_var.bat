dtexec /FILE "\"##DTSPATH##\"" /DECRYPT "test" /CONNECTION SourceConnectionFlatFile;"\"##path##\""  /CHECKPOINTING OFF
sqlcmd -S "lyra.unfcsd.unf.edu" -U "cap4774sp15dwa1" -P "hovertrack" -Q  "exec master.process_dispatcher_report"
taskkill /IM run_file_import_var.bat