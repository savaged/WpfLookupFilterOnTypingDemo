using System.Collections.Generic;
using System.Threading.Tasks;
using WpfLookupFilterOnTypingDemo.Models;
using WpfLookupFilterOnTypingDemo.Services;

namespace WpfLookupFilterOnTypingDemo.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private readonly ISampleModelService _modelService;
        
        private SampleModel _selectedModel;

        public MainViewModel(
            ISampleModelService modelService,
            ILookupService lookupService)
        {
            _modelService = modelService;

            NumbersLookup = lookupService
                .GetLookup(nameof(NumbersLookup));

            Index = new List<SampleModel>();
        }

        public async Task LoadAsync()
        {
            var index = await 
                _modelService.GetIndexAsync();
            foreach (var model in index)
            {
                Index.Add(model);
            }
        }
        
        public IList<SampleModel> Index { get; }

        public IDictionary<int, string> NumbersLookup { get; }        

        public SampleModel SelectedModel
        {
            get => _selectedModel;
            set
            {
                _selectedModel = value;
                RaisePropertyChanged();
            }
        }
    }
}
