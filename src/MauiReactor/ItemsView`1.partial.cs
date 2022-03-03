using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;
using System.Collections;

namespace MauiReactor
{
    public partial interface IGenericItemsView : IItemsViewWithSource
    {
    }

    public abstract partial class ItemsView<T, TChild>
    {
        IEnumerable? IItemsViewWithSource.ItemsSource { get; set; }

        Func<object, VisualNode>? IItemsViewWithSource.ItemTemplate { get; set; }

        public VisualStateGroupList ItemVisualStateGroups { get; set; } = new VisualStateGroupList();

        private class ItemTemplateNode : VisualNode, IHostElement
        {
            private readonly ItemTemplatePresenter? _presenter = null;
            private readonly VisualNode _owner;

            public ItemTemplateNode(VisualNode root, ItemTemplatePresenter presenter, VisualNode owner)
            {
                _root = root;
                _presenter = presenter;
                _owner = owner;

                Invalidate();
            }

            private VisualNode _root;

            private IHostElement GetPageHost()
            {
                var current = _owner;
                while (current != null && current is not IHostElement)
                    current = current.Parent;

                return Validate.EnsureNotNull(current as IHostElement);
            }

            public VisualNode Root
            {
                get => _root;
                set
                {
                    if (_root != value)
                    {
                        _root = value;
                        Invalidate();
                    }
                    else
                    {
                        _root.Update();
                    }
                }
            }

            public Microsoft.Maui.Controls.Page? ContainerPage => GetPageHost().ContainerPage;

            protected sealed override void OnAddChild(VisualNode widget, BindableObject nativeControl)
            {
                Validate.EnsureNotNull(_presenter);

                if (nativeControl is View view)
                    _presenter.Content = view;
                else
                {
                    throw new InvalidOperationException($"Type '{nativeControl.GetType()}' not supported under '{GetType()}'");
                }
            }

            protected sealed override void OnRemoveChild(VisualNode widget, BindableObject nativeControl)
            {
            }

            protected override IEnumerable<VisualNode> RenderChildren()
            {
                yield return Root;
            }

            protected internal override void OnLayoutCycleRequested()
            {
                Layout();
                base.OnLayoutCycleRequested();
            }

            public IHostElement Run()
            {
                var ownerPageHost = GetPageHost();
                if (ownerPageHost == null)
                {
                    throw new NotSupportedException();
                }

                return ownerPageHost.Run();
            }

            public void Stop()
            {
                var ownerPageHost = GetPageHost();
                if (ownerPageHost == null)
                {
                    throw new NotSupportedException();
                }

                ownerPageHost.Stop();
            }
        }

        private class ItemTemplatePresenter : Microsoft.Maui.Controls.ContentView
        {
            private ItemTemplateNode? _itemTemplateNode;
            private readonly CustomDataTemplate _template;

            public ItemTemplatePresenter(CustomDataTemplate template)
            {
                _template = template;
                VisualStateManager.SetVisualStateGroups(this, template.Owner.ItemVisualStateGroups);
            }

            protected override void OnBindingContextChanged()
            {
                while (true)
                {
                    var item = BindingContext;

                    if (item == null)
                        break;

                    VisualNode? newRoot = _template.GetVisualNodeForItem(item);

                    if (newRoot == null)
                        break;

                    if (_itemTemplateNode != null)
                    {
                        _itemTemplateNode.Root = newRoot;
                    }
                    else
                    {
                        _itemTemplateNode = new ItemTemplateNode(newRoot, this, _template.Owner);
                        _itemTemplateNode.Layout();
                    }

                    break;
                }

                base.OnBindingContextChanged();
            }
        }

        private class CustomDataTemplate
        {
            public DataTemplate DataTemplate { get; }
            public ItemsView<T, TChild> Owner { get; set; }

            public CustomDataTemplate(ItemsView<T, TChild> owner)
            {
                Owner = owner;
                DataTemplate = new DataTemplate(() => new ItemTemplatePresenter(this));
            }

            public VisualNode? GetVisualNodeForItem(object item)
            {
                IItemsViewWithSource itemsView = Owner;

                if (itemsView.ItemTemplate != null)
                {
                    return itemsView.ItemTemplate(item);
                }

                return null;
            }
        }

        private CustomDataTemplate? _customDataTemplate;

        partial void OnBeginUpdate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIItemsView = (IItemsView)this;

            if (NativeControl.ItemsSource is ObservableItemsSource existingCollection &&
                existingCollection.ItemsSource == thisAsIItemsView.ItemsSource)
            {
                Validate.EnsureNotNull(_customDataTemplate);

                _customDataTemplate.Owner = this;
                existingCollection.NotifyCollectionChanged();
            }
            else if (thisAsIItemsView.ItemsSource != null)
            {
                _customDataTemplate = new CustomDataTemplate(this);
                NativeControl.ItemsSource = ObservableItemsSource.Create(thisAsIItemsView.ItemsSource);
                NativeControl.ItemTemplate = _customDataTemplate.DataTemplate;
            }
            else
            {
                NativeControl.ItemsSource = null;
                NativeControl.ItemTemplate = null;
            }
        }

        protected override void OnMigrated(VisualNode newNode)
        {
            ((ItemsView<T, TChild>)newNode)._customDataTemplate = _customDataTemplate;

            base.OnMigrated(newNode);
        }
    }

}
