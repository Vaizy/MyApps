using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MyApps
{
    internal class Unit
    {
        private float _health;
        public string Name { get; }
        public float Health => _health;
        public Interval Damage{ get; }
        public float Armor { get; set; }

        public Unit(): this("Unknown Unit")
        {
            Damage = new Interval(0, 0);
            Armor = 0.6f;
        }

        public Unit(string name)
        {
            Name = name;
            Damage = new Interval(0, 0);
            Armor = 0.6f;
        }

        public Unit(string name, int mindamage, int maxdamage)
        { 
            Name = name; 
            Damage = new Interval(mindamage, maxdamage);
            Armor = 0.6f;
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(int value)
        {
            _health = _health - value * Armor;
            return (Health <= 0f) ? true : false;
        }
    }
}
