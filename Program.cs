using opggave4.Services;

var reader = new CsvReaderService();
var path = "data/mydata.csv";

var reports = reader.Read(path);

//I'm reading a database created in CsvReaderService.

// I'm accessing the file.

// I'm reading the lines.

Console.WriteLine(reports.Count);
Console.WriteLine($"вот столько строк {reports.Count}");

