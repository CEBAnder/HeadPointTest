using System.Collections.Generic;
using System.Linq;

namespace HeadPointTest.Task1
{
    public class Resolver
    {
        public static List<List<string>> GetGroupOfWords(IEnumerable<string> inputWords)
        {
            var map = new Dictionary<string, List<string>>();

            foreach (var word in inputWords)
            {
                var key = string.Concat(word.ToLower().OrderBy(c => c));
                if (!map.TryGetValue(key, out var existing))
                {
                    existing = new List<string>();
                }
                existing.Add(word);
                map[key] = existing;
            }

            return map.Values.ToList();
        }
    }
}
