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
            var ReloadedPage = new MainPage(); Navigation.InsertPageBefore(ReloadedPage, this); 
            await Navigation.PopAsync();
        }

        private async void Enable_InfitiveBase(object sender, EventArgs e)
        {
            Verbs.Children.Clear();
            Verbs.ForceLayout();
            DisableAllRadios();

            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.infinitive))
            {
                Verbs.Children.Add(item);
            }
        }

        private async void Enable_PastTenseBase(object sender, EventArgs e)
        {
            Verbs.Children.Clear();
            Verbs.ForceLayout();
            DisableAllRadios();

            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.pastTense))
            {
                Verbs.Children.Add(item);
            }
        }

        private async void Enable_PastParticipleBase(object sender, EventArgs e)
        {
            Verbs.Children.Clear();
            Verbs.ForceLayout();
            DisableAllRadios();

            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.pastParticiple))
            {
                Verbs.Children.Add(item);
            }
        }

        private async Task DisableAllRadios()
        {
            await Task.Run(() =>
            {
                foreach (var element in RadioButtonLayout.Children)
                {
                    element.IsEnabled = false;
                }
            });
        }
    }
}
