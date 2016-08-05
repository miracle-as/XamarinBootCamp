using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Praeclarum.UI;
using UIKit;

namespace XamBootCamp.iOS
{
    public class DetailsView : MvxViewController
    {
        protected DetailsViewModel DetailsViewModel
        {
            get { return ViewModel as DetailsViewModel; }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetupLayout();
            SetupBindings();
        }

        protected UILabel _label;
        protected UITextField _textField;

        protected void SetupLayout()
        {
            Title = "Details";

            View.BackgroundColor = UIColor.White;

            _label = new UILabel();
            View.AddSubview(_label);

            _textField = new UITextField();
            _textField.Placeholder = "Please enter your name...";
            _textField.BorderStyle = UITextBorderStyle.Line;

            View.AddSubview(_textField);

            View.ConstrainLayout(
                () =>
                _label.Frame.Left == View.Frame.Left + 20
                && _label.Frame.Top == View.Frame.Top + 100
                && _textField.Frame.Left == _label.Frame.Left
                && _textField.Frame.Top == _label.Frame.Bottom + 20
                && _textField.Frame.Width == 200
            );
        }

        protected void SetupBindings()
        {
            var set = this.CreateBindingSet<DetailsView, DetailsViewModel>();

            set.Bind(_label).To(vm => vm.Greeting);
            set.Bind(_textField).To(vm => vm.Detail);

            set.Apply();
        }
    }
}

