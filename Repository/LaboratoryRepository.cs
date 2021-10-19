using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Pharmaceuticals.Models;

namespace Pharmaceuticals.Repository
{
    public class LaboratoryRepository
    {
        public IEnumerable<Laboratory> Get()
        {
            using (var connection = new SqlConnection())
            {
                return connection.GetAll<Laboratory>();
            }
        }
    }
}