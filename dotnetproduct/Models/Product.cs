using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetproduct.models
{

    public class Product{

        public int ID { get; set; }
        public String Name {get; set;}
        public String Category {get; set;} 
        public String Production {get; set;} 

        public Double Price {get; set;} 

        
    }

}