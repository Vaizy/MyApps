using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApps
{
    internal class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[]
            {
                new Room(new Unit("Guard"), new Weapon("sword")),
                new Room(new Unit("Archer"), new Weapon("bow")),
                new Room(new Unit("Barbarian"), new Weapon("club"))
            };
        }

        public void ShowRooms()
        {
            foreach (Room room in rooms) 
            {
                Console.WriteLine("Unit of room " + room.Unit.Name);
                Console.WriteLine("Weapon of room " + room.Weapon.Name);
                Console.WriteLine("—");
            }
        }
    }
}
