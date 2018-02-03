using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{
    public class SoliniaDatabaseJSON : ISoliniaDatabase
    {
        private string _jsonPath;
        public List<NPC> Npcs { get; set; }
        public List<Quest> Quests { get; set; }
        public List<Item> Items { get; set; }
        public List<Spell> Spells { get; set; }

        public SoliniaDatabaseJSON(string jsonPath)
        {
            _jsonPath = jsonPath;
            Npcs = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText(_jsonPath + @"\npcs.json"));
            Quests = JsonConvert.DeserializeObject<List<Quest>>(File.ReadAllText(_jsonPath + @"\quests.json"));
            Items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_jsonPath + @"\items.json"));
            Spells = JsonConvert.DeserializeObject<List<Spell>>(File.ReadAllText(_jsonPath + @"\spells.json"));
        }

        public IEnumerable<Tuple<NPC, NPCEvent>> GetAwardsQuestNPCEventsForQuest(Quest quest)
        {
            foreach (NPC npc in this.Npcs)
            {
                if (npc.eventHandlers.Count == 0)
                    continue;

                foreach (NPCEvent npcEvent in npc.eventHandlers)
                {
                    if (npcEvent.awardsQuest == quest.Id)
                        yield return Tuple.Create(npc, npcEvent);
                }
            }
        }

        public IEnumerable<Tuple<NPC, NPCEvent>> GetRequiresQuestNPCEventsForQuest(Quest quest)
        {
            foreach (NPC npc in this.Npcs)
            {
                if (npc.eventHandlers.Count == 0)
                    continue;

                foreach (NPCEvent npcEvent in npc.eventHandlers)
                {
                    if (npcEvent.requiresQuest == quest.Id)
                        yield return Tuple.Create(npc, npcEvent);
                }
            }
        }
    }
}
