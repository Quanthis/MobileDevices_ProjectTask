using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

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
            List<FVWord> fVWords = new List<FVWord>
            {
                new FVWord("arise", "arose", "arisen"),
                new FVWord("awake", "awoke", "awoken"),

                new FVWord("become", "became", "become"),
                new FVWord("begin", "began", "begun"),
                new FVWord("bear", "bore", "borne"),
                new FVWord("break", "broke", "broken"),
                new FVWord("beat", "beat", "beaten"),
                new FVWord("bend", "bent", "bent"),
                new FVWord("beset" , "beset", "beset"),
                new FVWord("bet", "bet", "bet"),
                new FVWord("bid", "bid", "bid"),
                new FVWord("bind", "bound", "bound"),
                new FVWord("bite", "bit", "bitten"),
                new FVWord("bleed", "bled", "bled"),
                new FVWord("blow", "blew", "blown"),
                new FVWord("breed", "bred", "bred"),
                new FVWord("bring", "brought", "brought"),
                new FVWord("broadcast", "broadcast", "broadcast"),
                new FVWord("build", "built", "built"),
                new FVWord("burn", "burnt", "burnt"),
                new FVWord("burst", "burst", "burst"),
                new FVWord("buy", "bought", "bought"),

                new FVWord("cast", "cast", "cast"),
                new FVWord("catch", "caught", "caught"),
                new FVWord("choose", "chose", "chosen"),
                new FVWord("cling", "clung", "clung"),
                new FVWord("come", "came", "come"),
                new FVWord("cost", "cost", "cost"),
                new FVWord("creep", "crept", "crept"),
                new FVWord("cut", "cut", "cut"),

                new FVWord("deal", "dealt", "dealt"),
                new FVWord("dig", "dug", "dug"),
                new FVWord("dive", "dove", "dived"),
                new FVWord("do", "did", "done"),
                new FVWord("draw", "drew", "drawn"),
                new FVWord("dream", "dreamt", "dreamt"),
                new FVWord("drink", "drank", "drunk"),
                new FVWord("drive", "drowe", "driven"),

                new FVWord("eat", "ate", "eaten")
            };

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

        public async Task<List<StackLayout>> Fill_Partially(FVWord.WordGiven baseForm)
        {
            return await Task.Run(() =>
            {
                List<StackLayout> results = new List<StackLayout>();
                results.Clear();

                uint counter = 0;

                switch (baseForm)
                {
                    case FVWord.WordGiven.infinitive:                        

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
                                Text = "",
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 125,
                                IsReadOnly = false,
                                AutomationId = $"MainPagePastTenseNo{counter}"
                            };

                            Entry participle = new Entry
                            {
                                Text = "",
                                HorizontalOptions = LayoutOptions.End,
                                WidthRequest = 125,
                                IsReadOnly = false,
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

                    case FVWord.WordGiven.pastTense:

                        foreach (var element in fVWords)
                        {
                            Entry infinitive = new Entry
                            {
                                Text = "",
                                HorizontalOptions = LayoutOptions.Start,
                                WidthRequest = 125,
                                IsReadOnly = false,
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
                                Text = "",
                                HorizontalOptions = LayoutOptions.End,
                                WidthRequest = 125,
                                IsReadOnly = false,
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

                    case FVWord.WordGiven.pastParticiple:

                        foreach (var element in fVWords)
                        {
                            Entry infinitive = new Entry
                            {
                                Text = "",
                                HorizontalOptions = LayoutOptions.Start,
                                WidthRequest = 125,
                                IsReadOnly = false,
                                AutomationId = $"MainPageInfinitiveNo{counter}"
                            };

                            Entry tense = new Entry
                            {
                                Text = "",
                                HorizontalOptions = LayoutOptions.Center,
                                WidthRequest = 125,
                                IsReadOnly = false,
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

                    default: return results;
                }         
            });
        }
    }
}
