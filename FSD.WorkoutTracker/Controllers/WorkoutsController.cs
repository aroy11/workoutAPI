using FSD.WorkoutTracker.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FSD.WorkoutTracker.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WorkoutsController : ApiController
    {
        // GET: api/Workouts
        public IEnumerable<Workout> Get()
        {
            return new List<Workout>() { new Workout() { WorkoutId = 1, CategoryId = 3 } };
        }

        // GET: api/Workouts/5
        public Workout Get(int id)
        {
            return new Workout() { WorkoutId = 1, Category = new WorkoutCategory() { CategoryId = 5 } };
        }

        // POST: api/Workouts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Workouts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Workouts/5
        public void Delete(int id)
        {
        }
    }
}
