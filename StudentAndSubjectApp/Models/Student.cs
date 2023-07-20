using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StudentAndSubjectApp.Models
{
        public class Student
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? FirstName { get; set; }
            public string? Surname { get; set; }
            public string? Email { get; set; }
            [Display(Name = "Date of Birth")]
            [DataType(DataType.Date)]
            public DateTime DateOfBirth { get; set; }
        }
}

