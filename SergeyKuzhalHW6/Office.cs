using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC3
{
    class Office
    {
        public string Address { get; private set; }
        public List<Room> Rooms { get; private set; }

        public Office (string officeAddress, List<Room> rooms)
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
