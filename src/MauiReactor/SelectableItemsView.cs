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
    public partial interface ISelectableItemsView : IStructuredItemsView
    {
        PropertyValue<Microsoft.Maui.Controls.SelectionMode>? SelectionMode { get; set; }

        PropertyValue<object>? SelectedItem { get; set; }

        Action? SelectionChangedAction { get; set; }

        Action<object?, SelectionChangedEventArgs>? SelectionChangedActionWithArgs { get; set; }
    }

    public partial class SelectableItemsView<T> : StructuredItemsView<T>, ISelectableItemsView where T : Microsoft.Maui.Controls.SelectableItemsView, new()
    {
        public SelectableItemsView()
        {
        }

        public SelectableItemsView(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<Microsoft.Maui.Controls.SelectionMode>? ISelectableItemsView.SelectionMode { get; set; }

        PropertyValue<object>? ISelectableItemsView.SelectedItem { get; set; }

        Action? ISelectableItemsView.SelectionChangedAction { get; set; }

        Action<object?, SelectionChangedEventArgs>? ISelectableItemsView.SelectionChangedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsISelectableItemsView = (ISelectableItemsView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty, thisAsISelectableItemsView.SelectionMode);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty, thisAsISelectableItemsView.SelectedItem);
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
            var thisAsISelectableItemsView = (ISelectableItemsView)this;
            if (thisAsISelectableItemsView.SelectionChangedAction != null || thisAsISelectableItemsView.SelectionChangedActionWithArgs != null)
            {
                NativeControl.SelectionChanged += NativeControl_SelectionChanged;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            var thisAsISelectableItemsView = (ISelectableItemsView)this;
            thisAsISelectableItemsView.SelectionChangedAction?.Invoke();
            thisAsISelectableItemsView.SelectionChangedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.SelectionChanged -= NativeControl_SelectionChanged;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class SelectableItemsView : SelectableItemsView<Microsoft.Maui.Controls.SelectableItemsView>
    {
        public SelectableItemsView()
        {
        }

        public SelectableItemsView(Action<Microsoft.Maui.Controls.SelectableItemsView?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class SelectableItemsViewExtensions
    {
        public static T SelectionMode<T>(this T selectableItemsView, Microsoft.Maui.Controls.SelectionMode selectionMode)
            where T : ISelectableItemsView
        {
            selectableItemsView.SelectionMode = new PropertyValue<Microsoft.Maui.Controls.SelectionMode>(selectionMode);
            return selectableItemsView;
        }

        public static T SelectionMode<T>(this T selectableItemsView, Func<Microsoft.Maui.Controls.SelectionMode> selectionModeFunc)
            where T : ISelectableItemsView
        {
            selectableItemsView.SelectionMode = new PropertyValue<Microsoft.Maui.Controls.SelectionMode>(selectionModeFunc);
            return selectableItemsView;
        }

        public static T SelectedItem<T>(this T selectableItemsView, object selectedItem)
            where T : ISelectableItemsView
        {
            selectableItemsView.SelectedItem = new PropertyValue<object>(selectedItem);
            return selectableItemsView;
        }

        public static T SelectedItem<T>(this T selectableItemsView, Func<object> selectedItemFunc)
            where T : ISelectableItemsView
        {
            selectableItemsView.SelectedItem = new PropertyValue<object>(selectedItemFunc);
            return selectableItemsView;
        }

        public static T OnSelectionChanged<T>(this T selectableItemsView, Action? selectionChangedAction)
            where T : ISelectableItemsView
        {
            selectableItemsView.SelectionChangedAction = selectionChangedAction;
            return selectableItemsView;
        }

        public static T OnSelectionChanged<T>(this T selectableItemsView, Action<object?, SelectionChangedEventArgs>? selectionChangedActionWithArgs)
            where T : ISelectableItemsView
        {
            selectableItemsView.SelectionChangedActionWithArgs = selectionChangedActionWithArgs;
            return selectableItemsView;
        }
    }
}