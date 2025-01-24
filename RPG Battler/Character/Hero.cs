using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero(CombatClass combatClass)
        {
            Name = "Unknown";
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            CombatClass = combatClass;
        }

        public void PowerLevel(int powerLevel)
        {
            // int level = powerLevel / 5;
            for (int i = 0; i < powerLevel; i++)
            {
                LevelUp();
            }
        }

        public void AwakenHero()
        {
            Random random = new Random();
            CombatClass = (CombatClass) random.Next(0, 4);
            PowerLevel(random.Next(8, 13));
        }

        public void LevelUp()
        {
            Level += 1;
            Random LevelUp = new Random();
            switch (CombatClass)
            {
                case CombatClass.Warrior:
                    {
                        Health += LevelUp.Next(10, 21);
                        Power += LevelUp.Next(1, 4);
                        Luck += LevelUp.Next(1, 4);
                        break;
                    }
                case CombatClass.Wizard:
                    {
                        Health += LevelUp.Next(1, 16);
                        Power += LevelUp.Next(3, 6);
                        Luck += LevelUp.Next(1, 4);
                        break;
                    }
                case CombatClass.Rogue:
                    {
                        Health += LevelUp.Next(1, 16);
                        Power += LevelUp.Next(1, 4);
                        Luck += LevelUp.Next(3, 6);
                        break;
                    }
                default:
                    {
                        Health += LevelUp.Next(1, 16);
                        Power += LevelUp.Next(1, 4);
                        Luck += LevelUp.Next(1, 4);
                        break;
                    }
            }
        }

        public void CalculateTotals()
        {
        }

        public void DisplayStats(bool withEquipment = false)
        {
            if (withEquipment)
            {
                Console.WriteLine($"Here are {Name} the {CombatClass}'s total stats with equipment on:");
            }
            else
            {
                Console.WriteLine($"Here are {Name} the {CombatClass}'s natural stats with no equipment on:");
                Console.WriteLine($"Health: {Health}\nPower: {Power}\nLuck: {Luck}");
            }
        }
    }
}
