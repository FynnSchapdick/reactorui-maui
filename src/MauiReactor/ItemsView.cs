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
    public partial interface IItemsView : IView
    {
        PropertyValue<object>? EmptyView { get; set; }
        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? HorizontalScrollBarVisibility { get; set; }
        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? VerticalScrollBarVisibility { get; set; }
        PropertyValue<int>? RemainingItemsThreshold { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>? ItemsUpdatingScrollMode { get; set; }

        Action? ScrollToRequestedAction { get; set; }
        Action<object?, ScrollToRequestEventArgs>? ScrollToRequestedActionWithArgs { get; set; }
        Action? ScrolledAction { get; set; }
        Action<object?, ItemsViewScrolledEventArgs>? ScrolledActionWithArgs { get; set; }
        Action? RemainingItemsThresholdReachedAction { get; set; }
        Action<object?, EventArgs>? RemainingItemsThresholdReachedActionWithArgs { get; set; }

    }

    public abstract partial class ItemsView<T> : View<T>, IItemsView where T : Microsoft.Maui.Controls.ItemsView, new()
    {
        protected ItemsView()
        {

        }

        protected ItemsView(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<object>? IItemsView.EmptyView { get; set; }
        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? IItemsView.HorizontalScrollBarVisibility { get; set; }
        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? IItemsView.VerticalScrollBarVisibility { get; set; }
        PropertyValue<int>? IItemsView.RemainingItemsThreshold { get; set; }
        PropertyValue<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>? IItemsView.ItemsUpdatingScrollMode { get; set; }

        Action? IItemsView.ScrollToRequestedAction { get; set; }
        Action<object?, ScrollToRequestEventArgs>? IItemsView.ScrollToRequestedActionWithArgs { get; set; }
        Action? IItemsView.ScrolledAction { get; set; }
        Action<object?, ItemsViewScrolledEventArgs>? IItemsView.ScrolledActionWithArgs { get; set; }
        Action? IItemsView.RemainingItemsThresholdReachedAction { get; set; }
        Action<object?, EventArgs>? IItemsView.RemainingItemsThresholdReachedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIItemsView = (IItemsView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsView.EmptyViewProperty, thisAsIItemsView.EmptyView);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty, thisAsIItemsView.HorizontalScrollBarVisibility);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty, thisAsIItemsView.VerticalScrollBarVisibility);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty, thisAsIItemsView.RemainingItemsThreshold);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty, thisAsIItemsView.ItemsUpdatingScrollMode);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIItemsView = (IItemsView)this;
            if (thisAsIItemsView.ScrollToRequestedAction != null || thisAsIItemsView.ScrollToRequestedActionWithArgs != null)
            {
                NativeControl.ScrollToRequested += NativeControl_ScrollToRequested;
            }
            if (thisAsIItemsView.ScrolledAction != null || thisAsIItemsView.ScrolledActionWithArgs != null)
            {
                NativeControl.Scrolled += NativeControl_Scrolled;
            }
            if (thisAsIItemsView.RemainingItemsThresholdReachedAction != null || thisAsIItemsView.RemainingItemsThresholdReachedActionWithArgs != null)
            {
                NativeControl.RemainingItemsThresholdReached += NativeControl_RemainingItemsThresholdReached;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_ScrollToRequested(object? sender, ScrollToRequestEventArgs e)
        {
            var thisAsIItemsView = (IItemsView)this;
            thisAsIItemsView.ScrollToRequestedAction?.Invoke();
            thisAsIItemsView.ScrollToRequestedActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_Scrolled(object? sender, ItemsViewScrolledEventArgs e)
        {
            var thisAsIItemsView = (IItemsView)this;
            thisAsIItemsView.ScrolledAction?.Invoke();
            thisAsIItemsView.ScrolledActionWithArgs?.Invoke(sender, e);
        }
        private void NativeControl_RemainingItemsThresholdReached(object? sender, EventArgs e)
        {
            var thisAsIItemsView = (IItemsView)this;
            thisAsIItemsView.RemainingItemsThresholdReachedAction?.Invoke();
            thisAsIItemsView.RemainingItemsThresholdReachedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.ScrollToRequested -= NativeControl_ScrollToRequested;
                NativeControl.Scrolled -= NativeControl_Scrolled;
                NativeControl.RemainingItemsThresholdReached -= NativeControl_RemainingItemsThresholdReached;
            }

            base.OnDetachNativeEvents();
        }

    }


    public static partial class ItemsViewExtensions
    {
        public static T EmptyView<T>(this T itemsView, object emptyView) where T : IItemsView
        {
            itemsView.EmptyView = new PropertyValue<object>(emptyView);
            return itemsView;
        }

        public static T EmptyView<T>(this T itemsView, Func<object> emptyViewFunc) where T : IItemsView
        {
            itemsView.EmptyView = new PropertyValue<object>(emptyViewFunc);
            return itemsView;
        }



        public static T HorizontalScrollBarVisibility<T>(this T itemsView, Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility) where T : IItemsView
        {
            itemsView.HorizontalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(horizontalScrollBarVisibility);
            return itemsView;
        }

        public static T HorizontalScrollBarVisibility<T>(this T itemsView, Func<Microsoft.Maui.ScrollBarVisibility> horizontalScrollBarVisibilityFunc) where T : IItemsView
        {
            itemsView.HorizontalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(horizontalScrollBarVisibilityFunc);
            return itemsView;
        }



        public static T VerticalScrollBarVisibility<T>(this T itemsView, Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility) where T : IItemsView
        {
            itemsView.VerticalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(verticalScrollBarVisibility);
            return itemsView;
        }

        public static T VerticalScrollBarVisibility<T>(this T itemsView, Func<Microsoft.Maui.ScrollBarVisibility> verticalScrollBarVisibilityFunc) where T : IItemsView
        {
            itemsView.VerticalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(verticalScrollBarVisibilityFunc);
            return itemsView;
        }



        public static T RemainingItemsThreshold<T>(this T itemsView, int remainingItemsThreshold) where T : IItemsView
        {
            itemsView.RemainingItemsThreshold = new PropertyValue<int>(remainingItemsThreshold);
            return itemsView;
        }

        public static T RemainingItemsThreshold<T>(this T itemsView, Func<int> remainingItemsThresholdFunc) where T : IItemsView
        {
            itemsView.RemainingItemsThreshold = new PropertyValue<int>(remainingItemsThresholdFunc);
            return itemsView;
        }



        public static T ItemsUpdatingScrollMode<T>(this T itemsView, Microsoft.Maui.Controls.ItemsUpdatingScrollMode itemsUpdatingScrollMode) where T : IItemsView
        {
            itemsView.ItemsUpdatingScrollMode = new PropertyValue<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>(itemsUpdatingScrollMode);
            return itemsView;
        }

        public static T ItemsUpdatingScrollMode<T>(this T itemsView, Func<Microsoft.Maui.Controls.ItemsUpdatingScrollMode> itemsUpdatingScrollModeFunc) where T : IItemsView
        {
            itemsView.ItemsUpdatingScrollMode = new PropertyValue<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>(itemsUpdatingScrollModeFunc);
            return itemsView;
        }




        public static T OnScrollToRequested<T>(this T itemsView, Action scrollToRequestedAction) where T : IItemsView
        {
            itemsView.ScrollToRequestedAction = scrollToRequestedAction;
            return itemsView;
        }

        public static T OnScrollToRequested<T>(this T itemsView, Action<object?, ScrollToRequestEventArgs> scrollToRequestedActionWithArgs) where T : IItemsView
        {
            itemsView.ScrollToRequestedActionWithArgs = scrollToRequestedActionWithArgs;
            return itemsView;
        }
        public static T OnScrolled<T>(this T itemsView, Action scrolledAction) where T : IItemsView
        {
            itemsView.ScrolledAction = scrolledAction;
            return itemsView;
        }

        public static T OnScrolled<T>(this T itemsView, Action<object?, ItemsViewScrolledEventArgs> scrolledActionWithArgs) where T : IItemsView
        {
            itemsView.ScrolledActionWithArgs = scrolledActionWithArgs;
            return itemsView;
        }
        public static T OnRemainingItemsThresholdReached<T>(this T itemsView, Action remainingItemsThresholdReachedAction) where T : IItemsView
        {
            itemsView.RemainingItemsThresholdReachedAction = remainingItemsThresholdReachedAction;
            return itemsView;
        }

        public static T OnRemainingItemsThresholdReached<T>(this T itemsView, Action<object?, EventArgs> remainingItemsThresholdReachedActionWithArgs) where T : IItemsView
        {
            itemsView.RemainingItemsThresholdReachedActionWithArgs = remainingItemsThresholdReachedActionWithArgs;
            return itemsView;
        }
    }
}
