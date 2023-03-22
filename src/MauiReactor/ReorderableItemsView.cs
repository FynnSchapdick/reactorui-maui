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
    public partial interface IReorderableItemsView : IGroupableItemsView
    {
        PropertyValue<bool>? CanMixGroups { get; set; }

        PropertyValue<bool>? CanReorderItems { get; set; }

        Action? ReorderCompletedAction { get; set; }

        Action<object?, EventArgs>? ReorderCompletedActionWithArgs { get; set; }
    }

    public partial class ReorderableItemsView<T> : GroupableItemsView<T>, IReorderableItemsView where T : Microsoft.Maui.Controls.ReorderableItemsView, new()
    {
        public ReorderableItemsView()
        {
        }

        public ReorderableItemsView(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<bool>? IReorderableItemsView.CanMixGroups { get; set; }

        PropertyValue<bool>? IReorderableItemsView.CanReorderItems { get; set; }

        Action? IReorderableItemsView.ReorderCompletedAction { get; set; }

        Action<object?, EventArgs>? IReorderableItemsView.ReorderCompletedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIReorderableItemsView = (IReorderableItemsView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty, thisAsIReorderableItemsView.CanMixGroups);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty, thisAsIReorderableItemsView.CanReorderItems);
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
            var thisAsIReorderableItemsView = (IReorderableItemsView)this;
            if (thisAsIReorderableItemsView.ReorderCompletedAction != null || thisAsIReorderableItemsView.ReorderCompletedActionWithArgs != null)
            {
                NativeControl.ReorderCompleted += NativeControl_ReorderCompleted;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_ReorderCompleted(object? sender, EventArgs e)
        {
            var thisAsIReorderableItemsView = (IReorderableItemsView)this;
            thisAsIReorderableItemsView.ReorderCompletedAction?.Invoke();
            thisAsIReorderableItemsView.ReorderCompletedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.ReorderCompleted -= NativeControl_ReorderCompleted;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class ReorderableItemsView : ReorderableItemsView<Microsoft.Maui.Controls.ReorderableItemsView>
    {
        public ReorderableItemsView()
        {
        }

        public ReorderableItemsView(Action<Microsoft.Maui.Controls.ReorderableItemsView?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class ReorderableItemsViewExtensions
    {
        public static T CanMixGroups<T>(this T reorderableItemsView, bool canMixGroups)
            where T : IReorderableItemsView
        {
            reorderableItemsView.CanMixGroups = new PropertyValue<bool>(canMixGroups);
            return reorderableItemsView;
        }

        public static T CanMixGroups<T>(this T reorderableItemsView, Func<bool> canMixGroupsFunc)
            where T : IReorderableItemsView
        {
            reorderableItemsView.CanMixGroups = new PropertyValue<bool>(canMixGroupsFunc);
            return reorderableItemsView;
        }

        public static T CanReorderItems<T>(this T reorderableItemsView, bool canReorderItems)
            where T : IReorderableItemsView
        {
            reorderableItemsView.CanReorderItems = new PropertyValue<bool>(canReorderItems);
            return reorderableItemsView;
        }

        public static T CanReorderItems<T>(this T reorderableItemsView, Func<bool> canReorderItemsFunc)
            where T : IReorderableItemsView
        {
            reorderableItemsView.CanReorderItems = new PropertyValue<bool>(canReorderItemsFunc);
            return reorderableItemsView;
        }

        public static T OnReorderCompleted<T>(this T reorderableItemsView, Action? reorderCompletedAction)
            where T : IReorderableItemsView
        {
            reorderableItemsView.ReorderCompletedAction = reorderCompletedAction;
            return reorderableItemsView;
        }

        public static T OnReorderCompleted<T>(this T reorderableItemsView, Action<object?, EventArgs>? reorderCompletedActionWithArgs)
            where T : IReorderableItemsView
        {
            reorderableItemsView.ReorderCompletedActionWithArgs = reorderCompletedActionWithArgs;
            return reorderableItemsView;
        }
    }
}