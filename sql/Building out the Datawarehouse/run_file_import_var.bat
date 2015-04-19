dtexec /FILE "\"##DTSPATH##"" /DECRYPT "test" /CONNECTION SourceConnectionFlatFile;"\"##path##\""  /CHECKPOINTING OFF  /REPORTING EWCDI 
sqlcmd -S "lyra.unfcsd.unf.edu" -U "cap4774sp15dwa1" -P "hovertrack" -Q  "exec master.process_dispatcher_report"
