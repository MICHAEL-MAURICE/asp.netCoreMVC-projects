
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace day2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }


        public virtual List<Instuctor> Instuctors { get; set; }
        public virtual List<Course> Courses { get; set; }

        public virtual List<Trainee> Trainees { get; set; }

    }
}
