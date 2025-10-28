using opggave4.Services;

var reader = new CsvReaderService();
var path = "data/mydata.csv";

var reports = reader.Reed(path);

//

