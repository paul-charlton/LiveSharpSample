using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LiveSharpSample.ViewModels
{
    public class TestViewModel : ReactiveObject, IRoutableViewModel, IReactiveObject, INotifyPropertyChanged, INotifyPropertyChanging, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new ViewModelActivator();

        public IScreen HostScreen { get; }

        public string NormalBound1 { get; set; } = "NormalBound1";

        public string NormalBound2 { get; set; } = "NormalBound2";

        public string ReactiveBound1 { get; set; } = "ReactiveBound1";

        public string ReactiveBound2 { get; set; } = "ReactiveBound2";

        public string UrlPathSegment { get; }
    }
}