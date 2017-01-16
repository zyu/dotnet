using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using testdb.Model;
using testdb.Data;
namespace testdb.Controllers
{
    public class TeeController : Controller
    { 


        private ApplicationDbContext _context;
        public TeeController(ApplicationDbContext context){
            this._context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            
                var students = new Student[]
                {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Now},
                new Student{FirstMidName="where '' 1=1",LastName="Olivetto",EnrollmentDate=DateTime.Now}
                };
                foreach (Student s in students)
                {
                    _context.Students.Add(s);
                     
               
                for(var i = 0 ; i< 100 ;i++){
                   
                    var merchant = new Merchant{

                        ActivateTime = DateTime.Now,
                        Contacter ="420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响420.52 [Kbytes/sec] received 平均每秒网络上的流量，可以帮助排除是否存在网络流量过大导致响"
                    };
                    _context.Merchants.Add(merchant);
                         
                }
                }

                _context.SaveChanges(); 
                
            return View(); 
        }  
    }
}
