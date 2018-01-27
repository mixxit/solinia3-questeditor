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
    public partial class frmQuestEditor : Form
    {
        private string _jsonPath;
        private SoliniaQuestManager _manager;

        public frmQuestEditor()
        {
            InitializeComponent();
        }
        
        private void tvTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (_manager == null)
                return;

            if (e.Node.Tag is Quest)
            {
                _manager.ShowClickedQuestNode((Quest)e.Node.Tag);
            }

            if (e.Node.Tag is Tuple<NPC, NPCEvent>)
            {
                _manager.ShowClickedQuestStepNode((Tuple<NPC, NPCEvent>)e.Node.Tag);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_manager == null)
                return;

            _manager.CommitQuestStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_manager == null)
                return;

            _manager.CommitNewQuestStep();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_manager == null)
                return;
            _manager.ShowRaw();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
