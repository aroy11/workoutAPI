﻿using System.ComponentModel.DataAnnotations;

namespace FSD.WorkoutTracker.Core.Entities
{
    public class Workout_Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
    }
}