using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggave4.Services
{

    //Reader - System.IO: Utforsk hvordan File.ReadAllLines() eller File.ReadAllText() kan brukes til å lese filinnholdet.
    public class CsvReaderService
    {
        private static readonly string[] Headers = new[]

        {
            "RA_Report #",
            "RA_CAERS Created Date",
            "AEC_Event Start Date",
            "PRI_Product Role",
            "PRI_Reported Brand/Product Name",
            "PRI_FDA Industry Code",
            "PRI_FDA Industry Name",
            "CI_Age at Adverse Event",
            "CI_Age Unit",
            "CI_Gender",
            "AEC_One Row Outcomes",
            "SYM_One Row Coded Symptoms"
        };


        //Parsing: Bruk string-manipulasjon (.Split()) for å konvertere rader til objekter.


        public List<FdaReport> Reed(string path)
        {
            var lines = File.ReadAllLines(path);

        }
    }
}














