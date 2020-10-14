using NUnit.Framework;
using RestApiTester.Models.Requests;
using RestApiTester.Services.Concreate;
using System.Threading.Tasks;

namespace RestApiTester.Test
{
    public class Tests
    {
        private DataService service;

        [SetUp]
        public void Setup()
        {
            service = new DataService();
        }

        [Test]
        public async Task IsSearchCorrect()
        {
            string searchName = "LINQ";
            var response = await service.Search(new SearchRequest { SearchName = searchName.ToLower() });
            if (response?.Channel?.Items != null)
            {
                var items = response.Channel.Items.Count;
                if (items > 50) items = 50;

                for (int i = 0; i < items; i++)
                {
                    bool res = response.Channel.Items[i].Description.ToLower().Contains(searchName.ToLower());
                    Assert.IsTrue(res, "пнахр");
                }
            }
        }
    }
}