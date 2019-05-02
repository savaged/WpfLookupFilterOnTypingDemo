using System.Collections.Generic;
using System.Data;
using System.Linq;
using WpfLookupFilterOnTypingDemo.Data;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public class SampleModelService : ISampleModelService
    {
        private IList<SampleModel> _index;

        public object SampleDatbase { get; }

        public SampleModelService(
            ILookupService lookupService)
        {
            _index = new List<SampleModel>();
            var dt = SampleDatabase.Default.SampleTable;
            foreach (DataRow r in dt.Rows)
            {
                var countId = (int)r["CountId"];
                var m = new SampleModel(
                    (int)r["Id"],
                    (string)r["Name"],
                    countId,
                    lookupService
                        .GetLookupItem("NumbersLookup", countId)
                );
                _index.Add(m);                
            }
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
