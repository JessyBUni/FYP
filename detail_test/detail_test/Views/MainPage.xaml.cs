using detail_test.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace detail_test.Views
{
  
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        static public int Prog;
        static public int Sub;
        static public string SC;

        public MainPage( int Progress, int subLevel, string ServerCon)
        {
            Prog=Progress;
            Sub = subLevel;
            SC = ServerCon;

            InitializeComponent();
            //Application.Current.MainPage = this;
            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage) Detail);
            //MenuPages.Add((int)MenuItemType.About, (NavigationPage)Detail);
            //MenuPages.Add((int)MenuItemType.Settings, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            //if (!MenuPages.ContainsKey(id))
            //{
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        Detail = new NavigationPage(new ItemsPage( ));
                       // MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        Detail = new NavigationPage(new AboutPage());
                        //MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Settings:
                        Detail = new NavigationPage(new SettingsPage());
                        //MenuPages.Add(id, new NavigationPage(new SettingsPage()));
                        break;
                }
            //}

           /* var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;*/

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
           // }
        }
    }
}