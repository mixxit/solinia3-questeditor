using System;
using System.Collections.Generic;

namespace SoliniaQuestEditor
{
    public class Item : ISearchableObject
    {
        public int id { get; set; }
        public string displayname { get; set; }
        public string basename { get; set; }
        public int abilityid { get; set; } = 0;
        public string lore { get; set; }
        public int strength { get; set; } = 0;
        public int stamina { get; set; } = 0;
        public int agility { get; set; } = 0;
        public int dexterity { get; set; } = 0;
        public int intelligence { get; set; } = 0;
        public int wisdom { get; set; } = 0;
        public int charisma { get; set; } = 0;
        public List<String> allowedClassNames { get; set; } = new List<string>();
        public string texturebase64 { get; set; }
        public bool questitem { get; set; } = false;
        public int damage { get; set; } = 0;
        public int weaponabilityid { get; set; } = 0;
        public int attackspeed { get; set; } = 0;
        public string enchantment1 { get; set; }
        public int enchantment1val { get; set; }
        public string enchantment2 { get; set; }
        public int enchantment2val { get; set; }
        public string enchantment3 { get; set; }
        public int enchantment3val { get; set; }
        public string enchantment4 { get; set; }
        public int enchantment4val { get; set; }
        public int hpregen { get; set; } = 0;
        public int mpregen { get; set; } = 0;
        public int worth { get; set; } = 1;
        public bool coreitem { get; set; } = false;
        public int fireResist { get; set; } = 0;
        public int coldResist { get; set; } = 0;
        public int magicResist { get; set; } = 0;
        public int poisonResist { get; set; } = 0;
        public int diseaseResist { get; set; } = 0;
        public bool spellscroll { get; set; } = false;
        public byte color { get; set; }
        public bool isTemporary { get; set; }
        public bool isConsumable { get; set; }
        public int baneUndead { get; set; }
        public bool isPetControlRod { get; set; } = false;
        public bool isAugmentation { get; set; } = false;
        public bool isCrafting { get; set; } = false;
        public bool isQuest { get; set; } = false;
        public AugmentationSlotType augmentationFitsSlotType { get; set; } = AugmentationSlotType.NONE;
        public string discoverer { get; set; } = "";
        public int minLevel { get; set; } = 0;
        public int ac { get; set; } = 0;
        public int hp { get; set; } = 0;
        public int mana { get; set; } = 0;
        public bool isExperienceBonus { get; set; } = false;
        public SkillType skillModType { get; set; } = SkillType.None;
        public int skillModValue { get; set; } = 0;
        public SkillType skillModType2 { get; set; } = SkillType.None;
        public int skillModValue2 { get; set; } = 0;
        public SkillType skillModType3 { get; set; } = SkillType.None;
        public int skillModValue3 { get; set; } = 0;
        public SkillType skillModType4 { get; set; } = SkillType.None;
        public int skillModValue4 { get; set; } = 0;

        public string GetSearchValue()
        {
            return displayname;
        }
    }
}
