using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileDevices_ProjectTask
{
    public partial class MainPage : ContentPage
    {
        private ContentLoader content;

        public MainPage()
        {
            InitializeComponent();
            content = new ContentLoader();
            
            foreach(var item in content.Fill_Full())
            {
                Verbs.Children.Add(item);
            }
        }

        

        private async void PerformCheck(object sender, EventArgs e)
        {

        }

        private async void ReloadPage(object sender, EventArgs e)
        {

        }
    }
}
