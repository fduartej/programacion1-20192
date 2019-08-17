using System;
using Microsoft.AspNetCore.Mvc;
using dotnet_web.models;

namespace dotnet_web.controllers
{

    public class HomeController:Controller{

        [HttpPost]
        public IActionResult RegistrarFan(Follower follow){
            return View("myview");
        }
    }

}