using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC2
{
    public class MoodAnalyse
    {

        public string Info;
        public MoodAnalyse(string info)
        {
            this.Info = info;
        }
        public string AnalyseMood()
        {
            try
            {
                if (Info.Contains("sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "sad";
                }
                else
                {

                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }


        }
    }
}
}