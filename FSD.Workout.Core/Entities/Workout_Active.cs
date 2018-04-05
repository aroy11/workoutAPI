using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSD.WorkoutTracker.Core.Entities
{
    public class Workout_Active
    {
        [Key]
        public int Id { get; set; }
        public int Workout_Id { get; set; }
        public DateTime? Start_Time { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public DateTime? End_Time { get; set; }
        public string Comment { get; set; }
        public bool? Status { get; set; }

        [Key, ForeignKey("Workout_Id")]
        public virtual Workout_Collection WorkoutCollection { get; set; }

    }

}
