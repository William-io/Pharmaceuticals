using Dapper;
using Microsoft.Data.SqlClient;
using Pharmaceuticals.Models;

namespace Pharmaceuticals.Repository
{
    public class LaboratoryRepository : Repository<Laboratory>
    {
        private readonly SqlConnection _connection;
        public LaboratoryRepository(SqlConnection connection)
        : base(connection)
           => _connection = connection;

        public List<Laboratory> ReadWithRole()
        {
            var query = @"
                SELECT
                    [User].*,
                    [Role].*
                FROM
                    [User]
                    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                    LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var laboratories = new List<Laboratory>();
            var items = _connection.Query<Laboratory, Role, Laboratory>(
                query,
                (laboratory, role) =>
                {
                    var lab = laboratories.FirstOrDefault(x => x.Id == laboratory.Id);
                    if (lab == null)
                    {
                        lab = laboratory;
                        lab.Roles.Add(role);
                        laboratories.Add(lab);
                    }
                    else
                        lab.Roles.Add(role);

                    return laboratory;
                }, splitOn: "Id");
            return laboratories;
        }

        internal object GetWithRoles()
        {
            throw new NotImplementedException();
        }
    }

}