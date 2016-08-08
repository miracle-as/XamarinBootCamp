using MvvmCross.Core.ViewModels;

namespace XamBootCamp.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private IApplicationVersionService _applicationVersionService;
        public FirstViewModel(IApplicationVersionService applicationVersionService)
        {
            _applicationVersionService = applicationVersionService;         
        }

        public string ApplicationVersionString
        {
            get
            {
                return string.Format("{0} ({1})",
                                     _applicationVersionService.ApplicationVersion,
                                     _applicationVersionService.ApplicationBuildNumber);
            }
        }

        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        private IMvxCommand _showDetailsCommand;
        public IMvxCommand ShowDetailsCommand
        {
            get
            {
                if (_showDetailsCommand == null)
                {
                    _showDetailsCommand = new MvxCommand<FirstViewModel>(ShowDetails);
                }

                return _showDetailsCommand;
            }
        }

        protected void ShowDetails(FirstViewModel vm)
        {
            ShowViewModel<DetailsViewModel>();
        }
    }
}
