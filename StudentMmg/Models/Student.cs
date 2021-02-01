using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMmg.Models
{
    public class Student
    {

        [Key]
        public int StudentID { get; set; }
        public string Studentname { get; set; }
        
        public string StudentDoB { get; set; }
        public string StudentAddress { get; set; }
    }
}
