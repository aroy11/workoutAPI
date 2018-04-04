using FSD.WorkoutTracker.DataAccess;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FSD.WorkoutTracker.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoriesController : ApiController
    {
        CategoryDAO _categoryDAO = new CategoryDAO();

        [HttpGet]
        public string GetCategories(int id)
        {
            return _categoryDAO.GetCategories();
        }

        [HttpPost]
        public void AddCategories([FromBody]string value)
        {
        }
    }
}
