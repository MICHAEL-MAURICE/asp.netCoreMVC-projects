using day2.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace day2.ViewModel
{
    public class inst_Mobel
    {
        public int id { get; set; }
        public string name { get; set; }

        public string adress { get; set; }
        public int salary { get; set; }
        public int Dept_Id { get; set; }
        public int Course_Id { get; set; }
        public string img_Name { get; set; }
        public List<Department> ins_dept { get; set; }
        public List<Course> inst_cors { get; set; }

        

        public IFormFile img { get; set; }

    }
}
