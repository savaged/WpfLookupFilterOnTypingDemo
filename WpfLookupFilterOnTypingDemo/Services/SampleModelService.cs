using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WpfLookupFilterOnTypingDemo.Data;
using WpfLookupFilterOnTypingDemo.Models;

namespace WpfLookupFilterOnTypingDemo.Services
{
    public class SampleModelService : ISampleModelService
    {
        private readonly ILookupService _lookupService;
        private IList<SampleModel> _index;

        public object SampleDatbase { get; }

        public SampleModelService(
            ILookupService lookupService)
        {
            _index = new List<SampleModel>();
            _lookupService = lookupService; 
        }

        public async Task<IList<SampleModel>> GetIndexAsync()
        {
            await Task.Run(() =>
            {
                var dt = SampleDatabase
                    .Default.SampleTable;
                foreach (DataRow r in dt.Rows)
                {
                    var countId = (int)r["CountId"];
                    var m = new SampleModel(
                        (int)r["Id"],
                        (string)r["Name"],
                        countId,
                        _lookupService.GetLookupItem(
                            "NumbersLookup", countId)
                    );
                    _index.Add(m);
                }
            });
            return _index;
        }
    }
}
