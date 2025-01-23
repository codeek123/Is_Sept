using AdminApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminApplication.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            string URL = "https://localhost:7286/api/Admin/GetStudents";

            HttpResponseMessage response = client.GetAsync(URL).Result;
            var data = response.Content.ReadAsAsync<List<Student>>().Result;
            return View(data);
        }
    }
}
