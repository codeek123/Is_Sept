using AdminApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminApplication.Controllers
{
    public class SemestersController : Controller
    {
        
            public IActionResult Index()
            {
                HttpClient client = new HttpClient();
                string URL = "https://localhost:7286/api/Admin/GetSemesters";

                HttpResponseMessage response = client.GetAsync(URL).Result;
                var data = response.Content.ReadAsAsync<List<Semester>>().Result;
                return View(data);
            }
        
    }
}
