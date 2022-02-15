
using System.ComponentModel.DataAnnotations.Schema;

namespace day2.Models

    
{


    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Grade { get; set; }
        [ForeignKey("Department")]
        public int dept_Id { get; set; }

        public virtual List<crsResult> crsResults { get; set; }
        public virtual Department Department { get; set; }


    }
}
