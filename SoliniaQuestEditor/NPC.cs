using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{

    public class NPC : ISearchableObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mctype { get; set; } = "SKELETON";
        public int level { get; set; } = 1;
        public int factionid { get; set; }
        public bool usedisguise { get; set; } = false;
        public string disguisetype { get; set; }
        public string headitem { get; set; }
        public string chestitem { get; set; }
        public string legsitem { get; set; }
        public string feetitem { get; set; }
        public string handitem { get; set; }
        public string offhanditem { get; set; }
        public bool boss { get; set; } = false;
        public bool heroic { get; set; } = false;
        public bool raidboss { get; set; } = false;
        public bool raidheroic { get; set; } = false;
        public bool burning { get; set; } = false;
        public bool invisible { get; set; } = false;
        public bool customhead { get; set; } = false;
        public string customheaddata { get; set; }
        public int merchantid { get; set; }
        public bool upsidedown { get; set; } = false;
        public int loottableid { get; set; }
        public int raceid { get; set; }
        public int classid { get; set; }
        public bool isRandomSpawn { get; set; } = false;
        public string killTriggerText { get; set; }
        public string randomchatTriggerText { get; set; }
        public bool isGuard { get; set; } = false;
        public bool isRoamer { get; set; } = false;
        public bool isPet { get; set; } = false;
        public bool isUndead { get; set; } = false;
        public bool isAnimal { get; set; } = false;
        public List<NPCEvent> eventHandlers { get; set; } = new List<NPCEvent>();
        public string deathGrantsTitle { get; set; } = "";
        public bool isSummoner { get; set; } = false;
        public int avoidanceRating { get; set; } = 0;
        public int accuracyRating { get; set; } = 0;
        public int ac { get; set; } = 0;

        public string GetSearchValue()
        {
            return name;
        }
    }
}
