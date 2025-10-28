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
            if (lines.Length == 0) return new List<FdaReport>();
            var headerLine = lines[0];
            var headerCells = headerLine.Split(',');

            //read the CSV, check the empty database so that there are no errors.
            //headerLine accepts headers for future data maps
            //headerCells splits the split headerLine and retrieves the deleted data.

            var map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            //we store headers and values
            for (int i = 0; i < headerCells.Length; i++)
                map[headerCells[i].Trim()] = i;
            //we remove all problems from the line to map
            //header check and error
            foreach (var h in Headers)
                if (!map.ContainsKey(h))
                    Console.WriteLine($"I didn't find a title with the name {h}");
            //compare the header from private static readonly string[] Headers = new[]
            var list = new List<FdaReport>();

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                //Line check. Skip the first line of the header and check further. If the line is empty, move on.
            }
        }
    }
}














