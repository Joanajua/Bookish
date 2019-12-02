using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Npgsql;

namespace Bookish.DataAccess
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            string connectionString = "Server=127.0.0.1; Port=5432; Database=bookish; User Id=bookish; Password=123";
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            var books = connection.Query<Book>("SELECT * FROM books");
            return books.ToList();
        }
    }
}
