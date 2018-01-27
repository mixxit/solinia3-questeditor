using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{
    public class Item : ISearchableObject
    {
        public int id { get; set; }
        public string displayname { get; set; }
        public string basename { get; set; }
        public int abilityid { get; set; }
        public int strength { get; set; }
        public int stamina { get; set; }
        public int agility { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public List<object> allowedClassNames { get; set; }
        public bool questitem { get; set; }
        public int damage { get; set; }
        public int weaponabilityid { get; set; }
        public int attackspeed { get; set; }
        public int enchantment1val { get; set; }
        public int enchantment2val { get; set; }
        public int enchantment3val { get; set; }
        public int enchantment4val { get; set; }
        public int hpregen { get; set; }
        public int mpregen { get; set; }
        public int worth { get; set; }
        public bool coreitem { get; set; }
        public int fireResist { get; set; }
        public int coldResist { get; set; }
        public int magicResist { get; set; }
        public int poisonResist { get; set; }
        public int diseaseResist { get; set; }
        public bool spellscroll { get; set; }
        public int color { get; set; }
        public bool isTemporary { get; set; }
        public bool isConsumable { get; set; }
        public int baneUndead { get; set; }
        public bool isPetControlRod { get; set; }
        public bool isAugmentation { get; set; }
        public bool isCrafting { get; set; }
        public bool isQuest { get; set; }
        public string augmentationFitsSlotType { get; set; }
        public string discoverer { get; set; }
        public int minLevel { get; set; }
        public int ac { get; set; }
        public int hp { get; set; }
        public int mana { get; set; }
        public bool isExperienceBonus { get; set; }
        public string skillModType { get; set; }
        public int skillModValue { get; set; }
        public string skillModType2 { get; set; }
        public int skillModValue2 { get; set; }
        public string skillModType3 { get; set; }
        public int skillModValue3 { get; set; }
        public string skillModType4 { get; set; }
        public int skillModValue4 { get; set; }

        public string GetSearchValue()
        {
            return displayname;
        }
    }
}
