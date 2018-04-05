using FSD.WorkoutTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutDAO
    {

        public bool CreateWorkoutCollection(Models.Workout workout)
        {
            bool addWorkoutStatus = false;
            using (var dbContext = new WorkoutContext())
            {
                Workout_Collection workoutCollection = new Workout_Collection()
                {
                    Calories_Burnt_Per_Min = workout.CaloriesBurntPerMinute,
                    Category_Id = workout.CategoryId,
                    Workout_Id = workout.WorkoutId,
                    Workout_Title = workout.WorkoutTitle,
                    Workout_Note = workout.WorkoutNote

                };

                dbContext.Workout_Collections.Add(workoutCollection);
                dbContext.SaveChanges();
                addWorkoutStatus = true;

                return addWorkoutStatus;
            }
        }

        public List<Models.Workout> GetActiveWorkouts(string name)
        {
            using (var dbContext = new WorkoutContext())
            {
                List<Workout_Collection> workoutCollection = dbContext.Workout_Collections.Where(i => (i.Workout_Title.StartsWith(name) || String.IsNullOrWhiteSpace(name))).ToList();
                List<Models.Workout> workouts = workoutCollection.Select(x => new Models.Workout() { WorkoutId = x.Workout_Id, WorkoutTitle = x.Workout_Title }).ToList();

                return workouts;
            }
        }
    }
}
