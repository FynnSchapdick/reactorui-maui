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
    public partial interface IMenuFlyoutSeparator : IMenuFlyoutItem
    {
    }

    public partial class MenuFlyoutSeparator<T> : MenuFlyoutItem<T>, IMenuFlyoutSeparator where T : Microsoft.Maui.Controls.MenuFlyoutSeparator, new()
    {
        public MenuFlyoutSeparator()
        {
        }

        public MenuFlyoutSeparator(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            base.OnUpdate();
            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
    }

    public partial class MenuFlyoutSeparator : MenuFlyoutSeparator<Microsoft.Maui.Controls.MenuFlyoutSeparator>
    {
        public MenuFlyoutSeparator()
        {
        }

        public MenuFlyoutSeparator(Action<Microsoft.Maui.Controls.MenuFlyoutSeparator?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class MenuFlyoutSeparatorExtensions
    {
    }
}