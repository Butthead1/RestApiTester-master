using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiTester.Models.Requests
{
    public class SearchRequest : Request
    {
        public string SearchName { get; set; }
    }

    public class Request
    {
    }
}
