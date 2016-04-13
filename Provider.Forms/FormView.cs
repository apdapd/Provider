using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Provider.Defs;

namespace Provider.Forms
{
    public partial class FormView : Form
    {
        public int pageSize;
        public int pageNum;
        public int nOrder;
        public List<DataAbonent> listDataAbonent;

        public event EventHandler NextPage;

        public FormView()
        {
            InitializeComponent();
            nOrder = 0;
            pageNum = 0;
            pageSize = 10;
            //button_Click(this, null);
            //dataGridView1.DataSource = listDataAbonent;
        }
        private void FormView_Shown(object sender, EventArgs e)
        {
            button_Click(this, null);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            pageNum = pageNum > 0 ? pageNum - 1 : 0;
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageNum++;
            button_Click(sender, e);
        }

        private void button_Click(object sender, EventArgs e)
        {
            buttonPrev.Enabled = pageNum > 0;
            if (NextPage != null)
                NextPage(sender, e);
            dataGridView1.DataSource = listDataAbonent;
        }
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nOrder = e.ColumnIndex;
            button_Click(sender, e);
            //DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            //DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            //ListSortDirection direction;

            //// If oldColumn is null, then the DataGridView is not sorted.
            //if (oldColumn != null)
            //{
            //    // Sort the same column again, reversing the SortOrder.
            //    if (oldColumn == newColumn &&
            //        dataGridView1.SortOrder == SortOrder.Ascending)
            //    {
            //        direction = ListSortDirection.Descending;
            //    }
            //    else
            //    {
            //        // Sort a new column and remove the old SortGlyph.
            //        direction = ListSortDirection.Ascending;
            //        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            //    }
            //}
            //else
            //{
            //    direction = ListSortDirection.Ascending;
            //}

            //// Sort the selected column.
            //dataGridView1.Sort(newColumn, direction);
            //newColumn.HeaderCell.SortGlyphDirection =
            //    direction == ListSortDirection.Ascending ?
            //    SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

       
    }
}
