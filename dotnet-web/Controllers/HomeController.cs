using System;
using Microsoft.AspNetCore.Mvc;
using dotnet_web.models;

using System.Linq;

namespace dotnet_web.controllers
{

    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index(){
            return View(_context.Followers.ToList());
        }
        
        public IActionResult Create(){
            return View();
        }

        public IActionResult Details(int? id){

           if (id == null)
            {
                return NotFound();
            }

            var follower = _context.Followers
                .SingleOrDefault(m => m.ID == id);
            if (follower == null)
            {
                return NotFound();
            }

            return View(follower);
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
            _context.SaveChanges();

            return View(follow);
        }
    }

}