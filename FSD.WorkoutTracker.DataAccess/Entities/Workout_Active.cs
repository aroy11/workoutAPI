using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD.WorkoutTracker.DataAccess.Entities
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

        [Key, ForeignKey("workout_id")]
        public virtual Workout_Collection WorkoutCollection { get; set; }

    }

}
