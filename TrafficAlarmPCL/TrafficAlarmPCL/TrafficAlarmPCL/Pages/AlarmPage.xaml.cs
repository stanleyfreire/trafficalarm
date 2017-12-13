using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrafficAlarmPCL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlarmPage : ContentPage
    {
        public AlarmPage()
        {
            
            InitializeComponent();
            
        }

        async void Save_Clicked(object sender, System.EventArgs e)
        {
            

            var alarmItem = (AlarmModel)BindingContext;

            string datePicked = Convert.ToDateTime(alarmItem.DatePicked.Date).ToString("MM-dd-yyyy");
            string timePicked = String.Format("{0}:{1}:{2}", alarmItem.TimePicked.Hours.ToString(), alarmItem.TimePicked.Minutes.ToString(), alarmItem.TimePicked.Seconds.ToString());
            alarmItem.ArrivalTime = Convert.ToDateTime(String.Format("{0} {1}", datePicked, timePicked));
            alarmItem.LeavingTime = DateTime.Now;

            App.Database.SaveAlarm(alarmItem);
            await Navigation.PopAsync();
        }

        
        async void Delete_Clicked(object sender, System.EventArgs e)
        {
            var alarmItem = (AlarmModel)BindingContext;
            App.Database.DeleteAlarm(alarmItem);
            await Navigation.PopAsync();
        }
    }
}
