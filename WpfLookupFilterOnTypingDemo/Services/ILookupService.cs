using System.Collections.Generic;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public interface ILookupService
    {
        IDictionary<int, string> GetLookup(string lookupName);
    }
}