using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoliniaQuestEditor
{
    public partial class frmQuestVisualiser : Form
    {
        private SoliniaWorldManager _manager;

        public frmQuestVisualiser()
        {
            InitializeComponent();
        }

        private void tvTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (_manager == null)
                return;

            if (e.Node.Tag is Quest)
            {
                ShowClickedQuestNode((Quest)e.Node.Tag);
            }

            if (e.Node.Tag is Tuple<NPC, NPCEvent>)
            {
                ShowClickedQuestStepNode((Tuple<NPC, NPCEvent>)e.Node.Tag);
            }
        }

        public void ShowClickedQuestStepNode(Tuple<NPC, NPCEvent> questStepData)
        {
            GetQuestPanel().Visible = false;

            GetInteractionTypeTextBox().Text = questStepData.Item2.interactiontype.ToString();
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
                foreach (NPC npc in _manager.Database.Npcs)
                {
                    if (npc.isPet)
                        continue;

                    int index = listBox.Items.Add(npc.id + " " + npc.name);
                }
            }

            GetQuestPanel().Visible = true;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuestVisualiser_Load(object sender, EventArgs e)
        {
            LoadQuestTree();
        }

        public Panel GetQuestPanel()
        {
            foreach (Control control in Controls.Find("panelQuest", true))
            {
                return (Panel)control;
            }

            throw new KeyNotFoundException();
        }

        public Panel GetQuestStepPanel()
        {
            foreach (Control control in Controls.Find("panelQuestStep", true))
            {
                return (Panel)control;
            }

            throw new KeyNotFoundException();
        }

        public TreeView GetTreeView()
        {
            foreach (Control control in Controls.Find("tvTree", true))
            {
                return (TreeView)control;
            }

            throw new KeyNotFoundException();
        }

        private void LoadQuestTree()
        {
            GetQuestPanel().Visible = false;
            GetQuestStepPanel().Visible = false;
            GetTreeView().Nodes.Clear();

            foreach (Quest quest in _manager.Database.Quests)
            {
                TreeNode node = GetTreeView().Nodes.Add(quest.Id + " - " + quest.name);
                node.Tag = quest;
                foreach (Tuple<NPC, NPCEvent> questStep in _manager.Database.GetAwardsQuestNPCEventsForQuest(quest))
                {
                    TreeNode subNode = node.Nodes.Add("AWARDED BY: " + questStep.Item1.name + " quest step");
                    subNode.Tag = questStep;
                }
                foreach (Tuple<NPC, NPCEvent> questStep in _manager.Database.GetRequiresQuestNPCEventsForQuest(quest))
                {
                    TreeNode subNode = node.Nodes.Add("REQUIRED BY: " + questStep.Item1.name + " quest step");
                    subNode.Tag = questStep;
                }
            }
        }

        internal void SetManager(SoliniaWorldManager soliniaWorldManager)
        {
            this._manager = soliniaWorldManager;
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

        public TextBox GetNPCIDTextBox()
        {
            foreach (TextBox textbox in GetQuestStepPanel().Controls.Find("tbNPCId", true))
            {
                return textbox;
            }

            throw new KeyNotFoundException();
        }
    }
}
