using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace FSD.WorkoutTracker.DataAccess
{
    public class WorkoutConfiguration : DbConfiguration
    {
        public WorkoutConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}