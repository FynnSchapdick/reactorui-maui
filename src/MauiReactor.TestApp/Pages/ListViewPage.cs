﻿using MauiReactor.TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor.TestApp.Pages
{
    public enum ViewMode
    {
        TextCell,

        ImageCell,

        SwitchCell,

        EntryCell,

        ViewCell
    }

    public class ListViewPageState : IState
    {
        public ViewMode ViewMode { get; set; } = ViewMode.ViewCell;
    }

    public class ListViewPage : Component<ListViewPageState>
    {
        private readonly IEnumerable<Monkey> _allMonkeys = Monkey.GetList();

        private VisualNode RenderSwitchMode(ViewMode viewMode)
            => new HStack(spacing: 10)
            {
                new Label(viewMode.ToString()),
                new Switch()
                    .IsToggled(State.ViewMode == viewMode)
                    .OnToggled((s, e)=>SetState(_ => _.ViewMode = viewMode))
            };

        public override VisualNode Render()
        {
            return new ContentPage()
            {
                new Grid("Auto,*", "*")
                {
                    new StackLayout()
                    {
                        RenderSwitchMode(ViewMode.TextCell),
                        RenderSwitchMode(ViewMode.ImageCell),
                        RenderSwitchMode(ViewMode.SwitchCell),
                        RenderSwitchMode(ViewMode.EntryCell),
                        RenderSwitchMode(ViewMode.ViewCell),
                    },
                    RenderCollection()
                        .GridRow(1)
                }
            }
            .Title("ListView Test");
        }

        private ListView RenderCollection()
        {
            switch (State.ViewMode)
            {
                case ViewMode.TextCell:
                    return new ListView()
                        .ItemsSource(_allMonkeys, RenderMonkeyWithTextCell)
                        .RowHeight(64);
                case ViewMode.ImageCell:
                    return new ListView()
                        .ItemsSource(_allMonkeys, RenderMonkeyWithImageCell)
                        .RowHeight(64);
                case ViewMode.SwitchCell:
                    return new ListView()
                        .ItemsSource(_allMonkeys, RenderMonkeyWithSwitchCell)
                        .RowHeight(48);
                case ViewMode.EntryCell:
                    return new ListView()
                        .ItemsSource(_allMonkeys, RenderMonkeyWithEntryCell)
                        .RowHeight(48);
                case ViewMode.ViewCell:
                    return new ListView()
                        .ItemsSource(_allMonkeys, RenderMonkey)
                        .RowHeight(120);
            }

            throw new InvalidOperationException();
        }

        private VisualNode RenderMonkeyWithTextCell(Monkey monkey)
        {
            return new TextCell()
                .Text(monkey.Name)
                .Detail(monkey.Details);
        }

        private VisualNode RenderMonkeyWithImageCell(Monkey monkey)
        {
            return new ImageCell()
                .Text(monkey.Name)
                .Detail(monkey.Details)
                .ImageSource(monkey.ImageUrl);
        }

        private VisualNode RenderMonkeyWithSwitchCell(Monkey monkey)
        {
            return new SwitchCell()
                .Text(monkey.Name);
        }

        private VisualNode RenderMonkeyWithEntryCell(Monkey monkey)
        {
            return new EntryCell()
                .Text(monkey.Name);
        }

        private VisualNode RenderMonkey(Monkey monkey)
        {
            return new HorizontalStackLayout()
            {
                new Image()
                    .Source(new Uri(monkey.ImageUrl))
                    .Margin(4),
                new StackLayout()
                {
                    new Label(monkey.Name)
                        .FontSize(NamedSize.Default)
                        .Margin(5),
                    new Label(monkey.Location)
                        .FontSize(NamedSize.Caption)
                        .Margin(5)
                }
            }
            .Padding(10);
        }
    }

}
