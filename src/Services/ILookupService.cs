using System.Collections.Generic;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public interface ILookupService
    {
        IDictionary<int, string> GetLookup(string lookupName);

        ILookupItem GetLookupItem(string lookupName, int key);
    }
}