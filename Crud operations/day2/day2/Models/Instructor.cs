using System.ComponentModel.DataAnnotations.Schema;

namespace day2.Models
{
    public class Instuctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        [ForeignKey("Department")]
        public int dept_Id { get; set; }

        [ForeignKey("Course")]
        public int crs_Id { get; set; }


        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }

    }
}
