using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggave4.Models
{
    public class Caers
    {
        public string ReportNumber { get; set; } = string.Empty;                  // RA_Report #
        public DateTime? CreatedDate { get; set; }               // RA_CAERS Created Date
        public DateTime? EventStartDate { get; set; }            // AEC_Event Start Date
        public string ProductRole { get; set; } = string.Empty;                   // PRI_Product Role
        public string ProductName { get; set; } = string.Empty;                   // PRI_Reported Brand/Product Name
        public string IndustryCode { get; set; } = string.Empty;                  // PRI_FDA Industry Code
        public string IndustryName { get; set; } = string.Empty;                  // PRI_FDA Industry Name
        public string AgeAtEvent { get; set; } = string.Empty;                    // CI_Age at Adverse Event
        public string AgeUnit { get; set; } = string.Empty;                          // CI_Age Unit
        public string Gender { get; set; } = string.Empty;                           // CI_Gender
        public string Outcome { get; set; } = string.Empty;              // AEC_One Row Outcomes
        public string Symptoms { get; set; } = string.Empty;           // SYM_One Row Coded Symptoms


    }
}


//A_Report #,RA_CAERS Created Date,AEC_Event Start Date,PRI_Product Role,PRI_Reported Brand/Product Name,PRI_FDA Industry Code
//PRI_FDA Industry Name,CI_Age at Adverse Event,CI_Age Unit,CI_Gender,AEC_One Row Outcomes,SYM_One Row Coded Symptoms