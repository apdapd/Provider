using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Provider.Data.EntityFramework;

namespace Provider.Forms.Presenters
{
    
    class ViewPresenter
    {
        private FormView _formView;

        public ViewPresenter(FormView formView)
        {
            _formView = formView;
            _formView.NextPage += FormViewOnNextPage;
        }

        private void FormViewOnNextPage(object sender, EventArgs eventArgs)
        {
            var entityWork = new EntityWork();
            _formView.listDataAbonent = entityWork.GetAbonents(_formView.pageSize, _formView.pageNum * _formView.pageSize, _formView.nOrder);
            
        }

    }
}
