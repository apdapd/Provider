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
    public interface IFormNew
    {      
        DataAbonent _dataAbonent { get; set; }
        
        event EventHandler ButtonOKClick;        
    }
    public partial class FormNew : Form, IFormNew
    {
        public DataAbonent _dataAbonent { get; set; }
        private List<DataTarif> _listDataTarifs;
        //private DataTarif _dataTarif;

        public event EventHandler ButtonOKClick;
        public FormNew(List<DataTarif> listDataTarifs)
        {
            _dataAbonent = new DataAbonent();
            InitializeComponent();
            _listDataTarifs = listDataTarifs;
        }

        private void FormNew_Shown(object sender, EventArgs e)
        {
            //comboBoxTarifs.DataSource = _listDataTarifs;
            //comboBoxTarifs.DisplayMember = "_listDataTarifs.Name";
           // comboBoxTarifs.ValueMember = "_listDataTarifs.TarifId";
            comboBoxTarifs.DataSource = _listDataTarifs.Select(a => a.Name).ToList();
            comboBoxTarifs.SelectedIndex = 0;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _dataAbonent.TarifId = _listDataTarifs[comboBoxTarifs.SelectedIndex].TarifId;
            _dataAbonent.Name = textBoxName.Text;
            _dataAbonent.Address = textBoxAddress.Text;
            if (ButtonOKClick != null)
                ButtonOKClick(this, EventArgs.Empty);
            Close();
        }
    }
}
