using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Provider.Data.EntityFramework;

namespace Provider.Forms.Presenters
{
    class MainPresenter
    {
        SynchronizationContext _context = SynchronizationContext.Current;

        private IMainForm _mainForm;

        public MainPresenter(IMainForm mainForm)
        {
            _mainForm = mainForm;

            _mainForm.ButtonAppendClick += Append_Click;
            _mainForm.ButtonViewClick += View_Click;

        }

        private void View_Click(object sender, EventArgs e)
        {
            
            var formView = new FormView();
            var viewPresenter = new ViewPresenter(formView);
            formView.Show();
        }

        
        
        private void Append_Click(object sender, EventArgs e)
        {
            var entityWork = new EntityWork();
            var listDataTarifs = entityWork.GetTarifs();
            var formNew = new FormNew(listDataTarifs);
            MakeFormNew(formNew);
            formNew.Show();
        }

        private void MakeFormNew(FormNew formNew)
        {
            formNew.ButtonOKClick += FormNewButtonOKClick;
        }

        private async void FormNewButtonOKClick(object sender, EventArgs e)
        {
            FormNew ff = sender as FormNew;
            var entityWork = new EntityWork();
            if (ff != null)
            {
                bool ret = await entityWork.AddAbonentAsync(ff._dataAbonent);
            }
        }

    }
}
