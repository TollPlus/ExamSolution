using ExamSolution.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSolution.Data
{
    public class SchoolManagamentContext : DbContext
    {
        public SchoolManagamentContext(DbContextOptions<SchoolManagamentContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<ClassDetailsModel> ClassDetails { get; set; }
        public DbSet<TeacherModelClass> Teachers { get; set; }
        public DbSet<StudentModelClass>  Students { get; set; }


    }
}
