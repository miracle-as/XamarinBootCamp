using System;
using MvvmCross.Core.ViewModels;

namespace XamBootCamp
{
    public class DetailsViewModel
        : MvxViewModel
    {
        public DetailsViewModel ()
        {
        }

        private string _detail;
        public string Detail 
        {
            get 
            {
                return _detail;
            }
            set 
            {
                SetProperty (ref _detail, value);
                Greeting = "Hello " + _detail;
            }
        }

        private string _greeting;
        public string Greeting
        {
            get
            {
                return _greeting;
            }
            set
            {
                SetProperty(ref _greeting, value);
            }
        }
    }
}

