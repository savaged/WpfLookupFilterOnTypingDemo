using System.Collections.Generic;
using System.Linq;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public class SampleModelService : ISampleModelService
    {
        private IList<SampleModel> _index;

        public SampleModelService()
        {
            _index = new List<SampleModel>
            {
                new SampleModel { Id = 1, Name = "Apple", CountId = 2 },
                new SampleModel { Id = 2, Name = "Pear", CountId = 4 },
                new SampleModel { Id = 3, Name = "Orange", CountId = 1 }
            };
        }

        public SampleModel Show(int id)
        {
            var value = _index.SingleOrDefault(s => s.Id == id);
            return value;
        }

        public IList<SampleModel> Index()
        {
            return _index;
        }
    }
}
