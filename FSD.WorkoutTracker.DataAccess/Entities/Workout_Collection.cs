using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSD.WorkoutTracker.DataAccess.Entities
{
    public class Workout_Collection
    {
        [Key]
        public int Workout_Id { get; set; }
        public string Workout_Title { get; set; }
        public string Workout_Note { get; set; }
        public double? Calories_Burnt_Per_Min { get; set; }
        public int Category_Id { get; set; }

        [Key, ForeignKey("Category_Id")]
        public virtual Workout_Category WorkoutCategory { get; set; }
    }

}