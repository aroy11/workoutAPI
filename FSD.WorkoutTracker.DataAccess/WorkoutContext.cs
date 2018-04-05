using FSD.WorkoutTracker.Core.Entities;
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
        public virtual DbSet<Workout_Active> Workout_Actives { get; set; }
        public virtual DbSet<Workout_Collection> Workout_Collections { get; set; }
        public virtual DbSet<Workout_Category> Workout_Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}