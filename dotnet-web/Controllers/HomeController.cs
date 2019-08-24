using System;
using Microsoft.AspNetCore.Mvc;
using dotnet_web.models;

namespace dotnet_web.controllers
{

    public class HomeController:Controller{


        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        
        // POST: Home/RegistrarFan
        [HttpPost]
        public IActionResult RegistrarFan(Follower follow){
            Console.WriteLine("RegistrarFan");
            int age =DateTime.Now.Year - follow.Birth.Year;
            follow.Age = age;
            return View(follow);
        }
    }

}