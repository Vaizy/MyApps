using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyApps
{
    internal class Weapon
    {

        public string Name { get; }

        public Interval Damage { get; private set; }
        public float Durability { get; }

        public Weapon(string name) {
            Name = name;
            Durability = 1f;
        }
        public Weapon(string name, int mindamage, int maxdamage) : this(name)
        {
            Damage = new Interval(mindamage, maxdamage);
        }

        public int GetDamage()
        {
            return Damage.Get();
        }

        public void GetInfo()
        {
            Console.WriteLine("Оружие: {0}", Name);
            Console.WriteLine("Прочность: {0}", Durability);
            Console.WriteLine();
        }
    }
}
