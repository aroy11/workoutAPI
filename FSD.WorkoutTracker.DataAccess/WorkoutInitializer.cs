namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutTrackerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WorkoutContext>
    {
        protected override void Seed(WorkoutContext context)
        {
            //var workouts = new List<Workout>
            //{
            //new Workout{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //new Workout{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Workout{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Workout{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Workout{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Workout{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            //new Workout{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Workout{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            //};

            //workouts.ForEach(s => context.Workouts.Add(s));
            //context.SaveChanges();

            //var categories = new List<WorkoutCategory>
            //{
            //new WorkoutCategory{CourseID=1050,Title="Chemistry",Credits=3,},
            //new WorkoutCategory{CourseID=4022,Title="Microeconomics",Credits=3,},
            //new WorkoutCategory{CourseID=4041,Title="Macroeconomics",Credits=3,},
            //new WorkoutCategory{CourseID=1045,Title="Calculus",Credits=4,},
            //new WorkoutCategory{CourseID=3141,Title="Trigonometry",Credits=4,},
            //new WorkoutCategory{CourseID=2021,Title="Composition",Credits=3,},
            //new WorkoutCategory{CourseID=2042,Title="Literature",Credits=4,}
            //};
            //categories.ForEach(s => context.Categories.Add(s));
            //context.SaveChanges();          
        }
    }
}