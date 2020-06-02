using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Apress_Navigation
{
    public class DrilldownTableView : ContentPage
    {

        public DrilldownTableView()
        {

            Command<Type> navigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await this.Navigation.PushAsync(page);
            });

            this.Title = "Drilldown List Using TableView";

            var tableView = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Hindi")
                    {
                        new TextCell
                        {
                            Text = "Prathama",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text = "Dusarã",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell
                        {
                            Text = "Tisarã",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        }
                    },
                    new TableSection("Español")
                    {
                        new TextCell
                        {
                            Text = "Primeiro",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },

                        new TextCell
                        {
                            Text = "Segundo",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },

                        new TextCell
                        {
                            Text = "Terceira",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        }
                    },
                    new TableSection("English")
                    {
                        new TextCell
                        {
                            Text = "First",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },

                        new TextCell
                        {
                            Text = "Second",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },

                        new TextCell
                        {
                            Text = "Third",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        }


                    }
                },

            };


            Content = new StackLayout
            {
                Children = {
                    tableView
                }
            };
        }
    }
}