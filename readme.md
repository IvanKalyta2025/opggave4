I using https://www.kaggle.com/datasets/fda/adverse-food-events?select=CAERS_ASCII_2004_2017Q2.csv DB

RA_Report #,RA_CAERS Created Date,AEC_Event Start Date,PRI_Product Role,PRI_Reported Brand/Product Name,PRI_FDA Industry Code,PRI_FDA Industry Name,CI_Age at Adverse Event,CI_Age Unit,CI_Gender,AEC_One Row Outcomes,SYM_One Row Coded Symptoms

program start
make reader = new CsvReaderService
let pathToFile = "data/mydata.csv"
reports = reader.Read(pathToFile)

print reports.Count
print text "number of terms..." together with same number

controller = new ReportController(reports)

print line "The first five products"
take controller.SelectAllProdictNames()
keep only first five
for each name do Console.WriteLine(name)

print line "The first five IndustryName"
again take controller.SelectAllProdictNames()
keep first five
write them out (looks like they wanted industry names but same method used)

print line "The first five Female Reports (Where)"
take controller.WhereGender("Female")
keep first five
for each report print number, product name and gender with |

program end

pseudocode CsvReaderService.Read(path):
lines = File.ReadAllLines(path)
if no lines -> return new empty list
headerLine = first line
headerCells = headerLine.Split(',')
make dictionary map to remember column positions
go through headerCells and store pairs
check map contains every header from Headers
make empty list result
for every line after first:
if line is empty -> continue
cells = line.Split(',')
make new FdaReport item
fill fields from cells[0]..cells[11]
try DateTime.TryParse for the date fields, else null
add item into result
after loop return result

pseudocode ReportController:
keep private List<FdaReport> \_data
constructor gets data and stores in \_data

    method SelectAllProdictNames():
        filter _data where ProductName not empty
        return sequence of names only

    method WhereGender(gender):
        filter _data where Gender not null and equals gender ignoring case
        return found reports

    // more methods not written yet
