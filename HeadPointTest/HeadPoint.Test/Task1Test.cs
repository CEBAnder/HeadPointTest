using HeadPointTest.Task1;
using NUnit.Framework;
using System.Collections.Generic;

namespace HeadPoint.Test
{
    public class Task1Test
    {        
        [Test]
        public void GetGroupOfWords_CasualWords_CorrectGroups()
        {
            var input = new List<string>() { "ток", "рост", "кот", "торс", " то", "фывап", "рок" };

            var actualOutput = Resolver.GetGroupOfWords(input);
            var expectedOutput = new List<List<string>>
            {
                new List<string>{ "ток", "кот", " то" },
                new List<string>{ "рост","торс" },
                new List<string>{ "фывап" },
                new List<string>{ "рок" }
            };

            Assert.AreEqual(expectedOutput, actualOutput);
        }        
    }
}