using System;
using System.Collections.Generic;
using QuickLog.Models;
using QuickLog.ViewModels;
using Xamarin.Forms;

namespace QuickLog.Views
{
    public partial class MainPage : ContentPage
    {
        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {
            InitializeComponent();

            menuList = new List<MasterPageItem>();

            menuList.Add(new MasterPageItem { Title = "Home", Icon = "", TargetType = typeof(LogDetailViewModel) });

            navigationDrawerList.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(LogDetailViewModel)));
        }
    }
}
