using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Collections.Generic;
using day2.Models;
using day2.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace day2.Controllers
{
    public class CoController:Controller
    {

         IHostingEnvironment host;
        public CoController(IHostingEnvironment host)
        {
            this.host = host;
        }


        ItiSystem cooo = new ItiSystem();


       Instuctor instractor=new Instuctor();

       

        public IActionResult TrIndex()
        {

          
            var result = cooo.crsResults.Include(c => c.Course).Include(t => t.Trainee).ToList();

            List<TranieeStudentDegree> myModel = new List<TranieeStudentDegree>();
            foreach (var r in result)
            {
                myModel.Add(new TranieeStudentDegree());
            }
                int i = 0;
            foreach (var r in result)
            {
                
                myModel[i].Degree = result[i].Degree;
                myModel[i].Trename = result[i].Trainee.Name;
                if (result[i].Degree > r.Course.min_Degree)
                {
                   
                    myModel[i].Status = true;
                }
                else
                {
                    
                    myModel[i].Status = false;
                }
                i++;
            }

            return View("TrIndex",myModel);


        
        }



        public IActionResult TrDetials(int id)
        {

            
           

                crsResult result = cooo.crsResults.Include(c => c.Course).Include(t => t.Trainee)
                    .Where(s => s.trainee_ID == id).FirstOrDefault();

                TranieeStudentDegree myModel = new TranieeStudentDegree();
                myModel.Degree = result.Degree;
                myModel.Trename = result.Trainee.Name;

                if (result.Degree > result.Course.min_Degree)
                {
                    myModel.Status = true;
                    
                }
                else
                {
                    myModel.Status = false;
                  
                }

                return View("TrDetials",myModel);
               
        }

        public IActionResult Index()
        {


            List<Instuctor> ins = cooo.instuctors.ToList();


            return View("Index", ins);
        }


        public IActionResult Detials(int id)
        {

            Instuctor ins1 =
                cooo.instuctors
                .Where(p => p.Id == id).FirstOrDefault();

           
                return View("Detials", ins1);
            
           

        }

        public IActionResult Update_ins(int id)
        {
            Instuctor ins1 =
               cooo.instuctors
               .Where(p => p.Id == id).FirstOrDefault();
            List<Department> ins_dept = cooo.departments.ToList();
            List<Course> inst_cors = cooo.courses.ToList();

            inst_Mobel insttt = new inst_Mobel() { adress = ins1.Address, name = ins1.Name, Course_Id = ins1.crs_Id,

                Dept_Id = ins1.dept_Id, salary = ins1.Salary, img_Name = ins1.Image, inst_cors = inst_cors, ins_dept = ins_dept
            , id = ins1.Id
            };
            

            return View("Details_ins", insttt);
        }

        //Save_updae
        public IActionResult Save_updae(int id, inst_Mobel inst)
        {



            Instuctor ins1 =
              cooo.instuctors
              .Where(p => p.Id == id).FirstOrDefault();
            if (inst != null)
            {
                if (inst.img != null)

                {

                    string imgpath = Path.Combine(host.WebRootPath, "imgs");
                    string file_name = inst.img.FileName;
                    inst.img.CopyTo(new FileStream(Path.Combine(imgpath, file_name), FileMode.Create));
                    ins1.Image = file_name;
                    inst.img_Name = file_name;
                }
                else
                {
                    ins1.Image = inst.img_Name;
                }
                ins1.Name = inst.name;
                ins1.Address = inst.adress;
              
                ins1.dept_Id = inst.Dept_Id;
                ins1.crs_Id = inst.Course_Id;
                ins1.Salary = inst.salary;

                
                cooo.SaveChanges();
                return RedirectToAction("Index");

            }



            return View();
        }

        public IActionResult Delete(int id) {

            Instuctor ins1 =
             cooo.instuctors
             .Where(p => p.Id == id).FirstOrDefault();
            cooo.instuctors.Remove(ins1);
            cooo.SaveChanges(); 
            
            return RedirectToAction("Index");
            

        }

        public IActionResult Add_ins()
        {
            List<Department> ins_dept = cooo.departments.ToList();
            List<Course> inst_cors=cooo.courses.ToList();


            return View("Add_ins",new inst_Mobel() { ins_dept=ins_dept,inst_cors=inst_cors});

        }

        public IActionResult Save_ins(inst_Mobel inst)
        {

            if (inst.img != null&& inst.name!=null &&inst.adress!=null)
            {
                string imgpath = Path.Combine(host.WebRootPath, "imgs");
                string file_name = inst.img.FileName;
                inst.img.CopyTo(new FileStream(Path.Combine(imgpath, file_name), FileMode.Create));

                instractor.Name=inst.name;
                instractor.Address = inst.adress;
                instractor.Image = file_name;
                instractor.dept_Id = inst.Dept_Id;
                instractor.crs_Id = inst.Course_Id;
                instractor.Salary = inst.salary;

                cooo.instuctors.Add(instractor);
                cooo.SaveChanges();
                return RedirectToAction("Index");

            }



            return View("Add_ins",inst);
        }




        }
}
 


    
