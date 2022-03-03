// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable

namespace MauiReactor
{
    public partial interface INavigationPage : IPage
    {
        PropertyValue<Microsoft.Maui.Graphics.Color>? BarBackgroundColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? BarBackground { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? BarTextColor { get; set; }

        Action? PoppedAction { get; set; }
        Action<object?, NavigationEventArgs>? PoppedActionWithArgs { get; set; }
        Action? PoppedToRootAction { get; set; }
        Action<object?, NavigationEventArgs>? PoppedToRootActionWithArgs { get; set; }
        Action? PushedAction { get; set; }
        Action<object?, NavigationEventArgs>? PushedActionWithArgs { get; set; }

    }

    public partial class NavigationPage<T> : Page<T>, INavigationPage where T : Microsoft.Maui.Controls.NavigationPage, new()
    {
        public NavigationPage()
        {

        }

        public NavigationPage(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Graphics.Color>? INavigationPage.BarBackgroundColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? INavigationPage.BarBackground { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? INavigationPage.BarTextColor { get; set; }

        Action? INavigationPage.PoppedAction { get; set; }
        Action<object?, NavigationEventArgs>? INavigationPage.PoppedActionWithArgs { get; set; }
        Action? INavigationPage.PoppedToRootAction { get; set; }
        Action<object?, NavigationEventArgs>? INavigationPage.PoppedToRootActionWithArgs { get; set; }
        Action? INavigationPage.PushedAction { get; set; }
        Action<object?, NavigationEventArgs>? INavigationPage.PushedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsINavigationPage = (INavigationPage)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.NavigationPage.BarBackgroundColorProperty, thisAsINavigationPage.BarBackgroundColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.NavigationPage.BarBackgroundProperty, thisAsINavigationPage.BarBackground);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.NavigationPage.BarTextColorProperty, thisAsINavigationPage.BarTextColor);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsINavigationPage = (INavigationPage)this;
            if (thisAsINavigationPage.PoppedAction != null || thisAsINavigationPage.PoppedActionWithArgs != null)
            {
                NativeControl.Popped += NativeControl_Popped;
            }
            if (thisAsINavigationPage.PoppedToRootAction != null || thisAsINavigationPage.PoppedToRootActionWithArgs != null)
            {
                NativeControl.PoppedToRoot += NativeControl_PoppedToRoot;
            }
            if (thisAsINavigationPage.PushedAction != null || thisAsINavigationPage.PushedActionWithArgs != null)
            {
                NativeControl.Pushed += NativeControl_Pushed;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_Popped(object? sender, NavigationEventArgs e)
        {
            var thisAsINavigationPage = (INavigationPage)this;
            thisAsINavigationPage.PoppedAction?.Invoke();
            thisAsINavigationPage.PoppedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_PoppedToRoot(object? sender, NavigationEventArgs e)
        {
            var thisAsINavigationPage = (INavigationPage)this;
            thisAsINavigationPage.PoppedToRootAction?.Invoke();
            thisAsINavigationPage.PoppedToRootActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Pushed(object? sender, NavigationEventArgs e)
        {
            var thisAsINavigationPage = (INavigationPage)this;
            thisAsINavigationPage.PushedAction?.Invoke();
            thisAsINavigationPage.PushedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Popped -= NativeControl_Popped;
                NativeControl.PoppedToRoot -= NativeControl_PoppedToRoot;
                NativeControl.Pushed -= NativeControl_Pushed;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class NavigationPage : NavigationPage<Microsoft.Maui.Controls.NavigationPage>
    {
        public NavigationPage()
        {

        }

        public NavigationPage(Action<Microsoft.Maui.Controls.NavigationPage?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class NavigationPageExtensions
    {
        public static T BarBackgroundColor<T>(this T navigationPage, Microsoft.Maui.Graphics.Color barBackgroundColor) where T : INavigationPage
        {
            navigationPage.BarBackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barBackgroundColor);
            return navigationPage;
        }

        public static T BarBackgroundColor<T>(this T navigationPage, Func<Microsoft.Maui.Graphics.Color> barBackgroundColorFunc) where T : INavigationPage
        {
            navigationPage.BarBackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barBackgroundColorFunc);
            return navigationPage;
        }



        public static T BarBackground<T>(this T navigationPage, Microsoft.Maui.Controls.Brush barBackground) where T : INavigationPage
        {
            navigationPage.BarBackground = new PropertyValue<Microsoft.Maui.Controls.Brush>(barBackground);
            return navigationPage;
        }

        public static T BarBackground<T>(this T navigationPage, Func<Microsoft.Maui.Controls.Brush> barBackgroundFunc) where T : INavigationPage
        {
            navigationPage.BarBackground = new PropertyValue<Microsoft.Maui.Controls.Brush>(barBackgroundFunc);
            return navigationPage;
        }



        public static T BarTextColor<T>(this T navigationPage, Microsoft.Maui.Graphics.Color barTextColor) where T : INavigationPage
        {
            navigationPage.BarTextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barTextColor);
            return navigationPage;
        }

        public static T BarTextColor<T>(this T navigationPage, Func<Microsoft.Maui.Graphics.Color> barTextColorFunc) where T : INavigationPage
        {
            navigationPage.BarTextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barTextColorFunc);
            return navigationPage;
        }




        public static T OnPopped<T>(this T navigationPage, Action poppedAction) where T : INavigationPage
        {
            navigationPage.PoppedAction = poppedAction;
            return navigationPage;
        }

        public static T OnPopped<T>(this T navigationPage, Action<object?, NavigationEventArgs> poppedActionWithArgs) where T : INavigationPage
        {
            navigationPage.PoppedActionWithArgs = poppedActionWithArgs;
            return navigationPage;
        }
        public static T OnPoppedToRoot<T>(this T navigationPage, Action poppedToRootAction) where T : INavigationPage
        {
            navigationPage.PoppedToRootAction = poppedToRootAction;
            return navigationPage;
        }

        public static T OnPoppedToRoot<T>(this T navigationPage, Action<object?, NavigationEventArgs> poppedToRootActionWithArgs) where T : INavigationPage
        {
            navigationPage.PoppedToRootActionWithArgs = poppedToRootActionWithArgs;
            return navigationPage;
        }
        public static T OnPushed<T>(this T navigationPage, Action pushedAction) where T : INavigationPage
        {
            navigationPage.PushedAction = pushedAction;
            return navigationPage;
        }

        public static T OnPushed<T>(this T navigationPage, Action<object?, NavigationEventArgs> pushedActionWithArgs) where T : INavigationPage
        {
            navigationPage.PushedActionWithArgs = pushedActionWithArgs;
            return navigationPage;
        }
    }
}
