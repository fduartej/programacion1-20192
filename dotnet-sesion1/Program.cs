using System;

namespace dotnet_sesion1
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            String name;
            String password;
            int edad;
            
            Console.WriteLine("My App! ");
            Console.WriteLine("Ingrese su nombre: ");
            name=Console.ReadLine();
            Console.WriteLine("Ingrese su password: ");
            password=Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello {0}",name);
            if(edad>18){
               Console.WriteLine("Puede Beber!");     
            }else{
               Console.WriteLine("No debe Beber!");      
            }
        }
    }
}
