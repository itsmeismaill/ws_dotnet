using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webexemple
{
    /// <summary>
    /// Summary description for WebExemple
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebExemple : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a+b;
        }

        //create a webmethod that returns an Article List
        [WebMethod]
        public List<Article> GetArticles()
        {
            var arts = new List<Article>
            {
                new Article(1, "pain"),
                new Article(2, "pomme")
            };
            return arts;
        }

    }
}
