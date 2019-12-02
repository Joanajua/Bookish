using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Bookish.DataAccess;
using Dapper;
using Npgsql;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new BookRepository();

            
             
            foreach (var item in repository.GetBooks())
            {
                
                Console.WriteLine($"Book ID: {item.book_id}, Title: {item.title}, Author: {item.author}, ISBN: {item.isbn}, Total copies: {item.total_copies}");

            }

            Console.ReadLine();
        }
        
    }
   

}
