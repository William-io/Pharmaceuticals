using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Pharmaceuticals.Models;

namespace Pharmaceuticals.Repository
{
    public class LaboratoryRepository
    {
        private readonly SqlConnection _connection;
        public LaboratoryRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<Laboratory> Get()
            => _connection.GetAll<Laboratory>();
        public Laboratory Insert(int id)

            => _connection.Get<Laboratory>(id);
        public void Create(Laboratory laboratory)
            => _connection.Insert<Laboratory>(laboratory);
    }
}