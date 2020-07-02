using LiveSharpSample.ViewModels;
using ReactiveUI.XamForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace LiveSharpSample.Views
{
    public partial class TestPage : ReactiveContentPage<TestViewModel>
    {
        private Label _label1, _label2;

        private void Build()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label()
                        .Assign(out _label1),
                     
                    new Label()
                        .Assign(out _label2),

                    new Label()
                        .Bind(Label.TextProperty, nameof(TestViewModel.NormalBound1)),

                    new Label()
                        .Bind(Label.TextProperty, nameof(TestViewModel.NormalBound2)),

                    new Label{Text = "Static1" },

                    new Label{Text = "Static2" },
                }
            };
        }
    }
}