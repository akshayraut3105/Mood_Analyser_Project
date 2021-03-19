using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModdAnalayser;
using ModdAnalayser;
using Mood_Analyse;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("ModdAnalayger.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("ModdAnalayger.MoodAnalyser", "MoodAnalyser", "SAD");
            expected.Equals(obj);
        }

    }
}
