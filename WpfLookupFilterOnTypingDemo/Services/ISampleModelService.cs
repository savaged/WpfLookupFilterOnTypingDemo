using System.Collections.Generic;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public interface ISampleModelService
    {
        IList<SampleModel> Index();
        SampleModel Show(int id);
    }
}