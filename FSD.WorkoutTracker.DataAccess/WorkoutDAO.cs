using FSD.WorkoutTracker.DataAccess.Entities;
using FSD.WorkoutTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutDAO
    {

        public bool CreateWorkoutCollection(Workout workout)
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

                dbContext.Workouts.Add(workoutCollection);
                dbContext.SaveChanges();
                addWorkoutStatus = true;

                return addWorkoutStatus;
            }
        }

        public List<Workout> GetActiveWorkouts(string name)
        {
            using (var dbContext = new WorkoutContext())
            {
                List<Workout_Collection> workoutCollection = dbContext.Workouts.Where(i => (i.Workout_Title.StartsWith(name) || String.IsNullOrWhiteSpace(name))).ToList();
                List<Workout> workouts = workoutCollection.Select(x => new Workout() { WorkoutId = x.Workout_Id, WorkoutTitle = x.Workout_Title }).ToList();

                return workouts;
            }
        }
    }
}
