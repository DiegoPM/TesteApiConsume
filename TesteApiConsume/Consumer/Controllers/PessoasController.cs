using API.Models;
using Consumer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using Consumer.Views.Pessoas;

namespace Consumer.Controllers
{
    public class PessoasController : Controller
    {
     
        public IActionResult Index()
        {
            //var response = ApiCall.Get("https://localhost:44364/api/Pessoas");
            ////List<Pessoa> pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(response.Content.ReadAsStringAsync().Result);
            //var a = response.Content.ReadAsStringAsync().Result;
            return View();
        }
    }
}
