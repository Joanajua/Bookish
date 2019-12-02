using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=127.0.0.1; Port=5432; Database=bookish; User Id=bookish; Password=123";
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            var books = connection.Query<Book>("SELECT * FROM books");

            Console.ReadLine();
        }
        
    }
   

}
