using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutDBInitialize : DropCreateDatabaseIfModelChanges<WorkoutContext>
    {

        protected override void Seed(WorkoutContext context)
        {

            context.Workout_Categories.Add(
                  new Core.Entities.Workout_Category
                  {
                      Category_Id = 1,
                      Category_Name = "Jogging"
                  });

            context.Workout_Categories.Add(
                 new Core.Entities.Workout_Category
                 {
                     Category_Id = 2,
                     Category_Name = "Sprint"

                 });

            context.Workout_Categories.Add(
                 new Core.Entities.Workout_Category
                 {
                     Category_Id = 3,
                     Category_Name = "Slow Walk"
                 });

            context.Workout_Categories.Add(
                new Core.Entities.Workout_Category
                {
                    Category_Id = 4,
                    Category_Name = "Cardio"
                });

            context.Workout_Categories.Add(
                new Core.Entities.Workout_Category
                {
                    Category_Id = 5,
                    Category_Name = "Aerobics"
                });

            context.Workout_Categories.Add(
                new Core.Entities.Workout_Category
                {
                    Category_Id = 6,
                    Category_Name = "Yoga"
                });



            context.SaveChanges();

            base.Seed(context);
        }

    }
}
