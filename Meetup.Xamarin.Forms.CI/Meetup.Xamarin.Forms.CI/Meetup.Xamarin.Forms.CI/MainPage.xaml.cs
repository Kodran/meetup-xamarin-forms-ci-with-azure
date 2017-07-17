using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Service;

namespace Meetup.Xamarin.Forms.CI
{
    public partial class MainPage : ContentPage
    {
        IService api = new Service();
        public MainPage()
        {
            InitializeComponent();
            Init();
        }
        private async void Init()
        {
            var result = await CallWebApi();

            var customerListView = new ListView();
            Device.BeginInvokeOnMainThread(() =>
            {
                customerListView.ItemsSource = result;
                CustomerWrapper.Children.Add(customerListView);
            });
        }

        public async Task<List<string>> CallWebApi()
        {
            var customers = await api.GetCustomerAll();
            return customers;
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            SetNewData();
        }

        private async void SetNewData()
        {
            var result = await CallWebApi();
            var customerListView = new ListView();
            Device.BeginInvokeOnMainThread(() =>
            {
                customerListView.ItemsSource = result;
            });
        }
    }
}
