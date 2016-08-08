using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using XamBootCamp.Localization;

namespace XamBootCamp.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = AppResources.FirstView_Title;

            var set = this.CreateBindingSet<FirstView, XamBootCamp.ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Bind(GoDetailsButton).To(vm => vm.ShowDetailsCommand);
            set.Apply();
        }
    }
}
