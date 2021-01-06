using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TicTakTok
{
    class Core
    {
        private AppDisplay _display;
        //Save already loaded pages to entered data can be preserved
        private Dictionary<string, object> Pages;
        public Core(AppDisplay StartUpGUI)
        {
            this._display = StartUpGUI;
            this.Pages = new Dictionary<string, object>();
        }
        //Manipulate and Save Data
        //Calculate Interactions

        public void ViewChange(string Name = "Home")
        {
            bool isCached = Pages.ContainsKey(Name);
            if (false == isCached)
            {
                //DataConext not working
                object Content = null;
                switch (Name)
                {
                    case "Game":
                        Content = new Views.Game() { DataContext = new Model._GameViewModel() };
                        break;
                    case "Home":
                        Content = new Views.Home() { DataContext = new Model._HomeViewModel() };
                        break;
                    default:
                        //error handling
                        Content = new Views.Error() { DataContext = new Model.ErrorViewModel() };
                        break;
                }
                Pages.Add(Name, Content);
            }
            this._display.Navigate(Pages[Name]);
        }
    }
}
