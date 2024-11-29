using System;
using System.Runtime.ConstrainedExecution;

namespace Upcasting_Downcasting_Enum__Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            //Program class

            //1. İki ədəd room obyekti yaradırsız daha sonra bir hotel obyekti yaradırsız hotel obyektinin içindəki AddRoom methodu vasitəsilə yaratdığınız iki room
            //obyektini hoteldəki rooms arrayinə əlavə edirsiz.

            Room room1 = new Room("Earth", 22.22, 20);
            Room room2 = new Room("Jupiter", 33.33, 18);

            Hotel hotel = new Hotel("Ganja");
            hotel.AddRoom(room1);
            room1.IsAvailable = false;
            hotel.AddRoom(room2);

            //2. MakeReservation methodunu try catch-ə salıb işlədirsiz yarana biləcək iki exception-da yoxlayırsız.
            try
            {
                hotel.MakeReservation(2);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error: " + ex.Message);
            }
            #endregion
            #region task2

            //Program.cs :

            //Minimum 2 car obyekti yaradırsnız.Console`a çıxarırsınız

            Car car1 = new Car();
            car1.Brand = "Mercedes";
            car1.Model = "E200";
            car1.Type = CarType.Sedan;
            Car car2 = new Car();
            car2.Brand = "BMW";
            car2.Model = "X5";
            car2.Type=CarType.SUV;

            Console.WriteLine(car1);
            Console.WriteLine(car2);

            #endregion
        }
    }
}
