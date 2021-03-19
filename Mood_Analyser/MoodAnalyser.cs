using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ModdAnalayser
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string analyseMoodLive1()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }

    }

    [Serializable]
    internal class MoodAnalyserCustomException : Exception
    {
        private object eMPTY_MESSAGE;
        private string v;

        public MoodAnalyserCustomException()
        {
        }

        public MoodAnalyserCustomException(string message) : base(message)
        {
        }

        public MoodAnalyserCustomException(object eMPTY_MESSAGE, string v)
        {
            this.eMPTY_MESSAGE = eMPTY_MESSAGE;
            this.v = v;
        }

        public MoodAnalyserCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}