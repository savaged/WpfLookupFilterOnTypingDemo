using System.Collections.Generic;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public class LookupService : ILookupService
    {
        private readonly IDictionary<string, IDictionary<int, string>> _index;

        public LookupService()
        {
            _index = new Dictionary<string, IDictionary<int, string>>
            {
                {
                    "NumbersLookup",
                    new Dictionary<int, string>
                    {
                        { 1, "One" },
                        { 2, "Two" },
                        { 3, "Three" },
                        { 4, "Four" },
                        { 5, "Five" },
                        { 6, "Six" }
                    }
                },
            };
        }

        public IDictionary<int, string> GetLookup(string lookupName)
        {
            var value = _index[lookupName];
            return value;
        }

        public ILookupItem GetLookupItem(string lookupName, int key)
        {
            var lookup = GetLookup(lookupName);
            var value = new LookupItem(key, lookup);
            return value;
        }
    }
}
