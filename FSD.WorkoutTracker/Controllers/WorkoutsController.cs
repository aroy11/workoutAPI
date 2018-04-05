using FSD.WorkoutTracker.Core.Entities;
using FSD.WorkoutTracker.DataAccess;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FSD.WorkoutTracker.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WorkoutsController : ApiController
    {

        private IRepository<Workout_Active> _workoutRepository = null;
        public WorkoutsController()
        {
            this._workoutRepository = new Repository<Workout_Active>();
        }

        public WorkoutsController(IRepository<Workout_Active> workoutRepository)
        {
            this._workoutRepository = workoutRepository;
        }

        // GET: api/Workouts
        public IEnumerable<Workout_Active> Get()
        {
            return _workoutRepository.GetAll();
        }

        // GET: api/Workouts/5
        public Workout_Active Get(int id)
        {
            return new Workout_Active();
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
