using System;
using Microsoft.AspNetCore.Mvc;
using dotnetproduct.models;

namespace dotnetproduct.controllers
{

    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index(){
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarProduct(Product product){

            _context.Add(product);
            _context.SaveChanges();

            return View("Resultado",product);
        }
    }

}