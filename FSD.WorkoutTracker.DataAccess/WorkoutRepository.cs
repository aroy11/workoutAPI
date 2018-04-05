using FSD.Workout.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutRepository : IWorkoutRepository
    {
        WorkoutContext context = new WorkoutContext();

        public void Add(Core.Entities.Workout_Active b)
        {
            context.Workout_Actives.Add(b);
            context.SaveChanges();
        }



        public void Edit(Core.Entities.Workout_Active b)
        {
            context.Entry(b).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(string Id)
        {
            Core.Entities.Workout_Active b = context.Workout_Actives.Find(Id);
            context.Workout_Actives.Remove(b);
            context.SaveChanges();
        }



        public IEnumerable<Core.Entities.Workout_Active> GetActiveWorkouts()
        {
            return context.Workout_Actives;
        }


        public Core.Entities.Workout_Active FindById(int Id)
        {
            var c = (from r in context.Workout_Actives where r.Id == Id select r).FirstOrDefault();

            return c;
        }

    }
}
