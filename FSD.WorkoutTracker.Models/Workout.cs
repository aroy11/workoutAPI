using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.WorkoutTracker.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public string WorkoutTitle { get; set; }
        public string WorkoutNote { get; set; }
        public float CaloriesBurntPerMinute { get; set; }
        public int CategoryId { get; set; }
        public WorkoutCategory Category { get; set; }
    }

}
