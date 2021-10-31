using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace myapp.Controllers
{
    public class HelloWorldController
    {
        public IActionResult Index(){
            return View();
        }


        public string Welcome(string name, int ID = 1){
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}