using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{
    public interface ISoliniaDatabase
    {
        List<NPC> Npcs { get; set; }
        List<Quest> Quests { get; set; }
        List<Item> Items { get; set; }
        List<Spell> Spells { get; set; }

        IEnumerable<Tuple<NPC, NPCEvent>> GetAwardsQuestNPCEventsForQuest(Quest quest);
        IEnumerable<Tuple<NPC, NPCEvent>> GetRequiresQuestNPCEventsForQuest(Quest quest);
    }
}
