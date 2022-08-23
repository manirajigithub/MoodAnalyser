 using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserUC5;


namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        string Null = "Its Null";
        string Empty = "Its Empty";



        [TestMethod]
        public void checkEmptyMood()
        {
            //To check the test case 
            //If Empty it return Empty message
            MoodAnalyse test1 = new MoodAnalyse("");
            var res1 = test1.AnalyseEmptyMood();
            string Exp1 = Empty;
            Assert.AreEqual(Exp1, res1);
        }
        [TestMethod]
        public void checkNullMood()
        {
            //To check the test case 
            //If Null it return Null message
            MoodAnalyse test2 = new MoodAnalyse(null);
            var res2 = test2.AnalyseNullMood();
            string Exp2 = Null;
            Assert.AreEqual(Exp2, res2);


        }



        [TestMethod]

        //The data in the row is null
        // Created using DataRow object.
        [DataRow(null)]
        
        public void checkMood(string info)
        {
            //To check the test case 
            //If null it return happy
            MoodAnalyse test = new MoodAnalyse(info);
            var res = test.AnalyseMood();
            Assert.AreEqual("happy", res);
        }
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

        /// <summary>
        /// Use Reflection to Create MoodAnalyser with default Constructor
        /// </summary>
       
        
        [TestMethod]
        public void No_Such_Class()
        {
            string exp = "Can't Found This Class ";
            object obj = null;
            try
            {
                MoodAnalyserFactory test = new MoodAnalyserFactory();
                obj = test.Mood_Analyser("MoodAnalyser.MoodAnalyse", "MoodAnalyse");

            }
            catch (Custom_Exception Ex)

            {
                Assert.AreEqual(exp, Ex.Message);
            }
        }
      
        [TestMethod]
        public void No_Such_Constructor()
        {
            string expected = "Can't Found This Constructor ";
            object obj = null;
            try
            {
                MoodAnalyserFactory test = new MoodAnalyserFactory();
                obj = test.Mood_Analyser("MoodAnalyser.MoodAnalyser", "MoodAnalyse");

            }
            catch (Custom_Exception Ex)
            {
                Assert.AreEqual(expected,Ex.Message);
            }
        }


        /// <summary>
        /// Use Reflection to Create MoodAnalyser with Parameter Constructor
        /// </summary>
        [TestMethod]
        public void Check_Parameterized_Constructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.MoodAnalyserParameter("MoodAnalyser.MoodAnalyse", "Mood_Analyser", message);

            }
            catch (Custom_Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            actual.Equals(expected);
        }
        //Invalid case
        [TestMethod]
        public void Check_Class_Error()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.MoodAnalyserParameter("MoodAnalyser.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (Custom_Exception Ex)
            {
                Assert.AreEqual(expected, Ex.Message);
            }
        }
    }
}
