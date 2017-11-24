using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.ClubModel
{
    [Table("Course")]
    class Course
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int CourseID { get; set; }

        [Display(Name = "Course Code")]
        public String CourseCode { get; set; }

        [Display(Name = "Course Year")]
        public String Year { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
    }
}
