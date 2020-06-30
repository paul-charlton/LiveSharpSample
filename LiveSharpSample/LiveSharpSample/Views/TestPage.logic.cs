using LiveSharpSample.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;

namespace LiveSharpSample.Views
{
    public partial class TestPage
    {
        public TestPage()
        {
            Build();

            ViewModel = new TestViewModel();

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.Title, x => x._label1.Text, x => $"prefix {x}")
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel, x => x.Description, x => x._label2.Text, x => $"{x} suffix")
                    .DisposeWith(disposables);
            });
        }
    }
}