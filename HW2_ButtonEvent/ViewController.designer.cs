// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HW2_ButtonEvent
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HelloLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton mybutton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameTextView { get; set; }

        [Action ("UIButton199_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton199_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (HelloLabel != null) {
                HelloLabel.Dispose ();
                HelloLabel = null;
            }

            if (mybutton != null) {
                mybutton.Dispose ();
                mybutton = null;
            }

            if (NameTextView != null) {
                NameTextView.Dispose ();
                NameTextView = null;
            }
        }
    }
}