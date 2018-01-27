using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{
    public class NPCEvent
    {
        public string interactiontype { get; set; }
        public string triggerdata { get; set; }
        public string chatresponse { get; set; }
        public int requiresQuest { get; set; }
        public string requiresQuestFlag { get; set; }
        public int awardsQuest { get; set; }
        public string awardsQuestFlag { get; set; }
        public int npcId { get; set; }
        public int awardsItem { get; set; }
        public string teleportResponse { get; set; }
        public bool awardsRandomisedGear { get; set; }
    }
}
