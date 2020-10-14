using RestApiTester.Models.Requests;
using RestApiTester.Models.Responses;
using RestApiTester.Services.Concreate;
using System;
using System.Threading.Tasks;

namespace RestApiTester
{
    class Program
    {
        private static DataService Service = new DataService();

        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
            Console.ReadKey();
        }

        public static async Task MainAsync(string[] args)
        {
            var response = await Service.Search(new SearchRequest { SearchName = "LINQ".ToLower() });

            if (response?.Channel?.Items != null)
            {
                foreach (var item in response.Channel.Items)
                {
                    Console.WriteLine(item.Description + "\n");
                }
                Console.WriteLine(response.Channel.Items.Count);
            }
        }
    }
}
