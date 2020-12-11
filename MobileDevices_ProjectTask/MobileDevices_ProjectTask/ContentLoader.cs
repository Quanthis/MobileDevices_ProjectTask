using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileDevices_ProjectTask
{
    public class ContentLoader
    {
        private List<FVWord> fVWords;

        public ContentLoader() 
        {
            fVWords = GenerateFVWords();
        }

        private List<FVWord> GenerateFVWords()
        {
            List <FVWord> fVWords = new List<FVWord>();

            fVWords.Add(new FVWord("arise", "arose", "arisen"));
            fVWords.Add(new FVWord("awake", "awoke", "awoken"));
            fVWords.Add(new FVWord("become", "became", "become"));
            fVWords.Add(new FVWord("begin", "began", "begun"));
            fVWords.Add(new FVWord("break", "brokre", "broken"));
            fVWords.Add(new FVWord("bring", "brought", "brought"));
            fVWords.Add(new FVWord("build", "built", "built"));
            fVWords.Add(new FVWord("buy", "bought", "bought"));
            fVWords.Add(new FVWord("catch", "caught", "caught"));

            return fVWords;
        }

        public List<FVWord> GetFVWords()
        {
            return fVWords;
        }

        public List<StackLayout> Fill_Full()
        {
            List<StackLayout> results = new List<StackLayout>();
            uint counter = 0;

            foreach (var element in fVWords)
            {
                Entry infinitive = new Entry
                {
                    Text = element.infinitive,
                    HorizontalOptions = LayoutOptions.Start,
                    WidthRequest = 125,
                    IsReadOnly = true,
                    AutomationId = $"MainPageInfinitiveNo{counter}"
                };

                Entry tense = new Entry
                {
                    Text = element.pastTense,
                    HorizontalOptions = LayoutOptions.Center,
                    WidthRequest = 125,
                    IsReadOnly = true,
                    AutomationId = $"MainPagePastTenseNo{counter}"
                };

                Entry participle = new Entry
                {
                    Text = element.pastParticiple,
                    HorizontalOptions = LayoutOptions.End,
                    WidthRequest = 125,
                    IsReadOnly = true,
                    AutomationId = $"MainPagePastParticipleNo{counter}"
                };

                StackLayout stackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    AutomationId = $"MainPageStackLayoutNo{counter}"
                };

                stackLayout.Children.Add(infinitive);
                stackLayout.Children.Add(tense);
                stackLayout.Children.Add(participle);

                results.Add(stackLayout);

                ++counter;
            }

            return results;
        }
    }
}
