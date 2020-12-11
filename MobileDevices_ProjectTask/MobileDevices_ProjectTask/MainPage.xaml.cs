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
            DisableAllRadios();

            uint indexer = 0;
            string input1 = "";
            string input2 = "";

            foreach(StackLayout item in Verbs.Children)
            {
                if(RB_Infinitive.IsChecked)
                {
                    foreach(Entry element in item.Children)
                    {
                        if(element.AutomationId == $"MainPagePastTenseNo{indexer}")
                        {
                            input1 = element.Text;
                        }
                        else if(element.AutomationId == $"MainPagePastParticipleNo{indexer}")
                        {
                            input2 = element.Text;
                        }

                        element.IsReadOnly = true;
                    }

                    if(await content.GetFVWords()[(int)indexer].CheckIfWordSpelledCorrectly(FVWord.WordGiven.infinitive, input1, input2))
                    {
                        item.BackgroundColor = Color.Green;
                    }
                    else
                    {
                        item.BackgroundColor = Color.Red;
                    }
                }

                else if(RB_PastTense.IsChecked)
                {
                    foreach (Entry element in item.Children)
                    {
                        if (element.AutomationId == $"MainPageInfinitiveNo{indexer}")
                        {
                            input1 = element.Text;
                        }
                        else if (element.AutomationId == $"MainPagePastParticipleNo{indexer}")
                        {
                            input2 = element.Text;
                        }

                        element.IsReadOnly = true;
                    }

                    if (await content.GetFVWords()[(int)indexer].CheckIfWordSpelledCorrectly(FVWord.WordGiven.pastTense, input1, input2))
                    {
                        item.BackgroundColor = Color.Green;
                    }
                    else
                    {
                        item.BackgroundColor = Color.Red;
                    }
                }

                else if(RB_PastParticiple.IsChecked)
                {
                    foreach (Entry element in item.Children)
                    {
                        if (element.AutomationId == $"MainPageInfinitiveNo{indexer}")
                        {
                            input1 = element.Text;
                        }
                        else if (element.AutomationId == $"MainPagePastTenseNo{indexer}")
                        {
                            input2 = element.Text;
                        }

                        element.IsReadOnly = true;
                    }

                    if (await content.GetFVWords()[(int)indexer].CheckIfWordSpelledCorrectly(FVWord.WordGiven.pastParticiple, input1, input2))
                    {
                        item.BackgroundColor = Color.Green;
                    }
                    else
                    {
                        item.BackgroundColor = Color.Red;
                    }
                }

                ++indexer;
            }
            indexer = 0;
        }

        private async void ReloadPage(object sender, EventArgs e)
        {
            var ReloadedPage = new MainPage(); Navigation.InsertPageBefore(ReloadedPage, this); 
            await Navigation.PopAsync();
        }

        private async void Enable_InfitiveBase(object sender, EventArgs e)
        {
            DisableRadio();         //because it has 1st index of RadioButtons it seems it must call this method synchronusly

            Verbs.Children.Clear();
            Verbs.ForceLayout();
            TestButton.IsEnabled = true;

            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.infinitive))
            {
                Verbs.Children.Add(item);
            }
        }

        private async void Enable_PastTenseBase(object sender, EventArgs e)
        {
            DisableAllRadios();
            Verbs.Children.Clear();
            Verbs.ForceLayout();
            TestButton.IsEnabled = true;

            foreach (var item in await content.Fill_Partially(FVWord.WordGiven.pastTense))
            {
                Verbs.Children.Add(item);
            }
        }

        private async void Enable_PastParticipleBase(object sender, EventArgs e)
        {
            DisableAllRadios();
            Verbs.Children.Clear();
            Verbs.ForceLayout();
            TestButton.IsEnabled = true;

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

        private void DisableRadio()
        {
            foreach (var element in RadioButtonLayout.Children)
            {
                element.IsEnabled = false;
            }
        }
    }
}
