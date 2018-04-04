using FSD.WorkoutTracker.DataAccess.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext()
            : base("name = WorkoutConnection")
        {
        }
        public virtual DbSet<Workout_Active> ActiveWorkouts { get; set; }
        public virtual DbSet<Workout_Collection> Workouts { get; set; }
        public virtual DbSet<Workout_Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}