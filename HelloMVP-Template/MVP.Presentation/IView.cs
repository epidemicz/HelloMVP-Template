using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public interface IView<TPresenter>
    {
        TPresenter Presenter { get; set; }
    }
}
