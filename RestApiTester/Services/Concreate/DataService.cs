using RestApiTester.Models.Requests;
using RestApiTester.Models.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTester.Services.Concreate
{
    public class DataService : IDataService
    {
        private static readonly RestClient client = new RestClient();

        public async Task<SearchResponse> Search(SearchRequest model)
        {
            try
            {
                var request = new RestRequest(AppConstants.GetSearch(model?.SearchName), DataFormat.None);

                return await client.GetAsync<SearchResponse>(request);
            }
            catch (Exception e) 
            {
                await LoggerService.Write("DataService", e.ToString());
                return null; 
            }
        }
    }
}
