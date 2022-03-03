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
    public partial interface IFlyoutItem : IShellItem
    {


    }

    public partial class FlyoutItem<T> : ShellItem<T>, IFlyoutItem where T : Microsoft.Maui.Controls.FlyoutItem, new()
    {
        public FlyoutItem()
        {

        }

        public FlyoutItem(Action<T?> componentRefAction)
            : base(componentRefAction)
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


    }

    public partial class FlyoutItem : FlyoutItem<Microsoft.Maui.Controls.FlyoutItem>
    {
        public FlyoutItem()
        {

        }

        public FlyoutItem(Action<Microsoft.Maui.Controls.FlyoutItem?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class FlyoutItemExtensions
    {

    }
}
