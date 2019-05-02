using System.Collections.Generic;
using System.Threading.Tasks;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public interface ISampleModelService
    {
        Task<IList<SampleModel>> GetIndexAsync();
    }
}