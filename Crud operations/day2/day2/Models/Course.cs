
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace day2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int min_Degree { get; set; }
        [ForeignKey("Department")]
        public int dept_Id { get; set; }

        public virtual Department Department { get; set; }
        public virtual List<Instuctor> Instuctors { get; set; }
        public virtual List<crsResult> crsResults { get; set; }


    }
}


/*
 
 
 
        ItiSystem c =new ItiSystem();
        public IActionResult Index()
        {


            List<Instuctor> ins = c.instuctor.ToList();


            return View("Index",ins);
        }

        public IActionResult Detials(int id)
        {

            
            Instuctor ins1 =
                c.instuctor
                .Where(p => p.Id == id).FirstOrDefault();
            
            return View("Detials", ins1);
        }


    }
}
 
 
 */
