using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StudentAndSubjectApp.Controllers
{
    public class UniversityController : Controller
    {
        public IActionResult AllCourses()
        {
            using (HttpClient client = new HttpClient())
            {
                string jsonUrl = "https://www.liverpool.ac.uk/app-data/study-abroad/courses.json";

                    HttpResponseMessage response = client.GetAsync(jsonUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {   
                        string jsonContent = response.Content.ReadAsStringAsync().Result;
                        var universityData = JsonConvert.DeserializeObject<List<Models.University>>(jsonContent);
                        return View(universityData);
                    }

                        else
                        {
                            return View("Error");
                        }
            }

        }
        
    }
}


