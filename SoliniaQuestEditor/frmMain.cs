using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoliniaQuestEditor
{
    public partial class frmMain : Form
    {
        SoliniaWorldManager _manager;

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string defaultPath = @"E:\dev\spigot\plugins\Solinia3Core";
            if (_manager == null)
            if (Directory.Exists(defaultPath))
                _manager = new SoliniaWorldManager(this, defaultPath);
        }

        internal void SaveObject(object saveObject)
        {
            if (saveObject is Item)
            {
                SaveItem((Item)saveObject);
            }

            if (saveObject is NPC)
            {
                SaveNPC((NPC)saveObject);
            }
        }

        private void SaveNPC(NPC npc)
        {
            String temppath = Path.GetTempPath() + @"\" + Guid.NewGuid().ToString() + ".txt";
            System.IO.File.WriteAllText(temppath, JsonConvert.SerializeObject(npc, Formatting.Indented));
            System.Diagnostics.Process.Start(temppath);
        }

        private void SaveItem(Item item)
        {
            String temppath = Path.GetTempPath() + @"\" + Guid.NewGuid().ToString() + ".txt";
            System.IO.File.WriteAllText(temppath, JsonConvert.SerializeObject(item, Formatting.Indented));
            System.Diagnostics.Process.Start(temppath);
        }

        private void loadWorldFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonPath = Microsoft.VisualBasic.Interaction.InputBox("JSON Data Path", "Folder Path:", @"E:\dev\spigot\plugins\Solinia3Core", -1, -1);
            _manager = new SoliniaWorldManager(this, jsonPath);

        }

        public void CreateDynamicObject<T>()
        {
            if (!IsWorldLoaded())
            {
                MessageBox.Show("World is not loaded, please load via the file menu");
                return;
            }

            frmObjectEditor form = new frmObjectEditor();
            form.MdiParent = this;
            foreach (PropertyGrid grid in form.Controls.Find("pgObject", false))
            {
                grid.SelectedObject = default(T);
                form.Show();
            }
        }

        public void SearchDynamicObject<T>(List<T> lookupData) where T : ISearchableObject
        {
            if (!IsWorldLoaded())
            {
                MessageBox.Show("World is not loaded, please load via the file menu");
                return;
            }

            string search = GetSearchTerm();
            
            var objects = lookupData.Where(o => o.GetSearchValue().ToLower().Contains(search.ToLower()));

            if (objects.Count() < 1)
            {
                MessageBox.Show("No results found");
                return;
            }

            if (objects.Count() == 1)
            {
                frmObjectEditor form = new frmObjectEditor();
                form.MdiParent = this;
                foreach (PropertyGrid grid in form.Controls.Find("pgObject", false))
                {
                    grid.SelectedObject = objects.FirstOrDefault();
                    form.Show();
                }
            }

            if (objects.Count() > 1)
            {
                T result = ComboBox("Please double click an object", objects.ToList<T>());
                if (result == null)
                {
                    MessageBox.Show("Nothing selected");
                    return;
                }

                frmObjectEditor form = new frmObjectEditor();
                form.MdiParent = this;
                foreach (PropertyGrid grid in form.Controls.Find("pgObject", false))
                {
                    grid.SelectedObject = result;
                    form.Show();
                }
            }
        }

        private void createItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDynamicObject<Item>();
        }

        private void searchItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDynamicObject<Item>(GetManager().Database.Items);
        }

        public T ComboBox<T>(String title, List<T> objects)
        {
            using (frmDataGridSelect<T> form = new frmDataGridSelect<T>(title, new SortableBindingList<T>(objects)))
            {
                form.ShowDialog();
                return form.Result;
            }
        }

        public SoliniaWorldManager GetManager()
        {
            if (_manager == null)
                throw new Exception("No world folder loaded");

            return _manager;
        }

        public bool IsWorldLoaded()
        {
            if (_manager == null)
                return false;

            return true;
        }

        public string GetSearchTerm()
        {
            return Microsoft.VisualBasic.Interaction.InputBox("Search Term", "Search for:", @"", -1, -1).ToLower();
        }

        private void createNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDynamicObject<NPC>();
        }

        private void searchNPCsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDynamicObject<NPC>(GetManager().Database.Npcs);
        }

        private void searchQuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDynamicObject<Quest>(GetManager().Database.Quests);
        }

        private void createQuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDynamicObject<Quest>();
        }
    }
}
