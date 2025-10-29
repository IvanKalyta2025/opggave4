using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opggave4.Models;

namespace opggave4.Controllers
{
    public class ReportController
    {
        private readonly List<FdaReport> _data;
        public ReportController(List<FdaReport> data)
        {
            _data = data;
        }

        public IEnumerable<string> SelectAllProdict;
        //iterate over the entire list using the method IEnumerable

        //.Where(contact => contact.Location == "Vestfold")
        //.Select(contact => new { Email = contact.Email, Name = contact.Name });

    }
}