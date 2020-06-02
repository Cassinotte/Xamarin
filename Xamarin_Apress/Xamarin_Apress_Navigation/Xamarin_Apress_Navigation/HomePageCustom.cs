using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class HomePageCustom : ContentPage
    {
        public HomePageCustom()
        {
            Command<Type> navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Xamarin.Forms Navigation";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                    {
                        new TableSection("Chapter 6 examples")
                        {
                            new TextCell
                            {
                                Text = "Hierarchical Navigation Using NavigationPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(NavigationPage1)
                            },

                            new TextCell
                            {
                                Text = "Dropdown Menu Using ToolbarItems",
                                Command = navigateCommand,
                                CommandParameter = typeof(DropdowMenu)
                            },

                            new TextCell
                            {
                                Text = "Modal Navigation Using NavigationPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(ModalPage)
                            },

                            new TextCell
                            {
                                Text = "Alerts Using DisplayAlert",
                                Command = navigateCommand,
                                CommandParameter = typeof(Alert)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using ListView by Item",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownListViewByItem)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using ListView by Page",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownListViewByPage)
                            },

                            new TextCell
                            {
                                Text = "Drilldown TableView for Grouping",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownTableView)
                            },

                            new TextCell
                            {
                                Text = "Popup Menu Using ActionSheet",
                                Command = navigateCommand,
                                CommandParameter = typeof(PopupMenu)
                            },

                            new TextCell
                            {
                                Text = "Disk Persistence Using the Properties Dictionary",
                                Command = navigateCommand,
                                CommandParameter = typeof(PropertiesPage1)
                            },

                            new TextCell
                            {
                                Text = "Using a Static Global Class",
                                Command = navigateCommand,
                                CommandParameter = typeof(GlobalPage1)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using ListView by Page",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownListViewByPage)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using TableView",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownTableView)
                            },

                            new TextCell
                            {
                                Text = "Tabs Using TabbedPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(TabPage)
                            },

                            new TextCell
                            {
                                Text = "Data-bound Tabs Using TabbedPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(TabPageDatabound)
                            },

                            new TextCell
                            {
                                Text = "Springboard Using Grid",
                                Command = navigateCommand,
                                CommandParameter = typeof(Springboard)
                            },
                            new TextCell
                            {
                                Text = "Carousel Using CarouselPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(Carousel)
                            }

                        }

                    }
            };
        }
    }
}