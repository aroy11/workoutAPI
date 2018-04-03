using FSD.WorkoutTracker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutCategory> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}