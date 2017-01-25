using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSheetDbTest.Models;

namespace TimeSheetDbTest.ViewModels
{
    public class PackagesViewModel
    {
        public int Id { get; set; }
        public IEnumerable<PackagesModels> Packages { get; set; }
    }
}