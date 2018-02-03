using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoliniaQuestEditor
{
    public class NPCEvent
    {
        public InteractionType interactiontype { get; set; }
        public String triggerdata { get; set; }
        public String chatresponse { get; set; }
        public int requiresQuest { get; set; }
        public int awardsQuest { get; set; }
        public String requiresQuestFlag { get; set; }
        public String awardsQuestFlag { get; set; }
        public int npcId { get; set; }
        public int awardsItem { get; set; }
        public String teleportResponse { get; set; }
        public bool awardsRandomisedGear { get; set; }
    }
}
