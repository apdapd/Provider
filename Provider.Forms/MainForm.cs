using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Provider.Data.EntityFramework;
using Provider.Defs;

namespace Provider.Forms
{
        public interface IMainForm
    {

        event EventHandler ButtonAppendClick;
        event EventHandler ButtonViewClick;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonAppendClick;
        public event EventHandler ButtonViewClick;
        private void buttonAppend_Click(object sender, EventArgs e)
        {
            if (ButtonAppendClick != null)
                ButtonAppendClick(this, EventArgs.Empty);           
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (ButtonViewClick != null)
                ButtonViewClick(this, EventArgs.Empty);           
        }
    }
}
