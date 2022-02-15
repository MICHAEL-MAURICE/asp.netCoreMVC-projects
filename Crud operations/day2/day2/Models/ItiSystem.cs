using Microsoft.EntityFrameworkCore;

 namespace day2.Models

{
    public class ItiSystem:DbContext
    {
        public DbSet<Trainee> trainee { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instuctor> instuctors { get; set; }
        public DbSet<crsResult> crsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITIday2;Integrated Security=True");
        }

    }
}
