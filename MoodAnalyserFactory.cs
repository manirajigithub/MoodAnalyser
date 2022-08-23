using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyserUC4
{
    public class MoodAnalyserFactory
    {

        public object Mood_Analyser(string Class, string Constructor)
        {
            string c = @"." + Constructor + "$";
            Match result = Regex.Match(Class, c);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type AnalyserType = assembly.GetType(Class);
                    var res = Activator.CreateInstance(AnalyserType);
                    return res;
                }
                catch (Exception ex)
                {
                    throw new Custom_Exception(Custom_Exception.ExceptionType.NO_SUCH_CLASS, "Can't Found This Class ");
                }
            }

            throw new Custom_Exception(Custom_Exception.ExceptionType.NO_SUCH_CONSTRUCTOR, "Can't Found This Constructor ");

        }

    }
}