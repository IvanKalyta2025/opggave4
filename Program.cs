using opggave4.Services;
using opggave4.Controllers;

var reader = new CsvReaderService();
var path = "data/mydata.csv";

var reports = reader.Read(path);

//I'm reading a database created in CsvReaderService.

// I'm accessing the file.

// I'm reading the lines.

Console.WriteLine(reports.Count);
Console.WriteLine($"вот столько строк {reports.Count}");

var controller = new ReportController(reports);
Console.WriteLine("\nThe first five products ");

foreach (var name in controller.SelectAllProdictNames().Take(5))
    Console.WriteLine($"{name}");

//I take the first five products and put them in the console.


