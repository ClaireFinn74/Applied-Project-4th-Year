using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thYearAppliedProject
{
   public class JsonObjectsClass
    {
        public class Error
        {
            public string message { get; set; }
            public string type { get; set; }
            public int code { get; set; }
            public string fbtrace_id { get; set; }
        }

        public class Cover
        {
            public string cover_id { get; set; }
            public string source { get; set; }
            public int offset_y { get; set; }
            public int offset_x { get; set; }
        }

        public class RootObject
        {
            public Error error { get; set; }
            public string about { get; set; }
            public string category { get; set; }
            public string company_overview { get; set; }
            public bool is_published { get; set; }
            public string mission { get; set; }
            public string products { get; set; }
            public int talking_about_count { get; set; }
            public string username { get; set; }
            public string website { get; set; }
            public int were_here_count { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string link { get; set; }
            public int likes { get; set; }
            public Cover cover { get; set; }
        }
    }
}
