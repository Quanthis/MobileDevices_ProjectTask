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

        private async void Enable_InfitiveBase(object sender, EventArgs e)
        {
            Verbs.Children.Clear();
            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.infinitive))
            {
                Verbs.Children.Add(item);
            }
        }

        private async void Enable_PastTenseBase(object sender, EventArgs e)
        {
            Verbs.Children.Clear();
            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.pastTense))
            {
                Verbs.Children.Add(item);
            }
        }

        private async void Enable_PastParticipleBase(object sender, EventArgs e)
        {
            Verbs.Children.Clear();
            foreach(var item in await content.Fill_Partially(FVWord.WordGiven.pastParticiple))
            {
                Verbs.Children.Add(item);
            }
        }
    }
}
