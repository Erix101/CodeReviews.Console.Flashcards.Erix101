using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Flashcards.Erix101
{
    internal class DataAccess
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        private string _connectionString;

        public DataAccess()
        {
            _connectionString = configuration.GetSection("ConnectionStrings")["DefaultConnection"];
        }

        internal void CreateDatabase()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

            }
        }


    }
}
