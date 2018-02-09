using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iAttendeded.Models;

namespace iAttended.Models.ViewModels
{
    public class StudentViewModel
    {
        public List<Student> Student { get; set; }
        public List<Course> Courses { get; set; }
    }
}