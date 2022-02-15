using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace day2.Models
{
    public class crsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int crs_ID { get; set; }
        [ForeignKey("Trainee")]
        public int trainee_ID { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }


    }
}
