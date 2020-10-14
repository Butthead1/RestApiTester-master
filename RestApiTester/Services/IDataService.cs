using RestApiTester.Models.Requests;
using RestApiTester.Models.Responses;
using System.Threading.Tasks;

namespace RestApiTester.Services
{
    interface IDataService
    {
        Task<SearchResponse> Search(SearchRequest model);
    }
}
