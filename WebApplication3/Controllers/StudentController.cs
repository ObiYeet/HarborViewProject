﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.HelperClasses;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentHome()
        {
            return View();
        }
        public ActionResult SearchSection()
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.createSectionSearchHelper());
        }

        public ActionResult SearchSectionResults()
        {
            return PartialView(new List<Section>());
        }
        [HttpPost]
        public ActionResult SearchSectionResults(String searchParameter, String searchType, String searchYear, String searchSemester)
        {
            return PartialView(WebApplication3.Models.StudentDbConnectionClass.searchSections(searchType, searchParameter, searchYear, searchSemester));
        }

        public ActionResult ViewHolds(String userID)
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.viewHolds(userID));
        }

        public ActionResult ViewAdvisor(String userID)
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.viewAdvisor(userID));
        }

        public ActionResult ViewSchedule()
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.createScheduleViewHelper());
        }
        
        //public ActionResult ViewScheduleResults()
        //{
        //    return View(new List<Enrollment>());
        //}
        [HttpPost]
        public ActionResult ViewScheduleResults(String userID, String year, String semester)
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.viewSchedule(userID, year, semester));
        }

        public ActionResult ViewCurrentSchedule(String userID, String year, String semester)
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.viewSchedule(userID, year, semester));
        }

        public ActionResult RegisterForClassesSelector()
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.createAddEnrollmentViewScheduleHelper());
        }

        public ActionResult RegisterForClasses(String searchParameter, String searchType, String searchYear, String searchSemester)
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.searchSections(searchType, searchParameter, searchYear, searchSemester));
        }

        public ActionResult RegisteredForClass(int studentID, int sectionID, String year, String season)
        {
            String result = "<script> alert(\"" + WebApplication3.Models.StudentDbConnectionClass.register(sectionID, studentID, year, season) + "\"); </script>";
            return View((object) result);
        }

        public ActionResult RemoveEnrollmentOptions()
        {
            return View(WebApplication3.Models.StudentDbConnectionClass.createScheduleViewHelper());
        }

        //public ActionResult RemoveEnrollmentResults()
        //{
        //    return View(new List<Section>());
        //}
        [HttpPost]
        public ActionResult RemoveEnrollmentResults(String userID, String year, String semester)
        {

            return View(WebApplication3.Models.StudentDbConnectionClass.submitDropClass(userID, year, semester));
        }

        public String RemoveEnrollment(int studentID, int sectionID, String semester, String year)
        {
            String result = "";// WebApplication3.Models.StudentDbConnectionClass.removeEnrollment(studentID, sectionID);
            return result;
        }
    }
}



