using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Monster : Creations
    {
        public int DropExperience { get; set; }
        public CreatureRarity Rarity { get; set; }

        public void PowerLevel(int powerLevel)
        {
            for (int i = 0; i < powerLevel; i++)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level += 1;
            Random LevelUp = new Random();
            switch (Rarity)
            {
                case CreatureRarity.Common:
                {
                    TotalHealth += LevelUp.Next(2,11);
                    TotalPower += 2;
                    TotalLuck += LevelUp.Next(1,4);
                    break;
                }
                case CreatureRarity.Rare:
                {
                    TotalHealth += LevelUp.Next(10,14);
                    TotalPower += LevelUp.Next(3,5);
                    TotalLuck += LevelUp.Next(3,6);
                    break;
                }
                case CreatureRarity.Heroic:
                {
                    TotalHealth += LevelUp.Next(12,21);
                    TotalPower += LevelUp.Next(3,6);
                    TotalLuck += LevelUp.Next(3,8);
                    break;
                }
                case CreatureRarity.Legendary:
                {
                    TotalHealth += LevelUp.Next(20,41);
                    TotalPower += LevelUp.Next(5,13);
                    TotalLuck += LevelUp.Next(10,21);
                    break;
                }
            }
        }

        public Monster()
        {
            Random PercentRare = new Random();
            int thisRarity = PercentRare.Next(0, 100);
            if (thisRarity < 60)
            {
                Rarity = CreatureRarity.Common;
            }
            else if (thisRarity >= 60 && thisRarity < 90)
            {
                Rarity = CreatureRarity.Rare;
            }
            else if (thisRarity >= 90 && thisRarity < 99)
            {
                Rarity = CreatureRarity.Heroic;
            }
            else if (thisRarity == 99)
            {
                Rarity = CreatureRarity.Legendary;
            }
            PowerLevel(PercentRare.Next(5,15));
            Name = "Unknown Beast";
        }

        public enum CreatureRarity
        {
            Common,
            Rare,
            Heroic,
            Legendary
        }
    }
}
