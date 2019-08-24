using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_web.models
{

    public class Follower{

        public String Name {get; set;}
        public String Email {get; set;}

        [DataType(DataType.Date)]
        public DateTime Birth {get; set;}

        public int Age {get; set;}
    }

}