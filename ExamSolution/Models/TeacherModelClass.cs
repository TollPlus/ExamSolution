using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSolution.Models
{
    public class TeacherModelClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherImage { get; set; }
        [ForeignKey("ClassId")]
        public int ClassId { get; set; }
        public ClassDetailsModel ClassDetailsModel { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
