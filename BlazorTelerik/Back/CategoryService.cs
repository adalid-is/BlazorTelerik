using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using BlazorTelerik.Back;

namespace BlazorTelerik.Back
{
    public class CategoryService
    {
        private HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public Task<IEnumerable<CategoryDto>> GetCategories()
        {
            return _http.GetFromJsonAsync<IEnumerable<CategoryDto>>("https://demos.telerik.com/blazor-ui-service/api/Category/GetCategories");
        }
    }
}