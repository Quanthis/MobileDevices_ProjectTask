using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileDevices_ProjectTask
{
    public class FVWord                              //FVWord - full varation word
    {
        public readonly string infinitive;
        public readonly string pastTense;
        public readonly string pastParticiple;

        public enum WordGiven
        {
            infinitive,
            pastTense,
            pastParticiple
        };

        public FVWord(string invinitife, string pastTense, string pastParticiple)
        {
            this.infinitive = invinitife;
            this.pastTense = pastTense;
            this.pastParticiple = pastParticiple;
        }

        public async Task<bool> CheckIfWordSpelledCorrectly(WordGiven wordGiven, string inputForm1, string inputForm2)
        {
            return await Task.Run(()=>
            {
                switch (wordGiven)
                {
                    case WordGiven.infinitive:

                        if (pastTense == inputForm1 && pastParticiple == inputForm2)
                        {
                            return true;
                        }
                        else return false;

                    case WordGiven.pastTense:

                        if (infinitive == inputForm1 && pastParticiple == inputForm2)
                        {
                            return true;
                        }
                        else return false;

                    case WordGiven.pastParticiple:

                        if (infinitive == inputForm1 && pastTense == inputForm2)
                        {
                            return true;
                        }
                        else return false;

                    default: return false;
                }
            });
        }
    }
}
