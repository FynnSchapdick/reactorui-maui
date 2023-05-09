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
    public partial interface IListView : IGenericItemsView
    {
        PropertyValue<bool>? IsPullToRefreshEnabled { get; set; }

        PropertyValue<bool>? IsRefreshing { get; set; }

        PropertyValue<object>? SelectedItem { get; set; }

        PropertyValue<Microsoft.Maui.Controls.ListViewSelectionMode>? SelectionMode { get; set; }

        PropertyValue<bool>? HasUnevenRows { get; set; }

        PropertyValue<int>? RowHeight { get; set; }

        PropertyValue<bool>? IsGroupingEnabled { get; set; }

        PropertyValue<Microsoft.Maui.Controls.SeparatorVisibility>? SeparatorVisibility { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? SeparatorColor { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? RefreshControlColor { get; set; }

        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? HorizontalScrollBarVisibility { get; set; }

        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? VerticalScrollBarVisibility { get; set; }

        Action? ItemAppearingAction { get; set; }

        Action<object?, ItemVisibilityEventArgs>? ItemAppearingActionWithArgs { get; set; }

        Action? ItemDisappearingAction { get; set; }

        Action<object?, ItemVisibilityEventArgs>? ItemDisappearingActionWithArgs { get; set; }

        Action? ItemSelectedAction { get; set; }

        Action<object?, SelectedItemChangedEventArgs>? ItemSelectedActionWithArgs { get; set; }

        Action? ItemTappedAction { get; set; }

        Action<object?, ItemTappedEventArgs>? ItemTappedActionWithArgs { get; set; }

        Action? ScrolledAction { get; set; }

        Action<object?, ScrolledEventArgs>? ScrolledActionWithArgs { get; set; }

        Action? RefreshingAction { get; set; }

        Action<object?, EventArgs>? RefreshingActionWithArgs { get; set; }
    }

    public abstract partial class ListView<T> : ItemsView<T, Microsoft.Maui.Controls.Cell>, IListView where T : Microsoft.Maui.Controls.ListView, new()
    {
        public ListView()
        {
        }

        public ListView(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<bool>? IListView.IsPullToRefreshEnabled { get; set; }

        PropertyValue<bool>? IListView.IsRefreshing { get; set; }

        PropertyValue<object>? IListView.SelectedItem { get; set; }

        PropertyValue<Microsoft.Maui.Controls.ListViewSelectionMode>? IListView.SelectionMode { get; set; }

        PropertyValue<bool>? IListView.HasUnevenRows { get; set; }

        PropertyValue<int>? IListView.RowHeight { get; set; }

        PropertyValue<bool>? IListView.IsGroupingEnabled { get; set; }

        PropertyValue<Microsoft.Maui.Controls.SeparatorVisibility>? IListView.SeparatorVisibility { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? IListView.SeparatorColor { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? IListView.RefreshControlColor { get; set; }

        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? IListView.HorizontalScrollBarVisibility { get; set; }

        PropertyValue<Microsoft.Maui.ScrollBarVisibility>? IListView.VerticalScrollBarVisibility { get; set; }

        Action? IListView.ItemAppearingAction { get; set; }

        Action<object?, ItemVisibilityEventArgs>? IListView.ItemAppearingActionWithArgs { get; set; }

        Action? IListView.ItemDisappearingAction { get; set; }

        Action<object?, ItemVisibilityEventArgs>? IListView.ItemDisappearingActionWithArgs { get; set; }

        Action? IListView.ItemSelectedAction { get; set; }

        Action<object?, SelectedItemChangedEventArgs>? IListView.ItemSelectedActionWithArgs { get; set; }

        Action? IListView.ItemTappedAction { get; set; }

        Action<object?, ItemTappedEventArgs>? IListView.ItemTappedActionWithArgs { get; set; }

        Action? IListView.ScrolledAction { get; set; }

        Action<object?, ScrolledEventArgs>? IListView.ScrolledActionWithArgs { get; set; }

        Action? IListView.RefreshingAction { get; set; }

        Action<object?, EventArgs>? IListView.RefreshingActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIListView = (IListView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.IsPullToRefreshEnabledProperty, thisAsIListView.IsPullToRefreshEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.IsRefreshingProperty, thisAsIListView.IsRefreshing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.SelectedItemProperty, thisAsIListView.SelectedItem);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.SelectionModeProperty, thisAsIListView.SelectionMode);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.HasUnevenRowsProperty, thisAsIListView.HasUnevenRows);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.RowHeightProperty, thisAsIListView.RowHeight);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.IsGroupingEnabledProperty, thisAsIListView.IsGroupingEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.SeparatorVisibilityProperty, thisAsIListView.SeparatorVisibility);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.SeparatorColorProperty, thisAsIListView.SeparatorColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.RefreshControlColorProperty, thisAsIListView.RefreshControlColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.HorizontalScrollBarVisibilityProperty, thisAsIListView.HorizontalScrollBarVisibility);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ListView.VerticalScrollBarVisibilityProperty, thisAsIListView.VerticalScrollBarVisibility);
            base.OnUpdate();
            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIListView = (IListView)this;
            if (thisAsIListView.ItemAppearingAction != null || thisAsIListView.ItemAppearingActionWithArgs != null)
            {
                NativeControl.ItemAppearing += NativeControl_ItemAppearing;
            }

            if (thisAsIListView.ItemDisappearingAction != null || thisAsIListView.ItemDisappearingActionWithArgs != null)
            {
                NativeControl.ItemDisappearing += NativeControl_ItemDisappearing;
            }

            if (thisAsIListView.ItemSelectedAction != null || thisAsIListView.ItemSelectedActionWithArgs != null)
            {
                NativeControl.ItemSelected += NativeControl_ItemSelected;
            }

            if (thisAsIListView.ItemTappedAction != null || thisAsIListView.ItemTappedActionWithArgs != null)
            {
                NativeControl.ItemTapped += NativeControl_ItemTapped;
            }

            if (thisAsIListView.ScrolledAction != null || thisAsIListView.ScrolledActionWithArgs != null)
            {
                NativeControl.Scrolled += NativeControl_Scrolled;
            }

            if (thisAsIListView.RefreshingAction != null || thisAsIListView.RefreshingActionWithArgs != null)
            {
                NativeControl.Refreshing += NativeControl_Refreshing;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_ItemAppearing(object? sender, ItemVisibilityEventArgs e)
        {
            var thisAsIListView = (IListView)this;
            thisAsIListView.ItemAppearingAction?.Invoke();
            thisAsIListView.ItemAppearingActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ItemDisappearing(object? sender, ItemVisibilityEventArgs e)
        {
            var thisAsIListView = (IListView)this;
            thisAsIListView.ItemDisappearingAction?.Invoke();
            thisAsIListView.ItemDisappearingActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ItemSelected(object? sender, SelectedItemChangedEventArgs e)
        {
            var thisAsIListView = (IListView)this;
            thisAsIListView.ItemSelectedAction?.Invoke();
            thisAsIListView.ItemSelectedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_ItemTapped(object? sender, ItemTappedEventArgs e)
        {
            var thisAsIListView = (IListView)this;
            thisAsIListView.ItemTappedAction?.Invoke();
            thisAsIListView.ItemTappedActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Scrolled(object? sender, ScrolledEventArgs e)
        {
            var thisAsIListView = (IListView)this;
            thisAsIListView.ScrolledAction?.Invoke();
            thisAsIListView.ScrolledActionWithArgs?.Invoke(sender, e);
        }

        private void NativeControl_Refreshing(object? sender, EventArgs e)
        {
            var thisAsIListView = (IListView)this;
            thisAsIListView.RefreshingAction?.Invoke();
            thisAsIListView.RefreshingActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.ItemAppearing -= NativeControl_ItemAppearing;
                NativeControl.ItemDisappearing -= NativeControl_ItemDisappearing;
                NativeControl.ItemSelected -= NativeControl_ItemSelected;
                NativeControl.ItemTapped -= NativeControl_ItemTapped;
                NativeControl.Scrolled -= NativeControl_Scrolled;
                NativeControl.Refreshing -= NativeControl_Refreshing;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class ListView : ListView<Microsoft.Maui.Controls.ListView>
    {
        public ListView()
        {
        }

        public ListView(Action<Microsoft.Maui.Controls.ListView?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class ListViewExtensions
    {
        public static T IsPullToRefreshEnabled<T>(this T listView, bool isPullToRefreshEnabled)
            where T : IListView
        {
            listView.IsPullToRefreshEnabled = new PropertyValue<bool>(isPullToRefreshEnabled);
            return listView;
        }

        public static T IsPullToRefreshEnabled<T>(this T listView, Func<bool> isPullToRefreshEnabledFunc)
            where T : IListView
        {
            listView.IsPullToRefreshEnabled = new PropertyValue<bool>(isPullToRefreshEnabledFunc);
            return listView;
        }

        public static T IsRefreshing<T>(this T listView, bool isRefreshing)
            where T : IListView
        {
            listView.IsRefreshing = new PropertyValue<bool>(isRefreshing);
            return listView;
        }

        public static T IsRefreshing<T>(this T listView, Func<bool> isRefreshingFunc)
            where T : IListView
        {
            listView.IsRefreshing = new PropertyValue<bool>(isRefreshingFunc);
            return listView;
        }

        public static T SelectedItem<T>(this T listView, object selectedItem)
            where T : IListView
        {
            listView.SelectedItem = new PropertyValue<object>(selectedItem);
            return listView;
        }

        public static T SelectedItem<T>(this T listView, Func<object> selectedItemFunc)
            where T : IListView
        {
            listView.SelectedItem = new PropertyValue<object>(selectedItemFunc);
            return listView;
        }

        public static T SelectionMode<T>(this T listView, Microsoft.Maui.Controls.ListViewSelectionMode selectionMode)
            where T : IListView
        {
            listView.SelectionMode = new PropertyValue<Microsoft.Maui.Controls.ListViewSelectionMode>(selectionMode);
            return listView;
        }

        public static T SelectionMode<T>(this T listView, Func<Microsoft.Maui.Controls.ListViewSelectionMode> selectionModeFunc)
            where T : IListView
        {
            listView.SelectionMode = new PropertyValue<Microsoft.Maui.Controls.ListViewSelectionMode>(selectionModeFunc);
            return listView;
        }

        public static T HasUnevenRows<T>(this T listView, bool hasUnevenRows)
            where T : IListView
        {
            listView.HasUnevenRows = new PropertyValue<bool>(hasUnevenRows);
            return listView;
        }

        public static T HasUnevenRows<T>(this T listView, Func<bool> hasUnevenRowsFunc)
            where T : IListView
        {
            listView.HasUnevenRows = new PropertyValue<bool>(hasUnevenRowsFunc);
            return listView;
        }

        public static T RowHeight<T>(this T listView, int rowHeight)
            where T : IListView
        {
            listView.RowHeight = new PropertyValue<int>(rowHeight);
            return listView;
        }

        public static T RowHeight<T>(this T listView, Func<int> rowHeightFunc)
            where T : IListView
        {
            listView.RowHeight = new PropertyValue<int>(rowHeightFunc);
            return listView;
        }

        public static T IsGroupingEnabled<T>(this T listView, bool isGroupingEnabled)
            where T : IListView
        {
            listView.IsGroupingEnabled = new PropertyValue<bool>(isGroupingEnabled);
            return listView;
        }

        public static T IsGroupingEnabled<T>(this T listView, Func<bool> isGroupingEnabledFunc)
            where T : IListView
        {
            listView.IsGroupingEnabled = new PropertyValue<bool>(isGroupingEnabledFunc);
            return listView;
        }

        public static T SeparatorVisibility<T>(this T listView, Microsoft.Maui.Controls.SeparatorVisibility separatorVisibility)
            where T : IListView
        {
            listView.SeparatorVisibility = new PropertyValue<Microsoft.Maui.Controls.SeparatorVisibility>(separatorVisibility);
            return listView;
        }

        public static T SeparatorVisibility<T>(this T listView, Func<Microsoft.Maui.Controls.SeparatorVisibility> separatorVisibilityFunc)
            where T : IListView
        {
            listView.SeparatorVisibility = new PropertyValue<Microsoft.Maui.Controls.SeparatorVisibility>(separatorVisibilityFunc);
            return listView;
        }

        public static T SeparatorColor<T>(this T listView, Microsoft.Maui.Graphics.Color separatorColor)
            where T : IListView
        {
            listView.SeparatorColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(separatorColor);
            return listView;
        }

        public static T SeparatorColor<T>(this T listView, Func<Microsoft.Maui.Graphics.Color> separatorColorFunc)
            where T : IListView
        {
            listView.SeparatorColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(separatorColorFunc);
            return listView;
        }

        public static T RefreshControlColor<T>(this T listView, Microsoft.Maui.Graphics.Color refreshControlColor)
            where T : IListView
        {
            listView.RefreshControlColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(refreshControlColor);
            return listView;
        }

        public static T RefreshControlColor<T>(this T listView, Func<Microsoft.Maui.Graphics.Color> refreshControlColorFunc)
            where T : IListView
        {
            listView.RefreshControlColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(refreshControlColorFunc);
            return listView;
        }

        public static T HorizontalScrollBarVisibility<T>(this T listView, Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : IListView
        {
            listView.HorizontalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(horizontalScrollBarVisibility);
            return listView;
        }

        public static T HorizontalScrollBarVisibility<T>(this T listView, Func<Microsoft.Maui.ScrollBarVisibility> horizontalScrollBarVisibilityFunc)
            where T : IListView
        {
            listView.HorizontalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(horizontalScrollBarVisibilityFunc);
            return listView;
        }

        public static T VerticalScrollBarVisibility<T>(this T listView, Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : IListView
        {
            listView.VerticalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(verticalScrollBarVisibility);
            return listView;
        }

        public static T VerticalScrollBarVisibility<T>(this T listView, Func<Microsoft.Maui.ScrollBarVisibility> verticalScrollBarVisibilityFunc)
            where T : IListView
        {
            listView.VerticalScrollBarVisibility = new PropertyValue<Microsoft.Maui.ScrollBarVisibility>(verticalScrollBarVisibilityFunc);
            return listView;
        }

        public static T OnItemAppearing<T>(this T listView, Action? itemAppearingAction)
            where T : IListView
        {
            listView.ItemAppearingAction = itemAppearingAction;
            return listView;
        }

        public static T OnItemAppearing<T>(this T listView, Action<object?, ItemVisibilityEventArgs>? itemAppearingActionWithArgs)
            where T : IListView
        {
            listView.ItemAppearingActionWithArgs = itemAppearingActionWithArgs;
            return listView;
        }

        public static T OnItemDisappearing<T>(this T listView, Action? itemDisappearingAction)
            where T : IListView
        {
            listView.ItemDisappearingAction = itemDisappearingAction;
            return listView;
        }

        public static T OnItemDisappearing<T>(this T listView, Action<object?, ItemVisibilityEventArgs>? itemDisappearingActionWithArgs)
            where T : IListView
        {
            listView.ItemDisappearingActionWithArgs = itemDisappearingActionWithArgs;
            return listView;
        }

        public static T OnItemSelected<T>(this T listView, Action? itemSelectedAction)
            where T : IListView
        {
            listView.ItemSelectedAction = itemSelectedAction;
            return listView;
        }

        public static T OnItemSelected<T>(this T listView, Action<object?, SelectedItemChangedEventArgs>? itemSelectedActionWithArgs)
            where T : IListView
        {
            listView.ItemSelectedActionWithArgs = itemSelectedActionWithArgs;
            return listView;
        }

        public static T OnItemTapped<T>(this T listView, Action? itemTappedAction)
            where T : IListView
        {
            listView.ItemTappedAction = itemTappedAction;
            return listView;
        }

        public static T OnItemTapped<T>(this T listView, Action<object?, ItemTappedEventArgs>? itemTappedActionWithArgs)
            where T : IListView
        {
            listView.ItemTappedActionWithArgs = itemTappedActionWithArgs;
            return listView;
        }

        public static T OnScrolled<T>(this T listView, Action? scrolledAction)
            where T : IListView
        {
            listView.ScrolledAction = scrolledAction;
            return listView;
        }

        public static T OnScrolled<T>(this T listView, Action<object?, ScrolledEventArgs>? scrolledActionWithArgs)
            where T : IListView
        {
            listView.ScrolledActionWithArgs = scrolledActionWithArgs;
            return listView;
        }

        public static T OnRefreshing<T>(this T listView, Action? refreshingAction)
            where T : IListView
        {
            listView.RefreshingAction = refreshingAction;
            return listView;
        }

        public static T OnRefreshing<T>(this T listView, Action<object?, EventArgs>? refreshingActionWithArgs)
            where T : IListView
        {
            listView.RefreshingActionWithArgs = refreshingActionWithArgs;
            return listView;
        }
    }
}