using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Battler.Character.Upgrades;

namespace RPG_Battler.Character
{
    public  class Creations
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int TotalHealth { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        
    }

    public enum CombatClass
    {
        None,
        Warrior,
        Wizard,
        Rogue
    }
}
