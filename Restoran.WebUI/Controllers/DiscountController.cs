using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restoran.WebUI.ViewModels.DiscountViewModels;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.WebUI.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DiscountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("link");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDiscountViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateDiscount()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountViewModel createDiscountViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createDiscountViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("link", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"link/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction();
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateDiscount(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"link/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateDiscountViewModel>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountViewModel updateDiscountViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateDiscountViewModel);
            StringContent stringContent = new(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("link", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        //[HttpGet]   
        //public async Task<ActionResult> GetDiscount(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"link{id}");
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var value = JsonConvert.DeserializeObject<GetDiscountViewModel>(jsonData);
        //        return View(value); 
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
