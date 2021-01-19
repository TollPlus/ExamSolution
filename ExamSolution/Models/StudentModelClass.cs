using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSolution.Models
{
    public class StudentModelClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentImage { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public char Grade { get; set; }
        [ForeignKey("ClassId")]
        public int ClassId { get; set; }
        public ClassDetailsModel ClassDetailsModel { get; set; }
        [Required]
        public string Section { get; set; }
    }
}
