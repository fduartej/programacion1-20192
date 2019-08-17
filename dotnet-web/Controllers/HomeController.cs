using System;
using Microsoft.AspNetCore.Mvc;
using dotnet_web.models;

namespace dotnet_web.controllers
{

    public class HomeController:Controller{

        [HttpPost]
        public IActionResult RegistrarFan(Follower follow){
            int age =DateTime.Now.Year - follow.Birth.Year;
            return View("myview");
        }
    }

}