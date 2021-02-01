using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMmg.Models
{
    public class Course
    {

        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Date)]
        public String CourseDuration { get; set; }
    }
}
