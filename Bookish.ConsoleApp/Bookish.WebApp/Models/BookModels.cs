using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish
{
    public class BookModel
    {
       public int book_id { get; set; }
       public string title { get; set; }
       public string author { get; set; }
       public string isbn { get; set; }
       public int total_copies { get; set; }

    }
}
