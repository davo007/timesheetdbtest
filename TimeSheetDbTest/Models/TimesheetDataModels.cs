﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeSheetDbTest.Models
{
    public class TimesheetDataModels
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime WeekEndingDate { get; set; }
        public int JobNumber { get; set; }
        public string Package { get; set; }
        public string Activity { get; set; }
        public int NCR { get; set; }
        public int Variation { get; set; }
        public int MondayTime { get; set; }
        public int TuesdayTime { get; set; }
        public int WednesdayTime { get; set; }
        public int ThursdayTime { get; set; }
        public int FridayTime { get; set; }
        public int SaturadayTime { get; set; }
        public int SundayTime { get; set; }
    }
}