using MoodAnalyserUC2;
namespace MoodAnalyserUC2
{
    class program
    {
        public static void Main(string[] args)
        {



            Console.WriteLine("Welcome to Mood Analyser program");



            MoodAnalyser check = new MoodAnalyser("msg");
            Console.WriteLine(check.AnalyseMood("I am sad"));
            Console.WriteLine(check.AnalyseMood("I am happy"));


            MoodAnalyser check1 = new MoodAnalyser("msg");
            check1.AnalyseAnyMood("I am in any mood");
        }
    }
}
