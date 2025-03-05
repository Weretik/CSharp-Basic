using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10._Generic
{
    public interface ICreature
    {
        string Name { get; }
        DateTime LastGiftDate { get; set; }
    }
    public class MagicBag<T> where T : ICreature
    {
        public string GiveGift(T creature)
        {
            DateTime currentDate = DateTime.Today;

            if (creature.LastGiftDate.Date == currentDate.Date)
            {
                return $"{creature.Name}, ви вже отримали подарунок сьогодні!";
            }

            creature.LastGiftDate = currentDate;
            return $"{creature.Name}, ваш подарунок: {GetGiftForCreature(creature)}";
        }

        private string GetGiftForCreature(T creature)
        {
            if (creature is Human)
            {
                return "книга";
            }
            else if (creature is Elf)
            {
                return "магічний кристал";
            }
            else
            {
                return "невідомий подарунок";
            }
        }
    }
    public class Human : ICreature
    {
        public string Name { get; private set; }
        public DateTime LastGiftDate { get; set; }

        public Human(string name)
        {
            Name = name;
            LastGiftDate = DateTime.MinValue;
        }
    }

    public class Elf : ICreature
    {
        public string Name { get; private set; }
        public DateTime LastGiftDate { get; set; }

        public Elf(string name)
        {
            Name = name;
            LastGiftDate = DateTime.MinValue;
        }
    }
}
