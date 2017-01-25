using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSheetDbTest.Models;

namespace TimeSheetDbTest.ViewModels
{
    public class ActivitiesViewModel
    {
        public int Id { get; set; }
        public IEnumerable<ActivitiesModels> Activities { get; set; }
    }
}