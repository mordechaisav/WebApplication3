using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("product/{id}")]
        public string ggggg(int id, [FromQuery] bool hasItem = true)
        {
            return $"Product ID: {id}, Has Item: {hasItem.ToString().ToLower()}.";
        }

        [Route("order/confirm/{orderId}")]
        public string h(int orderId, [FromQuery] string status = "success")
        {
            return $"Order ID: {orderId}, Status: {status.First().ToString().ToUpper() + status.Substring(1).ToLower()}";
        }

        [Route("user/profile/{username}")]
        public string lll(string username, [FromQuery] int age = 30)
        {
            return $"Username: {username}, Age: {age}";
        }

        [Route("search/results")]
        public string SearchResults([FromQuery] string query, [FromQuery] int page = 1)
        {
            return $"Search Query: {query}, Page: {page}";
        }

        [Route("report/summary/{year}")]
        public string ReportSummary(int year, [FromQuery] string type = "annual")
        {
            return $"Year: {year}, Report Type: {type.First().ToString().ToUpper() + type.Substring(1).ToLower()}";
        }

        [Route("invoice/view/{invoiceId}")]
        public string ViewInvoice(int invoiceId, [FromQuery] bool paid = true)
        {
            return $"Invoice ID: {invoiceId}, Paid: {paid.ToString().ToLower()}";
        }

        [Route("store/item/{itemId}")]
        public string StoreItem(int itemId, [FromQuery] string category = "electronics")
        {
            return $"Item ID: {itemId}, Category: {category.First().ToString().ToUpper() + category.Substring(1).ToLower()}";
        }

        [Route("blog/post/{postId}")]
        public string BlogPost(int postId, [FromQuery] string title)
        {
            return $"Post ID: {postId}, Title: {title}";
        }

        [Route("checkout/process")]
        public string CheckoutProcess([FromQuery] int cartId, [FromQuery] bool discount = true)
        {
            return $"Cart ID: {cartId}, Discount Applied: {discount.ToString().ToLower()}";
        }

        [Route("location/details/{locationId}")]
        public string LocationDetails(string locationId, [FromQuery] string type = "city", [FromQuery] int population = 8000000)
        {
            return $"Location ID: {locationId}, Type: {type.First().ToString().ToUpper() + type.Substring(1).ToLower()}, Population: {population:N0}";
        }

      
        [Route("logUTMs")]
        public string LogUTMs([FromQuery] Dictionary<string, string> queryStrings)
        {
            return string.Join(", ", queryStrings.Select(q => $"{q.Key}: {q.Value}"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
