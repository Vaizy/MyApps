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
        public int Damage{ get; }
        public float Armor { get; set; }

        public Unit(): this("Unknown Unit")
        {
            Damage = 5;
            Armor = 0.6f;
            //_health = 5f;
        }

        public Unit(string name)
        {
            Name = name;
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
