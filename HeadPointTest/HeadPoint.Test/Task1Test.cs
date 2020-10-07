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
            var input = new List<string>() { "���", "����", "���", "����", "���", "�����", "���" };

            var actualOutput = Resolver.GetGroupOfWords(input);
            var expectedOutput = new List<List<string>>
            {
                new List<string>{ "���", "���", "���" },
                new List<string>{ "����","����" },
                new List<string>{ "�����" },
                new List<string>{ "���" }
            };

            Assert.AreEqual(expectedOutput, actualOutput);
        }        
    }
}