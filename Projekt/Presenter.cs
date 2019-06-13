using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            view.LoadingDrives += View_LoadingDrives;
            view.LoadingFiles += View_LoadingFiles;
        }
        private void View_LoadingDrives()
        {
            view.Drives = model.GetDrives;
        }
        private void View_LoadingFiles()
        {
            view.Files = model.GetFiles(view.CurrentPath);
        }
    }
}
