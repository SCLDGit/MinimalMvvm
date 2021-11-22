using System;
using System.Collections.Generic;
using System.Text;

using Avalonia.Metadata;

using ReactiveUI.Fody.Helpers;

namespace MinimalMvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive] public bool ButtonIsEnabled { get; set; }
        [Reactive] public bool MessageIsShown  { get; set; }

        public void ClickButton(object p_parameters)
        {
            MessageIsShown = !MessageIsShown;
        }

        [DependsOn(nameof(ButtonIsEnabled))]
        public bool CanClickButton(object p_parameters)
        {
            return ButtonIsEnabled;
        }
    }
}
