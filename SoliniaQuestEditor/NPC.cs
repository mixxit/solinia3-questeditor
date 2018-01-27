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
        public string mctype { get; set; }
        public int level { get; set; }
        public int factionid { get; set; }
        public bool usedisguise { get; set; }
        public bool boss { get; set; }
        public bool heroic { get; set; }
        public bool raidboss { get; set; }
        public bool raidheroic { get; set; }
        public bool burning { get; set; }
        public bool invisible { get; set; }
        public bool customhead { get; set; }
        public int merchantid { get; set; }
        public bool upsidedown { get; set; }
        public int loottableid { get; set; }
        public int raceid { get; set; }
        public int classid { get; set; }
        public bool isRandomSpawn { get; set; }
        public bool isGuard { get; set; }
        public bool isRoamer { get; set; }
        public bool isPet { get; set; }
        public bool isUndead { get; set; }
        public bool isAnimal { get; set; }
        public List<NPCEvent> eventHandlers { get; set; }
        public string deathGrantsTitle { get; set; }
        public bool isSummoner { get; set; }
        public int avoidanceRating { get; set; }
        public int accuracyRating { get; set; }
        public int ac { get; set; }
        public string headitem { get; set; }
        public string chestitem { get; set; }
        public string legsitem { get; set; }
        public string feetitem { get; set; }
        public string handitem { get; set; }
        public string offhanditem { get; set; }
        public string disguisetype { get; set; }
        public string randomchatTriggerText { get; set; }
        public string customheaddata { get; set; }
        public string killTriggerText { get; set; }

        public string GetSearchValue()
        {
            return name;
        }
    }
}
