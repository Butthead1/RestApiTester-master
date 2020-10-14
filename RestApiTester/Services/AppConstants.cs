using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiTester.Services
{
    public static class AppConstants
    {
        private const string BaseUrl = "https://docs.microsoft.com/";

        public static string GetSearch(string searchName) => $"{BaseUrl}api/search/rss?search={searchName}&locale=ru-ru&facet=";
    }
}
