using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SoliniaQuestEditor
{
    internal class SoliniaQuestManager
    {
        private frmQuestEditor _form;
        private string _jsonPath;

        public SoliniaQuestManager(frmQuestEditor form, string jsonPath)
        {
            _form = form;
            _jsonPath = jsonPath;

            LoadData();
        }

        public TextBox GetInteractionTypeTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbInteractionType", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetTriggerDataTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbTriggerData", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetChatResponseTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbChatResponse", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetRequiresQuestTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbRequiresQuest", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetAwardsQuestTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbAwardsQuest", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetAwardsQuestFlagTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbAwardsQuestFlag", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetRequiresQuestFlagTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbRequiresQuestFlag", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        internal void ShowRaw()
        {
            string npcdata = "";

            foreach (ComboBox listBox in GetQuestPanel().Controls.Find("cbNPCIdList", true))
            {
                if (String.IsNullOrEmpty((string)listBox.SelectedItem))
                {
                    return;
                }

                npcdata = (string)listBox.SelectedItem;
            }

            int npcId = Convert.ToInt32(npcdata.Split(' ')[0]);
            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText(_jsonPath + @"\npcs.json"));
            NPC npc = npcs.Where(n => n.id == npcId).FirstOrDefault();

            String temppath = Path.GetTempPath() + @"\" + Guid.NewGuid().ToString() + ".txt";
            System.IO.File.WriteAllText(temppath, JsonConvert.SerializeObject(npc, Formatting.Indented));
            System.Diagnostics.Process.Start(temppath);
        }

        public TextBox GetNPCIDTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbNPCId", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        internal void CommitNewQuestStep()
        {
            string npcdata = "";

            foreach (ComboBox listBox in GetQuestPanel().Controls.Find("cbNPCIdList", true))
            {
                if (String.IsNullOrEmpty((string)listBox.SelectedItem))
                {
                    return;
                }

                npcdata = (string)listBox.SelectedItem;
            }

            int npcId = Convert.ToInt32(npcdata.Split(' ')[0]);
            string newTriggerData = GetNewTriggerDataTextBox().Text;

            if (npcId < 1)
                return;

            if (String.IsNullOrEmpty(newTriggerData))
                return;

            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText(_jsonPath + @"\npcs.json"));
            if (npcs.Where(npc => npc.id == npcId).FirstOrDefault().eventHandlers.Where(npcEvent => npcEvent.triggerdata.Equals(newTriggerData)).Count() == 0)
            {
                // trigger data doesnt exist, create it
                NPCEvent npcEvent = new NPCEvent();
                npcEvent.interactiontype = "CHAT";
                npcEvent.awardsItem = 0;
                npcEvent.awardsQuest = 0;
                npcEvent.awardsQuestFlag = "";
                npcEvent.requiresQuestFlag = "";
                npcEvent.awardsRandomisedGear = false;
                npcEvent.chatresponse = "CONTACTDEV";
                npcEvent.npcId = npcId;
                npcEvent.requiresQuest = Convert.ToInt32(GetQuestIdTextBox().Text);
                npcEvent.teleportResponse = "";
                npcEvent.triggerdata = newTriggerData;

                npcs.Where(npc => npc.id == npcId).FirstOrDefault().eventHandlers.Add(npcEvent);
            }
            else
            {
                // already exists
                return;

            }

            string json = JsonConvert.SerializeObject(npcs);
            File.WriteAllText(_jsonPath + @"\npcs.json", json);
            LoadData();

        }

        public TextBox GetAwardsItemTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbAwardsItem", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetQuestIdTextBox()
        {
            foreach (TextBox textbox in GetQuestPanel().Controls.Find("tbQuestId", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetNewTriggerDataTextBox()
        {
            foreach (TextBox textbox in GetQuestPanel().Controls.Find("tbNewTriggerData", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetTeleportResponseTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbTeleportResponse", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }

        public TextBox GetAwardsRandomisedGearTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbAwardsRandomisedGear", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }


        public void ShowClickedQuestStepNode(Tuple<NPC,NPCEvent> questStepData)
        {
            GetQuestPanel().Visible = false;

            GetInteractionTypeTextBox().Text = questStepData.Item2.interactiontype;
            GetTriggerDataTextBox().Text = questStepData.Item2.triggerdata;
            GetChatResponseTextBox().Text = questStepData.Item2.chatresponse;
            GetRequiresQuestTextBox().Text = questStepData.Item2.requiresQuest.ToString();
            GetAwardsQuestTextBox().Text = questStepData.Item2.awardsQuest.ToString();
            GetAwardsQuestFlagTextBox().Text = questStepData.Item2.awardsQuestFlag;
            GetRequiresQuestFlagTextBox().Text = questStepData.Item2.requiresQuestFlag;
            GetNPCIDTextBox().Text = questStepData.Item2.npcId.ToString();
            GetAwardsItemTextBox().Text = questStepData.Item2.awardsItem.ToString();
            GetTeleportResponseTextBox().Text = questStepData.Item2.teleportResponse;
            GetAwardsRandomisedGearTextBox().Text = questStepData.Item2.awardsRandomisedGear.ToString();

            GetQuestStepPanel().Visible = true;
        }

        public void ShowClickedQuestNode(Quest questData)
        {
            GetQuestStepPanel().Visible = false;
            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText(_jsonPath + @"\npcs.json"));

            foreach (TextBox textbox in GetQuestPanel().Controls.Find("tbQuestId", true))
            {
                textbox.Text = questData.Id.ToString();
            }

            foreach (TextBox textbox in GetQuestPanel().Controls.Find("tbNewTriggerData", true))
            {
                textbox.Text = "";
            }

            foreach (TextBox textbox in GetQuestPanel().Controls.Find("txtQuestName", true))
            {
                textbox.Text = questData.name;
            }

            foreach (ComboBox listBox in GetQuestPanel().Controls.Find("cbNPCIdList", true))
            {
                listBox.Items.Clear();
                foreach (NPC npc in npcs)
                {
                    if (npc.isPet)
                        continue;

                    int index = listBox.Items.Add(npc.id + " " + npc.name);
                }
            }

            GetQuestPanel().Visible = true;
        }

        public Panel GetQuestPanel()
        {
            foreach (Control control in _form.Controls.Find("panelQuest", true))
            {
                return (Panel)control;
            }

            throw new KeyNotFoundException();
        }

        public Panel GetQuestStepPanel()
        {
            foreach (Control control in _form.Controls.Find("panelQuestStep", true))
            {
                return (Panel)control;
            }

            throw new KeyNotFoundException();
        }

        public TreeView GetTreeView()
        {
            foreach (Control control in _form.Controls.Find("tvTree", true))
            {
                return (TreeView)control;
            }

            throw new KeyNotFoundException();
        }

        public void LoadData()
        {
            GetQuestPanel().Visible = false;
            GetQuestStepPanel().Visible = false;

            List<Quest> quests = JsonConvert.DeserializeObject<List<Quest>>(File.ReadAllText(_jsonPath + @"\quests.json"));
            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText(_jsonPath + @"\npcs.json"));
            MessageBox.Show("Quests Loaded: "+ quests.Count + " NPCs Loaded: " + npcs.Count);

            GetTreeView().Nodes.Clear();
            foreach(Quest quest in quests)
            {
                TreeNode node = GetTreeView().Nodes.Add(quest.Id + " - " + quest.name);
                node.Tag = quest;
                foreach(Tuple<NPC, NPCEvent> questStep in FindAwardsQuestNPCEventsForQuest(quest,npcs))
                {
                    TreeNode subNode = node.Nodes.Add("AWARDED BY: " + questStep.Item1.name + " quest step");
                    subNode.Tag = questStep;
                }
                foreach (Tuple<NPC, NPCEvent> questStep in FindRequiresQuestNPCEventsForQuest(quest, npcs))
                {
                    TreeNode subNode = node.Nodes.Add("REQUIRED BY: " + questStep.Item1.name + " quest step");
                    subNode.Tag = questStep;
                }
            }
        }

        internal void CommitQuestStep()
        {
            int npcId = 0;
            String triggerdata = "";

            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbNPCId", true))
            {
                npcId = Convert.ToInt32(textbox.Text);
            }

            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbTriggerData", true))
            {
                triggerdata = textbox.Text;
            }

            if (npcId < 1)
                return;

            List<NPC> npcs = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText(_jsonPath + @"\npcs.json"));
            if (npcs.Where(npc => npc.id == npcId).FirstOrDefault().eventHandlers.Where(npcEvent => npcEvent.triggerdata.Equals(triggerdata)).Count() == 0)
            {
                // trigger data doesnt exist, create it
                NPCEvent npcEvent = new NPCEvent();
                npcEvent.awardsItem = Convert.ToInt32(GetAwardsItemTextBox().Text);
                npcEvent.awardsQuest = Convert.ToInt32(GetAwardsQuestTextBox().Text);
                npcEvent.awardsQuestFlag = GetAwardsQuestFlagTextBox().Text;
                npcEvent.requiresQuestFlag = GetRequiresQuestFlagTextBox().Text;
                npcEvent.awardsRandomisedGear = Convert.ToBoolean(GetAwardsRandomisedGearTextBox().Text);
                npcEvent.chatresponse = GetChatResponseTextBox().Text;
                npcEvent.interactiontype = GetInteractionTypeTextBox().Text;
                npcEvent.npcId = Convert.ToInt32(GetNPCIDTextBox().Text);
                npcEvent.requiresQuest = Convert.ToInt32(GetRequiresQuestTextBox().Text);
                npcEvent.teleportResponse = GetTeleportResponseTextBox().Text;
                npcEvent.triggerdata = GetTriggerDataTextBox().Text;

                npcs.Where(npc => npc.id == npcId).FirstOrDefault().eventHandlers.Add(npcEvent);
            } else
            {
                // trigger data does exist, update it
                NPCEvent npcEvent = npcs.Where(npc => npc.id == npcId).FirstOrDefault().eventHandlers.Where(n => n.triggerdata.Equals(triggerdata)).FirstOrDefault();

                npcEvent.awardsItem = Convert.ToInt32(GetAwardsItemTextBox().Text);
                npcEvent.awardsQuest = Convert.ToInt32(GetAwardsQuestTextBox().Text);
                npcEvent.awardsQuestFlag = GetAwardsQuestFlagTextBox().Text;
                npcEvent.awardsRandomisedGear = Convert.ToBoolean(GetAwardsRandomisedGearTextBox().Text);
                npcEvent.chatresponse = GetChatResponseTextBox().Text;
                npcEvent.interactiontype = GetInteractionTypeTextBox().Text;
                npcEvent.npcId = Convert.ToInt32(GetNPCIDTextBox().Text);
                npcEvent.requiresQuest = Convert.ToInt32(GetRequiresQuestTextBox().Text);
                npcEvent.requiresQuestFlag = GetRequiresQuestFlagTextBox().Text;
                npcEvent.teleportResponse = GetTeleportResponseTextBox().Text;
                npcEvent.triggerdata = GetTriggerDataTextBox().Text;

            }

            string json = JsonConvert.SerializeObject(npcs);
            File.WriteAllText(_jsonPath + @"\npcs.json", json);

            LoadData();
        }

        public IEnumerable<Tuple<NPC,NPCEvent>> FindAwardsQuestNPCEventsForQuest(Quest quest, List<NPC> npcs)
        {
            foreach(NPC npc in npcs)
            {
                if (npc.eventHandlers.Count == 0)
                    continue;

                foreach(NPCEvent npcEvent in npc.eventHandlers)
                {
                    if (npcEvent.awardsQuest == quest.Id)
                        yield return Tuple.Create(npc, npcEvent);
                }
            }
        }

        public IEnumerable<Tuple<NPC,NPCEvent>> FindRequiresQuestNPCEventsForQuest(Quest quest, List<NPC> npcs)
        {
            foreach (NPC npc in npcs)
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