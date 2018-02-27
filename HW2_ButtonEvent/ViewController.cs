using System;

using UIKit;

namespace HW2_ButtonEvent
{
    public partial class ViewController : UIViewController
    {
        partial void UIButton199_TouchUpInside(UIButton sender)
        {
            Console.WriteLine("[UIButton199] click");

            var name = NameTextView.Text;

            HelloLabel.Text = "Hello " + name;

           // throw new NotImplementedException();
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("View did Load()..."); 



        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
