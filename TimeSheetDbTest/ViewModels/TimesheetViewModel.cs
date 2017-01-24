using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TimeSheetDbTest.Models;

namespace TimeSheetDbTest.ViewModels
{
    public class TimesheetViewModel
    {
        [Display(Name = "Job Number")]
        public int JobNumberId { get; set; }
        
        public IEnumerable<JobNumberModels> JobNumber { get; set; }

        
    }
}