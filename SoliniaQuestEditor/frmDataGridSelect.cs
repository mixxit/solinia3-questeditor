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
    public partial class frmDataGridSelect<T> : Form
    {
        public T Result;
        public frmDataGridSelect()
        {
            InitializeComponent();
        }

        public frmDataGridSelect(string title, SortableBindingList<T> objects)
        {
            InitializeComponent();
            this.Text = title;
            foreach(DataGridView dataGrid in this.Controls.Find("dgList", false))
            {
                dataGrid.DataSource = objects.ToList<T>();
            }
        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex < 0)
                return;

            foreach (DataGridView dataGrid in this.Controls.Find("dgList", false))
            {
                Result = (T)dataGrid.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void dgList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex < 0)
                return;

            foreach (DataGridView dataGrid in this.Controls.Find("dgList", false))
            {
                Result = (T)dataGrid.Rows[e.RowIndex].DataBoundItem;
            }

            this.Close();
        }
    }
}
