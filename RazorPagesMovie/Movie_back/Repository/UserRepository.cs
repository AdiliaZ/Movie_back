using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie_Back.Models;
using Npgsql;
using Dapper;

namespace Movie_back.Repository
{
    public class UserRepository
    {
        private string connectionString = "User ID=postgres; Password=podrostok01092001; Server=127.0.0.1; Port=5432; Database=movie_bd";

        public async Task AddUser(User user, string password)
        {
            await using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                connection.Execute(
                    "insert into users (email, password, is_member) values (@Email, @Password, @IsMember)",
                    new { Email = user.Email, Password = password, IsMember = user.IsMember});

            }
        
        }
    }
}
