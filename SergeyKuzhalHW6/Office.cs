using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhalHW7
{
    class Office
    {
        public string Address { get; private set; }
        public Room[] Rooms { get; private set; }

        public Office (string officeAddress, Room[] rooms)
        {
            Address = officeAddress;
            Rooms = rooms;
        }

        public int GetOfficeRoomsSquare()
        {
            int officeRoomsSquare = 0;
            foreach (Room room in Rooms)
            {
                officeRoomsSquare += room.GetRoomSquare();
            }

            return officeRoomsSquare;
        }
    }
}
