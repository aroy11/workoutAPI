using FSD.WorkoutTracker.Core.Entities;
using FSD.WorkoutTracker.DataAccess;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FSD.WorkoutTracker.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        private IRepository<Workout_Category> _categoryRepository = null;
        public CategoriesController()
        {
            this._categoryRepository = new Repository<Workout_Category>();
        }

        public CategoriesController(IRepository<Workout_Category> categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IEnumerable<Workout_Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }

        [HttpPost]
        public Workout_Category AddCategories([FromBody]Workout_Category category)
        {
            return _categoryRepository.Insert(category);
        }


        public void Put([FromBody]Workout_Category category)
        {
            _categoryRepository.Update(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
}
