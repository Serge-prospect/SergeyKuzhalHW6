using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyKuzhal_HW_QAC3
{
    class Room
    {
        public int RoomNumber { get; private set; }
        public int RoomLength { get; private set; }
        public int RoomWidth { get; private set; }

        public Room (int roomNumber, int roomLength, int roomWidth)
        {
            RoomNumber = roomNumber;
            RoomLength = roomLength;
            RoomWidth = roomWidth;
        }

        public int GetRoomSquare()
        {
            int roomSquare = RoomLength * RoomWidth;

            return roomSquare;
        }
    }
}
