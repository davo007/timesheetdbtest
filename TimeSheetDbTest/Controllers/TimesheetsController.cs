using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheetDbTest.Models;
using TimeSheetDbTest.ViewModels;


namespace TimeSheetDbTest.Controllers
{
    public class TimesheetsController : Controller
    {

        private InteracctDataContext _context;
        private ApplicationDbContext _context2;

        public TimesheetsController()
        {
            _context = new InteracctDataContext();
            _context2 = new ApplicationDbContext();
        }

        // GET: Timesheets
        public ActionResult Index()
        {
            
            var JobNumbers = _context.GetJobNumbers();



            IEnumerable<JobNumberModels> JobNumbersList = JobNumbers.Select(x => new JobNumberModels
            {

                Id = (int)x.Job_No__JOB_,
                JobNumber = (int)x.Job_No__JOB_

            }).ToList();

            //IEnumerable<GetJobNumbersResult> JobNumbersList = JobNumbers.Select(x => new GetJobNumbersResult
            //{

            //    Id = (int)x.Job_No__JOB_,
            //    Job_No__JOB_ = (int)x.Job_No__JOB_

            //}).ToList();

            var viewModel = new TimesheetViewModel
            {
                
                JobNumber = JobNumbersList
            };
                        
            return View(viewModel);
        }
    }
}