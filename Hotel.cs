using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Upcasting_Downcasting_Enum__Exception
{
    //    Hotel class
    //- Name
    //- Rooms array - içində Room obyektləri saxlayır və private-dır.

    //ps: Name dəyəri olmadan bir Hotel obyekti yaratmaq olmaz.

    public class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms = Array.Empty<Room>();

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            //- AddRoom() - Parametr olaraq Room obyekti qəbul edib rooms arrayinə əlavə edir.
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
        }
        public void MakeReservation(int? roomId)
        {
            //- MakeReservation() - Parametr olaraq nullable int tipindən bir roomId qəbul edir əgər roomId null olaraq geriyə NullReferanceException qaytarır əks halda
            //göndərilən roomId-li otaq tapılır və IsAvailable dəyəri yoxlanılır əgər IsAvailable dəyəri  false-dusa geriyə yuxarıda yaratdığınız NotAvailableException
            //qaytarılır
            //əgər true-dursa həmin room-un IsAvailable dəyəri false olur.

            foreach (Room room in Rooms)
            {
                if (room.Id == roomId)
                {
                    if (room.IsAvailable)
                    {
                        room.IsAvailable = false;
                        return;
                    }
                    else throw new NotAvailableException("Room is not available.");
                }
            }
            throw new NullReferenceException("Room not found.");
        }


    }
}
