using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using SQLite;
using TrafficAlarmPCL;
using TrafficAlarmPCL.Pages;
using TrafficAlarmPCL.Model;

namespace TrafficAlarmPCL
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();
            this.Title = "Alarmes";
            

            var toolbarItemPreferences = new ToolbarItem { Icon = "preferences.png" };
            var toolbarItemAdd = new ToolbarItem { Icon = "add.png" };


            toolbarItemPreferences.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PreferencesPage() { BindingContext = new PreferencesModel() }, true);
            };

            toolbarItemAdd.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new AlarmPage() { BindingContext = new AlarmModel() }, true);
            };

            ToolbarItems.Add(toolbarItemPreferences);
            ToolbarItems.Add(toolbarItemAdd);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

           lvAlarms.ItemsSource = App.Database.GetAlarms();
        }

        async void alarm_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AlarmPage() { BindingContext = e.SelectedItem as AlarmModel });
            }

        }
    }
}

