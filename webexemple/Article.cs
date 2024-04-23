using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webexemple
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Article(int id, string title )
        {
            Id = id;
            Title = title;
        }
        public Article()
        {

        }
    }
}