using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class MainViewPresenter : Presenter<IMainView>, IMainViewPresenter
    {
        private IMainView _view;

        public MainViewPresenter(IMainView view, IApplicationController appController) : base(view, appController)
        {
            _view = view;
            _view.Presenter = this;
        }
    }
}
