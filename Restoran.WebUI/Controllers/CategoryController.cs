using Microsoft.AspNetCore.Mvc;

namespace Restoran.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetCategories()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("asdssd");
            if (responseMessage.IsSuccessStatusCode)
            {
                var json = responseMessage.Content.ReadAsStringAsync();
                
            }
            return View();
        }
    }
}
