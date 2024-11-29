using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_Enum__Exception
{
    //    Car class`nız olur.
    //Id - kənardan set edə bilmirsiniz, öz-özünə artır.
    //Brand - (mercedes, bmw və s.)
    //Model - (e200, f10 və s.)
    //Type - Enum olacaq(Sport, SUV, Sedan və s.)
    //ToString() methodunu override edirsiniz və console`a çıxaranda car obyektini bütün məlumatları göstərilməlidir.
    public class Car
    {
        private static int _count=0;
        public int Id { get; private set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarType Type { get; set; }
        public Car()
        {
            Id=++_count;
        }
        public override string ToString()
        {
            return $"Id - {Id}\r\nBrand - {Brand}\r\nModel - {Model}\r\nType - {Type}";
        }

    }
}
