using $safeprojectname$.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class MainView : Form, IMainView
    {
        private IMainViewPresenter _presenter;

        public MainView()
        {
            InitializeComponent();
        }

        public IMainViewPresenter Presenter
        {
            get { return _presenter; }
            set
            {
                if (_presenter == null)
                {
                    _presenter = value;
                }
            }
        }
    }
}
