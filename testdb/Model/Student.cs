using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; 
namespace testdb.Model
{
    public class Student
    {
       public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Secret { get; set; }

        private DateTime addTime = DateTime.Now;

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime
        {
            get { return addTime; }
            set { addTime = value; }
        }
        
        }
    
} 