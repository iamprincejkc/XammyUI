using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XammyUI.ViewModels
{
    public class JFIntroViewModel : BindableBase
    {
        private bool _IsEnabled = true;
        public bool IsEnabled
        {
            get { return _IsEnabled; }
            set { 
                SetProperty(ref _IsEnabled, value);
                SkipCommand.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand SkipCommand { get; private set; }
        private readonly INavigationService _navigationService;
        public JFIntroViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SkipCommand = new DelegateCommand(Submit,CanSubmit).ObservesCanExecute( () => IsEnabled);
        }
        void Submit()
        {
            IsEnabled = false;
            _navigationService.NavigateAsync("JFHome");
            IsEnabled = true;
        }
        bool CanSubmit()
        {
            return IsEnabled = true;
        }
    }
}
