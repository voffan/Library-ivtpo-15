using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReadingRoom
    {
        public ReadingRoom() { }
        public ReadingRoom(string room_name)
        {
            Name = room_name;
        }
        public int ReadingRoomID { get; set; }
        public string Name { get; set; }
    }
}
