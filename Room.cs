using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Upcasting_Downcasting_Enum__Exception
{
    //  Room class
    //- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda  avtomatik bir vahid artacaq.
    //- Name
    //- Price
    //- PersonCapacity - otağın neçə nəfərlik olduğunu bildirir.
    //- IsAvailable - otağın rezervasiya olunub olunmadığını göstərir (true/false), default olaraq true  olmalıdır.


    public class Room
    {
        private static int _counter = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string name, double price, byte personCapacity)
        {
            //ps: Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz
            Id = ++_counter;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = true;
        }
        public void ShowInfo()
        {
            //- ShowInfo() - Otağın bütün məlumatlarını göstərir
            Console.WriteLine($"Id - {Id}\r\nName - {Name}\r\nPrice - {Price}\r\nPerson Capacity - {PersonCapacity}\r\n{(IsAvailable ? "Available" : "Not Available")}");
        }
        public override string ToString()
        {
            //ToString methodunu override edirsiz və geriyə ShowInfo methodunu qaytarırsız.
            return $"Id - {Id}\r\nName - {Name}\r\nPrice - {Price}\r\nPerson Capacity - {PersonCapacity}\r\n{(IsAvailable ? "Available" : "Not Available")}";
        }
    }
}
