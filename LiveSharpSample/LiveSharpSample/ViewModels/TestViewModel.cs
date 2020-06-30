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

        public string Description { get; set; } = "Description";

        public IScreen HostScreen { get; }

        public string Title { get; set; } = "Title";

        public string UrlPathSegment { get; }
    }
}