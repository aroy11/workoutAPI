using FSD.WorkoutTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FSD.WorkoutTracker.Controllers
{
    public class WorkoutsController : ApiController
    {
        // GET: api/Workouts
        public IEnumerable<Workout> Get()
        {
            return new List<Workout>() { new Workout() { WorkoutId = 1, CategoryId = 3 } };
        }

        // GET: api/Workouts/5
        public string Get(int id)
        {
            return "value";
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
