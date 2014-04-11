using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DndClient.ViewModel
{
    public abstract class WorkspaceViewModel : ViewModelBase
    {
        public ICommand Close;
    }
}
