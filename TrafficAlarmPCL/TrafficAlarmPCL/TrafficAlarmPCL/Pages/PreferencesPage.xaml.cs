using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrafficAlarmPCL.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreferencesPage : ContentPage
    {
        public PreferencesPage()
        {
            InitializeComponent();

            var refreshTimesList = new List<string>();
            refreshTimesList.Add("5 min");
            refreshTimesList.Add("15 min");
            refreshTimesList.Add("30 min");
            refreshTimesList.Add("1 hora");
            refreshTimes.ItemsSource = refreshTimesList;

            var thresholdTimesList = new List<string>();
            thresholdTimesList.Add("1 hora");
            thresholdTimesList.Add("2 horas");
            thresholdTimesList.Add("3 horas");
            thresholdTimes.ItemsSource = thresholdTimesList;

            var setupTimesList = new List<string>();
            setupTimesList.Add("15 min");
            setupTimesList.Add("30 min");
            setupTimesList.Add("45 min");
            setupTimesList.Add("1 hora");
            setupTimesList.Add("1:30h");
            setupTimes.ItemsSource = setupTimesList;

            var calculationMethodsList = new List<string>();
            calculationMethodsList.Add("Carro");
            calculationMethodsList.Add("Bicicleta");
            calculationMethods.ItemsSource = calculationMethodsList;
        }
    }
}