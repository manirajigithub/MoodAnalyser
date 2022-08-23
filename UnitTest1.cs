using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMoodhappy()
        {
            MoodAnalyser m = new MoodAnalyser("msg");
            var res = m.AnalyseMood("I am happy");
            Assert.AreEqual("happy", res);


        }


        [TestMethod]
        public void CheckMoodAny()
        {
            var m1 = new MoodAnalyser("msg");
            var res1 = m1.AnalyseAnyMood("I am in any mood");


            Assert.AreEqual("happy", res1);
        }
    }
}