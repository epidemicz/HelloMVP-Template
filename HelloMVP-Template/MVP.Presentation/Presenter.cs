using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public abstract class Presenter<TView>
    {
        private readonly TView _view;

        public Presenter(TView view, IApplicationController appController)
        {
            _view = view;
            ApplicationController = appController;
        }

        public TView View
        {
            get { return _view; }
        }

        protected IApplicationController ApplicationController { get; set; }
    }
}
