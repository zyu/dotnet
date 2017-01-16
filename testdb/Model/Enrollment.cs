using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; 
namespace testdb.Model
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; } 
        public int StudentID { get; set; }
      
        public Grade? Grade { get; set; }
 
        public Student Student { get; set; }
    }
}
