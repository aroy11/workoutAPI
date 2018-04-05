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

        private IRepository<Workout_Active> _activeWorkoutsRepository = null;
        private IRepository<Workout_Collection> _workoutsRepository = null;

        #region Constructors
        public WorkoutsController()
        {
            this._activeWorkoutsRepository = new Repository<Workout_Active>();
            this._workoutsRepository = new Repository<Workout_Collection>();
        }

        public WorkoutsController(IRepository<Workout_Active> activeWorkoutsRepository)
        {
            this._activeWorkoutsRepository = activeWorkoutsRepository;
            this._workoutsRepository = new Repository<Workout_Collection>();
        }

        public WorkoutsController(IRepository<Workout_Collection> workoutRepository)
        {
            this._activeWorkoutsRepository = new Repository<Workout_Active>();
            this._workoutsRepository = workoutRepository;
        }

        public WorkoutsController(IRepository<Workout_Collection> workoutRepository, IRepository<Workout_Active> activeWorkoutsRepository)
        {
            this._activeWorkoutsRepository = activeWorkoutsRepository;
            this._workoutsRepository = workoutRepository;
        }
        #endregion

        [Route("api/GetWorkouts")]
        [HttpGet]
        public IEnumerable<Workout_Collection> GetWorkouts()
        {
            return _workoutsRepository.GetAll();
        }

        [HttpGet]
        [Route("api/GetWorkout/{id}")]
        public Workout_Collection Get(int id)
        {
            return _workoutsRepository.GetById(id);
        }

        [HttpPost]
        [Route("api/AddWorkout")]
        public void AddWorkout([FromBody]Workout_Collection workout)
        {
            _workoutsRepository.Insert(workout);
        }

        [HttpPut]
        [Route("api/EditWorkout")]
        public void EditWorkout([FromBody]Workout_Collection workout)
        {
            _workoutsRepository.Update(workout);
        }

        [HttpDelete]
        [Route("api/DeleteWorkout/{id}")]
        public void Delete(int id)
        {
            _workoutsRepository.Delete(id);
        }

        [HttpPost]
        [Route("api/StartWorkout")]
        public void StartWorkout([FromBody]Workout_Active workout)
        {
            _activeWorkoutsRepository.Insert(workout);
        }

        [HttpPost]
        [Route("api/EndWorkout")]
        public void EndWorkout([FromBody]Workout_Active workout)
        {
            _activeWorkoutsRepository.Insert(workout);
        }
    }
}
