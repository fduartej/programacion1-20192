using System;
using Microsoft.AspNetCore.Mvc;
using dotnet_web.models;

namespace dotnet_web.controllers
{

    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        
        // POST: Home/RegistrarFan
        [HttpPost]
        public IActionResult RegistrarFan(Follower follow){
            Console.WriteLine("RegistrarFan");
            int age =DateTime.Now.Year - follow.Birth.Year;
            Random  rnd = new Random();
            int numero = rnd.Next();
            follow.Age = age;

            _context.Add(follow);

            return View(follow);
        }
    }

}