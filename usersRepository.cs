using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
public class UsersRepository
{
    public User getUserById(int id)
    {
        var connectionString = "Server=tcp:kursazure.database.windows.net,1433;Initial Catalog=sqldb-kurs-azure-dev;Persist Security Info=False;User ID=testadmin;Password=kinvof-3cijca-kyvCuk;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        using (var connection = new SqlConnection(connectionString))
        {
            IEnumerable<User> queryResult = connection.Query<User>($"SELECT [Id], [FirstName], [LastName] FROM dbo.[Users] WHERE Id={id}");
            return queryResult.ToList().FirstOrDefault();
        }
    }
}