<Query Kind="Statements" />

var now = DateTimeOffset.Now;
now.Dump();
var pacific = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
var nowPacific = TimeZoneInfo.ConvertTime(now, pacific);
nowPacific.Dump();
TimeZoneInfo.GetSystemTimeZones().Dump();