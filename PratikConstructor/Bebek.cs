using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikConstructor
{
    
    public class Bebek
    {
       public string name {  get; set; }
       public string surname {  get; set; }
       public DateTime birthDate { get; set; }
        //default olan constructor
        public Bebek()
        {
            birthDate = DateTime.Now;
            name = "Bilinmeyen ad";
            surname = "Bilinmeyen Soyad";
            Console.WriteLine("Ingaaaaaaaaaaaa");
        }
        //Parametre alan constructor
       public Bebek(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
            birthDate = DateTime.Now;
            Console.WriteLine("Ingaaaaaaaaaaaa");
        }
    }
}
