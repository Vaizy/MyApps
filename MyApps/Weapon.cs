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
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }

        public float Durability { get; }

        public Weapon(string name) {
            Name = name;
            Durability = 1f;
        }
        public Weapon(string name, int mindamage, int maxdamage) : this(name)
        {
            MinDamage = mindamage;
            MaxDamage = maxdamage;
            SetDamageParams(MinDamage, MaxDamage);
        }

        private void SetDamageParams(int minDamage, int maxDamage)
        {
            // проверка min damage < max damage
            if (minDamage > maxDamage)
            {
                (this.MinDamage, this.MaxDamage) = (this.MaxDamage, this.MinDamage);
                Console.WriteLine("Оружие '{0}'. Неверно задан минимальный и максимальный урон.", this.Name);
            }
            if (minDamage < 1)
            {
                this.MinDamage = 1;
                Console.WriteLine("Минимальный урон не может быть меньше 1. Установлено значение 1");
            }
            if (maxDamage <= 1)
            {
                this.MaxDamage = 10;
                Console.WriteLine("Максимальный урон должен быть больше 1. Установлено значение 10");
            }
        }

        public int GetDamage()
        {
            return (MinDamage + MaxDamage ) / 2;
        }

        public void GetInfo()
        {
            Console.WriteLine("Оружие: {0}", Name);
            Console.WriteLine("Минимальный урон: {0}", MinDamage);
            Console.WriteLine("Максимальный урон: {0}", MaxDamage);
            Console.WriteLine("Прочность: {0}", Durability);
            Console.WriteLine();
        }
    }
}
