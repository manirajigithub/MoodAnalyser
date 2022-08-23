using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUC5
{
    public class Custom_Exception : Exception
    {

        public enum Mood
        {
            Empty,
            Null
        }

        public readonly Mood Minfo;

        public Custom_Exception(Mood minfo, string info) : base(info)
        {
            this.Minfo = minfo;
        }


        /// <summary>
        /// Used For Reflection
        /// </summary>
        ExceptionType type;
        public enum ExceptionType
        {
            NULL, EMPTY, NO_SUCH_CLASS, NO_SUCH_CONSTRUCTOR
        }
        public Custom_Exception(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}