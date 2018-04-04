using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.WorkoutTracker.Models
{
    public class WorkoutCategory
    {
        public WorkoutCategory()
        {
            Workouts = new List<Workout>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Workout> Workouts { get; set; }
    }

}
