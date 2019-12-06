using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;

namespace Bookish.WebApp.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpPost]
        public ActionResult Search(SearchModel Form)
        
        {
            
            
        //select the book from searchbox
        var searchRepository = new BookRepository();

            var matches = new List<Book>();
            foreach (var item in searchRepository.GetBooks())

            {
                if (item.title.Contains(Form.title) || item.author.Contains(Form.title))

                {
                    matches.Add(item);

                }
            }

            //var matches2 = searchRepository.GetBooks().Where(item => Form.title.Contains(item.title)).ToList();

            return View(matches);
        }
    }
}
