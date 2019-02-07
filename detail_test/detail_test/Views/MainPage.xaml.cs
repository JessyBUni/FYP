using detail_test.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace detail_test.Views
{
  
    public class DataStore
    {
        public int Progress { get; set; }
        public int Subscription { get; set; }
        public string ServerConn { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        DataStore Info = new DataStore();
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage( int Progress, int subLevel, string ServerCon)
        {
            Info.Progress=Progress;
            Info.Subscription = subLevel;
            Info.ServerConn = ServerCon;

            InitializeComponent();
            //Application.Current.MainPage = this;
            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage) Detail);
            //MenuPages.Add((int)MenuItemType.About, (NavigationPage)Detail);
            //MenuPages.Add((int)MenuItemType.Settings, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                    
                        //var itemspage = new ItemsPage();
                   
                        //MenuPages.Add(id, new NavigationPage(itemspage));
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Settings:
                        MenuPages.Add(id, new NavigationPage(new SettingsPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}