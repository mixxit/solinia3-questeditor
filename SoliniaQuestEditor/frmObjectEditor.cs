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
    public partial class frmObjectEditor : Form
    {
        public frmObjectEditor()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PropertyGrid grid in this.Controls.Find("pgObject", false))
            {
                ((frmMain)this.ParentForm).SaveObject(grid.SelectedObject);
            }

        }
    }
}
