using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
